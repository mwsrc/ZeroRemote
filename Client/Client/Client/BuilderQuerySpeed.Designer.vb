<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuilderQuerySpeed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuilderQuerySpeed))
        Me.TrackBarQuerySpeed = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelSpeed = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.TrackBarQuerySpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrackBarQuerySpeed
        '
        Me.TrackBarQuerySpeed.Location = New System.Drawing.Point(32, 76)
        Me.TrackBarQuerySpeed.Maximum = 5
        Me.TrackBarQuerySpeed.Name = "TrackBarQuerySpeed"
        Me.TrackBarQuerySpeed.Size = New System.Drawing.Size(280, 45)
        Me.TrackBarQuerySpeed.TabIndex = 0
        Me.TrackBarQuerySpeed.Value = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 52)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Configure the server query speed." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A faster query speed offers a faster communica" & _
    "tion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "between server and client but increases the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "stress on the webserver."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelSpeed
        '
        Me.LabelSpeed.AutoSize = True
        Me.LabelSpeed.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSpeed.Location = New System.Drawing.Point(61, 114)
        Me.LabelSpeed.Name = "LabelSpeed"
        Me.LabelSpeed.Size = New System.Drawing.Size(193, 13)
        Me.LabelSpeed.TabIndex = 2
        Me.LabelSpeed.Text = "Selected Query Speed: 3000 ms"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 136)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(338, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.DropDownButtonWidth = 0
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(21, 20)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(221, 17)
        Me.ToolStripStatusLabel1.Text = "Good query speed. Average server stress."
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'BuilderQuerySpeed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 158)
        Me.Controls.Add(Me.LabelSpeed)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrackBarQuerySpeed)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BuilderQuerySpeed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configure Server Query Speed"
        Me.TopMost = True
        CType(Me.TrackBarQuerySpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TrackBarQuerySpeed As System.Windows.Forms.TrackBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelSpeed As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
End Class
