Imports MySql.Data.MySqlClient
Public Class Management_Calendar_Add_New_Event
    Public Event_id As Integer = 0
    Private Sub btn_new_event_cancel_Click(sender As Object, e As EventArgs) Handles btn_new_event_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_new_event_save_Click(sender As Object, e As EventArgs) Handles btn_new_event_save.Click
        Try
            If Event_id = 0 Then
                If txt_new_description.Text <> "" And txt_new_caption.Text <> "" Then
                    Dim repos As DialogResult = MessageBox.Show("You are about to Add a new Event, are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    If repos = DialogResult.Yes Then
                        sql_ds = New DataSet
                        sql_da = New MySqlDataAdapter("INSERT INTO calendar_events (Date,Caption,Description,employee_id)
                            VALUES('" & txt_new_date.Text & "','" & txt_new_caption.Text & "','" & txt_new_description.Text & "','" & login_id & "')", sql_con)
                        sql_da.Fill(sql_ds, "calendar_events")
                        Me.Close()
                        Management_Calendar.display_current_date()
                        Management.btn_management_message.Text = "Event added Successflly"
                        Management.btn_management_message.Show()
                        message(Management.btn_management_message, "success")

                    End If
                Else
                    Management.btn_management_message.Text = "Please fill out all required (*) fields"
                    Management.btn_management_message.Show()
                    message(Management.btn_management_message, "warning")
                End If
            Else
                If txt_new_description.Text <> "" And txt_new_caption.Text <> "" Then
                    Dim repos As DialogResult = MessageBox.Show("You are about to Update Event, are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    If repos = DialogResult.Yes Then
                        sql_ds = New DataSet
                        sql_da = New MySqlDataAdapter("UPDATE calendar_events SET Date = '" & txt_new_date.Text & "', Caption = '" & txt_new_caption.Text & "', Description= '" & txt_new_description.Text & "'
                                                        WHERE ID ='" & Event_id & "'", sql_con)
                        sql_da.Fill(sql_ds, "calendar_events")
                        Me.Close()
                        Management_Calendar.display_current_date()
                        Management.btn_management_message.Text = "Event Updated Successflly"
                        Management.btn_management_message.Show()
                        message(Management.btn_management_message, "success")

                    End If
                Else
                    Management.btn_management_message.Text = "Please fill out all required (*) fields"
                    Management.btn_management_message.Show()
                    message(Management.btn_management_message, "warning")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_new_event_delete_Click(sender As Object, e As EventArgs) Handles btn_new_event_delete.Click
        Try
            Dim repos As DialogResult = MessageBox.Show("You are about to Update Event, are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If repos = DialogResult.Yes Then
                sql_ds = New DataSet
                sql_da = New MySqlDataAdapter("DELETE FROM calendar_events where ID ='" & Event_id & "'", sql_con)
                sql_da.Fill(sql_ds, "calendar_events")
                Me.Close()
                Management_Calendar.display_current_date()
                Management.btn_management_message.Text = "Event Deleted Successflly"
                Management.btn_management_message.Show()
                message(Management.btn_management_message, "success")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class