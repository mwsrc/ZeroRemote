Imports System.Windows.Forms
Imports System.Drawing

Public Class ImageComboBox
    Inherits ComboBox

    Private mImageList As ImageList = Nothing

    Sub New()
        Me.DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
    End Sub

    Public Property ImageList() As ImageList
        Get
            Return mImageList
        End Get
        Set(ByVal value As ImageList)
            mImageList = value
        End Set
    End Property

    Protected Overrides Sub OnDrawItem(ByVal e As System.Windows.Forms.DrawItemEventArgs)
        MyBase.OnDrawItem(e)

        e.DrawBackground()
        e.DrawFocusRectangle()

        If e.Index >= 0 Then

            If TypeOf Me.Items(e.Index) Is ImageComboItem Then
                If mImageList IsNot Nothing Then
                    Dim CurrItem As ImageComboItem = DirectCast(Me.Items(e.Index), ImageComboItem)

                    If CurrItem.ImageIndex <> -1 Then
                        Me.ImageList.Draw(e.Graphics, e.Bounds.Left, e.Bounds.Top, CurrItem.ImageIndex)
                        e.Graphics.DrawString(CurrItem.Text, CurrItem.Font, _
                        New SolidBrush(CType(CurrItem.ForeColor, Color)), _
                        e.Bounds.Left + mImageList.ImageSize.Width, e.Bounds.Top)
                    Else
                        e.Graphics.DrawString(CurrItem.Text, CurrItem.Font, _
                        New SolidBrush(CType(CurrItem.ForeColor, Color)), _
                        e.Bounds.Left + mImageList.ImageSize.Width, e.Bounds.Top)
                    End If
                End If
            Else
                e.Graphics.DrawString(Me.Items(e.Index).ToString(), e.Font, _
                New SolidBrush(e.ForeColor), e.Bounds.Left, e.Bounds.Top)
            End If
        End If
    End Sub
End Class

Public Class ImageComboItem
    Private mForeColor As Color = Color.Black
    Private mImageIndex As Integer = -1
    Private mTag As Object = Nothing
    Private mText As String = ""
    Private mFont As Font

    Sub New(ByVal Text As String, ByVal Font As Font, ByVal ForeColor As Color)
        mText = Text
        mFont = Font
        mForeColor = ForeColor
    End Sub

    Sub New(ByVal Text As String, ByVal Font As Font, _
    ByVal ForeColor As Color, ByVal ImageIndex As Integer)
        mText = Text
        mFont = Font
        mForeColor = ForeColor
        mImageIndex = ImageIndex
    End Sub

    Public Property ForeColor() As Color
        Get
            Return mForeColor
        End Get
        Set(ByVal value As Color)
            mForeColor = CType(value, Color)
        End Set
    End Property

    Public Property ImageIndex() As Integer
        Get
            Return mImageIndex
        End Get
        Set(ByVal value As Integer)
            mImageIndex = value
        End Set
    End Property

    Public Property Tag() As Object
        Get
            Return mTag
        End Get
        Set(ByVal value As Object)
            mTag = value
        End Set
    End Property

    Public Property Text() As String
        Get
            Return mText
        End Get
        Set(ByVal value As String)
            mText = value
        End Set
    End Property

    Public Property Font() As Font
        Get
            Return mFont
        End Get
        Set(ByVal value As Font)
            mFont = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return mText
    End Function
End Class