<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordRecovery
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PasswordRecovery))
        Me.ListViewPasswords = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageListBrowsers = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBoxConfirmUsage = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListViewPasswords
        '
        Me.ListViewPasswords.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListViewPasswords.Enabled = False
        Me.ListViewPasswords.FullRowSelect = True
        Me.ListViewPasswords.Location = New System.Drawing.Point(12, 12)
        Me.ListViewPasswords.Name = "ListViewPasswords"
        Me.ListViewPasswords.Size = New System.Drawing.Size(561, 234)
        Me.ListViewPasswords.SmallImageList = Me.ImageListBrowsers
        Me.ListViewPasswords.TabIndex = 0
        Me.ListViewPasswords.UseCompatibleStateImageBehavior = False
        Me.ListViewPasswords.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Browser"
        Me.ColumnHeader1.Width = 91
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Username"
        Me.ColumnHeader2.Width = 106
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Password"
        Me.ColumnHeader3.Width = 99
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "URL/Website"
        Me.ColumnHeader4.Width = 244
        '
        'ImageListBrowsers
        '
        Me.ImageListBrowsers.ImageStream = CType(resources.GetObject("ImageListBrowsers.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListBrowsers.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListBrowsers.Images.SetKeyName(0, "Google-Chrome-icon.png")
        Me.ImageListBrowsers.Images.SetKeyName(1, "filezilla.png")
        Me.ImageListBrowsers.Images.SetKeyName(2, "windows.png")
        Me.ImageListBrowsers.Images.SetKeyName(3, "Mozilla-Firefox-icon.png")
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(209, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Recover Passwords"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBoxConfirmUsage
        '
        Me.CheckBoxConfirmUsage.AutoSize = True
        Me.CheckBoxConfirmUsage.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxConfirmUsage.Location = New System.Drawing.Point(31, 297)
        Me.CheckBoxConfirmUsage.Name = "CheckBoxConfirmUsage"
        Me.CheckBoxConfirmUsage.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxConfirmUsage.TabIndex = 2
        Me.CheckBoxConfirmUsage.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "  By using this feature I confirm that I've read the "
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(340, 286)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(105, 13)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Terms of Service"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(446, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "and have explicit "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(377, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "permission to recover the passwords of the controlled computer."
        '
        'PasswordRecovery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 333)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBoxConfirmUsage)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListViewPasswords)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PasswordRecovery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PasswordRecovery"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListViewPasswords As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageListBrowsers As System.Windows.Forms.ImageList
    Friend WithEvents CheckBoxConfirmUsage As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
