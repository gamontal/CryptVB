Imports System.IO

Module ChkEncrypt
    Public ReadOnly Property CheckifFileisEncoded(ByVal filePath As String) As Boolean
        Get
            Dim newTextReader As String = My.Computer.FileSystem.ReadAllText(filePath)
            Dim str As [String] = newTextReader
            Try
                Dim data As Byte() = Convert.FromBase64String(str)
                Return (str.Replace(" ", "").Length Mod 4 = 0)
            Catch ex As Exception
                Return False
            End Try
        End Get
    End Property
End Module
