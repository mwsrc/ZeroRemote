Imports System.Text

Public Class SecureStrings


    Public Shared Pass As String = "SecureZRSettings"

    ' RC4 Encryption
    Public Shared Function Rc4(ByVal message As String) As String
        Dim s = Enumerable.Range(0, 256).ToArray
        Dim i, j As Integer
        For i = 0 To s.Length - 1
            j = (j + Asc(Pass(i Mod Pass.Length)) + s(i)) And 255
            Dim temp = s(i)
            s(i) = s(j)
            s(j) = temp
        Next
        i = 0
        j = 0
        Dim sb As New StringBuilder(message.Length)
        For Each c As Char In message
            i = (i + 1) And 255
            j = (j + s(i)) And 255
            Dim temp = s(i)
            s(i) = s(j)
            s(j) = temp
            sb.Append(Chr(s((s(i) + s(j)) And 255) Xor Asc(c)))
        Next
        Return sb.ToString
    End Function

End Class
