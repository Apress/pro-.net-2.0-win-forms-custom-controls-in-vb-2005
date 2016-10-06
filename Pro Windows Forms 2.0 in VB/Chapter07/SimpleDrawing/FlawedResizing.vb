Public Class FlawedResizing

    Private Sub chkResizeRedraw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkResizeRedraw.CheckedChanged
        Invalidate()
    End Sub

    Private Sub FlawedResizing_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        ResizeRedraw = chkResizeRedraw.Checked
        Dim pen As New Pen(Color.Red, 1)
        e.Graphics.DrawEllipse(pen, New Rectangle(New Point(0, 0), _
          Me.ClientSize))
        pen.Dispose()
    End Sub
End Class