'Imports Amazon.SimpleNotificationService
'Imports Amazon.SimpleNotificationService.Model
Imports MySql.Data.MySqlClient
Public Class Test
    'Dim mySNSClient As New AmazonSimpleNotificationServiceClient

    'Try
    'Dim snsRequest As New PublishRequest
    'Dim snsResponse As New PublishResponse
    'Dim snsMessageSettings As New Dictionary(Of String, MessageAttributeValue)()
    '        snsMessageSettings.Add("AWS.SNS.SMS.SenderID", New MessageAttributeValue() With {.StringValue = "HTU-JMTC", .DataType = "String"})
    '        snsMessageSettings.Add("AWS.SNS.SMS.SMSType", New MessageAttributeValue() With {.StringValue = "Promotional", .DataType = "String"})
    '        snsRequest.MessageAttributes = snsMessageSettings
    '        snsRequest.PhoneNumber = "233553279261"
    '        snsRequest.Message = "Welcome to HTU-JMTC, We render all kinds of Mechanical Servces. What can we do for you?"
    '        snsResponse = mySNSClient.Publish(snsRequest)
    '        MsgBox(snsResponse.MessageId)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

End Class