<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilemanagerRenameFile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilemanagerRenameFile))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonRenameFile = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.TextBoxRenameFile = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter the new name for the file  you " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "like to rename and make sure you ad" & _
    "d the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "file extension: "
        '
        'ButtonRenameFile
        '
        Me.ButtonRenameFile.Image = CType(resources.GetObject("ButtonRenameFile.Image"), System.Drawing.Image)
        Me.ButtonRenameFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRenameFile.Location = New System.Drawing.Point(15, 84)
        Me.ButtonRenameFile.Name = "ButtonRenameFile"
        Me.ButtonRenameFile.Size = New System.Drawing.Size(93, 24)
        Me.ButtonRenameFile.TabIndex = 1
        Me.ButtonRenameFile.Text = "Rename"
        Me.ButtonRenameFile.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Image = CType(resources.GetObject("ButtonCancel.Image"), System.Drawing.Image)
        Me.ButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCancel.Location = New System.Drawing.Point(136, 84)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(93, 24)
        Me.ButtonCancel.TabIndex = 2
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'TextBoxRenameFile
        '
        Me.TextBoxRenameFile.Location = New System.Drawing.Point(15, 56)
        Me.TextBoxRenameFile.Name = "TextBoxRenameFile"
        Me.TextBoxRenameFile.Size = New System.Drawing.Size(253, 20)
        Me.TextBoxRenameFile.TabIndex = 3
        '
        'FilemanagerRenameFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 120)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBoxRenameFile)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonRenameFile)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FilemanagerRenameFile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Rename File"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonRenameFile As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents TextBoxRenameFile As System.Windows.Forms.TextBox
End Class
