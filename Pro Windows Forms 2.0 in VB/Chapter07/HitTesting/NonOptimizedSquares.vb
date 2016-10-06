Public Class NonOptimizedSquares
    ' Store the squares that are painted on the form.
    Private squares As New List(Of Rectangle)()

    Private Sub DrawSquare_MouseDown(ByVal sender As Object, _
      ByVal e As System.Windows.Forms.MouseEventArgs) _
      Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            ' Define a new square based on where the user clicked.
            Dim square As New Rectangle(e.X, e.Y, 20, 20)
            squares.Add(square)

            ' Request a repaint.
            Invalidate()
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            ' Search  for the clicked square.
            Dim squareNumber As Integer = 0
            For Each square As Rectangle In squares
                squareNumber += 1
                If square.Contains(e.X, e.Y) Then
                    MessageBox.Show("Point inside square #" & _
                      squareNumber)
                End If
            Next
        End If
    End Sub

    Private Sub DrawSquare_Paint(ByVal sender As Object, _
      ByVal e As System.Windows.Forms.PaintEventArgs) _
      Handles MyBase.Paint

        Dim squarePen As New Pen(Color.Red, 10)
        For Each square As Rectangle In squares
            e.Graphics.DrawRectangle(squarePen, square)
        Next

        squarePen.Dispose()
        lblCount.Text = " " & squares.Count & " squares"
    End Sub

End Class