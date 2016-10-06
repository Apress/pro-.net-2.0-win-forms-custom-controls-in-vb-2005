Public Class SimpleDraw

    Private Sub SimpleDraw_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        If chkRepaint.Checked Then
            Dim drawingPen As New Pen(Color.Red, 15)
            e.Graphics.DrawArc(drawingPen, 50, 20, 100, 200, 40, 210)
            drawingPen.Dispose()
        End If
    End Sub

  
End Class