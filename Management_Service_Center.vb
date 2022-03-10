Public Class Management_Service_Center
    Private Sub btn_new_user_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If btn_save.Text = "SAVE" Then
                Dim repos As DialogResult = MessageBox.Show("You are about to Add a Service Center, are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If repos = DialogResult.Yes Then
                    sql_ds = New DataSet
                    sql_da = New MySqlDataAdapter("INSERT INTO `service_center`(`ID`, `Name`, `TIN`, `Email`, `Telephone_Number`, `Mobile_Number`, `Post_Box_Number`, `Location`) 
                            VALUES ('1','" & txt_name.Text.ToString & "','" & txt_tin_number.Text.ToString & "','" & txt_email.Text.ToString & "','" & txt_tel_number.Text.ToString & "','" & txt_phone_number.Text.ToString & "','" & txt_pobox.Text.ToString & "','" & txt_location.Text.ToString & "')", sql_con)
                    sql_da.Fill(sql_ds, "service_center")

                    message("success", "Service Center Added Successflly")
                End If
                gms_main_form_loader(Auth)
            Else
                Dim repos As DialogResult = MessageBox.Show("You are about Edit informations on the Service Center, are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If repos = DialogResult.Yes Then
                    sql_ds = New DataSet
                    sql_da = New MySqlDataAdapter("UPDATE `service_center` SET `Name`='" & txt_name.Text.ToString & "',`TIN`='" & txt_tin_number.Text.ToString & "',`Email`='" & txt_email.Text.ToString & "',`Telephone_Number`='" & txt_tel_number.Text.ToString & "',`Mobile_Number`='" & txt_phone_number.Text.ToString & "',`Post_Box_Number`='" & txt_pobox.Text.ToString & "',`Location`='" & txt_location.Text.ToString & "' WHERE `ID` = '1'", sql_con)
                    sql_da.Fill(sql_ds, "service_center")
                    message("success", "Service Center Updated Successflly")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Service Center Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Close()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class
