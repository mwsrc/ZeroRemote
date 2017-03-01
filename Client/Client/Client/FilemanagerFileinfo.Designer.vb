<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilemanagerFileinfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilemanagerFileinfo))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBoxFilename = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxFileType = New System.Windows.Forms.TextBox()
        Me.TextBoxFileDescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelFilesize = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelCreationDate = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBoxReadonly = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHidden = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSystem = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTemporary = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxLocation = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(34, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBoxFilename
        '
        Me.TextBoxFilename.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFilename.Location = New System.Drawing.Point(102, 21)
        Me.TextBoxFilename.Name = "TextBoxFilename"
        Me.TextBoxFilename.ReadOnly = True
        Me.TextBoxFilename.Size = New System.Drawing.Size(183, 21)
        Me.TextBoxFilename.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(27, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Filetype:"
        '
        'TextBoxFileType
        '
        Me.TextBoxFileType.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFileType.Location = New System.Drawing.Point(102, 65)
        Me.TextBoxFileType.Name = "TextBoxFileType"
        Me.TextBoxFileType.ReadOnly = True
        Me.TextBoxFileType.Size = New System.Drawing.Size(183, 21)
        Me.TextBoxFileType.TabIndex = 3
        '
        'TextBoxFileDescription
        '
        Me.TextBoxFileDescription.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFileDescription.Location = New System.Drawing.Point(102, 91)
        Me.TextBoxFileDescription.Name = "TextBoxFileDescription"
        Me.TextBoxFileDescription.ReadOnly = True
        Me.TextBoxFileDescription.Size = New System.Drawing.Size(183, 21)
        Me.TextBoxFileDescription.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(7, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(31, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Filesize:"
        '
        'LabelFilesize
        '
        Me.LabelFilesize.AutoSize = True
        Me.LabelFilesize.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFilesize.Location = New System.Drawing.Point(104, 147)
        Me.LabelFilesize.Name = "LabelFilesize"
        Me.LabelFilesize.Size = New System.Drawing.Size(50, 13)
        Me.LabelFilesize.TabIndex = 7
        Me.LabelFilesize.Text = "0 Bytes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(25, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Created:"
        '
        'LabelCreationDate
        '
        Me.LabelCreationDate.AutoSize = True
        Me.LabelCreationDate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCreationDate.Location = New System.Drawing.Point(104, 171)
        Me.LabelCreationDate.Name = "LabelCreationDate"
        Me.LabelCreationDate.Size = New System.Drawing.Size(73, 13)
        Me.LabelCreationDate.TabIndex = 9
        Me.LabelCreationDate.Text = "00/00/0000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(16, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Attributes:"
        '
        'CheckBoxReadonly
        '
        Me.CheckBoxReadonly.AutoSize = True
        Me.CheckBoxReadonly.Enabled = False
        Me.CheckBoxReadonly.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxReadonly.Location = New System.Drawing.Point(102, 200)
        Me.CheckBoxReadonly.Name = "CheckBoxReadonly"
        Me.CheckBoxReadonly.Size = New System.Drawing.Size(84, 17)
        Me.CheckBoxReadonly.TabIndex = 11
        Me.CheckBoxReadonly.Text = "Read-only"
        Me.CheckBoxReadonly.UseVisualStyleBackColor = True
        '
        'CheckBoxHidden
        '
        Me.CheckBoxHidden.AutoSize = True
        Me.CheckBoxHidden.Enabled = False
        Me.CheckBoxHidden.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxHidden.Location = New System.Drawing.Point(194, 200)
        Me.CheckBoxHidden.Name = "CheckBoxHidden"
        Me.CheckBoxHidden.Size = New System.Drawing.Size(65, 17)
        Me.CheckBoxHidden.TabIndex = 12
        Me.CheckBoxHidden.Text = "Hidden"
        Me.CheckBoxHidden.UseVisualStyleBackColor = True
        '
        'CheckBoxSystem
        '
        Me.CheckBoxSystem.AutoSize = True
        Me.CheckBoxSystem.Enabled = False
        Me.CheckBoxSystem.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSystem.Location = New System.Drawing.Point(102, 223)
        Me.CheckBoxSystem.Name = "CheckBoxSystem"
        Me.CheckBoxSystem.Size = New System.Drawing.Size(69, 17)
        Me.CheckBoxSystem.TabIndex = 13
        Me.CheckBoxSystem.Text = "System"
        Me.CheckBoxSystem.UseVisualStyleBackColor = True
        '
        'CheckBoxTemporary
        '
        Me.CheckBoxTemporary.AutoSize = True
        Me.CheckBoxTemporary.Enabled = False
        Me.CheckBoxTemporary.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxTemporary.Location = New System.Drawing.Point(194, 223)
        Me.CheckBoxTemporary.Name = "CheckBoxTemporary"
        Me.CheckBoxTemporary.Size = New System.Drawing.Size(89, 17)
        Me.CheckBoxTemporary.TabIndex = 14
        Me.CheckBoxTemporary.Text = "Temporary"
        Me.CheckBoxTemporary.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(25, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Location:"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(116, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxLocation
        '
        Me.TextBoxLocation.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLocation.Location = New System.Drawing.Point(102, 114)
        Me.TextBoxLocation.Name = "TextBoxLocation"
        Me.TextBoxLocation.ReadOnly = True
        Me.TextBoxLocation.Size = New System.Drawing.Size(183, 21)
        Me.TextBoxLocation.TabIndex = 18
        '
        'FilemanagerFileinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 299)
        Me.Controls.Add(Me.TextBoxLocation)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CheckBoxTemporary)
        Me.Controls.Add(Me.CheckBoxSystem)
        Me.Controls.Add(Me.CheckBoxHidden)
        Me.Controls.Add(Me.CheckBoxReadonly)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelCreationDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelFilesize)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxFileDescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxFileType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxFilename)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FilemanagerFileinfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Fileinfo"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxFilename As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxFileType As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxFileDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelFilesize As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelCreationDate As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxReadonly As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHidden As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSystem As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxTemporary As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBoxLocation As System.Windows.Forms.TextBox
End Class
