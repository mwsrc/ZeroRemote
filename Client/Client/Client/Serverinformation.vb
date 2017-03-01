Public Class Serverinformation

    ' This feature will grab the settings that have been applied to the created server file.

    Private Sub ButtonRefreshServerInfo_Click(sender As Object, e As EventArgs) Handles ButtonRefreshServerInfo.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Refreshing serverinformation...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|14")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Serverinformation")
        End Try
    End Sub

    Public Sub SplitTreeviewData()
        TreeViewServerInfo.Nodes.Clear()
        Dim Data As String = Main.ReadData()
        Dim Parts() As String = Split(Data, "|||")
        For i As Integer = 0 To UBound(Parts)
            TreeViewServerInfo.Nodes.Add(New TreeNode(Parts(i), i, i))
        Next
    End Sub

    Private Sub Serverinformation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            TreeViewServerInfo.Nodes(0).Text = "Processname: ??"
            TreeViewServerInfo.Nodes(1).Text = "Memory Usage: ??"
            TreeViewServerInfo.Nodes(2).Text = "Executable Path: ??"
            TreeViewServerInfo.Nodes(3).Text = "Autostart at reboot: ??"
            TreeViewServerInfo.Nodes(4).Text = "Unique ID: ??"
            TreeViewServerInfo.Nodes(5).Text = "Protected Process: ??"
            TreeViewServerInfo.Nodes(6).Text = "Privileges: ??"
            TreeViewServerInfo.Nodes(7).Text = "Visible Mode: ??"
            TreeViewServerInfo.Nodes(8).Text = "Hosting URL: ??"
        Catch
        End Try
    End Sub
End Class