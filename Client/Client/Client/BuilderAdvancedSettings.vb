Public Class BuilderAdvancedSettings

    
    Private Sub CheckBox2_Click(sender As Object, e As EventArgs) Handles CheckBoxUnkillableProcessExploit.Click
        If Builder.CheckBoxProcessProtection.Checked Or Builder.CheckBoxBreakOnTermination.Checked Then
            CheckBoxUnkillableProcessExploit.Checked = False
            MsgBox("To use this feature you first have to disable ProcessBreakOnTermination and Process Kernel Security.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub ButtonApplyAdvancedSettings_Click(sender As Object, e As EventArgs) Handles ButtonApplyAdvancedSettings.Click
        Me.Hide()
    End Sub

    Private Sub CheckBoxAntiDebug_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAntiDebug.CheckedChanged
        If CheckBoxAntiDebug.Checked Then
            Builder.StubAntiDebug = "True"
        Else
            Builder.StubAntiDebug = "False"
        End If
    End Sub

    Private Sub CheckBoxUnkillableProcessExploit_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxUnkillableProcessExploit.CheckedChanged
        If CheckBoxUnkillableProcessExploit.Checked = True Then
            Builder.StubUnkillableProcessExploit = "True"
        Else
            Builder.StubUnkillableProcessExploit = "False"
        End If
    End Sub

    Private Sub CheckBoxAntiDllInjection_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAntiDllInjection.CheckedChanged
        If CheckBoxAntiDllInjection.Checked Then
            Builder.StubAntiDllInject = "True"
        Else
            Builder.StubAntiDllInject = "False"
        End If
    End Sub

    Private Sub CheckBoxUnkillableProcessExploit_MouseEnter(sender As Object, e As EventArgs) Handles CheckBoxUnkillableProcessExploit.MouseEnter
        Label2.Visible = True
    End Sub

    Private Sub CheckBoxUnkillableProcessExploit_MouseLeave(sender As Object, e As EventArgs) Handles CheckBoxUnkillableProcessExploit.MouseLeave
        Label2.Visible = False
    End Sub

    Private Sub BuilderAdvancedSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub
End Class