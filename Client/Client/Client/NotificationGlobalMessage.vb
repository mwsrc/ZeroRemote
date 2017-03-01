Public Class NotificationGlobalMessage

    Sub New(ByVal Title As String, ByVal Message As String)
        InitializeComponent()
        LabelTitle.Text = Title
        LabelInfo.Text = Message
    End Sub


    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        e.Graphics.DrawRectangle(New Pen(Color.DarkGray, 1), 0, 0, Me.Width - 1, Me.Height - 1)
    End Sub

    Sub Me_Load() Handles MyBase.Load
        Me.Top = My.Computer.Screen.WorkingArea.Height + Me.Height
        Me.Left = My.Computer.Screen.WorkingArea.Width - Me.Width
    End Sub

    Public Sub MoveDown()
        While Me.Top - Me.Height < My.Computer.Screen.WorkingArea.Height
            Me.Top += 1
        End While
        Me.Close()
    End Sub

    Public Sub MoveUp()
        While Me.Bottom > My.Computer.Screen.WorkingArea.Height
            Me.Top -= 1
        End While
    End Sub

    Public Sub Toggle()
        If State = _State.Down Then
            MoveUp()
        Else
            MoveDown()
        End If
    End Sub

    Public ReadOnly Property State As _State
        Get
            If Me.Top > My.Computer.Screen.WorkingArea.Height Then
                Return _State.Down
            Else
                Return _State.Up
            End If
        End Get
    End Property

    Public Enum _State As Integer
        Up = 0
        Down = 1
    End Enum

    Private Sub Notification_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim TimeoutThread As New System.Threading.Thread(Sub()
                                                             System.Threading.Thread.Sleep(7000)
                                                             Invoke(New MethodInvoker(Sub()
                                                                                          Me.MoveDown()
                                                                                      End Sub))
                                                         End Sub)
        TimeoutThread.Start()
    End Sub


    Private Sub InfoButtonControl_Click_1(sender As Object, e As EventArgs)
        Main.Show()
        Main.TopMost = True
        Main.BringToFront()
        Main.WindowState = FormWindowState.Normal
    End Sub

End Class