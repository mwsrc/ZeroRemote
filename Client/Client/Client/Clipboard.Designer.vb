<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clipboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clipboard))
        Me.RichTextBoxClipboard = New System.Windows.Forms.RichTextBox()
        Me.ButtonGetText = New System.Windows.Forms.Button()
        Me.ButtonSetText = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RichTextBoxClipboard
        '
        Me.RichTextBoxClipboard.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBoxClipboard.Name = "RichTextBoxClipboard"
        Me.RichTextBoxClipboard.Size = New System.Drawing.Size(270, 143)
        Me.RichTextBoxClipboard.TabIndex = 2
        Me.RichTextBoxClipboard.Text = ""
        '
        'ButtonGetText
        '
        Me.ButtonGetText.Image = CType(resources.GetObject("ButtonGetText.Image"), System.Drawing.Image)
        Me.ButtonGetText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonGetText.Location = New System.Drawing.Point(117, 161)
        Me.ButtonGetText.Name = "ButtonGetText"
        Me.ButtonGetText.Size = New System.Drawing.Size(99, 24)
        Me.ButtonGetText.TabIndex = 1
        Me.ButtonGetText.Text = "Get Text"
        Me.ButtonGetText.UseVisualStyleBackColor = True
        '
        'ButtonSetText
        '
        Me.ButtonSetText.Image = CType(resources.GetObject("ButtonSetText.Image"), System.Drawing.Image)
        Me.ButtonSetText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSetText.Location = New System.Drawing.Point(12, 161)
        Me.ButtonSetText.Name = "ButtonSetText"
        Me.ButtonSetText.Size = New System.Drawing.Size(99, 24)
        Me.ButtonSetText.TabIndex = 0
        Me.ButtonSetText.Text = "Set Text"
        Me.ButtonSetText.UseVisualStyleBackColor = True
        '
        'Clipboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 192)
        Me.Controls.Add(Me.RichTextBoxClipboard)
        Me.Controls.Add(Me.ButtonGetText)
        Me.Controls.Add(Me.ButtonSetText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Clipboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Clipboard"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonSetText As System.Windows.Forms.Button
    Friend WithEvents ButtonGetText As System.Windows.Forms.Button
    Friend WithEvents RichTextBoxClipboard As System.Windows.Forms.RichTextBox
End Class
