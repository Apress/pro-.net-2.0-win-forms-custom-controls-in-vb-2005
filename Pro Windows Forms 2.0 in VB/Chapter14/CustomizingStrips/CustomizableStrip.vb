Public Class CustomizableStrip

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        ToolStripManager.SaveSettings(Me, "Test")
    End Sub

    Private Sub cmdRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRestore.Click
        ToolStripManager.LoadSettings(Me, "Test")
    End Sub
End Class