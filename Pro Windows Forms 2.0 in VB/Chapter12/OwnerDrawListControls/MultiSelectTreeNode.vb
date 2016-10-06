Public Class MultiSelectTreeNode
    Inherits TreeNode

    Private selected As Boolean = False
    Public Overloads ReadOnly Property IsSelected() As Boolean
        Get
            Return selected
        End Get
    End Property

    Private selectedNodes As List(Of MultiSelectTreeNode)

    Public Sub New(ByVal text As String, _
  ByVal selectedNodes As List(Of MultiSelectTreeNode))
        MyBase.New(text)
        Me.selectedNodes = selectedNodes
    End Sub

    Public Sub [Select]()
        ' Check if the selection is being changed.
        If selected <> True Then
            selected = True

            ' Update the collection.
            selectedNodes.Add(Me)
            RepaintNode()
        End If
    End Sub

    Public Sub UnSelect()
        ' Check if the selection is being changed.
        If selected <> False Then
            selected = False

            ' Update the collection.
            selectedNodes.Remove(Me)
            RepaintNode()
        End If
    End Sub

    Private Sub RepaintNode()
        ' TreeView will be null if the node hasn't been
        ' added yet.
        If MyBase.TreeView IsNot Nothing AndAlso MyBase.IsVisible Then
            ' Repaint the node.
            MyBase.TreeView.Invalidate(MyBase.Bounds)
        End If
    End Sub

End Class
