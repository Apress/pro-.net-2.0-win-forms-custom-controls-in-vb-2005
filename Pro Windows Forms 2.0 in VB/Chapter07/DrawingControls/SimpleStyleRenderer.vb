Imports System.Windows.Forms.VisualStyles

Public Class SimpleStyleRenderer

    Private Sub SimpleStyleRenderer_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim element As VisualStyleElement = VisualStyleElement.Button.CheckBox.CheckedNormal

        If Application.RenderWithVisualStyles And _
         VisualStyleRenderer.IsElementDefined(element) Then

            Dim renderer As New VisualStyleRenderer(element)
            Dim rectCheck As New Rectangle(10, 10, 50, 50)
            Dim rectBox As New Rectangle(10, 10, 200, 50)
            Dim rectText As New Rectangle(50, 25, 150, 25)
            renderer.DrawBackground(e.Graphics, rectCheck)
            renderer.DrawEdge(e.Graphics, rectBox, _
             Edges.Bottom Or Edges.Top Or Edges.Left Or Edges.Right, _
             EdgeStyle.Etched, EdgeEffects.Flat)
            renderer.DrawText(e.Graphics, rectText, "Styled checkbox", False, TextFormatFlags.Top)

        Else
            ' (Perform ControlPaint drawing here.)
        End If
    End Sub
End Class