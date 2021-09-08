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
                    sql_da = New MySqlDataAdapter("UPDATE inventory SET Category = '" & txt_new_category.Text & "', Description = '" & txt_new_part_name.Text & "', Serial_no = '" & txt_new_part_number.Text & "',
                            Alternative = '" & txt_new_alternative.Text & "', Location = '" & txt_new_location.Text & "', Model_Type = '" & txt_new_model.Text & "', Stock = '" & txt_new_quantity.Text & "',
                            Unit_Cost = '" & txt_new_unit_cost.Text & "'
                            Where ID = '" & Management_Inventory.InventoryDataGridView.CurrentRow.Cells(0).Value & "'", sql_con)
                    sql_da.Fill(sql_ds, "inventory")
                    sidebar_form_loader(Management_Inventory)
                    datagrid_fill_default("inventory", Management_Inventory.InventoryDataGridView)
                End If
            ElseIf btn_new_item_save.Text = "SAVE" Then
                Dim repos As DialogResult = MessageBox.Show("You are about to Add a new item to inventory, are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If repos = DialogResult.Yes Then
                    sql_ds = New DataSet
                    sql_da = New MySqlDataAdapter("INSERT INTO inventory(Category,Description,Serial_no,Alternative,Location,Model_Type,Stock,Unit_Cost)
                            VALUES('" & txt_new_category.Text & "','" & txt_new_part_name.Text & "','" & txt_new_part_number.Text & "','" & txt_new_alternative.Text & "','" & txt_new_location.Text & "',
                            '" & txt_new_model.Text & "','" & txt_new_quantity.Text & "','" & txt_new_unit_cost.Text & "')", sql_con)
                    sql_da.Fill(sql_ds, "inventory")
                    sidebar_form_loader(Management_Inventory)
                    datagrid_fill_default("inventory", Management_Inventory.InventoryDataGridView)
                End If
            Else
                MsgBox("Nothing to Do")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class