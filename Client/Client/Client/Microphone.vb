Imports System.Threading

Public Class Microphone

    Private RecordDuration As Integer = 1000
    Private WaitTime As Integer = 0


    ' Remote microphone was never a finished feature, I planed on implementing it in a new update but didnt find the time.
    ' This feature is not yet correctly working!


    Private Sub ButtonRecord_Click(sender As Object, e As EventArgs) Handles ButtonRecord.Click
        ' Recording time
        RecordDuration = CInt(NumericUpDownRecordTime.Value)
        WaitTime = RecordDuration * 1000

        'Show time to wait in label
        ProgressBar1.Maximum = RecordDuration
        Dim WaitThread As New Thread(AddressOf ProgressBar)
        Try
            Main.WriteData(CStr(RecordDuration))
            Main.WriteCommand(Main.SelectedUserID & "|69")
        Catch x As Exception
            MsgBox("Unable to send Command. Please retry" & x.Message, MsgBoxStyle.OkOnly, "Microphone")
        End Try
        Dim WaitThread2 As New Thread(AddressOf ChangeLabelStatus)
        WaitThread2.Start(RecordDuration)
        ButtonRecord.Enabled = False
        WaitThread.Start(RecordDuration)
        While WaitThread.IsAlive
            Application.DoEvents()
        End While
        MsgBox("Workx")

    End Sub

    Delegate Sub ProgressBar1ValuePlusOne(ByVal value As Integer)
    Delegate Sub LabelUpdate(ByVal value As Integer)

    Private Sub ProgressBar1ValuePlus1(ByVal value As Integer)
        ProgressBar1.Value = value
    End Sub

    Private Sub UpdateLabelStatus(ByVal value As Integer)
        LabelStatus.Text = String.Format("Waiting : {0}s", value)
    End Sub
    Private Sub ProgressBar(ByVal progressTime As Object)
       
        For Value1 As Integer = 0 To CInt(progressTime)
            Dim progressPlusOne As New ProgressBar1ValuePlusOne(AddressOf ProgressBar1ValuePlus1)
            Me.Invoke(progressPlusOne, Value1)

            Threading.Thread.Sleep(1000)
        Next

    End Sub

    Private Sub ChangeLabelStatus(ByVal labelstats As Object)
        Dim val1 As Integer = CInt(labelstats)
        Dim progressPlusOne As New LabelUpdate(AddressOf UpdateLabelStatus)

        While val1 >= 0
            Me.Invoke(progressPlusOne, val1)
            val1 -= 1
            Threading.Thread.Sleep(1000)
        End While
    End Sub

    Private Sub LabelStateChange()

    End Sub

End Class