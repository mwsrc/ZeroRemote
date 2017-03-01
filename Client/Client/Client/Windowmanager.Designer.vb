<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Windowmanager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Windowmanager))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListViewWindows = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStripWindowmanager = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RestoreWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizeWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaximizeWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FreezeWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnfreezeWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeWindowTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageListWindows = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStripWindowmanager.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(156, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListViewWindows
        '
        Me.ListViewWindows.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListViewWindows.ContextMenuStrip = Me.ContextMenuStripWindowmanager
        Me.ListViewWindows.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewWindows.FullRowSelect = True
        Me.ListViewWindows.Location = New System.Drawing.Point(12, 12)
        Me.ListViewWindows.Name = "ListViewWindows"
        Me.ListViewWindows.Size = New System.Drawing.Size(376, 203)
        Me.ListViewWindows.SmallImageList = Me.ImageListWindows
        Me.ListViewWindows.TabIndex = 1
        Me.ListViewWindows.UseCompatibleStateImageBehavior = False
        Me.ListViewWindows.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Handle"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Windowstate"
        Me.ColumnHeader2.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Window Title"
        Me.ColumnHeader3.Width = 202
        '
        'ContextMenuStripWindowmanager
        '
        Me.ContextMenuStripWindowmanager.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestoreWindowToolStripMenuItem, Me.MinimizeWindowToolStripMenuItem, Me.MaximizeWindowToolStripMenuItem, Me.CloseWindowToolStripMenuItem, Me.FreezeWindowToolStripMenuItem, Me.UnfreezeWindowToolStripMenuItem, Me.ChangeWindowTextToolStripMenuItem})
        Me.ContextMenuStripWindowmanager.Name = "ContextMenuStripWindowmanager"
        Me.ContextMenuStripWindowmanager.Size = New System.Drawing.Size(188, 158)
        '
        'RestoreWindowToolStripMenuItem
        '
        Me.RestoreWindowToolStripMenuItem.Image = CType(resources.GetObject("RestoreWindowToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RestoreWindowToolStripMenuItem.Name = "RestoreWindowToolStripMenuItem"
        Me.RestoreWindowToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.RestoreWindowToolStripMenuItem.Text = "Restore Window"
        '
        'MinimizeWindowToolStripMenuItem
        '
        Me.MinimizeWindowToolStripMenuItem.Image = CType(resources.GetObject("MinimizeWindowToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MinimizeWindowToolStripMenuItem.Name = "MinimizeWindowToolStripMenuItem"
        Me.MinimizeWindowToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.MinimizeWindowToolStripMenuItem.Text = "Minimize Window"
        '
        'MaximizeWindowToolStripMenuItem
        '
        Me.MaximizeWindowToolStripMenuItem.Image = CType(resources.GetObject("MaximizeWindowToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MaximizeWindowToolStripMenuItem.Name = "MaximizeWindowToolStripMenuItem"
        Me.MaximizeWindowToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.MaximizeWindowToolStripMenuItem.Text = "Maximize Window"
        '
        'CloseWindowToolStripMenuItem
        '
        Me.CloseWindowToolStripMenuItem.Image = CType(resources.GetObject("CloseWindowToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CloseWindowToolStripMenuItem.Name = "CloseWindowToolStripMenuItem"
        Me.CloseWindowToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.CloseWindowToolStripMenuItem.Text = "Close Window"
        '
        'FreezeWindowToolStripMenuItem
        '
        Me.FreezeWindowToolStripMenuItem.Image = CType(resources.GetObject("FreezeWindowToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FreezeWindowToolStripMenuItem.Name = "FreezeWindowToolStripMenuItem"
        Me.FreezeWindowToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.FreezeWindowToolStripMenuItem.Text = "Freeze Window"
        '
        'UnfreezeWindowToolStripMenuItem
        '
        Me.UnfreezeWindowToolStripMenuItem.Image = CType(resources.GetObject("UnfreezeWindowToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UnfreezeWindowToolStripMenuItem.Name = "UnfreezeWindowToolStripMenuItem"
        Me.UnfreezeWindowToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.UnfreezeWindowToolStripMenuItem.Text = "Unfreeze Window"
        '
        'ChangeWindowTextToolStripMenuItem
        '
        Me.ChangeWindowTextToolStripMenuItem.Image = CType(resources.GetObject("ChangeWindowTextToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangeWindowTextToolStripMenuItem.Name = "ChangeWindowTextToolStripMenuItem"
        Me.ChangeWindowTextToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ChangeWindowTextToolStripMenuItem.Text = "Change Window Text"
        '
        'ImageListWindows
        '
        Me.ImageListWindows.ImageStream = CType(resources.GetObject("ImageListWindows.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListWindows.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListWindows.Images.SetKeyName(0, "application.png")
        Me.ImageListWindows.Images.SetKeyName(1, "application_add.png")
        Me.ImageListWindows.Images.SetKeyName(2, "application_delete.png")
        '
        'Windowmanager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 253)
        Me.Controls.Add(Me.ListViewWindows)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Windowmanager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Windowmanager"
        Me.TopMost = True
        Me.ContextMenuStripWindowmanager.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListViewWindows As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageListWindows As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStripWindowmanager As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CloseWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MinimizeWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaximizeWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FreezeWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnfreezeWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeWindowTextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
