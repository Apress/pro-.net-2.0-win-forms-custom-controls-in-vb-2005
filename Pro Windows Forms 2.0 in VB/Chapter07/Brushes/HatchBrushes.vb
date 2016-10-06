Imports System.Drawing.Drawing2D

Public Class HatchBrushes

    Private Sub HatchBrushes_Paint(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.PaintEventArgs) _
    Handles MyBase.Paint

        Dim y As Integer = 20
        Dim x As Integer = 20
        Dim captionFont As New Font("Tahoma", 8)

        ' Enumerate over all the styles.
        For Each brushStyle As HatchStyle In [Enum].GetValues(GetType(HatchStyle))
            Dim brush As New HatchBrush(brushStyle, Color.Blue, Color.LightYellow)

            ' Fill a rectangle with the brush.
            e.Graphics.FillRectangle(brush, x, y, 40, 20)

            ' Display the brush name.
            e.Graphics.DrawString(brushStyle.ToString(), captionFont, _
              Brushes.Black, 50 + x, y + 5)

            y += 30
            If (y + 30) > ClientSize.Height Then
                y = 20
                x += 180
            End If
            brush.Dispose()
        Next
        captionFont.Dispose()
    End Sub

End Class