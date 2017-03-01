<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrymanagerModifyValue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrymanagerModifyValue))
        Me.TextBoxRegistryvaluename = New System.Windows.Forms.TextBox()
        Me.TextBoxRegistryvaluedata = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonModify = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxRegistryvaluename
        '
        Me.TextBoxRegistryvaluename.Location = New System.Drawing.Point(23, 34)
        Me.TextBoxRegistryvaluename.Name = "TextBoxRegistryvaluename"
        Me.TextBoxRegistryvaluename.ReadOnly = True
        Me.TextBoxRegistryvaluename.Size = New System.Drawing.Size(222, 20)
        Me.TextBoxRegistryvaluename.TabIndex = 0
        '
        'TextBoxRegistryvaluedata
        '
        Me.TextBoxRegistryvaluedata.Location = New System.Drawing.Point(23, 82)
        Me.TextBoxRegistryvaluedata.Name = "TextBoxRegistryvaluedata"
        Me.TextBoxRegistryvaluedata.Size = New System.Drawing.Size(222, 20)
        Me.TextBoxRegistryvaluedata.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Registryvalue name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Registryvalue data:"
        '
        'ButtonModify
        '
        Me.ButtonModify.Image = CType(resources.GetObject("ButtonModify.Image"), System.Drawing.Image)
        Me.ButtonModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonModify.Location = New System.Drawing.Point(75, 114)
        Me.ButtonModify.Name = "ButtonModify"
        Me.ButtonModify.Size = New System.Drawing.Size(112, 23)
        Me.ButtonModify.TabIndex = 4
        Me.ButtonModify.Text = "Modify Value"
        Me.ButtonModify.UseVisualStyleBackColor = True
        '
        'RegistrymanagerModifyValue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 151)
        Me.Controls.Add(Me.ButtonModify)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxRegistryvaluedata)
        Me.Controls.Add(Me.TextBoxRegistryvaluename)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegistrymanagerModifyValue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modify Registryvalue"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxRegistryvaluename As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRegistryvaluedata As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonModify As System.Windows.Forms.Button
End Class
