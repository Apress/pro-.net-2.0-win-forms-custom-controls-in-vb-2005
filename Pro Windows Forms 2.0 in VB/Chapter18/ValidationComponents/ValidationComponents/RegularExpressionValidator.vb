Imports System.Text.RegularExpressions

Public Class RegularExpressionValidator
    Inherits BaseValidator

    ' Store the regular expression.
    Private _validationExpression As String
    Public Property ValidationExpression() As String
        Get
            Return _validationExpression
        End Get
        Set(ByVal value As String)
            _validationExpression = value
        End Set
    End Property

    ' Validate with the regular expression.
    Protected Overrides Function EvaluateIsValid() As Boolean
        ' Don't validate if empty (that's a job for the RequiredFieldValidator).
        If ControlToValidate.Text.Trim().Length = 0 Then Return True

        ' Evaluate the regular expression.
        Dim expression As New Regex(ValidationExpression)
        Return expression.IsMatch(ControlToValidate.Text)
    End Function

    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyBase.New()
        container.Add(Me)
    End Sub
End Class
