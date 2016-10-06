Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Drawing.Drawing2D

Public Class GradientFillEditor
    Inherits UITypeEditor

    Public Overrides Function GetPaintValueSupported( _
      ByVal context As ITypeDescriptorContext) As Boolean
        Return True
    End Function

    Public Overrides Sub PaintValue( _
      ByVal e As System.Drawing.Design.PaintValueEventArgs)
        Dim fill As GradientFill = CType(e.Value, GradientFill)
        Dim brush As New LinearGradientBrush(e.Bounds, _
            fill.ColorA, fill.ColorB, fill.GradientFillStyle)

        ' Paint the thumbnail.
        e.Graphics.FillRectangle(brush, e.Bounds)
    End Sub

End Class
