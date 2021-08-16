Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
'Imports System.Windows.Forms.DockStyle
'mports System.Windows.Forms.DataGridViewImageColumn
Module Codebot_GMS_Module
    Public sql_con As New MySqlConnection("server=localhost;user id=root;password=;database=codebot_gms_schema;sslMode=none")
    Public sql_rdr As MySqlDataReader
    Public sql_dt As DataTable
    Public sql_da As MySqlDataAdapter
    Public sql_ds As DataSet
    Public sql_cmd As MySqlCommand
    Public message_ts As TimeSpan
    Public signup_id, signup_name, login_id, login_full_name, login_as As String
    Public Sub login()
        Try
            'sql_con.Close()
            'sql_con.Open()
            sql_da = New MySqlDataAdapter("SELECT * FROM user WHERE Username = '" & Auth_Login.txt_login_username.Text & "'", sql_con)
            sql_dt = New DataTable
            sql_dt.Clear()
            sql_da.Fill(sql_dt)
            If sql_dt.Rows.Count() > 0 Then
                login_id = sql_dt.Rows(0).Item("Employee_ID").ToString()

                If StrComp(Auth_Login.txt_login_username.Text, sql_dt.Rows(0).Item("Username").ToString(), CompareMethod.Binary) _
                       Or StrComp(Auth_Login.txt_login_password.Text, sql_dt.Rows(0).Item("Password").ToString(), CompareMethod.Binary) Then

                Else
                    sql_da = New MySqlDataAdapter("SELECT * FROM employee WHERE ID = '" & login_id & "'", sql_con)
                    sql_dt = New DataTable
                    sql_dt.Clear()
                    sql_da.Fill(sql_dt)
                    login_full_name = sql_dt.Rows(0).Item("First_Name").ToString() & " " & sql_dt.Rows(0).Item("Other_Name").ToString() & " " & sql_dt.Rows(0).Item("Last_Name").ToString()
                    login_as = sql_dt.Rows(0).Item("Position").ToString()
                    Management.login_name.Text = login_full_name
                    If sql_dt.Rows(0).Item("Active").ToString() = True Then
                        If login_as = "Administrator" Or login_as = "Supervisor" Or login_as = "Manager" Or login_as = "Management Engineer" Or login_as = "Supervising Engineer" Then
                            gms_main_form_loader(Management)
                            Management.sidebar_active(Management.btn_home)
                            sidebar_form_loader(Management_Home)
                            datagrid_fill("employee", Management_Employees.EmployeesDataGridView)
                            Management.login_position.Text = login_as

                            Management.btn_management_message.Text = "Login Was Successful"
                            Management.btn_management_message.Show()
                            message(Management.btn_management_message, "success")
                        Else
                            gms_main_form_loader(Management)
                            Management.sidebar_active(Management.btn_home)
                            sidebar_form_loader(Management_Home)
                            datagrid_fill("employee", Management_Employees.EmployeesDataGridView)
                            Management.login_position.Text = login_as
                            'hide some administrative privilages
                            Management.btn_employees.Visible = False
                            Management.btn_inventory.Visible = False
                            Management.btn_statistics.Visible = False
                            Management.btn_market.Visible = False
                        End If

                    Else
                        Auth.btn_auth_message.Text = "User is Deactivated, Contact Manager"
                        Auth.btn_auth_message.Show()
                        message(Auth.btn_auth_message, "warning")
                    End If
                End If
            Else
                Auth.btn_auth_message.Text = "User not Found"
                Auth.btn_auth_message.Show()
                message(Auth.btn_auth_message, "warning")
            End If
            'sql_con.Close()
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
        'sql_con.Close()
        'sql_con.Open()
        sql_da = New MySqlDataAdapter("SELECT * FROM " & default_table, sql_con)
        sql_dt = New DataTable
        sql_dt.Clear()
        'sql_ds = New DataSet
        sql_da.Fill(sql_dt)
        gridview_name.DataSource = sql_dt
        'sql_con.Close()
    End Sub

    Public Sub datagrid_filter(ByRef filter_table As String, ByRef gridview_name As DataGridView)

    End Sub

    Public Sub clear_all_forms()

    End Sub
    Public Sub message(ByRef btn_name As Button, ByRef message_type As String)
        If message_type = "warning" Then
            btn_name.Show()
            btn_name.BackColor = Color.LightCoral
            btn_name.ForeColor = Color.WhiteSmoke


            Auth.message_timer.Enabled = True
            message_ts = New TimeSpan(0, 0, 3)
        ElseIf message_type = "success" Then
            btn_name.Show()
            btn_name.BackColor = Color.PaleGreen
            btn_name.ForeColor = Color.Green
            Auth.message_timer.Enabled = True
            message_ts = New TimeSpan(0, 0, 3)
        ElseIf message_type = "information" Then
            btn_name.Show()
            btn_name.BackColor = Color.LightBlue
            btn_name.ForeColor = Color.Blue
            Auth.message_timer.Enabled = True
            message_ts = New TimeSpan(0, 0, 3)
        End If
    End Sub
End Module
