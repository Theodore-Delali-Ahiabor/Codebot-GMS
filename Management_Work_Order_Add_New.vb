Imports MySql.Data.MySqlClient
Public Class Management_Work_Order_Add_New
    Public customer, automobile, services_id, parts_id As Integer
    Public date_in, date_due_out As String
    Dim service(), s_cost() As String
    Dim descriptions(), quantitys(), stocks(), costs(), unit_costs() As String

    Private Sub btn_new_work_order_new_cusromer_Click(sender As Object, e As EventArgs) Handles btn_new_work_order_new_cusromer.Click
        With Management_Work_Order_Add_New_Customer
            .clearCustomer()
            .customer_new_datails_panel.Dock = DockStyle.Fill
            .customer_select_edit_panel.Visible = False
            .customer_new_datails_panel.Visible = True
            .ShowDialog()
            .btn_new_customer_save.Text = "SAVE"
        End With
    End Sub

    Public Sub btn_new_work_order_new_automobile_Click(sender As Object, e As EventArgs) Handles btn_new_work_order_new_automobile.Click
        With Management_Work_Order_Add_New_Automobile
            .clearAutomobile()
            .automobile_new_datails_panel.Dock = DockStyle.Fill
            .automobile_select_edit_panel.Visible = False
            .automobile_new_datails_panel.Visible = True
            .ShowDialog()
            .btn_new_automobile_save.Text = "SAVE"
        End With
    End Sub

    Private Sub btn_new_item_cancel_Click(sender As Object, e As EventArgs) Handles btn_new_item_cancel.Click
        sidebar_form_loader(Management_Work_Order)
        Management.lbl_current_tab.Text = "Work Orders"
    End Sub

    Private Sub btn_new_item_save_Click(sender As Object, e As EventArgs) Handles btn_new_item_save.Click
        Try
            If txt_work_order_new_customer.Text <> "" And txt_work_order_new_automobile.Text <> "" And txt_new_work_order_technicians.Text <> "" And txt_new_work_order_date_in.Checked = True And txt_new_work_order_date_out.Checked = True And
           txt_new_work_order_mileage.Text <> "" And txt_new_work_order_progress_stats.Text <> "" Then
                date_in = txt_new_work_order_date_in.Value.Year & "-" & txt_new_work_order_date_in.Value.Month & "-" & txt_new_work_order_date_in.Value.Day
                date_due_out = txt_new_work_order_date_out.Value.Year & "-" & txt_new_work_order_date_out.Value.Month & "-" & txt_new_work_order_date_out.Value.Day
                Dim repos As DialogResult = MessageBox.Show("You are about to Add a new Work Order, are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If btn_new_item_save.Text = "SAVE" Then
                    If repos = DialogResult.Yes Then
                        sql_ds = New DataSet
                        sql_da = New MySqlDataAdapter("INSERT INTO work_order(`Customer`,`Automobile`,`Technician`,`Date_In`,`Date_Due_Out`,`Mileage`,`Parts_ID`, `Services_ID`,`Status`,`Relevant_Informations`,`Created_On`,`Created_By`,`Last_Modified_On`,`Last_Modified_By`)
                            VALUES('" & customer & "','" & automobile & "','" & txt_new_work_order_technicians.Text & "', '" & date_in & "','" & date_due_out & "','" & txt_new_work_order_mileage.Text & "', '" & parts_id & "', '" & services_id & "','" & txt_new_work_order_progress_stats.Text & "',
                            '" & txt_new_work_order_relevant_information.Text & "',SYSDATE(),'" & login_id & "',SYSDATE(),'" & login_id & "')", sql_con)
                        sql_da.Fill(sql_ds, "work_order")
                        sidebar_form_loader(Management_Work_Order)
                        datagrid_fill_default("work_order_view", Management_Work_Order.WorkOrderDataGridView)
                        message("success", "Work Order Added Successflly")
                    End If
                Else
                    If repos = DialogResult.Yes Then
                        sql_ds = New DataSet
                        sql_da = New MySqlDataAdapter("UPDATE `work_order` SET `Customer`='" & customer & "',`Automobile`='" & automobile & "',`Technician`='" & txt_new_work_order_technicians.Text & "',`Date_In`='" & date_in & "',`Date_Due_Out`='" & date_due_out & "',`Mileage`='" & txt_new_work_order_mileage.Text & "',`Parts_ID`='" & parts_id & "'
                            ,`Services_ID`='" & services_id & "',`Status`='" & txt_new_work_order_progress_stats.Text & "',`Relevant_Informations`='" & txt_new_work_order_relevant_information.Text & "',`Last_Modified_On`=SYSDATE(),`Last_Modified_By`='" & login_id & "' WHERE `ID`='" & lbl_new_work_order_id.Text & "'", sql_con)
                        sql_da.Fill(sql_ds, "work_order")
                        sidebar_form_loader(Management_Work_Order)
                        datagrid_fill_default("work_order_view", Management_Work_Order.WorkOrderDataGridView)
                        message("success", "Work Order Updated Successflly")
                    End If
                End If
            Else
                message("warning", "Please fill out all required (*) fields")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Save New Work Order Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_new_work_order_existing_automobile_Click(sender As Object, e As EventArgs) Handles btn_new_work_order_existing_automobile.Click
        Management_Work_Order_Add_New_Automobile.automobile_select_edit_panel.Dock = DockStyle.Fill
        Management_Work_Order_Add_New_Automobile.automobile_select_edit_panel.Visible = True
        Management_Work_Order_Add_New_Automobile.automobile_new_datails_panel.Visible = False
        datagrid_fill_default("automobile_info", Management_Work_Order_Add_New_Automobile.AutomobileDataGridView)
        Management_Work_Order_Add_New_Automobile.ShowDialog()
        Management_Work_Order_Add_New_Automobile.AutomobileDataGridView.Rows(0).Selected = True
    End Sub

    Private Sub btn_new_work_order_existing_cusromer_Click(sender As Object, e As EventArgs) Handles btn_new_work_order_existing_cusromer.Click
        Management_Work_Order_Add_New_Customer.customer_select_edit_panel.Dock = DockStyle.Fill
        Management_Work_Order_Add_New_Customer.customer_select_edit_panel.Visible = True
        Management_Work_Order_Add_New_Customer.customer_new_datails_panel.Visible = False
        datagrid_fill_default("customer_info", Management_Work_Order_Add_New_Customer.CustomerDataGridView)
        Management_Work_Order_Add_New_Customer.ShowDialog()
        Management_Work_Order_Add_New_Customer.CustomerDataGridView.Rows(0).Selected = True
    End Sub

    Private Sub work_order_clear_customer_Click(sender As Object, e As EventArgs) Handles work_order_clear_customer.Click
        txt_work_order_new_customer.Clear()
    End Sub

    Private Sub work_order_cleartechnician_Click(sender As Object, e As EventArgs) Handles work_order_cleartechnician.Click
        txt_new_work_order_technicians.Clear()
    End Sub

    Private Sub txt_new_work_order_relevant_information_TextChanged(sender As Object, e As EventArgs) Handles txt_new_work_order_relevant_information.TextChanged
        lbl_relevant_infomation_character_count.Text = "(" + (200 - txt_new_work_order_relevant_information.TextLength).ToString + "/200)"
    End Sub

    Private Sub btn_new_work_order_add_services_Click(sender As Object, e As EventArgs) Handles btn_new_work_order_add_services.Click
        Try
            sql_da = New MySqlDataAdapter("SELECT `Service`,`Cost` FROM `services` WHERE `Work_Order_ID` ='" & lbl_new_work_order_id.Text & "'  ORDER BY ID DESC", sql_con)
            sql_dt = New DataTable
            sql_dt.Clear()
            sql_da.Fill(sql_dt)

            If sql_dt.Rows.Count > 0 Then
                service = sql_dt.Rows(0).Item("Service").ToString.Split("-")
                s_cost = sql_dt.Rows(0).Item("Cost").ToString.Split("-")
                Management_Work_Order_Add_New_Services.btn_new_services_save.Text = "UPDATE"
            Else
                Management_Work_Order_Add_New_Services.btn_new_services_save.Text = "SAVE"
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
                If sql_dt.Rows.Count > 0 Then
                    For row As Integer = 0 To service.Length - 1
                        .Rows.Add(service(row), CDbl(s_cost(row)))
                    Next
                End If
            End With
            'Addding columns to servicesDatagrid view
            With Management_Work_Order_Add_New_Services.ServicesDataGridView
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
                .Columns(0).Width = 800
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Services Data Display Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        Management_Work_Order_Add_New_Services.ShowDialog()
    End Sub

    Private Sub btn_new_work_order_add_parts_Click(sender As Object, e As EventArgs) Handles btn_new_work_order_add_parts.Click
        Try
            sql_da = New MySqlDataAdapter("SELECT  `Description`, `Quantity`, `Stock`, `Cost`, `Unit_Cost` FROM `parts` WHERE `Work_Order_ID` = '" & lbl_new_work_order_id.Text & "'", sql_con)
            sql_dt = New DataTable
            sql_dt.Clear()
            sql_da.Fill(sql_dt)

            If sql_dt.Rows.Count > 0 Then
                descriptions = sql_dt.Rows(0).Item("Description").ToString.Split("-")
                quantitys = sql_dt.Rows(0).Item("Quantity").ToString.Split("-")
                stocks = sql_dt.Rows(0).Item("Stock").ToString.Split("-")
                costs = sql_dt.Rows(0).Item("Cost").ToString.Split("-")
                unit_costs = sql_dt.Rows(0).Item("Unit_Cost").ToString.Split("-")
                Management_Work_Order_Add_New_Parts.btn_new_parts_save.Text = "UPDATE"
            Else
                Management_Work_Order_Add_New_Parts.btn_new_parts_save.Text = "SAVE"
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
                Dim Stock As New DataColumn
                With Stock
                    .ColumnName = "Stock"
                    .Caption = "Stock"
                End With
                .Columns.Add(Stock)
                Dim cost As New DataColumn
                With cost
                    .ColumnName = "Cost"
                    .Caption = "Cost / GHS"
                End With
                .Columns.Add(cost)
                Dim unit_cost As New DataColumn
                With unit_cost
                    .ColumnName = "Unit_Cost"
                    .Caption = "Unit_Cost"
                End With
                .Columns.Add(unit_cost)
                If sql_dt.Rows.Count > 0 Then
                    For row As Integer = 0 To descriptions.Length - 1
                        .Rows.Add(descriptions(row), quantitys(row), stocks(row), CDbl(costs(row)), CDbl(unit_costs(row)))
                    Next
                End If
            End With

            With Management_Work_Order_Add_New_Parts.PartsDataGridView
                .Columns.Clear()
                .AutoGenerateColumns = False
                .DataSource = parts_dt
                '
                Dim parts_name As New DataGridViewComboBoxColumn
                With parts_name
                    .HeaderText = "Parts Name / Description"
                    .DataPropertyName = "Parts_Name"
                    .DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox

                    Dim sql_cmd As New MySqlCommand("SELECT * FROM inventory WHERE Stock > 0", sql_con)
                    sql_con.Close()
                    sql_con.Open()
                    Dim sql_rdr As MySqlDataReader = sql_cmd.ExecuteReader()
                    'Add items to DataGridViewComboBoxColumn
                    While sql_rdr.Read
                        If parts_name.Items.Contains(sql_rdr.Item("Description").ToString) = False Then
                            parts_name.Items.Add(sql_rdr.Item("Description").ToString)
                        End If
                    End While
                    sql_con.Close()

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
                Dim Stock As New DataGridViewTextBoxColumn
                With Stock
                    .HeaderText = "Stock"
                    .DataPropertyName = "Stock"
                End With
                .Columns.Add(Stock)
                '
                Dim Cost As New DataGridViewTextBoxColumn
                With Cost
                    .HeaderText = "Cost / GHS"
                    .DataPropertyName = "Cost"
                End With
                .Columns.Add(Cost)
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
            MessageBox.Show(ex.Message, "Parts Data Display Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        Management_Work_Order_Add_New_Parts.ShowDialog()
    End Sub

    Private Sub work_order_clear_automobile_Click(sender As Object, e As EventArgs) Handles work_order_clear_automobile.Click
        txt_work_order_new_automobile.Clear()
    End Sub

    Private Sub btn_new_work_order_add_technician_Click(sender As Object, e As EventArgs) Handles btn_new_work_order_add_technician.Click
        datagrid_fill("technician_view", Management_Work_Order_Add_New_Technician.TechnicianDataGridView)
        Management_Work_Order_Add_New_Technician.ShowDialog()
    End Sub
    Public Function getServices()
        sql_da = New MySqlDataAdapter("SELECT * FROM `services` WHERE `Work_Order_ID` = '" & lbl_new_work_order_id.Text & "'", sql_con)
        sql_dt = New DataTable
        sql_dt.Clear()
        sql_da.Fill(sql_dt)

        Dim desTotal As Integer = 0
        Dim costTotal As Decimal = 0.00
        If sql_dt.Rows.Count > 0 Then
            Dim service() As String = sql_dt.Rows(0).Item("Service").ToString.Split("-")
            Dim cost() As String = sql_dt.Rows(0).Item("Cost").ToString.Split("-")
            For i As Integer = 0 To service.Length - 1
                costTotal += cost(i)
            Next
            services_id = sql_dt.Rows(0).Item("ID")
            desTotal = service.Length
        End If
        Return "  " + CStr(desTotal) + " Services | GHS " + CStr(costTotal)
    End Function
    Public Function getParts()
        sql_da = New MySqlDataAdapter("SELECT * FROM `parts` WHERE `Work_Order_ID` = '" & lbl_new_work_order_id.Text & "'", sql_con)
        sql_dt = New DataTable
        sql_dt.Clear()
        sql_da.Fill(sql_dt)
        Dim desTotal As Integer = 0
        Dim costTotal As Decimal = 0.00
        If sql_dt.Rows.Count > 0 Then
            Dim description() As String = sql_dt.Rows(0).Item("description").ToString.Split("-")
            Dim cost() As String = sql_dt.Rows(0).Item("Cost").ToString.Split("-")
            For i As Integer = 0 To cost.Length - 1
                costTotal += cost(i)
            Next
            parts_id = sql_dt.Rows(0).Item("ID")
            desTotal = description.Length
        End If
        Return "  " + CStr(desTotal) + " Parts | GHS " + CStr(costTotal)
    End Function


End Class