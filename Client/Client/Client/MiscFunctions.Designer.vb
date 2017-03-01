<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MiscFunctions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MiscFunctions))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.ButtonRestoreMouse = New System.Windows.Forms.Button()
        Me.ButtonSwapMouse = New System.Windows.Forms.Button()
        Me.ButtonUnblockKeyboard = New System.Windows.Forms.Button()
        Me.ButtonBlockKeyboard = New System.Windows.Forms.Button()
        Me.ButtonScreensaver = New System.Windows.Forms.Button()
        Me.ButtonLogoff = New System.Windows.Forms.Button()
        Me.ButtonReboot = New System.Windows.Forms.Button()
        Me.ButtonShutdown = New System.Windows.Forms.Button()
        Me.ButtonShowDesktopIcons = New System.Windows.Forms.Button()
        Me.ButtonHideDesktopIcons = New System.Windows.Forms.Button()
        Me.ButtonUnlockTaskBar = New System.Windows.Forms.Button()
        Me.ButtonLockTaskBar = New System.Windows.Forms.Button()
        Me.ButtonShowClock = New System.Windows.Forms.Button()
        Me.ButtonHideClock = New System.Windows.Forms.Button()
        Me.ButtonShowTaskBar = New System.Windows.Forms.Button()
        Me.ButtonHideTaskBar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonShowDesktopIcons)
        Me.GroupBox1.Controls.Add(Me.ButtonHideDesktopIcons)
        Me.GroupBox1.Controls.Add(Me.ButtonUnlockTaskBar)
        Me.GroupBox1.Controls.Add(Me.ButtonLockTaskBar)
        Me.GroupBox1.Controls.Add(Me.ButtonShowClock)
        Me.GroupBox1.Controls.Add(Me.ButtonHideClock)
        Me.GroupBox1.Controls.Add(Me.ButtonShowTaskBar)
        Me.GroupBox1.Controls.Add(Me.ButtonHideTaskBar)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 158)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Desktop Interface / User Interface"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonScreensaver)
        Me.GroupBox2.Controls.Add(Me.ButtonLogoff)
        Me.GroupBox2.Controls.Add(Me.ButtonReboot)
        Me.GroupBox2.Controls.Add(Me.ButtonShutdown)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(12, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(373, 94)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Power Options"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonRestoreMouse)
        Me.GroupBox3.Controls.Add(Me.ButtonSwapMouse)
        Me.GroupBox3.Controls.Add(Me.ButtonUnblockKeyboard)
        Me.GroupBox3.Controls.Add(Me.ButtonBlockKeyboard)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox3.Location = New System.Drawing.Point(391, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(227, 158)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mouse Keyboard"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button9)
        Me.GroupBox4.Controls.Add(Me.Button10)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox4.Location = New System.Drawing.Point(391, 178)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(227, 94)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Disk Tray"
        '
        'Button9
        '
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(17, 54)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(190, 23)
        Me.Button9.TabIndex = 5
        Me.Button9.Text = "Close Disk Tray"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.ForeColor = System.Drawing.Color.Black
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.Location = New System.Drawing.Point(17, 23)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(190, 23)
        Me.Button10.TabIndex = 4
        Me.Button10.Text = "Open Disk Tray"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'ButtonRestoreMouse
        '
        Me.ButtonRestoreMouse.ForeColor = System.Drawing.Color.Black
        Me.ButtonRestoreMouse.Image = CType(resources.GetObject("ButtonRestoreMouse.Image"), System.Drawing.Image)
        Me.ButtonRestoreMouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRestoreMouse.Location = New System.Drawing.Point(17, 117)
        Me.ButtonRestoreMouse.Name = "ButtonRestoreMouse"
        Me.ButtonRestoreMouse.Size = New System.Drawing.Size(190, 23)
        Me.ButtonRestoreMouse.TabIndex = 3
        Me.ButtonRestoreMouse.Text = "Restore Mouse Buttons"
        Me.ButtonRestoreMouse.UseVisualStyleBackColor = True
        '
        'ButtonSwapMouse
        '
        Me.ButtonSwapMouse.ForeColor = System.Drawing.Color.Black
        Me.ButtonSwapMouse.Image = CType(resources.GetObject("ButtonSwapMouse.Image"), System.Drawing.Image)
        Me.ButtonSwapMouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSwapMouse.Location = New System.Drawing.Point(17, 86)
        Me.ButtonSwapMouse.Name = "ButtonSwapMouse"
        Me.ButtonSwapMouse.Size = New System.Drawing.Size(190, 23)
        Me.ButtonSwapMouse.TabIndex = 2
        Me.ButtonSwapMouse.Text = "Swap Mouse Buttons"
        Me.ButtonSwapMouse.UseVisualStyleBackColor = True
        '
        'ButtonUnblockKeyboard
        '
        Me.ButtonUnblockKeyboard.ForeColor = System.Drawing.Color.Black
        Me.ButtonUnblockKeyboard.Image = CType(resources.GetObject("ButtonUnblockKeyboard.Image"), System.Drawing.Image)
        Me.ButtonUnblockKeyboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonUnblockKeyboard.Location = New System.Drawing.Point(17, 57)
        Me.ButtonUnblockKeyboard.Name = "ButtonUnblockKeyboard"
        Me.ButtonUnblockKeyboard.Size = New System.Drawing.Size(190, 23)
        Me.ButtonUnblockKeyboard.TabIndex = 1
        Me.ButtonUnblockKeyboard.Text = "Unblock Mouse/Keyboard"
        Me.ButtonUnblockKeyboard.UseVisualStyleBackColor = True
        '
        'ButtonBlockKeyboard
        '
        Me.ButtonBlockKeyboard.ForeColor = System.Drawing.Color.Black
        Me.ButtonBlockKeyboard.Image = CType(resources.GetObject("ButtonBlockKeyboard.Image"), System.Drawing.Image)
        Me.ButtonBlockKeyboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBlockKeyboard.Location = New System.Drawing.Point(17, 28)
        Me.ButtonBlockKeyboard.Name = "ButtonBlockKeyboard"
        Me.ButtonBlockKeyboard.Size = New System.Drawing.Size(190, 23)
        Me.ButtonBlockKeyboard.TabIndex = 0
        Me.ButtonBlockKeyboard.Text = "Block Mouse/Keyboard"
        Me.ButtonBlockKeyboard.UseVisualStyleBackColor = True
        '
        'ButtonScreensaver
        '
        Me.ButtonScreensaver.ForeColor = System.Drawing.Color.Black
        Me.ButtonScreensaver.Image = CType(resources.GetObject("ButtonScreensaver.Image"), System.Drawing.Image)
        Me.ButtonScreensaver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonScreensaver.Location = New System.Drawing.Point(199, 58)
        Me.ButtonScreensaver.Name = "ButtonScreensaver"
        Me.ButtonScreensaver.Size = New System.Drawing.Size(160, 23)
        Me.ButtonScreensaver.TabIndex = 3
        Me.ButtonScreensaver.Text = "Start Screensaver"
        Me.ButtonScreensaver.UseVisualStyleBackColor = True
        '
        'ButtonLogoff
        '
        Me.ButtonLogoff.ForeColor = System.Drawing.Color.Black
        Me.ButtonLogoff.Image = CType(resources.GetObject("ButtonLogoff.Image"), System.Drawing.Image)
        Me.ButtonLogoff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonLogoff.Location = New System.Drawing.Point(199, 29)
        Me.ButtonLogoff.Name = "ButtonLogoff"
        Me.ButtonLogoff.Size = New System.Drawing.Size(160, 23)
        Me.ButtonLogoff.TabIndex = 2
        Me.ButtonLogoff.Text = "Logoff Computer"
        Me.ButtonLogoff.UseVisualStyleBackColor = True
        '
        'ButtonReboot
        '
        Me.ButtonReboot.ForeColor = System.Drawing.Color.Black
        Me.ButtonReboot.Image = CType(resources.GetObject("ButtonReboot.Image"), System.Drawing.Image)
        Me.ButtonReboot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonReboot.Location = New System.Drawing.Point(17, 58)
        Me.ButtonReboot.Name = "ButtonReboot"
        Me.ButtonReboot.Size = New System.Drawing.Size(160, 23)
        Me.ButtonReboot.TabIndex = 1
        Me.ButtonReboot.Text = "Reboot Computer"
        Me.ButtonReboot.UseVisualStyleBackColor = True
        '
        'ButtonShutdown
        '
        Me.ButtonShutdown.ForeColor = System.Drawing.Color.Black
        Me.ButtonShutdown.Image = CType(resources.GetObject("ButtonShutdown.Image"), System.Drawing.Image)
        Me.ButtonShutdown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonShutdown.Location = New System.Drawing.Point(17, 29)
        Me.ButtonShutdown.Name = "ButtonShutdown"
        Me.ButtonShutdown.Size = New System.Drawing.Size(160, 23)
        Me.ButtonShutdown.TabIndex = 0
        Me.ButtonShutdown.Text = "Shutdown Computer"
        Me.ButtonShutdown.UseVisualStyleBackColor = True
        '
        'ButtonShowDesktopIcons
        '
        Me.ButtonShowDesktopIcons.ForeColor = System.Drawing.Color.Black
        Me.ButtonShowDesktopIcons.Image = CType(resources.GetObject("ButtonShowDesktopIcons.Image"), System.Drawing.Image)
        Me.ButtonShowDesktopIcons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonShowDesktopIcons.Location = New System.Drawing.Point(185, 117)
        Me.ButtonShowDesktopIcons.Name = "ButtonShowDesktopIcons"
        Me.ButtonShowDesktopIcons.Size = New System.Drawing.Size(174, 23)
        Me.ButtonShowDesktopIcons.TabIndex = 7
        Me.ButtonShowDesktopIcons.Text = "Show Desktop Icons"
        Me.ButtonShowDesktopIcons.UseVisualStyleBackColor = True
        '
        'ButtonHideDesktopIcons
        '
        Me.ButtonHideDesktopIcons.ForeColor = System.Drawing.Color.Black
        Me.ButtonHideDesktopIcons.Image = CType(resources.GetObject("ButtonHideDesktopIcons.Image"), System.Drawing.Image)
        Me.ButtonHideDesktopIcons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonHideDesktopIcons.Location = New System.Drawing.Point(185, 86)
        Me.ButtonHideDesktopIcons.Name = "ButtonHideDesktopIcons"
        Me.ButtonHideDesktopIcons.Size = New System.Drawing.Size(174, 23)
        Me.ButtonHideDesktopIcons.TabIndex = 6
        Me.ButtonHideDesktopIcons.Text = "Hide Desktop Icons"
        Me.ButtonHideDesktopIcons.UseVisualStyleBackColor = True
        '
        'ButtonUnlockTaskBar
        '
        Me.ButtonUnlockTaskBar.ForeColor = System.Drawing.Color.Black
        Me.ButtonUnlockTaskBar.Image = CType(resources.GetObject("ButtonUnlockTaskBar.Image"), System.Drawing.Image)
        Me.ButtonUnlockTaskBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonUnlockTaskBar.Location = New System.Drawing.Point(185, 57)
        Me.ButtonUnlockTaskBar.Name = "ButtonUnlockTaskBar"
        Me.ButtonUnlockTaskBar.Size = New System.Drawing.Size(174, 23)
        Me.ButtonUnlockTaskBar.TabIndex = 5
        Me.ButtonUnlockTaskBar.Text = "Unlock Taskbar"
        Me.ButtonUnlockTaskBar.UseVisualStyleBackColor = True
        '
        'ButtonLockTaskBar
        '
        Me.ButtonLockTaskBar.ForeColor = System.Drawing.Color.Black
        Me.ButtonLockTaskBar.Image = CType(resources.GetObject("ButtonLockTaskBar.Image"), System.Drawing.Image)
        Me.ButtonLockTaskBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonLockTaskBar.Location = New System.Drawing.Point(185, 28)
        Me.ButtonLockTaskBar.Name = "ButtonLockTaskBar"
        Me.ButtonLockTaskBar.Size = New System.Drawing.Size(174, 23)
        Me.ButtonLockTaskBar.TabIndex = 4
        Me.ButtonLockTaskBar.Text = "Lock Taskbar"
        Me.ButtonLockTaskBar.UseVisualStyleBackColor = True
        '
        'ButtonShowClock
        '
        Me.ButtonShowClock.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ButtonShowClock.Image = CType(resources.GetObject("ButtonShowClock.Image"), System.Drawing.Image)
        Me.ButtonShowClock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonShowClock.Location = New System.Drawing.Point(17, 117)
        Me.ButtonShowClock.Name = "ButtonShowClock"
        Me.ButtonShowClock.Size = New System.Drawing.Size(150, 23)
        Me.ButtonShowClock.TabIndex = 3
        Me.ButtonShowClock.Text = "Show Clock"
        Me.ButtonShowClock.UseVisualStyleBackColor = True
        '
        'ButtonHideClock
        '
        Me.ButtonHideClock.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ButtonHideClock.Image = CType(resources.GetObject("ButtonHideClock.Image"), System.Drawing.Image)
        Me.ButtonHideClock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonHideClock.Location = New System.Drawing.Point(17, 86)
        Me.ButtonHideClock.Name = "ButtonHideClock"
        Me.ButtonHideClock.Size = New System.Drawing.Size(150, 23)
        Me.ButtonHideClock.TabIndex = 2
        Me.ButtonHideClock.Text = "Hide Clock"
        Me.ButtonHideClock.UseVisualStyleBackColor = True
        '
        'ButtonShowTaskBar
        '
        Me.ButtonShowTaskBar.ForeColor = System.Drawing.Color.Black
        Me.ButtonShowTaskBar.Image = CType(resources.GetObject("ButtonShowTaskBar.Image"), System.Drawing.Image)
        Me.ButtonShowTaskBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonShowTaskBar.Location = New System.Drawing.Point(17, 57)
        Me.ButtonShowTaskBar.Name = "ButtonShowTaskBar"
        Me.ButtonShowTaskBar.Size = New System.Drawing.Size(150, 23)
        Me.ButtonShowTaskBar.TabIndex = 1
        Me.ButtonShowTaskBar.Text = "Show Taskbar"
        Me.ButtonShowTaskBar.UseVisualStyleBackColor = True
        '
        'ButtonHideTaskBar
        '
        Me.ButtonHideTaskBar.ForeColor = System.Drawing.Color.Black
        Me.ButtonHideTaskBar.Image = CType(resources.GetObject("ButtonHideTaskBar.Image"), System.Drawing.Image)
        Me.ButtonHideTaskBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonHideTaskBar.Location = New System.Drawing.Point(17, 28)
        Me.ButtonHideTaskBar.Name = "ButtonHideTaskBar"
        Me.ButtonHideTaskBar.Size = New System.Drawing.Size(151, 23)
        Me.ButtonHideTaskBar.TabIndex = 0
        Me.ButtonHideTaskBar.Text = "Hide Taskbar"
        Me.ButtonHideTaskBar.UseVisualStyleBackColor = True
        '
        'MiscFunctions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 284)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MiscFunctions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Miscellanous Functions"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonShowTaskBar As System.Windows.Forms.Button
    Friend WithEvents ButtonHideTaskBar As System.Windows.Forms.Button
    Friend WithEvents ButtonShowClock As System.Windows.Forms.Button
    Friend WithEvents ButtonHideClock As System.Windows.Forms.Button
    Friend WithEvents ButtonShowDesktopIcons As System.Windows.Forms.Button
    Friend WithEvents ButtonHideDesktopIcons As System.Windows.Forms.Button
    Friend WithEvents ButtonUnlockTaskBar As System.Windows.Forms.Button
    Friend WithEvents ButtonLockTaskBar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonReboot As System.Windows.Forms.Button
    Friend WithEvents ButtonShutdown As System.Windows.Forms.Button
    Friend WithEvents ButtonLogoff As System.Windows.Forms.Button
    Friend WithEvents ButtonScreensaver As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonRestoreMouse As System.Windows.Forms.Button
    Friend WithEvents ButtonSwapMouse As System.Windows.Forms.Button
    Friend WithEvents ButtonUnblockKeyboard As System.Windows.Forms.Button
    Friend WithEvents ButtonBlockKeyboard As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
End Class
