Public Class FormattedListItemWrapper

    Private _item As Object
    Public Property Item() As Object
        Get
            Return _item
        End Get
        Set(ByVal value As Object)
            _item = value
        End Set
    End Property

            Private _foreColor As Color
    Public Property ForeColor As Color
        Get
            Return _foreColor
        End Get
        Set(ByVal value As Color)
            _foreColor = value
        End Set
    End Property

    Private _backColor As Color
    Public Property BackColor() As Color
        Get
            Return _backColor
        End Get
        Set(ByVal value As Color)
            _backColor = value
        End Set
    End Property

    Private _font As Font
    Public Property Font() As Font
        Get
            Return _font
        End Get
        Set(ByVal value As Font)
            _font = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        If item Is Nothing Then
            Return ""
        Else
            Return item.ToString()
        End If
    End Function

    Public Sub New(ByVal item As Object)
        Me.Item = item
    End Sub

    Public Sub New(ByVal item As Object, ByVal Font As Font)
        Me.New(item)
        Me.Font = Font
    End Sub

    Public Sub New(ByVal item As Object, ByVal Font As Font, _
    ByVal foreColor As Color, ByVal backColor As Color)
        Me.New(item, Font)
        Me.ForeColor = foreColor
        Me.BackColor = backColor
    End Sub
        
End Class
