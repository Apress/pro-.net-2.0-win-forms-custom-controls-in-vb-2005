Public Class Form1

    Private Sub Form1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        ' Fill the background with a tile.
        Dim backgroundBitmap As Bitmap = My.Resources.Pic
        Dim backgroundBrush As New TextureBrush(backgroundBitmap)
        e.Graphics.FillRectangle(backgroundBrush, ClientRectangle)
        backgroundBrush.Dispose()
        backgroundBitmap.Dispose()


        ' Draw some solid content.
        Dim solidColor As Color = Color.Yellow
        Dim penWidth As Integer = 80
        Dim opaquePen As New Pen(solidColor, penWidth)
        e.Graphics.DrawLine(opaquePen, 0, 50, 200, 20)
        opaquePen.Dispose()

        ' Make the color partly transparent (50%).
        Dim semiTransparentColor As Color = Color.FromArgb( _
          128, solidColor.R, solidColor.G, solidColor.B)
        Dim semiTransparentPen As New Pen(semiTransparentColor, penWidth)
        e.Graphics.DrawLine(semiTransparentPen, 0, 200, 200, 140)
        semiTransparentPen.Dispose()

        ' Make the color very transparent (70% transparent).
        Dim veryTransparentColor As Color = Color.FromArgb( _
          77, solidColor.R, solidColor.G, solidColor.B)
        Dim veryTransparentPen As New Pen(veryTransparentColor, penWidth)
        e.Graphics.DrawLine(veryTransparentPen, 0, 350, 200, 260)
        veryTransparentPen.Dispose()

        ' Draw some transparent text.
        Dim transparentBrush As New SolidBrush(semiTransparentColor)
        e.Graphics.DrawString("TRANSPARENT", New Font("Verdana", 36, FontStyle.Bold), _
          transparentBrush, 80, 150)
        transparentBrush.Dispose()

    End Sub
End Class
