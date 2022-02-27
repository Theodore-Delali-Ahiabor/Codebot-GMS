Imports MySql.Data.MySqlClient
Imports System.Net.Mail
'Imports Amazon.SimpleNotificationService
'Imports Amazon.SimpleNotificationService.Model
Public Class Auth_Password_Reset
    Public reset_id, reset_phone, reset_email As String
    Public reset_code As Integer

    Shared random As New Random()

    Private Sub btn_password_reset_cancel_Click(sender As Object, e As EventArgs) Handles btn_password_reset_cancel.Click
        auth_form_loader(Auth_Login)
    End Sub
    Private Sub btn_password_reset_send_code_Click(sender As Object, e As EventArgs) Handles btn_password_reset_send_code.Click
        If txt_password_reset_email.Text <> "" Then
            If txt_password_reset_email.Text.Contains("'") Then
                message("error", "Unexpected sign ' in email") '
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
                            reset_phone = CStr(sql_dt.Rows(0).Item("Phone"))
                            reset_email = sql_dt.Rows(0).Item("email")
                            Try
                                If CheckForInternetConnection() = True Then
                                    'Sends a reset code  to the user requesting the password reset based on the selected meduims
                                    If chkb_login_reset_send_email.Checked Then
                                        'send email
                                        Me.UseWaitCursor = True
                                        message("information", "Please wait while we send your reset code")
                                        send_email("Login Reset", txt_password_reset_email.Text, "Your login reset code is " + CStr(reset_code))
                                        'check if the mail was sent sucessfully
                                        If email_delevery_status = 1 Then
                                            message("success", "Reset code successfully sent to " + txt_password_reset_email.Text)
                                            login_reset_update_user()
                                        Else
                                            message("warning", "Failed to send email to " + reset_email + ". ")
                                        End If
                                        Me.Cursor = DefaultCursor
                                    ElseIf chkb_login_reset_send_whatsapp.Checked Then
                                        'send whatsapp
                                        send_whatsapp(reset_phone, "Your login reset code is " + CStr(reset_code))
                                        message("success", "Login reset code has been successfully sent to " + reset_phone)
                                        login_reset_update_user()
                                    Else
                                        message("warning", "No messaging meduim Selected")
                                    End If
                                Else
                                    message("warning", "No internet connection, Check internet conection and try Again")
                                End If
                            Catch ex As Exception
                                MessageBox.Show(ex.Message, "Sending Code Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        Else
                            message("warning", "Email NOT an Employee")
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Email Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else
                    message("warning", "Enter a valid email address")
                    txt_password_reset_email.Focus()
                End If
            End If

        Else
            message("warning", "Email address field is empty")
        End If
    End Sub
    Public Sub login_reset_update_user()
        sql_ds = New DataSet
        sql_da = New MySqlDataAdapter("UPDATE `user` SET `Reset_Code` = '" & reset_code & "', `Last_Updated` = '" & Date.UtcNow & "' WHERE 	Employee_ID = '" & reset_id & "'", sql_con)
        sql_da.Fill(sql_ds, "user")
        Auth_Password_Reset_Code_Validation.ShowDialog()
    End Sub
    Private Sub chkb_login_reset_send_whatsapp_CheckedChanged(sender As Object, e As EventArgs) Handles chkb_login_reset_send_whatsapp.CheckedChanged
        If chkb_login_reset_send_whatsapp.Checked Then
            message("information", "Lunch and login to whatsapp desktop if installed else install for this option to work")
        Else

        End If
    End Sub

    Private Sub chkb_login_reset_send_sms_CheckedChanged(sender As Object, e As EventArgs) Handles chkb_login_reset_send_sms.CheckedChanged

    End Sub

    Private Sub chkb_login_reset_send_email_CheckedChanged(sender As Object, e As EventArgs) Handles chkb_login_reset_send_email.CheckedChanged

    End Sub
End Class