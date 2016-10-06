Public Class Product

    Private _modelNumber As String
    Public Property ModelNumber() As String
        Get
            Return _modelNumber
        End Get
        Set(ByVal value As String)
            _modelNumber = value
        End Set
    End Property

    Private _modelName As String
    Public Property ModelName() As String
        Get
            Return _modelName
        End Get
        Set(ByVal value As String)
            _modelName = value
        End Set
    End Property

    Private _unitCost As Decimal
    Public Property UnitCost() As Decimal
        Get
            Return _unitCost
        End Get
        Set(ByVal value As Decimal)
            _unitCost = value
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

    Public Sub New(ByVal modelNumber As String, ByVal modelName As String, _
      ByVal unitCost As Decimal, ByVal description As String)
        Me.ModelNumber = modelNumber
        Me.ModelName = modelName
        Me.UnitCost = unitCost
        Me.Description = description
    End Sub

    Public Sub New()
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("{0} ({1})", modelName, modelNumber)
    End Function
End Class

