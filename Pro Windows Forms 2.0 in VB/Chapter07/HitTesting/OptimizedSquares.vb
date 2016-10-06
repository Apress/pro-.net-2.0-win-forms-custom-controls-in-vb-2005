Public Class OptimizedSquares
    ' Store the squares that are painted on the form.
    Private squares As New List(Of Rectangle)()

    Private Sub DrawSquare_MouseDown(ByVal sender As Object, _
      ByVal e As System.Windows.Forms.MouseEventArgs) _
      Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            Dim square As New Rectangle(e.X, e.Y, 20, 20)
            squares.Add(square)

            ' Get a region that includes the square and its border.
            ' Because the pen width is 10 pixels (and the center line is in
            ' the middle), you'll need an extra 5 pixels on each side.
            square.Inflate(5, 5)
            Invalidate(square)
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



    ' Paint all the squares when the form needs to be refreshed
    ' in response to the Paint event.
    Private Sub DrawSquare_Paint(ByVal sender As Object, _
      ByVal e As System.Windows.Forms.PaintEventArgs) _
      Handles MyBase.Paint

        For Each square As Rectangle In squares
            DrawRectangle(square, e.Graphics)
        Next
    End Sub

    ' This procedure performs the actual drawing, and is called by
    ' DrawSquare_MouseDown and DrawSquare_Paint.
    Private Sub DrawRectangle(ByVal rect As Rectangle, ByVal g As Graphics)
        Dim squarePen As New Pen(Color.Red, 10)
        g.DrawRectangle(squarePen, rect)
        squarePen.Dispose()
        lblCount.Text = " " & squares.Count & " squares"
    End Sub

End Class