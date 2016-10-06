Imports System.ComponentModel

Public Class ContextMenus

    Private Sub contextMenuStrip_Opening(ByVal sender As Object, _
  ByVal e As CancelEventArgs) Handles contextMenuStrip1.Opening
        ' Enable everything.
        For Each item As ToolStripItem In contextMenuStrip1.Items
            item.Visible = True
        Next

        ' Disable what isn't appropriate.
        If TypeOf contextMenuStrip1.SourceControl Is Label Then
            cutToolStripMenuItem1.Visible = False
            pasteToolStripMenuItem1.Visible = False
        End If
    End Sub

End Class