Imports MySql.Data.MySqlClient
Public Class Management_Work_Order
    Private Sub cmb_work_order_status_filter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_work_order_status_filter.SelectedIndexChanged
        If cmb_work_order_status_filter.SelectedIndex = 0 Then
            datagrid_fill_default("work_order_view", Me.WorkOrderDataGridView)
        Else
            datagrid_fill_filter("work_order_view", Me.WorkOrderDataGridView, "Progress_Status", Me.cmb_work_order_status_filter)
        End If
    End Sub

    Private Sub btn_add_new_work_order_Click(sender As Object, e As EventArgs) Handles btn_add_new_work_order.Click
        Management.lbl_current_tab.Text = "Work Orders | Add New Order"
        sidebar_form_loader(Management_Work_Order_Add_New)
        'Management_Inventory_Add_New.btn_new_item_save.Text = "SAVE"
    End Sub

    Private Sub txt_work_order_automobile_name_filter_TextChanged(sender As Object, e As EventArgs) Handles txt_work_order_automobile_name_filter.TextChanged
        If txt_work_order_automobile_name_filter.Text = "" Then
            datagrid_fill_default("work_order_view", Me.WorkOrderDataGridView)
        Else
            datagrid_fill_filter_textbox("work_order_view", Me.WorkOrderDataGridView, "ID", txt_work_order_automobile_name_filter)
        End If
    End Sub
    Private Sub WorkOrderDataGridView_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles WorkOrderDataGridView.ColumnHeaderMouseClick
        datagrid_fill_color_effect("work_order_view", Me.WorkOrderDataGridView)
        clear_gridview_default_selection(Me.WorkOrderDataGridView)
    End Sub

    Private Sub btn_start_work_order_Click(sender As Object, e As EventArgs) Handles btn_start_work_order.Click
        Try
            If Me.WorkOrderDataGridView.SelectedRows.Count > 0 Then
                If Me.WorkOrderDataGridView.CurrentRow.Cells(6).Value.ToString = "In Progress" Then
                    Management.btn_management_message.Text = "Work Order already In Progress"
                    Management.btn_management_message.Show()
                    message(Management.btn_management_message, "information")
                ElseIf Me.WorkOrderDataGridView.CurrentRow.Cells(6).Value.ToString = "Done" Then
                    Management.btn_management_message.Text = "Work Order already ended"
                    Management.btn_management_message.Show()
                    message(Management.btn_management_message, "information")
                Else
                    Dim repos As DialogResult = MessageBox.Show("You are about to end a Work Order @ ID '" & Me.WorkOrderDataGridView.CurrentRow.Cells(0).Value & "', are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    If repos = DialogResult.Yes Then
                        sql_ds = New DataSet
                        sql_da = New MySqlDataAdapter("UPDATE work_order SET Status = '" & "Done" & "' 
                            Where ID = '" & Me.WorkOrderDataGridView.CurrentRow.Cells(0).Value & "'", sql_con)
                        sql_da.Fill(sql_ds, "work_order")
                        datagrid_fill_default("work_order_view", Me.WorkOrderDataGridView)
                        Management.btn_management_message.Text = "Work Order ended successfully"
                        Management.btn_management_message.Show()
                        message(Management.btn_management_message, "success")
                    End If
                End If
            Else
                Management.btn_management_message.Text = "No Work Order selected"
                Management.btn_management_message.Show()
                message(Management.btn_management_message, "warning")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_end_work_order_Click(sender As Object, e As EventArgs) Handles btn_end_work_order.Click
        Try
            If Me.WorkOrderDataGridView.SelectedRows.Count > 0 Then
                If Me.WorkOrderDataGridView.CurrentRow.Cells(6).Value.ToString = "Done" Then
                    Management.btn_management_message.Text = "Work Order already ended"
                    Management.btn_management_message.Show()
                    message(Management.btn_management_message, "information")
                ElseIf Me.WorkOrderDataGridView.CurrentRow.Cells(6).Value.ToString = "Pending" Then
                    Management.btn_management_message.Text = "Work Order can not end while pending"
                    Management.btn_management_message.Show()
                    message(Management.btn_management_message, "information")
                Else
                    Dim repos As DialogResult = MessageBox.Show("You are about to Initiate a Work Order @ ID '" & Me.WorkOrderDataGridView.CurrentRow.Cells(0).Value & "', are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    If repos = DialogResult.Yes Then
                        sql_ds = New DataSet
                        sql_da = New MySqlDataAdapter("UPDATE work_order SET Status = '" & "Done" & "' 
                            Where ID = '" & Me.WorkOrderDataGridView.CurrentRow.Cells(0).Value & "'", sql_con)
                        sql_da.Fill(sql_ds, "work_order")
                        datagrid_fill_default("work_order_view", Me.WorkOrderDataGridView)
                        Management.btn_management_message.Text = "Work Order Started successfully"
                        Management.btn_management_message.Show()
                        message(Management.btn_management_message, "success")
                    End If
                End If
            Else
                Management.btn_management_message.Text = "No Work Order selected"
                Management.btn_management_message.Show()
                message(Management.btn_management_message, "warning")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class