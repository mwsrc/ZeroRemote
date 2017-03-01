<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Networkviewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Networkviewer))
        Me.ButtonGetConnections = New System.Windows.Forms.Button()
        Me.ListViewConnections = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageListTraffic = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelTCPCount = New System.Windows.Forms.Label()
        Me.LabelUDPCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonGetConnections
        '
        Me.ButtonGetConnections.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGetConnections.Image = CType(resources.GetObject("ButtonGetConnections.Image"), System.Drawing.Image)
        Me.ButtonGetConnections.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonGetConnections.Location = New System.Drawing.Point(12, 234)
        Me.ButtonGetConnections.Name = "ButtonGetConnections"
        Me.ButtonGetConnections.Size = New System.Drawing.Size(159, 23)
        Me.ButtonGetConnections.TabIndex = 0
        Me.ButtonGetConnections.Text = "Get active connections"
        Me.ButtonGetConnections.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonGetConnections.UseVisualStyleBackColor = True
        '
        'ListViewConnections
        '
        Me.ListViewConnections.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListViewConnections.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewConnections.FullRowSelect = True
        Me.ListViewConnections.Location = New System.Drawing.Point(12, 11)
        Me.ListViewConnections.Name = "ListViewConnections"
        Me.ListViewConnections.Size = New System.Drawing.Size(458, 215)
        Me.ListViewConnections.SmallImageList = Me.ImageListTraffic
        Me.ListViewConnections.TabIndex = 1
        Me.ListViewConnections.UseCompatibleStateImageBehavior = False
        Me.ListViewConnections.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Protocol"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Local Endpoint"
        Me.ColumnHeader2.Width = 105
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Remote Endpoint"
        Me.ColumnHeader3.Width = 128
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Connection State"
        Me.ColumnHeader4.Width = 108
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "PID"
        Me.ColumnHeader5.Width = 53
        '
        'ImageListTraffic
        '
        Me.ImageListTraffic.ImageStream = CType(resources.GetObject("ImageListTraffic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListTraffic.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListTraffic.Images.SetKeyName(0, "network-ethernet.png")
        Me.ImageListTraffic.Images.SetKeyName(1, "network-hub.png")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(177, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TCP Connections: "
        '
        'LabelTCPCount
        '
        Me.LabelTCPCount.AutoSize = True
        Me.LabelTCPCount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTCPCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelTCPCount.Location = New System.Drawing.Point(294, 239)
        Me.LabelTCPCount.Name = "LabelTCPCount"
        Me.LabelTCPCount.Size = New System.Drawing.Size(14, 13)
        Me.LabelTCPCount.TabIndex = 3
        Me.LabelTCPCount.Text = "0"
        '
        'LabelUDPCount
        '
        Me.LabelUDPCount.AutoSize = True
        Me.LabelUDPCount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUDPCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelUDPCount.Location = New System.Drawing.Point(447, 239)
        Me.LabelUDPCount.Name = "LabelUDPCount"
        Me.LabelUDPCount.Size = New System.Drawing.Size(14, 13)
        Me.LabelUDPCount.TabIndex = 5
        Me.LabelUDPCount.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(325, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "UDP Connections: "
        '
        'Networkviewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 263)
        Me.Controls.Add(Me.LabelUDPCount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelTCPCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListViewConnections)
        Me.Controls.Add(Me.ButtonGetConnections)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Networkviewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Networkviewer"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonGetConnections As System.Windows.Forms.Button
    Friend WithEvents ListViewConnections As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageListTraffic As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelTCPCount As System.Windows.Forms.Label
    Friend WithEvents LabelUDPCount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
