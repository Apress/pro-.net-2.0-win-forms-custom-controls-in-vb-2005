Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel.Design


Public Class BarItemCollectionEditor
    Inherits CollectionEditor

    Public Sub New(ByVal type As Type)
        MyBase.New(type)
    End Sub

    Public Overloads Overrides Function EditValue(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal provider As IServiceProvider, ByVal value As Object) As Object
        Dim returnObject As Object = MyBase.EditValue(context, provider, value)
        CType(context.Instance, SimpleChart).RebuildChart()
        Return returnObject
    End Function

    Protected Overrides Function CreateInstance(ByVal itemType As Type) As Object
        Dim item As New BarItem("Enter Title Here", 0)
        Return item
    End Function


End Class

