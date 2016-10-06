<Serializable()> _
Public Class ShapeCollection
    Inherits CollectionBase

    Public Sub Remove(ByVal shapeToRemove As Shape)
        List.Remove(shapeToRemove)
    End Sub

    Public ReadOnly Property Item(ByVal index As Integer) As Shape
        Get
            Return CType(List(index), Shape)
        End Get
    End Property

    Public Sub Add(ByVal shapeToAdd As Shape)
        ' Reorder the shapes so the new shape is on top.
        For Each shape As Shape In List
            shape.ZOrder += 1
        Next
        shapeToAdd.ZOrder = 0
        List.Add(shapeToAdd)
    End Sub

    Public Sub BringShapeToFront(ByVal frontShape As Shape)
        For Each shape As Shape In List
            shape.ZOrder += 1
        Next
        frontShape.ZOrder = 0
    End Sub

    Public Sub SendShapeToBack(ByVal backShape As Shape)
        Dim maxZOrder As Integer = 0
        For Each shape As Shape In List
            If shape.ZOrder > maxZOrder Then
                maxZOrder = shape.ZOrder
            End If
        Next
        maxZOrder += 1
        backShape.ZOrder = maxZOrder
    End Sub

    Public Function HitTest(ByVal point As Point) As Shape
        Sort()
        For Each shape As Shape In List
            If shape.HitTest(point) Or shape.HitTestBorder(point) Then
                Return shape
            End If
        Next
        Return Nothing
    End Function

    Public Sub Sort()
        InnerList.Sort()
    End Sub

    <NonSerialized()> Private ReverseComparer As New ReverseZOrderComparer()
    Public Sub ReverseSort()
        InnerList.Sort(ReverseComparer)
    End Sub

End Class

Public Class ReverseZOrderComparer
    Implements IComparer

    Public Function Compare(ByVal shapeA As Object, ByVal shapeB As Object) As Integer _
      Implements IComparer.Compare
        ' Call the CompareTo() method in the reverse order.
        ' This gives a highest-to-lowest sort.
        Return CType(shapeB, Shape).CompareTo(CType(shapeA, Shape))
    End Function

End Class
