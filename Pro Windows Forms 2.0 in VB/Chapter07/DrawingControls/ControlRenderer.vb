Imports System.Windows.Forms.VisualStyles

Public Class ControlRenderer

    Private Sub ControlRenderer_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        CheckBoxRenderer.DrawCheckBox(e.Graphics, New Point(10, 10), _
          New Rectangle(10, 10, 110, 15), "Style checkbox", Font, False, CheckBoxState.CheckedNormal)

    End Sub
End Class