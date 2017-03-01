<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.RichTextBoxTOS = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CheckBoxShowNotification = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBoxautorefresh = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListViewHosts = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageListWerbservers = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ListViewLogs = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageListLogs = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.ImageListSettings = New System.Windows.Forms.ImageList(Me.components)
        Me.GraphConnections = New Client.Graph()
        Me.CheckBoxCommandConfirmationMessageBox = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ImageList = Me.ImageListSettings
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(408, 253)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.RichTextBoxTOS)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(400, 226)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TOS"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'RichTextBoxTOS
        '
        Me.RichTextBoxTOS.BackColor = System.Drawing.Color.White
        Me.RichTextBoxTOS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxTOS.Location = New System.Drawing.Point(8, 6)
        Me.RichTextBoxTOS.Name = "RichTextBoxTOS"
        Me.RichTextBoxTOS.ReadOnly = True
        Me.RichTextBoxTOS.Size = New System.Drawing.Size(382, 211)
        Me.RichTextBoxTOS.TabIndex = 0
        Me.RichTextBoxTOS.Text = resources.GetString("RichTextBoxTOS.Text")
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CheckBoxCommandConfirmationMessageBox)
        Me.TabPage2.Controls.Add(Me.CheckBoxShowNotification)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.CheckBoxautorefresh)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.ImageIndex = 1
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(400, 226)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CheckBoxShowNotification
        '
        Me.CheckBoxShowNotification.AutoSize = True
        Me.CheckBoxShowNotification.Checked = True
        Me.CheckBoxShowNotification.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxShowNotification.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxShowNotification.Location = New System.Drawing.Point(23, 121)
        Me.CheckBoxShowNotification.Name = "CheckBoxShowNotification"
        Me.CheckBoxShowNotification.Size = New System.Drawing.Size(233, 17)
        Me.CheckBoxShowNotification.TabIndex = 4
        Me.CheckBoxShowNotification.Text = "Show notification on new connection"
        Me.CheckBoxShowNotification.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(20, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Userinterface Settings:"
        '
        'CheckBoxautorefresh
        '
        Me.CheckBoxautorefresh.AutoSize = True
        Me.CheckBoxautorefresh.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxautorefresh.Location = New System.Drawing.Point(23, 46)
        Me.CheckBoxautorefresh.Name = "CheckBoxautorefresh"
        Me.CheckBoxautorefresh.Size = New System.Drawing.Size(198, 17)
        Me.CheckBoxautorefresh.TabIndex = 2
        Me.CheckBoxautorefresh.Text = "Autorefresh every 30 seconds"
        Me.CheckBoxautorefresh.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(20, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Connection Settings"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.ListViewHosts)
        Me.TabPage3.ImageIndex = 2
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(400, 226)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Hosts"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(211, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Remove Host"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(75, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add Host"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(40, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(328, 26)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Add a new host which will be used to communicate with " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the servers on the remote" & _
    " systems."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListViewHosts
        '
        Me.ListViewHosts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5})
        Me.ListViewHosts.FullRowSelect = True
        Me.ListViewHosts.Location = New System.Drawing.Point(75, 53)
        Me.ListViewHosts.MultiSelect = False
        Me.ListViewHosts.Name = "ListViewHosts"
        Me.ListViewHosts.Size = New System.Drawing.Size(256, 116)
        Me.ListViewHosts.SmallImageList = Me.ImageListWerbservers
        Me.ListViewHosts.TabIndex = 0
        Me.ListViewHosts.UseCompatibleStateImageBehavior = False
        Me.ListViewHosts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Webhosts"
        Me.ColumnHeader5.Width = 252
        '
        'ImageListWerbservers
        '
        Me.ImageListWerbservers.ImageStream = CType(resources.GetObject("ImageListWerbservers.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListWerbservers.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListWerbservers.Images.SetKeyName(0, "globe.png")
        Me.ImageListWerbservers.Images.SetKeyName(1, "servers.png")
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ListViewLogs)
        Me.TabPage4.ImageIndex = 3
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(400, 226)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Logs"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ListViewLogs
        '
        Me.ListViewLogs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListViewLogs.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewLogs.FullRowSelect = True
        Me.ListViewLogs.Location = New System.Drawing.Point(8, 8)
        Me.ListViewLogs.Name = "ListViewLogs"
        Me.ListViewLogs.Size = New System.Drawing.Size(382, 209)
        Me.ListViewLogs.SmallImageList = Me.ImageListLogs
        Me.ListViewLogs.TabIndex = 0
        Me.ListViewLogs.UseCompatibleStateImageBehavior = False
        Me.ListViewLogs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Status"
        Me.ColumnHeader1.Width = 88
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Time"
        Me.ColumnHeader2.Width = 82
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Description"
        Me.ColumnHeader3.Width = 208
        '
        'ImageListLogs
        '
        Me.ImageListLogs.ImageStream = CType(resources.GetObject("ImageListLogs.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListLogs.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListLogs.Images.SetKeyName(0, "tick-button.png")
        Me.ImageListLogs.Images.SetKeyName(1, "minus-button.png")
        Me.ImageListLogs.Images.SetKeyName(2, "information-button.png")
        Me.ImageListLogs.Images.SetKeyName(3, "exclamation-button.png")
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GraphConnections)
        Me.TabPage5.ImageIndex = 4
        Me.TabPage5.Location = New System.Drawing.Point(4, 23)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(400, 226)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Statistics"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'ImageListSettings
        '
        Me.ImageListSettings.ImageStream = CType(resources.GetObject("ImageListSettings.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListSettings.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListSettings.Images.SetKeyName(0, "auction-hammer-gavel.png")
        Me.ImageListSettings.Images.SetKeyName(1, "globe-network.png")
        Me.ImageListSettings.Images.SetKeyName(2, "server-property.png")
        Me.ImageListSettings.Images.SetKeyName(3, "book-open-text-image.png")
        Me.ImageListSettings.Images.SetKeyName(4, "chart--pencil.png")
        '
        'GraphConnections
        '
        Me.GraphConnections.BorderColor = System.Drawing.Color.Gray
        Me.GraphConnections.DataColumnForeColor = System.Drawing.Color.Gray
        Me.GraphConnections.DataSmoothing = False
        Me.GraphConnections.DataSmoothingLevel = CType(2, Byte)
        Me.GraphConnections.DrawDataColumn = True
        Me.GraphConnections.DrawHorizontalLines = True
        Me.GraphConnections.DrawHoverData = True
        Me.GraphConnections.DrawHoverLine = True
        Me.GraphConnections.DrawLineGraph = False
        Me.GraphConnections.DrawVerticalLines = False
        Me.GraphConnections.FillColor = System.Drawing.Color.White
        Me.GraphConnections.GraphBorderColor = System.Drawing.Color.ForestGreen
        Me.GraphConnections.GraphFillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.GraphConnections.HorizontalLineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.GraphConnections.HoverBorderColor = System.Drawing.Color.ForestGreen
        Me.GraphConnections.HoverFillColor = System.Drawing.Color.White
        Me.GraphConnections.HoverLabelBorderColor = System.Drawing.Color.DarkGray
        Me.GraphConnections.HoverLabelFillColor = System.Drawing.Color.White
        Me.GraphConnections.HoverLabelForeColor = System.Drawing.Color.Gray
        Me.GraphConnections.HoverLabelShadowColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GraphConnections.HoverLineColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GraphConnections.LineGraphColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GraphConnections.Location = New System.Drawing.Point(13, 12)
        Me.GraphConnections.Name = "GraphConnections"
        Me.GraphConnections.OverrideMax = False
        Me.GraphConnections.OverrideMaxValue = 100.0!
        Me.GraphConnections.OverrideMin = False
        Me.GraphConnections.OverrideMinValue = 0.0!
        Me.GraphConnections.SidePadding = True
        Me.GraphConnections.Size = New System.Drawing.Size(377, 205)
        Me.GraphConnections.TabIndex = 0
        Me.GraphConnections.Text = "Graph1"
        Me.GraphConnections.Values = New Single(-1) {}
        Me.GraphConnections.VerticalLineColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        'CheckBoxCommandConfirmationMessageBox
        '
        Me.CheckBoxCommandConfirmationMessageBox.AutoSize = True
        Me.CheckBoxCommandConfirmationMessageBox.Location = New System.Drawing.Point(23, 144)
        Me.CheckBoxCommandConfirmationMessageBox.Name = "CheckBoxCommandConfirmationMessageBox"
        Me.CheckBoxCommandConfirmationMessageBox.Size = New System.Drawing.Size(252, 17)
        Me.CheckBoxCommandConfirmationMessageBox.TabIndex = 5
        Me.CheckBoxCommandConfirmationMessageBox.Text = "Show success messages for commands"
        Me.CheckBoxCommandConfirmationMessageBox.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 252)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBoxTOS As System.Windows.Forms.RichTextBox
    Friend WithEvents CheckBoxautorefresh As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ImageListSettings As System.Windows.Forms.ImageList
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents GraphConnections As Client.Graph
    Friend WithEvents ListViewLogs As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageListLogs As System.Windows.Forms.ImageList
    Friend WithEvents CheckBoxShowNotification As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListViewHosts As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ImageListWerbservers As System.Windows.Forms.ImageList
    Friend WithEvents CheckBoxCommandConfirmationMessageBox As System.Windows.Forms.CheckBox
End Class
