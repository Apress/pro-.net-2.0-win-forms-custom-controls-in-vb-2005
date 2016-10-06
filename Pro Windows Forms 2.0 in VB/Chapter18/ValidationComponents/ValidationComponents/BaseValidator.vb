Imports System.ComponentModel

Public MustInherit Class BaseValidator
    ' Use an internal error provider to show error icons.
    Private errorProvider As New ErrorProvider()

    ' Expose whatever ErrorProvider settings you want the
    ' user to be able to modify (like Icon, BlinkStyle, and BlinkRate).
    ' This class exposes only Icon.
    Public Property Icon() As Icon
        Get
            Return errorProvider.Icon
        End Get
        Set(ByVal value As Icon)
            errorProvider.Icon = value
        End Set
    End Property

    ' This is the error message that will be shown if validation fails.
    Private _errorMessage As String
    Public Property ErrorMessage() As String
        Get
            Return _errorMessage
        End Get
        Set(ByVal Value As String)
            _errorMessage = Value
        End Set
    End Property

    ' This property allows you to check if validation succeeded.
    ' The safest option is to default to False, and assume that
    ' any unvalidated data is not valid.
    Private _isValid As Boolean = False
    Public ReadOnly Property IsValid() As Boolean
        Get
            Return _isValid
        End Get
    End Property

    Private _cancelFocus As Boolean = False
    Public Property CancelFocusChangeWhenInvalid() As Boolean
        Get
            Return _cancelFocus
        End Get
        Set(ByVal value As Boolean)
            _cancelFocus = value
        End Set
    End Property

    ' This is the control that will be validated.
    ' The ReferenceConverter allows the user to choose a control from
    ' a drop-down list with all the controls on the form.
    Private _controlToValidate As Control

    <TypeConverter(GetType(ReferenceConverter))> _
Public Property ControlToValidate() As Control
        Get
            Return _controlToValidate
        End Get
        Set(ByVal value As Control)
            ' Detach event handler from previous control.
            If _controlToValidate IsNot Nothing And Not DesignMode Then
                RemoveHandler _controlToValidate.Validating, _
                  AddressOf ControlToValidate_Validating
            End If
            _controlToValidate = value

            ' Hook up the control's Validating event.
            If _controlToValidate IsNot Nothing And Not DesignMode Then
                AddHandler _controlToValidate.Validating, _
                  AddressOf ControlToValidate_Validating
            End If
        End Set
    End Property

    ' Validate the control when the Validating event fires.
    Private Sub ControlToValidate_Validating(ByVal sender As Object, _
      ByVal e As CancelEventArgs)
        Validate()

        ' Cancel the focus change if the data is invalid,
        ' and this is the configured behavior.
        If Not IsValid And CancelFocusChangeWhenInvalid Then e.Cancel = True
    End Sub

    ' This is a public method so that validation can be triggered
    ' manually if you want, not just in response to the Validating event.
    Public Function Validate() As Boolean
        ' Validate the control (using whatever functionality
        ' is provided in the derived class).
        _isValid = EvaluateIsValid()

        If IsValid Then
            ' Clear the error message.
            errorProvider.SetError(ControlToValidate, "")
        Else
            ' Display the error message.
            errorProvider.SetError(ControlToValidate, ErrorMessage)
        End If

        Return IsValid
    End Function

    ' This is the method where the derived classes will
    ' execute their validation logic.
    Protected MustOverride Function EvaluateIsValid() As Boolean

    Public Shared Function IsFormValid(ByVal formComponents As IContainer) As Boolean
        Dim invalidInput As Boolean = False

        ' Maybe nothing to validate...
        If formComponents Is Nothing Then
            Return (True)
        End If

        ' Make sure all the validation is performed.
        For Each component As IComponent In formComponents.Components
            If TypeOf component Is BaseValidator Then
                Dim validator As BaseValidator = CType(component, BaseValidator)
                validator.Validate()
                If Not validator.IsValid Then
                    invalidInput = True
                    Exit For
                End If
            End If
        Next
        Return Not invalidInput
    End Function

End Class
