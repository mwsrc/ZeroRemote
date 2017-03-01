Imports System.Text

Public Class BuilderAssemblyInformation

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim Param As CreateParams = MyBase.CreateParams
            Param.ClassStyle = Param.ClassStyle Or &H200
            Return Param
        End Get
    End Property

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAssemblyVersion.KeyPress
        Dim allowedChars As String = "0123456789."
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Function RandomString() As String
        Dim chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz"
        Dim random = New Random(Guid.NewGuid().GetHashCode())
        Dim mystring = New String(Enumerable.Repeat(chars, 20).[Select](Function(s) s(random.[Next](s.Length))).ToArray())
        Return mystring
    End Function

    ' Generate a random version string
    Private Function RandomVersion() As String
        Dim CharSet As String = "1234567890."
        Dim RandomMutex As New StringBuilder
        Dim rnd As New System.Random
        For i As Integer = 0 To 11

            If Not CharSet.ElementAt(rnd.Next(0, 11)) = "." AndAlso ((i = 0) Or (i = 11)) Then
                RandomMutex.Append(CharSet.ElementAt(rnd.Next(0, 10)))
            Else
                RandomMutex.Append(CharSet.ElementAt(rnd.Next(0, 11)))
            End If
        Next
        Return RandomMutex.ToString
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBoxAssemblyCompany.Text = RandomString()
        TextBoxAssemblyCopyright.Text = RandomString()
        TextBoxAssemblyDescription.Text = RandomString()
        TextBoxAssemblyProduct.Text = RandomString()
        TextBoxAssemblyTitle.Text = RandomString()
        TextBoxAssemblyTrademark.Text = RandomString()
        TextBoxAssemblyVersion.Text = RandomVersion()
    End Sub


    ' Clone assembly information of an existing file
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim assemblypath As String = String.Empty
        Dim SelectAssemblyToCloneDialog As New OpenFileDialog
        SelectAssemblyToCloneDialog.Filter = "Executables |*.exe*"
        SelectAssemblyToCloneDialog.Multiselect = False
        SelectAssemblyToCloneDialog.Title = "Select Assembly to Clone"
        If SelectAssemblyToCloneDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            assemblypath = SelectAssemblyToCloneDialog.FileName
            Dim FileInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(assemblypath)
            TextBoxAssemblyCompany.Text = FileInfo.CompanyName
            TextBoxAssemblyCopyright.Text = FileInfo.LegalCopyright
            TextBoxAssemblyDescription.Text = FileInfo.FileDescription
            TextBoxAssemblyProduct.Text = FileInfo.ProductName
            TextBoxAssemblyTitle.Text = FileInfo.OriginalFilename
            TextBoxAssemblyTrademark.Text = FileInfo.LegalTrademarks
            TextBoxAssemblyVersion.Text = FileInfo.FileVersion
        Else
            Exit Sub
        End If
    End Sub
End Class
