Imports System.Drawing.Drawing2D

Public Class CompoundShapedForm

    Private path As New GraphicsPath()

    Private Sub CompoundShapedForm_Load(ByVal sender As Object, ByVal e As EventArgs) _
      Handles MyBase.Load
        path.AddEllipse(0, 0, CInt(Me.Width / 2), CInt(Me.Height / 2))
        path.AddRectangle(New Rectangle(Me.Width / 2, Me.Height / 4, _
          Me.Width / 2, Me.Height / 4))
        path.AddEllipse(CInt(Me.Width / 2), CInt(Me.Height / 2), _
          CInt(Me.Width / 2), CInt(Me.Height / 2))
        Me.Region = New Region(path)
    End Sub

    Private Sub CompoundShapedForm_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) _
      Handles MyBase.Paint
        e.Graphics.SmoothingMode = SmoothingMode.HighQuality
        e.Graphics.FillPath(Brushes.LightBlue, path)

        Dim drawingPen As New Pen(Color.SlateBlue, 8)
        Using drawingPen
            e.Graphics.DrawPath(drawingPen, path)
        End Using
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.Close()
    End Sub
End Class