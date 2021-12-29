Public Class Management_Inventory_Add_New_Suplyer
    Public suppylier_id As Integer
    Private Sub btn_suplyer_select_select_Click(sender As Object, e As EventArgs) Handles btn_suplier_select_select.Click
        If SupplierDataGridView.SelectedRows.Count = 1 Then
            suppylier_id = SupplierDataGridView.CurrentRow.Cells(0).Value
            Management_Inventory_Add_New.txt_new_supplier.Text = SupplierDataGridView.CurrentRow.Cells(1).Value
            Me.Close()
        Else
            message("warning", "No supplier selected")
        End If

    End Sub

    Private Sub btn_suplyer_select_cancel_Click(sender As Object, e As EventArgs) Handles btn_suplier_select_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_suplyer_select_edit_Click(sender As Object, e As EventArgs) Handles btn_suplier_select_edit.Click
        If SupplierDataGridView.SelectedRows.Count = 1 Then
            supplier_select_panel.Visible = False
            supplier_new_datails_panel.Visible = True
            supplier_new_datails_panel.Dock = DockStyle.Fill
            txt_new_supplier_description.Text = SupplierDataGridView.CurrentRow.Cells(1).Value
            txt_new_supplier_rep.Text = SupplierDataGridView.CurrentRow.Cells(2).Value
            txt_new_supplier_location.Text = SupplierDataGridView.CurrentRow.Cells(3).Value
            txt_new_supplier_business_sector.Text = SupplierDataGridView.CurrentRow.Cells(4).Value
            txt_new_supplier_phone_number.Text = SupplierDataGridView.CurrentRow.Cells(5).Value
            txt_new_supplier_email.Text = SupplierDataGridView.CurrentRow.Cells(6).Value
            txt_new_supplier_post_box.Text = SupplierDataGridView.CurrentRow.Cells(7).Value
            btn_new_suplier_save.Text = "EDIT"
        Else
            message("warning", "No supplier selected")
        End If

    End Sub

    Private Sub btn_suplyer_select_new_Click(sender As Object, e As EventArgs) Handles btn_suplier_select_new.Click
        clear_supplier_form()
        supplier_select_panel.Visible = False
        supplier_new_datails_panel.Visible = True
        supplier_new_datails_panel.Dock = DockStyle.Fill
    End Sub

    Private Sub btn_new_suplier_cancel_Click(sender As Object, e As EventArgs) Handles btn_new_suplier_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_new_suplier_save_Click(sender As Object, e As EventArgs) Handles btn_new_suplier_save.Click
        Try
            If btn_new_suplier_save.Text = "EDIT" Then
                Dim repos As DialogResult = MessageBox.Show("You are about to Update suplppier info @ ID '" & SupplierDataGridView.CurrentRow.Cells(0).Value & "', are you sure to continue ?", "Updating Supplier Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If repos = DialogResult.Yes Then
                    sql_ds = New DataSet
                    sql_da = New MySqlDataAdapter("UPDATE suplyers SET `Description` = '" & txt_new_supplier_description.Text & "', `Representative` = '" & txt_new_supplier_rep.Text & "', `Location` = '" & txt_new_supplier_location.Text & "',
                            `Business_Sector` = '" & txt_new_supplier_business_sector.Text & "',`Phone_Number` = '" & txt_new_supplier_phone_number.Text & "', `Email_Address` = '" & txt_new_supplier_email.Text & "', `Post_Box_Number` = '" & txt_new_supplier_post_box.Text & "',
                            `Last_Modified_On` = SYSDATE(), `Last_Modified_By` = '" & login_id & "'
                            Where ID = '" & SupplierDataGridView.CurrentRow.Cells(0).Value & "'", sql_con)
                    sql_da.Fill(sql_ds, "suppliers")
                    datagrid_fill_default("supplier_view", SupplierDataGridView)
                End If
            ElseIf btn_new_suplier_save.Text = "SAVE" Then
                Dim repos As DialogResult = MessageBox.Show("You are about to Add a new Supplier, are you sure to continue ?", "Updating Supplier Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If repos = DialogResult.Yes Then
                    sql_ds = New DataSet
                    sql_da = New MySqlDataAdapter("INSERT INTO suppliers(`Description`,`Representative`,`Location`,`Business_Sector`,`Phone_Number`,`Email_Address`,`Post_Box_Number`,`Created_On`,`Created_By`,`Last_Modified_On`,`Last_Modified_By`)
                            VALUES('" & txt_new_supplier_description.Text & "','" & txt_new_supplier_rep.Text & "','" & txt_new_supplier_location.Text & "','" & txt_new_supplier_business_sector.Text & "','" & txt_new_supplier_phone_number.Text & "','" & txt_new_supplier_email.Text & "','" & txt_new_supplier_post_box.Text & "',SYSDATE(),'" & login_id & "',SYSDATE(), '" & login_id & "')", sql_con)
                    sql_da.Fill(sql_ds, "suppliers")
                    datagrid_fill_default("supplier_view", SupplierDataGridView)
                    '
                    '
                End If
                supplier_new_datails_panel.Visible = False
                supplier_select_panel.Visible = True
                supplier_select_panel.Dock = DockStyle.Fill
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Save Supplier Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub clear_supplier_form()
        txt_new_supplier_description.Clear()
        txt_new_supplier_rep.Clear()
        txt_new_supplier_location.Clear()
        txt_new_supplier_business_sector.Text = ""
        txt_new_supplier_phone_number.Clear()
        txt_new_supplier_email.Clear()
        txt_new_supplier_post_box.Clear()
    End Sub
End Class