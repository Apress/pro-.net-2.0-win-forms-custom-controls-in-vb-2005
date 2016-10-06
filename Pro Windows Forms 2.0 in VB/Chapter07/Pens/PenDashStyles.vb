Imports System.Drawing.Drawing2D

Public Class PenDashStyles

    Private Sub PenDashStyles_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim myPen As New Pen(Color.Blue, 10)
        Dim y As Integer = 20
        For Each dash As DashStyle In [Enum].GetValues(GetType(DashStyle))

            myPen.DashStyle = dash
            e.Graphics.DrawLine(myPen, 20, y, 100, y)
            e.Graphics.DrawString(dash.ToString(), New Font("Tahoma", 8), Brushes.Black, 120, y - 10)
            y += 30
        Next

        y += 10
        myPen.StartCap = LineCap.Round
        myPen.EndCap = LineCap.Round

        For Each dash As DashStyle In [Enum].GetValues(GetType(DashStyle))

            myPen.DashStyle = dash
            e.Graphics.DrawLine(myPen, 20, y, 100, y)
            e.Graphics.DrawString(dash.ToString() + " (with round caps)", New Font("Tahoma", 8), Brushes.Black, 120, y - 10)
            y += 30
        Next
    End Sub
End Class