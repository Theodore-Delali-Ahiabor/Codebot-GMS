Imports MySql.Data.MySqlClient
Public Class Management_Inventory_Add_New
    Private Sub btn_new_item_cancel_Click(sender As Object, e As EventArgs) Handles btn_new_item_cancel.Click
        sidebar_form_loader(Management_Inventory)
        Management.lbl_current_tab.Text = "Inventory"
    End Sub

    Private Sub btn_new_item_save_Click(sender As Object, e As EventArgs) Handles btn_new_item_save.Click

        Try
            If btn_new_item_save.Text = "UPDATE" Then
                Dim repos As DialogResult = MessageBox.Show("You are about to Update info @ ID '" & Management_Inventory.InventoryDataGridView.CurrentRow.Cells(0).Value & "', are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If repos = DialogResult.Yes Then
                    sql_ds = New DataSet
                    sql_da = New MySqlDataAdapter("UPDATE inventory SET `Category` = '" & txt_new_category.Text & "', `Description` = '" & txt_new_part_name.Text & "', `Serial_no` = '" & txt_new_part_number.Text & "',
                            `Alternative` = '" & txt_new_alternative.Text & "', `Location` = '" & txt_new_location.Text & "', `Model_Type` = '" & txt_new_model.Text & "',
                            `Unit_Cost` = '" & txt_new_unit_cost.Text & "',`Supplier_ID` = '" & Management_Inventory_Add_New_Suplyer.suppylier_id & "', `Last_Modified_On` = SYSDATE(),`Last_Modified_By` = '" & login_id & "'
                            Where `ID` = '" & Management_Inventory.InventoryDataGridView.CurrentRow.Cells(0).Value & "'", sql_con)
                    sql_da.Fill(sql_ds, "inventory")
                    sidebar_form_loader(Management_Inventory)
                    datagrid_fill_default("inventory_view", Management_Inventory.InventoryDataGridView)
                End If
            ElseIf btn_new_item_save.Text = "SAVE" Then
                Dim repos As DialogResult = MessageBox.Show("You are about to Add a new item to inventory, are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If repos = DialogResult.Yes Then
                    sql_ds = New DataSet
                    sql_da = New MySqlDataAdapter("INSERT INTO inventory(`Category`,`Description`,`Serial_no`,`Alternative`,`Location`,`Model_Type`,`Stock`,`Unit_Cost`,`Supplier_ID`,`Created_On`,`Created_By`,`Last_Modified_On`,`Last_Modified_By`)
                            VALUES('" & txt_new_category.Text & "','" & txt_new_part_name.Text & "','" & txt_new_part_number.Text & "','" & txt_new_alternative.Text & "','" & txt_new_location.Text & "','" & txt_new_model.Text & "','" & txt_new_quantity.Text & "',
                            '" & txt_new_unit_cost.Text & "','" & txt_new_supplier.Text & "',SYSDATE(),'" & login_id & "',SYSDATE(),'" & login_id & "')", sql_con)
                    sql_da.Fill(sql_ds, "inventory")
                    sidebar_form_loader(Management_Inventory)
                    datagrid_fill_default("inventory_view", Management_Inventory.InventoryDataGridView)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Save New Item Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_new_item_existing_suplyer_Click(sender As Object, e As EventArgs) Handles btn_new_item_existing_supplier.Click
        Management_Inventory_Add_New_Suplyer.supplier_new_datails_panel.Visible = False
        Management_Inventory_Add_New_Suplyer.supplier_select_panel.Visible = True
        Management_Inventory_Add_New_Suplyer.supplier_select_panel.Dock = DockStyle.Fill
        datagrid_fill_default("supplier_view", Management_Inventory_Add_New_Suplyer.SupplierDataGridView)
        Management_Inventory_Add_New_Suplyer.ShowDialog()
    End Sub

    Private Sub btn_new_item_new_suplyer_Click(sender As Object, e As EventArgs) Handles btn_new_item_new_supplier.Click
        Management_Inventory_Add_New_Suplyer.supplier_select_panel.Visible = False
        Management_Inventory_Add_New_Suplyer.supplier_new_datails_panel.Visible = True
        Management_Inventory_Add_New_Suplyer.supplier_new_datails_panel.Dock = DockStyle.Fill
        Management_Inventory_Add_New_Suplyer.clear_supplier_form()
        Management_Inventory_Add_New_Suplyer.ShowDialog()
    End Sub

    Private Sub inventory_clear_suplyer_Click(sender As Object, e As EventArgs) Handles inventory_clear_supplier.Click
        txt_new_supplier.Clear()
    End Sub
End Class