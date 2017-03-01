<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Screenviewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Screenviewer))
        Me.PictureBoxScreenviewer = New System.Windows.Forms.PictureBox()
        Me.ButtonTakeScreenshot = New System.Windows.Forms.Button()
        Me.ComboBoxQuality = New System.Windows.Forms.ComboBox()
        Me.ButtonSaveScreenshot = New System.Windows.Forms.Button()
        Me.SaveFileDialogSaveScreenshot = New System.Windows.Forms.SaveFileDialog()
        Me.CheckBoxStamp = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxScreenviewer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxScreenviewer
        '
        Me.PictureBoxScreenviewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxScreenviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxScreenviewer.Location = New System.Drawing.Point(12, 51)
        Me.PictureBoxScreenviewer.Name = "PictureBoxScreenviewer"
        Me.PictureBoxScreenviewer.Size = New System.Drawing.Size(508, 290)
        Me.PictureBoxScreenviewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxScreenviewer.TabIndex = 0
        Me.PictureBoxScreenviewer.TabStop = False
        '
        'ButtonTakeScreenshot
        '
        Me.ButtonTakeScreenshot.Image = CType(resources.GetObject("ButtonTakeScreenshot.Image"), System.Drawing.Image)
        Me.ButtonTakeScreenshot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTakeScreenshot.Location = New System.Drawing.Point(12, 19)
        Me.ButtonTakeScreenshot.Name = "ButtonTakeScreenshot"
        Me.ButtonTakeScreenshot.Size = New System.Drawing.Size(140, 23)
        Me.ButtonTakeScreenshot.TabIndex = 1
        Me.ButtonTakeScreenshot.Text = "Take Screenshot"
        Me.ButtonTakeScreenshot.UseVisualStyleBackColor = True
        '
        'ComboBoxQuality
        '
        Me.ComboBoxQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxQuality.FormattingEnabled = True
        Me.ComboBoxQuality.Items.AddRange(New Object() {"Very Low", "Low", "Normal", "Good", "Very Good"})
        Me.ComboBoxQuality.Location = New System.Drawing.Point(161, 20)
        Me.ComboBoxQuality.Name = "ComboBoxQuality"
        Me.ComboBoxQuality.Size = New System.Drawing.Size(95, 21)
        Me.ComboBoxQuality.TabIndex = 2
        '
        'ButtonSaveScreenshot
        '
        Me.ButtonSaveScreenshot.Image = CType(resources.GetObject("ButtonSaveScreenshot.Image"), System.Drawing.Image)
        Me.ButtonSaveScreenshot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSaveScreenshot.Location = New System.Drawing.Point(262, 19)
        Me.ButtonSaveScreenshot.Name = "ButtonSaveScreenshot"
        Me.ButtonSaveScreenshot.Size = New System.Drawing.Size(113, 23)
        Me.ButtonSaveScreenshot.TabIndex = 3
        Me.ButtonSaveScreenshot.Text = "Save Image"
        Me.ButtonSaveScreenshot.UseVisualStyleBackColor = True
        '
        'SaveFileDialogSaveScreenshot
        '
        Me.SaveFileDialogSaveScreenshot.DefaultExt = "*.jpg"
        Me.SaveFileDialogSaveScreenshot.FileName = "Screenshot"
        Me.SaveFileDialogSaveScreenshot.Filter = "Jpeg Image|*.jpg"
        Me.SaveFileDialogSaveScreenshot.Title = "Save Screenshot"
        '
        'CheckBoxStamp
        '
        Me.CheckBoxStamp.AutoSize = True
        Me.CheckBoxStamp.Location = New System.Drawing.Point(403, 23)
        Me.CheckBoxStamp.Name = "CheckBoxStamp"
        Me.CheckBoxStamp.Size = New System.Drawing.Size(102, 17)
        Me.CheckBoxStamp.TabIndex = 4
        Me.CheckBoxStamp.Text = "        Add Stamp"
        Me.CheckBoxStamp.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(424, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Screenviewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 353)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckBoxStamp)
        Me.Controls.Add(Me.ButtonSaveScreenshot)
        Me.Controls.Add(Me.ComboBoxQuality)
        Me.Controls.Add(Me.ButtonTakeScreenshot)
        Me.Controls.Add(Me.PictureBoxScreenviewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(536, 391)
        Me.Name = "Screenviewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Screenviewer"
        Me.TopMost = True
        CType(Me.PictureBoxScreenviewer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBoxScreenviewer As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonTakeScreenshot As System.Windows.Forms.Button
    Friend WithEvents ComboBoxQuality As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonSaveScreenshot As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialogSaveScreenshot As System.Windows.Forms.SaveFileDialog
    Friend WithEvents CheckBoxStamp As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
