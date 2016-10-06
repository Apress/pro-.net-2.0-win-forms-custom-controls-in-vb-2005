Public Class ProjectTreeNode
    Inherits TreeNode

    Private _project As Project
    Public ReadOnly Property Project() As Project
        Get
            Return _project
        End Get
    End Property

    Public Sub New(ByVal project As Project, ByVal text As String, _
      ByVal imageIndex As Integer, ByVal selectedImageIndex As Integer)
        ' Call the base class (TreeNode) constructor.
        MyBase.New(text, imageIndex, selectedImageIndex)

        ' Store the project.
        _project = project
    End Sub

End Class
