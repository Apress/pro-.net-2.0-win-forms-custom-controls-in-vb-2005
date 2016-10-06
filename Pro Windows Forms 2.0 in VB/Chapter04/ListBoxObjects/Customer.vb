Public Class Customer

    Public FirstName As String
    Public LastName As String
    Public BirthDate As DateTime

    Public Sub New(ByVal firstName As String, _
      ByVal lastName As String, ByVal birthDate As DateTime)
        Me.FirstName = firstName
        Me.LastName = lastName
        Me.BirthDate = birthDate
    End Sub

    Public Overrides Function ToString() As String
        Return FirstName & " " & LastName
    End Function

End Class

