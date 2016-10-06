Imports System.ComponentModel

<Serializable()> _
<TypeConverter(GetType(BarItemConverter))> _
Public Class BarItem

    Private _shortForm As String
    Public Property ShortForm() As String
        Get
            Return _shortForm
        End Get
        Set(ByVal value As String)
            _shortForm = value
        End Set
    End Property

    Private _barValue As Single
    Public Property Value() As Single
        Get
            Return _barValue
        End Get
        Set(ByVal value As Single)
            _barValue = value
        End Set
    End Property

    Public Sub New(ByVal shortForm As String, ByVal value As Single)
        Me.ShortForm = shortForm
        Me.Value = value
    End Sub

End Class
