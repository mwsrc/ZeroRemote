Public Class ProcessmanagerModules
    Public Sub ListModules(ByVal DataString As String)
        ListBoxModules.Items.Clear()
        Try
            ListBoxModules.Items.AddRange(DataString.Split(CChar("|||")))
            For i As Integer = ListBoxModules.Items.Count - 1 To 0 Step -1
                If ListBoxModules.GetItemText(ListBoxModules.Items(i)) = String.Empty Then
                    ListBoxModules.Items.RemoveAt(i)
                End If
            Next i
            LabelModuleCount.Text = "Loaded " & ListBoxModules.Items.Count.ToString & " modules."
            Me.ShowDialog()
        Catch
            MsgBox("Bad String formatting", MsgBoxStyle.Critical, "Failed")
        End Try
    End Sub

End Class