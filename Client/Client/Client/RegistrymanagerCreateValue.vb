Public Class RegistrymanagerCreateValue

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Creating registryvalue...")
        If String.IsNullOrWhiteSpace(TextBoxRegistryName.Text) Then
            Settings.AddLog("Warning", Settings.State.Warning, "No registryvaluename entered!")
            MsgBox("Enter a registryname", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Try
                Main.WriteData(Registrymanager.LabelCurrentPath.Text & "|||" & TextBoxRegistryName.Text & "|||" & TextBoxRegistryData.Text)
                Main.WriteCommand(Main.SelectedUserID & "|37")
                Using dialog As New Waiting()
                    dialog.ShowDialog()
                End Using
                Me.Close()
            Catch x As Exception
                MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Create Registryvalue")
            End Try
        End If
    End Sub

End Class