Public Class Form1

    ' Keep track of when fake "drag-and-drop" mode is enabled.
    Private isDragging As Boolean = False

    ' Store the location where the user clicked the control.
    Private clickOffsetX As Integer, clickOffsetY As Integer


    Private Sub lblDragger_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblDragger.MouseDown
        isDragging = True
        clickOffsetX = e.X
        clickOffsetY = e.Y
    End Sub

    Private Sub lblDragger_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblDragger.MouseUp
        isDragging = False
    End Sub

    Private Sub lblDragger_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblDragger.MouseMove
        If isDragging Then
            ' The control coordinates are converted into form coordinates
            ' by adding the label position offset.
            ' The offset where the user clicked in the control is also
            ' accounted for. Otherwise, it looks like the top-left corner
            ' of the label is attached to the mouse.
            lblDragger.Left = e.X + lblDragger.Left - clickOffsetX
            lblDragger.Top = e.Y + lblDragger.Top - clickOffsetY
        End If
    End Sub
End Class
