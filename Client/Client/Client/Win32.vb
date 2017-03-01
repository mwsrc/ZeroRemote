Imports System.Runtime.InteropServices

Public Class Win32

    ' P/Invoke definitions 

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
