Imports MySql.Data.MySqlClient
Public Class Auth_Password_Reset
    Public reset_id As String
    Public null As String
    Public reset_code As Integer
    Private Sub btn_password_reset_cancel_Click(sender As Object, e As EventArgs) Handles btn_password_reset_cancel.Click
        auth_form_loader(Auth_Login)
    End Sub
    Private Sub btn_password_reset_send_code_Click(sender As Object, e As EventArgs) Handles btn_password_reset_send_code.Click
        If txt_password_reset_phone_number.Text <> "" Then
            If IsNumeric(txt_password_reset_phone_number.Text) Then
                Try
                    sql_da = New MySqlDataAdapter("SELECT  employee.*, `user`.* FROM employee INNER JOIN `user` ON employee.ID = `user`.Employee_ID WHERE phone = '" & txt_password_reset_phone_number.Text & "'", sql_con)
                    sql_dt = New DataTable
                    sql_dt.Clear()
                    sql_da.Fill(sql_dt)
                    If sql_dt.Rows.Count() > 0 Then
                        reset_id = sql_dt.Rows(0).Item("Employee_ID")
                        reset_code = 758425
                        sql_ds = New DataSet
                        sql_da = New MySqlDataAdapter("INSERT INTO login_reset(Request_ID,	Reset_Code,Request_Time)
                        VALUES('" & reset_id & "', '" & reset_code & "', '" & Date.UtcNow & "')", sql_con)
                        sql_da.Fill(sql_ds, "user")
                        btn_password_reset_reset.Enabled = True
                        btn_password_reset_send_code.Enabled = False
                        btn_password_reset_send_code.Text = "CODE SENT"
                        txt_password_reset_phone_number.Enabled = False
                        txt_password_reset_code.Focus()
                        Auth.btn_auth_message.Text = "Reset Code was Sent to '" & txt_password_reset_phone_number.Text & "'"
                        Auth.btn_auth_message.Show()
                        message(Auth.btn_auth_message, "success")
                    Else
                        Auth.btn_auth_message.Text = "Number NOT an Employee"
                        Auth.btn_auth_message.Show()
                        message(Auth.btn_auth_message, "warning")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                Auth.btn_auth_message.Text = "Enter numeric values ONLY"
                Auth.btn_auth_message.Show()
                message(Auth.btn_auth_message, "warning")
                txt_password_reset_phone_number.Focus()
            End If
        Else
            Auth.btn_auth_message.Text = "Phone number field is empty"
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
                                auth_form_loader(Auth_Signup)
                                Auth.btn_auth_message.Text = "Create New Username & Password"
                                Auth.btn_auth_message.Show()
                                message(Auth.btn_auth_message, "success")
                                Auth_Login.txt_login_username.Focus()
                            End If

                        Else
                            Auth.btn_auth_message.Text = "Number NOT an Employee"
                            Auth.btn_auth_message.Show()
                            message(Auth.btn_auth_message, "warning")
                        End If
                    Else
                        Auth.btn_auth_message.Text = "Invalid Code"
                        Auth.btn_auth_message.Show()
                        message(Auth.btn_auth_message, "warning")
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
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