Imports MySql.Data.MySqlClient
Public Class Management
    Public Sub Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Codehbot Garage Management System"
        sidebar_active(btn_home)
        sidebar_form_loader(Management_Home)
        box_collections_fill()
    End Sub
    Public Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Me.lbl_current_tab.Text = "Dashboard | Work Oders Due"
        sidebar_active(sender)
        sidebar_form_loader(Management_Home)
        Management_Home.activebar_work_orders.Visible = True
        With Management_Home
            .work_order_due_soon_Click(.work_order_due_soon, EventArgs.Empty)
            .work_order_overdue_Click(.work_order_overdue, EventArgs.Empty)
            .low_inventory_low_stock_Click(.low_inventory_low_stock, EventArgs.Empty)
            .low_inventory_out_of_stock_Click(.low_inventory_out_of_stock, EventArgs.Empty)
            .upcoming_events_soon_Click(.upcoming_events_soon, EventArgs.Empty)
            .upcoming_events_today_Click(.upcoming_events_today, EventArgs.Empty)
            .invoice_payments_pending_Click(.invoice_payments_pending, EventArgs.Empty)
            .invoice_payments_incomplete_Click(.invoice_payments_incomplete, EventArgs.Empty)
            work_order_overdue_filter("6")
            datagrif_fill_column_resize("work_order_view", .HomeDataGridView)
        End With
    End Sub
    Public Sub btn_work_orders_Click(sender As Object, e As EventArgs) Handles btn_work_orders.Click
        sidebar_active(sender)
        sidebar_form_loader(Management_Work_Order)
        datagrid_fill_default("work_order_view", Management_Work_Order.WorkOrderDataGridView)
        datagrif_fill_column_resize("work_order_view", Management_Work_Order.WorkOrderDataGridView)
        Management_Work_Order.txt_work_order_automobile_name_filter.Clear()
        Management_Work_Order.cmb_work_order_status_filter.SelectedIndex() = 0
    End Sub

    Public Sub btn_invoice_Click(sender As Object, e As EventArgs) Handles btn_invoice.Click
        sidebar_active(sender)
        sidebar_form_loader(Management_Invoice)
        datagrid_fill_default("invoice", Management_Invoice.InvoiceDataGridView)
        Management_Invoice.txt_invoice_id_filter.Clear()
        Management_Invoice.cmb_payment_status_filter.SelectedIndex() = 0
    End Sub

    Public Sub btn_inventory_Click(sender As Object, e As EventArgs) Handles btn_inventory.Click
        sidebar_active(sender)
        sidebar_form_loader(Management_Inventory)
        datagrid_fill_default("inventory", Management_Inventory.InventoryDataGridView)
        datagrif_fill_column_resize("inventory", Management_Inventory.InventoryDataGridView)
        Management_Inventory.txt_inventory_part_name_filter.Clear()
        Management_Inventory.cmb_inventory_category_filter.SelectedIndex() = 0
        Management_Inventory.cmb_inventory_location_filter.SelectedIndex() = 0
    End Sub

    Private Sub btn_purcahse_orders_Click(sender As Object, e As EventArgs) Handles btn_logs.Click
        sidebar_active(sender)
    End Sub

    Public Sub btn_employees_Click(sender As Object, e As EventArgs) Handles btn_employees.Click
        sidebar_active(sender)
        sidebar_form_loader(Management_Employees)
        datagrid_fill_default("employee_view", Management_Employees.EmployeesDataGridView)
        datagrif_fill_column_resize("employee_view", Management_Employees.EmployeesDataGridView)
        Management_Employees.txt_employee_name_filter.Clear()
        Management_Employees.cmb_employee_position_filter.SelectedIndex() = 0
    End Sub
    '
    Public Sub btn_statistics_Click(sender As Object, e As EventArgs) Handles btn_statistics.Click
        sidebar_active(sender)
    End Sub
    'CLICK EVENT FOR THE CALENDAR BUTTON ON THE SIDEBAR
    Private Sub btn_calenders_Click(sender As Object, e As EventArgs) Handles btn_calenders.Click
        sidebar_active(sender)
        sidebar_form_loader(Management_Calendar)
        Management_Calendar.display_current_date()
    End Sub
    Private Sub btn_messages_Click(sender As Object, e As EventArgs) Handles btn_messages.Click
        sidebar_active(sender)
        'sidebar_form_loader(Management_Calendar)
    End Sub
    'TO LOG A USER OUT OF THE SYSTEM
    Public Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        gms_main_form_loader(Auth)
        Auth_Login.txt_login_username.Clear()
        Auth_Login.txt_login_password.Clear()
        Auth_Login.txt_login_username.Focus()
        Auth.btn_auth_message.Text = "You Logged Out Successfuly"
        Auth.btn_auth_message.Show()
        message(Auth.btn_auth_message, "success")
    End Sub
    'CHANGES THE BACKGROUND COLOR OF THE SIDEBAR BUTTONS WHEN CLICKED
    Public Sub sidebar_active(ByVal btn As Button)
        While btn.BackColor = Color.Teal
            btn_home.BackColor = Color.Teal
            btn_calenders.BackColor = Color.Teal
            btn_employees.BackColor = Color.Teal
            btn_inventory.BackColor = Color.Teal
            btn_logs.BackColor = Color.Teal
            btn_work_orders.BackColor = Color.Teal
            btn_statistics.BackColor = Color.Teal
            btn_invoice.BackColor = Color.Teal
            btn_messages.BackColor = Color.Teal
            btn.BackColor = Color.CadetBlue
            btn.Focus()
        End While
        lbl_current_tab.Text = btn.Text
    End Sub
    'DISPLAYS THE CURRENT DATE AND TIME IN THE LOWER RIGHT CORNNER 
    Public Sub systemtime_Tick(sender As Object, e As EventArgs) Handles systemtime.Tick
        current_date.Text = Date.Now.ToShortDateString
        current_time.Text = TimeOfDay
    End Sub
    'TO HIDE THE MESSAGE WHEN CLICKED 
    Private Sub btn_management_message_Click(sender As Object, e As EventArgs) Handles btn_management_message.Click
        btn_management_message.Hide()
    End Sub
    'THE REFRESH BUTTON CALLS THE SIDEBAR CLICK EVENTS BASED ON THE ACTIVE BUTTON 
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        If btn_home.BackColor = Color.CadetBlue Then
            Me.btn_home_Click(Me.btn_home, EventArgs.Empty)
        ElseIf btn_employees.BackColor = Color.CadetBlue Then
            Me.btn_employees_Click(Me.btn_employees, EventArgs.Empty)
        ElseIf btn_inventory.BackColor = Color.CadetBlue Then
            Me.btn_inventory_Click(Me.btn_inventory, EventArgs.Empty)
        ElseIf btn_work_orders.BackColor = Color.CadetBlue Then
            Me.btn_work_orders_Click(Me.btn_work_orders, EventArgs.Empty)
        ElseIf btn_calenders.BackColor = Color.CadetBlue Then
            Me.btn_calenders_Click(Me.btn_calenders, EventArgs.Empty)
        ElseIf btn_invoice.BackColor = Color.CadetBlue Then
            Me.btn_invoice_Click(Me.btn_invoice, EventArgs.Empty)
        End If
    End Sub

    Private Sub tsmi_work_order_Click(sender As Object, e As EventArgs) Handles tsmi_work_order.Click
        Management_Work_Order.btn_add_new_work_order_Click(Management_Work_Order.btn_add_new_work_order, EventArgs.Empty)
    End Sub

    Private Sub tsmi_part_Click(sender As Object, e As EventArgs) Handles tsmi_part.Click
        Management_Inventory.btn_add_new_inventory_item_Click(Management_Inventory.btn_add_new_inventory_item, EventArgs.Empty)
    End Sub

    Private Sub tsmi_invoice_Click(sender As Object, e As EventArgs) Handles tsmi_invoice.Click
        Management_Invoice.btn_add_new_invoice_Click(Management_Invoice.btn_add_new_invoice, EventArgs.Empty)
    End Sub

    Private Sub tsmi_employee_Click(sender As Object, e As EventArgs) Handles tsmi_employee.Click
        Management_Employees.btn_add_new_employee_Click(Management_Employees.btn_add_new_employee, EventArgs.Empty)
    End Sub

    Private Sub tsmi_exit_Click(sender As Object, e As EventArgs) Handles tsmi_exit.Click
        GMS_Main.Close()
    End Sub


End Class