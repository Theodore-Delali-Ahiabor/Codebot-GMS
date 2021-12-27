'Imports Amazon.SimpleNotificationService
'Imports Amazon.SimpleNotificationService.Model
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Net.Mail
Public Class Test

    Private Sub btn_browse_img_Click(sender As Object, e As EventArgs) Handles btn_browse_img.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim web As New WebBrowser
        web.Navigate("whatsapp://send?phone=+233" & TextBox1.Text & "&text=" & TextBox2.Text & "")
        SendKeys.Send("{ENTER}")
            'Timer1.Start()

        'Timer1.Stop()
    End Sub
    Dim sec As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sec += 1
        If sec = 5 Then
            SendKeys.Send("{ENTER}")
            Timer1.Stop()
            sec = 0
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Question)
    End Sub
End Class