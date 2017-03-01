<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Downloadmanager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Downloadmanager))
        Me.TextBoxDownloadLink = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxDownloadLocation = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxDownloadLink
        '
        Me.TextBoxDownloadLink.Location = New System.Drawing.Point(22, 71)
        Me.TextBoxDownloadLink.Name = "TextBoxDownloadLink"
        Me.TextBoxDownloadLink.Size = New System.Drawing.Size(354, 20)
        Me.TextBoxDownloadLink.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Download and execute a binary file to the remote computer." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Make sure you notify " & _
    "your client when you use this feature."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Downloadlink : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Downlocation on remote computer :"
        '
        'ComboBoxDownloadLocation
        '
        Me.ComboBoxDownloadLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDownloadLocation.FormattingEnabled = True
        Me.ComboBoxDownloadLocation.Items.AddRange(New Object() {"AppData", "Temp", "Desktop"})
        Me.ComboBoxDownloadLocation.Location = New System.Drawing.Point(238, 100)
        Me.ComboBoxDownloadLocation.Name = "ComboBoxDownloadLocation"
        Me.ComboBoxDownloadLocation.Size = New System.Drawing.Size(138, 21)
        Me.ComboBoxDownloadLocation.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(22, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Send Request"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Downloadmanager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 167)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBoxDownloadLocation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxDownloadLink)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Downloadmanager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Downloadmanager"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxDownloadLink As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDownloadLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
