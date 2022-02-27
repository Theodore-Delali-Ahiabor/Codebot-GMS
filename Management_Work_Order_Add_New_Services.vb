Public Class Management_Work_Order_Add_New_Services
    Dim service_work_order_id As String
    Dim service As String
    Dim cost As String
    Private Sub btn_new_services_cancel_Click(sender As Object, e As EventArgs) Handles btn_new_services_cancel.Click
        Close()
        ServicesDataGridView.DataSource.clear()

    End Sub

    Private Sub btn_new_services_save_Click(sender As Object, e As EventArgs) Handles btn_new_services_save.Click
        ServicesDataGridView.Rows(ServicesDataGridView.Rows.Count - 1).Cells(0).Selected = True
        Dim services() As String
        Dim costs() As String
        Dim RowCount As Integer = ServicesDataGridView.Rows.Count - 1
        ReDim services(RowCount - 1)
        ReDim costs(RowCount - 1)

        Try
            For row = 0 To ServicesDataGridView.Rows.Count - 2
                services(row) = CStr(ServicesDataGridView.Rows(row).Cells(0).Value)
                costs(row) = CStr(ServicesDataGridView.Rows(row).Cells(1).Value)
            Next row

            service_work_order_id = Management_Work_Order_Add_New.lbl_new_work_order_id.Text
            service = String.Join("-", services)
            cost = String.Join("-", costs)

            If btn_new_services_save.Text = "SAVE" Then
                sql_ds = New DataSet
                sql_da = New MySqlDataAdapter("INSERT INTO `services`(`Work_Order_ID`, `Service`, `Cost`)
                    VALUES ('" & service_work_order_id & "', '" & service & "', '" & cost & "')", sql_con)
                sql_da.Fill(sql_ds, "services")
                Me.Close()
                message("success", "Services Added Successflly")
            ElseIf btn_new_services_save.Text = "UPDATE" Then
                sql_ds = New DataSet
                sql_da = New MySqlDataAdapter("UPDATE `services` SET `Service`= '" & service & "',`Cost`='" & cost & "' WHERE `Work_Order_ID` = '" & service_work_order_id & "'", sql_con)
                sql_da.Fill(sql_ds, "services")

                Me.Close()
                message("success", "Services Updated Successflly")
            End If
            Management_Work_Order_Add_New.txt_work_order_new_services.Text = Management_Work_Order_Add_New.getServices()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Save services Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ServicesDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles ServicesDataGridView.CellValueChanged
        If ServicesDataGridView.CurrentCell.ColumnIndex = 1 And ServicesDataGridView.CurrentCell.Value.ToString IsNot String.Empty Then
            message("error", "Empty or null values are NOT allowed")
            ServicesDataGridView.CurrentCell.Selected = True
        End If
    End Sub


End Class