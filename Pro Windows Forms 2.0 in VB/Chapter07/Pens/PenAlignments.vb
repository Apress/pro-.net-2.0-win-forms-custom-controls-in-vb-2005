Imports System.Drawing.Drawing2D

Public Class PenAlignments

    Private Sub PenAlignments_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim rect As New Rectangle(10, 10, 110, 110)
        Dim pen As New Pen(Color.White, 11)
        Dim penOutline As New Pen(Color.Black, 1)
        penOutline.Alignment = PenAlignment.Inset
        pen.Alignment = PenAlignment.Center
        e.Graphics.DrawString("11-Pixel Centered Pen", SystemFonts.DefaultFont, Brushes.Black, rect.Location)
        rect.Offset(0, 25)
        e.Graphics.FillRectangle(Brushes.LightBlue, rect)
        e.Graphics.DrawRectangle(pen, rect)
        e.Graphics.DrawRectangle(penOutline, rect)

        rect.Offset(150, -25)
        e.Graphics.DrawString("11-Pixel Inset Pen", SystemFonts.DefaultFont, Brushes.Black, rect.Location)
        rect.Offset(0, 25)
        pen.Alignment = PenAlignment.Inset
        e.Graphics.FillRectangle(Brushes.LightBlue, rect)
        e.Graphics.DrawRectangle(pen, rect)
        e.Graphics.DrawRectangle(penOutline, rect)

        pen.Dispose()
    End Sub
End Class