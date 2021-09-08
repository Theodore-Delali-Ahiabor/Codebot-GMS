Imports MySql.Data.MySqlClient
Public Class Management
    Public Sub Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Codehbot Garage Management System"
        sidebar_active(btn_home)
        sidebar_form_loader(Management_Home)
        box_collections_fill()
    End Sub
    Public Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        sidebar_active(sender)
        sidebar_form_loader(Management_Home)
        Management_Home.activebar_work_orders.Visible = True
        Management_Home.work_order_due_soon_Click(Management_Home.work_order_due_soon, EventArgs.Empty)
        Management_Home.work_order_overdue_Click(Management_Home.work_order_overdue, EventArgs.Empty)
        Management_Home.low_inventory_low_stock_Click(Management_Home.low_inventory_low_stock, EventArgs.Empty)
        Management_Home.low_inventory_out_of_stock_Click(Management_Home.low_inventory_out_of_stock, EventArgs.Empty)
        work_order_overdue_filter("6")
        datagrif_fill_column_resize("work_order_view", Management_Home.HomeDataGridView)
    End Sub
    Private Sub btn_market_Click(sender As Object, e As EventArgs) Handles btn_market.Click
        sidebar_active(sender)
        sidebar_form_loader(Management_Market)
    End Sub
    Public Sub btn_work_orders_Click(sender As Object, e As EventArgs) Handles btn_work_orders.Click
        sidebar_active(sender)
        sidebar_form_loader(Management_Work_Order)
        datagrid_fill_default("work_order_view", Management_Work_Order.WorkOrderDataGridView)
        datagrif_fill_column_resize("work_order_view", Management_Work_Order.WorkOrderDataGridView)
    End Sub

    Public Sub btn_invoice_Click(sender As Object, e As EventArgs) Handles btn_invoice.Click
        sidebar_active(sender)
    End Sub

    Public Sub btn_inventory_Click(sender As Object, e As EventArgs) Handles btn_inventory.Click
        sidebar_active(sender)
        sidebar_form_loader(Management_Inventory)
        datagrid_fill_default("inventory", Management_Inventory.InventoryDataGridView)
        datagrif_fill_column_resize("inventory", Management_Inventory.InventoryDataGridView)
    End Sub

    Private Sub btn_purcahse_orders_Click(sender As Object, e As EventArgs) Handles btn_purcahse_orders.Click
        sidebar_active(sender)
    End Sub

    Public Sub btn_employees_Click(sender As Object, e As EventArgs) Handles btn_employees.Click
        sidebar_active(sender)
        sidebar_form_loader(Management_Employees)
        datagrid_fill_default("employee_view", Management_Employees.EmployeesDataGridView)
        datagrif_fill_column_resize("employee_view", Management_Employees.EmployeesDataGridView)
    End Sub

    Public Sub btn_statistics_Click(sender As Object, e As EventArgs) Handles btn_statistics.Click
        sidebar_active(sender)
    End Sub
    Private Sub btn_calenders_Click(sender As Object, e As EventArgs) Handles btn_calenders.Click
        sidebar_active(sender)
        sidebar_form_loader(Management_Calendar)
    End Sub
    Public Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        gms_main_form_loader(Auth)
        Auth_Login.txt_login_username.Clear()
        Auth_Login.txt_login_password.Clear()
        Auth_Login.txt_login_username.Focus()
        Auth.btn_auth_message.Text = "You Logged Out Successfuly"
        Auth.btn_auth_message.Show()
        message(Auth.btn_auth_message, "success")
    End Sub
    Public Sub sidebar_active(ByVal btn As Button)
        While btn.BackColor = Color.Teal
            btn_home.BackColor = Color.Teal
            btn_market.BackColor = Color.Teal
            btn_calenders.BackColor = Color.Teal
            btn_employees.BackColor = Color.Teal
            btn_inventory.BackColor = Color.Teal
            btn_purcahse_orders.BackColor = Color.Teal
            btn_work_orders.BackColor = Color.Teal
            btn_statistics.BackColor = Color.Teal
            btn_invoice.BackColor = Color.Teal
            btn.BackColor = Color.CadetBlue
            btn.Focus()
        End While
        lbl_current_tab.Text = btn.Text
    End Sub
    Public Sub systemtime_Tick(sender As Object, e As EventArgs) Handles systemtime.Tick
        current_date.Text = Date.Now.ToShortDateString
        current_time.Text = TimeOfDay
    End Sub

    Private Sub btn_management_message_Click(sender As Object, e As EventArgs) Handles btn_management_message.Click
        btn_management_message.Hide()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        If btn_home.BackColor = Color.CadetBlue Then
            btn_home_Click(sender, e)
            lbl_current_tab.Text = "Dashboard | Work Oders Due"
        ElseIf btn_employees.BackColor = Color.CadetBlue Then
            btn_employees_Click(sender, e)
            lbl_current_tab.Text = "Employees"
        ElseIf btn_inventory.BackColor = Color.CadetBlue Then
            btn_inventory_Click(sender, e)
            lbl_current_tab.Text = "Inventory"
        ElseIf btn_work_orders.BackColor = Color.CadetBlue Then
            btn_work_orders_Click(sender, e)
        ElseIf btn_market.BackColor = Color.CadetBlue Then
            btn_market_Click(sender, e)
        ElseIf btn_calenders.BackColor = Color.CadetBlue Then
            btn_calenders_Click(sender, e)
        ElseIf btn_invoice.BackColor = Color.CadetBlue Then
            btn_invoice_Click(sender, e)
        End If
    End Sub

End Class