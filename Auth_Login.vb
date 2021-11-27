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
                                    Management.btn_home_Click(Management.btn_home, EventArgs.Empty)
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
                        invalid_login += 1
                        If invalid_login = 0 Then
                            lbl_attempts.Text = "Attempts: 0/3"
                        ElseIf invalid_login = 1 Then
                            lbl_attempts.Text = "Attempts: 1/3"
                        ElseIf invalid_login = 2 Then
                            lbl_attempts.Text = "Attempts: 2/3"
                        ElseIf invalid_login > 2 Then
                            lbl_attempts.Text = "Attempts: 3/3"
                            btn_signup.Hide()
                            btn_login.Hide()
                            txt_login_password.Enabled = False
                            txt_login_username.Enabled = False
                            txt_login_username.Clear()
                            txt_login_password.Clear()
                            txt_invalid_display.Show()
                            invalid_login_ts = New TimeSpan(0, 2, 59)
                            invalid_login_timer.Enabled = True
                            Auth.btn_auth_message.Text = "You are out of attemps"
                            Auth.btn_auth_message.Show()
                            message(Auth.btn_auth_message, "warning")
                        End If
                    End If
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

    Public Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click
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

    Private Sub lbl_password_reset_Click(sender As Object, e As EventArgs) Handles lbl_password_reset.Click, txt_invalid_display.Click
        auth_form_loader(Auth_Password_Reset)
        With Auth_Password_Reset
            .txt_password_reset_email.Clear()
            .txt_password_reset_code.Clear()
            .btn_password_reset_reset.Enabled = False
            .btn_password_reset_send_code.Enabled = True
            .btn_password_reset_send_code.Text = "SEND CODE"
            .btn_password_reset_send_code.BackColor = Color.DarkTurquoise
            .txt_password_reset_email.Enabled = True
            .txt_password_reset_code.Enabled = False
            .txt_password_reset_email.Focus()
        End With
    End Sub

    Private Sub invalid_login_timer_Tick(sender As Object, e As EventArgs) Handles invalid_login_timer.Tick
        If invalid_login_ts.Minutes = 0 AndAlso invalid_login_ts.Seconds = 0 Then
            txt_invalid_display.Hide()
            btn_login.Show()
            btn_signup.Show()
            txt_login_password.Enabled = True
            txt_login_username.Enabled = True
            txt_login_username.Focus()
            invalid_login_timer.Stop()
            invalid_login = 0
            lbl_attempts.Text = "Attempts: 0/3"
        Else
            invalid_login_ts = invalid_login_ts.Subtract(New TimeSpan(0, 0, 1))
            txt_invalid_display.Text = String.Format("Try Again in  {0} Mins : {1} Secs", invalid_login_ts.Minutes, invalid_login_ts.Seconds)
        End If
    End Sub
End Class