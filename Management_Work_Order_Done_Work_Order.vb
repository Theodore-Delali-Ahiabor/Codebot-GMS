
Public Class Management_Work_Order_Done_Work_Order
    Public last_service_id As Integer

    Private Sub btn_done_complete_Click(sender As Object, e As EventArgs) Handles btn_done_complete.Click
        If txt_done_next_service_due_date.Checked = False Then
            txt_done_next_service_due_date.Focus()
            message("warning", "Kindly select a next service due date")
        ElseIf txt_done_next_service_due_date.Value <= Date.Today Then
            message("warning", "Invalid date selected. Select ONLY future dates")
            txt_done_next_service_due_date.Focus()
        ElseIf txt_done_mileage.Text = "" Or txt_done_mileage.Text < 0 Or IsNumeric(txt_done_mileage.Text) = False Then
            message("warning", "Kindly enter a VALID next service due mileage")
            txt_done_mileage.Focus()
        Else
            Dim next_due_date As String = CStr(txt_done_next_service_due_date.Value.Year) + "-" + CStr(txt_done_next_service_due_date.Value.Month) + "-" + CStr(txt_done_next_service_due_date.Value.Day)
            sql_da = New MySqlDataAdapter("SELECT c.First_Name, c.Phone, c.Email, w.ID, w.Date_In, a.Category,a.Year,a.Make,a.Model,a.Color,a.Reg_Number from customer_info c
                    INNER JOIN work_order w
                    ON c.ID = w.Customer
                    INNER JOIN automobile_info a
                    ON w.Automobile = a.ID
                    WHERE  w.ID  = '" & Management_Work_Order.WorkOrderDataGridView.CurrentRow.Cells(0).Value & "'", sql_con)
            sql_dt = New DataTable
            sql_dt.Clear()
            sql_da.Fill(sql_dt)
            Dim date_in As String = CStr(sql_dt.Rows(0).Item("Date_In").Year) + "-" + CStr(sql_dt.Rows(0).Item("Date_In").Month) + "-" + CStr(sql_dt.Rows(0).Item("Date_In").Day)
            Dim work_order_msg As String = "Hi " + CStr(sql_dt.Rows(0).Item("First_Name")) + ", " & vbCrLf & "   Your " + sql_dt.Rows(0).Item("Color") + ", " + CStr(sql_dt.Rows(0).Item("Year")) + ", " + CStr(sql_dt.Rows(0).Item("Make")) + ", " + CStr(sql_dt.Rows(0).Item("Model")) + ", " + CStr(sql_dt.Rows(0).Item("Category")) + ", which you brought in for servicing on " + date_in + " with registration number " + CStr(sql_dt.Rows(0).Item("Reg_Number")) + " is ready for pick up." & vbCrLf & "     Kindly visit our garage for check out as soon as posible. Please be reminded that there with be a GHC20.00 charge per day if you fail to pick yor vehicle within (3)three days of completion. Thank you."
            Dim work_order_pick_up_email As String = CStr(sql_dt.Rows(0).Item("Email"))
            Dim work_order_pick_up_phone As Integer = sql_dt.Rows(0).Item("Phone")
            'Add event to calendar
            Try
                'add description
                sql_ds = New DataSet
                sql_da = New MySqlDataAdapter("INSERT INTO calendar_events (Date,Caption,Last_Service_ID,Next_Service_Mileage,employee_id,Description)
                            VALUES('" & next_due_date & "','" & "Next Servie Due" & "','" & last_service_id & "','" & txt_done_mileage.Text & "','" & login_id & "','" & null & "')", sql_con)
                sql_da.Fill(sql_ds, "calendar_events")
                Me.Close()
                'message("success", "Next Servive Due Event added Successflly")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Event Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            'Send pick up notification
            Try
                If chkb_work_order_send_email.Checked Then
                    If sql_dt.Rows.Count() = 1 Then
                        If work_order_pick_up_email <> "" Then
                            'Send email to customer
                            send_email("Work Order Pick Up", work_order_pick_up_email, work_order_msg)
                            If email_delevery_status = 1 Then
                                message("success", "Pick up notice has been successfully sent to " + work_order_pick_up_email)
                            Else
                                message("warning", "Failed to send email to " + work_order_pick_up_email + ". Check email address and try again. ")
                            End If
                            Me.Close()
                        Else
                            Me.Close()
                            message("error", "Customer did not provide an email address")
                        End If
                    End If
                ElseIf chkb_work_order_send_whatsapp.Checked Then
                    'Send whatsapp message
                    send_whatsapp(work_order_pick_up_phone, work_order_msg)
                ElseIf chkb_work_order_send_sms.Checked Then
                    'send sms
                Else
                    message("information", "No pick-up notification sent to customer ")
                End If


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Pick Notification Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class