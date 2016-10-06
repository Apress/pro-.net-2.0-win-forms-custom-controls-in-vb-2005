Public Class DirectorySelectedEventArgs
    Inherits EventArgs

    Private _directoryName As String

    Public Property DirectoryName() As String
        Get
            Return _directoryName
        End Get
        Set(ByVal value As String)
            _directoryName = value
        End Set
    End Property

    Public Sub New(ByVal directoryName As String)
        Me.DirectoryName = directoryName
    End Sub

End Class
