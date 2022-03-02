Public Class Management_Work_Order_Add_New_Parts
    Dim part_work_order_id As Integer
    Dim description, quantity, stock, cost, unit_cost As String

    Private Sub btn_new_parts_cancel_Click(sender As Object, e As EventArgs) Handles btn_new_parts_cancel.Click
        Close()
        PartsDataGridView.DataSource.clear()
    End Sub

    Private Sub btn_new_parts_save_Click(sender As Object, e As EventArgs) Handles btn_new_parts_save.Click
        PartsDataGridView.Rows(PartsDataGridView.Rows.Count - 1).Cells(0).Selected = True
        Dim descriptions(), quantitys(), stocks(), costs(), unit_costs() As String
        Dim RowCount As Integer = PartsDataGridView.Rows.Count - 1
        ReDim descriptions(RowCount - 1)
        ReDim quantitys(RowCount - 1)
        ReDim stocks(RowCount - 1)
        ReDim costs(RowCount - 1)
        ReDim unit_costs(RowCount - 1)

        Try
            For row = 0 To PartsDataGridView.Rows.Count - 2
                descriptions(row) = CStr(PartsDataGridView.Rows(row).Cells(0).Value)
                quantitys(row) = CStr(PartsDataGridView.Rows(row).Cells(1).Value)
                stocks(row) = CStr(PartsDataGridView.Rows(row).Cells(2).Value)
                costs(row) = CStr(PartsDataGridView.Rows(row).Cells(3).Value)
                unit_costs(row) = CStr(PartsDataGridView.Rows(row).Cells(4).Value)
            Next row

            part_work_order_id = Management_Work_Order_Add_New.lbl_new_work_order_id.Text
            description = String.Join("-", descriptions)
            quantity = String.Join("-", quantitys)
            stock = String.Join("-", stocks)
            cost = String.Join("-", costs)
            unit_cost = String.Join("-", unit_costs)

            If btn_new_parts_save.Text = "SAVE" Then
                sql_ds = New DataSet
                sql_da = New MySqlDataAdapter("INSERT INTO `parts`(`Work_Order_ID`, `Description`, `Quantity`, `Stock`, `Cost`, `Unit_Cost`) 
                            VALUES ('" & part_work_order_id & "','" & description & "','" & quantity & "','" & stock & "','" & cost & "','" & unit_cost & "')", sql_con)
                sql_da.Fill(sql_ds, "parts")
                Me.Close()
                message("success", "Parts Added Successflly")
            ElseIf btn_new_parts_save.Text = "UPDATE" Then
                sql_ds = New DataSet
                sql_da = New MySqlDataAdapter("UPDATE `parts` SET `Description`='" & description & "',`Quantity`='" & quantity & "',`Stock`='" & stock & "',`Cost`='" & cost & "',`Unit_Cost`='" & unit_cost & "' WHERE `Work_Order_ID`='" & part_work_order_id & "'", sql_con)
                sql_da.Fill(sql_ds, "parts")

                Me.Close()
                message("success", "Parts Updated Successflly")
            End If
            Management_Work_Order_Add_New.txt_work_order_new_parts.Text = Management_Work_Order_Add_New.getParts()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Save Parts Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PartsDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles PartsDataGridView.CellValueChanged
        'message("success", "check point reached")
        Try
            With PartsDataGridView
                If .CurrentRow.Cells(0).Value.ToString <> "" And .CurrentRow.Cells(0).Selected = True Then
                    'Query database for details of the selected part
                    Dim sql_cmd As New MySqlCommand("SELECT * FROM `inventory` WHERE `Description` = '" & .CurrentRow.Cells(0).Value.ToString() & "'", sql_con)
                    sql_con.Close()
                    sql_con.Open()
                    Dim sql_rdr As MySqlDataReader = sql_cmd.ExecuteReader()
                    'Assign the selected part it's corresponding Stock/Available quantity and it's unit cost
                    If sql_rdr.Read = True Then
                        .CurrentRow.Cells(1).Value = CStr(1)
                        .CurrentRow.Cells(2).Value = sql_rdr.Item("Stock").ToString
                        .CurrentRow.Cells(4).Value = sql_rdr.Item("Unit_Cost").ToString
                        .CurrentRow.Cells(3).Value = (CDec(.CurrentRow.Cells(4).Value) * CDec(.CurrentRow.Cells(1).Value)).ToString
                    End If
                    sql_con.Close()

                ElseIf .CurrentRow.Cells(1).Value.ToString <> "" Then
                    Dim total_parts_cost As Decimal = 00.00
                    'Calculate the parts total cost by multiplying each request quantity with it's corresponding unit cost
                    .CurrentRow.Cells(3).Value = (CInt(.CurrentRow.Cells(4).Value) * CInt(.CurrentRow.Cells(1).Value)).ToString
                    For i = 0 To .Rows.Count - 2
                        'total_parts_cost += (CDec(.Rows.Item(i).Cells(1).Value) * CDec(.Rows.Item(i).Cells(3).Value))
                    Next

                End If
            End With

        Catch ex As Exception
            ' MessageBox.Show(ex.Message, "Parts Selection Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PartsDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PartsDataGridView.CellClick
        'PartsDataGridView_CellValueChanged(PartsDataGridView, EventArgs.Empty)
    End Sub

    Private Sub PartsDataGridView_CellStateChanged(sender As Object, e As DataGridViewCellStateChangedEventArgs)

    End Sub

    Private Sub PartsDataGridView_Click(sender As Object, e As EventArgs) Handles PartsDataGridView.Click

    End Sub
End Class