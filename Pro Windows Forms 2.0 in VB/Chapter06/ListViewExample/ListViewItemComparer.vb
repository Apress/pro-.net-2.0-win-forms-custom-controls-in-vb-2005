
Public Class ListViewItemComparer
    Implements IComparer

    Private _column As Integer
    Public Property Column() As Integer
        Get
            Return _column
        End Get
        Set(ByVal value As Integer)
            _column = value
        End Set
    End Property

    Private _numeric As Boolean = False
    Public Property Numeric() As Boolean
        Get
            Return _numeric
        End Get
        Set(ByVal value As Boolean)
            _numeric = value
        End Set
    End Property

    Private _descending As Boolean = False
    Public Property Descending() As Boolean
        Get
            Return _descending
        End Get
        Set(ByVal value As Boolean)
            _descending = value
        End Set
    End Property

    Public Sub New(ByVal columnIndex As Integer)
        Column = columnIndex
    End Sub

    Public Function Compare(ByVal x As Object, ByVal y As Object) _
      As Integer Implements System.Collections.IComparer.Compare
        Dim listX, listY As ListViewItem
        If descending Then
            listY = CType(x, ListViewItem)
            listX = CType(y, ListViewItem)
        Else
            listX = CType(x, ListViewItem)
            listY = CType(y, ListViewItem)
        End If

        If Numeric Then
            ' Convert column text to numbers before comparing.
            ' If the conversion fails, the value defaults to 0.
            Dim valX, valY As Double
            valX = Val(listX.SubItems(Column).Text)
            valY = Val(listY.SubItems(Column).Text)

            ' Perform a numeric comparison.
            Return Decimal.Compare(valX, valY)
        Else
            ' Perform an alphabetic comparison.
            Return String.Compare( _
              listX.SubItems(Column).Text, listY.SubItems(Column).Text)
        End If
    End Function

End Class
