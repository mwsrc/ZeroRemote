Public Class MiscFunctions


    Private Sub ButtonHideTaskBar_Click(sender As Object, e As EventArgs) Handles ButtonHideTaskBar.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Hiding taskbar...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|41")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Misc Functions")
        End Try
    End Sub

    Private Sub ButtonShowTaskBar_Click(sender As Object, e As EventArgs) Handles ButtonShowTaskBar.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Hiding taskbar...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|42")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Misc Functions")
        End Try
    End Sub

    Private Sub ButtonHideClock_Click(sender As Object, e As EventArgs) Handles ButtonHideClock.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Hiding clock...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|43")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Misc Functions")
        End Try
    End Sub

    Private Sub ButtonShowClock_Click(sender As Object, e As EventArgs) Handles ButtonShowClock.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Showing clock clock...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|44")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Misc Functions")
        End Try
    End Sub

    Private Sub ButtonLockTaskBar_Click(sender As Object, e As EventArgs) Handles ButtonLockTaskBar.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Locking taskbar...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|45")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Misc Functions")
        End Try
    End Sub

    Private Sub ButtonUnlockTaskBar_Click(sender As Object, e As EventArgs) Handles ButtonUnlockTaskBar.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Unlocking Taskbar...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|46")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Misc Functions")
        End Try
    End Sub

    Private Sub ButtonHideDesktopIcons_Click(sender As Object, e As EventArgs) Handles ButtonHideDesktopIcons.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Hiding Desktop Icons...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|47")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Misc Functions")
        End Try
    End Sub

    Private Sub ButtonShowDesktopIcons_Click(sender As Object, e As EventArgs) Handles ButtonShowDesktopIcons.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Showing Desktop Icons...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|48")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Misc Functions")
        End Try
    End Sub

    Private Sub ButtonBlockKeyboard_Click(sender As Object, e As EventArgs) Handles ButtonBlockKeyboard.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Blocking Mouse/Keyboard...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|49")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Misc Functions")
        End Try
    End Sub

    Private Sub ButtonUnblockKeyboard_Click(sender As Object, e As EventArgs) Handles ButtonUnblockKeyboard.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Unblocking Mouse/Keyboard...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|50")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Misc Functions")
        End Try
    End Sub

    Private Sub ButtonSwapMouse_Click(sender As Object, e As EventArgs) Handles ButtonSwapMouse.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Swapping mouse buttons...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|51")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Misc Functions")
        End Try
    End Sub

    Private Sub ButtonRestoreMouse_Click(sender As Object, e As EventArgs) Handles ButtonRestoreMouse.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Restoring mouse buttons...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|52")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Misc Functions")
        End Try
    End Sub

    Private Sub ButtonShutdown_Click(sender As Object, e As EventArgs) Handles ButtonShutdown.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Shutting down computer...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|53")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Misc Functions")
        End Try
    End Sub

    Private Sub ButtonReboot_Click(sender As Object, e As EventArgs) Handles ButtonReboot.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Rebooting down computer...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|54")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Misc Functions")
        End Try
    End Sub

    Private Sub ButtonLogoff_Click(sender As Object, e As EventArgs) Handles ButtonLogoff.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Logging off computer...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|55")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Misc Functions")
        End Try
    End Sub

    Private Sub ButtonScreensaver_Click(sender As Object, e As EventArgs) Handles ButtonScreensaver.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Launching screensaver...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|56")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Misc Functions")
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Opening Disk Tray...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|57")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Misc Functions")
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Closing Disk Tray...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|58")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Misc Functions")
        End Try
    End Sub
End Class