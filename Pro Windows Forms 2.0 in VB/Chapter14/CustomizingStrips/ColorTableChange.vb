Public Class ColorTableChange

    Private Sub ColorTableChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        toolStrip1.Renderer = New ToolStripProfessionalRenderer(New CustomColorTable())
    End Sub
End Class