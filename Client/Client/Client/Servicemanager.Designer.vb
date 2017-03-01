<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Servicemanager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Servicemanager))
        Me.ListViewServices = New System.Windows.Forms.ListView()
        Me.ColumnHeaderName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderDesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderState = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStripServices = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StartServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetServicepathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageListServices = New System.Windows.Forms.ImageList(Me.components)
        Me.ButtonRefreshServices = New System.Windows.Forms.Button()
        Me.ContextMenuStripServices.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewServices
        '
        Me.ListViewServices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderName, Me.ColumnHeaderDesc, Me.ColumnHeaderState})
        Me.ListViewServices.ContextMenuStrip = Me.ContextMenuStripServices
        Me.ListViewServices.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewServices.FullRowSelect = True
        Me.ListViewServices.Location = New System.Drawing.Point(12, 12)
        Me.ListViewServices.Name = "ListViewServices"
        Me.ListViewServices.Size = New System.Drawing.Size(368, 293)
        Me.ListViewServices.SmallImageList = Me.ImageListServices
        Me.ListViewServices.TabIndex = 0
        Me.ListViewServices.UseCompatibleStateImageBehavior = False
        Me.ListViewServices.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderName
        '
        Me.ColumnHeaderName.Text = "Servicename"
        Me.ColumnHeaderName.Width = 115
        '
        'ColumnHeaderDesc
        '
        Me.ColumnHeaderDesc.Text = "Service Description"
        Me.ColumnHeaderDesc.Width = 156
        '
        'ColumnHeaderState
        '
        Me.ColumnHeaderState.Text = "Status"
        Me.ColumnHeaderState.Width = 92
        '
        'ContextMenuStripServices
        '
        Me.ContextMenuStripServices.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartServiceToolStripMenuItem, Me.StopServiceToolStripMenuItem, Me.GetServicepathToolStripMenuItem})
        Me.ContextMenuStripServices.Name = "ContextMenuStrip1"
        Me.ContextMenuStripServices.Size = New System.Drawing.Size(157, 70)
        '
        'StartServiceToolStripMenuItem
        '
        Me.StartServiceToolStripMenuItem.Image = CType(resources.GetObject("StartServiceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StartServiceToolStripMenuItem.Name = "StartServiceToolStripMenuItem"
        Me.StartServiceToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.StartServiceToolStripMenuItem.Text = "Start Service"
        '
        'StopServiceToolStripMenuItem
        '
        Me.StopServiceToolStripMenuItem.Image = CType(resources.GetObject("StopServiceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StopServiceToolStripMenuItem.Name = "StopServiceToolStripMenuItem"
        Me.StopServiceToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.StopServiceToolStripMenuItem.Text = "Stop Service"
        '
        'GetServicepathToolStripMenuItem
        '
        Me.GetServicepathToolStripMenuItem.Image = CType(resources.GetObject("GetServicepathToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GetServicepathToolStripMenuItem.Name = "GetServicepathToolStripMenuItem"
        Me.GetServicepathToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.GetServicepathToolStripMenuItem.Text = "Get Servicepath"
        '
        'ImageListServices
        '
        Me.ImageListServices.ImageStream = CType(resources.GetObject("ImageListServices.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListServices.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListServices.Images.SetKeyName(0, "geara.png")
        Me.ImageListServices.Images.SetKeyName(1, "gearm.png")
        Me.ImageListServices.Images.SetKeyName(2, "gearw.png")
        '
        'ButtonRefreshServices
        '
        Me.ButtonRefreshServices.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefreshServices.Image = CType(resources.GetObject("ButtonRefreshServices.Image"), System.Drawing.Image)
        Me.ButtonRefreshServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRefreshServices.Location = New System.Drawing.Point(141, 311)
        Me.ButtonRefreshServices.Name = "ButtonRefreshServices"
        Me.ButtonRefreshServices.Size = New System.Drawing.Size(103, 23)
        Me.ButtonRefreshServices.TabIndex = 1
        Me.ButtonRefreshServices.Text = "Refresh"
        Me.ButtonRefreshServices.UseVisualStyleBackColor = True
        '
        'Servicemanager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 341)
        Me.Controls.Add(Me.ButtonRefreshServices)
        Me.Controls.Add(Me.ListViewServices)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Servicemanager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Servicemanager"
        Me.TopMost = True
        Me.ContextMenuStripServices.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListViewServices As System.Windows.Forms.ListView
    Friend WithEvents ButtonRefreshServices As System.Windows.Forms.Button
    Friend WithEvents ColumnHeaderName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderDesc As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderState As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageListServices As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStripServices As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StartServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetServicepathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
