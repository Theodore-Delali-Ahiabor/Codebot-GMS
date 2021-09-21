Imports MySql.Data.MySqlClient
Public Class Management_Calendar
    Public list_fl_day As New List(Of FlowLayoutPanel)
    Public current_date As New DateTime

    Private Sub Management_Calendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        current_date = DateTime.Today
        generatedaypanel(42)
        display_current_date()
    End Sub
    Public Sub generatedaypanel(ByRef totaldays As Integer)
        fl_days.Controls.Clear()
        list_fl_day.Clear()
        For i As Integer = 1 To totaldays
            Dim fl As New FlowLayoutPanel
            fl.Name = $"fl_day{i}"
            fl.Size = New Size(142, 75)
            fl.BackColor = Color.White
            fl.BorderStyle = BorderStyle.FixedSingle
            fl.Margin = fl_days.Margin
            fl_days.Controls.Add(fl)
            list_fl_day.Add(fl)
        Next
    End Sub
    Public Sub display_current_date()

        lbl_month_year.Text = current_date.ToString("MMMM, yyyy")
        add_label_of_day(get_first_day_of_week_of_current_date, get_total_days_of_current_month)
    End Sub
    Public Sub previous_month()
        current_date = current_date.AddMonths(-1)
        display_current_date()
    End Sub
    Public Sub next_month()
        current_date = current_date.AddMonths(1)
        display_current_date()
    End Sub
    Public Sub add_new_event_to_fl_day()

    End Sub
    Public Sub add_label_of_day(ByRef start_day_at_fl_number As Integer, total_days_in_month As Integer)
        For Each fl As FlowLayoutPanel In list_fl_day
            fl.Controls.Clear()
        Next
        For i As Integer = 1 To total_days_in_month
            Dim lbl As New Label
            lbl.Name = $"lbl_day{i}"
            lbl.AutoSize = False
            lbl.TextAlign = ContentAlignment.MiddleRight
            lbl.Size = New Size(139, 24)
            lbl.Text = i
            lbl.Font = New Font("Ebrima", 14)
            list_fl_day((i - 1) + (start_day_at_fl_number)).Controls.Clear()
            list_fl_day((i - 1) + (start_day_at_fl_number)).Controls.Add(lbl)
        Next
    End Sub
    Private Function get_first_day_of_week_of_current_date() As Integer
        Dim first_day_of_month As DateTime = New Date(current_date.Year, current_date.Month, 1)
        Return first_day_of_month.DayOfWeek + 1
    End Function
    Private Function get_total_days_of_current_month() As Integer
        Dim first_day_of_current_day As DateTime = New Date(current_date.Year, current_date.Month, 1)
        Return first_day_of_current_day.AddMonths(1).AddDays(-1).Day
    End Function
    Private Sub btn_calendar_current_month_Click(sender As Object, e As EventArgs) Handles btn_calendar_current_month.Click
        current_date = DateTime.Today
        display_current_date()
    End Sub

    Private Sub btn_calender_previous_month_Click(sender As Object, e As EventArgs) Handles btn_calender_previous_month.Click
        previous_month()
    End Sub

    Private Sub btn_calendar_next_month_Click(sender As Object, e As EventArgs) Handles btn_calendar_next_month.Click
        next_month()
    End Sub
End Class