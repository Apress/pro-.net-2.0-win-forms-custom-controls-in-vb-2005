Imports System.Drawing.Drawing2D

Public Class LineJoins

    Private Sub LineJoins_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim myPen As New Pen(Color.Blue, 10)
        Dim y As Integer = 20

        For Each join As LineJoin In [Enum].GetValues(GetType(LineJoin))

            myPen.LineJoin = join
            e.Graphics.DrawRectangle(myPen, 20, y, 70, 40)
            e.Graphics.DrawString(join.ToString(), New Font("Tahoma", 8), Brushes.Black, 100, y + 10)
            y += 70
        Next
    End Sub
End Class