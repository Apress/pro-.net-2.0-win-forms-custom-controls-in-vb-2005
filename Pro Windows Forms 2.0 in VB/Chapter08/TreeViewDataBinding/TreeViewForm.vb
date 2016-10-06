Public Class TreeViewForm

    Private Sub TreeViewForm_Load(ByVal sender As System.Object, _
   ByVal e As System.EventArgs) Handles MyBase.Load
        Dim nodeParent As TreeNode
        For Each row As DataRow In Program.StoreDB.GetCategories().Rows
            ' Add the category node.
            nodeParent = _
              treeDB.Nodes.Add(row(StoreDB.CategoryField.Name).ToString())
            nodeParent.ImageIndex = 0

            ' Store the disconnected category information.
            nodeParent.Tag = row

            ' Add a "dummy" node.
            nodeParent.Nodes.Add("*")
        Next
    End Sub

    Private Sub treeDB_BeforeExpand(ByVal sender As System.Object, _
  ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) _
  Handles treeDB.BeforeExpand

        Dim nodeSelected, nodeChild As TreeNode
        nodeSelected = e.Node
        If nodeSelected.Nodes(0).Text = "*" Then
            ' This is a dummy node.
            nodeSelected.Nodes.Clear()

            For Each row As DataRow In _
              Program.StoreDB.GetProductsInCategory(CType(nodeSelected.Tag, DataRow))

                Dim field As String = row(StoreDB.ProductField.Name).ToString()
                nodeChild = nodeSelected.Nodes.Add(field)

                ' Store the disconnected product information.
                nodeChild.Tag = row

            Next
        End If
    End Sub

    Private Sub treeDB_AfterSelect(ByVal sender As System.Object, _
      ByVal e As System.Windows.Forms.TreeViewEventArgs) _
      Handles treeDB.AfterSelect
        lblInfo.Text = Program.StoreDB.GetDisplayText(CType(e.Node.Tag, DataRow))
    End Sub


End Class
