Public Class CustomOverflow

    Private Sub toolStripOverflow_LayoutCompleted(ByVal sender As Object, _
  ByVal e As EventArgs) Handles ToolStripOverflow.LayoutCompleted
        ' Check if the overflow menu is in use.
        If toolStripOverflow.OverflowButton.HasDropDownItems Then
            ' Step backwards.
            For i As Integer = toolStripOverflow.Items.Count - 1 To 0 Step -1
                Dim item As ToolStripItem = toolStripOverflow.Items(i)
                If Not TypeOf item Is ToolStripSeparator Then
                    If item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText Then
                        item.DisplayStyle = ToolStripItemDisplayStyle.Text
                        Return
                    End If
                End If
            Next

            ' If we reached here, all buttons are shrunk to text.
            ' Try reducing them further.
            For i As Integer = toolStripOverflow.Items.Count - 1 To 0 Step -1
                Dim item As ToolStripItem = toolStripOverflow.Items(i)
                If Not TypeOf item Is ToolStripSeparator Then
                    If item.DisplayStyle = ToolStripItemDisplayStyle.Text Then
                        item.DisplayStyle = ToolStripItemDisplayStyle.Image
                        Return
                    End If
                End If
            Next
            ' If we reach here, the bar is fully collapsed.

        End If
    End Sub

    Private Sub toolStripOverflow_Layout(ByVal sender As Object, _
  ByVal e As LayoutEventArgs) Handles toolStripOverflow.Layout
        If toolStripOverflow.DisplayRectangle.Width > MeasureToolStrip() Then
            ' Right now everything fits.
            ' Check if a larger size is appropriate.
            For Each item As ToolStripItem In toolStripOverflow.Items
                If Not TypeOf item Is ToolStripSeparator Then

                    ' Look to expand any image-only buttons.
                    If item.DisplayStyle = ToolStripItemDisplayStyle.Image Then
                        item.DisplayStyle = ToolStripItemDisplayStyle.Text
                        Return
                    End If
                End If
            Next

            ' If we reach here, there are no image-only buttons.
            ' Look to expand any text-only buttons.
            For Each item As ToolStripItem In toolStripOverflow.Items
                If Not TypeOf item Is ToolStripSeparator Then
                    If item.DisplayStyle = ToolStripItemDisplayStyle.Text Then
                        item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                        Return
                    End If
                End If
            Next
            ' If we reach here, the bar is fully expanded.
        End If
    End Sub

    Private threshold As Integer = 25
    Private Function MeasureToolStrip() As Integer

        Dim totalItemWidth As Integer = 0
        For Each item As ToolStripItem In toolStripOverflow.Items
            totalItemWidth += item.Bounds.Width + item.Margin.Horizontal
        Next
        Return totalItemWidth + threshold
    End Function
End Class