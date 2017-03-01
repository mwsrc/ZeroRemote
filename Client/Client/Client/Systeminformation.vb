Public Class Systeminformation


    Private Sub ButtonRefreshSystemInfo_Click(sender As Object, e As EventArgs) Handles ButtonRefreshSystemInfo.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Refreshing systeminformation...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|13")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Systeminformation")
        End Try
    End Sub

    Public Sub SplitTreeviewData()
        TreeViewSysInfo.Nodes.Clear()
        Dim Data As String = Main.ReadData()
        Dim Parts() As String = Split(Data, "|||")
        For i As Integer = 0 To UBound(Parts)
            TreeViewSysInfo.Nodes.Add(New TreeNode(Parts(i), i, i))
        Next
    End Sub

    Private Sub Systeminformation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            TreeViewSysInfo.Nodes(0).Text = "Username: ??"
            TreeViewSysInfo.Nodes(1).Text = "Computername: ??"
            TreeViewSysInfo.Nodes(2).Text = "Operating System: ??"
            TreeViewSysInfo.Nodes(3).Text = "Country: ??"
            TreeViewSysInfo.Nodes(4).Text = "Privileges: ??"
            TreeViewSysInfo.Nodes(5).Text = "Screen Resolution: ??"
            TreeViewSysInfo.Nodes(6).Text = "Bitsystem: ??"
            TreeViewSysInfo.Nodes(7).Text = "RAM: ??"
            TreeViewSysInfo.Nodes(8).Text = "Processor: ??"
            TreeViewSysInfo.Nodes(9).Text = "Graphics Card: ??"
            TreeViewSysInfo.Nodes(10).Text = "Time Since Last Reboot: ??"
            TreeViewSysInfo.Nodes(11).Text = "AntiVirus Software: ??"
            TreeViewSysInfo.Nodes(12).Text = "Firewall Software: ??"
            TreeViewSysInfo.Nodes(13).Text = "Webcam: ??"
        Catch
        End Try
    End Sub
End Class