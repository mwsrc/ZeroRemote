<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcessmanagerModules
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcessmanagerModules))
        Me.ListBoxModules = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelModuleCount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBoxModules
        '
        Me.ListBoxModules.FormattingEnabled = True
        Me.ListBoxModules.Location = New System.Drawing.Point(12, 85)
        Me.ListBoxModules.Name = "ListBoxModules"
        Me.ListBoxModules.Size = New System.Drawing.Size(207, 134)
        Me.ListBoxModules.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 65)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "This is a list of the loaded modules" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(DLL-Files) of the selected process." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "On so" & _
    "me processes the server need" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "elevated privileges in order to get a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "list of th" & _
    "e loaded DLL's."
        '
        'LabelModuleCount
        '
        Me.LabelModuleCount.AutoSize = True
        Me.LabelModuleCount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelModuleCount.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LabelModuleCount.Location = New System.Drawing.Point(12, 226)
        Me.LabelModuleCount.Name = "LabelModuleCount"
        Me.LabelModuleCount.Size = New System.Drawing.Size(115, 13)
        Me.LabelModuleCount.TabIndex = 2
        Me.LabelModuleCount.Text = "Loaded 0 modules."
        '
        'ProcessmanagerModules
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 248)
        Me.Controls.Add(Me.LabelModuleCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxModules)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProcessmanagerModules"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modules (Loaded DLL's)"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBoxModules As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelModuleCount As System.Windows.Forms.Label
End Class
