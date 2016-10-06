Public Class SimpleOwnerDrawList

    Private Sub listBox1_MeasureItem(ByVal sender As Object, ByVal e As MeasureItemEventArgs) _
      Handles listBox1.MeasureItem
        ' Specify a fixed height.
        ' (The default height depends on the system font settings,
        ' but it usually 13 pixels.)
        e.ItemHeight = 15
    End Sub

    Private Sub listBox1_DrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs) _
      Handles listBox1.DrawItem
        ' Draw the background.
        ' The color (white or blue) depends on selection.
        e.DrawBackground()

        ' Determine the forecolor based on whether or not
        ' the item is selected.
        Dim drawBrush As Brush
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            drawBrush = Brushes.White
        Else
            drawBrush = Brushes.Black
        End If

        ' Get the item text.
        Dim text As String = CType(sender, ListBox).Items(e.Index).ToString()

        ' Draw the item text.
        e.Graphics.DrawString(text, CType(sender, Control).Font, _
          drawBrush, e.Bounds.X, e.Bounds.Y)
    End Sub

End Class