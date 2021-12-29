Imports MySql.Data.MySqlClient
Public Class Management_Calendar
    Public list_fl_day As New List(Of FlowLayoutPanel)
    Public current_date As New DateTime

    Private Sub Management_Calendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        current_date = DateTime.Today
        generate_day_panel(42)
        display_current_date()
    End Sub
    Public Sub generate_day_panel(ByRef totaldays As Integer)
        fl_days.Controls.Clear()
        list_fl_day.Clear()
        For i As Integer = 1 To totaldays
            Dim fl As New FlowLayoutPanel
            fl.Name = $"fl_day{i}"
            fl.Size = New Size(142, 75)
            fl.BackColor = Color.White
            fl.BorderStyle = BorderStyle.FixedSingle
            fl.Cursor = Cursors.Hand
            fl.AutoScroll = True
            AddHandler fl.Click, AddressOf add_new_event_to_fl_day
            fl_days.Controls.Add(fl)
            'If i Mod 5 = 0 Then
            '    list_fl_day.Add()
            'End If
            list_fl_day.Add(fl)
        Next
    End Sub
    Public Sub display_current_date()
        Dim start_day As Integer = get_first_day_of_week_of_current_date()
        Dim total_number_of_days As Integer = get_total_days_of_current_month()
        lbl_month_year.Text = current_date.ToString("MMMM, yyyy")
        add_label_of_day(start_day, total_number_of_days)
        add_events_to_fl_day(start_day)
    End Sub
    Public Sub previous_month()
        current_date = current_date.AddMonths(-1)
        display_current_date()
    End Sub
    Public Sub next_month()
        current_date = current_date.AddMonths(1)
        display_current_date()
    End Sub
    Public Sub add_new_event_to_fl_day(sender As Object, e As EventArgs)
        Dim day As Integer = CType(sender, FlowLayoutPanel).Tag
        If day <> 0 Then
            With Management_Calendar_Add_New_Event
                .Event_id = 0
                .txt_new_caption.Text = ""
                .txt_new_description.Text = ""
                .txt_new_date.Text = current_date.Year & "-" & current_date.Month & "-" & day
                .btn_new_event_save.Text = "SAVE"
                .btn_new_event_cancel.Text = "CANCEL"
                .ShowDialog()
            End With

            display_current_date()
        End If
    End Sub
    Private Sub show_event_details(sender As Object, e As EventArgs)
        Try
            Dim event_id As Integer = CType(sender, LinkLabel).Tag
            Dim event_sql As String = $"SELECT * FROM calendar_events where ID = {event_id}"
            Dim dt = query_event_table(event_sql)
            If dt.rows.count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                With Management_Calendar_Add_New_Event
                    .Event_id = event_id
                    .txt_new_caption.Text = row("Caption")
                    .txt_new_date.Text = row("Date").year & "-" & row("Date").month & "-" & row("Date").day
                    .txt_new_description.Text = row("Description")
                    .btn_new_event_save.Text = "UPDATE"
                    .btn_new_event_cancel.Text = "DELETE"
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Event Details Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub add_events_to_fl_day(ByRef start_day_at_fl_number As Integer)
        Try
            Dim start_date As Date = New Date(current_date.Year, current_date.Month, 1)
            Dim end_date As Date = start_date.AddMonths(1).AddDays(-1)

            default_query = $"SELECT * FROM calendar_events 
                                where Date between '{start_date.Year & "-" & start_date.Month & "-" & start_date.Day }'  
                                and '{end_date.Year & "-" & end_date.Month & "-" & end_date.Day }' and employee_id = '" & login_id & "' "
            Dim dt = query_event_table(default_query)

            For Each row As DataRow In dt.Rows
                Dim link As New LinkLabel
                link.Tag = row("ID")
                link.Name = $"link{row("ID")}"
                link.Text = row("Caption")
                AddHandler link.Click, AddressOf show_event_details
                list_fl_day((row("Date").day) + (start_day_at_fl_number - 1)).Controls.Add(link)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Event Display Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub add_label_of_day(ByRef start_day_at_fl_number As Integer, total_days_in_month As Integer)
        For Each fl As FlowLayoutPanel In list_fl_day
            fl.Controls.Clear()
            fl.Tag = 0
            fl.BackColor = Color.White
        Next

        For i As Integer = 1 To total_days_in_month
            Dim lbl As New Label
            lbl.Name = $"lbl_day{i}"
            lbl.AutoSize = False
            lbl.TextAlign = ContentAlignment.MiddleRight
            lbl.Size = New Size(110, 24)
            lbl.Text = i
            lbl.Font = New Font("Ebrima", 14)
            fl_days.Enabled = True
            list_fl_day((i - 1) + (start_day_at_fl_number)).Tag = i
            list_fl_day((i - 1) + (start_day_at_fl_number)).Controls.Add(lbl)

            If New Date(current_date.Year, current_date.Month, i) = Date.Today Then
                list_fl_day((i - 1) + (start_day_at_fl_number)).BackColor = Color.Teal
                list_fl_day((i - 1) + (start_day_at_fl_number)).ForeColor = Color.White
            End If
        Next

    End Sub
    Private Function get_first_day_of_week_of_current_date() As Integer
        Dim first_day_of_month As DateTime = New Date(current_date.Year, current_date.Month, 1)
        Return first_day_of_month.DayOfWeek
    End Function
    Private Function get_total_days_of_current_month() As Integer
        Dim first_day_of_current_day As DateTime = New Date(current_date.Year, current_date.Month, 1)
        Return first_day_of_current_day.AddMonths(1).AddDays(-1).Day
    End Function
    Private Sub btn_calendar_current_month_Click(sender As Object, e As EventArgs)
        current_date = DateTime.Today
        display_current_date()
    End Sub

    Private Sub btn_calender_previous_month_Click(sender As Object, e As EventArgs)
        previous_month()
    End Sub

    Private Sub btn_calendar_next_month_Click(sender As Object, e As EventArgs)
        next_month()
    End Sub
    Public Function query_event_table(ByRef default_query As String)
        sql_da = New MySqlDataAdapter(default_query, sql_con)
        sql_ds = New DataSet
        sql_ds.Clear()
        sql_da.Fill(sql_ds, "result")
        Return sql_ds.Tables("result")

    End Function

    Private Sub pb_calendar_previous_Click(sender As Object, e As EventArgs) Handles pb_calendar_previous.Click
        previous_month()
    End Sub

    Public Sub pb_calendar_current_Click(sender As Object, e As EventArgs) Handles pb_calendar_current.Click
        current_date = DateTime.Today
        display_current_date()
    End Sub

    Private Sub pb_calendar_next_Click(sender As Object, e As EventArgs) Handles pb_calendar_next.Click
        next_month()
    End Sub
End Class