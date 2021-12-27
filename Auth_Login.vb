
Public Class Auth_Login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_login_username.Text <> "" And txt_login_password.Text <> "" Then
            If txt_login_username.Text.Contains("'") Then
                message("error", "Unexpeted Character (') in username")
                txt_login_username.Focus()
            Else
                Try
                    sql_da = New MySqlDataAdapter("SELECT * FROM user WHERE Username = '" & txt_login_username.Text & "'", sql_con)
                    sql_dt = New DataTable
                    sql_dt.Clear()
                    sql_da.Fill(sql_dt)
                    If sql_dt.Rows.Count() > 0 Then
                        login_id = sql_dt.Rows(0).Item("Employee_ID").ToString()

                        If StrComp(txt_login_username.Text, sql_dt.Rows(0).Item("Username").ToString(), CompareMethod.Binary) _
                        Or StrComp(txt_login_password.Text, Decoding(sql_dt.Rows(0).Item("Password").ToString()), CompareMethod.Binary) Then
                            invalid_login_counter()
                        Else
                            sql_da = New MySqlDataAdapter("SELECT * FROM employee WHERE ID = '" & login_id & "'", sql_con)
                            sql_dt = New DataTable
                            sql_dt.Clear()
                            sql_da.Fill(sql_dt)
                            login_full_name = sql_dt.Rows(0).Item("First_Name").ToString() & " " & sql_dt.Rows(0).Item("Other_Name").ToString() & " " & sql_dt.Rows(0).Item("Last_Name").ToString()
                            login_as = sql_dt.Rows(0).Item("Role").ToString()
                            login_first_name = sql_dt.Rows(0).Item("First_Name").ToString()
                            If sql_dt.Rows(0).Item("Active").ToString() = True Then
                                Access_Control(login_as)
                            Else
                                message("warning", "Employee is deactivated, contact Administrator")
                                txt_login_username.Focus()
                            End If
                        End If
                    Else
                        invalid_login_counter()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        ElseIf txt_login_username.Text = "" Then
            message("warning", "Username Feild is Empty")
            txt_login_username.Focus()
        ElseIf txt_login_password.Text = "" Then
            message("warning", "Password Feild is Empty")
            txt_login_password.Focus()
        End If
    End Sub
    Public Sub invalid_login_counter()
        invalid_login += 1
        If invalid_login = 0 Then
            lbl_attempts.Text = "Attempts: 0/3"
        ElseIf invalid_login = 1 Then
            lbl_attempts.Text = "Attempts: 1/3"
            message("warning", "Invalid username or password. You are left with 2 attemps.")
            txt_login_username.Focus()
        ElseIf invalid_login = 2 Then
            lbl_attempts.Text = "Attempts: 2/3"
            message("warning", "Invalid username or password . You are left with 1 attemp.")
            txt_login_username.Focus()
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
            message("warning", "You are out of attemps. Try again after 3 munites.")
            txt_login_username.Focus()
        End If
    End Sub
    Public Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click
        txt_login_username.Clear()
        txt_login_password.Clear()
        With Auth_Signup
            .lbl_signup_title.Text = "SignUP"
            .txt_signup_email.Clear()
            .txt_signup_email.Focus()
            .txt_signup_username.Clear()
            .txt_signup_password.Clear()
            .txt_signup_confirm_password.Clear()
            .txt_signup_email.Enabled = True
            .txt_signup_username.Enabled = False
            .txt_signup_password.Enabled = False
            .txt_signup_confirm_password.Enabled = False
            .signup_middle_panel.Visible = False
            .signup_notice_panel.Visible = True
            .btn_signup_verify_create.Text = "VERIFY"
        End With
        auth_form_loader(Auth_Signup)
    End Sub

    Private Sub lbl_password_reset_Click(sender As Object, e As EventArgs) Handles lbl_password_reset.Click
        With Auth_Password_Reset
            .txt_password_reset_email.Clear()
            .txt_password_reset_email.Focus()
        End With
        auth_form_loader(Auth_Password_Reset)
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