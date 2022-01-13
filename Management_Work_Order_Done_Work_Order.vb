
Public Class Management_Work_Order_Done_Work_Order
    Public last_service_id As Integer
    Dim date_in As String
    Dim work_order_msg As String
    Dim work_order_pick_up_email As String
    Dim work_order_pick_up_phone As Integer
    Dim next_due_date As String = CStr(txt_done_next_service_due_date.Value.Year) + "-" + CStr(txt_done_next_service_due_date.Value.Month) + "-" + CStr(txt_done_next_service_due_date.Value.Day)
    Private Sub btn_done_complete_Click(sender As Object, e As EventArgs) Handles btn_done_complete.Click
        Try
            sql_da = New MySqlDataAdapter("SELECT c.First_Name, c.Phone, c.Email, w.ID, w.Date_In, a.Category,a.Year,a.Make,a.Model,a.Color,a.Reg_Number from customer_info c
                INNER JOIN work_order w
                ON c.ID = w.Customer
                INNER JOIN automobile_info a
                ON w.Automobile = a.ID
                WHERE  w.ID  = '" & Management_Work_Order.WorkOrderDataGridView.CurrentRow.Cells(0).Value & "'", sql_con)
            sql_dt = New DataTable
            sql_dt.Clear()
            sql_da.Fill(sql_dt)
            date_in = CStr(sql_dt.Rows(0).Item("Date_In").Year) + "-" + CStr(sql_dt.Rows(0).Item("Date_In").Month) + "-" + CStr(sql_dt.Rows(0).Item("Date_In").Day)
            work_order_msg = "Hi " + CStr(sql_dt.Rows(0).Item("First_Name")) + ", " & vbCrLf & "   Your " + sql_dt.Rows(0).Item("Color") + ", " + CStr(sql_dt.Rows(0).Item("Year")) + ", " + CStr(sql_dt.Rows(0).Item("Make")) + ", " + CStr(sql_dt.Rows(0).Item("Model")) + ", " + CStr(sql_dt.Rows(0).Item("Category")) + ", which you brought in for servicing on " + date_in + " with registration number " + CStr(sql_dt.Rows(0).Item("Reg_Number")) + " is ready for pick up." & vbCrLf & "     Kindly visit our garage for check out as soon as posible. Please be reminded that there with be a GHC20.00 charge per day if you fail to pick yor vehicle within (3)three days of completion. Thank you."
            work_order_pick_up_email = CStr(sql_dt.Rows(0).Item("Email"))
            work_order_pick_up_phone = sql_dt.Rows(0).Item("Phone")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Getting Work Order ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        If txt_done_next_service_due_date.Checked = False Then
            txt_done_next_service_due_date.Focus()
            message("warning", "Kindly select a next service due date")
        ElseIf txt_done_next_service_due_date.Value <= Date.Today Then
            message("warning", "Invalid date selected. Select ONLY future dates")
            txt_done_next_service_due_date.Focus()
        ElseIf txt_done_mileage.Text.ToString = "" Then
            message("warning", "Kindly enter a VALID next service due mileage")
            txt_done_mileage.Focus()
        Else
            If IsNumeric(txt_done_mileage.Text) Then
                If CInt(txt_done_mileage.Text) > 0 Then
                    'Add event to calendar
                    Try
                        If chkb_work_order_send_email.Checked Or chkb_work_order_send_whatsapp.Checked Or chkb_work_order_send_sms.Checked Then
                            If CheckForInternetConnection() = True Then
                                If chkb_work_order_send_email.Checked Then
                                    If sql_dt.Rows.Count() = 1 Then
                                        If work_order_pick_up_email <> "" Then
                                            'Send email to customer
                                            send_email("Work Order Pick Up", work_order_pick_up_email, work_order_msg)
                                            If email_delevery_status = 1 Then
                                                message("success", "Pick up notice has been successfully sent to " + work_order_pick_up_email)
                                            Else
                                                message("warning", "Failed to send email to " + work_order_pick_up_email + ". Check internet connection and try again. ")
                                            End If
                                        Else
                                            message("error", "Customer did not provide an email address")
                                        End If
                                    End If
                                    next_service_due_calendar_event()
                                ElseIf chkb_work_order_send_whatsapp.Checked Then
                                    'Send whatsapp message
                                    send_whatsapp(work_order_pick_up_phone, work_order_msg)
                                    next_service_due_calendar_event()
                                ElseIf chkb_work_order_send_sms.Checked Then
                                    'send sms
                                    message("information", "No pick-up message was sent to customer ")
                                    next_service_due_calendar_event()
                                End If
                            Else
                                message("warning", "No internet connection, Check internet conection and try Again")
                            End If
                        Else
                            next_service_due_calendar_event()
                        End If

                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Pick Notification Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else
                    message("warning", "Kindly enter a VALID next service due mileage")
                    txt_done_mileage.Focus()
                End If
            Else
                message("warning", "Kindly enter a VALID next service due mileage")
                txt_done_mileage.Focus()
            End If
        End If
    End Sub
    Public Sub next_service_due_calendar_event()
        Try
            Dim description As String = "The next service due mileage is  " + CStr(txt_done_mileage.Text) + "km." + "" & vbCrLf & "" + "View details of the last service with work order ID number " + last_service_id.ToString
            sql_ds = New DataSet
            sql_da = New MySqlDataAdapter("INSERT INTO calendar_events (Date,Caption,employee_id,Description)
                            VALUES('" & next_due_date & "','" & "Next Service Due" & "','" & login_id & "','" & description & "')", sql_con)
            sql_da.Fill(sql_ds, "calendar_events")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Event Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class