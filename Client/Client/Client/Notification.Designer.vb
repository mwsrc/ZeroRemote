﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Notification))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.InfoButtonHide = New Client.InfoButton()
        Me.InfoButtonControl = New Client.InfoButton()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.InfoButtonHide)
        Me.Panel1.Controls.Add(Me.InfoButtonControl)
        Me.Panel1.Location = New System.Drawing.Point(2, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 33)
        Me.Panel1.TabIndex = 4
        '
        'InfoButtonHide
        '
        Me.InfoButtonHide.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoButtonHide.Location = New System.Drawing.Point(153, 5)
        Me.InfoButtonHide.Name = "InfoButtonHide"
        Me.InfoButtonHide.Size = New System.Drawing.Size(108, 23)
        Me.InfoButtonHide.TabIndex = 1
        Me.InfoButtonHide.Text = "Hide"
        '
        'InfoButtonControl
        '
        Me.InfoButtonControl.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoButtonControl.Location = New System.Drawing.Point(29, 5)
        Me.InfoButtonControl.Name = "InfoButtonControl"
        Me.InfoButtonControl.Size = New System.Drawing.Size(108, 23)
        Me.InfoButtonControl.TabIndex = 0
        Me.InfoButtonControl.Text = "Take Control"
        '
        'LabelInfo
        '
        Me.LabelInfo.AutoSize = True
        Me.LabelInfo.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInfo.Location = New System.Drawing.Point(73, 41)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(122, 24)
        Me.LabelInfo.TabIndex = 7
        Me.LabelInfo.Text = "Client 'TEST-PC/Test' " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "connected from Japan."
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelTitle.Location = New System.Drawing.Point(5, 7)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(217, 13)
        Me.LabelTitle.TabIndex = 9
        Me.LabelTitle.Text = "ZeroRemote - New Client Connected"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Notification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 122)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelInfo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Notification"
        Me.ShowInTaskbar = False
        Me.Text = "Notification"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents InfoButtonHide As Client.InfoButton
    Friend WithEvents InfoButtonControl As Client.InfoButton
    Friend WithEvents LabelInfo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
End Class
