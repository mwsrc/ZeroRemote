Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Windows.Forms
Public NotInheritable Class InfoButton
    Inherits Control

    Private bool_0 As Boolean

    Private string_0 As String

    Private bool_1 As Boolean

    Private bool_2 As Boolean

    Private bool_3 As Boolean

    Private pen_0 As Pen

    Private pen_1 As Pen

    Private pen_2 As Pen

    Private solidBrush_0 As SolidBrush

    Private solidBrush_1 As SolidBrush

    Private solidBrush_2 As SolidBrush

    Public Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            MyBase.Text = value
            Me.Invalidate()
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        Me.SetStyle((ControlStyles.UserPaint _
                        Or (ControlStyles.Opaque _
                        Or (ControlStyles.ResizeRedraw _
                        Or (ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer)))), True)
        Me.SetStyle(ControlStyles.Selectable, False)
        Me.pen_0 = New Pen(Color.FromArgb(120, 160, 220))
        Me.pen_1 = New Pen(Color.FromArgb(140, 180, 240))
        Me.pen_2 = New Pen(Color.FromArgb(150, 150, 150))
        Me.solidBrush_0 = New SolidBrush(Color.FromArgb(190, 230, 255))
        Me.solidBrush_1 = New SolidBrush(Color.FromArgb(200, 240, 255))
        Me.solidBrush_2 = New SolidBrush(Color.FromArgb(230, 230, 230))
    End Sub

    Public Function method_0() As Boolean
        Return Me.bool_0
    End Function

    Public Sub method_1(ByVal bool_4 As Boolean)
        Me.bool_0 = bool_4
        Me.Invalidate()
    End Sub

    Public Function method_2() As String
        Return Me.string_0
    End Function

    Public Sub method_3(ByVal string_1 As String)
        Me.string_0 = string_1
        Me.Invalidate()
    End Sub

    Public Function method_4() As Boolean
        Return Me.bool_1
    End Function

    Public Sub method_5(ByVal bool_4 As Boolean)
        Me.bool_1 = bool_4
        Me.Invalidate()
    End Sub

    Public Sub method_6()
        Me.Width = (Me.method_8 + 36)
    End Sub

    Private Function method_7() As String
        If Me.bool_1 Then
            Dim num As Integer = Me.method_8
            If (num _
                        > (Me.Width - 36)) Then
                Dim width As Integer = TextRenderer.MeasureText(" ", Me.Font).Width
                Dim num2 As Integer = CType(Math.Round(Math.Ceiling((CType((num _
                                    - (Me.Width - 36)), Double) / CType(width, Double)))), Integer)
                If ((Me.Text.Length - num2) _
                            > 3) Then
                    Return (Me.Text.Remove((Me.Text.Length _
                                    - (num2 - 3))) + "...")
                End If
                Return "..."
            End If
        End If
        Return Me.Text
    End Function

    Private Function method_8() As Integer
        Dim size As Size = TextRenderer.MeasureText(Me.Text, Me.Font)
        Dim size2 As Size
        If Not String.IsNullOrEmpty(Me.string_0) Then
            size2 = TextRenderer.MeasureText(Me.string_0, Me.Font)
        End If
        Return (size2.Width + (size.Width + CInt(Me.method_0)))
    End Function

    Protected Overrides Sub OnMouseEnter(ByVal eventArgs_0 As EventArgs)
        Me.bool_2 = True
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal eventArgs_0 As EventArgs)
        Me.bool_2 = False
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal mea As MouseEventArgs)
        Me.bool_3 = True
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal mea As MouseEventArgs)
        Me.bool_3 = False
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(ByVal paintEventArgs_0 As PaintEventArgs)
        Dim graphics As Graphics = paintEventArgs_0.Graphics
        graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
        Dim pen As Pen
        Dim brush As SolidBrush
        If Me.bool_3 Then
            pen = Me.pen_0
            brush = Me.solidBrush_0
        ElseIf Me.bool_2 Then
            pen = Me.pen_1
            brush = Me.solidBrush_1
        Else
            pen = Me.pen_2
            brush = Me.solidBrush_2
        End If
        graphics.FillRectangle(brush, Me.ClientRectangle)
        graphics.DrawRectangle(pen, 0, 0, (Me.Width - 1), (Me.Height - 1))
        Dim text As String = Me.method_7
        Dim sizeF As SizeF = graphics.MeasureString(text, Me.Font)
        Dim size As Size = sizeF.ToSize
        Dim size2 As Size
        If Not String.IsNullOrEmpty(Me.string_0) Then
            sizeF = graphics.MeasureString(Me.string_0, Me.Font)
            size2 = sizeF.ToSize
        End If
        Dim num As Integer = (size2.Width + (size.Width + CInt(Me.method_0)))
        Dim p As Point = New Point(CInt(((Me.Width / 2) _
                        - (num / 2))), CInt(((Me.Height / 2) _
                        - (size.Height / 2))))
        graphics.DrawString(text, Me.Font, Brushes.Black, p)
        graphics.DrawString(Me.string_0, Me.Font, Brushes.Gray, CType((p.X + size.Width), Single), CType(p.Y, Single))
        If Me.method_0 Then
            Dim path As GraphicsPath = Me.method_9((p.X _
                            + (size2.Width _
                            + (size.Width + 3))), CInt((p.Y _
                            + ((size.Height / 2) _
                            - 1))))
            graphics.FillPath(Brushes.Black, path)
        End If
    End Sub

    Private Function method_9(ByVal int_0 As Integer, ByVal int_1 As Integer) As GraphicsPath
        Dim graphicsPath As GraphicsPath = New GraphicsPath
        graphicsPath.AddLine((int_0 + 1), int_1, (int_0 + (7 + 1)), int_1)
        graphicsPath.AddLine((int_0 + 7), int_1, (int_0 + 4), (int_1 + (4 - 1)))
        graphicsPath.CloseFigure()
        Return graphicsPath
    End Function
End Class