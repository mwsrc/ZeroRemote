<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageBoxManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MessageBoxManager))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxTitle = New System.Windows.Forms.TextBox()
        Me.TextBoxMessage = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonTest = New System.Windows.Forms.Button()
        Me.ButtonSend = New System.Windows.Forms.Button()
        Me.ImageListIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageComboBoxMsgBoxButtons = New Client.ImageComboBox()
        Me.ImageComboBoxMsgBoxIcons = New Client.ImageComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MessageBox Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MessageBox Title:"
        '
        'TextBoxTitle
        '
        Me.TextBoxTitle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTitle.Location = New System.Drawing.Point(28, 35)
        Me.TextBoxTitle.MaxLength = 250
        Me.TextBoxTitle.Name = "TextBoxTitle"
        Me.TextBoxTitle.Size = New System.Drawing.Size(343, 21)
        Me.TextBoxTitle.TabIndex = 2
        Me.TextBoxTitle.Text = "ZeroRemote"
        '
        'TextBoxMessage
        '
        Me.TextBoxMessage.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMessage.Location = New System.Drawing.Point(27, 85)
        Me.TextBoxMessage.MaxLength = 250
        Me.TextBoxMessage.Multiline = True
        Me.TextBoxMessage.Name = "TextBoxMessage"
        Me.TextBoxMessage.Size = New System.Drawing.Size(344, 80)
        Me.TextBoxMessage.TabIndex = 3
        Me.TextBoxMessage.Text = "This computer is controlled by ZeroRemote."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "MessageBox Icon:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(196, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "MessageBox Buttons:"
        '
        'ButtonTest
        '
        Me.ButtonTest.Image = CType(resources.GetObject("ButtonTest.Image"), System.Drawing.Image)
        Me.ButtonTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTest.Location = New System.Drawing.Point(75, 229)
        Me.ButtonTest.Name = "ButtonTest"
        Me.ButtonTest.Size = New System.Drawing.Size(108, 23)
        Me.ButtonTest.TabIndex = 8
        Me.ButtonTest.Text = "Test"
        Me.ButtonTest.UseVisualStyleBackColor = True
        '
        'ButtonSend
        '
        Me.ButtonSend.Image = CType(resources.GetObject("ButtonSend.Image"), System.Drawing.Image)
        Me.ButtonSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSend.Location = New System.Drawing.Point(199, 229)
        Me.ButtonSend.Name = "ButtonSend"
        Me.ButtonSend.Size = New System.Drawing.Size(108, 23)
        Me.ButtonSend.TabIndex = 9
        Me.ButtonSend.Text = "Send"
        Me.ButtonSend.UseVisualStyleBackColor = True
        '
        'ImageListIcons
        '
        Me.ImageListIcons.ImageStream = CType(resources.GetObject("ImageListIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListIcons.Images.SetKeyName(0, "balloon-white.png")
        Me.ImageListIcons.Images.SetKeyName(1, "information.png")
        Me.ImageListIcons.Images.SetKeyName(2, "question.png")
        Me.ImageListIcons.Images.SetKeyName(3, "exclamation.png")
        Me.ImageListIcons.Images.SetKeyName(4, "cross-circle.png")
        '
        'ImageComboBoxMsgBoxButtons
        '
        Me.ImageComboBoxMsgBoxButtons.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ImageComboBoxMsgBoxButtons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ImageComboBoxMsgBoxButtons.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImageComboBoxMsgBoxButtons.FormattingEnabled = True
        Me.ImageComboBoxMsgBoxButtons.ImageList = Nothing
        Me.ImageComboBoxMsgBoxButtons.Items.AddRange(New Object() {"Ok", "Ok and Cancel", "Abort, Retry and Ignore", "Yes and No", "Yes, No and Cancel"})
        Me.ImageComboBoxMsgBoxButtons.Location = New System.Drawing.Point(199, 194)
        Me.ImageComboBoxMsgBoxButtons.Name = "ImageComboBoxMsgBoxButtons"
        Me.ImageComboBoxMsgBoxButtons.Size = New System.Drawing.Size(172, 22)
        Me.ImageComboBoxMsgBoxButtons.TabIndex = 7
        '
        'ImageComboBoxMsgBoxIcons
        '
        Me.ImageComboBoxMsgBoxIcons.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ImageComboBoxMsgBoxIcons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ImageComboBoxMsgBoxIcons.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImageComboBoxMsgBoxIcons.FormattingEnabled = True
        Me.ImageComboBoxMsgBoxIcons.ImageList = Me.ImageListIcons
        Me.ImageComboBoxMsgBoxIcons.Location = New System.Drawing.Point(28, 194)
        Me.ImageComboBoxMsgBoxIcons.Name = "ImageComboBoxMsgBoxIcons"
        Me.ImageComboBoxMsgBoxIcons.Size = New System.Drawing.Size(155, 22)
        Me.ImageComboBoxMsgBoxIcons.TabIndex = 4
        '
        'MessageBoxManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 265)
        Me.Controls.Add(Me.ButtonSend)
        Me.Controls.Add(Me.ButtonTest)
        Me.Controls.Add(Me.ImageComboBoxMsgBoxButtons)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ImageComboBoxMsgBoxIcons)
        Me.Controls.Add(Me.TextBoxMessage)
        Me.Controls.Add(Me.TextBoxTitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MessageBoxManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MessageBox Manager"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTitle As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMessage As System.Windows.Forms.TextBox
    Friend WithEvents ImageComboBoxMsgBoxIcons As Client.ImageComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ImageComboBoxMsgBoxButtons As Client.ImageComboBox
    Friend WithEvents ButtonTest As System.Windows.Forms.Button
    Friend WithEvents ButtonSend As System.Windows.Forms.Button
    Friend WithEvents ImageListIcons As System.Windows.Forms.ImageList
End Class
