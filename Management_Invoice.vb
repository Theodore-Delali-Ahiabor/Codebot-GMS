Public Class Management_Invoice
    Public Sub btn_add_new_invoice_Click(sender As Object, e As EventArgs) Handles btn_add_new_invoice.Click
        Management.lbl_current_tab.Text = "Invoice | Add New Invoice"
        sidebar_form_loader(Management_Invoice_Add_New)

        Try

            With Management_Invoice_Add_New.InvoiceServicesDataGridView
                .Columns.Clear()
                .AutoGenerateColumns = False
                '.DataSource = services_dt
                '
                Dim Description As New DataGridViewTextBoxColumn
                With Description
                    .HeaderText = "Description"
                    .DataPropertyName = "Description"
                End With
                .Columns.Add(Description)
                '
                Dim Cost As New DataGridViewTextBoxColumn
                With Cost
                    .HeaderText = "Cost"
                    .DataPropertyName = "Cost"
                End With
                .Columns.Add(Cost)
                .Columns(0).Width = 500
            End With


            With Management_Invoice_Add_New.InvoicePartsDataGridView
                .Columns.Clear()
                .AutoGenerateColumns = False
                '.DataSource = parts_dt
                '
                Dim Parts_Name As New DataGridViewTextBoxColumn
                With Parts_Name
                    .HeaderText = "Parts Name / Description"
                    .DataPropertyName = "Parts_Name"
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
                Dim Unit_Cost As New DataGridViewTextBoxColumn
                With Unit_Cost
                    .HeaderText = "Unit_Cost"
                    .DataPropertyName = "Unit_Cost"
                End With
                .Columns.Add(Unit_Cost)
                '
                Dim Cost As New DataGridViewTextBoxColumn
                With Cost
                    .HeaderText = "Cost"
                    .DataPropertyName = "Cost"
                End With
                .Columns.Add(Cost)
                .Columns(0).Width = 400
            End With

            Try
                sql_da = New MySqlDataAdapter("SELECT * FROM `invoice`", sql_con)
                sql_dt = New DataTable
                sql_dt.Clear()
                sql_da.Fill(sql_dt)
                Management_Invoice_Add_New.lbl_new_invoice_id.Text = sql_dt.Rows.Count + 1
                Management_Invoice_Add_New.lbl_new_invoice_writer.Text = Management.login_name.Text

            Catch ex As Exception

            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Add New Invoice Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        Management_Invoice_Add_New.clear_invoice()
    End Sub

    Private Sub btn_fully_paid_invoice_Click(sender As Object, e As EventArgs) Handles btn_fully_paid_invoice.Click
        Try
            With Management_Invoice_Update_Payment
                If InvoiceDataGridView.SelectedRows.Count = 1 Then
                    If InvoiceDataGridView.CurrentRow.Cells("Payment_Status").Value.ToString = "Paid" Then
                        message("information", "Invoice has been fully paid.")
                    Else
                        .update = False
                        .txt_amount_due.Text = InvoiceDataGridView.CurrentRow.Cells("Grand_Total").Value.ToString
                        .txt_available_balance.Text = InvoiceDataGridView.CurrentRow.Cells("Balance").Value.ToString
                        .ShowDialog()
                        If .update = True Then
                            If .balance <= 0.00 Then
                                .payment_status = "Paid"
                            Else
                                .payment_status = "Incomplete"
                            End If
                            Dim repos As DialogResult = MessageBox.Show("You are about to Add a new invoice, are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                                If repos = DialogResult.Yes Then
                                    sql_ds = New DataSet
                                sql_da = New MySqlDataAdapter("UPDATE `invoice` SET `Paid_Amt`='" & .payment_amt & "',`Balance`='" & .balance & "',`Payment_Status`='" & .payment_status & "' Where ID = '" & InvoiceDataGridView.CurrentRow.Cells("ID").Value & "'", sql_con)
                                sql_da.Fill(sql_ds, "invoice")
                                    datagrid_fill_default("invoice", Me.InvoiceDataGridView)
                                    datagrid_fill_column_resize("invoice", Me.InvoiceDataGridView)
                                    message("success", "Invoice Updated successfully.")
                                End If
                            End If
                        End If
                Else
                    message("warning", "No Invoice selected")
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "New Payment Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub

End Class