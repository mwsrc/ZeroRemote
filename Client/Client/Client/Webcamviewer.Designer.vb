<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Webcamviewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Webcamviewer))
        Me.ComboBoxWebcamDevices = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonSaveSnapshot = New System.Windows.Forms.Button()
        Me.ButtonTakeSnapshot = New System.Windows.Forms.Button()
        Me.ButtonLoadDevices = New System.Windows.Forms.Button()
        Me.PictureBoxWebcam = New System.Windows.Forms.PictureBox()
        Me.SaveFileDialogWebcam = New System.Windows.Forms.SaveFileDialog()
        CType(Me.PictureBoxWebcam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxWebcamDevices
        '
        Me.ComboBoxWebcamDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxWebcamDevices.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxWebcamDevices.FormattingEnabled = True
        Me.ComboBoxWebcamDevices.Location = New System.Drawing.Point(128, 10)
        Me.ComboBoxWebcamDevices.Name = "ComboBoxWebcamDevices"
        Me.ComboBoxWebcamDevices.Size = New System.Drawing.Size(184, 21)
        Me.ComboBoxWebcamDevices.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Webcam Devices:"
        '
        'ButtonSaveSnapshot
        '
        Me.ButtonSaveSnapshot.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveSnapshot.Image = CType(resources.GetObject("ButtonSaveSnapshot.Image"), System.Drawing.Image)
        Me.ButtonSaveSnapshot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSaveSnapshot.Location = New System.Drawing.Point(169, 283)
        Me.ButtonSaveSnapshot.Name = "ButtonSaveSnapshot"
        Me.ButtonSaveSnapshot.Size = New System.Drawing.Size(143, 23)
        Me.ButtonSaveSnapshot.TabIndex = 4
        Me.ButtonSaveSnapshot.Text = "Save Snapshot"
        Me.ButtonSaveSnapshot.UseVisualStyleBackColor = True
        '
        'ButtonTakeSnapshot
        '
        Me.ButtonTakeSnapshot.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTakeSnapshot.Image = CType(resources.GetObject("ButtonTakeSnapshot.Image"), System.Drawing.Image)
        Me.ButtonTakeSnapshot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTakeSnapshot.Location = New System.Drawing.Point(14, 283)
        Me.ButtonTakeSnapshot.Name = "ButtonTakeSnapshot"
        Me.ButtonTakeSnapshot.Size = New System.Drawing.Size(148, 23)
        Me.ButtonTakeSnapshot.TabIndex = 3
        Me.ButtonTakeSnapshot.Text = "Take Snapshot"
        Me.ButtonTakeSnapshot.UseVisualStyleBackColor = True
        '
        'ButtonLoadDevices
        '
        Me.ButtonLoadDevices.Image = CType(resources.GetObject("ButtonLoadDevices.Image"), System.Drawing.Image)
        Me.ButtonLoadDevices.Location = New System.Drawing.Point(319, 8)
        Me.ButtonLoadDevices.Name = "ButtonLoadDevices"
        Me.ButtonLoadDevices.Size = New System.Drawing.Size(29, 23)
        Me.ButtonLoadDevices.TabIndex = 2
        Me.ButtonLoadDevices.UseVisualStyleBackColor = True
        '
        'PictureBoxWebcam
        '
        Me.PictureBoxWebcam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxWebcam.Location = New System.Drawing.Point(14, 37)
        Me.PictureBoxWebcam.Name = "PictureBoxWebcam"
        Me.PictureBoxWebcam.Size = New System.Drawing.Size(334, 240)
        Me.PictureBoxWebcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxWebcam.TabIndex = 0
        Me.PictureBoxWebcam.TabStop = False
        '
        'SaveFileDialogWebcam
        '
        Me.SaveFileDialogWebcam.DefaultExt = "*.jpg"
        Me.SaveFileDialogWebcam.FileName = "Webcam"
        Me.SaveFileDialogWebcam.Filter = "JPEG Image|*.jpg"
        Me.SaveFileDialogWebcam.Title = "Save Webcam Snapshot"
        '
        'Webcamviewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 313)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonSaveSnapshot)
        Me.Controls.Add(Me.ButtonTakeSnapshot)
        Me.Controls.Add(Me.ButtonLoadDevices)
        Me.Controls.Add(Me.ComboBoxWebcamDevices)
        Me.Controls.Add(Me.PictureBoxWebcam)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Webcamviewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Webcamviewer"
        Me.TopMost = True
        CType(Me.PictureBoxWebcam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBoxWebcam As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBoxWebcamDevices As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonLoadDevices As System.Windows.Forms.Button
    Friend WithEvents ButtonTakeSnapshot As System.Windows.Forms.Button
    Friend WithEvents ButtonSaveSnapshot As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialogWebcam As System.Windows.Forms.SaveFileDialog
End Class
