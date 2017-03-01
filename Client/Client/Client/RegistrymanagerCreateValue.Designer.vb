<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrymanagerCreateValue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrymanagerCreateValue))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxRegistryName = New System.Windows.Forms.TextBox()
        Me.TextBoxRegistryData = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registryvalue name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Registryvalue data:"
        '
        'TextBoxRegistryName
        '
        Me.TextBoxRegistryName.Location = New System.Drawing.Point(18, 41)
        Me.TextBoxRegistryName.Name = "TextBoxRegistryName"
        Me.TextBoxRegistryName.Size = New System.Drawing.Size(235, 20)
        Me.TextBoxRegistryName.TabIndex = 2
        '
        'TextBoxRegistryData
        '
        Me.TextBoxRegistryData.Location = New System.Drawing.Point(18, 89)
        Me.TextBoxRegistryData.Name = "TextBoxRegistryData"
        Me.TextBoxRegistryData.Size = New System.Drawing.Size(235, 20)
        Me.TextBoxRegistryData.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(79, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Create Value"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RegistrymanagerCreateValue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 151)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxRegistryData)
        Me.Controls.Add(Me.TextBoxRegistryName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegistrymanagerCreateValue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create Registry Value"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxRegistryName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRegistryData As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
