Imports MySql.Data.MySqlClient
Public Class Management_Inventory
    Private Sub cmb_inventory_category_filter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_inventory_category_filter.SelectedIndexChanged
        If cmb_inventory_category_filter.SelectedIndex = 0 Then
            datagrid_fill_default("inventory", InventoryDataGridView)
        Else
            datagrid_fill_filter("inventory", InventoryDataGridView, "Category", Me.cmb_inventory_category_filter)
        End If
    End Sub

    Private Sub cmb_inventory_location_filter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_inventory_location_filter.SelectedIndexChanged
        If cmb_inventory_location_filter.SelectedIndex = 0 Then
            datagrid_fill_default("inventory", InventoryDataGridView)
        Else
            datagrid_fill_filter("inventory", InventoryDataGridView, "Location", Me.cmb_inventory_location_filter)
        End If
    End Sub

    Public Sub btn_add_new_inventory_item_Click(sender As Object, e As EventArgs) Handles btn_add_new_inventory_item.Click
        Management_Inventory_Add_New.txt_new_quantity.Enabled = False
        sidebar_form_loader(Management_Inventory_Add_New)
        Management.lbl_current_tab.Text = "Inventory | Add New Item"
        Management_Inventory_Add_New.btn_new_item_save.Text = "SAVE"
        clear_inventory_form()

        With Management_Inventory_Add_New
            .txt_new_alternative.Enabled = True
            .txt_new_category.Enabled = True
            .txt_new_location.Enabled = True
            .txt_new_model.Enabled = True
            .txt_new_part_name.Enabled = True
            .txt_new_part_number.Enabled = True
            .txt_new_quantity.Enabled = True
            .txt_new_quantity.Enabled = True
        End With
    End Sub

    Private Sub txt_inventory_part_name_filter_TextChanged(sender As Object, e As EventArgs) Handles txt_inventory_part_name_filter.TextChanged
        If txt_inventory_part_name_filter.Text = "" Then
            datagrid_fill_default("inventory", InventoryDataGridView)
        Else
            datagrid_fill_filter_textbox("inventory", InventoryDataGridView, "Description", Me.txt_inventory_part_name_filter)
        End If
    End Sub

    Private Sub btn_edit_inventory_item_Click(sender As Object, e As EventArgs) Handles btn_edit_inventory_item.Click
        Try
            If InventoryDataGridView.SelectedRows.Count = 1 Then
                Management_Inventory_Add_New.txt_new_quantity.Enabled = False
                Management.lbl_current_tab.Text = "Inventory | Edit Item Info"
                Management_Inventory_Add_New.btn_new_item_save.Text = "UPDATE"

                sql_da = New MySqlDataAdapter("SELECT * FROM inventory WHERE ID = '" & InventoryDataGridView.CurrentRow.Cells(0).Value.ToString() & "'", sql_con)
                sql_dt = New DataTable
                sql_dt.Clear()
                sql_da.Fill(sql_dt)
                If sql_dt.Rows.Count() > 0 Then
                    sidebar_form_loader(Management_Inventory_Add_New)
                    With Management_Inventory_Add_New
                        .txt_new_category.Text = sql_dt.Rows(0).Item("Category").ToString()
                        .txt_new_part_name.Text = sql_dt.Rows(0).Item("Description").ToString()
                        .txt_new_part_number.Text = sql_dt.Rows(0).Item("Serial_no").ToString()
                        .txt_new_alternative.Text = sql_dt.Rows(0).Item("Alternative").ToString()
                        .txt_new_location.Text = sql_dt.Rows(0).Item("Location").ToString()
                        .txt_new_model.Text = sql_dt.Rows(0).Item("Model_Type").ToString()
                        .txt_new_quantity.Text = sql_dt.Rows(0).Item("Stock").ToString()
                        .txt_new_unit_cost.Text = sql_dt.Rows(0).Item("Unit_Cost").ToString()

                        .txt_new_category.Enabled = True
                        .txt_new_part_name.Enabled = True
                        .txt_new_part_number.Enabled = True
                        .txt_new_alternative.Enabled = True
                        .txt_new_location.Enabled = True
                        .txt_new_model.Enabled = True
                        .txt_new_quantity.Enabled = False
                        .txt_new_unit_cost.Enabled = True
                    End With
                Else
                    message("warning", "No Data Found")
                End If
            Else
                message("warning", "No Row was selected")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Edit Item Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub clear_inventory_form()
        Management_Inventory_Add_New.txt_new_category.Text = ""
        Management_Inventory_Add_New.txt_new_part_name.Clear()
        Management_Inventory_Add_New.txt_new_part_number.Clear()
        Management_Inventory_Add_New.txt_new_alternative.Clear()
        Management_Inventory_Add_New.txt_new_location.Clear()
        Management_Inventory_Add_New.txt_new_model.Clear()
        Management_Inventory_Add_New.txt_new_quantity.Clear()
        Management_Inventory_Add_New.txt_new_unit_cost.Clear()
    End Sub

    Private Sub InventoryDataGridView_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles InventoryDataGridView.ColumnHeaderMouseClick
        datagrid_fill_color_effect("inventory", Me.InventoryDataGridView)
        clear_gridview_default_selection(Me.InventoryDataGridView)
    End Sub

    Private Sub InventoryDataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles InventoryDataGridView.CellMouseDoubleClick
        btn_edit_inventory_item_Click(btn_edit_inventory_item, EventArgs.Empty)
    End Sub

    Private Sub btn_stock_item_Click(sender As Object, e As EventArgs) Handles btn_stock_item.Click
        If InventoryDataGridView.SelectedRows.Count = 1 Then
            sql_da = New MySqlDataAdapter("SELECT * FROM inventory WHERE ID = '" & InventoryDataGridView.CurrentRow.Cells(0).Value.ToString() & "'", sql_con)
            sql_dt = New DataTable
            sql_dt.Clear()
            sql_da.Fill(sql_dt)
            If sql_dt.Rows.Count() > 0 Then
                sidebar_form_loader(Management_Inventory_Add_New)
                With Management_Inventory_Add_New
                    .txt_new_category.Text = sql_dt.Rows(0).Item("Category").ToString()
                    .txt_new_part_name.Text = sql_dt.Rows(0).Item("Description").ToString()
                    .txt_new_part_number.Text = sql_dt.Rows(0).Item("Serial_no").ToString()
                    .txt_new_alternative.Text = sql_dt.Rows(0).Item("Alternative").ToString()
                    .txt_new_location.Text = sql_dt.Rows(0).Item("Location").ToString()
                    .txt_new_model.Text = sql_dt.Rows(0).Item("Model_Type").ToString()
                    .txt_new_quantity.Text = sql_dt.Rows(0).Item("Stock").ToString()
                    .txt_new_unit_cost.Text = sql_dt.Rows(0).Item("Unit_Cost").ToString()

                    .txt_new_category.Enabled = False
                    .txt_new_part_name.Enabled = False
                    .txt_new_part_number.Enabled = False
                    .txt_new_alternative.Enabled = False
                    .txt_new_location.Enabled = False
                    .txt_new_model.Enabled = False
                    .txt_new_quantity.Enabled = True
                    .txt_new_unit_cost.Enabled = False
                End With

            Else
                message("warning", "No Data Found")
            End If
        Else
            message("warning", "No Item selected")
        End If
    End Sub

    Private Sub btn_make_items_requisition_Click(sender As Object, e As EventArgs) Handles btn_make_items_requisition.Click
        'Management_Market.ShowDialog()
    End Sub
End Class