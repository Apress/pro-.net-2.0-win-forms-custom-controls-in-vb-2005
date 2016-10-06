Imports System.ComponentModel

' This class is the base for all button controls in this project.
' It contains fields so that inheriting buttons can track 
' button state (normal, hover, pressed, and disabled)
Public MustInherit Class StateButtonBase
    Inherits Control
    Implements IButtonControl

    'ToDo: Add Implements Clauses for implementation methods of these interface(s)
    '

    Private _dialogResult As DialogResult = dialogResult.None
    Private _state As StateButtonState

    Public Sub New()
        SetStyle(ControlStyles.StandardClick Or ControlStyles.StandardDoubleClick, False)
    End Sub 'New

    Protected Overrides ReadOnly Property DefaultSize() As Size
        Get
            Return New Size(75, 23)
        End Get
    End Property

    <Category("Behavior"), DefaultValue(GetType(DialogResult), "DialogResult.None"), Description("Specifies the dialog result that this button will return when a form is closed by clicking it")> _
        Public Property DialogResult() As DialogResult Implements IButtonControl.DialogResult
        Get
            Return _dialogResult
        End Get
        Set(ByVal value As DialogResult)
            _dialogResult = value
        End Set
    End Property

    Protected ReadOnly Property State() As StateButtonState
        Get
            Return _state
        End Get
    End Property

    Private Sub SetState(ByVal setState As StateButtonState, ByVal [set] As Boolean)
        Dim newState As StateButtonState = Me.state
        If [set] Then
            newState = newState Or setState
        Else
            newState = newState And Not setState
        End If

        If Me.state <> newState Then
            _state = newState
            Invalidate()
        End If
    End Sub

    Public Sub NotifyDefault(ByVal isDefault As Boolean) Implements IButtonControl.NotifyDefault
        SetState(StateButtonState.Default, isDefault)
    End Sub

    Public Sub PerformClick() Implements IButtonControl.PerformClick
        OnClick(EventArgs.Empty)
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        SetState(StateButtonState.Pressed, True)
        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        Dim click As Boolean = False
        If (state And StateButtonState.Pressed) <> 0 Then
            click = True
        End If
        SetState(StateButtonState.Pressed, False)
        MyBase.OnMouseUp(e)

        If click Then
            Update()
            PerformClick()
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        If Capture Then
            SetState(StateButtonState.Pressed, ClientRectangle.Contains(e.X, e.Y))
        End If
        MyBase.OnMouseMove(e)
    End Sub

    Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
        SetState(StateButtonState.MouseHover, True)
        MyBase.OnMouseEnter(e)
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        SetState(StateButtonState.MouseHover, False)
        MyBase.OnMouseLeave(e)
    End Sub

End Class

<Flags()> _
Public Enum StateButtonState
    None = &H0
    Pressed = &H1
    MouseHover = &H2
    [Default] = &H4
    Disabled = &H8
End Enum 