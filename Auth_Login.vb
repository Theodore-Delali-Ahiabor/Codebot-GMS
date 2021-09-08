Imports MySql.Data.MySqlClient
Public Class Auth_Login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_login_username.Text <> "" And txt_login_password.Text <> "" Then
            If txt_login_username.Text.Contains("'") Then
                Auth.btn_auth_message.Text = "Unexpeted Character ' in username"
                txt_login_username.Focus()
                message(Auth.btn_auth_message, "warning")
            Else
                Try
                    'sql_con.Close()
                    'sql_con.Open()
                    sql_da = New MySqlDataAdapter("SELECT * FROM user WHERE Username = '" & txt_login_username.Text & "'", sql_con)
                    sql_dt = New DataTable
                    sql_dt.Clear()
                    sql_da.Fill(sql_dt)
                    If sql_dt.Rows.Count() > 0 Then
                        login_id = sql_dt.Rows(0).Item("Employee_ID").ToString()

                        If StrComp(txt_login_username.Text, sql_dt.Rows(0).Item("Username").ToString(), CompareMethod.Binary) _
                       Or StrComp(txt_login_password.Text, sql_dt.Rows(0).Item("Password").ToString(), CompareMethod.Binary) Then
                            Auth.btn_auth_message.Text = "Invalid Username or Password"
                            Auth.btn_auth_message.Show()
                            message(Auth.btn_auth_message, "warning")
                        Else
                            sql_da = New MySqlDataAdapter("SELECT * FROM employee WHERE ID = '" & login_id & "'", sql_con)
                            sql_dt = New DataTable
                            sql_dt.Clear()
                            sql_da.Fill(sql_dt)
                            login_full_name = sql_dt.Rows(0).Item("First_Name").ToString() & " " & sql_dt.Rows(0).Item("Other_Name").ToString() & " " & sql_dt.Rows(0).Item("Last_Name").ToString()
                            login_as = sql_dt.Rows(0).Item("Role").ToString()

                            If sql_dt.Rows(0).Item("Active").ToString() = True Then
                                If login_as = "Administrator" Or login_as = "Supervisor" Or login_as = "Manager" Or login_as = "Management Engineer" Or login_as = "Supervising Engineer" Then
                                    gms_main_form_loader(Management)
                                    Management.sidebar_active(Management.btn_home)
                                    Management.lbl_current_tab.Text = "Dashboard | Work Oders Due"
                                    sidebar_form_loader(Management_Home)
                                    Management_Home.activebar_work_orders.Visible = True
                                    Management_Home.work_order_due_soon_Click(Management_Home.work_order_due_soon, EventArgs.Empty)
                                    Management_Home.work_order_overdue_Click(Management_Home.work_order_overdue, EventArgs.Empty)
                                    Management_Home.low_inventory_low_stock_Click(Management_Home.low_inventory_low_stock, EventArgs.Empty)
                                    Management_Home.low_inventory_out_of_stock_Click(Management_Home.low_inventory_out_of_stock, EventArgs.Empty)
                                    work_order_overdue_filter("6")
                                    datagrif_fill_column_resize("work_order_view", Management_Home.HomeDataGridView)
                                    Management.login_position.Text = login_as
                                    Management.login_name.Text = login_full_name

                                    'display some administrative privilages
                                    Management.btn_employees.Visible = True
                                    Management.btn_inventory.Visible = True
                                    Management.btn_statistics.Visible = True
                                    Management.btn_market.Visible = True

                                    Management.btn_management_message.Text = "Login Was Successful"
                                    Management.btn_management_message.Show()
                                    message(Management.btn_management_message, "success")
                                Else
                                    gms_main_form_loader(Management)
                                    Management.sidebar_active(Management.btn_home)
                                    sidebar_form_loader(Management_Home)
                                    datagrid_fill_default("employee", Management_Employees.EmployeesDataGridView)
                                    Management.login_position.Text = login_as
                                    Management.login_name.Text = login_full_name
                                    'hide some administrative privilages
                                    Management.btn_employees.Visible = False
                                    Management.btn_inventory.Visible = False
                                    Management.btn_statistics.Visible = False
                                    Management.btn_market.Visible = False

                                    Management.btn_management_message.Text = "Login Was Successful"
                                    Management.btn_management_message.Show()
                                    message(Management.btn_management_message, "success")
                                End If

                            Else
                                Auth.btn_auth_message.Text = "User is Deactivated, Contact Manager"
                                Auth.btn_auth_message.Show()
                                message(Auth.btn_auth_message, "warning")
                            End If
                        End If
                    Else
                        Auth.btn_auth_message.Text = "Invalid Username or Password"
                        Auth.btn_auth_message.Show()
                        message(Auth.btn_auth_message, "warning")
                    End If
                    'sql_con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf txt_login_username.Text = "" Then
            txt_login_username.Focus()
            Auth.btn_auth_message.Text = "Username Feild is Empty"
            Auth.btn_auth_message.Show()
            message(Auth.btn_auth_message, "warning")
        ElseIf txt_login_password.Text = "" Then
            txt_login_password.Focus()
            Auth.btn_auth_message.Text = "Password Feild is Empty"
            Auth.btn_auth_message.Show()
            message(Auth.btn_auth_message, "warning")
        End If

    End Sub

    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click
        txt_login_username.Clear()
        txt_login_password.Clear()
        Auth_Signup.txt_signup_phone.Clear()
        Auth_Signup.txt_signup_phone.Focus()
        Auth_Signup.txt_signup_username.Clear()
        Auth_Signup.txt_signup_password.Clear()
        Auth_Signup.txt_signup_confirm_password.Clear()
        Auth_Signup.txt_signup_phone.Enabled = True
        Auth_Signup.txt_signup_username.Enabled = False
        Auth_Signup.txt_signup_password.Enabled = False
        Auth_Signup.txt_signup_confirm_password.Enabled = False
        Auth_Signup.signup_middle_panel.Visible = False
        auth_form_loader(Auth_Signup)
        Auth_Signup.btn_signup_verify_create.Text = "VERIFY"
    End Sub

    Private Sub lbl_password_reset_Click(sender As Object, e As EventArgs) Handles lbl_password_reset.Click
        auth_form_loader(Auth_Password_Reset)
        Auth_Password_Reset.txt_password_reset_phone_number.Clear()
        Auth_Password_Reset.txt_password_reset_code.Clear()
        Auth_Password_Reset.btn_password_reset_reset.Enabled = False
        Auth_Password_Reset.btn_password_reset_send_code.Enabled = True
        Auth_Password_Reset.btn_password_reset_send_code.Text = "SEND CODE"
        Auth_Password_Reset.txt_password_reset_phone_number.Enabled = True
        Auth_Password_Reset.txt_password_reset_phone_number.Focus()
    End Sub
End Class