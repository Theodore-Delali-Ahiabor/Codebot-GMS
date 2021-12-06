'Imports Amazon.SimpleNotificationService
'Imports Amazon.SimpleNotificationService.Model
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Test
    Public Function Encoding(ByRef password As String)
        Dim wrapper As New Simple3Des()

        'Return Encrypted password
        Return wrapper.EncryptData(password)
    End Function
    Public Function Decoding(ByRef password As String)
        Dim wrapper As New Simple3Des()

        ' Decrypt the Password
        Return wrapper.DecryptData(password)
    End Function
    Public NotInheritable Class Simple3Des
        Private TripleDes As New TripleDESCryptoServiceProvider
        Private Function TruncateHash(ByVal key As String, ByVal length As Integer) As Byte()
            Dim sha1 As New SHA1CryptoServiceProvider

            ' Hash the key.
            Dim keyBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(key)
            Dim hash() As Byte = sha1.ComputeHash(keyBytes)

            ' Truncate or pad the hash.
            ReDim Preserve hash(length - 1)
            Return hash
        End Function

        'constructor to initialize the 3DES cryptographic service provider.
        Sub New()
            ' Initialize the crypto provider.
            TripleDes.Key = TruncateHash("Codebot_GMS", TripleDes.KeySize \ 8)
            TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
        End Sub

        Public Function EncryptData(ByVal plaintext As String) As String

            ' Convert the plaintext string to a byte array.
            Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)

            ' Create the stream.
            Dim ms As New System.IO.MemoryStream
            ' Create the encoder to write to the stream.
            Dim encStream As New CryptoStream(ms,
                TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
            encStream.FlushFinalBlock()

            ' Convert the encrypted stream to a printable string.
            Return Convert.ToBase64String(ms.ToArray)
        End Function

        Public Function DecryptData(ByVal encryptedtext As String) As String

            ' Convert the encrypted text string to a byte array.
            Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

            ' Create the stream.
            Dim ms As New System.IO.MemoryStream
            ' Create the decoder to write to the stream.
            Dim decStream As New CryptoStream(ms, TripleDes.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
            decStream.FlushFinalBlock()

            ' Convert the plaintext stream to a string.
            Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
        End Function
    End Class

    Private Sub btn_browse_img_Click(sender As Object, e As EventArgs) Handles btn_browse_img.Click
        TextBox2.Text = Encoding(TextBox1.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = Decoding(TextBox2.Text)
    End Sub
End Class