Public Class Divider
    Inherits Control

    Sub New()
        SetStyle(ControlStyles.ResizeRedraw, True)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        ControlPaint.DrawBorder3D(e.Graphics, New Rectangle(0, 0, Me.Width, Me.Height), Border3DStyle.Etched, Border3DSide.Top)
    End Sub

End Class