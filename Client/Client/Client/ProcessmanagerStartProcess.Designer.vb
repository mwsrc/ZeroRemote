<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcessmanagerStartProcess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcessmanagerStartProcess))
        Me.ButtonStartProcess = New System.Windows.Forms.Button()
        Me.ButtonAbort = New System.Windows.Forms.Button()
        Me.TextBoxProcessname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonStartProcess
        '
        Me.ButtonStartProcess.Image = CType(resources.GetObject("ButtonStartProcess.Image"), System.Drawing.Image)
        Me.ButtonStartProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonStartProcess.Location = New System.Drawing.Point(12, 82)
        Me.ButtonStartProcess.Name = "ButtonStartProcess"
        Me.ButtonStartProcess.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStartProcess.TabIndex = 0
        Me.ButtonStartProcess.Text = "Start"
        Me.ButtonStartProcess.UseVisualStyleBackColor = True
        '
        'ButtonAbort
        '
        Me.ButtonAbort.Image = CType(resources.GetObject("ButtonAbort.Image"), System.Drawing.Image)
        Me.ButtonAbort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAbort.Location = New System.Drawing.Point(93, 82)
        Me.ButtonAbort.Name = "ButtonAbort"
        Me.ButtonAbort.Size = New System.Drawing.Size(88, 23)
        Me.ButtonAbort.TabIndex = 1
        Me.ButtonAbort.Text = "Cancel"
        Me.ButtonAbort.UseVisualStyleBackColor = True
        '
        'TextBoxProcessname
        '
        Me.TextBoxProcessname.Location = New System.Drawing.Point(12, 56)
        Me.TextBoxProcessname.Name = "TextBoxProcessname"
        Me.TextBoxProcessname.Size = New System.Drawing.Size(240, 20)
        Me.TextBoxProcessname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter the name of the file you like to execute." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(For example notepad.exe)"
        '
        'ProcessmanagerStartProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 117)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxProcessname)
        Me.Controls.Add(Me.ButtonAbort)
        Me.Controls.Add(Me.ButtonStartProcess)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProcessmanagerStartProcess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Start New Process"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonStartProcess As System.Windows.Forms.Button
    Friend WithEvents ButtonAbort As System.Windows.Forms.Button
    Friend WithEvents TextBoxProcessname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
