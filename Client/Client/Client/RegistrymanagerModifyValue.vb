Public Class RegistrymanagerModifyValue

    Private Sub ButtonModify_Click(sender As Object, e As EventArgs) Handles ButtonModify.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Modifying registryvalue...")
            Try
            Main.WriteData(Registrymanager.LabelCurrentPath.Text & "|||" & TextBoxRegistryvaluename.Text & "|||" & TextBoxRegistryvaluedata.Text)
            Main.WriteCommand(Main.SelectedUserID & "|39")
                Using dialog As New Waiting()
                    dialog.ShowDialog()
                End Using
                Me.Close()
            Catch x As Exception
                MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Create Registryvalue")
            End Try
    End Sub
End Class