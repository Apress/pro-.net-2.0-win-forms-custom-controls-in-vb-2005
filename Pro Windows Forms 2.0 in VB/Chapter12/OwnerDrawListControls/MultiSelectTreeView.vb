Imports System.Collections.ObjectModel

Public Class MultiSelectTreeView
    Inherits TreeView

    ' Force the tree to use owner drawing.
    Public Sub New()
        MyBase.DrawMode = TreeViewDrawMode.OwnerDrawText
    End Sub

    ' Track the selected nodes.
    Private _selectedNodes As New List(Of MultiSelectTreeNode2)()

    Public ReadOnly Property SelectedNodes() As _
      ReadOnlyCollection(Of MultiSelectTreeNode2)
        Get
            ' Return a read-only wrapper for this collection.
            ' The only way to change selection is through the
            ' MultiSelectTreeNode methods.
            Return _selectedNodes.AsReadOnly()
        End Get
    End Property

    Protected Overrides Sub OnDrawNode(ByVal e As DrawTreeNodeEventArgs)
        ' Check for multiple selection support.
        If Not TypeOf e.Node Is MultiSelectTreeNode2 Then
            ' No multiple selection support.
            e.DrawDefault = True
        Else
            Dim multiNode As MultiSelectTreeNode2 = CType(e.Node, MultiSelectTreeNode2)

            ' Retrieve the node font. If the node font has not been set,
            ' use the TreeView font.
            Dim nodeFont As Font = multiNode.NodeFont
            If nodeFont Is Nothing Then nodeFont = Me.Font

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

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        ' Test if the click was on a node.
        Dim nodeHit As TreeNode = Me.HitTest(e.X, e.Y).Node
        If nodeHit Is Nothing Then Return

        If TypeOf nodeHit Is MultiSelectTreeNode2 Then
            ' Get the node that was clicked.
            Dim multiNode As MultiSelectTreeNode2 = CType(nodeHit, MultiSelectTreeNode2)

            ' Use advanced selection rules.
            If (Control.ModifierKeys And Keys.Control) = 0 Then
                ' Ctrl is not held down.
                ' Remove previous selection.
                Dim nodesToDelete As New List(Of MultiSelectTreeNode2)()
                For Each node As MultiSelectTreeNode2 In SelectedNodes
                    If node IsNot multiNode Then
                        nodesToDelete.Add(node)
                    End If
                Next
                For Each node As MultiSelectTreeNode2 In nodesToDelete
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

    Public Overloads Sub [Select](ByVal node As MultiSelectTreeNode2)

        If Not node.IsSelected Then
            node.IsSelected = True
            ' Update the collection.
            _selectedNodes.Add(node)
            MyBase.Invalidate(MyBase.Bounds)
        End If
    End Sub

    Public Sub UnSelect(ByVal node As MultiSelectTreeNode2)

        If node.IsSelected Then
            node.IsSelected = False

            ' Update the collection.
            _selectedNodes.Remove(node)
            MyBase.Invalidate(MyBase.Bounds)
        End If
    End Sub
End Class

Public Class MultiSelectTreeNode2
    Inherits TreeNode

    Private selected As Boolean = False
    Public Overloads Property IsSelected() As Boolean
        Get
            Return selected
        End Get
        Friend Set(ByVal value As Boolean)
            selected = value
        End Set
    End Property

    Private selectedNodes As List(Of MultiSelectTreeNode)

    Public Sub New(ByVal text As String)
        MyBase.New(text)
    End Sub

    Private ReadOnly Property MultiSelectTreeView() As MultiSelectTreeView
        Get
            Return CType(MyBase.TreeView, MultiSelectTreeView)
        End Get
    End Property

    Public Sub [Select]()

        ' Check if the selection is being changed.
        If selected <> True Then
            If MultiSelectTreeView IsNot Nothing Then
                MultiSelectTreeView.Select(Me)
            End If
        End If
    End Sub

    Public Sub UnSelect()

        ' Check if the selection is being changed.
        If selected <> False Then
            If MultiSelectTreeView IsNot Nothing Then
                MultiSelectTreeView.UnSelect(Me)
            End If
        End If
    End Sub

End Class
