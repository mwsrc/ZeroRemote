<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartupMonitor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartupMonitor))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListViewStartupPrograms = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStripStartup = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RenoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageListPrograms = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStripStartup.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(163, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "List Startup Programs"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListViewStartupPrograms
        '
        Me.ListViewStartupPrograms.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListViewStartupPrograms.ContextMenuStrip = Me.ContextMenuStripStartup
        Me.ListViewStartupPrograms.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewStartupPrograms.FullRowSelect = True
        Me.ListViewStartupPrograms.Location = New System.Drawing.Point(12, 47)
        Me.ListViewStartupPrograms.Name = "ListViewStartupPrograms"
        Me.ListViewStartupPrograms.Size = New System.Drawing.Size(479, 213)
        Me.ListViewStartupPrograms.SmallImageList = Me.ImageListPrograms
        Me.ListViewStartupPrograms.TabIndex = 1
        Me.ListViewStartupPrograms.UseCompatibleStateImageBehavior = False
        Me.ListViewStartupPrograms.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Startup Program"
        Me.ColumnHeader1.Width = 161
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Startup Path"
        Me.ColumnHeader2.Width = 314
        '
        'ContextMenuStripStartup
        '
        Me.ContextMenuStripStartup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RenoveToolStripMenuItem})
        Me.ContextMenuStripStartup.Name = "ContextMenuStripStartup"
        Me.ContextMenuStripStartup.Size = New System.Drawing.Size(167, 26)
        '
        'RenoveToolStripMenuItem
        '
        Me.RenoveToolStripMenuItem.Image = CType(resources.GetObject("RenoveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RenoveToolStripMenuItem.Name = "RenoveToolStripMenuItem"
        Me.RenoveToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.RenoveToolStripMenuItem.Text = "Remove Program"
        '
        'ImageListPrograms
        '
        Me.ImageListPrograms.ImageStream = CType(resources.GetObject("ImageListPrograms.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListPrograms.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListPrograms.Images.SetKeyName(0, "calendar-task.png")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Use the Startupmanager to manage the autostart programs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on the remote computer."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StartupMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 299)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListViewStartupPrograms)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StartupMonitor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Startupmanager"
        Me.TopMost = True
        Me.ContextMenuStripStartup.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListViewStartupPrograms As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStripStartup As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RenoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageListPrograms As System.Windows.Forms.ImageList
End Class
