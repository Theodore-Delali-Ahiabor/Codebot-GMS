Public Class Auth_Password_Reset_Code_Validation
    Private Sub Auth_Password_Reset_Code_Validation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear_code_validation()

    End Sub
    Private Sub btn_reset_code_cancel_Click(sender As Object, e As EventArgs) Handles btn_reset_code_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_reset_code_validate_Click(sender As Object, e As EventArgs) Handles btn_reset_code_validate.Click
        Try
            Dim entered_code As String = txt_code_1.Text + txt_code_2.Text + txt_code_3.Text + txt_code_4.Text + txt_code_5.Text + txt_code_6.Text
            If IsNumeric(entered_code) And entered_code.Length = 6 Then
                sql_da = New MySqlDataAdapter("SELECT * FROM `login_reset` WHERE Request_Time = (SELECT MAX(`Request_Time`) FROM `login_reset` WHERE `Request_ID` = '" & Auth_Password_Reset.reset_id & "')", sql_con)
                sql_dt = New DataTable
                sql_dt.Clear()
                sql_da.Fill(sql_dt)
                If sql_dt.Rows.Count() = 1 Then
                    If entered_code = sql_dt.Rows(0).Item("Reset_Code") Then
                        Dim repos As DialogResult = MessageBox.Show("Are you sure to reset user login?", "User Login Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                        If repos = DialogResult.Yes Then
                            sql_ds = New DataSet
                            '
                            sql_da = New MySqlDataAdapter("UPDATE user SET Username = '" & null & "' , Password = '" & null & "'  WHERE Employee_ID = '" & sql_dt.Rows(0).Item("Request_ID") & "'", sql_con)
                            sql_da.Fill(sql_ds, "employee")
                            Me.Close()
                            message("success", "Reset code validated successfully. Create new Username & Password")
                            'Auth_Login.btn_signup_Click(Auth_Login.btn_signup, EventArgs.Empty)

                            With Auth_Signup
                                .lbl_signup_title.Text = "Reset"
                                .txt_signup_email.Text = Auth_Password_Reset.reset_email
                                .txt_signup_email.Enabled = False
                                .txt_signup_username.Clear()
                                .txt_signup_password.Clear()
                                .txt_signup_confirm_password.Clear()
                                .txt_signup_username.Enabled = True
                                .txt_signup_password.Enabled = True
                                .txt_signup_confirm_password.Enabled = True
                                .signup_middle_panel.Visible = True
                                .signup_notice_panel.Visible = False
                                .btn_signup_verify_create.Text = "RESET"
                            End With
                            auth_form_loader(Auth_Signup)
                            Auth_Login.txt_login_username.Focus()
                        End If
                    Else
                        MessageBox.Show("Enter a VALID code and try again", "Invalid Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        clear_code_validation()
                    End If
                Else
                    MessageBox.Show("Login Reset Request not Found", "Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Enter a VALID code and try again", "Invalid Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
                clear_code_validation()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Code Validatioin Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txt_code_1_TextChanged(sender As Object, e As EventArgs) Handles txt_code_1.TextChanged
        If txt_code_1.TextLength = 1 Then
            txt_code_2.Focus()
        End If
    End Sub

    Private Sub txt_code_2_TextChanged(sender As Object, e As EventArgs) Handles txt_code_2.TextChanged
        If txt_code_2.TextLength = 1 Then
            txt_code_3.Focus()
        End If
    End Sub

    Private Sub txt_code_3_TextChanged(sender As Object, e As EventArgs) Handles txt_code_3.TextChanged
        If txt_code_3.TextLength = 1 Then
            txt_code_4.Focus()
        End If
    End Sub

    Private Sub txt_code_4_TextChanged(sender As Object, e As EventArgs) Handles txt_code_4.TextChanged
        If txt_code_4.TextLength = 1 Then
            txt_code_5.Focus()
        End If
    End Sub

    Private Sub txt_code_5_TextChanged(sender As Object, e As EventArgs) Handles txt_code_5.TextChanged
        If txt_code_5.TextLength = 1 Then
            txt_code_6.Focus()
        End If
    End Sub

    Private Sub txt_code_6_TextChanged(sender As Object, e As EventArgs) Handles txt_code_6.TextChanged
        If txt_code_6.TextLength = 1 Then
            btn_reset_code_validate.Focus()
            If txt_code_6.Text <> "" Then
                btn_reset_code_validate_Click(btn_reset_code_validate, EventArgs.Empty)
            End If
        End If
    End Sub

    Public Sub clear_code_validation()
        txt_code_1.Clear()
        txt_code_2.Clear()
        txt_code_3.Clear()
        txt_code_4.Clear()
        txt_code_5.Clear()
        txt_code_6.Clear()
        txt_code_1.Focus()
    End Sub

End Class