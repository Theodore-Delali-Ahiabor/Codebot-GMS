Public Class Management_Employees_Add_New
    Private Sub btn_new_user_cancel_Click(sender As Object, e As EventArgs) Handles btn_new_user_cancel.Click
        sidebar_form_loader(Management_Employees)

    End Sub

    Private Sub btn_new_user_save_Click(sender As Object, e As EventArgs) Handles btn_new_user_save.Click
        If btn_new_user_save.Text = "UPDATE" Then
            Management_Employees.add_update_user("UPDATE")
        Else
            Management_Employees.add_update_user("SAVE")
        End If
    End Sub
End Class