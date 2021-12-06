Imports MySql.Data.MySqlClient
Imports System.Net.Mail
'Imports Amazon.SimpleNotificationService
'Imports Amazon.SimpleNotificationService.Model
Public Class Auth_Password_Reset
    Public reset_id As String
    Public reset_code As Integer
    Public reset_email As String

    Shared random As New Random()

    Private Sub btn_password_reset_cancel_Click(sender As Object, e As EventArgs) Handles btn_password_reset_cancel.Click
        auth_form_loader(Auth_Login)
    End Sub
    Private Sub btn_password_reset_send_code_Click(sender As Object, e As EventArgs) Handles btn_password_reset_send_code.Click
        If txt_password_reset_email.Text <> "" Then
            If txt_password_reset_email.Text.Contains("'") Then
                Auth.btn_auth_message.Text = "Unexpected symbol ' in email"
                Auth.btn_auth_message.Show()
                message(Auth.btn_auth_message, "warning") '
                txt_password_reset_email.Focus()
            Else
                If txt_password_reset_email.Text.Contains("@") And txt_password_reset_email.Text.Contains(".") Then
                    Try
                        sql_da = New MySqlDataAdapter("SELECT  employee.*, `user`.* FROM employee INNER JOIN `user` ON employee.ID = `user`.Employee_ID WHERE email = '" & txt_password_reset_email.Text & "'", sql_con)
                        sql_dt = New DataTable
                        sql_dt.Clear()
                        sql_da.Fill(sql_dt)
                        If sql_dt.Rows.Count() > 0 Then
                            reset_id = sql_dt.Rows(0).Item("Employee_ID")
                            reset_code = random.Next(100000, 999999)
                            reset_email = sql_dt.Rows(0).Item("email")
                            'Sends an email  to the user requesting the password reset
                            Try
                                Dim Smtp_Server As New SmtpClient
                                Dim e_mail As New MailMessage()
                                Smtp_Server.UseDefaultCredentials = False
                                Smtp_Server.Credentials = New Net.NetworkCredential("theodoredela@gmail.com", "@DrahKulaH98")
                                Smtp_Server.Port = 587
                                Smtp_Server.EnableSsl = True
                                Smtp_Server.Host = "smtp.gmail.com"

                                e_mail = New MailMessage()
                                e_mail.From = New MailAddress("theodoredela@gmail.com")
                                e_mail.To.Add(txt_password_reset_email.Text)
                                e_mail.Subject = "Email Sending"
                                e_mail.IsBodyHtml = False
                                e_mail.Body = "Your login reset code is "
                                Smtp_Server.Send(e_mail)
                                MsgBox("Mail Sent")


                                'Dim smtp_server As New SmtpClient
                                'Dim email As New MailMessage()
                                'smtp_server.UseDefaultCredentials = False
                                'smtp_server.Credentials = New Net.NetworkCredential("theodoredela@gmail.com", "DrahKulaH98")
                                'smtp_server.Port = 587
                                'smtp_server.EnableSsl = True
                                'smtp_server.Host = "smtp.gmail.com"
                                'email = New MailMessage()
                                'email.From = New MailAddress("theodoredela@gmail.com")
                                'email.To.Add(txt_password_reset_email.Text)
                                'email.Subject = " HTU-JMTC Password Reset"
                                'email.IsBodyHtml = False
                                'email.Body = "Your login reset code is " + reset_code.ToString
                                'smtp_server.Send(email)
                                MsgBox("check point")
                                sql_ds = New DataSet
                                sql_da = New MySqlDataAdapter("INSERT INTO login_reset(Request_ID,	Reset_Code,Request_Time)
                                                VALUES('" & reset_id & "', '" & reset_code & "', '" & Date.UtcNow & "')", sql_con)
                                sql_da.Fill(sql_ds, "user")
                                'Displays a message in the application
                                btn_password_reset_reset.Enabled = True
                                btn_password_reset_send_code.Enabled = False
                                btn_password_reset_send_code.Text = "CODE SENT"
                                btn_password_reset_send_code.BackColor = Color.LightGreen
                                txt_password_reset_email.Enabled = False
                                txt_password_reset_code.Enabled = True
                                txt_password_reset_code.Focus()
                                MessageBox.Show("Login reset code has been successfully sent to " + txt_password_reset_email.Text + ". Check  your mail and enter reset code", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Catch ex As Exception
                                'MessageBox.Show("Something went wrong while attempting to send email. Kindly check your connection and try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                'btn_password_reset_reset.Enabled = False
                                'btn_password_reset_send_code.Enabled = True
                                'btn_password_reset_send_code.Text = "SEND CODE"
                                'btn_password_reset_send_code.BackColor = Color.DarkTurquoise
                                'txt_password_reset_email.Enabled = True
                                'txt_password_reset_email.Focus()
                                MessageBox.Show(ex.Message, "SMTP Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        Else
                            Auth.btn_auth_message.Text = "Email NOT an Employee"
                            Auth.btn_auth_message.Show()
                            message(Auth.btn_auth_message, "warning")
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Email Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else
                    Auth.btn_auth_message.Text = "Enter a valid email address"
                    Auth.btn_auth_message.Show()
                    message(Auth.btn_auth_message, "warning")
                    txt_password_reset_email.Focus()
                End If
            End If

        Else
            Auth.btn_auth_message.Text = "Email address field is empty"
            Auth.btn_auth_message.Show()
            message(Auth.btn_auth_message, "warning")
        End If
    End Sub
    Private Sub btn_password_reset_reset_Click(sender As Object, e As EventArgs) Handles btn_password_reset_reset.Click
        If txt_password_reset_code.Text <> "" Then
            If IsNumeric(txt_password_reset_code.Text) Then
                Try
                    If txt_password_reset_code.Text = reset_code Then
                        sql_da = New MySqlDataAdapter("SELECT login_reset.* FROM login_reset WHERE Request_ID = '" & reset_id & "'", sql_con)
                        sql_dt = New DataTable
                        sql_dt.Clear()
                        sql_da.Fill(sql_dt)
                        If sql_dt.Rows.Count() > 0 Then
                            Dim repos As DialogResult = MessageBox.Show("Are you sure to reset user login?", "User Login Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                            If repos = DialogResult.Yes Then
                                sql_ds = New DataSet
                                sql_da = New MySqlDataAdapter("UPDATE user SET Username = '" & null & "' , Password = '" & null & "'  WHERE Employee_ID = '" & reset_id & "'", sql_con)
                                sql_da.Fill(sql_ds, "employee")
                                Auth_Login.btn_signup_Click(Auth_Login.btn_signup, EventArgs.Empty)
                                Auth.btn_auth_message.Text = "Create New Username & Password"
                                Auth.btn_auth_message.Show()
                                message(Auth.btn_auth_message, "success")
                                Auth_Login.txt_login_username.Focus()
                            End If

                        Else
                            Auth.btn_auth_message.Text = "Employee NOT found"
                            Auth.btn_auth_message.Show()
                            message(Auth.btn_auth_message, "warning")
                        End If
                    Else
                        Auth.btn_auth_message.Text = "Invalid Code"
                        Auth.btn_auth_message.Show()
                        message(Auth.btn_auth_message, "warning")
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Reset Code Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                Auth.btn_auth_message.Text = "Enter numeric values only"
                Auth.btn_auth_message.Show()
                message(Auth.btn_auth_message, "warning")
                txt_password_reset_code.Focus()
            End If
        Else
            Auth.btn_auth_message.Text = "Required field is empty"
            Auth.btn_auth_message.Show()
            message(Auth.btn_auth_message, "warning")
        End If
    End Sub


End Class