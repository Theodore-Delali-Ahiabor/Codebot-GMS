Public Class Management_Market
    Dim Parts_Name As New DataGridViewComboBoxColumn

    Private Sub MarketDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles MarketDataGridView.CellValueChanged
        Try
            If MarketDataGridView.CurrentRow.Cells(0).Value.ToString <> "" And MarketDataGridView.CurrentRow.Cells(0).Selected = True Then
                '
                Dim sql_cmd As New MySqlCommand("SELECT * FROM inventory WHERE `Description` = '" & MarketDataGridView.CurrentRow.Cells(0).Value.ToString & "'", sql_con)
                sql_con.Close()
                sql_con.Open()
                Dim sql_rdr As MySqlDataReader = sql_cmd.ExecuteReader()
                '
                If sql_rdr.Read = True Then
                    MarketDataGridView.CurrentRow.Cells(2).Value = sql_rdr.Item("Stock").ToString
                End If
                sql_con.Close()

            ElseIf MarketDataGridView.CurrentRow.Cells(1).Value.GetType.ToString <> "system.Int32" And MarketDataGridView.CurrentRow.Cells(1).Value.ToString <> "" Then
                MessageBox.Show("Enter Integer values only", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MarketDataGridView.CurrentRow.Cells(1).Value = String.Empty
                MarketDataGridView.CurrentRow.Cells(1).Selected = True
                'MarketDataGridView.CurrentRow.Cells(1).
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_work_order_id_TextChanged(sender As Object, e As EventArgs) Handles txt_work_order_id.TextChanged
        'add_columns_to_market_datagridview()
        'If sql_dt.Rows.Count > 0 Then
        '    For i = 0 To sql_dt.Rows.Count - 1
        '        MsgBox(i)
        '    Next
        'Else

        'End If

    End Sub
    Private Sub btn_new_parts_requisition_cancel_Click(sender As Object, e As EventArgs) Handles btn_new_parts_requisition_cancel.Click
        sidebar_form_loader(Me)
        add_columns_to_market_datagridview()
        Management.lbl_current_tab.Text = "Parts Requisition"
    End Sub

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

    Public Sub add_columns_to_market_datagridview()
        sql_dt = New DataTable
        sql_dt.Clear()
        With sql_dt
            Dim Parts_Name As New DataColumn
            With Parts_Name
                .Caption = "Parts Name / Description"
                .ColumnName = "Parts_Name"
            End With
            .Columns.Add(Parts_Name)
            Dim Quantity As New DataColumn
            With Quantity
                .Caption = "Quantity"
                .ColumnName = "Quantity"
            End With
            .Columns.Add(Quantity)
            Dim Available As New DataColumn
            With Available
                .ColumnName = "Available"
                .Caption = "Available"
            End With
            .Columns.Add(Available)
        End With
        Try
            With MarketDataGridView
                .Columns.Clear()
                .AutoGenerateColumns = False
                .DataSource = sql_dt
                '
                With Parts_Name
                    .HeaderText = "Parts Name / Description"
                    .DataPropertyName = "Parts_Name"
                    .DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox

                    Dim sql_cmd As New MySqlCommand("SELECT * FROM inventory WHERE Stock > 0", sql_con)
                    sql_con.Close()
                    sql_con.Open()
                    Dim sql_rdr As MySqlDataReader = sql_cmd.ExecuteReader()
                    'Add items to DataGridViewComboBoxColumn
                    While sql_rdr.Read
                        If Parts_Name.Items.Contains(sql_rdr.Item("Description").ToString) = False Then
                            Parts_Name.Items.Add(sql_rdr.Item("Description").ToString)
                        End If
                    End While
                    sql_con.Close()

                End With
                .Columns.Add(Parts_Name)
                '
                Dim Quantity As New DataGridViewTextBoxColumn
                With Quantity
                    .HeaderText = "Quantity"
                    .DataPropertyName = "Quantity"
                End With
                .Columns.Add(Quantity)
                '
                Dim Available As New DataGridViewTextBoxColumn
                With Available
                    .HeaderText = "Available"
                    .DataPropertyName = "Available"

                End With
                .Columns.Add(Available)
                .Columns(0).Width = 500
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class