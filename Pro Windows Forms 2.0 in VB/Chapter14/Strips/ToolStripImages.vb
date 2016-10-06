Public Class ToolStripImages

    Private Sub ToolStripImages_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstRelationship.DataSource = [Enum].GetNames(GetType(TextImageRelation))
    End Sub

    Private Sub cmdApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApply.Click
        Dim selection As TextImageRelation
        selection = CType([Enum].Parse(GetType(TextImageRelation), lstRelationship.Text), TextImageRelation)
        For Each item As ToolStripItem In toolStrip1.Items
            item.TextImageRelation = selection
        Next
    End Sub
End Class