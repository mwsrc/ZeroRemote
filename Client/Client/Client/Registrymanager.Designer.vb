<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrymanager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrymanager))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ListViewRegistryValue = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStripRegistry = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CreateRegistryvalueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteRegistryvalueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyRegistryvalueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageListRegistry = New System.Windows.Forms.ImageList(Me.components)
        Me.ListViewRegistrykey = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LabelCurrentPath = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ButtonGo = New System.Windows.Forms.Button()
        Me.ContextMenuStripRegistry.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"HKEY_CLASSES_ROOT", "HKEY_CURRENT_USER", "HKEY_LOCAL_MACHINE", "HKEY_USERS", "HKEY_CURRENT_CONFIG"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 13)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(167, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'ListViewRegistryValue
        '
        Me.ListViewRegistryValue.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListViewRegistryValue.ContextMenuStrip = Me.ContextMenuStripRegistry
        Me.ListViewRegistryValue.FullRowSelect = True
        Me.ListViewRegistryValue.Location = New System.Drawing.Point(216, 12)
        Me.ListViewRegistryValue.Name = "ListViewRegistryValue"
        Me.ListViewRegistryValue.Size = New System.Drawing.Size(287, 245)
        Me.ListViewRegistryValue.SmallImageList = Me.ImageListRegistry
        Me.ListViewRegistryValue.TabIndex = 2
        Me.ListViewRegistryValue.UseCompatibleStateImageBehavior = False
        Me.ListViewRegistryValue.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 112
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Type"
        Me.ColumnHeader2.Width = 69
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Value"
        Me.ColumnHeader3.Width = 102
        '
        'ContextMenuStripRegistry
        '
        Me.ContextMenuStripRegistry.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateRegistryvalueToolStripMenuItem, Me.DeleteRegistryvalueToolStripMenuItem, Me.ModifyRegistryvalueToolStripMenuItem})
        Me.ContextMenuStripRegistry.Name = "ContextMenuStripRegistry"
        Me.ContextMenuStripRegistry.Size = New System.Drawing.Size(186, 70)
        '
        'CreateRegistryvalueToolStripMenuItem
        '
        Me.CreateRegistryvalueToolStripMenuItem.Image = CType(resources.GetObject("CreateRegistryvalueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CreateRegistryvalueToolStripMenuItem.Name = "CreateRegistryvalueToolStripMenuItem"
        Me.CreateRegistryvalueToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.CreateRegistryvalueToolStripMenuItem.Text = "Create Registryvalue"
        '
        'DeleteRegistryvalueToolStripMenuItem
        '
        Me.DeleteRegistryvalueToolStripMenuItem.Image = CType(resources.GetObject("DeleteRegistryvalueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteRegistryvalueToolStripMenuItem.Name = "DeleteRegistryvalueToolStripMenuItem"
        Me.DeleteRegistryvalueToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.DeleteRegistryvalueToolStripMenuItem.Text = "Delete Registryvalue"
        '
        'ModifyRegistryvalueToolStripMenuItem
        '
        Me.ModifyRegistryvalueToolStripMenuItem.Image = CType(resources.GetObject("ModifyRegistryvalueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ModifyRegistryvalueToolStripMenuItem.Name = "ModifyRegistryvalueToolStripMenuItem"
        Me.ModifyRegistryvalueToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ModifyRegistryvalueToolStripMenuItem.Text = "Modify Registryvalue"
        '
        'ImageListRegistry
        '
        Me.ImageListRegistry.ImageStream = CType(resources.GetObject("ImageListRegistry.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListRegistry.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListRegistry.Images.SetKeyName(0, "regedit_205.png")
        Me.ImageListRegistry.Images.SetKeyName(1, "regedit_206.png")
        Me.ImageListRegistry.Images.SetKeyName(2, "folder-horizontal.png")
        Me.ImageListRegistry.Images.SetKeyName(3, "arrow-180.png")
        '
        'ListViewRegistrykey
        '
        Me.ListViewRegistrykey.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4})
        Me.ListViewRegistrykey.FullRowSelect = True
        Me.ListViewRegistrykey.Location = New System.Drawing.Point(12, 49)
        Me.ListViewRegistrykey.Name = "ListViewRegistrykey"
        Me.ListViewRegistrykey.Size = New System.Drawing.Size(198, 209)
        Me.ListViewRegistrykey.SmallImageList = Me.ImageListRegistry
        Me.ListViewRegistrykey.TabIndex = 3
        Me.ListViewRegistrykey.UseCompatibleStateImageBehavior = False
        Me.ListViewRegistrykey.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Key"
        Me.ColumnHeader4.Width = 194
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelCurrentPath})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 263)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(515, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LabelCurrentPath
        '
        Me.LabelCurrentPath.Name = "LabelCurrentPath"
        Me.LabelCurrentPath.Size = New System.Drawing.Size(0, 17)
        '
        'ButtonGo
        '
        Me.ButtonGo.Image = CType(resources.GetObject("ButtonGo.Image"), System.Drawing.Image)
        Me.ButtonGo.Location = New System.Drawing.Point(185, 12)
        Me.ButtonGo.Name = "ButtonGo"
        Me.ButtonGo.Size = New System.Drawing.Size(25, 23)
        Me.ButtonGo.TabIndex = 1
        Me.ButtonGo.UseVisualStyleBackColor = True
        '
        'Registrymanager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 285)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ListViewRegistrykey)
        Me.Controls.Add(Me.ListViewRegistryValue)
        Me.Controls.Add(Me.ButtonGo)
        Me.Controls.Add(Me.ComboBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Registrymanager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registrymanager"
        Me.TopMost = True
        Me.ContextMenuStripRegistry.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonGo As System.Windows.Forms.Button
    Friend WithEvents ListViewRegistryValue As System.Windows.Forms.ListView
    Friend WithEvents ListViewRegistrykey As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageListRegistry As System.Windows.Forms.ImageList
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LabelCurrentPath As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ContextMenuStripRegistry As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CreateRegistryvalueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteRegistryvalueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyRegistryvalueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
