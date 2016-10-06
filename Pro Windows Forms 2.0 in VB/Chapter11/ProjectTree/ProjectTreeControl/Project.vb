Public Class Project

    ' Use an enumeration to represent the three project status types.
    Public Enum StatusType
        Unassigned
        InProgress
        Closed
    End Enum

    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _description As String
    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property

    Private _status As StatusType
    Public Property Status() As StatusType
        Get
            Return _status
        End Get
        Set(ByVal value As StatusType)
            _status = value
        End Set
    End Property

    Public Sub New(ByVal name As String, _
      ByVal description As String, ByVal status As StatusType)
        Me.Name = name
        Me.Description = description
        Me.Status = status
    End Sub

End Class
