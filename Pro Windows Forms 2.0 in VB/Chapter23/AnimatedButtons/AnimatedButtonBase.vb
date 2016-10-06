Public MustInherit Class AnimatedButtonBase
    Inherits Control
    Implements IButtonControl

    Public Enum States
        Normal
        MouseOver
        Pushed
        Disabled
    End Enum

    Public Sub PerformClick() Implements IButtonControl.PerformClick
        OnClick(EventArgs.Empty)
    End Sub

    Private _dialogResult As DialogResult
    Public Property DialogResult() As DialogResult Implements IButtonControl.DialogResult
        Get
            Return _dialogResult
        End Get
        Set(ByVal value As DialogResult)
            _dialogResult = value
        End Set
    End Property

    Public Sub NotifyDefault(ByVal value As Boolean) Implements IButtonControl.NotifyDefault
        ' Fires when the button is made into a default.
        ' You could set properties to adjust the rendering,
        ' but that's not necessary.
        OnNotifyDefault(value)
    End Sub

    Public Overridable Sub OnNotifyDefault(ByVal value As Boolean)
        ' This method can be overriden in derived classes
        ' if they wish to apply rendering customizations.
    End Sub

    ' Begin in normal state.
    Private _state As States = States.Normal

    ' This property procedure ensures the control is
    ' invalidated only when the state changes.
    Private Property State() As States
        Get
            Return _state
        End Get
        Set(ByVal value As States)
            If _state <> value Then
                _state = value
                Invalidate()
            End If
        End Set
    End Property

    Protected Overrides Sub OnEnabledChanged(ByVal e As EventArgs)
        If Not Enabled Then
            State = States.Disabled
        ElseIf Enabled And State = States.Disabled Then
            State = States.Normal
        End If
        MyBase.OnEnabledChanged(e)
    End Sub

    Public Overrides Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            If value <> MyBase.Text Then
                MyBase.Text = value
                Invalidate()
            End If
        End Set
    End Property

    ' If you want to make only a portion of the button
    ' clickable, this is the method to override.
    Protected Overridable Function HitTest(ByVal X As Integer, ByVal Y As Integer) _
      As Boolean
        Return True
    End Function

    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)

        ' Do nothing if the button is disabled.
        If State = States.Disabled Then Return

        If HitTest(e.X, e.Y) Then
            If State <> States.Pushed Then State = States.MouseOver
        Else
            State = States.Normal
        End If
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        If State <> States.Disabled Then State = States.Normal
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        ' Do nothing if the button is disabled.
        If State = States.Disabled Then Return

        If HitTest(e.X, e.Y) Then
            If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
                State = States.Pushed
                Focus()
            End If
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        ' Do nothing if the button is disabled.
        If State = States.Disabled Then Return

        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
            If HitTest(e.X, e.Y) Then
                State = States.MouseOver
            Else
                State = States.Normal
            End If
        End If
    End Sub

    Protected Overrides Sub OnClick(ByVal e As EventArgs)
        If State = States.Pushed Then
            MyBase.OnClick(e)
        End If
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Select Case State
            Case States.Normal
                PaintNormal(e.Graphics)
            Case States.MouseOver
                PaintMouseOver(e.Graphics)
            Case States.Pushed
                PaintPushed(e.Graphics)
            Case States.Disabled
                PaintDisabled(e.Graphics)
        End Select
        If Me.Focused And State <> States.Disabled Then PaintFocusRectangle(e.Graphics)
    End Sub

    Protected MustOverride Sub PaintNormal(ByVal g As Graphics)
    Protected MustOverride Sub PaintMouseOver(ByVal g As Graphics)
    Protected MustOverride Sub PaintPushed(ByVal g As Graphics)
    Protected MustOverride Sub PaintDisabled(ByVal g As Graphics)

    Private _paintFocusCue As Boolean = True
    Public Property PaintFocusCue() As Boolean
        Get
            Return _paintFocusCue
        End Get
        Set(ByVal value As Boolean)
            If value <> _paintFocusCue Then
                _paintFocusCue = value
                Invalidate()
            End If
        End Set
    End Property

    Protected Overridable Sub PaintFocusRectangle(ByVal g As Graphics)
        ControlPaint.DrawFocusRectangle(g, Me.ClientRectangle)
    End Sub

    Protected Overrides Sub OnGotFocus(ByVal e As EventArgs)
        If PaintFocusCue Then Invalidate()
    End Sub

    Protected Overrides Sub OnLostFocus(ByVal e As EventArgs)
        If PaintFocusCue Then Invalidate()
    End Sub

    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
    End Sub

End Class
