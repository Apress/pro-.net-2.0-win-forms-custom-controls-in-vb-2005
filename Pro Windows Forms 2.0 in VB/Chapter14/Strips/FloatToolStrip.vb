Public Class FloatToolStrip
    Inherits ToolStrip

    Public Event Undocked(ByVal sender As Object, ByVal e As EventArgs)

    Protected Overrides Sub OnMouseDown(ByVal mea As MouseEventArgs)
        If Me.GripRectangle.Contains(mea.Location) Then
            Dim location As Point = PointToScreen(Point.Empty)

            ' For more control, this would be a custom form.
            ' You could then event handlers that would react when
            ' it is dragged to an edge, and redock it automatically.
            _floatForm = New Form()
            _floatForm.StartPosition = FormStartPosition.Manual
            _floatForm.Owner = Me.FindForm()
            Dim pt As Point = location
            pt.Offset(5, 5)
            _floatForm.Location = pt
            _floatForm.Text = Me.Text
            _floatForm.FormBorderStyle = FormBorderStyle.FixedToolWindow
            _floatForm.ClientSize = Me.Size

            ' A control can be contained in only one form. This moves
            ' the ToolStrip out of the original form and into the floating form.
            _floatForm.Controls.Add(Me)
            _floatForm.Show()

            ' Raise the event to notify the form.
            RaiseEvent Undocked(Me, EventArgs.Empty)
        Else
            ' Perform the normal mouse-click handling.
            MyBase.OnMouseDown(mea)
        End If
    End Sub


    Private _floatForm As Form
    Public ReadOnly Property FloatForm() As Form
        Get
            Return _floatForm
        End Get
    End Property

    Public Sub New()
        MyBase.New()
    End Sub
End Class

