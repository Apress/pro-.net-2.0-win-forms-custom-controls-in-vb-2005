Imports System.Drawing.Drawing2D

Public Class Smoothing

    Private Sub picNone_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picNone.Paint
        e.Graphics.SmoothingMode = SmoothingMode.None
        DrawEllipse(e.Graphics)
    End Sub

    Private Sub DrawEllipse(ByVal g As Graphics)
        Dim drawingPen As New Pen(Color.Red, 5)
        g.DrawEllipse(drawingPen, 10, 10, 300, 40)
    End Sub

    Private Sub picHighSpeed_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picHighSpeed.Paint
        e.Graphics.SmoothingMode = SmoothingMode.HighSpeed
        DrawEllipse(e.Graphics)
    End Sub

    Private Sub picAntialias_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picAntialias.Paint
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        DrawEllipse(e.Graphics)
    End Sub

    Private Sub picHighQuality_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picHighQuality.Paint
        e.Graphics.SmoothingMode = SmoothingMode.HighQuality
        DrawEllipse(e.Graphics)
    End Sub
End Class