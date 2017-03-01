Public Class BuilderQuerySpeed


    ' Set the refresh time for the server (to prevent webhost overheating)
    ' If only a few bots are controlled, you can set it lower
    ' otherwise set it should be higher to not make the server stress to big
    Private Sub TrackBarQuerySpeed_Scroll(sender As Object, e As EventArgs) Handles TrackBarQuerySpeed.Scroll
        Select Case TrackBarQuerySpeed.Value
            Case 0
                LabelSpeed.Text = "Selected Query Speed: 1000 ms"
                ToolStripSplitButton1.Image = My.Resources.exclamation
                ToolStripStatusLabel1.Text = "Very high query speed. Very high server stress."
                Builder.StubQuerySpeed = "1000"
            Case 1
                LabelSpeed.Text = "Selected Query Speed: 2000 ms"
                ToolStripSplitButton1.Image = My.Resources.exclamation
                ToolStripStatusLabel1.Text = "Fast query speed. High server stress."
                Builder.StubQuerySpeed = "2000"
            Case 2
                LabelSpeed.Text = "Selected Query Speed: 3000 ms"
                ToolStripSplitButton1.Image = My.Resources.information
                ToolStripStatusLabel1.Text = "Good query speed. Average server stress."
                Builder.StubQuerySpeed = "3000"
            Case 3
                LabelSpeed.Text = "Selected Query Speed: 4000 ms"
                ToolStripSplitButton1.Image = My.Resources.information
                ToolStripStatusLabel1.Text = "Medium query speed. Average server stress."
                Builder.StubQuerySpeed = "4000"
            Case 4
                LabelSpeed.Text = "Selected Query Speed: 6000 ms"
                ToolStripSplitButton1.Image = My.Resources.information
                ToolStripStatusLabel1.Text = "Slow query speed. Small server stress."
                Builder.StubQuerySpeed = "6000"
            Case 5
                LabelSpeed.Text = "Selected Query Speed: 8000 ms"
                ToolStripSplitButton1.Image = My.Resources.information
                ToolStripStatusLabel1.Text = "Very slow query speed. Very small server stress."
                Builder.StubQuerySpeed = "8000"
        End Select
    End Sub

    Private Sub BuilderQuerySpeed_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

End Class