

Public Class Management_Feedbacks


    Private Function GetMails(ByVal hostname As String, ByVal port As Integer, ByVal useSsl As Boolean, ByVal username As String, ByVal password As String) As List(Of OpenPop.Mime.Message)
        Dim client As OpenPop.Pop3.Pop3Client = New OpenPop.Pop3.Pop3Client()
        client.Connect(hostname, port, useSsl)
        client.Authenticate(username, password)

        Dim messageCount As Integer = client.GetMessageCount()

        Dim allMessages As List(Of OpenPop.Mime.Message) = New List(Of OpenPop.Mime.Message)(messageCount)

        For count As Integer = 1 To messageCount
            Try
                MsgBox("check")
                allMessages.Add(client.GetMessage(count))
                MsgBox("check" + allMessages.ToString)
            Catch ex As OpenPop.Pop3.Exceptions.PopServerException
                allMessages.Add(Nothing)
                MsgBox("Error - " + ex.ToString)

            End Try
        Next
        Return allMessages
        'MsgBox(allMessages)
    End Function

    Private Sub btn_new_mail_Click(sender As Object, e As EventArgs) Handles btn_new_mail.Click
        If CheckForInternetConnection() = True Then
            MsgBox("You are connected")
        Else
            MsgBox("No Internet Connection")
        End If

    End Sub
End Class