Imports MySql.Data.MySqlClient
Public Class Management_Work_Order_Add_New_Technician
    Private Sub btn_technician_select_cancel_Click(sender As Object, e As EventArgs) Handles btn_technician_select_cancel.Click
        Me.Hide()
    End Sub

    Private Sub btn_technician_select_select_Click(sender As Object, e As EventArgs) Handles btn_technician_select_select.Click
        Try
            If TechnicianDataGridView.SelectedRows.Count > 0 Then
                For i = 0 To TechnicianDataGridView.SelectedRows.Count - 1
                    Dim name As String = TechnicianDataGridView.SelectedRows.Item(i).Cells(0).Value.ToString

                    If Management_Work_Order_Add_New.txt_new_work_order_technicians.Text.Contains(name) = False Then
                        Management_Work_Order_Add_New.txt_new_work_order_technicians.Text = Management_Work_Order_Add_New.txt_new_work_order_technicians.Text & TechnicianDataGridView.SelectedRows.Item(i).Cells(0).Value + ", " & vbCrLf
                        Me.Hide()
                    Else
                        Me.Hide()
                    End If
                Next
            Else
                message("warning", "No Technician selected")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Technician(s) Selection Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class