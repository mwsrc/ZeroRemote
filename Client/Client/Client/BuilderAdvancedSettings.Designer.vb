<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuilderAdvancedSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuilderAdvancedSettings))
        Me.CheckBoxAntiDllInjection = New System.Windows.Forms.CheckBox()
        Me.CheckBoxUnkillableProcessExploit = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAntiDebug = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonApplyAdvancedSettings = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CheckBoxAntiDllInjection
        '
        Me.CheckBoxAntiDllInjection.AutoSize = True
        Me.CheckBoxAntiDllInjection.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxAntiDllInjection.Location = New System.Drawing.Point(25, 53)
        Me.CheckBoxAntiDllInjection.Name = "CheckBoxAntiDllInjection"
        Me.CheckBoxAntiDllInjection.Size = New System.Drawing.Size(315, 17)
        Me.CheckBoxAntiDllInjection.TabIndex = 0
        Me.CheckBoxAntiDllInjection.Text = "Anti-Dll Injection (Prevent i.e. ring3 packet hooks)"
        Me.CheckBoxAntiDllInjection.UseVisualStyleBackColor = True
        '
        'CheckBoxUnkillableProcessExploit
        '
        Me.CheckBoxUnkillableProcessExploit.AutoSize = True
        Me.CheckBoxUnkillableProcessExploit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxUnkillableProcessExploit.Location = New System.Drawing.Point(25, 76)
        Me.CheckBoxUnkillableProcessExploit.Name = "CheckBoxUnkillableProcessExploit"
        Me.CheckBoxUnkillableProcessExploit.Size = New System.Drawing.Size(366, 17)
        Me.CheckBoxUnkillableProcessExploit.TabIndex = 1
        Me.CheckBoxUnkillableProcessExploit.Text = "Unkillable Process (Exploit using ZwSetInformationProcess)"
        Me.CheckBoxUnkillableProcessExploit.UseVisualStyleBackColor = True
        '
        'CheckBoxAntiDebug
        '
        Me.CheckBoxAntiDebug.AutoSize = True
        Me.CheckBoxAntiDebug.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxAntiDebug.Location = New System.Drawing.Point(25, 99)
        Me.CheckBoxAntiDebug.Name = "CheckBoxAntiDebug"
        Me.CheckBoxAntiDebug.Size = New System.Drawing.Size(299, 17)
        Me.CheckBoxAntiDebug.TabIndex = 2
        Me.CheckBoxAntiDebug.Text = "Anti-Debug (Prevents Server beeing debugged)"
        Me.CheckBoxAntiDebug.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(57, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Please use these settings with caution. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "They could make the server becoming uns" & _
    "table."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonApplyAdvancedSettings
        '
        Me.ButtonApplyAdvancedSettings.Image = CType(resources.GetObject("ButtonApplyAdvancedSettings.Image"), System.Drawing.Image)
        Me.ButtonApplyAdvancedSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonApplyAdvancedSettings.Location = New System.Drawing.Point(154, 161)
        Me.ButtonApplyAdvancedSettings.Name = "ButtonApplyAdvancedSettings"
        Me.ButtonApplyAdvancedSettings.Size = New System.Drawing.Size(99, 23)
        Me.ButtonApplyAdvancedSettings.TabIndex = 3
        Me.ButtonApplyAdvancedSettings.Text = "Apply"
        Me.ButtonApplyAdvancedSettings.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(60, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(283, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Unstable on x86 systems. Experimental feature!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Server could become unstable. Ple" & _
    "ase use with caution."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.Visible = False
        '
        'BuilderAdvancedSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 194)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonApplyAdvancedSettings)
        Me.Controls.Add(Me.CheckBoxAntiDebug)
        Me.Controls.Add(Me.CheckBoxUnkillableProcessExploit)
        Me.Controls.Add(Me.CheckBoxAntiDllInjection)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BuilderAdvancedSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Advanced Builder Settings"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBoxAntiDllInjection As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxUnkillableProcessExploit As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxAntiDebug As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonApplyAdvancedSettings As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
