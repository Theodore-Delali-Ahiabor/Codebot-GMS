Imports MySql.Data.MySqlClient
Public Class Management_Home
    Private Sub work_oders_due_panel_Click(sender As Object, e As EventArgs) Handles work_oders_due_panel.Click
        work_order_overdue_filter("6")
        datagrif_fill_column_resize("work_order_view", Me.HomeDataGridView)
    End Sub

    Private Sub low_inventory_panel_Click(sender As Object, e As EventArgs) Handles low_inventory_panel.Click
        activebar_work_orders.Visible = False
        activebar_inventory.Visible = True
        activebar_events.Visible = False
        activebar_payments.Visible = False
        datagrid_fill_flter_with_variable("inventory", Me.HomeDataGridView, "Stock", "<", "10")
        datagrif_fill_column_resize("inventory", Me.HomeDataGridView)
        Management.lbl_current_tab.Text = "Dashboard | Inventory Low"
    End Sub
    Private Sub upcoming_events_panel_Click(sender As Object, e As EventArgs) Handles upcoming_events_panel.Click
        activebar_work_orders.Visible = False
        activebar_inventory.Visible = False
        activebar_events.Visible = True
        activebar_payments.Visible = False
        datagrid_fill_flter_with_variable("events_view", Me.HomeDataGridView, "Due_In", "<", "11")
        Management.lbl_current_tab.Text = "Dashboard | Upcoming Events"
    End Sub
    Private Sub invoice_payments_panel_Click(sender As Object, e As EventArgs) Handles invoice_payments_panel.Click
        activebar_work_orders.Visible = False
        activebar_inventory.Visible = False
        activebar_events.Visible = False
        activebar_payments.Visible = True
        datagrid_fill_flter_with_variable("invoice", Me.HomeDataGridView, "Payment_Status", "<>", "'" & "Full Payment" & "'")
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
        work_order_overdue_filter("1")
        Me.work_order_overdue.Text = HomeDataGridView.Rows().Count & " Overdue"
        datagrif_fill_column_resize("work_order_view", Me.HomeDataGridView)
    End Sub

    Public Sub work_order_due_soon_Click(sender As Object, e As EventArgs) Handles work_order_due_soon.Click
        activebar_work_orders.Visible = True
        activebar_inventory.Visible = False
        activebar_payments.Visible = False
        activebar_events.Visible = False
        sql_da = New MySqlDataAdapter("SELECT * FROM work_order_view WHERE Due_In < 6 AND Due_In > -1 AND Progress_Status <>'" & "Complete" & "' ORDER BY ID DESC ", sql_con)
        sql_dt = New DataTable
        sql_dt.Clear()
        sql_da.Fill(sql_dt)
        Me.HomeDataGridView.DataSource = sql_dt
        datagrid_fill_color_effect("work_order_view", Me.HomeDataGridView)
        Me.work_order_due_soon.Text = HomeDataGridView.Rows().Count & " Due Soon"
        Management.lbl_current_tab.Text = "Dashboard | Work Oders Due"
        clear_gridview_default_selection(Me.HomeDataGridView)
        datagrif_fill_column_resize("work_order_view", Me.HomeDataGridView)
    End Sub

    Public Sub low_inventory_out_of_stock_Click(sender As Object, e As EventArgs) Handles low_inventory_out_of_stock.Click
        activebar_work_orders.Visible = False
        activebar_inventory.Visible = True
        activebar_payments.Visible = False
        activebar_events.Visible = False
        datagrid_fill_flter_with_variable("inventory", Me.HomeDataGridView, "Stock", "=", "0")
        Me.low_inventory_out_of_stock.Text = HomeDataGridView.Rows.Count & " Out of Stock"
        datagrif_fill_column_resize("inventory", Me.HomeDataGridView)
        Management.lbl_current_tab.Text = "Dashboard | Inventory Low"
    End Sub

    Public Sub low_inventory_low_stock_Click(sender As Object, e As EventArgs) Handles low_inventory_low_stock.Click
        activebar_work_orders.Visible = False
        activebar_inventory.Visible = True
        activebar_payments.Visible = False
        activebar_events.Visible = False
        sql_da = New MySqlDataAdapter("SELECT * FROM inventory WHERE Stock < 10 AND Stock <> 0 ORDER BY ID DESC", sql_con)
        sql_dt = New DataTable
        sql_dt.Clear()
        sql_da.Fill(sql_dt)
        Me.HomeDataGridView.DataSource = sql_dt
        datagrid_fill_color_effect("inventory", Me.HomeDataGridView)
        datagrif_fill_column_resize("inventory", Me.HomeDataGridView)
        Me.low_inventory_low_stock.Text = HomeDataGridView.Rows.Count & " Low Stock"
        Management.lbl_current_tab.Text = "Dashboard | Inventory Low"
        clear_gridview_default_selection(Me.HomeDataGridView)
    End Sub
    Public Sub upcoming_events_past_Click(sender As Object, e As EventArgs) Handles upcoming_events_past.Click
        calendar_events("<", "0")

        'activebar_work_orders.Visible = False
        'activebar_inventory.Visible = False
        'activebar_payments.Visible = False
        'activebar_events.Visible = True
        'datagrid_fill_flter_with_variable("events_view", Me.HomeDataGridView, "Due_In", "<", "0")
        Me.upcoming_events_past.Text = HomeDataGridView.Rows.Count & " Past"
        'Management.lbl_current_tab.Text = "Dashboard | Upcoming Events"
    End Sub
    Public Sub upcoming_events_soon_Click(sender As Object, e As EventArgs) Handles upcoming_events_soon.Click
        activebar_work_orders.Visible = False
        activebar_inventory.Visible = False
        activebar_payments.Visible = False
        activebar_events.Visible = True
        sql_da = New MySqlDataAdapter("SELECT * FROM events_view WHERE Due_In < 11 AND Due_In > 0 AND Added_by = '" & login_id & "' ORDER BY ID DESC", sql_con)
        sql_dt = New DataTable
        sql_dt.Clear()
        sql_da.Fill(sql_dt)
        Me.HomeDataGridView.DataSource = sql_dt
        datagrid_fill_color_effect("events_view", Me.HomeDataGridView)
        clear_gridview_default_selection(Me.HomeDataGridView)
        Me.upcoming_events_soon.Text = HomeDataGridView.Rows.Count & " soon"
        Management.lbl_current_tab.Text = "Dashboard | Upcoming Events"
    End Sub

    Public Sub upcoming_events_today_Click(sender As Object, e As EventArgs) Handles upcoming_events_today.Click
        calendar_events("=", "0")
        Me.upcoming_events_today.Text = HomeDataGridView.Rows.Count & " Today"
    End Sub
    Public Sub invoice_payments_pending_Click(sender As Object, e As EventArgs) Handles invoice_payments_pending.Click
        activebar_work_orders.Visible = False
        activebar_inventory.Visible = False
        activebar_events.Visible = False
        activebar_payments.Visible = True
        datagrid_fill_flter_with_variable("invoice", Me.HomeDataGridView, "Payment_Status", " LIKE ", "'" & "Pending" & "'")
        Me.invoice_payments_pending.Text = HomeDataGridView.Rows.Count & " Pending"
        Management.lbl_current_tab.Text = "Dashboard | Invoice Payments"
    End Sub

    Public Sub invoice_payments_incomplete_Click(sender As Object, e As EventArgs) Handles invoice_payments_incomplete.Click
        activebar_work_orders.Visible = False
        activebar_inventory.Visible = False
        activebar_events.Visible = False
        activebar_payments.Visible = True
        datagrid_fill_flter_with_variable("invoice", Me.HomeDataGridView, "Payment_Status", " LIKE ", "'" & "Partial Payment" & "'")
        Me.invoice_payments_incomplete.Text = HomeDataGridView.Rows.Count & " Incomplete"
        Management.lbl_current_tab.Text = "Dashboard | Invoice Payments"
    End Sub
    Private Sub HomeDataGridView_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles HomeDataGridView.ColumnHeaderMouseClick
        If activebar_work_orders.Visible = True Then
            datagrid_fill_color_effect("work_order_view", Me.HomeDataGridView)
            clear_gridview_default_selection(Me.HomeDataGridView)
        ElseIf activebar_inventory.Visible = True Then
            datagrid_fill_color_effect("inventory", Me.HomeDataGridView)
            clear_gridview_default_selection(Me.HomeDataGridView)
        ElseIf activebar_events.Visible = True Then
            datagrid_fill_color_effect("events_view", Me.HomeDataGridView)
            clear_gridview_default_selection(Me.HomeDataGridView)
        End If
    End Sub


End Class