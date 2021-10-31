Imports MySql.Data.MySqlClient
Public Class Management_Work_Order_Add_New_Technician
    Private Sub btn_technician_select_cancel_Click(sender As Object, e As EventArgs) Handles btn_technician_select_cancel.Click
        Me.Hide()
    End Sub

    Private Sub btn_technician_select_select_Click(sender As Object, e As EventArgs) Handles btn_technician_select_select.Click
        If TechnicianDataGridView.SelectedRows.Count > 0 Then
            'For Each item In Management_Work_Order_Add_New.txt_new_work_order_technicians.Text
            If Management_Work_Order_Add_New.txt_new_work_order_technicians.Text.Contains(TechnicianDataGridView.CurrentRow.Cells(1).Value & ", ") Then
                Management.btn_management_message.Text = "Technician already selected"
                Management.btn_management_message.Show()
                message(Management.btn_management_message, "warning")
            Else
                Management_Work_Order_Add_New.txt_new_work_order_technicians.Text = Management_Work_Order_Add_New.txt_new_work_order_technicians.Text & TechnicianDataGridView.CurrentRow.Cells(1).Value & ", " & vbCrLf
                    Me.Hide()
                End If
            ' Next
        Else
            Management.btn_management_message.Text = "No Technician was selected"
            Management.btn_management_message.Show()
            message(Management.btn_management_message, "warning")
        End If

    End Sub

    Public Sub Management_Work_Order_Add_New_Technician_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With Me.TechnicianDataGridView
                .Columns(0).Visible = False
                .Columns(1).Width = 300   'Full name
                .Columns(2).Visible = False   '
                .Columns(3).Visible = False  '
                .Columns(4).Width = 80    '
                .Columns(5).Width = 300   '
                .Columns(6).Width = 100    '
                .Columns(7).Visible = False   'Active
            End With

        Catch ex As Exception

        End Try

    End Sub
End Class