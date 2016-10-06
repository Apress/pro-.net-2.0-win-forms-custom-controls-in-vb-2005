Public Class Form1

   
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim node As TreeNode = treeOne.Nodes.Add("Fruits")
        node.Nodes.Add("Apple")
        node.Nodes.Add("Peach")
        node.Expand()

        node = treeTwo.Nodes.Add("Vegetables")
        node.Nodes.Add("Tomato")
        node.Nodes.Add("Eggplant")
        node.Expand()

        treeTwo.AllowDrop = True
        treeOne.AllowDrop = True
    End Sub

    Private Sub tree_MouseDown(ByVal sender As Object, _
  ByVal e As System.Windows.Forms.MouseEventArgs) _
  Handles treeOne.MouseDown, treeTwo.MouseDown

        ' Get the tree.
        Dim tree As TreeView = CType(sender, TreeView)

        ' Get the node underneath the mouse.
        Dim node As TreeNode = tree.GetNodeAt(e.X, e.Y)
        tree.SelectedNode = node

        ' Start the drag-and-drop operation with a cloned copy of the node.
        If node IsNot Nothing Then
            tree.DoDragDrop(node, DragDropEffects.Copy)
        End If
    End Sub

    Private Sub tree_DragOver(ByVal sender As Object, _
  ByVal e As System.Windows.Forms.DragEventArgs) _
  Handles treeOne.DragOver, treeTwo.DragOver

        ' Get the tree.
        Dim tree As TreeView = CType(sender, TreeView)

        ' Drag and drop denied by default.
        e.Effect = DragDropEffects.None

        ' Get the dragged object.
        Dim nodeSource As TreeNode = e.Data.GetData(GetType(TreeNode))

        ' Is it a valid format?
        If nodeSource IsNot Nothing Then

            ' Make sure it's not from the current tree.
            If nodeSource.TreeView IsNot tree Then
                ' Get the screen point.
                Dim pt As New Point(e.X, e.Y)

                ' Convert to a point in the TreeView's coordinate system.
                pt = tree.PointToClient(pt)

                ' Is the mouse over a valid node?
                Dim node As TreeNode = tree.GetNodeAt(pt)
                If node IsNot Nothing Then
                    ' (You could also check the state of the Ctrl key to decide
                    '  whether to copy or move nodes.)
                    e.Effect = DragDropEffects.Copy
                    tree.SelectedNode = node
                End If
            End If
        End If
    End Sub

    Private Sub tree_DragDrop(ByVal sender As Object, _
  ByVal e As System.Windows.Forms.DragEventArgs) _
  Handles treeOne.DragDrop, treeTwo.DragDrop

        ' Get the tree.
        Dim tree As TreeView = CType(sender, TreeView)

        ' Get the screen point.
        Dim pt As New Point(e.X, e.Y)

        ' Convert to a point in the TreeView's coordinate system.
        pt = tree.PointToClient(pt)

        ' Get the node underneath the mouse.
        Dim node As TreeNode = tree.GetNodeAt(pt)

        ' Add a child node.
        Dim nodeToAdd As TreeNode = CType(e.Data.GetData(GetType(TreeNode)), TreeNode)
        node.Nodes.Add(nodeToAdd.Clone())

        ' Show the newly added node if it is not already visible.
        node.Expand()
    End Sub

End Class
