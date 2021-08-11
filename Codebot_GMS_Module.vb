Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
'Imports System.Windows.Forms.DockStyle
'mports System.Windows.Forms.DataGridViewImageColumn
Module Codebot_GMS_Module
    Public sql_con As New MySqlConnection("server=localhost;user id=root;password=@Welcome98;database=codebot_gms_schema;sslMode=none")
    Public sql_rdr As MySqlDataReader
    Public sql_dt As DataTable
    Public sql_da As MySqlDataAdapter
    Public sql_ds As DataSet
    Dim sql_cmd As MySqlCommand

    Public Sub login()
        Try
            sql_con.Close()
            sql_con.Open()
            sql_da = New MySqlDataAdapter("SELECT * FROM user WHERE Username = '" & Auth_Login.txt_login_username.Text & "'", sql_con)
            sql_dt = New DataTable
            sql_dt.Clear()
            sql_da.Fill(sql_dt)
            If sql_dt.Rows.Count() > 0 Then
                If StrComp(Auth_Login.txt_login_username.Text, sql_dt.Rows(0).Item("Username").ToString(), CompareMethod.Binary) _
                       Or StrComp(Auth_Login.txt_login_password.Text, sql_dt.Rows(0).Item("Password").ToString(), CompareMethod.Binary) Then
                    Auth.btn_message.Text = "Invalid Username and Password"
                    Auth.btn_message.Show()
                    Auth.message()
                Else
                    sql_da = New MySqlDataAdapter("SELECT * FROM employee WHERE ID = '" & sql_dt.Rows(0).Item("Employee_ID").ToString() & "'", sql_con)
                    sql_dt = New DataTable
                    sql_dt.Clear()
                    sql_da.Fill(sql_dt)
                    If sql_dt.Rows(0).Item("Active?").ToString() = True Then
                        gms_main_form_loader(Management)
                        Management.sidebar_active(Management.btn_home)
                        sidebar_form_loader(Management_Home)
                        datagrid_fill("employee", Management_Employees.EmployeesDataGridView)
                        Dim login_full_name As String = sql_dt.Rows(0).Item("First_Name").ToString() & " " & sql_dt.Rows(0).Item("Other_Name(s)").ToString() & " " & sql_dt.Rows(0).Item("Last_Name").ToString()
                        Management.login_name.Text = login_full_name
                        Management.login_position.Text = sql_dt.Rows(0).Item("Position").ToString()
                    Else
                        Auth.btn_message.Text = "User is Deactivated, Contact Manager"
                        Auth.btn_message.Show()
                        Auth.message()
                    End If
                End If
            Else
                Auth.btn_message.Text = "User not Found"
                Auth.btn_message.Show()
                Auth.message()
            End If
            sql_con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub gms_main_form_loader(ByVal main_form As Form)
        main_form.TopLevel = False
        main_form.FormBorderStyle = FormBorderStyle.None
        main_form.WindowState = FormWindowState.Maximized
        GMS_Main.GMS_Main_panel.Controls.Add(main_form)
        main_form.Visible = False
        If main_form.Visible = False Then
            Management.Visible = False
            Auth.Visible = False
            main_form.Visible = True
        Else
            main_form.Visible = False
        End If
    End Sub
    Public Sub sidebar_form_loader(ByRef form As Form)
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        Management.management_main_container.Controls.Add(form)
        form.Visible = False
        If form.Visible = False Then
            Management_Employees.Visible = False
            Management_Home.Visible = False
            Management_Employees_Add_New.Visible = False
            Management_Work_Order.Visible = False
            Management_Market.Visible = False
            form.Visible = True
        Else
            form.Visible = False
        End If
    End Sub
    Public Sub auth_form_loader(ByRef auth_form As Form)
        auth_form.TopLevel = False
        auth_form.FormBorderStyle = FormBorderStyle.None
        auth_form.WindowState = FormWindowState.Maximized
        Auth.auth_left_panel.Controls.Add(auth_form)
        auth_form.Visible = False
        If auth_form.Visible = False Then
            Auth_Signup.Visible = False
            Auth_Login.Visible = False
            Auth_Password_Reset.Visible = False
            auth_form.Visible = True
            'Auth.btn_message.Controls. = bringfront
        Else
            auth_form.Visible = False
        End If
    End Sub

    Public Sub datagrid_fill(ByRef default_table As String, ByRef gridview_name As DataGridView)
        sql_con.Close()
        sql_con.Open()
        sql_da = New MySqlDataAdapter("SELECT * FROM " & default_table, sql_con)
        sql_dt = New DataTable
        sql_dt.Clear()
        'sql_ds = New DataSet
        sql_da.Fill(sql_dt)
        gridview_name.DataSource = sql_dt
        sql_con.Close()
    End Sub
End Module
