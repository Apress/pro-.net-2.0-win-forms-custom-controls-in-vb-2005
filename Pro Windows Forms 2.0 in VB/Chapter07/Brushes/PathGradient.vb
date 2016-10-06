Imports System.Drawing.Drawing2D

Public Class PathGradient

    Private Sub PathGradientBrush_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        ' Create the path (which determines the shape of the gradient).
        Dim path As New GraphicsPath()
        Dim size As Integer = 150
        path.AddEllipse(10, 10, size, size)

        ' Create the brush, and set its colors.
        Dim brush As New PathGradientBrush(path)
        brush.SurroundColors = New Color() {Color.White}
        brush.CenterColor = Color.Violet

        ' Paint the gradient.
        e.Graphics.FillRectangle(brush, 10, 10, size, size)

        path.Dispose()
        brush.Dispose()

    End Sub
End Class