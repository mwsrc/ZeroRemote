<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Microphone
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Microphone))
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.NumericUpDownRecordTime = New System.Windows.Forms.NumericUpDown()
        Me.LabelRecordDuration = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.ButtonRecord = New System.Windows.Forms.Button()
        Me.TimerWait = New System.Windows.Forms.Timer(Me.components)
        CType(Me.NumericUpDownRecordTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.Location = New System.Drawing.Point(15, 13)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(271, 13)
        Me.LabelDescription.TabIndex = 0
        Me.LabelDescription.Text = "Record the microphone of the remote system."
        '
        'NumericUpDownRecordTime
        '
        Me.NumericUpDownRecordTime.Location = New System.Drawing.Point(161, 48)
        Me.NumericUpDownRecordTime.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.NumericUpDownRecordTime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownRecordTime.Name = "NumericUpDownRecordTime"
        Me.NumericUpDownRecordTime.Size = New System.Drawing.Size(48, 21)
        Me.NumericUpDownRecordTime.TabIndex = 1
        Me.NumericUpDownRecordTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDownRecordTime.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'LabelRecordDuration
        '
        Me.LabelRecordDuration.AutoSize = True
        Me.LabelRecordDuration.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelRecordDuration.Location = New System.Drawing.Point(15, 51)
        Me.LabelRecordDuration.Name = "LabelRecordDuration"
        Me.LabelRecordDuration.Size = New System.Drawing.Size(256, 13)
        Me.LabelRecordDuration.TabIndex = 2
        Me.LabelRecordDuration.Text = "Record microphone for                 seconds."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(128, 100)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(158, 12)
        Me.ProgressBar1.TabIndex = 3
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatus.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.LabelStatus.Location = New System.Drawing.Point(157, 84)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(65, 12)
        Me.LabelStatus.TabIndex = 4
        Me.LabelStatus.Text = "Status: Idle"
        '
        'ButtonRecord
        '
        Me.ButtonRecord.Image = CType(resources.GetObject("ButtonRecord.Image"), System.Drawing.Image)
        Me.ButtonRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRecord.Location = New System.Drawing.Point(18, 89)
        Me.ButtonRecord.Name = "ButtonRecord"
        Me.ButtonRecord.Size = New System.Drawing.Size(92, 24)
        Me.ButtonRecord.TabIndex = 5
        Me.ButtonRecord.Text = "Record"
        Me.ButtonRecord.UseVisualStyleBackColor = True
        '
        'TimerWait
        '
        Me.TimerWait.Interval = 1000
        '
        'Microphone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 125)
        Me.Controls.Add(Me.ButtonRecord)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.NumericUpDownRecordTime)
        Me.Controls.Add(Me.LabelRecordDuration)
        Me.Controls.Add(Me.LabelDescription)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Microphone"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Microphone"
        Me.TopMost = True
        CType(Me.NumericUpDownRecordTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelDescription As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownRecordTime As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelRecordDuration As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents ButtonRecord As System.Windows.Forms.Button
    Friend WithEvents TimerWait As System.Windows.Forms.Timer
End Class
