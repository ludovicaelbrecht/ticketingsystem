Imports System.Text
Imports System.Security.Cryptography


Namespace css


Public Module encryptMD5
    Public encryptedText As String

    Public Sub encryptMD5(ByVal str As String)
        Dim md5Hasher As New MD5CryptoServiceProvider
        Dim hashedDataBytes As Byte()
        Dim encoder As New UTF8Encoding

        hashedDataBytes = md5Hasher.ComputeHash(encoder.GetBytes(str))

        Dim b As Byte
        For Each b In hashedDataBytes
            encryptedText += b
        Next b

    End Sub
End Module

End Namespace
