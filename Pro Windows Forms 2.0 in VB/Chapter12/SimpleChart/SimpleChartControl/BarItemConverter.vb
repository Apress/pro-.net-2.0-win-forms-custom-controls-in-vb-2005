Imports System.ComponentModel
Imports System.ComponentModel.Design.Serialization
Imports System.Reflection
Imports System.Globalization

Public Class BarItemConverter
    Inherits ExpandableObjectConverter

    Public Overrides Function CanConvertFrom(ByVal context As ITypeDescriptorContext, ByVal t As Type) As Boolean
        If t Is GetType(String) Then
            Return True
        Else
            Return MyBase.CanConvertFrom(context, t)
        End If
    End Function

    Public Overrides Function CanConvertTo(ByVal context As ITypeDescriptorContext, ByVal destType As Type) As Boolean
        If destType Is GetType(InstanceDescriptor) Or destType Is GetType(String) Then
            Return True
        Else
            Return MyBase.CanConvertTo(context, destType)
        End If
    End Function

    Public Overrides Function ConvertFrom(ByVal context As ITypeDescriptorContext, ByVal info As CultureInfo, ByVal value As Object) As Object
        If value.GetType Is GetType(String) Then
            Try
                Dim elements() As String = CStr(value).Split(",")
                Return New BarItem(elements(0), Single.Parse(elements(1)))
            Catch
                Throw New ArgumentException("Could not convert the value")
            End Try
            end if
        Return MyBase.ConvertFrom(context, info, value)
    End Function

    Public Overrides Function ConvertTo(ByVal context As ITypeDescriptorContext, ByVal info As CultureInfo, ByVal value As Object, ByVal destType As Type) As Object
        Dim item As BarItem = CType(value, BarItem)
        If destType Is GetType(String) Then
            Return String.Format("{0}, {1}", item.ShortForm, item.Value)

        ElseIf destType Is GetType(InstanceDescriptor) Then
            Dim ctor As ConstructorInfo = _
              GetType(BarItem).GetConstructor( _
              New Type() {GetType(String), GetType(Single)})
            Return New InstanceDescriptor(ctor, _
                   New Object() {item.ShortForm, item.Value})
        Else
            Return MyBase.ConvertTo(context, info, value, destType)
        End If
    End Function
End Class
