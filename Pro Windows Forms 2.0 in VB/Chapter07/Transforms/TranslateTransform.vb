Public Class TranslateTransform

    Private Sub TranslateTransform_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        ' Draw several squares in different places.
        DrawRectangle(e.Graphics)
        e.Graphics.TranslateTransform(180, 60)
        DrawRectangle(e.Graphics)
        e.Graphics.TranslateTransform(-50, 80)
        DrawRectangle(e.Graphics)
        e.Graphics.TranslateTransform(-100, 50)
        DrawRectangle(e.Graphics)
    End Sub

    Private Sub DrawRectangle(ByVal g As Graphics)
        Dim drawingPen As New Pen(Color.Red, 30)

        ' Draw a rectangle at a fixed position.
        g.DrawRectangle(drawingPen, New Rectangle(20, 20, 20, 20))

        drawingPen.Dispose()
    End Sub

End Class