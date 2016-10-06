Public Class ProjectSelectedEventArgs
    Inherits EventArgs

    Private _project As Project
    Public Property Project() As Project
        Get
            Return _project
        End Get
        Set(ByVal value As Project)
            _project = value
        End Set
    End Property

    Public Sub New(ByVal project As Project)
        Me.Project = project
    End Sub

End Class
