Public Class Palette

    Private Sub lbl_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblPictureTwo.MouseDown, lblPictureThree.MouseDown, lblPictureOne.MouseDown
        Dim lbl As Label = CType(sender, Label)
        lbl.DoDragDrop(lbl.Image, DragDropEffects.Copy)
    End Sub
End Class