Imports System.Drawing.Drawing2D

'------------------
'Creator: aeonhack
'Site: elitevs.net
'Created: 08/18/2012
'Changed: 01/16/2013
'Version: 1.3.0
'------------------
Public Class Graph
    Inherits Control

    Sub New()
        Dim B As New Bitmap(1, 1)
        SG = Graphics.FromImage(B)

        GP = New GraphicsPath()
        _Values = New List(Of Single)
        _SmoothValues = New List(Of Single)

        FillColor = Color.White
        BorderColor = Color.Gray

        GraphFillColor = Color.FromArgb(50, Color.LightGreen)
        GraphBorderColor = Color.ForestGreen

        HorizontalLineColor = Color.FromArgb(238, 238, 238)
        VerticalLineColor = Color.FromArgb(248, 248, 248)

        DataColumnForeColor = Color.Gray

        HoverFillColor = Color.White
        HoverBorderColor = Color.ForestGreen
        HoverLineColor = Color.FromArgb(35, Color.ForestGreen)

        HoverLabelForeColor = Color.Gray
        HoverLabelFillColor = Color.White
        HoverLabelBorderColor = Color.DarkGray
        HoverLabelShadowColor = Color.FromArgb(35, Color.Black)

        LineGraphColor = Color.FromArgb(130, 0, 200, 255)

        SetStyle(DirectCast(139286, ControlStyles), True)
    End Sub

#Region " Properties "

    Private _FillColor As SolidBrush
    Public Property FillColor() As Color
        Get
            Return _FillColor.Color
        End Get
        Set(ByVal value As Color)
            _FillColor = New SolidBrush(value)
            Invalidate()
        End Set
    End Property

    Private _BorderColor As Pen
    Public Property BorderColor() As Color
        Get
            Return _BorderColor.Color
        End Get
        Set(ByVal value As Color)
            _BorderColor = New Pen(value)
            Invalidate()
        End Set
    End Property

    Private _GraphFillColor As SolidBrush
    Public Property GraphFillColor() As Color
        Get
            Return _GraphFillColor.Color
        End Get
        Set(ByVal value As Color)
            _GraphFillColor = New SolidBrush(value)
            Invalidate()
        End Set
    End Property

    Private _GraphBorderColor As Pen
    Public Property GraphBorderColor() As Color
        Get
            Return _GraphBorderColor.Color
        End Get
        Set(ByVal value As Color)
            _GraphBorderColor = New Pen(value)
            Invalidate()
        End Set
    End Property

    Private _HorizontalLineColor As Pen
    Public Property HorizontalLineColor() As Color
        Get
            Return _HorizontalLineColor.Color
        End Get
        Set(ByVal value As Color)
            _HorizontalLineColor = New Pen(value)
            Invalidate()
        End Set
    End Property

    Private _VerticalLineColor As Pen
    Public Property VerticalLineColor() As Color
        Get
            Return _VerticalLineColor.Color
        End Get
        Set(ByVal value As Color)
            _VerticalLineColor = New Pen(value)
            Invalidate()
        End Set
    End Property

    Private _DataColumnForeColor As SolidBrush
    Public Property DataColumnForeColor() As Color
        Get
            Return _DataColumnForeColor.Color
        End Get
        Set(ByVal value As Color)
            _DataColumnForeColor = New SolidBrush(value)
            Invalidate()
        End Set
    End Property

    Private _HoverFillColor As SolidBrush
    Public Property HoverFillColor() As Color
        Get
            Return _HoverFillColor.Color
        End Get
        Set(ByVal value As Color)
            _HoverFillColor = New SolidBrush(value)
            Invalidate()
        End Set
    End Property

    Private _HoverBorderColor As Pen
    Public Property HoverBorderColor() As Color
        Get
            Return _HoverBorderColor.Color
        End Get
        Set(ByVal value As Color)
            _HoverBorderColor = New Pen(value)
            Invalidate()
        End Set
    End Property

    Private _HoverLineColor As Pen
    Public Property HoverLineColor() As Color
        Get
            Return _HoverLineColor.Color
        End Get
        Set(ByVal value As Color)
            _HoverLineColor = New Pen(value)
            Invalidate()
        End Set
    End Property

    Private _HoverLabelForeColor As SolidBrush
    Public Property HoverLabelForeColor() As Color
        Get
            Return _HoverLabelForeColor.Color
        End Get
        Set(ByVal value As Color)
            _HoverLabelForeColor = New SolidBrush(value)
            Invalidate()
        End Set
    End Property

    Private _HoverLabelFillColor As SolidBrush
    Public Property HoverLabelFillColor() As Color
        Get
            Return _HoverLabelFillColor.Color
        End Get
        Set(ByVal value As Color)
            _HoverLabelFillColor = New SolidBrush(value)
            Invalidate()
        End Set
    End Property

    Private _HoverLabelBorderColor As Pen
    Public Property HoverLabelBorderColor() As Color
        Get
            Return _HoverLabelBorderColor.Color
        End Get
        Set(ByVal value As Color)
            _HoverLabelBorderColor = New Pen(value)
            Invalidate()
        End Set
    End Property

    Private _HoverLabelShadowColor As Pen
    Public Property HoverLabelShadowColor() As Color
        Get
            Return _HoverLabelShadowColor.Color
        End Get
        Set(ByVal value As Color)
            _HoverLabelShadowColor = New Pen(value, 2)
            Invalidate()
        End Set
    End Property

    Private _LineGraphColor As Pen
    Public Property LineGraphColor() As Color
        Get
            Return _LineGraphColor.Color
        End Get
        Set(ByVal value As Color)
            _LineGraphColor = New Pen(value, 6)
            _LineGraphColor.MiterLimit = 0.0F
            Invalidate()
        End Set
    End Property

    Private _DrawLineGraph As Boolean
    Public Property DrawLineGraph() As Boolean
        Get
            Return _DrawLineGraph
        End Get
        Set(ByVal value As Boolean)
            _DrawLineGraph = value
            Invalidate()
        End Set
    End Property

    Private _SidePadding As Boolean = True
    Public Property SidePadding() As Boolean
        Get
            Return _SidePadding
        End Get
        Set(ByVal value As Boolean)
            _SidePadding = value
            Invalidate()
        End Set
    End Property

    Private _DrawHoverData As Boolean = True
    Public Property DrawHoverData() As Boolean
        Get
            Return _DrawHoverData
        End Get
        Set(ByVal value As Boolean)
            Index = -1
            _DrawHoverData = value
            Invalidate()
        End Set
    End Property

    Private _DrawHoverLine As Boolean = True
    Public Property DrawHoverLine() As Boolean
        Get
            Return _DrawHoverLine
        End Get
        Set(ByVal value As Boolean)
            _DrawHoverLine = value
            Invalidate()
        End Set
    End Property

    Private _DrawDataColumn As Boolean = True
    Public Property DrawDataColumn() As Boolean
        Get
            Return _DrawDataColumn
        End Get
        Set(ByVal value As Boolean)
            _DrawDataColumn = value
            Invalidate()
        End Set
    End Property

    Private _DrawHorizontalLines As Boolean = True
    Public Property DrawHorizontalLines() As Boolean
        Get
            Return _DrawHorizontalLines
        End Get
        Set(ByVal value As Boolean)
            _DrawHorizontalLines = value
            Invalidate()
        End Set
    End Property

    Private _DrawVerticalLines As Boolean
    Public Property DrawVerticalLines() As Boolean
        Get
            Return _DrawVerticalLines
        End Get
        Set(ByVal value As Boolean)
            _DrawVerticalLines = value
            Invalidate()
        End Set
    End Property

    Private _DataSmoothing As Boolean
    Public Property DataSmoothing() As Boolean
        Get
            Return _DataSmoothing
        End Get
        Set(ByVal value As Boolean)
            _DataSmoothing = value

            InvalidateSmoothValues()
            FindMinMax()

            Invalidate()
        End Set
    End Property

    Private _DataSmoothingLevel As Byte = 2
    Public Property DataSmoothingLevel() As Byte
        Get
            Return _DataSmoothingLevel
        End Get
        Set(ByVal value As Byte)
            If value < 1 Then value = 1

            _DataSmoothingLevel = value

            InvalidateSmoothValues()
            FindMinMax()

            Invalidate()
        End Set
    End Property

    Public ReadOnly Property MaximumValue() As Single
        Get
            Return _MaximumValue
        End Get
    End Property

    Public ReadOnly Property MinimumValue() As Single
        Get
            Return _MinimumValue
        End Get
    End Property

    Private _OverrideMin As Boolean = False
    Public Property OverrideMin() As Boolean
        Get
            Return _OverrideMin
        End Get
        Set(ByVal value As Boolean)
            _OverrideMin = value
            If value Then InvalidateMinMax() Else FindMinMax()
            Invalidate()
        End Set
    End Property

    Private _OverrideMinValue As Single = 0.0F
    Public Property OverrideMinValue() As Single
        Get
            Return _OverrideMinValue
        End Get
        Set(ByVal value As Single)
            _OverrideMinValue = value
            InvalidateMinMax()
            Invalidate()
        End Set
    End Property

    Private _OverrideMax As Boolean = False
    Public Property OverrideMax() As Boolean
        Get
            Return _OverrideMax
        End Get
        Set(ByVal value As Boolean)
            _OverrideMax = value
            If value Then InvalidateMinMax() Else FindMinMax()
            Invalidate()
        End Set
    End Property

    Private _OverrideMaxValue As Single = 100.0F
    Public Property OverrideMaxValue() As Single
        Get
            Return _OverrideMaxValue
        End Get
        Set(ByVal value As Single)
            _OverrideMaxValue = value
            InvalidateMinMax()
            Invalidate()
        End Set
    End Property

    Private Sub InvalidateMinMax()
        If _OverrideMin Then _MinimumValue = _OverrideMinValue
        If _OverrideMax Then _MaximumValue = _OverrideMaxValue
    End Sub

    Private SS As Size
    Private SW, SH, SHH As Integer

    Private SG As Graphics

    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(value As Font)
            MyBase.Font = value

            SS = SG.MeasureString("999K", Font).ToSize()
            SW = SS.Width + 5
            SH = SS.Height + 5
            SHH = CInt(Math.Ceiling((SS.Height / 2) / 2) * 2)

            Invalidate()
        End Set
    End Property

#End Region

#Region " Graph Values "

    Private _MaximumValue As Single = Single.MinValue
    Private _MinimumValue As Single = Single.MaxValue
    Private CurrentValue As Single

    Private _Values As List(Of Single)
    Private _SmoothValues As List(Of Single)

    Public Property Values() As Single()
        Get
            Return _Values.ToArray()
        End Get
        Set(ByVal value As Single())
            Clear()

            AddValues(value)

            InvalidateSmoothValues()
            FindMinMax()
        End Set
    End Property

    Public Sub AddValue(ByVal value As Single)
        Index = -1
        _Values.Add(value)

        CleanValues()

        InvalidateSmoothValues()
        FindMinMax()

        Invalidate()
    End Sub

    Public Sub AddValues(ByVal values As Single())
        Index = -1
        _Values.AddRange(values)

        CleanValues()

        InvalidateSmoothValues()
        FindMinMax()

        Invalidate()
    End Sub

    Private Sub InvalidateSmoothValues()
        If Not _DataSmoothing Then Return

        _SmoothValues.Clear()

        Dim Mean As Single
        Dim Min, Max As Integer

        For I As Integer = 0 To _Values.Count - 1
            Mean = 0.0F

            Min = Math.Max(I - _DataSmoothingLevel, 0)
            Max = Math.Min(I + _DataSmoothingLevel, _Values.Count - 1)

            For X As Integer = Min To Max
                Mean += _Values(X)
            Next

            Mean = Mean / ((Max - Min) + 1)
            _SmoothValues.Add(Mean)
        Next
    End Sub

    Private Sub FindMinMax()
        _MaximumValue = Single.MinValue
        _MinimumValue = Single.MaxValue

        For I As Integer = 0 To _Values.Count - 1

            If _DataSmoothing Then
                CurrentValue = _SmoothValues(I)
            Else
                CurrentValue = _Values(I)
            End If

            If (CurrentValue > _MaximumValue) Then _MaximumValue = CurrentValue
            If (CurrentValue < _MinimumValue) Then _MinimumValue = CurrentValue
        Next

        InvalidateMinMax()
    End Sub

    Private Sub CleanValues()
        If _Values.Count > Width Then
            _Values.RemoveRange(0, _Values.Count - Width)
        End If
    End Sub

    Public Sub Clear()
        _Values.Clear()
        _SmoothValues.Clear()

        _MaximumValue = Single.MinValue
        _MinimumValue = Single.MaxValue

        InvalidateMinMax()
    End Sub

#End Region

    Private SB As String
    Private FB1, FB2 As Single

    Private G As Graphics
    Private GP As GraphicsPath

    Private P As Point
    Private PS As PointF()
    Private R1, R2, R3 As Rectangle

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        G = e.Graphics
        G.Clear(BackColor)

        R1 = New Rectangle(SW, 0, Width - SW, Height) 'Height - SH

        If Not _DrawDataColumn Then
            R1.X = 0
            R1.Width = Width
        End If

        R2 = New Rectangle(R1.X + 10, R1.Y + 10, R1.Width - 20, R1.Height - 20)

        If Not _SidePadding Then
            R2.X = R1.X
            R2.Width = R1.Width
        End If

        G.FillRectangle(_FillColor, R1)

        For I As Integer = 0 To 10
            FB1 = R2.Y + CSng((R2.Height - 1) * (I * 0.1))

            If _DrawHorizontalLines Then
                G.DrawLine(_HorizontalLineColor, R1.X, FB1, R1.Right - 1, FB1)
            End If

            If _DrawDataColumn AndAlso (_Values.Count > 1) Then
                If (I Mod 2 = 0) Then
                    G.DrawLine(_BorderColor, R1.X - 4, FB1, R1.X, FB1)

                    CurrentValue = CInt(((_MaximumValue - _MinimumValue) * (1 - (I * 0.1))) + _MinimumValue)
                    SB = SmallValue(CurrentValue)

                    SS = G.MeasureString(SB, Font).ToSize()
                    G.DrawString(SB, Font, _DataColumnForeColor, R1.X - 5 - SS.Width, FB1 - SHH)
                End If
            End If
        Next

        If _Values.Count > 1 Then
            PS = New PointF(_Values.Count + 1) {}
            FB1 = CSng((R2.Width - 1) / (_Values.Count - 1))

            For I As Integer = 0 To _Values.Count - 1
                FB2 = R2.X + (I * FB1)

                If _DataSmoothing Then
                    CurrentValue = (_SmoothValues(I) - _MinimumValue) / Math.Max(_MaximumValue - _MinimumValue, 1)
                Else
                    CurrentValue = (_Values(I) - _MinimumValue) / Math.Max(_MaximumValue - _MinimumValue, 1)
                End If

                If CurrentValue > 1 Then
                    CurrentValue = 1
                ElseIf CurrentValue < 0 Then
                    CurrentValue = 0
                End If

                PS(I) = New PointF(FB2, CInt(R2.Bottom - ((R2.Height - 1) * CurrentValue) - 1))

                If _DrawVerticalLines Then
                    G.DrawLine(_VerticalLineColor, FB2, R1.Y, FB2, R1.Bottom)
                End If
            Next

            PS(PS.Length - 2) = New PointF(R2.Right - 1, R1.Bottom - 1)
            PS(PS.Length - 1) = New PointF(R2.X, R1.Bottom - 1)

            G.SmoothingMode = SmoothingMode.HighQuality

            If _DrawLineGraph Then
                Array.Resize(PS, PS.Length - 2)
                G.DrawLines(_LineGraphColor, PS)
            Else
                GP.AddPolygon(PS)
                GP.CloseFigure()

                G.FillPath(_GraphFillColor, GP)
                G.DrawPath(_GraphBorderColor, GP)
                GP.Reset()
            End If

            If _DrawHoverData AndAlso Not (Index < 0) Then
                G.SetClip(R1)

                P = New Point(CInt(PS(Index).X), CInt(PS(Index).Y))
                R3 = New Rectangle(P.X - 4, P.Y - 4, 8, 8)

                If _DrawHoverLine Then
                    G.DrawLine(_HoverLineColor, P.X, R1.Y, P.X, R1.Bottom - 1)
                End If

                G.FillEllipse(_HoverFillColor, R3)
                G.DrawEllipse(_HoverBorderColor, R3)

                If _DataSmoothing Then
                    SB = _SmoothValues(Index).ToString("N0")
                Else
                    SB = _Values(Index).ToString("N0")
                End If

                SS = G.MeasureString(SB, Font).ToSize()

                P = PointToClient(MousePosition)

                R3 = New Rectangle(P.X + 24, P.Y, SS.Width + 20, SS.Height + 10)
                If (R3.X + R3.Width) > (R1.Right - 1) Then R3.X = P.X - R3.Width - 16
                If (R3.Y + R3.Height) > (R1.Bottom - 1) Then R3.Y = R1.Bottom - R3.Height - 1

                G.DrawRectangle(_HoverLabelShadowColor, R3)
                G.FillRectangle(_HoverLabelFillColor, R3)
                G.DrawRectangle(_HoverLabelBorderColor, R3)

                G.DrawString(SB, Font, _HoverLabelForeColor, New Point(R3.X + 10, R3.Y + 5))
            End If

            G.ResetClip()
            G.SmoothingMode = SmoothingMode.None
        End If

        G.DrawRectangle(_BorderColor, R1.X, R1.Y, R1.Width - 1, R1.Height - 1)
    End Sub

    Private Function SmallValue(value As Single) As String
        Dim R As Integer = CInt(value)

        Select Case R
            Case Is >= 1000000000
                Return (R \ 1000000000) & "B"
            Case Is >= 1000000
                Return (R \ 1000000) & "M"
            Case Is >= 1000
                Return (R \ 1000) & "K"
            Case Else
                Return CStr(R)
        End Select
    End Function

#Region " Hover Handler "

    Private Index As Integer = -1
    Private LastMove As Date

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        If Not _DrawHoverData Then Return

        R1 = New Rectangle(SW, 0, Width - SW, Height - SH)
        R2 = New Rectangle(R1.X + 8, R1.Y + 8, R1.Width - 16, R1.Height - 16)

        FB1 = CSng((R2.Width - 1) / (_Values.Count - 1))

        If R1.Contains(e.Location) Then
            Index = CInt((e.X - R2.X) / FB1)
            If Not Index < _Values.Count Then Index = -1
        Else
            Index = -1
        End If

        If Date.Now > LastMove.AddMilliseconds(33) Then
            LastMove = Date.Now
            Invalidate()
        End If
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        If Not _DrawHoverData Then Return

        Index = -1
        Invalidate()
    End Sub

#End Region

End Class