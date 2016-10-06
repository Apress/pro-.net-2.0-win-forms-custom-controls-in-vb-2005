Imports System.Drawing.Drawing2D

Public Class GradientBrushes

    Private Sub GradientBrushes_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim myBrush As Brush
        Dim y As Integer = 20
        Dim x As Integer = 20

        For Each gradientStyle As LinearGradientMode In [Enum].GetValues(GetType(LinearGradientMode))
            myBrush = New LinearGradientBrush(New Rectangle(x, y, 100, 60), Color.Violet, Color.White, gradientStyle)
            e.Graphics.FillRectangle(myBrush, x, y, 100, 60)
            e.Graphics.DrawString(gradientStyle.ToString(), New Font("Tahoma", 8), Brushes.Black, 110 + x, y + 20)
            y += 70
        Next

    End Sub
End Class