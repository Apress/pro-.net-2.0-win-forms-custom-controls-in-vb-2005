Imports System.Drawing.Drawing2D

Public Class Form1

    Private Sub chkClipping_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkClipping.CheckedChanged
        Invalidate()
    End Sub

    Private Sub Form1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias


        ' Create the GraphicsPath with an ellipse.
        Dim path As New GraphicsPath()
        Dim rect As New Rectangle(10, 10, 250, 50)
        path.AddEllipse(rect)

        ' Render the ellipse on the drawing surface.
        e.Graphics.DrawPath(Pens.Red, path)

        ' Set the clipping.
        Dim clippingRegion As New Region(path)
        If chkClipping.Checked Then e.Graphics.Clip = clippingRegion

        ' Draw inside the ellipse.
        e.Graphics.DrawString("Clipped", _
          New Font("Verdana", 36, FontStyle.Bold), Brushes.Black, 10, 10)
        clippingRegion.Dispose()
        path.Dispose()

        ' Rest the clipping region.
        e.Graphics.ResetClip()

        ' Clip to path (which represents text).
        path = New GraphicsPath()
        path.AddString("Clipped", New FontFamily("Verdana"), _
          0, 70, New Point(10, 130), New StringFormat())
        e.Graphics.DrawPath(Pens.Blue, path)

        ' Set the clipping.
        clippingRegion = New Region(path)
        If chkClipping.Checked Then e.Graphics.Clip = clippingRegion

        ' Draw a series of ellipses in the clipped region.
        For i As Integer = 0 To 40
            e.Graphics.DrawEllipse(Pens.Red, 180 - i * 3, 180 - i * 3, i * 6, i * 6)
        Next
        clippingRegion.Dispose()
        path.Dispose()

    End Sub
End Class
