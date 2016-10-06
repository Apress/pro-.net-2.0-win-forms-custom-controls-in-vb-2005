Imports System.Drawing.Drawing2D

Public Class PenCaps

    Private Sub PenCaps_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim myPen As New Pen(Color.Blue, 10)
        Dim y As Integer = 20

        For Each cap As LineCap In [Enum].GetValues(GetType(LineCap))
            myPen.StartCap = cap
            myPen.EndCap = cap
            e.Graphics.DrawLine(myPen, 20, y, 100, y)
            e.Graphics.DrawString(cap.ToString(), New Font("Tahoma", 8), Brushes.Black, 120, y - 10)
            y += 30
        Next
    End Sub
End Class