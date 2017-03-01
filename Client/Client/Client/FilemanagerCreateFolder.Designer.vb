<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilemanagerCreateFolder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilemanagerCreateFolder))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonRename = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the name of the new directory " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you like to create"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(24, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(205, 20)
        Me.TextBox1.TabIndex = 1
        '
        'ButtonRename
        '
        Me.ButtonRename.Image = CType(resources.GetObject("ButtonRename.Image"), System.Drawing.Image)
        Me.ButtonRename.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRename.Location = New System.Drawing.Point(24, 82)
        Me.ButtonRename.Name = "ButtonRename"
        Me.ButtonRename.Size = New System.Drawing.Size(92, 25)
        Me.ButtonRename.TabIndex = 2
        Me.ButtonRename.Text = "Create"
        Me.ButtonRename.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Image = CType(resources.GetObject("ButtonCancel.Image"), System.Drawing.Image)
        Me.ButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCancel.Location = New System.Drawing.Point(141, 82)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(88, 25)
        Me.ButtonCancel.TabIndex = 3
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'FilemanagerCreateFolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 117)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonRename)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FilemanagerCreateFolder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create New Folder"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonRename As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
End Class
