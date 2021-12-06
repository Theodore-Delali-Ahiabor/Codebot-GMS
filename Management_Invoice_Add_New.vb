Public Class Management_Invoice_Add_New

    Private Sub btn_new_ivoice_cancel_Click(sender As Object, e As EventArgs) Handles btn_new_ivoice_cancel.Click
        sidebar_form_loader(Management_Invoice)
        Management.lbl_current_tab.Text = "Invoive"
    End Sub

    Private Sub InvoicePartsDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles InvoicePartsDataGridView.CellValueChanged
        Try

            With InvoicePartsDataGridView
                If .CurrentRow.Cells(0).Value.ToString <> "" And .CurrentRow.Cells(0).Selected = True Then
                    'Query database for details of the selected part
                    Dim sql_cmd As New MySqlCommand("SELECT * FROM inventory WHERE `Description` = '" & .CurrentRow.Cells(0).Value.ToString & "'", sql_con)
                    sql_con.Close()
                    sql_con.Open()
                    Dim sql_rdr As MySqlDataReader = sql_cmd.ExecuteReader()
                    'Assign the selected part it's corresponding Stock/Available quantity and it's unit cost
                    If sql_rdr.Read = True Then
                        .CurrentRow.Cells(2).Value = sql_rdr.Item("Stock").ToString
                        .CurrentRow.Cells(3).Value = sql_rdr.Item("Unit_Cost").ToString
                    End If
                    sql_con.Close()

                ElseIf .CurrentRow.Cells(1).Value.ToString <> "" Then
                    Dim total_parts_cost As Decimal = 00.00
                    'Calculate the parts total cost by multiplying each request quantity with it's corresponding unit cost
                    For i = 0 To .Rows.Count - 2
                        total_parts_cost += (CDec(.Rows.Item(i).Cells(1).Value) * CDec(.Rows.Item(i).Cells(3).Value))
                    Next
                    'Display the total cost value to the user
                    lbl_new_invoice_total_parts_cost.Text = total_parts_cost
                    calculate()
                    ' Else
                    'MessageBox.Show("Enter Integer values only for Quantity column", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    '.CurrentRow.Cells(1).Value = String.Empty
                    '.CurrentRow.Cells(1).Selected = True
                    'MarketDataGridView.CurrentRow.Cells(1).
                    'End If
                End If
            End With

        Catch ex As Exception
            ' MessageBox.Show(ex.Message, "Parts Selection Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub calculate()
        Try
            'lbl_new_invoice_total_parts_cost.Text = ""
            'lbl_new_invoice_total_services_cost.Text = ""
            lbl_new_invoice_grand_total_cost.Text = CDec(lbl_new_invoice_total_parts_cost.Text) + CDec(lbl_new_invoice_total_services_cost.Text)
            'lbl_new_invoice_tax.Text = ""
            lbl_new_invoice_payable_amount.Text = CDec(lbl_new_invoice_grand_total_cost.Text) - CDec(lbl_new_invoice_tax.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Invoice Calculation Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub InvoiceServicesDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles InvoiceServicesDataGridView.CellValueChanged
        Try
            With InvoiceServicesDataGridView

                Dim total_service_cost As Decimal = 00.00
                'sum the cost of all the services
                For i = 0 To .Rows.Count - 2
                    total_service_cost += CDec(.Rows.Item(i).Cells(1).Value)
                Next
                'Display the total cost value to the user
                lbl_new_invoice_total_services_cost.Text = total_service_cost
                calculate()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Enter Services Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class