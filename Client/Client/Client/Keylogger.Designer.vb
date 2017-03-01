<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Keylogger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Keylogger))
        Me.RichTextBoxKeylogs = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBoxWarning = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxWarning, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBoxKeylogs
        '
        Me.RichTextBoxKeylogs.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RichTextBoxKeylogs.Location = New System.Drawing.Point(12, 60)
        Me.RichTextBoxKeylogs.Name = "RichTextBoxKeylogs"
        Me.RichTextBoxKeylogs.ReadOnly = True
        Me.RichTextBoxKeylogs.Size = New System.Drawing.Size(435, 244)
        Me.RichTextBoxKeylogs.TabIndex = 0
        Me.RichTextBoxKeylogs.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "For security reasons ZeroRemote will not store any keylogs on the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "controlled co" & _
    "mputer. You can only download the latest logs."
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(306, 310)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 24)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Search Keylogs"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(159, 310)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 24)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Save Keylogs"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(12, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Download Keylogs"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBoxWarning
        '
        Me.PictureBoxWarning.Image = CType(resources.GetObject("PictureBoxWarning.Image"), System.Drawing.Image)
        Me.PictureBoxWarning.Location = New System.Drawing.Point(12, 12)
        Me.PictureBoxWarning.Name = "PictureBoxWarning"
        Me.PictureBoxWarning.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxWarning.TabIndex = 2
        Me.PictureBoxWarning.TabStop = False
        '
        'Keylogger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 347)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBoxWarning)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBoxKeylogs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Keylogger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Keylogger"
        Me.TopMost = True
        CType(Me.PictureBoxWarning, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBoxKeylogs As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBoxWarning As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
