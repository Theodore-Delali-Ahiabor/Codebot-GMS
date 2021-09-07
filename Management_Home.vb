Imports MySql.Data.MySqlClient
Public Class Management_Home
    Private Sub work_oders_due_panel_Click(sender As Object, e As EventArgs) Handles work_oders_due_panel.Click
        work_order_overdue_filter("6")
    End Sub

    Private Sub low_inventory_panel_Click(sender As Object, e As EventArgs) Handles low_inventory_panel.Click
        activebar_work_orders.Visible = False
        activebar_inventory.Visible = True
        datagrid_fill_flter_with_variable("inventory", Me.HomeDataGridView, "Stock", "<", "10")
        datagrif_fill_column_resize("inventory", Me.HomeDataGridView)
        Management.lbl_current_tab.Text = "Dashboard | Inventory Low"
    End Sub

    Private Sub lbl_work_orders_due_Click(sender As Object, e As EventArgs) Handles lbl_work_orders_due.Click
        work_oders_due_panel_Click(sender, e)
    End Sub

    Private Sub lbl_low_inventory_Click(sender As Object, e As EventArgs) Handles lbl_low_inventory.Click
        low_inventory_panel_Click(sender, e)
    End Sub

    Private Sub PictureBoxInventory_Click(sender As Object, e As EventArgs) Handles PictureBoxInventory.Click
        low_inventory_panel_Click(sender, e)
    End Sub

    Private Sub PictureBoxWorkOrders_Click(sender As Object, e As EventArgs) Handles PictureBoxWorkOrders.Click
        work_oders_due_panel_Click(sender, e)
    End Sub

    Private Sub work_order_overdue_Click(sender As Object, e As EventArgs) Handles work_order_overdue.Click
        work_order_overdue_filter("1")
        work_order_overdue.Text = HomeDataGridView.Rows().Count & " Overdue"
    End Sub

    Private Sub work_order_due_soon_Click(sender As Object, e As EventArgs) Handles work_order_due_soon.Click
        activebar_work_orders.Visible = True
        activebar_inventory.Visible = False
        sql_da = New MySqlDataAdapter("SELECT * FROM work_order_view WHERE Due_In < 6 AND Due_In > -1 AND Progress_Status <>'" & "Done" & "' ", sql_con)
        sql_dt = New DataTable
        sql_dt.Clear()
        sql_da.Fill(sql_dt)
        HomeDataGridView.DataSource = sql_dt
        datagrid_fill_color_effect("work_order_view", Me.HomeDataGridView)
        work_order_due_soon.Text = HomeDataGridView.Rows().Count & " Due Soon"
        Management.lbl_current_tab.Text = "Dashboard | Work Oders Due"
    End Sub
End Class