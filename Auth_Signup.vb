Public Class Auth_Signup
    Private Sub btn_signup_verify_create_Click(sender As Object, e As EventArgs) Handles btn_signup_verify_create.Click
        If btn_signup_verify_create.Text = "VERIFY" Then
            'check if the user is permited to signup to signup 
            If txt_signup_phone.Text <> "" And IsNumeric(txt_signup_phone.Text) Then
                signup_middle_panel.Visible = True
                txt_signup_username.Focus()
                txt_signup_username.Enabled = True
                txt_signup_password.Enabled = True
                txt_signup_confirm_password.Enabled = True
                btn_signup_verify_create.Text = "CREATE"
            ElseIf txt_signup_phone.Text = "" Then
                txt_signup_phone.Focus()
                Auth.btn_message.Text = "Phone Number Field is Required"
                Auth.btn_message.Show()
                Auth.message()
            Else
                txt_signup_phone.Focus()
                Auth.btn_message.Text = "Invalid input"
                Auth.btn_message.Show()
                Auth.message()
            End If

        ElseIf btn_signup_verify_create.Text = "CCREATE" Then
            'check if the details are valid then add user
            If txt_signup_phone.Text <> "" And txt_signup_username.Text <> "" And txt_signup_password.Text <> "" And txt_signup_confirm_password.Text <> "" Then

            ElseIf txt_signup_phone.Text <> "" Then
                txt_signup_phone.Focus()
                Auth.btn_message.Text = "Phone Number Field is Required"
                Auth.btn_message.Show()
                Auth.message()
            ElseIf txt_signup_username.Text <> "" Then
                txt_signup_phone.Focus()
                Auth.btn_message.Text = "Phone Number Field is Required"
                Auth.btn_message.Show()
                Auth.message()
            End If
        End If
    End Sub

    Private Sub btn_signup_cancel_Click(sender As Object, e As EventArgs) Handles btn_signup_cancel.Click
        'login_panel.Dock = DockStyle.Fill
        'login_panel.Visible = True
        'password_reset_panel.Visible = False
        'signup_panel.Visible = False
        auth_form_loader(Auth_Login)
    End Sub

End Class