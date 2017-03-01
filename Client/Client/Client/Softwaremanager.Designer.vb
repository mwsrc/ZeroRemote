<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Softwaremanager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Softwaremanager))
        Me.ListViewSoftware = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageListIcon = New System.Windows.Forms.ImageList(Me.components)
        Me.ButtonGetSoftware = New System.Windows.Forms.Button()
        Me.LabelAppCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListViewSoftware
        '
        Me.ListViewSoftware.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListViewSoftware.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewSoftware.FullRowSelect = True
        Me.ListViewSoftware.Location = New System.Drawing.Point(12, 12)
        Me.ListViewSoftware.Name = "ListViewSoftware"
        Me.ListViewSoftware.Size = New System.Drawing.Size(437, 278)
        Me.ListViewSoftware.SmallImageList = Me.ImageListIcon
        Me.ListViewSoftware.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListViewSoftware.TabIndex = 0
        Me.ListViewSoftware.UseCompatibleStateImageBehavior = False
        Me.ListViewSoftware.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Softwarename"
        Me.ColumnHeader1.Width = 175
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Publisher"
        Me.ColumnHeader2.Width = 99
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Uninstall String"
        Me.ColumnHeader3.Width = 158
        '
        'ImageListIcon
        '
        Me.ImageListIcon.ImageStream = CType(resources.GetObject("ImageListIcon.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListIcon.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListIcon.Images.SetKeyName(0, "box--arrow.png")
        '
        'ButtonGetSoftware
        '
        Me.ButtonGetSoftware.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGetSoftware.Image = CType(resources.GetObject("ButtonGetSoftware.Image"), System.Drawing.Image)
        Me.ButtonGetSoftware.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonGetSoftware.Location = New System.Drawing.Point(12, 296)
        Me.ButtonGetSoftware.Name = "ButtonGetSoftware"
        Me.ButtonGetSoftware.Size = New System.Drawing.Size(154, 23)
        Me.ButtonGetSoftware.TabIndex = 1
        Me.ButtonGetSoftware.Text = "Refresh Software"
        Me.ButtonGetSoftware.UseVisualStyleBackColor = True
        '
        'LabelAppCount
        '
        Me.LabelAppCount.AutoSize = True
        Me.LabelAppCount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAppCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelAppCount.Location = New System.Drawing.Point(350, 301)
        Me.LabelAppCount.Name = "LabelAppCount"
        Me.LabelAppCount.Size = New System.Drawing.Size(14, 13)
        Me.LabelAppCount.TabIndex = 5
        Me.LabelAppCount.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(187, 301)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Installed Applications: "
        '
        'Softwaremanager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 327)
        Me.Controls.Add(Me.LabelAppCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonGetSoftware)
        Me.Controls.Add(Me.ListViewSoftware)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Softwaremanager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Softwaremanager"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListViewSoftware As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ButtonGetSoftware As System.Windows.Forms.Button
    Friend WithEvents ImageListIcon As System.Windows.Forms.ImageList
    Friend WithEvents LabelAppCount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
