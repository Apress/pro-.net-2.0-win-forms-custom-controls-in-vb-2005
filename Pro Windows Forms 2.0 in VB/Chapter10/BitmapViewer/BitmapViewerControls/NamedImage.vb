Friend Class NamedImage

    Private _image As Image
    Public Property Image() As Image
        Get
            Return _image
        End Get
        Set(ByVal value As Image)
            _image = value
        End Set
    End Property

    Private _fileName As String
    Public Property FileName() As String
        Get
            Return _fileName
        End Get
        Set(ByVal value As String)
            _fileName = value
        End Set
    End Property

    Public Sub New(ByVal image As Image, ByVal fileName As String)
        Me.Image = image
        Me.FileName = fileName
    End Sub

End Class
