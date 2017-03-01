Imports System.Runtime.InteropServices
Imports System.Security
Imports System.Runtime.ConstrainedExecution
Imports System.Threading
Imports System.Text

Public Class Win32


    ' P/Invoek declarations

    Public Delegate Function CallBack(ByVal hwnd As IntPtr, ByVal lParam As IntPtr) As Boolean
    Public Shared ActiveWindows As New ObjectModel.Collection(Of IntPtr)
    Public Delegate Function EnumWindowsProc(hWnd As IntPtr, lParam As IntPtr) As Boolean
    Public Delegate Function ConsoleEventDelegate(ByVal MyEvent As ConsoleEvent) As Boolean
    Public ReadingThread As Thread
    Public Const Windows = 11

    Public Enum ConsoleEvent
        CTRL_C_EVENT = 0
        CTRL_BREAK_EVENT = 1
        CTRL_CLOSE_EVENT = 2
        CTRL_LOGOFF_EVENT = 5
        CTRL_SHUTDOWN_EVENT = 6
    End Enum

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure SECURITY_ATTRIBUTES
        Public nLength As Integer
        Public lpSecurityDescriptor As Integer
        Public bInheritHandle As Integer
    End Structure

    <DllImport("kernel32.dll")> _
    Public Shared Function CopyFile(ByVal lpExistingFileName As String, ByVal lpNewFileName As String, ByVal bFailIfExists As Boolean) As Boolean
    End Function
    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function CreateDirectory(ByVal lpPathName As String, ByVal lpSecurityAttributes As SECURITY_ATTRIBUTES) As Boolean
    End Function
    <DllImport("kernel32.dll", SetLastError:=True, CharSet:=Runtime.InteropServices.CharSet.Ansi, ExactSpelling:=True)>
    Public Shared Function GetProcAddress(ByVal hModule As IntPtr, ByVal procName As String) As IntPtr
    End Function
    <DllImport("kernel32.dll", SetLastError:=True)> _
    Friend Shared Function IsWow64Process(<[In]> hSourceProcessHandle As IntPtr, <MarshalAs(UnmanagedType.Bool)> ByRef isWow64 As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
    <DllImport("kernel32.dll")>
    Public Shared Function WriteProcessMemory(ByVal hProcess As IntPtr, ByVal lpBaseAddress As IntPtr, ByVal lpBuffer As Byte(), ByVal nSize As UInteger, ByRef lpNumberOfBytesWritten As UInt32) As Boolean
    End Function
    <DllImport("kernel32.dll")>
    Public Shared Function GetCurrentProcess() As IntPtr
    End Function
    <DllImport("kernel32")> _
    Public Shared Function AllocConsole() As Boolean
    End Function
    <DllImport("kernel32.dll")> _
    Public Shared Function FreeConsole() As Int32
    End Function
    <DllImport("kernel32.dll")> _
    Public Shared Function SetConsoleCtrlHandler(ByVal handlerRoutine As ConsoleEventDelegate, ByVal add As Boolean) As Boolean
    End Function
    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, ExactSpelling:=True)> _
    Public Shared Function IsDebuggerPresent() As Boolean
    End Function
    <DllImport("user32.dll", EntryPoint:="MessageBoxW", SetLastError:=True, Charset:=CharSet.Unicode)> _
    Public Shared Function MessageBox(hwnd As IntPtr, <MarshalAs(UnmanagedType.LPTStr)> lpText As String, <MarshalAs(UnmanagedType.LPTStr)> lpCaption As String, <MarshalAs(UnmanagedType.U4)> uType As MessageBoxOptions) As <MarshalAs(UnmanagedType.U4)> MessageBoxResult
    End Function
    <DllImport("user32.dll")> _
    Public Shared Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    End Function
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Shared Function SetWindowText(ByVal hwnd As IntPtr, ByVal lpString As String) As Boolean
    End Function
    <DllImport("user32.dll")> _
    Public Shared Function EnableWindow(ByVal hwnd As Int32, ByVal nOption As Int32) As Int32
    End Function
    <DllImport("user32.dll")> _
    Public Shared Function SendMessageA(ByVal Hwnd As IntPtr, ByVal Message As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function EnumWindows(callback As EnumWindowsProc, extraData As IntPtr) As Boolean
    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Public Shared Function IsWindowVisible(ByVal hWnd As IntPtr) As Boolean
    End Function
    <DllImport("user32.dll")> _
    Public Shared Function IsZoomed(hwnd As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll")> _
    Public Shared Function IsIconic(hwnd As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll")> _
    Public Shared Function ShowWindow(hwnd As IntPtr, nCmdShow As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Shared Function FindWindowEx(ByVal parentHandle As IntPtr, ByVal childAfter As IntPtr, ByVal lclassName As String, ByVal windowTitle As String) As IntPtr
    End Function
    <DllImport("user32.dll", SetLastError:=True)> _
    Public Shared Function GetWindow(hWnd As IntPtr, uCmd As GetWindow_Cmd) As IntPtr
    End Function
    <DllImport("User32.dll")> _
    Public Shared Function SwapMouseButton(ByVal fSwap As IntPtr) As Boolean
    End Function
    <DllImport("user32.dll")> _
    Public Shared Function BlockInput(fBlockIt As Boolean) As Long
    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As UInt32, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll")> _
    Public Shared Function GetDesktopWindow() As Integer
    End Function
    <DllImport("user32.dll")> _
    Public Shared Function GetForegroundWindow() As IntPtr
    End Function
    <DllImport("user32.dll")> _
    Public Shared Function GetWindowText(ByVal hWnd As IntPtr, ByVal text As StringBuilder, ByVal Count As Integer) As Integer
    End Function
    <DllImport("advapi32.dll", SetLastError:=True)> _
    Public Shared Function OpenProcessToken(h As IntPtr, acc As Integer, ByRef phtok As IntPtr) As Boolean
    End Function
    <DllImport("advapi32.dll", SetLastError:=True)> _
    Public Shared Function LookupPrivilegeValue(host As String, name As String, ByRef pluid As Long) As Boolean
    End Function
    <DllImport("advapi32.dll", SetLastError:=True)> _
    Public Shared Function AdjustTokenPrivileges(htok As IntPtr, disall As Boolean, ByRef newst As TokPriv1Luid, len As Integer, prev As IntPtr, relen As IntPtr) As Boolean
    End Function
    <DllImport("user32.dll", SetLastError:=True)> _
    Public Shared Function ExitWindowsEx(flg As Integer, rea As Integer) As Boolean
    End Function
    <DllImport("advapi32.dll", SetLastError:=True)>
    Public Shared Function SetKernelObjectSecurity(ByVal Handle As IntPtr, ByVal securityInformation As Integer, <[In]()> ByVal pSecurityDescriptor As Byte()) As Boolean
    End Function
    <DllImport("advapi32.dll", SetLastError:=True)>
    Public Shared Function GetKernelObjectSecurity(ByVal Handle As IntPtr, ByVal securityInformation As Integer, <Out()> ByVal pSecurityDescriptor As Byte(), ByVal nLength As UInteger, ByRef lpnLengthNeeded As UInteger) As Boolean
    End Function
    <DllImport("advapi32.dll")> _
    Public Shared Function RegDeleteKeyValue(ByVal handle As IntPtr, ByVal keyName As String, ByVal valueName As String) As Long
    End Function
    <DllImport("ntdll.dll", SetLastError:=True)>
    Public Shared Function NtSetInformationProcess(ByVal hProcess As IntPtr, ByVal processInformationClass As Integer, ByRef processInformation As Integer, ByVal processInformationLength As Integer) As Integer
    End Function
    <DllImport("ntdll.dll")> _
    Public Shared Function ZwSetInformationProcess(ByVal _1 As IntPtr, ByVal _2 As IntPtr, ByVal _3 As IntPtr, ByVal _4 As IntPtr) As IntPtr
    End Function
    <DllImport("iphlpapi.dll", SetLastError:=True)> _
    Public Shared Function GetExtendedTcpTable(ByVal pTcpTable As IntPtr, ByRef dwOutBufLen As Integer, ByVal sort As Boolean, ByVal ipVersion As Integer, ByVal tblClass As TCP_TABLE_CLASS, ByVal reserved As Integer) As UInteger
    End Function
    <DllImport("iphlpapi.dll", SetLastError:=True)> _
    Public Shared Function GetExtendedUdpTable(ByVal pUdpTable As IntPtr, ByRef dwOutBufLen As Integer, ByVal sort As Boolean, ByVal ipVersion As Integer, ByVal tblClass As UDP_TABLE_CLASS, ByVal reserved As Integer) As UInteger
    End Function
    <DllImport("shlwapi.dll", SetLastError:=True, EntryPoint:="#437")> _
    Public Shared Function IsOS(os As Integer) As Boolean
    End Function
    <DllImport("winmm.dll", EntryPoint:="mciSendStringA")> _
    Public Shared Sub mciSendStringA(lpstrCommand As String, lpstrReturnString As String, uReturnLength As Long, hwndCallback As Long)
    End Sub
    <DllImport("Crypt32.dll", SetLastError:=True, CharSet:=System.Runtime.InteropServices.CharSet.Auto)> _
    Public Shared Function CryptUnprotectData(ByRef pDataIn As DATA_BLOB, ByVal szDataDescr As String, ByRef pOptionalEntropy As DATA_BLOB, ByVal pvReserved As IntPtr, ByRef pPromptStruct As CRYPTPROTECT_PROMPTSTRUCT, ByVal dwFlags As Integer, ByRef pDataOut As DATA_BLOB) As Boolean
    End Function
    <ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail), DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function GetModuleHandle(moduleName As String) As IntPtr
    End Function

    Public Enum TCP_TABLE_CLASS
        TCP_TABLE_BASIC_LISTENER
        TCP_TABLE_BASIC_CONNECTIONS
        TCP_TABLE_BASIC_ALL
        TCP_TABLE_OWNER_PID_LISTENER
        TCP_TABLE_OWNER_PID_CONNECTIONS
        TCP_TABLE_OWNER_PID_ALL
        TCP_TABLE_OWNER_MODULE_LISTENER
        TCP_TABLE_OWNER_MODULE_CONNECTIONS
        TCP_TABLE_OWNER_MODULE_ALL
    End Enum

    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure TokPriv1Luid
        Public Count As Integer
        Public Luid As Long
        Public Attr As Integer
    End Structure

    <Flags()> Enum CryptProtectPromptFlags
        CRYPTPROTECT_PROMPT_ON_UNPROTECT = &H1
        CRYPTPROTECT_PROMPT_ON_PROTECT = &H2
    End Enum
    <StructLayout(Runtime.InteropServices.LayoutKind.Sequential, CharSet:=Runtime.InteropServices.CharSet.Unicode)> Structure CRYPTPROTECT_PROMPTSTRUCT
        Public cbSize As Integer
        Public dwPromptFlags As CryptProtectPromptFlags
        Public hwndApp As IntPtr
        Public szPrompt As String
    End Structure
    <StructLayout(Runtime.InteropServices.LayoutKind.Sequential, CharSet:=Runtime.InteropServices.CharSet.Unicode)> Structure DATA_BLOB
        Public cbData As Integer
        Public pbData As IntPtr
    End Structure

    Public Enum GetWindow_Cmd As UInteger
        GW_HWNDFIRST = 0
        GW_HWNDLAST = 1
        GW_HWNDNEXT = 2
        GW_HWNDPREV = 3
        GW_OWNER = 4
        GW_CHILD = 5
        GW_ENABLEDPOPUP = 6
    End Enum

    Public Enum UDP_TABLE_CLASS
        UDP_TABLE_BASIC
        UDP_TABLE_OWNER_PID
        UDP_TABLE_OWNER_MODULE
    End Enum
    Public Enum MessageBoxResult As UInteger
        Ok = 1
        Cancel
        Abort
        Retry
        Ignore
        Yes
        No
        Close
        Help
        TryAgain
        ContinueOn
        Timeout = 32000
    End Enum
    Private Enum RegHive
        HKEY_CLASSES_ROOT = &H80000000
        HKEY_CURRENT_USER = &H80000001
        HKEY_LOCAL_MACHINE = &H80000002
        HKEY_USERS = &H80000003
        HKEY_CURRENT_CONFIG = &H80000005
    End Enum
    <SecurityCritical> _
    Friend Shared Function DoesWin32MethodExist(moduleName As String, methodName As String) As Boolean
        Dim moduleHandle As IntPtr = GetModuleHandle(moduleName)
        If moduleHandle = IntPtr.Zero Then
            Return False
        End If
        Return (GetProcAddress(moduleHandle, methodName) <> IntPtr.Zero)
    End Function
    <SecuritySafeCritical> _
    Public Shared Function GetOSArchitecture() As String
        Dim flag As Boolean
        If (IntPtr.Size = 8) OrElse ((DoesWin32MethodExist("kernel32.dll", "IsWow64Process") AndAlso IsWow64Process(GetCurrentProcess(), flag)) AndAlso flag) = True Then
            Return "x64"
        Else
            Return "x86"
        End If
    End Function

    Public Const SW_HIDE As Integer = 0
    Public Const SW_SHOW As Integer = 1
    Public Const SE_PRIVILEGE_ENABLED As Integer = &H2
    Public Const TOKEN_QUERY As Integer = &H8
    Public Const TOKEN_ADJUST_PRIVILEGES As Integer = &H20
    Public Const SE_SHUTDOWN_NAME As String = "SeShutdownPrivilege"
    Public Const EWX_LOGOFF As Integer = &H0
    Public Const EWX_SHUTDOWN As Integer = &H1
    Public Const EWX_REBOOT As Integer = &H2
    Public Const EWX_FORCE As Integer = &H4
    Public Const EWX_POWEROFF As Integer = &H8
    Public Const EWX_FORCEIFHUNG As Integer = &H10
    Public Const WM_SYSCOMMAND As Integer = &H112
    Public Const SC_SCREENSAVE As Integer = &HF140


    ' Uninstall P/Invoke Calls

    <DllImport("kernel32.dll", EntryPoint:="MoveFileEx")> _
    Public Shared Function MoveFileEx( _
ByVal fileName As String, _
ByVal newName As String, _
ByVal flags As UInteger) As Boolean
    End Function

    <DllImport("advapi32.dll", EntryPoint:="OpenProcessToken")> _
    Public Shared Function OpenToken( _
ByVal handle As IntPtr, _
ByVal access As UInteger, _
ByRef token As IntPtr) As Boolean
    End Function

    <DllImport("advapi32.dll", EntryPoint:="LookupPrivilegeValue")> _
    Public Shared Function GetPrivilegeID( _
ByVal machine As String, _
ByVal name As String, _
ByRef luid As Long) As Boolean
    End Function

    <DllImport("advapi32.dll", EntryPoint:="AdjustTokenPrivileges")> _
    Public Shared Function SetPrivilege( _
ByVal token As IntPtr, _
ByVal release As Boolean, _
ByRef newState As TokenPrivilege, _
ByVal zero1 As UInteger, _
ByVal zero2 As IntPtr, _
ByVal zero3 As IntPtr) As Boolean
    End Function

    <DllImport("advapi32.dll", EntryPoint:="InitiateSystemShutdownEx")> _
    Public Shared Function ShutdownEx( _
ByVal machine As String, _
ByVal message As String, _
ByVal timeout As UInteger, _
ByVal force As Boolean, _
ByVal reboot As Boolean, _
ByVal reason As UInteger) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure TokenPrivilege
        Public Count As UInteger
        Public LUID As Long
        Public Flags As UInteger
    End Structure

End Class
