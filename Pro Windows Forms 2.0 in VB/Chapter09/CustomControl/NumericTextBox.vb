Public Class NumericTextBox
    Inherits TextBox

    Protected Overrides Sub OnKeyPress(ByVal e As KeyPressEventArgs)
        ' Ignore all non-control and non-numeric key presses.
        If Not Char.IsControl(e.KeyChar) And _
           Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        ' Call the implementation in the base TextBox class,
        ' which raises the KeyPress event.
        MyBase.OnKeyPress(e)
    End Sub

End Class

