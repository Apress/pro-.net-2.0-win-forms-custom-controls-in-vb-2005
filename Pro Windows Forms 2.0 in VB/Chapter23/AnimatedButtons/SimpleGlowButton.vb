Imports System.Drawing.Drawing2D

Public Class SimpleGlowButton
    Inherits AnimatedButtonBase

    Private penOutline As Pen
    Private textFormat As StringFormat

    Public Sub New()
        ' In a more sophisticated control, these hard-coded
        ' details would be mapped to properties.
        penOutline = New Pen(Color.Black, 2)
        penOutline.Alignment = PenAlignment.Inset

        textFormat = New StringFormat()
        textFormat.Alignment = StringAlignment.Center
        textFormat.LineAlignment = StringAlignment.Center
    End Sub

    Protected Overrides Sub PaintNormal(ByVal g As Graphics)
        g.FillRectangle(Brushes.LightGray, ClientRectangle)
        g.DrawRectangle(penOutline, ClientRectangle)
        g.DrawString(Text, Font, Brushes.Black, ClientRectangle, textFormat)
    End Sub

    Protected Overrides Sub PaintMouseOver(ByVal g As Graphics)
        g.FillRectangle(Brushes.LimeGreen, ClientRectangle)
        g.DrawRectangle(penOutline, ClientRectangle)
        g.DrawString(Text, Font, Brushes.White, ClientRectangle, textFormat)
    End Sub

    Protected Overrides Sub PaintPushed(ByVal g As Graphics)
        g.FillRectangle(Brushes.Lime, ClientRectangle)
        g.DrawRectangle(penOutline, ClientRectangle)
        g.DrawString(Text, Font, Brushes.White, ClientRectangle, textFormat)
    End Sub

    Protected Overrides Sub PaintDisabled(ByVal g As Graphics)
        g.FillRectangle(Brushes.LightSlateGray, ClientRectangle)
        g.DrawRectangle(penOutline, ClientRectangle)
        g.DrawString(Text, Font, Brushes.White, ClientRectangle, textFormat)
    End Sub

End Class
