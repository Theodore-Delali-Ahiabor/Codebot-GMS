Public Class Management_Invoice
    Public Sub btn_add_new_invoice_Click(sender As Object, e As EventArgs) Handles btn_add_new_invoice.Click
        Management.lbl_current_tab.Text = "Invoice | Add New Invoice"
        sidebar_form_loader(Management_Invoice_Add_New)
        Try
            Dim services_dt As New DataTable
            services_dt.Clear()
            With services_dt
                Dim Description As New DataColumn
                With Description
                    .ColumnName = "Description"
                    .Caption = "Description"
                End With
                .Columns.Add(Description)
                Dim Cost As New DataColumn
                With Cost
                    .ColumnName = "Cost"
                    .Caption = "Cost"
                End With
                .Columns.Add(Cost)

            End With
            With Management_Invoice_Add_New.InvoiceServicesDataGridView
                .Columns.Clear()
                .AutoGenerateColumns = False
                .DataSource = services_dt
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



            Dim parts_dt = New DataTable
            parts_dt.Clear()
            With parts_dt
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
                Dim unit_cost As New DataColumn
                With unit_cost
                    .ColumnName = "unit_cost"
                    .Caption = "unit_cost"
                End With
                .Columns.Add(unit_cost)

            End With

            With Management_Invoice_Add_New.InvoicePartsDataGridView
                .Columns.Clear()
                .AutoGenerateColumns = False
                .DataSource = parts_dt
                '
                Dim parts_name As New DataGridViewComboBoxColumn
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
                '
                Dim Unit_Cost As New DataGridViewTextBoxColumn
                With Unit_Cost
                    .HeaderText = "Unit_Cost"
                    .DataPropertyName = "Unit_Cost"
                    .Visible = False
                End With
                .Columns.Add(Unit_Cost)
                .Columns(0).Width = 500
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class