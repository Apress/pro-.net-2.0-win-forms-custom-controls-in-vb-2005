Public Class ToolStripFloat


    Private Sub cmdDock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDock.Click
        Me.Controls.Add(FloatToolStrip1)
        FloatToolStrip1.FloatForm.Close()
        FloatToolStrip1.FloatForm.Dispose()
        cmdDock.Enabled = False
    End Sub

    Private Sub FloatToolStrip1_Undocked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FloatToolStrip1.Undocked
        cmdDock.Enabled = True
    End Sub
End Class