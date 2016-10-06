Public Class TextureBrushes

    Private Sub TextureBrushes_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim myBrush As New TextureBrush(My.Resources.Tile)
        e.Graphics.FillRectangle(myBrush, e.Graphics.ClipBounds)

    End Sub
End Class