<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WindowmanagerTitleChanger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WindowmanagerTitleChanger))
        Me.TextBoxWindowTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonAbort = New System.Windows.Forms.Button()
        Me.ButtonChangeTitle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxWindowTitle
        '
        Me.TextBoxWindowTitle.Location = New System.Drawing.Point(23, 67)
        Me.TextBoxWindowTitle.Name = "TextBoxWindowTitle"
        Me.TextBoxWindowTitle.Size = New System.Drawing.Size(249, 20)
        Me.TextBoxWindowTitle.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "With this feature you can change the window " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "title of any selected window to a c" & _
    "ustom title."
        '
        'ButtonAbort
        '
        Me.ButtonAbort.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAbort.Image = CType(resources.GetObject("ButtonAbort.Image"), System.Drawing.Image)
        Me.ButtonAbort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAbort.Location = New System.Drawing.Point(142, 99)
        Me.ButtonAbort.Name = "ButtonAbort"
        Me.ButtonAbort.Size = New System.Drawing.Size(88, 23)
        Me.ButtonAbort.TabIndex = 3
        Me.ButtonAbort.Text = "Cancel"
        Me.ButtonAbort.UseVisualStyleBackColor = True
        '
        'ButtonChangeTitle
        '
        Me.ButtonChangeTitle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonChangeTitle.Image = CType(resources.GetObject("ButtonChangeTitle.Image"), System.Drawing.Image)
        Me.ButtonChangeTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonChangeTitle.Location = New System.Drawing.Point(47, 99)
        Me.ButtonChangeTitle.Name = "ButtonChangeTitle"
        Me.ButtonChangeTitle.Size = New System.Drawing.Size(89, 23)
        Me.ButtonChangeTitle.TabIndex = 2
        Me.ButtonChangeTitle.Text = "Change"
        Me.ButtonChangeTitle.UseVisualStyleBackColor = True
        '
        'WindowmanagerTitleChanger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 134)
        Me.Controls.Add(Me.ButtonAbort)
        Me.Controls.Add(Me.ButtonChangeTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxWindowTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WindowmanagerTitleChanger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Change window title"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxWindowTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonAbort As System.Windows.Forms.Button
    Friend WithEvents ButtonChangeTitle As System.Windows.Forms.Button
End Class
