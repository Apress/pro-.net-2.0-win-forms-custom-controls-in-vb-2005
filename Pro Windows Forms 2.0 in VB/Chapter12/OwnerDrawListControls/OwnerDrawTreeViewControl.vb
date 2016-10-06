Public Class OwnerDrawTreeViewControl

    Private Sub OwnerDrawTreeViewControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim nodeP As New MultiSelectTreeNode2("Node Group")
        TreeView1.Nodes.Add(nodeP)

        Dim node As New MultiSelectTreeNode2("First Node")
        node.Select()
        nodeP.Nodes.Add(node)
        node = New MultiSelectTreeNode2("Second Node")
        nodeP.Nodes.Add(node)
        node = New MultiSelectTreeNode2("Third Node")
        nodeP.Nodes.Add(node)
        node = New MultiSelectTreeNode2("Fourth Node")
        nodeP.Nodes.Add(node)
        node = New MultiSelectTreeNode2("Fifth Node")
        nodeP.Nodes.Add(node)
        node = New MultiSelectTreeNode2("Sixth Node")
        nodeP.Nodes.Add(node)
        node = New MultiSelectTreeNode2("Seventh Node")
        nodeP.Nodes.Add(node)

        TreeView1.ExpandAll()
    End Sub

    Private Sub cmdGetSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetSelected.Click
        Dim nodeText As String = ""
        For Each node As TreeNode In TreeView1.SelectedNodes

            nodeText &= node.Text & vbNewLine
        Next

        MessageBox.Show(nodeText)
    End Sub
End Class