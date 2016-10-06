Imports System.ComponentModel

Public Class ProductList
    Inherits BindingList(Of Product)

    Public Sub New()
        MyBase.AllowNew = True
    End Sub

    Protected Overrides Function AddNewCore() As Object
        ' Create a new Product, and supply a unique model number
        ' and some placeholder values.
        Dim product As New Product(Guid.NewGuid().ToString(), _
          "[ModelName]", 0, "[Description]")

        ' Add the item to the collection.
        MyBase.Items.Add(product)
        Return product
    End Function
End Class

