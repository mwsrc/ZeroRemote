Imports System.Drawing.Drawing2D

Public Class AboutAndCredits

End Class

Class DarkTabControl
    Inherits TabControl

#Region "Functions"

    Private Function ChangeLightness(color__1 As Color, coef As Single) As Color
        Return Color.FromArgb(CInt(color__1.R * coef), CInt(color__1.G * coef), CInt(color__1.B * coef))
    End Function

#End Region

#Region "Initialize/Properties"

    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.DoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Font = New Font("Verdana", 8.0F)
        SizeMode = TabSizeMode.Fixed
        ItemSize = New Size(26, 121)
        Dock = DockStyle.Fill

        StringF = New StringFormat() With { _
                 .Alignment = StringAlignment.Near, _
                 .LineAlignment = StringAlignment.Center _
        }
        SelectFillBrush = New SolidBrush(Color.FromArgb(30, 30, 30))
        HoverFillBrush = New SolidBrush(Color.FromArgb(37, 37, 37))
        HighlightColor = Color.FromArgb(81, 126, 210)
    End Sub

    Public Property Highlight() As Color
        Get
            Return HighlightColor
        End Get
        Set(value As Color)
            HighlightColor = value
            Invalidate()
        End Set
    End Property

#End Region

#Region "Overrides"

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        Alignment = TabAlignment.Left
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        For i As Integer = 0 To TabCount - 1
            If GetTabRect(i).Contains(e.Location) Then
                HoverIndex = i
                Invalidate()
            End If
        Next
        MyBase.OnMouseMove(e)
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        HoverIndex = -1
        Invalidate()
        MyBase.OnMouseLeave(e)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        G = e.Graphics

        G.SmoothingMode = SmoothingMode.HighQuality

        G.Clear(DefaultBackColor)

        G.FillRectangle(Brushes.White, New Rectangle(0, 0, Width, Height))
        G.FillRectangle(SelectFillBrush, New Rectangle(0, 0, ItemSize.Height + 2, Height))

        For i As Integer = 0 To TabCount - 1
            Dim TabRect As Rectangle = GetTabRect(i)

            G.DrawLine(New Pen(Color.FromArgb(94, 94, 94)), New Point(TabRect.X, TabRect.Y), New Point(ItemSize.Height + 1, TabRect.Y))
            G.DrawLine(New Pen(Color.FromArgb(25, 25, 25)), New Point(TabRect.X, TabRect.Y - (TabRect.Height - 25)), New Point(ItemSize.Height + 1, TabRect.Y - (TabRect.Height - 25)))

            NoSelectFillBrush = New LinearGradientBrush(TabRect, Color.FromArgb(50, 50, 50), Color.FromArgb(41, 41, 41), 90.0F)

            If i = SelectedIndex Then
                G.FillRectangle(SelectFillBrush, TabRect)
                G.DrawLine(New Pen(HighlightColor), New Point(TabRect.X + 8, TabRect.Y - (TabRect.Height - 46)), New Point(TabRect.X + (TabRect.Width - 10), TabRect.Y - (TabRect.Height - 46)))
                G.DrawLine(New Pen(ChangeLightness(HighlightColor, 0.75F)), New Point(TabRect.X + 8, TabRect.Y - (TabRect.Height - 47)), New Point(TabRect.X + (TabRect.Width - 10), TabRect.Y - (TabRect.Height - 47)))
            ElseIf i = HoverIndex Then
                G.FillRectangle(HoverFillBrush, TabRect)
            Else
                G.FillRectangle(NoSelectFillBrush, TabRect)
            End If

            G.DrawString(TabPages(i).Text, Font, Brushes.Black, New Rectangle(TabRect.X + 8, TabRect.Y + 1, TabRect.Width, TabRect.Height), StringF)
            G.DrawString(TabPages(i).Text, Font, Brushes.White, New Rectangle(TabRect.X + 7, TabRect.Y, TabRect.Width, TabRect.Height), StringF)
        Next

        G.DrawLine(Pens.Black, New Point(ItemSize.Height + 2, 1), New Point(ItemSize.Height + 2, Height))
        G.DrawLine(New Pen(Color.FromArgb(25, 25, 25)), New Point(2, (TabCount * 26) + 2), New Point(122, (TabCount * 26) + 2))
    End Sub

#End Region

#Region "Declares"

    Private NoSelectFillBrush As LinearGradientBrush
    Private StringF As StringFormat
    Private SelectFillBrush As Brush, HoverFillBrush As Brush
    Private HighlightColor As Color
    Private G As Graphics
    Private HoverIndex As Integer = -1

#End Region

End Class
