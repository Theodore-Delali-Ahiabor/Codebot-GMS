Public Class Management_Market
    Dim Parts_Name As New DataGridViewComboBoxColumn

    Private Sub btn_new_parts_requisition_save_Click(sender As Object, e As EventArgs) Handles btn_new_parts_requisition_save.Click
        MarketDataGridView.Rows.Item(0).Cells(0).Selected = True
        Try
            If txt_work_order_id.Text.ToString <> "" Then
                sql_dt = New DataTable
                sql_da = New MySqlDataAdapter("SELECT * FROM `work_order` WHERE ID = '" & txt_work_order_id.Text.ToString & "'", sql_con)
                sql_da.Fill(sql_dt)
                If sql_dt.Rows.Count > 0 Then
                    sql_ds = New DataSet
                    With MarketDataGridView
                        Dim valid_count As Integer = 0
                        'LOOPING THROUGH ALL CELLS IN THE MARKET DATAGRIDVIEW
                        For i As Integer = 0 To (.Rows.Count - 2)
                            For j As Integer = 0 To 2
                                'CHECK IF ALL PART SELECTIONS HAVE CORRESPONDING QUSNTITY AND AVAILABLE VALUES
                                If .Rows.Item(i).Cells(j).Value.ToString <> "" Then
                                    valid_count += 1
                                    If valid_count = (.Rows.Count - 1) * 3 Then
                                        For k As Integer = 0 To (.Rows.Count - 2)
                                            MsgBox("check point reached")
                                            '    sql_da = New MySqlDataAdapter("INSERT INTO `parts_requisition`(`Employee_ID`, `work_order_ID`, `Parts_Name`, `Quantity`, `Available`, `Request_Time`) 
                                            'VALUES('" & login_id & "','" & txt_work_order_id.Text & "','" & .Rows.Item(k).Cells(0).Value.ToString & "','" & CInt(.Rows.Item(k).Cells(1).Value) & "','" & CInt(.Rows.Item(k).Cells(2).Value) & "', '" & Date.UtcNow & "')", sql_con)
                                            '    sql_da.Fill(sql_ds, "parts_requisition")
                                            MsgBox(CInt(.Rows.Item(k).Cells(2).Value) - CInt(.Rows.Item(k).Cells(1).Value))

                                            '                sql_ds = New DataSet
                                            '                sql_da = New MySqlDataAdapter("UPDATE inventory SET  Stock = '" & CInt(.Rows.Item(k).Cells(2).Value) - CInt(.Rows.Item(k).Cells(1).Value) & "'
                                            'Where ID = '" & "" & "'", sql_con)
                                            '                sql_da.Fill(sql_ds, "inventory")
                                        Next

                                    End If
                                Else
                                    MessageBox.Show("You are missing values for " & (((.Rows.Count - 1) * 3) - valid_count) - 1 & " cell(s) in the table. Kindly fill them to be able to continue.")
                                End If
                            Next
                        Next

                    End With
                    'sql_da.Fill(sql_ds, "parts_requisition")
                Else
                    txt_work_order_id.Focus()
                    Management.btn_management_message.Text = "Invalid Work Order ID"
                    Management.btn_management_message.Show()
                    message(Management.btn_management_message, "warning")
                End If
            Else
                txt_work_order_id.Focus()
                Management.btn_management_message.Text = "Empty work order field"
                Management.btn_management_message.Show()
                message(Management.btn_management_message, "warning")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class