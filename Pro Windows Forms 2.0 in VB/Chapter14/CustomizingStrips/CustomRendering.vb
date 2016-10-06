Public Class CustomRendering

    Private Sub opt_CheckedChanged(ByVal sender As Object, _
   ByVal e As EventArgs) Handles optPro.CheckedChanged, _
   optSys.CheckedChanged, optCust.CheckedChanged
        If optPro.Checked Then
            ToolStripManager.RenderMode = ToolStripManagerRenderMode.Professional
        ElseIf optSys.Checked Then
            ToolStripManager.RenderMode = ToolStripManagerRenderMode.System
        ElseIf optCust.Checked Then
            ToolStripManager.Renderer = New CustomRenderer()
        End If
    End Sub

    Private Sub chkContentPanel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkContentPanel.CheckedChanged
        If chkContentPanel.Checked Then
            toolStripContainer1.ContentPanel.RenderMode = ToolStripRenderMode.ManagerRenderMode
        Else
            toolStripContainer1.ContentPanel.RenderMode = ToolStripRenderMode.System
        End If
    End Sub
End Class