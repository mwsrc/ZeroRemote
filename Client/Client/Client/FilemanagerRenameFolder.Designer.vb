<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilemanagerRenameFolder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilemanagerRenameFolder))
        Me.ButtonRename = New System.Windows.Forms.Button()
        Me.ButtonCancelRename = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxRenameFolder = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonRename
        '
        Me.ButtonRename.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRename.Image = CType(resources.GetObject("ButtonRename.Image"), System.Drawing.Image)
        Me.ButtonRename.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRename.Location = New System.Drawing.Point(21, 71)
        Me.ButtonRename.Name = "ButtonRename"
        Me.ButtonRename.Size = New System.Drawing.Size(101, 25)
        Me.ButtonRename.TabIndex = 0
        Me.ButtonRename.Text = "Rename"
        Me.ButtonRename.UseVisualStyleBackColor = True
        '
        'ButtonCancelRename
        '
        Me.ButtonCancelRename.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelRename.Image = CType(resources.GetObject("ButtonCancelRename.Image"), System.Drawing.Image)
        Me.ButtonCancelRename.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCancelRename.Location = New System.Drawing.Point(128, 71)
        Me.ButtonCancelRename.Name = "ButtonCancelRename"
        Me.ButtonCancelRename.Size = New System.Drawing.Size(98, 25)
        Me.ButtonCancelRename.TabIndex = 1
        Me.ButtonCancelRename.Text = "Cancel"
        Me.ButtonCancelRename.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please the new name for the folder " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you like to rename:"
        '
        'TextBoxRenameFolder
        '
        Me.TextBoxRenameFolder.Location = New System.Drawing.Point(22, 45)
        Me.TextBoxRenameFolder.Name = "TextBoxRenameFolder"
        Me.TextBoxRenameFolder.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxRenameFolder.TabIndex = 3
        '
        'FilemanagerRenameFolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 108)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBoxRenameFolder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonCancelRename)
        Me.Controls.Add(Me.ButtonRename)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FilemanagerRenameFolder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Rename Folder"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonRename As System.Windows.Forms.Button
    Friend WithEvents ButtonCancelRename As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxRenameFolder As System.Windows.Forms.TextBox
End Class
