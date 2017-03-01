Imports System.Threading
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.IO

Public Class Settings

    Dim AutoRefreshThread As Thread = Nothing
    Public NewHostItem As ToolStripMenuItem


#Region "Connection Settings"

    Private Sub CheckBoxautorefresh_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxautorefresh.CheckedChanged
        If CheckBoxautorefresh.Checked Then
            AutoRefreshThread = New Threading.Thread(AddressOf Main.AutoRefresh)
            AutoRefreshThread.SetApartmentState(Threading.ApartmentState.STA)
            AutoRefreshThread.Start()
        Else
            AutoRefreshThread.Abort()
        End If
    End Sub

#End Region

#Region "Logs"

    Public Enum State
        Success = 0
        Failed = 1
        Pending = 2
        Warning = 3
    End Enum

    Public Shared Sub AddLog(ByVal Statetext As String, ByVal State As State, ByVal Description As String)
        With Settings.ListViewLogs.Items.Add(Statetext, State)
            .SubItems.Add(Format(TimeOfDay, "HH:mm:ss"))
            .SubItems.Add(Description)
        End With
    End Sub

#End Region

    Public Function IntToSingle(ByVal Number As Integer) As Single
        Return CType(Number, Single)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        GraphConnections.AddValue(8.0F)
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TopMost = False
        Dim HostName As String = String.Empty
        If HostName.EndsWith("/Zero/", StringComparison.InvariantCultureIgnoreCase) Then
            HostName.Replace("/Zero/", "/Zero")
        End If
        HostName = InputBox("Please input the url of your webhost.", "Add webhost", "http://127.0.0.1/Zero")
        If Not (HostName.EndsWith("/Zero", StringComparison.InvariantCultureIgnoreCase)) Or Not (HostName.StartsWith("http://", StringComparison.InvariantCultureIgnoreCase)) Then
            MessageBox.Show("The URL seems to be invalid. Make sure you enter a correct url." & vbNewLine & "Correct format : http://www.myserver.com/Zero", "Invalid Host URL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If Not String.IsNullOrEmpty(HostName) Then
            For Each item As ListViewItem In ListViewHosts.Items
                If item.Text.ToLower = HostName.ToLower Then
                    MessageBox.Show("This item is already in your List.", "Host already added", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Next
            ' Add Listview Items
            ListViewHosts.Items.Add(HostName, 1)
            ' Add new ToolStripItem
            NewHostItem = New ToolStripMenuItem(HostName, ImageListWerbservers.Images(0))
            NewHostItem.Text = HostName
            AddHandler NewHostItem.Click, AddressOf AddHost
            Main.ConnectToToolStripMenuItem.DropDownItems.Add(NewHostItem)
            MessageBox.Show("Host has been added to the list.", "New host added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TopMost = True
        End If
    End Sub

    Public Sub AddHost(a As Object, B As EventArgs)
        Main.HostAdress = Me.NewHostItem.Text
        Waiting.HostAddress = Main.HostAdress
        Main.Connect()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListViewHosts.Items.Count = 0 Then
            Main.ListViewMain.Items.Clear()
            Main.ToolStripUsersOnline.Text = "  Connections: " & Main.ListViewMain.Items.Count
            Main.Status = False
            Main.SetStatus(CType(1, Main.MyStatus))
            Me.TopMost = False
            MsgBox("No webhosts in the list.", MsgBoxStyle.Exclamation, "No Hosts")
            Me.TopMost = True
            Exit Sub
        Else
            If ListViewHosts.SelectedItems.Count = 0 Then
                Me.TopMost = False
                MsgBox("No webhosts selected to remove.", MsgBoxStyle.Exclamation, "No Hosts")
                Me.TopMost = True
                Exit Sub
            Else
                Dim counter As Integer = 0
                For i As Integer = ListViewHosts.SelectedItems.Count - 1 To 0 Step -1
                    For j As Integer = Main.ConnectToToolStripMenuItem.DropDownItems.Count - 1 To 0 Step -1
                        If Main.ConnectToToolStripMenuItem.DropDownItems(j).Text = ListViewHosts.SelectedItems(i).Text Then
                            Main.ConnectToToolStripMenuItem.DropDownItems.RemoveAt(j)
                        End If
                    Next
                    ListViewHosts.Items.RemoveAt(i)
                Next

                MessageBox.Show("Removed webhosts(s) from the list", "Webhost removed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        Exit Sub
    End Sub

    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim Hosts As New StringBuilder

        For Each item As ListViewItem In ListViewHosts.Items
            If Not String.IsNullOrEmpty(item.Text) Then
                Hosts.Append(item.Text & "|||")
            End If
        Next
        Try
            If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\ZeroHosts.txt") Then
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\ZeroHosts.txt")
            End If
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\ZeroHosts.txt", ApplicationSettings.Rijndaelcrypt(Hosts.ToString))
        Catch
            Me.TopMost = False
            MsgBox("Error saving settings.", MsgBoxStyle.Critical)
            Me.TopMost = True
        End Try

    End Sub

    Private Sub CheckBoxCommandConfirmationMessageBox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCommandConfirmationMessageBox.CheckedChanged
        If CheckBoxCommandConfirmationMessageBox.CheckState = CheckState.Checked Then
            Waiting.ShowConfirmationMessageBox = True
        Else
            Waiting.ShowConfirmationMessageBox = False
        End If
    End Sub
End Class