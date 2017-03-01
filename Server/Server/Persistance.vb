Imports System.IO
Imports System.Threading

Class Persistance


    ' Create a twin process, which will watch the current server process, if one of the two processes is killed, they will
    ' always restart each other again.
    ' Also mutex is adjusted.
    ' A process can be a watcher or a server process, so only one is listening for incoming commands.

#Region "Private Variables"

    Private name As String = String.Empty
    Private hash As String = String.Empty
    Private running As Boolean = False
    Private exitcode As Integer = 0
    Private _interval As Integer = 100

#End Region

#Region "Events"

    Public Event [Error](ByVal sender As Object, ByVal ex As Exception)
    Public Event StopCallback(ByVal sender As Object, ByVal ExitCode As Integer)

#End Region

#Region "Properties"

    Public ReadOnly Property CurrentHash As String
        Get
            Return Me.hash
        End Get
    End Property

    Public ReadOnly Property IsRunning As Boolean
        Get
            Return running
        End Get
    End Property

    Public ReadOnly Property IsWatcher As Boolean
        Get
            If Environment.GetCommandLineArgs.Length > 1 Then
                Return Environment.GetCommandLineArgs(1) = hash
            Else
                Return False
            End If
        End Get
    End Property

    Public Property Interval As Integer
        Set(value As Integer)
            _interval = value
        End Set
        Get
            Return _interval
        End Get
    End Property

#End Region

#Region "Public Methods"

    Sub New()
        name = Process.GetCurrentProcess.ProcessName
        hash = GetProcessHash(Process.GetCurrentProcess)
    End Sub

    Public Sub Start()
        If running Then Throw New Exception("The persistance is already running")
        running = True
        Dim t As New Thread(
          Sub()
              Try
                  Do While running
                      If CountProcesses() < 2 Then
                          If Not File.Exists(name & ".exe") Then Throw New Exception("The process cannot be started because the file does not exist")
                          If IsWatcher() Then
                              Process.Start(name)
                          Else
                              Process.Start(name, hash)
                          End If
                      End If
                      Thread.Sleep(_interval)
                  Loop
                  KillWatchers()
                  RaiseEvent StopCallback(Me, exitcode)
              Catch ex As Exception
                  RaiseEvent Error(Me, ex)
              End Try
          End Sub)
        t.Start()
    End Sub

    Public Sub [Stop]()
        If Not IsWatcher() Then running = False
    End Sub

    Public Sub [Stop](ByVal ExitCode As Integer)
        Me.exitcode = ExitCode
        If Not IsWatcher() Then running = False
    End Sub

    Public Sub KillWatchers()
        Try
            If IsWatcher() Then Return
            For Each p As Process In Process.GetProcessesByName(name)
                If p.Id <> Process.GetCurrentProcess.Id Then
                    If GetProcessHash(p) = hash Then
                        p.Kill()
                    End If
                End If
            Next
        Catch ex As Exception
            RaiseEvent Error(Me, ex)
        End Try
    End Sub

#End Region

#Region "Private Methods"

    Private Function GetProcessHash(ByVal p As Process) As String
        Try
            If p.HasExited Then Throw New Exception("The hash cannot be created because the process has exited")
            Dim path As String = p.MainModule.FileName
            If File.Exists(path) Then
                Dim f As New FileInfo(path)
                Return (f.Length + f.CreationTime.Second).ToString
            End If
        Catch ex As Exception
            RaiseEvent Error(Me, ex)
        End Try
        Return String.Empty
    End Function

    Private Function CountProcesses() As Integer
        Dim count As Integer = 0
        Try
            For Each p As Process In Process.GetProcessesByName(name)
                If GetProcessHash(p) = hash Then
                    count += 1
                End If
            Next
        Catch ex As Exception
            RaiseEvent Error(Me, ex)
        End Try
        Return count
    End Function

#End Region

End Class