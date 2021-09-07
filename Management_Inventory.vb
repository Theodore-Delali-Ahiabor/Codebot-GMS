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

    Private Sub btn_add_new_inventory_item_Click(sender As Object, e As EventArgs) Handles btn_add_new_inventory_item.Click
        sidebar_form_loader(Management_Inventory_Add_New)
        Management.lbl_current_tab.Text = "Inventory | Add New Item"
        Management_Inventory_Add_New.btn_new_item_save.Text = "SAVE"
        clear_inventory_form()
        'add_new_employee_clear()
        'Management_Employees_Add_New.txt_new_id.Text = new_employee_id
        'Management_Employees_Add_New.txt_new_active.SelectedIndex = 0
    End Sub

    Private Sub txt_inventory_part_name_filter_TextChanged(sender As Object, e As EventArgs) Handles txt_inventory_part_name_filter.TextChanged
        If txt_inventory_part_name_filter.Text = "" Then
            datagrid_fill_default("inventory", InventoryDataGridView)
        Else
            datagrid_fill_filter_textbox("inventory", InventoryDataGridView, "Part_Name", Me.txt_inventory_part_name_filter)
        End If
    End Sub

    Private Sub btn_edit_inventory_item_Click(sender As Object, e As EventArgs) Handles btn_edit_inventory_item.Click
        Try
            If InventoryDataGridView.SelectedRows.Count > 0 Then
                sidebar_form_loader(Management_Inventory_Add_New)
                Management.lbl_current_tab.Text = "Inventory | Edit Item Info"
                Management_Inventory_Add_New.btn_new_item_save.Text = "UPDATE"

                sql_da = New MySqlDataAdapter("SELECT * FROM inventory WHERE ID = '" & InventoryDataGridView.CurrentRow.Cells(0).Value.ToString() & "'", sql_con)
                sql_dt = New DataTable
                sql_dt.Clear()
                sql_da.Fill(sql_dt)
                If sql_dt.Rows.Count() > 0 Then
                    Management_Inventory_Add_New.txt_new_category.Text = sql_dt.Rows(0).Item("Category").ToString()
                    Management_Inventory_Add_New.txt_new_part_name.Text = sql_dt.Rows(0).Item("Part_Name").ToString()
                    Management_Inventory_Add_New.txt_new_part_number.Text = sql_dt.Rows(0).Item("Part_Number").ToString()
                    Management_Inventory_Add_New.txt_new_alternative.Text = sql_dt.Rows(0).Item("Alternative").ToString()
                    Management_Inventory_Add_New.txt_new_location.Text = sql_dt.Rows(0).Item("Location").ToString()
                    Management_Inventory_Add_New.txt_new_model.Text = sql_dt.Rows(0).Item("Model_Type").ToString()
                    Management_Inventory_Add_New.txt_new_quantity.Text = sql_dt.Rows(0).Item("Stock").ToString()
                    Management_Inventory_Add_New.txt_new_unit_cost.Text = sql_dt.Rows(0).Item("Unit_Cost").ToString()
                Else
                    Management.btn_management_message.Text = "No Data Found"
                    Management.btn_management_message.Show()
                    message(Management.btn_management_message, "warning")
                End If
            Else
                Management.btn_management_message.Text = "No Row was selected"
                Management.btn_management_message.Show()
                message(Management.btn_management_message, "warning")
                '
                Management.sidebar_active(Management.btn_inventory)
                sidebar_form_loader(Me)
                datagrid_fill_default("inventory", InventoryDataGridView)
                'datagrif_fill_column_resize()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
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
        datagrid_fill_color_effect("inventory", InventoryDataGridView)
    End Sub
End Class