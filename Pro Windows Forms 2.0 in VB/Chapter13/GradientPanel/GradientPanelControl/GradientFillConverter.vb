Imports System.ComponentModel
Imports System.Globalization
Imports System.Drawing.Drawing2D
Imports System.Reflection
Imports System.ComponentModel.Design.Serialization

' This version of the GradientFillConverter supports
' conversions to strings only.
'Public Class GradientFillConverter
'    Inherits ExpandableObjectConverter

'    Public Overrides Function CanConvertTo(ByVal context As ITypeDescriptorContext, _
'  ByVal destinationType As Type) As Boolean
'        If destinationType Is GetType(String) Then
'            Return True
'        Else
'            Return MyBase.CanConvertTo(context, destinationType)
'        End If
'    End Function

'    Public Overrides Function ConvertTo( _
'  ByVal context As ITypeDescriptorContext, ByVal culture As CultureInfo, _
'  ByVal value As Object, ByVal destinationType As Type) As Object
'        If destinationType Is GetType(String) Then
'            Return ConvertToString(value)
'        Else
'            Return MyBase.ConvertTo(context, culture, value, destinationType)
'        End If
'    End Function

'    Public Overloads Function ConvertToString(ByVal value As Object) As String
'        Dim fill As GradientFill = CType(value, GradientFill)
'        Dim converter As New ColorConverter()
'        Return String.Format("{0}, {1}, {2}", converter.ConvertToString(fill.ColorA), _
'          converter.ConvertToString(fill.ColorB), fill.GradientFillStyle)
'    End Function

'    Public Overrides Function CanConvertFrom(ByVal context As ITypeDescriptorContext, _
'  ByVal sourceType As Type) As Boolean
'        If sourceType Is GetType(String) Then
'            Return True
'        Else
'            Return MyBase.CanConvertFrom(context, sourceType)
'        End If
'    End Function

'    Public Overrides Function ConvertFrom(ByVal context As ITypeDescriptorContext, _
'  ByVal culture As CultureInfo, ByVal value As Object) As Object
'        If TypeOf value Is String Then
'            Return ConvertFromString(value)
'        Else
'            Return MyBase.ConvertFrom(context, culture, value)
'        End If
'    End Function

'    Public Overloads Function ConvertFromString(ByVal value As Object) As GradientFill
'        Dim values() As String = CStr(value).Split(",")
'        If values.Length <> 3 Then
'            Throw New ArgumentException("Could not convert the value")
'        End If

'        Try
'            Dim gradient As New GradientFill()

'            ' Retrieve the colors.
'            Dim converter As New ColorConverter()
'            gradient.ColorA = CType(converter.ConvertFromString(values(0)), Color)
'            gradient.ColorB = CType(converter.ConvertFromString(values(1)), Color)

'            ' Convert the name of the enumerated value into the corresponding
'            ' enumerated value (which is actually an integer constant).
'            gradient.GradientFillStyle = CType(System.Enum.Parse( _
'          GetType(LinearGradientMode), values(2), True), LinearGradientMode)

'            Return gradient
'        Catch err As Exception
'            Throw New ArgumentException("Could not convert the value")
'        End Try

'    End Function

'End Class

' This version of the GradientFillConverter uses a constructor
' to create new GradientFill objects when a property is changed.
Public Class GradientFillConverter
    Inherits ExpandableObjectConverter

    Public Overrides Function GetCreateInstanceSupported( _
      ByVal context As ITypeDescriptorContext) As Boolean
        ' Always force a new instance.
        Return True
    End Function

    Public Overrides Function CreateInstance( _
  ByVal context As ITypeDescriptorContext, ByVal propertyValues As IDictionary) As Object
        ' Create the new instance.
        Dim fill As New GradientFill()
        fill.ColorA = CType(propertyValues("ColorA"), Color)
        fill.ColorB = CType(propertyValues("ColorB"), Color)
        fill.GradientFillStyle = CType( _
          propertyValues("GradientFillStyle"), LinearGradientMode)
        Return fill
    End Function


    Public Overrides Function CanConvertTo( _
      ByVal context As ITypeDescriptorContext, ByVal destinationType As Type) _
      As Boolean
        If destinationType Is GetType(InstanceDescriptor) Then
            Return True
        Else
            Return MyBase.CanConvertTo(context, destinationType)
        End If
    End Function

    Public Overrides Function ConvertTo(ByVal context As ITypeDescriptorContext, _
   ByVal culture As CultureInfo, ByVal value As Object, _
   ByVal destinationType As Type) As Object
        If destinationType Is GetType(InstanceDescriptor) And _
          TypeOf value Is GradientFill Then
            Dim gradient As GradientFill = CType(value, GradientFill)

            ' Specify the three-parameter (Color-Color-LinearGradientMode)
            ' constructor.
            Dim ctor As ConstructorInfo = _
                GetType(GradientFill).GetConstructor( _
                New Type() { _
                  GetType(Color), GetType(Color), GetType(LinearGradientMode)})

            Return New InstanceDescriptor(ctor, _
                New Object() { _
                  gradient.ColorA, gradient.ColorB, gradient.GradientFillStyle})
        Else
            Return MyBase.ConvertTo(context, culture, value, destinationType)
        End If
    End Function


    Public Overloads Function ConvertToString(ByVal value As Object) As String
        Dim fill As GradientFill = CType(value, GradientFill)
        Dim converter As New ColorConverter()
        Return String.Format("{0}, {1}, {2}", converter.ConvertToString(fill.ColorA), _
          converter.ConvertToString(fill.ColorB), fill.GradientFillStyle)
    End Function

    Public Overrides Function CanConvertFrom(ByVal context As ITypeDescriptorContext, _
  ByVal sourceType As Type) As Boolean
        If sourceType Is GetType(String) Then
            Return True
        Else
            Return MyBase.CanConvertFrom(context, sourceType)
        End If
    End Function

    Public Overrides Function ConvertFrom(ByVal context As ITypeDescriptorContext, _
  ByVal culture As CultureInfo, ByVal value As Object) As Object
        If TypeOf value Is String Then
            Return ConvertFromString(value)
        Else
            Return MyBase.ConvertFrom(context, culture, value)
        End If
    End Function

    Public Overloads Function ConvertFromString(ByVal value As Object) As GradientFill
        Dim values() As String = CStr(value).Split(",")
        If values.Length <> 3 Then
            Throw New ArgumentException("Could not convert the value")
        End If

        Try
            Dim gradient As New GradientFill()

            ' Retrieve the colors.
            Dim converter As New ColorConverter()
            gradient.ColorA = CType(converter.ConvertFromString(values(0)), Color)
            gradient.ColorB = CType(converter.ConvertFromString(values(1)), Color)

            ' Convert the name of the enumerated value into the corresponding
            ' enumerated value (which is actually an integer constant).
            gradient.GradientFillStyle = CType(System.Enum.Parse( _
          GetType(LinearGradientMode), values(2), True), LinearGradientMode)

            Return gradient
        Catch err As Exception
            Throw New ArgumentException("Could not convert the value")
        End Try

    End Function

End Class

