Public Class DrawingArea

    Private Sub DrawingArea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim frmTool As New Palette()
        Me.AddOwnedForm(frmTool)
        frmTool.Show()
        picDrawingArea.AllowDrop = True
    End Sub

    Private Sub picDrawingArea_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles picDrawingArea.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub picDrawingArea_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles picDrawingArea.DragDrop
        ' Get the image.
        Dim img As Image = CType(e.Data.GetData(DataFormats.Bitmap), Image)

        ' Use this offset to center the 30x30-pixel images.
        Dim offset As Integer = 15

        ' Convert the coordinates from screen-based to form-based.
        Dim p As Point = Me.PointToClient(New Point(e.X - offset, e.Y - offset))

        ' Paint a temporary picture at this location.
        Dim g As Graphics = picDrawingArea.CreateGraphics()
        g.DrawImage(img, p)
        g.Dispose()
    End Sub
End Class
