Public Class Management_Invoice_Add_New
    Dim service(), s_cost(), descriptions(), quantitys(), costs(), unit_costs() As String
    Dim total_service_cost, total_part_cost As Decimal


    Private Sub btn_new_ivoice_cancel_Click(sender As Object, e As EventArgs) Handles btn_new_ivoice_cancel.Click
        sidebar_form_loader(Management_Invoice)
        Management.lbl_current_tab.Text = "Invoive | New"
    End Sub
    Private Sub calculate()
        Try
            lbl_new_invoice_total_parts_cost.Text = CStr(total_part_cost)
            lbl_new_invoice_total_services_cost.Text = CStr(total_service_cost)
            'lbl_new_invoice_tax.Text = ""
            lbl_new_invoice_payable_amount.Text = CDec(CDec(lbl_new_invoice_total_parts_cost.Text) + CStr(total_service_cost)) - CDec(lbl_new_invoice_tax.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Invoice Calculation Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btn_new_incoice_existing_work_order_Click(sender As Object, e As EventArgs) Handles btn_new_incoice_existing_work_order.Click
        Management_Invoice_Select_Work_Order.ShowDialog()
    End Sub

    Private Sub btn_new_invoice_new_work_order_Click(sender As Object, e As EventArgs)
        Management_Work_Order.btn_add_new_work_order_Click(Management_Work_Order.btn_add_new_work_order, EventArgs.Empty)
        Management.sidebar_active(Management.btn_work_orders)
    End Sub

    Public Sub clear_invoice()
        lbl_new_invoice_total_services_cost.Text = "00.00"
        lbl_new_invoice_total_parts_cost.Text = "00.00"
        lbl_new_invoice_tax.Text = "00.00"
        lbl_new_invoice_payable_amount.Text = "00.00"
        txt_invoice_work_order.Clear()
        cmb_payment_method_filter.Text = ""
        txt_invoice_payment_amount.Clear()
        cmb_payment_status_filter.Text = ""
    End Sub

    Private Sub txt_invoice_work_order_TextChanged(sender As Object, e As EventArgs) Handles txt_invoice_work_order.TextChanged
        If txt_invoice_work_order.Text <> "" Then
            Try
                sql_da = New MySqlDataAdapter("SELECT `Service`,`Cost` FROM `services` WHERE `Work_Order_ID` ='" & txt_invoice_work_order.Text & "'  ORDER BY ID DESC", sql_con)
                sql_dt = New DataTable
                sql_dt.Clear()
                sql_da.Fill(sql_dt)

                If sql_dt.Rows.Count > 0 Then
                    'MsgBox(sql_dt.Rows(0).Item("Service").ToString)
                    service = sql_dt.Rows(0).Item("Service").ToString.Split("-")
                    s_cost = sql_dt.Rows(0).Item("Cost").ToString.Split("-")
                    'Management_Work_Order_Add_New_Services.btn_new_services_save.Text = "UPDATE"
                Else
                    'Management_Work_Order_Add_New_Services.btn_new_services_save.Text = "SAVE"
                End If

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
                    total_service_cost = 0.00
                    If sql_dt.Rows.Count > 0 Then
                        For row As Integer = 0 To service.Length - 1
                            .Rows.Add(service(row), CDec(s_cost(row)))
                            total_service_cost += CDec(s_cost(row))
                        Next
                    End If
                End With
                'Addding columns to servicesDatagrid view
                With InvoiceServicesDataGridView
                    .Columns.Clear()
                    .AutoGenerateColumns = False
                    .DataSource = services_dt
                    'Adding the first column
                    Dim Description As New DataGridViewTextBoxColumn
                    With Description
                        .HeaderText = "Service Description"
                        .DataPropertyName = "Description"
                    End With
                    .Columns.Add(Description)
                    'Adding the second column
                    Dim Cost As New DataGridViewTextBoxColumn
                    With Cost
                        .HeaderText = "Cost/GHS"
                        .DataPropertyName = "Cost"
                    End With
                    .Columns.Add(Cost)
                    .Columns(0).Width = 600
                End With


                sql_da = New MySqlDataAdapter("SELECT  `Description`, `Quantity`, `Cost`, `Unit_Cost` FROM `parts` WHERE `Work_Order_ID` = '" & txt_invoice_work_order.Text & "'", sql_con)
                sql_dt = New DataTable
                sql_dt.Clear()
                sql_da.Fill(sql_dt)

                If sql_dt.Rows.Count > 0 Then
                    descriptions = sql_dt.Rows(0).Item("Description").ToString.Split("-")
                    quantitys = sql_dt.Rows(0).Item("Quantity").ToString.Split("-")
                    costs = sql_dt.Rows(0).Item("Cost").ToString.Split("-")
                    unit_costs = sql_dt.Rows(0).Item("Unit_Cost").ToString.Split("-")
                End If


                ''""""""""
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
                    Dim unit_cost As New DataColumn
                    With unit_cost
                        .ColumnName = "Unit_Cost"
                        .Caption = "Unit_Cost"
                    End With
                    .Columns.Add(unit_cost)
                    Dim cost As New DataColumn
                    With cost
                        .ColumnName = "Cost"
                        .Caption = "Cost / GHS"
                    End With
                    .Columns.Add(cost)
                    total_part_cost = 0.00
                    If sql_dt.Rows.Count > 0 Then
                        For row As Integer = 0 To descriptions.Length - 1
                            .Rows.Add(descriptions(row), quantitys(row), CDec(unit_costs(row)), CDec(costs(row)))
                            total_part_cost += CDec(costs(row))
                        Next
                    End If
                End With

                With InvoicePartsDataGridView
                    .Columns.Clear()
                    .AutoGenerateColumns = False
                    .DataSource = parts_dt
                    '
                    Dim parts_name As New DataGridViewTextBoxColumn
                    With parts_name
                        .HeaderText = "Parts Name / Description"
                        .DataPropertyName = "Parts_Name"
                    End With
                    .Columns.Add(parts_name)
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
                        .HeaderText = "Cost / GHS"
                        .DataPropertyName = "Cost"
                    End With
                    .Columns.Add(Cost)
                    .Columns(0).Width = 350
                End With
                calculate()
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class