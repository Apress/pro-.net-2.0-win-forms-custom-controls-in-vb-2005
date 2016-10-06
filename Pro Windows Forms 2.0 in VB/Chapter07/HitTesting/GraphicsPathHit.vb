Imports System.Drawing.Drawing2D

Public Class GraphicsPathHit
    Private path As GraphicsPath

    Private Sub GraphicsPathExample_Paint(ByVal sender As Object, _
      ByVal e As System.Windows.Forms.PaintEventArgs) _
      Handles MyBase.Paint

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        path = New GraphicsPath()
        path.StartFigure()
        path.AddArc(10, 10, 100, 100, 20, 50)
        path.AddLine(20, 50, 70, 230)
        path.CloseFigure()
        path.AddEllipse(120, 50, 80, 80)
        e.Graphics.FillPath(Brushes.White, path)
        e.Graphics.DrawPath(Pens.Black, path)
    End Sub

    Private Sub GraphicsPathExample_MouseDown(ByVal sender As Object, _
     ByVal e As System.Windows.Forms.MouseEventArgs) _
      Handles MyBase.MouseDown

        If path.IsVisible(e.X, e.Y) Then
            MessageBox.Show("You clicked inside the figure.")
        End If
    End Sub

End Class