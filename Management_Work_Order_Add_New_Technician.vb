Public Class Management_Work_Order_Add_New_Technician
    Private Sub btn_technician_select_cancel_Click(sender As Object, e As EventArgs) Handles btn_technician_select_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_technician_select_select_Click(sender As Object, e As EventArgs) Handles btn_technician_select_select.Click
        Management_Work_Order_Add_New.txt_new_work_order_technicians.Text = Management_Work_Order_Add_New.txt_new_work_order_technicians.Text & TechnicianDataGridView.CurrentRow.Cells(1).Value & ", " & vbCrLf
        'If TechnicianDataGridView.SelectedRows.Count > 1 Then

        'End If
        Me.Close()
    End Sub

    Private Sub Management_Work_Order_Add_New_Technician_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagrid_fill_color_effect("employee_view", Me.TechnicianDataGridView)
        TechnicianDataGridView.Columns(0).Visible = False
        TechnicianDataGridView.Columns(1).Width = 300   'Full name
        TechnicianDataGridView.Columns(2).Visible = False   '
        TechnicianDataGridView.Columns(3).Visible = False  '
        TechnicianDataGridView.Columns(4).Width = 80    '
        TechnicianDataGridView.Columns(5).Width = 300   '
        TechnicianDataGridView.Columns(6).Width = 100    '
        TechnicianDataGridView.Columns(7).Visible = False   'Active
    End Sub
End Class