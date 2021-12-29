Imports MySql.Data.MySqlClient
Public Class Management_Dashboard
    Private Sub work_oders_due_panel_Click(sender As Object, e As EventArgs) Handles work_oders_due_panel.Click
        work_order_overdue_filter("8")
    End Sub

    Private Sub low_inventory_panel_Click(sender As Object, e As EventArgs) Handles low_inventory_panel.Click
        activebar_work_orders.Visible = False
        activebar_inventory.Visible = True
        activebar_events.Visible = False
        activebar_payments.Visible = False
        datagrid_fill_flter_with_variable("inventory_view", Me.DashboardDataGridView, "Stock", "<", "11")
        Management.lbl_current_tab.Text = "Dashboard | Inventory Low"
    End Sub
    Private Sub upcoming_events_panel_Click(sender As Object, e As EventArgs) Handles upcoming_events_panel.Click
        upcoming_calendar_events("<", "8")
        Management.lbl_current_tab.Text = "Dashboard | Upcoming Events"
    End Sub
    Private Sub invoice_payments_panel_Click(sender As Object, e As EventArgs) Handles invoice_payments_panel.Click
        activebar_work_orders.Visible = False
        activebar_inventory.Visible = False
        activebar_events.Visible = False
        activebar_payments.Visible = True
        datagrid_fill_flter_with_variable("invoice", Me.DashboardDataGridView, "Payment_Status", "<>", "'" & "Full Payment" & "'")
        Management.lbl_current_tab.Text = "Dashboard | Invoice Payments"
    End Sub
    Private Sub lbl_work_orders_due_Click(sender As Object, e As EventArgs) Handles lbl_work_orders_due.Click
        work_oders_due_panel_Click(work_oders_due_panel, EventArgs.Empty)
    End Sub

    Private Sub lbl_low_inventory_Click(sender As Object, e As EventArgs) Handles lbl_low_inventory.Click
        low_inventory_panel_Click(low_inventory_panel, EventArgs.Empty)
    End Sub
    Private Sub lbl_invoice_payments_Click(sender As Object, e As EventArgs) Handles lbl_invoice_payments.Click
        invoice_payments_panel_Click(invoice_payments_panel, EventArgs.Empty)
    End Sub
    Private Sub lbl_upcoming_events_Click(sender As Object, e As EventArgs) Handles lbl_upcoming_events.Click
        upcoming_events_panel_Click(upcoming_events_panel, EventArgs.Empty)
    End Sub
    Private Sub PictureBoxInventory_Click(sender As Object, e As EventArgs) Handles PictureBoxInventory.Click
        low_inventory_panel_Click(low_inventory_panel, EventArgs.Empty)
    End Sub

    Private Sub PictureBoxWorkOrders_Click(sender As Object, e As EventArgs) Handles PictureBoxWorkOrders.Click
        work_oders_due_panel_Click(work_oders_due_panel, EventArgs.Empty)
    End Sub

    Public Sub work_order_overdue_Click(sender As Object, e As EventArgs) Handles work_order_overdue.Click
        work_order_overdue_filter("0")
        Me.work_order_overdue.Text = DashboardDataGridView.Rows().Count & " Overdue"
    End Sub

    Public Sub work_order_due_soon_Click(sender As Object, e As EventArgs) Handles work_order_due_soon.Click
        activebar_work_orders.Visible = True
        activebar_inventory.Visible = False
        activebar_payments.Visible = False
        activebar_events.Visible = False
        sql_da = New MySqlDataAdapter("SELECT * FROM `work_order_view` WHERE `Due_In` < 8 AND `Due_In` > -1 AND `Progress_Status` <>'" & "Completed" & "' AND `Progress_Status` <>'" & "Terminated" & "' ORDER BY ID DESC ", sql_con)
        sql_dt = New DataTable
        sql_dt.Clear()
        sql_da.Fill(sql_dt)
        Me.DashboardDataGridView.DataSource = sql_dt
        datagrid_fill_color_effect("work_order_view", Me.DashboardDataGridView)
        datagrid_fill_column_resize("work_order_view", Me.DashboardDataGridView)
        Me.work_order_due_soon.Text = DashboardDataGridView.Rows().Count & " Soon"
        Management.lbl_current_tab.Text = "Dashboard | Work Oders Due"
    End Sub
    Public Sub work_order_due_today_Click(sender As Object, e As EventArgs) Handles work_order_due_today.Click
        activebar_work_orders.Visible = True
        activebar_inventory.Visible = False
        activebar_payments.Visible = False
        activebar_events.Visible = False
        sql_da = New MySqlDataAdapter("SELECT * FROM `work_order_view` WHERE `Due_In` = 0 AND `Progress_Status` <>'" & "Completed" & "' AND `Progress_Status` <>'" & "Terminated" & "' ORDER BY ID DESC ", sql_con)
        sql_dt = New DataTable
        sql_dt.Clear()
        sql_da.Fill(sql_dt)
        Me.DashboardDataGridView.DataSource = sql_dt
        datagrid_fill_color_effect("work_order_view", Me.DashboardDataGridView)
        datagrid_fill_column_resize("work_order_view", Me.DashboardDataGridView)
        Management.lbl_current_tab.Text = "Dashboard | Work Oders Due"
        Me.work_order_due_today.Text = DashboardDataGridView.Rows().Count & " Today"
    End Sub
    Public Sub low_inventory_out_of_stock_Click(sender As Object, e As EventArgs) Handles low_inventory_out_of_stock.Click
        activebar_work_orders.Visible = False
        activebar_inventory.Visible = True
        activebar_payments.Visible = False
        activebar_events.Visible = False
        datagrid_fill_flter_with_variable("inventory_view", Me.DashboardDataGridView, "Stock", "=", "0")
        Me.low_inventory_out_of_stock.Text = DashboardDataGridView.Rows.Count & " Out of Stock"
        Management.lbl_current_tab.Text = "Dashboard | Inventory Low"
    End Sub

    Public Sub low_inventory_low_stock_Click(sender As Object, e As EventArgs) Handles low_inventory_low_stock.Click
        activebar_work_orders.Visible = False
        activebar_inventory.Visible = True
        activebar_payments.Visible = False
        activebar_events.Visible = False
        sql_da = New MySqlDataAdapter("SELECT * FROM inventory_view WHERE Stock < 10 AND Stock <> 0 ORDER BY ID DESC", sql_con)
        sql_dt = New DataTable
        sql_dt.Clear()
        sql_da.Fill(sql_dt)
        Me.DashboardDataGridView.DataSource = sql_dt
        datagrid_fill_color_effect("inventory_view", Me.DashboardDataGridView)
        datagrid_fill_column_resize("inventory_view", Me.DashboardDataGridView)
        Me.low_inventory_low_stock.Text = DashboardDataGridView.Rows.Count & " Low Stock"
        Management.lbl_current_tab.Text = "Dashboard | Inventory Low"
    End Sub
    Public Sub upcoming_events_past_Click(sender As Object, e As EventArgs) Handles upcoming_events_past.Click
        upcoming_calendar_events("<", "0")
        Me.upcoming_events_past.Text = DashboardDataGridView.Rows.Count & " Past"
    End Sub
    Public Sub upcoming_events_soon_Click(sender As Object, e As EventArgs) Handles upcoming_events_soon.Click
        upcoming_calendar_events("<", "8")
        Me.upcoming_events_soon.Text = DashboardDataGridView.Rows.Count & " soon"
    End Sub

    Public Sub upcoming_events_today_Click(sender As Object, e As EventArgs) Handles upcoming_events_today.Click
        upcoming_calendar_events("=", "0")
        Me.upcoming_events_today.Text = DashboardDataGridView.Rows.Count & " Today"
    End Sub
    Public Sub invoice_payments_pending_Click(sender As Object, e As EventArgs) Handles invoice_payments_pending.Click
        activebar_work_orders.Visible = False
        activebar_inventory.Visible = False
        activebar_events.Visible = False
        activebar_payments.Visible = True
        datagrid_fill_flter_with_variable("invoice", Me.DashboardDataGridView, "Payment_Status", " LIKE ", "'" & "Pending" & "'")
        Me.invoice_payments_pending.Text = DashboardDataGridView.Rows.Count & " Pending"
        Management.lbl_current_tab.Text = "Dashboard | Invoice Payments"
    End Sub

    Public Sub invoice_payments_incomplete_Click(sender As Object, e As EventArgs) Handles invoice_payments_incomplete.Click
        activebar_work_orders.Visible = False
        activebar_inventory.Visible = False
        activebar_events.Visible = False
        activebar_payments.Visible = True
        datagrid_fill_flter_with_variable("invoice", Me.DashboardDataGridView, "Payment_Status", " LIKE ", "'" & "Partial Payment" & "'")
        Me.invoice_payments_incomplete.Text = DashboardDataGridView.Rows.Count & " Incomplete"
        Management.lbl_current_tab.Text = "Dashboard | Invoice Payments"
    End Sub
    Private Sub HomeDataGridView_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DashboardDataGridView.ColumnHeaderMouseClick
        If activebar_work_orders.Visible = True Then
            datagrid_fill_color_effect("work_order_view", Me.DashboardDataGridView)
        ElseIf activebar_inventory.Visible = True Then
            datagrid_fill_color_effect("inventory_view", Me.DashboardDataGridView)
        ElseIf activebar_events.Visible = True Then
            datagrid_fill_color_effect("events_view", Me.DashboardDataGridView)
        ElseIf activebar_payments.Visible = True Then
            'datagrid_fill_color_effect("", Me.DashboardDataGridView)
        End If
    End Sub


End Class