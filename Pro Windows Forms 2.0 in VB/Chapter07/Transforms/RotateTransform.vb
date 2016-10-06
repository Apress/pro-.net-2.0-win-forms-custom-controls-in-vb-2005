Imports System.Drawing.Text

Public Class RotateTransform
    Private Sub RotateTransform_Paint(ByVal sender As Object, _
      ByVal e As System.Windows.Forms.PaintEventArgs) _
      Handles MyBase.Paint

        ' Optimize text quality.
        e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit

        ' Move origin to center of form so we can rotate around that.
        e.Graphics.TranslateTransform(Me.Width / 2 - 30, Me.Height / 2 - 30)

        DrawText(e.Graphics)
        e.Graphics.RotateTransform(45)
        DrawText(e.Graphics)
        e.Graphics.RotateTransform(75)
        DrawText(e.Graphics)
        e.Graphics.RotateTransform(160)
        DrawText(e.Graphics)
    End Sub

    Private Sub DrawText(ByVal g As Graphics)
        g.DrawString("Text", New Font("Verdana", 30, FontStyle.Bold), _
          Brushes.Black, 0, 10)
    End Sub

End Class