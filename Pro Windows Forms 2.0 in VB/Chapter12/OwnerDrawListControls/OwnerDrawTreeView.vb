Public Class OwnerDrawTreeView
    Private selectedNodes As New List(Of MultiSelectTreeNode)()
    
    Private Sub OwnerDrawTreeView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim nodeP As New MultiSelectTreeNode("Node Group", selectedNodes)
        treeView1.Nodes.Add(nodeP)

        Dim node As New MultiSelectTreeNode("First Node", selectedNodes)
        node.Select()
        nodeP.Nodes.Add(node)
        node = New MultiSelectTreeNode("Second Node", selectedNodes)
        nodeP.Nodes.Add(node)
        node = New MultiSelectTreeNode("Third Node", selectedNodes)
        nodeP.Nodes.Add(node)
        node = New MultiSelectTreeNode("Fourth Node", selectedNodes)
        nodeP.Nodes.Add(node)
        node = New MultiSelectTreeNode("Fifth Node", selectedNodes)
        nodeP.Nodes.Add(node)
        node = New MultiSelectTreeNode("Sixth Node", selectedNodes)
        nodeP.Nodes.Add(node)
        node = New MultiSelectTreeNode("Seventh Node", selectedNodes)
        nodeP.Nodes.Add(node)

        treeView1.ExpandAll()
    End Sub

    Private Sub cmdGetSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetSelected.Click
        Dim nodeText As String = ""
        For Each node As TreeNode In selectedNodes
            nodeText &= node.Text & vbNewLine
        Next

        MessageBox.Show(nodeText)
    End Sub

    Private Sub treeView1_DrawNode(ByVal sender As Object, _
  ByVal e As DrawTreeNodeEventArgs) Handles treeView1.DrawNode

        ' Check for multiple selection support.
        If Not TypeOf e.Node Is MultiSelectTreeNode Then
            ' No multiple selection support.
            e.DrawDefault = True
        Else
            Dim multiNode As MultiSelectTreeNode = CType(e.Node, MultiSelectTreeNode)

            ' Retrieve the node font. If the node font has not been set,
            ' use the TreeView font.
            Dim nodeFont As Font = multiNode.NodeFont
            If nodeFont Is Nothing Then nodeFont = treeView1.Font

            ' Create brushes for the background and foreground.
            Dim backBrush, foreBrush As Brush
            If multiNode.IsSelected Then
                foreBrush = SystemBrushes.HighlightText
                backBrush = SystemBrushes.Highlight
            Else
                If multiNode.ForeColor <> Color.Empty Then
                    foreBrush = New SolidBrush(multiNode.ForeColor)
                Else
                    foreBrush = New SolidBrush(multiNode.TreeView.ForeColor)
                End If

                If multiNode.BackColor <> Color.Empty Then
                    backBrush = New SolidBrush(multiNode.BackColor)
                Else
                    backBrush = New SolidBrush(multiNode.TreeView.BackColor)
                End If
            End If
            ' Draw the background of the selected node. 
            Dim bounds As Rectangle = e.Bounds
            bounds.X += 1
            e.Graphics.FillRectangle(backBrush, bounds)

            ' Draw the node text.
            e.Graphics.DrawString(e.Node.Text, nodeFont, foreBrush, e.Bounds.X, e.Bounds.Y)

            ' If the node has focus, draw the focus rectangle.
            If (e.State And TreeNodeStates.Focused) <> 0 Then
                Dim focusPen As New Pen(Color.Black)
                Using focusPen
                    focusPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
                    Dim focusBounds As Rectangle = e.Bounds
                    focusBounds.Size = New Size(focusBounds.Width, _
                      focusBounds.Height - 1)
                    e.Graphics.DrawRectangle(focusPen, focusBounds)
                End Using
            End If

            ' Dispose brushes if they were created
            ' just for this node.
            If Not multiNode.IsSelected Then
                backBrush.Dispose()
                foreBrush.Dispose()
            End If
        End If
    End Sub

    Private Sub treeView1_MouseDown(ByVal sender As Object, _
  ByVal e As MouseEventArgs) Handles treeView1.MouseDown

        ' Test if the click was on a node.
        Dim nodeHit As TreeNode = treeView1.HitTest(e.X, e.Y).Node
        If nodeHit Is Nothing Then Return

        If TypeOf nodeHit Is MultiSelectTreeNode Then
            ' Get the node that was clicked.
            Dim multiNode As MultiSelectTreeNode = CType(nodeHit, MultiSelectTreeNode)

            ' Use advanced selection rules.
            If (Control.ModifierKeys And Keys.Control) = 0 Then
                ' Ctrl is not held down.
                ' Remove previous selection.
                Dim nodesToDelete As New List(Of MultiSelectTreeNode)()
                For Each node As MultiSelectTreeNode In selectedNodes
                    If node IsNot multiNode Then
                        nodesToDelete.Add(node)
                    End If
                Next
                For Each node As MultiSelectTreeNode In nodesToDelete
                    node.UnSelect()
                Next

            End If

            If multiNode.IsSelected Then
                ' Node is already selected.
                ' Toggle it off.
                multiNode.UnSelect()
            Else
                multiNode.Select()
            End If
        End If
    End Sub

End Class