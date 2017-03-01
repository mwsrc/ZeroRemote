<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Filemanager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Filemanager))
        Me.ContextMenuStripLocal = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetFileinformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExecuteFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageListFilemanager = New System.Windows.Forms.ImageList(Me.components)
        Me.ListViewLocalFiles = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageListDrives = New System.Windows.Forms.ImageList(Me.components)
        Me.TextBoxLocalAdressBar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxRemoteAdressBar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListViewRemoteFiles = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStripRemote = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExecuteFileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonRemoteGo = New System.Windows.Forms.Button()
        Me.ButtonRefreshRemoteDrives = New System.Windows.Forms.Button()
        Me.ButtonLocalGo = New System.Windows.Forms.Button()
        Me.ButtonRefreshLocalDrives = New System.Windows.Forms.Button()
        Me.ComboBoxRemoteDrives = New Client.ImageComboBox()
        Me.ComboBoxLocalDrives = New Client.ImageComboBox()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripLocal.SuspendLayout()
        Me.ContextMenuStripRemote.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStripLocal
        '
        Me.ContextMenuStripLocal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteFolderToolStripMenuItem, Me.ShowFolderToolStripMenuItem, Me.RenameFolderToolStripMenuItem, Me.CreateFolderToolStripMenuItem, Me.DeleteFileToolStripMenuItem, Me.RenameFileToolStripMenuItem, Me.GetFileinformationToolStripMenuItem, Me.ExecuteFileToolStripMenuItem})
        Me.ContextMenuStripLocal.Name = "ContextMenuStrip2"
        Me.ContextMenuStripLocal.Size = New System.Drawing.Size(154, 180)
        '
        'DeleteFolderToolStripMenuItem
        '
        Me.DeleteFolderToolStripMenuItem.Image = CType(resources.GetObject("DeleteFolderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteFolderToolStripMenuItem.Name = "DeleteFolderToolStripMenuItem"
        Me.DeleteFolderToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.DeleteFolderToolStripMenuItem.Text = "Delete Folder"
        '
        'ShowFolderToolStripMenuItem
        '
        Me.ShowFolderToolStripMenuItem.Image = CType(resources.GetObject("ShowFolderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ShowFolderToolStripMenuItem.Name = "ShowFolderToolStripMenuItem"
        Me.ShowFolderToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ShowFolderToolStripMenuItem.Text = "Show Folder"
        '
        'RenameFolderToolStripMenuItem
        '
        Me.RenameFolderToolStripMenuItem.Image = CType(resources.GetObject("RenameFolderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RenameFolderToolStripMenuItem.Name = "RenameFolderToolStripMenuItem"
        Me.RenameFolderToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.RenameFolderToolStripMenuItem.Text = "Rename Folder"
        '
        'CreateFolderToolStripMenuItem
        '
        Me.CreateFolderToolStripMenuItem.Image = CType(resources.GetObject("CreateFolderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CreateFolderToolStripMenuItem.Name = "CreateFolderToolStripMenuItem"
        Me.CreateFolderToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.CreateFolderToolStripMenuItem.Text = "Create Folder"
        '
        'DeleteFileToolStripMenuItem
        '
        Me.DeleteFileToolStripMenuItem.Image = CType(resources.GetObject("DeleteFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteFileToolStripMenuItem.Name = "DeleteFileToolStripMenuItem"
        Me.DeleteFileToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.DeleteFileToolStripMenuItem.Text = "Delete File"
        '
        'RenameFileToolStripMenuItem
        '
        Me.RenameFileToolStripMenuItem.Image = CType(resources.GetObject("RenameFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RenameFileToolStripMenuItem.Name = "RenameFileToolStripMenuItem"
        Me.RenameFileToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.RenameFileToolStripMenuItem.Text = "Rename File"
        '
        'GetFileinformationToolStripMenuItem
        '
        Me.GetFileinformationToolStripMenuItem.Image = CType(resources.GetObject("GetFileinformationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GetFileinformationToolStripMenuItem.Name = "GetFileinformationToolStripMenuItem"
        Me.GetFileinformationToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.GetFileinformationToolStripMenuItem.Text = "Get Fileinfo"
        '
        'ExecuteFileToolStripMenuItem
        '
        Me.ExecuteFileToolStripMenuItem.Image = CType(resources.GetObject("ExecuteFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExecuteFileToolStripMenuItem.Name = "ExecuteFileToolStripMenuItem"
        Me.ExecuteFileToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ExecuteFileToolStripMenuItem.Text = "Execute File"
        '
        'ImageListFilemanager
        '
        Me.ImageListFilemanager.ImageStream = CType(resources.GetObject("ImageListFilemanager.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListFilemanager.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListFilemanager.Images.SetKeyName(0, "folder-horizontal.png")
        Me.ImageListFilemanager.Images.SetKeyName(1, "shell32_0000.png")
        Me.ImageListFilemanager.Images.SetKeyName(2, "shell32_0070.png")
        Me.ImageListFilemanager.Images.SetKeyName(3, "shell32_0069.png")
        Me.ImageListFilemanager.Images.SetKeyName(4, "msxml3_0000.png")
        Me.ImageListFilemanager.Images.SetKeyName(5, "shell32_0071.png")
        Me.ImageListFilemanager.Images.SetKeyName(6, "sud_0005.png")
        Me.ImageListFilemanager.Images.SetKeyName(7, "shell32_0116.png")
        Me.ImageListFilemanager.Images.SetKeyName(8, "shell32_0302.png")
        Me.ImageListFilemanager.Images.SetKeyName(9, "wmploc_0058.png")
        Me.ImageListFilemanager.Images.SetKeyName(10, "shell32_0072.png")
        Me.ImageListFilemanager.Images.SetKeyName(11, "regedit_0001.png")
        Me.ImageListFilemanager.Images.SetKeyName(12, "folder-zipper.png")
        Me.ImageListFilemanager.Images.SetKeyName(13, "icon.png")
        '
        'ListViewLocalFiles
        '
        Me.ListViewLocalFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListViewLocalFiles.ContextMenuStrip = Me.ContextMenuStripLocal
        Me.ListViewLocalFiles.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewLocalFiles.FullRowSelect = True
        Me.ListViewLocalFiles.Location = New System.Drawing.Point(12, 65)
        Me.ListViewLocalFiles.MultiSelect = False
        Me.ListViewLocalFiles.Name = "ListViewLocalFiles"
        Me.ListViewLocalFiles.Size = New System.Drawing.Size(292, 295)
        Me.ListViewLocalFiles.SmallImageList = Me.ImageListFilemanager
        Me.ListViewLocalFiles.TabIndex = 1
        Me.ListViewLocalFiles.UseCompatibleStateImageBehavior = False
        Me.ListViewLocalFiles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 147
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Size"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date"
        Me.ColumnHeader3.Width = 81
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Local Drives:"
        '
        'ImageListDrives
        '
        Me.ImageListDrives.ImageStream = CType(resources.GetObject("ImageListDrives.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListDrives.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListDrives.Images.SetKeyName(0, "drive.png")
        Me.ImageListDrives.Images.SetKeyName(1, "drive-disc.png")
        Me.ImageListDrives.Images.SetKeyName(2, "drive-network.png")
        Me.ImageListDrives.Images.SetKeyName(3, "drive-share.png")
        Me.ImageListDrives.Images.SetKeyName(4, "usb-flash-drive--arrow.png")
        '
        'TextBoxLocalAdressBar
        '
        Me.TextBoxLocalAdressBar.Location = New System.Drawing.Point(12, 12)
        Me.TextBoxLocalAdressBar.Name = "TextBoxLocalAdressBar"
        Me.TextBoxLocalAdressBar.ReadOnly = True
        Me.TextBoxLocalAdressBar.Size = New System.Drawing.Size(260, 20)
        Me.TextBoxLocalAdressBar.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(105, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 14)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Local Machine"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(435, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 14)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Remote Machine"
        '
        'TextBoxRemoteAdressBar
        '
        Me.TextBoxRemoteAdressBar.Location = New System.Drawing.Point(342, 12)
        Me.TextBoxRemoteAdressBar.Name = "TextBoxRemoteAdressBar"
        Me.TextBoxRemoteAdressBar.ReadOnly = True
        Me.TextBoxRemoteAdressBar.Size = New System.Drawing.Size(260, 20)
        Me.TextBoxRemoteAdressBar.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(342, 371)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Remote Drives:"
        '
        'ListViewRemoteFiles
        '
        Me.ListViewRemoteFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListViewRemoteFiles.ContextMenuStrip = Me.ContextMenuStripRemote
        Me.ListViewRemoteFiles.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewRemoteFiles.FullRowSelect = True
        Me.ListViewRemoteFiles.Location = New System.Drawing.Point(342, 65)
        Me.ListViewRemoteFiles.MultiSelect = False
        Me.ListViewRemoteFiles.Name = "ListViewRemoteFiles"
        Me.ListViewRemoteFiles.Size = New System.Drawing.Size(292, 295)
        Me.ListViewRemoteFiles.SmallImageList = Me.ImageListFilemanager
        Me.ListViewRemoteFiles.TabIndex = 10
        Me.ListViewRemoteFiles.UseCompatibleStateImageBehavior = False
        Me.ListViewRemoteFiles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Name"
        Me.ColumnHeader4.Width = 146
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Size"
        Me.ColumnHeader5.Width = 64
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Date"
        Me.ColumnHeader6.Width = 78
        '
        'ContextMenuStripRemote
        '
        Me.ContextMenuStripRemote.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ExecuteFileToolStripMenuItem1})
        Me.ContextMenuStripRemote.Name = "ContextMenuStrip2"
        Me.ContextMenuStripRemote.Size = New System.Drawing.Size(154, 202)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.ToolStripMenuItem1.Text = "Delete Folder"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(153, 22)
        Me.ToolStripMenuItem2.Text = "Show Folder"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(153, 22)
        Me.ToolStripMenuItem4.Text = "Create Folder"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Image = CType(resources.GetObject("ToolStripMenuItem5.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(153, 22)
        Me.ToolStripMenuItem5.Text = "Delete File"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Image = CType(resources.GetObject("ToolStripMenuItem6.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(153, 22)
        Me.ToolStripMenuItem6.Text = "Download File"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Image = CType(resources.GetObject("ToolStripMenuItem8.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(153, 22)
        Me.ToolStripMenuItem8.Text = "Rename File"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Image = CType(resources.GetObject("ToolStripMenuItem9.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(153, 22)
        Me.ToolStripMenuItem9.Text = "Get Fileinfo"
        '
        'ExecuteFileToolStripMenuItem1
        '
        Me.ExecuteFileToolStripMenuItem1.Image = CType(resources.GetObject("ExecuteFileToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ExecuteFileToolStripMenuItem1.Name = "ExecuteFileToolStripMenuItem1"
        Me.ExecuteFileToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.ExecuteFileToolStripMenuItem1.Text = "Execute File"
        '
        'ButtonRemoteGo
        '
        Me.ButtonRemoteGo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemoteGo.Image = CType(resources.GetObject("ButtonRemoteGo.Image"), System.Drawing.Image)
        Me.ButtonRemoteGo.Location = New System.Drawing.Point(608, 10)
        Me.ButtonRemoteGo.Name = "ButtonRemoteGo"
        Me.ButtonRemoteGo.Size = New System.Drawing.Size(27, 23)
        Me.ButtonRemoteGo.TabIndex = 15
        Me.ButtonRemoteGo.UseVisualStyleBackColor = True
        '
        'ButtonRefreshRemoteDrives
        '
        Me.ButtonRefreshRemoteDrives.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefreshRemoteDrives.Image = CType(resources.GetObject("ButtonRefreshRemoteDrives.Image"), System.Drawing.Image)
        Me.ButtonRefreshRemoteDrives.Location = New System.Drawing.Point(607, 366)
        Me.ButtonRefreshRemoteDrives.Name = "ButtonRefreshRemoteDrives"
        Me.ButtonRefreshRemoteDrives.Size = New System.Drawing.Size(27, 23)
        Me.ButtonRefreshRemoteDrives.TabIndex = 12
        Me.ButtonRefreshRemoteDrives.UseVisualStyleBackColor = True
        '
        'ButtonLocalGo
        '
        Me.ButtonLocalGo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLocalGo.Image = CType(resources.GetObject("ButtonLocalGo.Image"), System.Drawing.Image)
        Me.ButtonLocalGo.Location = New System.Drawing.Point(278, 10)
        Me.ButtonLocalGo.Name = "ButtonLocalGo"
        Me.ButtonLocalGo.Size = New System.Drawing.Size(27, 23)
        Me.ButtonLocalGo.TabIndex = 8
        Me.ButtonLocalGo.UseVisualStyleBackColor = True
        '
        'ButtonRefreshLocalDrives
        '
        Me.ButtonRefreshLocalDrives.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefreshLocalDrives.Image = CType(resources.GetObject("ButtonRefreshLocalDrives.Image"), System.Drawing.Image)
        Me.ButtonRefreshLocalDrives.Location = New System.Drawing.Point(277, 366)
        Me.ButtonRefreshLocalDrives.Name = "ButtonRefreshLocalDrives"
        Me.ButtonRefreshLocalDrives.Size = New System.Drawing.Size(27, 23)
        Me.ButtonRefreshLocalDrives.TabIndex = 4
        Me.ButtonRefreshLocalDrives.UseVisualStyleBackColor = True
        '
        'ComboBoxRemoteDrives
        '
        Me.ComboBoxRemoteDrives.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxRemoteDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRemoteDrives.FormattingEnabled = True
        Me.ComboBoxRemoteDrives.ImageList = Me.ImageListDrives
        Me.ComboBoxRemoteDrives.Location = New System.Drawing.Point(445, 368)
        Me.ComboBoxRemoteDrives.Name = "ComboBoxRemoteDrives"
        Me.ComboBoxRemoteDrives.Size = New System.Drawing.Size(145, 21)
        Me.ComboBoxRemoteDrives.TabIndex = 13
        '
        'ComboBoxLocalDrives
        '
        Me.ComboBoxLocalDrives.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxLocalDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxLocalDrives.FormattingEnabled = True
        Me.ComboBoxLocalDrives.ImageList = Me.ImageListDrives
        Me.ComboBoxLocalDrives.Location = New System.Drawing.Point(107, 368)
        Me.ComboBoxLocalDrives.Name = "ComboBoxLocalDrives"
        Me.ComboBoxLocalDrives.Size = New System.Drawing.Size(153, 21)
        Me.ComboBoxLocalDrives.TabIndex = 5
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(153, 22)
        Me.ToolStripMenuItem3.Text = "Rename Folder"
        '
        'Filemanager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 400)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonRemoteGo)
        Me.Controls.Add(Me.TextBoxRemoteAdressBar)
        Me.Controls.Add(Me.ComboBoxRemoteDrives)
        Me.Controls.Add(Me.ButtonRefreshRemoteDrives)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListViewRemoteFiles)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonLocalGo)
        Me.Controls.Add(Me.TextBoxLocalAdressBar)
        Me.Controls.Add(Me.ComboBoxLocalDrives)
        Me.Controls.Add(Me.ButtonRefreshLocalDrives)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListViewLocalFiles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Filemanager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Filemanager"
        Me.TopMost = True
        Me.ContextMenuStripLocal.ResumeLayout(False)
        Me.ContextMenuStripRemote.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListViewLocalFiles As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonRefreshLocalDrives As System.Windows.Forms.Button
    Friend WithEvents ImageListDrives As System.Windows.Forms.ImageList
    Friend WithEvents ComboBoxLocalDrives As Client.ImageComboBox
    Friend WithEvents ContextMenuStripLocal As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ImageListFilemanager As System.Windows.Forms.ImageList
    Friend WithEvents DeleteFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBoxLocalAdressBar As System.Windows.Forms.TextBox
    Friend WithEvents ButtonLocalGo As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonRemoteGo As System.Windows.Forms.Button
    Friend WithEvents TextBoxRemoteAdressBar As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxRemoteDrives As Client.ImageComboBox
    Friend WithEvents ButtonRefreshRemoteDrives As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListViewRemoteFiles As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ShowFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenameFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenameFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetFileinformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripRemote As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExecuteFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExecuteFileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
End Class
