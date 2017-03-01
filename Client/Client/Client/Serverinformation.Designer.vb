<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Serverinformation
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Processname: ??", 0, 0)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Memory Usage: ??", 1, 1)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Executable Path: ??", 2, 2)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Autostart at reboot: ??", 3, 3)
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Unique ID: ??", 4, 4)
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Protected Process: ??", 5, 5)
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Privileges: ??", 6, 6)
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Visible Mode: ??", 7, 7)
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hosting URL: ??", 8, 8)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Serverinformation))
        Me.TreeViewServerInfo = New System.Windows.Forms.TreeView()
        Me.ImageListServerInfo = New System.Windows.Forms.ImageList(Me.components)
        Me.ButtonRefreshServerInfo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TreeViewServerInfo
        '
        Me.TreeViewServerInfo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeViewServerInfo.FullRowSelect = True
        Me.TreeViewServerInfo.ImageIndex = 0
        Me.TreeViewServerInfo.ImageList = Me.ImageListServerInfo
        Me.TreeViewServerInfo.Location = New System.Drawing.Point(12, 12)
        Me.TreeViewServerInfo.Name = "TreeViewServerInfo"
        TreeNode1.ImageIndex = 0
        TreeNode1.Name = "Node0"
        TreeNode1.SelectedImageIndex = 0
        TreeNode1.Text = "Processname: ??"
        TreeNode2.ImageIndex = 1
        TreeNode2.Name = "Node0"
        TreeNode2.SelectedImageIndex = 1
        TreeNode2.Text = "Memory Usage: ??"
        TreeNode3.ImageIndex = 2
        TreeNode3.Name = "Node1"
        TreeNode3.SelectedImageIndex = 2
        TreeNode3.Text = "Executable Path: ??"
        TreeNode4.ImageIndex = 3
        TreeNode4.Name = "Node2"
        TreeNode4.SelectedImageIndex = 3
        TreeNode4.Text = "Autostart at reboot: ??"
        TreeNode5.ImageIndex = 4
        TreeNode5.Name = "Node3"
        TreeNode5.SelectedImageIndex = 4
        TreeNode5.Text = "Unique ID: ??"
        TreeNode6.ImageIndex = 5
        TreeNode6.Name = "Node4"
        TreeNode6.SelectedImageIndex = 5
        TreeNode6.Text = "Protected Process: ??"
        TreeNode7.ImageIndex = 6
        TreeNode7.Name = "Node5"
        TreeNode7.SelectedImageIndex = 6
        TreeNode7.Text = "Privileges: ??"
        TreeNode8.ImageIndex = 7
        TreeNode8.Name = "Node7"
        TreeNode8.SelectedImageIndex = 7
        TreeNode8.Text = "Visible Mode: ??"
        TreeNode9.ImageIndex = 8
        TreeNode9.Name = "Node9"
        TreeNode9.SelectedImageIndex = 8
        TreeNode9.Text = "Hosting URL: ??"
        Me.TreeViewServerInfo.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Me.TreeViewServerInfo.SelectedImageIndex = 0
        Me.TreeViewServerInfo.Size = New System.Drawing.Size(289, 172)
        Me.TreeViewServerInfo.TabIndex = 0
        '
        'ImageListServerInfo
        '
        Me.ImageListServerInfo.ImageStream = CType(resources.GetObject("ImageListServerInfo.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListServerInfo.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListServerInfo.Images.SetKeyName(0, "table--pencil.png")
        Me.ImageListServerInfo.Images.SetKeyName(1, "system-monitor--pencil.png")
        Me.ImageListServerInfo.Images.SetKeyName(2, "folder.png")
        Me.ImageListServerInfo.Images.SetKeyName(3, "reload_icon.png")
        Me.ImageListServerInfo.Images.SetKeyName(4, "clipped_id.png")
        Me.ImageListServerInfo.Images.SetKeyName(5, "secure_icon.png")
        Me.ImageListServerInfo.Images.SetKeyName(6, "2493303.png")
        Me.ImageListServerInfo.Images.SetKeyName(7, "bug.png")
        Me.ImageListServerInfo.Images.SetKeyName(8, "globe_network.png")
        '
        'ButtonRefreshServerInfo
        '
        Me.ButtonRefreshServerInfo.Image = CType(resources.GetObject("ButtonRefreshServerInfo.Image"), System.Drawing.Image)
        Me.ButtonRefreshServerInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRefreshServerInfo.Location = New System.Drawing.Point(105, 191)
        Me.ButtonRefreshServerInfo.Name = "ButtonRefreshServerInfo"
        Me.ButtonRefreshServerInfo.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRefreshServerInfo.TabIndex = 1
        Me.ButtonRefreshServerInfo.Text = "Refresh"
        Me.ButtonRefreshServerInfo.UseVisualStyleBackColor = True
        '
        'Serverinformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 225)
        Me.Controls.Add(Me.ButtonRefreshServerInfo)
        Me.Controls.Add(Me.TreeViewServerInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Serverinformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Serverinformation"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeViewServerInfo As System.Windows.Forms.TreeView
    Friend WithEvents ButtonRefreshServerInfo As System.Windows.Forms.Button
    Friend WithEvents ImageListServerInfo As System.Windows.Forms.ImageList
End Class
