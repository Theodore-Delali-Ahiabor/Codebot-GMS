Public Class Management_Inventory_Stock_In
    Private Sub btn_stock_in_Click(sender As Object, e As EventArgs) Handles btn_stock_in.Click
        Dim new_stock = Management_Inventory.current_stock + txt_stock_in_quntity.Value

        Dim repos As DialogResult = MessageBox.Show("You are about to Stock In quantity for item  @ ID '" & Management_Inventory.InventoryDataGridView.CurrentRow.Cells(0).Value & "', are you sure to continue ?", "Stock In Item", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If repos = DialogResult.Yes Then
            sql_ds = New DataSet
            sql_da = New MySqlDataAdapter("UPDATE `inventory` SET `Stock` = '" & new_stock & "', `Last_Modified_On` = SYSDATE(), `Last_Modified_By` = '" & login_id & "'
                            Where ID = '" & Management_Inventory.InventoryDataGridView.CurrentRow.Cells(0).Value & "'", sql_con)
            sql_da.Fill(sql_ds, "inventory")
            Me.Close()
            sidebar_form_loader(Management_Inventory)
            datagrid_fill_default("inventory_view", Management_Inventory.InventoryDataGridView)
        End If
    End Sub

    Private Sub btn_stock_in_cancel_Click(sender As Object, e As EventArgs) Handles btn_stock_in_cancel.Click
        Me.Close()
    End Sub

    Private Sub Management_Inventory_Stock_In_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_stock_in_quntity.Value = 0
    End Sub
End Class