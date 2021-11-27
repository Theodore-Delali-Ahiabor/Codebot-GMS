Imports MySql.Data.MySqlClient
Public Class Management_Work_Order_Add_New_Technician
    Private Sub btn_technician_select_cancel_Click(sender As Object, e As EventArgs) Handles btn_technician_select_cancel.Click
        Me.Hide()
    End Sub

    Private Sub btn_technician_select_select_Click(sender As Object, e As EventArgs) Handles btn_technician_select_select.Click
        If TechnicianDataGridView.SelectedRows.Count > 0 Then
            If Management_Work_Order_Add_New.txt_new_work_order_technicians.Text.Contains(TechnicianDataGridView.CurrentRow.Cells(0).Value + ", ") Then
                Management.btn_management_message.Text = "Technician already selected"
                Management.btn_management_message.Show()
                message(Management.btn_management_message, "warning")
            Else
                Management_Work_Order_Add_New.txt_new_work_order_technicians.Text = Management_Work_Order_Add_New.txt_new_work_order_technicians.Text & TechnicianDataGridView.CurrentRow.Cells(0).Value + ", " & vbCrLf
                Me.Hide()
            End If
        Else
            Management.btn_management_message.Text = "No Technician was selected"
            Management.btn_management_message.Show()
            message(Management.btn_management_message, "warning")
        End If
    End Sub


End Class