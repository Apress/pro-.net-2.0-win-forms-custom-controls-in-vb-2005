Imports System.Drawing.Text

Public Class SmoothingText

    Private Sub SmoothingText_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim textFont As New Font("Times New Roman", 25, FontStyle.Italic)
        e.Graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit
        e.Graphics.DrawString("Sample Text", textFont, Brushes.Black, 20, 20)
        e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit
        e.Graphics.DrawString("Sample Text", textFont, Brushes.Black, 20, 85)
        e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
        e.Graphics.DrawString("Sample Text", textFont, Brushes.Black, 20, 150)

    End Sub
End Class