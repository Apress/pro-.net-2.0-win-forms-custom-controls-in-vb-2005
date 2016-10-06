Public Class Form1
    Private isShrinking As Boolean = False
    Private extraSize As Integer = 0

    Private Sub tmrRefresh_Tick(ByVal sender As Object, _
      ByVal e As EventArgs) Handles tmrRefresh.Tick

        ' Change the circle dimensions.
        If isShrinking Then
            extraSize -= 1
        Else
            extraSize += 1
        End If

        ' Change the sizing direction if needed.
        If extraSize > (Me.Width - 150) Then
            isShrinking = True
        ElseIf extraSize < 1 Then
            isShrinking = False
        End If

        ' Repaint the form.
        Invalidate()
    End Sub

    Private Sub DoubleBuffering_Paint(ByVal sender As Object, _
  ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        ' Check if double buffering is needed.
        Me.DoubleBuffered = chkDoubleBuffer.Checked

        Dim g As Graphics = e.Graphics
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality

        ' Draw a rectangle.
        Dim drawingPen As New Pen(Color.Black, 10)
        g.FillRectangle(Brushes.White, New Rectangle(New Point(0, 0), _
          Me.ClientSize))
        g.DrawEllipse(drawingPen, 50, 50, 50 + extraSize, 50 + extraSize)
        drawingPen.Dispose()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmrRefresh.Start()
    End Sub
End Class
