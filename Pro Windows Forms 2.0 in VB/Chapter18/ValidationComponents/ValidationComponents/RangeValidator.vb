Public Enum ValidationDataType
    [Integer]
    [Double]
    Text
End Enum

Public Class RangeValidator
    Inherits BaseValidator

    ' Determines how the ranges are compared
    ' (numerically or alphabetically).
    Private _validationDataType As ValidationDataType
    Public Property Type() As ValidationDataType
        Get
            Return _validationDataType
        End Get
        Set(ByVal value As ValidationDataType)
            _validationDataType = value
        End Set
    End Property

    ' Set a minimum and maximum allowed value.
    ' You could add checks to make sure the minimum value
    ' isn't greater than the maximum value.
    Private _minimumValue As String = ""
    Public Property MinimumValue() As String
        Get
            Return _minimumValue
        End Get
        Set(ByVal value As String)
            _minimumValue = value
        End Set
    End Property

    Private _maximumValue As String = ""
    Public Property MaximumValue() As String
        Get
            Return _maximumValue
        End Get
        Set(ByVal value As String)
            _maximumValue = value
        End Set
    End Property

    Protected Overrides Function EvaluateIsValid() As Boolean
        ' Don't validate if empty (that's a job for the RequiredFieldValidator).
        If ControlToValidate.Text.Trim().Length = 0 Then Return True

        Select Case Type
            Case ValidationDataType.Double, ValidationDataType.Integer
                If Type = ValidationDataType.Integer Then
                    ' Check there's no decimal point.
                    If ControlToValidate.Text.IndexOf(".") <> -1 Then
                        Return False
                    End If
                End If

                Try
                    Dim valD As Double = Double.Parse(ControlToValidate.Text)
                    Return valD >= Double.Parse(MinimumValue) And _
                           valD <= Double.Parse(MaximumValue)
                Catch
                    ' The text can't be converted to a number
                    Return False
                End Try

            Case ValidationDataType.Text
                Dim valS As String = ControlToValidate.Text
                Return String.Compare(valS, MinimumValue) >= 0 And _
                    String.Compare(valS, MaximumValue) <= 0
            Case Else
                Return False
        End Select
    End Function

    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyBase.New()
        container.Add(Me)
    End Sub
End Class
