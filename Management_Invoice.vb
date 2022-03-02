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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Add New Invoice Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        Management_Invoice_Add_New.clear_invoice()
    End Sub

End Class