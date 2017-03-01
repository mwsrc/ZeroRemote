<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Systeminformation
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Username: ??")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Computername: ??", 1, 1)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Operating System: ??", 2, 2)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Country: ??", 3, 3)
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Privileges: ??", 4, 4)
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Screen Resolution: ??", 5, 5)
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bitsystem: ??", 6, 6)
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("RAM: ??", 7, 7)
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Processor: ??", 8, 8)
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Graphics Card: ??", 9, 9)
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Time Since Last Reboot: ??", 10, 10)
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("AntiVirus Software: ??", 11, 11)
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Firewall Software: ??", 12, 12)
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Webcam: ??", 13, 13)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Systeminformation))
        Me.TreeViewSysInfo = New System.Windows.Forms.TreeView()
        Me.ImageListSysInfo = New System.Windows.Forms.ImageList(Me.components)
        Me.ButtonRefreshSystemInfo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TreeViewSysInfo
        '
        Me.TreeViewSysInfo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeViewSysInfo.FullRowSelect = True
        Me.TreeViewSysInfo.ImageIndex = 0
        Me.TreeViewSysInfo.ImageList = Me.ImageListSysInfo
        Me.TreeViewSysInfo.Location = New System.Drawing.Point(12, 12)
        Me.TreeViewSysInfo.Name = "TreeViewSysInfo"
        TreeNode1.Name = "Node0"
        TreeNode1.Text = "Username: ??"
        TreeNode2.ImageIndex = 1
        TreeNode2.Name = "Node1"
        TreeNode2.SelectedImageIndex = 1
        TreeNode2.Text = "Computername: ??"
        TreeNode3.ImageIndex = 2
        TreeNode3.Name = "Node2"
        TreeNode3.SelectedImageIndex = 2
        TreeNode3.Text = "Operating System: ??"
        TreeNode4.ImageIndex = 3
        TreeNode4.Name = "Node3"
        TreeNode4.SelectedImageIndex = 3
        TreeNode4.Text = "Country: ??"
        TreeNode5.ImageIndex = 4
        TreeNode5.Name = "Node4"
        TreeNode5.SelectedImageIndex = 4
        TreeNode5.Text = "Privileges: ??"
        TreeNode6.ImageIndex = 5
        TreeNode6.Name = "Node5"
        TreeNode6.SelectedImageIndex = 5
        TreeNode6.Text = "Screen Resolution: ??"
        TreeNode7.ImageIndex = 6
        TreeNode7.Name = "Node6"
        TreeNode7.SelectedImageIndex = 6
        TreeNode7.Text = "Bitsystem: ??"
        TreeNode8.ImageIndex = 7
        TreeNode8.Name = "Node8"
        TreeNode8.SelectedImageIndex = 7
        TreeNode8.Text = "RAM: ??"
        TreeNode9.ImageIndex = 8
        TreeNode9.Name = "Node9"
        TreeNode9.SelectedImageIndex = 8
        TreeNode9.Text = "Processor: ??"
        TreeNode10.ImageIndex = 9
        TreeNode10.Name = "Node10"
        TreeNode10.SelectedImageIndex = 9
        TreeNode10.Text = "Graphics Card: ??"
        TreeNode11.ImageIndex = 10
        TreeNode11.Name = "Node11"
        TreeNode11.SelectedImageIndex = 10
        TreeNode11.Text = "Time Since Last Reboot: ??"
        TreeNode12.ImageIndex = 11
        TreeNode12.Name = "Node12"
        TreeNode12.SelectedImageIndex = 11
        TreeNode12.Text = "AntiVirus Software: ??"
        TreeNode13.ImageIndex = 12
        TreeNode13.Name = "Node13"
        TreeNode13.SelectedImageIndex = 12
        TreeNode13.Text = "Firewall Software: ??"
        TreeNode14.ImageIndex = 13
        TreeNode14.Name = "Node14"
        TreeNode14.SelectedImageIndex = 13
        TreeNode14.Text = "Webcam: ??"
        Me.TreeViewSysInfo.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14})
        Me.TreeViewSysInfo.SelectedImageIndex = 0
        Me.TreeViewSysInfo.Size = New System.Drawing.Size(308, 249)
        Me.TreeViewSysInfo.TabIndex = 0
        '
        'ImageListSysInfo
        '
        Me.ImageListSysInfo.ImageStream = CType(resources.GetObject("ImageListSysInfo.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListSysInfo.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListSysInfo.Images.SetKeyName(0, "user.png")
        Me.ImageListSysInfo.Images.SetKeyName(1, "computer.png")
        Me.ImageListSysInfo.Images.SetKeyName(2, "windows.png")
        Me.ImageListSysInfo.Images.SetKeyName(3, "locale-alternate.png")
        Me.ImageListSysInfo.Images.SetKeyName(4, "05.gif")
        Me.ImageListSysInfo.Images.SetKeyName(5, "monitor.png")
        Me.ImageListSysInfo.Images.SetKeyName(6, "icon_ram.png")
        Me.ImageListSysInfo.Images.SetKeyName(7, "system-monitor--pencil.png")
        Me.ImageListSysInfo.Images.SetKeyName(8, "processor.png")
        Me.ImageListSysInfo.Images.SetKeyName(9, "video.png")
        Me.ImageListSysInfo.Images.SetKeyName(10, "clock.png")
        Me.ImageListSysInfo.Images.SetKeyName(11, "shield.png")
        Me.ImageListSysInfo.Images.SetKeyName(12, "wall-brick.png")
        Me.ImageListSysInfo.Images.SetKeyName(13, "webcam.png")
        '
        'ButtonRefreshSystemInfo
        '
        Me.ButtonRefreshSystemInfo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefreshSystemInfo.Image = CType(resources.GetObject("ButtonRefreshSystemInfo.Image"), System.Drawing.Image)
        Me.ButtonRefreshSystemInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRefreshSystemInfo.Location = New System.Drawing.Point(109, 267)
        Me.ButtonRefreshSystemInfo.Name = "ButtonRefreshSystemInfo"
        Me.ButtonRefreshSystemInfo.Size = New System.Drawing.Size(103, 23)
        Me.ButtonRefreshSystemInfo.TabIndex = 1
        Me.ButtonRefreshSystemInfo.Text = "Refresh"
        Me.ButtonRefreshSystemInfo.UseVisualStyleBackColor = True
        '
        'Systeminformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 297)
        Me.Controls.Add(Me.ButtonRefreshSystemInfo)
        Me.Controls.Add(Me.TreeViewSysInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Systeminformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Systeminformation"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeViewSysInfo As System.Windows.Forms.TreeView
    Friend WithEvents ButtonRefreshSystemInfo As System.Windows.Forms.Button
    Friend WithEvents ImageListSysInfo As System.Windows.Forms.ImageList
End Class
