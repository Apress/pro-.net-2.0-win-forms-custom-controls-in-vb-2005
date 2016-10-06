Imports System.Text
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Drawing.Design


<Editor(GetType(BarItemCollectionEditor), GetType(System.Drawing.Design.UITypeEditor))> _
Public Class BarItemCollection
    Inherits CollectionBase
    Public Sub Add(ByVal item As BarItem)
        Me.List.Add(item)
    End Sub

    Public Sub Remove(ByVal index As Integer)
        ' Check to see if there is an item at the supplied index.
        If (index > Count - 1) OrElse (index < 0) Then
            Throw New System.IndexOutOfRangeException()
        Else
            Me.List.RemoveAt(index)
        End If
    End Sub

    Default Public Property Item(ByVal i As Integer) As BarItem
        Get
            Return CType(Me.List(i), BarItem)
        End Get
        Set(ByVal value As BarItem)
            Me.List(i) = value
        End Set
    End Property
End Class
