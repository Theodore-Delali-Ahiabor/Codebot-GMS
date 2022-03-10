Public Class GMS_Message
    '------------------------------
    'HIDES THE MESSAGE WHEN CLICKED
    '------------------------------
    Private Sub GMS_Message_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.Hide()
    End Sub
    '------------------------------
    'HIDES THE MESSAGE WHEN CLICKED
    '------------------------------
    Private Sub message_text_Click(sender As Object, e As EventArgs) Handles message_text.Click
        GMS_Message_Click(Me, EventArgs.Empty)
    End Sub
    '------------------------------
    'HIDES THE MESSAGE WHEN CLICKED
    '------------------------------
    Private Sub message_icon_Click(sender As Object, e As EventArgs) Handles message_icon.Click, message_warning_icon.Click, message_information_icon.Click, message_error_icon.Click, message_success_icon.Click, PictureBox1.Click
        GMS_Message_Click(Me, EventArgs.Empty)
    End Sub
    '-------------------------------------------------------
    'OCCURES WHEN THE TIMER IS ACTIVATED AND BEGIINS TICKING
    '-------------------------------------------------------
    Private Sub message_timer_Tick(sender As Object, e As EventArgs) Handles message_timer.Tick
        If message_ts.Seconds = 0 Then
            Hide()
            message_timer.Stop()
        Else
            If message_ts.Seconds = 5 Then
                Opacity = 0.6
            ElseIf message_ts.Seconds = 4 Then
                Opacity = 0.55
            ElseIf message_ts.Seconds = 3 Then
                Opacity = 0.4
            ElseIf message_ts.Seconds = 2 Then
                Opacity = 0.35
            ElseIf message_ts.Seconds = 1 Then
                Opacity = 0.3
            End If
            message_ts = message_ts.Subtract(New TimeSpan(0, 0, 1))
        End If
    End Sub
    '------------------------------------------------------------------------
    'RESETS THE TIMER AND OPACITY OF THE MESSAGE WHEN THE MOUSE HOVERS OVER IT
    '------------------------------------------------------------------------
    Private Sub GMS_Message_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        message_ts = New TimeSpan(0, 0, 10)
        Opacity = 0.9
    End Sub

    Private Sub GMS_Message_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 30, Screen.PrimaryScreen.WorkingArea.Height - Screen.PrimaryScreen.WorkingArea.Height + 50)
    End Sub
End Class