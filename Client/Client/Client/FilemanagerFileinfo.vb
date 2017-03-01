Public Class FilemanagerFileinfo

    Private Function HexToImage(ByVal Hex As String) As Image
        Dim Bytes(Hex.Length \ 2 - 1) As Byte
        For I = 0 To Bytes.Length - 1
            Bytes(I) = Convert.ToByte(Hex.Substring(I * 2, 2), 16)
        Next
        Return Image.FromStream(New IO.MemoryStream(Bytes))
    End Function

    Public Sub SplitFileInfo()
        Dim InfoString() As String
        Try
            InfoString = Split(CStr(Main.ReadData), "|||")
        Catch
            MsgBox("Failed formatting Info. Please Retry.", MsgBoxStyle.Exclamation)
            Exit Sub
        End Try
        PictureBox1.Image = HexToImage(InfoString(0))
        TextBoxFilename.Text = InfoString(1)
        TextBoxFileDescription.Text = InfoString(2)
        TextBoxFileType.Text = InfoString(3)
        TextBoxLocation.Text = InfoString(4)
        LabelCreationDate.Text = InfoString(5)
        LabelFilesize.Text = InfoString(6)
        If InfoString(7) = "1" Then
            CheckBoxHidden.Checked = True
        Else
            CheckBoxHidden.Checked = False
        End If
        If InfoString(7) = "1" Then
            CheckBoxHidden.Checked = True
        Else
            CheckBoxHidden.Checked = False
        End If
        If InfoString(8) = "1" Then
            CheckBoxSystem.Checked = True
        Else
            CheckBoxSystem.Checked = False
        End If
        If InfoString(9) = "1" Then
            CheckBoxReadonly.Checked = True
        Else
            CheckBoxReadonly.Checked = False
        End If
        If InfoString(10) = "1" Then
            CheckBoxTemporary.Checked = True
        Else
            CheckBoxTemporary.Checked = False
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class