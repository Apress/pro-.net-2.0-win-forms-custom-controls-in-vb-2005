

Public Class Form1


    Private Declare Function GetKeyState Lib "User32.dll" (ByVal key As System.Windows.Forms.Keys) As Short
    Private Declare Function GetAsyncKeyState Lib "User32.dll" (ByVal key As System.Windows.Forms.Keys) As Short

    Private Sub cmdAsyncState_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAsyncState.Click
        ' Test for the letter D.
        Dim state As Short = GetAsyncKeyState(Keys.D)

        Select Case state
            Case 0
                lbl.Text = "D has not been pressed since the last call."
            Case 1
                lbl.Text = _
         "D is not currently pressed, but has been pressed since the last call."
            Case -32767
                lbl.Text = "D is currently pressed."
        End Select
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        ' Show the key letter that was pressed. For example, if the user presses
        ' the D key, the key value will always be “D” regardless of whether Shift
        ' was held down or not).
        lbl.Text = "Key Code: " & e.KeyCode.ToString()

        ' Show the integer value for the key that was pressed
        ' (like 16 for Shift or 68 for D). 
        lbl.Text &= vbNewLine & "Key Value: " & e.KeyValue.ToString()

        ' The KeyData contains information about every key that was held down,
        ' as a combination of values from the Keys enumeration.
        ' You can enumerate over these values, or just call ToString()
        ' to a get a comma-separated list.
        lbl.Text &= vbNewLine & "Key Data: " & e.KeyData.ToString()

        ' You can use Modifiers to check for Alt, Control, and Shift.
        If (e.Modifiers And Keys.Shift) = Keys.Shift Then
            lbl.Text &= vbNewLine & "Shift was held down."
        End If
        If (e.Modifiers And Keys.Control) = Keys.Control Then
            lbl.Text &= vbNewLine & "Ctrl was held down."
        End If

        ' There is also an easier approach through the Alt, Control,
        ' and Shift properties.
        If e.Alt Then
            lbl.Text &= vbNewLine & "Alt was held down."
        End If

    End Sub

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        e.Handled = True
    End Sub
End Class
