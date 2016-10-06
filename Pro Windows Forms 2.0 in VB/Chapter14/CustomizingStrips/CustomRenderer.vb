Imports System.Drawing.Drawing2D

Public Class CustomRenderer
    Inherits ToolStripRenderer

    Protected Overrides Sub OnRenderItemText(ByVal e As ToolStripItemTextRenderEventArgs)
        e.TextColor = Color.White
        MyBase.OnRenderItemText(e)
    End Sub

    Protected Overrides Sub OnRenderImageMargin(ByVal e As ToolStripRenderEventArgs)
        MyBase.OnRenderImageMargin(e)
        Dim g As Graphics = e.Graphics
        Dim b As New LinearGradientBrush(e.AffectedBounds, Color.Yellow, Color.Green, 0)
        Using b
            g.FillRectangle(b, e.AffectedBounds)
        End Using
    End Sub

    Protected Overrides Sub OnRenderMenuItemBackground(ByVal e As ToolStripItemRenderEventArgs)
        MyBase.OnRenderMenuItemBackground(e)
        Dim g As Graphics = e.Graphics
        If e.Item.Selected Or e.Item.Pressed Then

            Dim b As New LinearGradientBrush(New Rectangle(0, 0, e.Item.Bounds.Width, e.Item.Bounds.Height), Color.LightGreen, Color.DarkGreen, 90)
            Using b
                Dim b1 As New SolidBrush(Color.Pink)
                g.FillRectangle(b, 0, 0, e.Item.Bounds.Width, e.Item.Bounds.Height)
                b1.Dispose()
            End Using
        End If
    End Sub

    Protected Overrides Sub OnRenderToolStripBackground(ByVal e As ToolStripRenderEventArgs)
        Dim g As Graphics = e.Graphics
        Dim b As New LinearGradientBrush(e.AffectedBounds, Color.DarkGray, Color.Black, 90)
        g.FillRectangle(b, e.AffectedBounds)
        b.Dispose()

        MyBase.OnRenderToolStripBackground(e)
    End Sub

    Protected Overrides Sub OnRenderButtonBackground(ByVal e As ToolStripItemRenderEventArgs)
        MyBase.OnRenderButtonBackground(e)

        ' Check if the item is selected.
        If e.Item.Pressed Or e.Item.Selected Then
            Dim brush As New LinearGradientBrush(e.Item.Bounds, _
                 Color.Yellow, Color.Green, 90)
            e.Graphics.FillRectangle(brush, 0, 0, e.Item.Width, e.Item.Height)
        End If
    End Sub


End Class
