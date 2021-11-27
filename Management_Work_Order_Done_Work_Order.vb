Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class Management_Work_Order_Done_Work_Order
    Public last_service_id As Integer
    Private Sub btn_done_reset_Click(sender As Object, e As EventArgs) Handles btn_done_reset.Click
        txt_done_next_service_due_date.Value = Date.Today
        txt_done_mileage.Clear()
        rbtn_pick_up_yes.Checked = True
        rbtn_pick_up_no.Checked = False
    End Sub

    Private Sub btn_done_complete_Click(sender As Object, e As EventArgs) Handles btn_done_complete.Click
        If txt_done_next_service_due_date.Checked = False Then
            Management.btn_management_message.Text = "Kindly select a next service due date"
            Management.btn_management_message.Show()
            message(Management.btn_management_message, "warning")
        ElseIf txt_done_next_service_due_date.Value <= Date.Today Then
            Management.btn_management_message.Text = "Invalid date selected"
            Management.btn_management_message.Show()
            message(Management.btn_management_message, "warning")
        ElseIf txt_done_mileage.Text = "" Then
            Management.btn_management_message.Text = "Kindly enter a mileage"
            Management.btn_management_message.Show()
            message(Management.btn_management_message, "warning")
        Else
            Dim next_due_date As String = CStr(txt_done_next_service_due_date.Value.Year) + "-" + CStr(txt_done_next_service_due_date.Value.Month) + "-" + CStr(txt_done_next_service_due_date.Value.Day)
            If rbtn_pick_up_yes.Checked = True Then
                'Send email to customer
                sql_da = New MySqlDataAdapter("SELECT customer_info.First_Name, customer_info.Email
                    FROM customer_info INNER JOIN
                         work_order ON customer_info.ID = work_order.Customer
                    WHERE  work_order.ID  = '" & Management_Work_Order.WorkOrderDataGridView.CurrentRow.Cells(0).Value & "'", sql_con)
                sql_dt = New DataTable
                sql_dt.Clear()
                sql_da.Fill(sql_dt)
                '
                If sql_dt.Rows.Count() > 0 Then
                    If sql_dt.Rows(0).Item("Email").value.ToString <> "" Then
                        Try
                            MsgBox("Check point")
                            Dim smtp_server As New SmtpClient
                            Dim email As New MailMessage
                            smtp_server.UseDefaultCredentials = False
                            smtp_server.Credentials = New Net.NetworkCredential("theodoredela@gmail.com", "DrahKulaH98")
                            smtp_server.Port = 587
                            smtp_server.EnableSsl = True
                            smtp_server.Host = "smtp.gmail.com"
                            email = New MailMessage()
                            email.From = New MailAddress("theodoredela@gmail.com")
                            email.To.Add(sql_dt.Rows(0).Item("Email"))
                            email.Subject = " HTU-JMTC Password Reset"
                            email.IsBodyHtml = False
                            email.Body = "Work on your vehicle is completed, kindly visit the Garage to pick up your vehicle"

                            smtp_server.Send(email)
                            smtp_server.DeliveryFormat.ToString()
                            MessageBox.Show("", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Catch ex As Exception
                            MessageBox.Show("Something went wrong while attempting to send email. Kindly check your connection and try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    Else
                        Me.Close()
                        MessageBox.Show("Email to customer was NOT successfull. Customer did not provide any Email Address", "No Email Address Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

                sql_ds = New DataSet
                sql_da = New MySqlDataAdapter("INSERT INTO calendar_events(Date,Caption,Last_Service_ID,Next_Service_Mileage,employee_id,Description)
                            VALUES('" & next_due_date & "','" & "Next Service Due" & "','" & last_service_id & "','" & txt_done_mileage.Text & "','" & login_id & "','" & null & "')", sql_con)
                sql_da.Fill(sql_ds, "calendar_events")
                Me.Close()
                Management.btn_management_message.Text = "Event added Successflly"
                Management.btn_management_message.Show()
                message(Management.btn_management_message, "success")

            Else
                sql_ds = New DataSet
                sql_da = New MySqlDataAdapter("INSERT INTO calendar_events (Date,Caption,Last_Service_ID,Next_Service_Mileage,employee_id,Description)
                            VALUES('" & next_due_date & "','" & "Next Servie Due" & "','" & last_service_id & "','" & txt_done_mileage.Text & "','" & login_id & "','" & null & "')", sql_con)
                sql_da.Fill(sql_ds, "calendar_events")
                    Me.Close()
                Management.btn_management_message.Text = "Event added Successflly"
                Management.btn_management_message.Show()
                message(Management.btn_management_message, "success")
            End If
        End If
    End Sub
End Class