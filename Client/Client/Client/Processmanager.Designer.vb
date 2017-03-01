<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Processmanager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Processmanager))
        Me.ListViewProcesses = New System.Windows.Forms.ListView()
        Me.ColumnHeader0 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStripProcesses = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StartProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerminateProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetModulesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageListProcess = New System.Windows.Forms.ImageList(Me.components)
        Me.ButtonRefreshProcesses = New System.Windows.Forms.Button()
        Me.ContextMenuStripProcesses.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewProcesses
        '
        Me.ListViewProcesses.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader0, Me.ColumnHeader1})
        Me.ListViewProcesses.ContextMenuStrip = Me.ContextMenuStripProcesses
        Me.ListViewProcesses.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewProcesses.FullRowSelect = True
        Me.ListViewProcesses.Location = New System.Drawing.Point(12, 12)
        Me.ListViewProcesses.Name = "ListViewProcesses"
        Me.ListViewProcesses.Size = New System.Drawing.Size(289, 286)
        Me.ListViewProcesses.SmallImageList = Me.ImageListProcess
        Me.ListViewProcesses.TabIndex = 0
        Me.ListViewProcesses.UseCompatibleStateImageBehavior = False
        Me.ListViewProcesses.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader0
        '
        Me.ColumnHeader0.Text = "Processname"
        Me.ColumnHeader0.Width = 224
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "PID"
        '
        'ContextMenuStripProcesses
        '
        Me.ContextMenuStripProcesses.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartProcessToolStripMenuItem, Me.TerminateProcessToolStripMenuItem, Me.GetModulesToolStripMenuItem})
        Me.ContextMenuStripProcesses.Name = "ContextMenuStripProcesses"
        Me.ContextMenuStripProcesses.Size = New System.Drawing.Size(172, 70)
        '
        'StartProcessToolStripMenuItem
        '
        Me.StartProcessToolStripMenuItem.Image = CType(resources.GetObject("StartProcessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StartProcessToolStripMenuItem.Name = "StartProcessToolStripMenuItem"
        Me.StartProcessToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.StartProcessToolStripMenuItem.Text = "Start Process"
        '
        'TerminateProcessToolStripMenuItem
        '
        Me.TerminateProcessToolStripMenuItem.Image = CType(resources.GetObject("TerminateProcessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TerminateProcessToolStripMenuItem.Name = "TerminateProcessToolStripMenuItem"
        Me.TerminateProcessToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.TerminateProcessToolStripMenuItem.Text = "Terminate Process"
        '
        'GetModulesToolStripMenuItem
        '
        Me.GetModulesToolStripMenuItem.Image = CType(resources.GetObject("GetModulesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GetModulesToolStripMenuItem.Name = "GetModulesToolStripMenuItem"
        Me.GetModulesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.GetModulesToolStripMenuItem.Text = "Get Modules"
        '
        'ImageListProcess
        '
        Me.ImageListProcess.ImageStream = CType(resources.GetObject("ImageListProcess.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListProcess.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListProcess.Images.SetKeyName(0, "1.png")
        Me.ImageListProcess.Images.SetKeyName(1, "2.png")
        '
        'ButtonRefreshProcesses
        '
        Me.ButtonRefreshProcesses.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefreshProcesses.Image = CType(resources.GetObject("ButtonRefreshProcesses.Image"), System.Drawing.Image)
        Me.ButtonRefreshProcesses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRefreshProcesses.Location = New System.Drawing.Point(106, 304)
        Me.ButtonRefreshProcesses.Name = "ButtonRefreshProcesses"
        Me.ButtonRefreshProcesses.Size = New System.Drawing.Size(99, 23)
        Me.ButtonRefreshProcesses.TabIndex = 1
        Me.ButtonRefreshProcesses.Text = "Refresh"
        Me.ButtonRefreshProcesses.UseVisualStyleBackColor = True
        '
        'Processmanager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 334)
        Me.Controls.Add(Me.ButtonRefreshProcesses)
        Me.Controls.Add(Me.ListViewProcesses)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Processmanager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Processmanager"
        Me.TopMost = True
        Me.ContextMenuStripProcesses.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListViewProcesses As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader0 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ButtonRefreshProcesses As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStripProcesses As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StartProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TerminateProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetModulesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageListProcess As System.Windows.Forms.ImageList
End Class
