Imports System.Security.Cryptography

Public Class ApplicationSettings

    Public Const SettingsPass As String = "ZeroRemoteSettings"

    Public Shared Function RijndaelDecrypt(ByVal UDecryptU As String) As String
        Dim XoAesProviderX As New RijndaelManaged
        Dim XbtCipherX() As Byte
        Dim XbtSaltX() As Byte = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}
        Dim XoKeyGeneratorX As New Rfc2898DeriveBytes(SettingsPass, XbtSaltX)
        XoAesProviderX.Key = XoKeyGeneratorX.GetBytes(XoAesProviderX.Key.Length)
        XoAesProviderX.IV = XoKeyGeneratorX.GetBytes(XoAesProviderX.IV.Length)
        Dim XmsX As New IO.MemoryStream
        Dim XcsX As New CryptoStream(XmsX, XoAesProviderX.CreateDecryptor(), _
        CryptoStreamMode.Write)
        Try
            XbtCipherX = Convert.FromBase64String(UDecryptU)
            XcsX.Write(XbtCipherX, 0, XbtCipherX.Length)
            XcsX.Close()
            UDecryptU = System.Text.Encoding.UTF8.GetString(XmsX.ToArray)
        Catch
            Return ""
        End Try
        Return UDecryptU
    End Function

    Public Shared Function Rijndaelcrypt(ByVal File As String) As String
        Dim oAesProvider As New RijndaelManaged
        Dim btClear() As Byte
        Dim btSalt() As Byte = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}
        Dim oKeyGenerator As New Rfc2898DeriveBytes(SettingsPass, btSalt)
        oAesProvider.Key = oKeyGenerator.GetBytes(oAesProvider.Key.Length)
        oAesProvider.IV = oKeyGenerator.GetBytes(oAesProvider.IV.Length)
        Dim ms As New IO.MemoryStream
        Dim cs As New CryptoStream(ms, _
        oAesProvider.CreateEncryptor(), _
        CryptoStreamMode.Write)
        btClear = System.Text.Encoding.UTF8.GetBytes(File)
        cs.Write(btClear, 0, btClear.Length)
        cs.Close()
        File = Convert.ToBase64String(ms.ToArray)
        Return File
    End Function


End Class