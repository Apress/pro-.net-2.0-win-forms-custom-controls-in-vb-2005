Public Class RequiredFieldValidator
    Inherits BaseValidator

    Protected Overrides Function EvaluateIsValid() As Boolean
        ' This is valid, as long as the value is not blank.
        Return (ControlToValidate.Text.Trim().Length <> 0)
    End Function

    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyBase.New()
        container.Add(Me)
    End Sub
End Class
