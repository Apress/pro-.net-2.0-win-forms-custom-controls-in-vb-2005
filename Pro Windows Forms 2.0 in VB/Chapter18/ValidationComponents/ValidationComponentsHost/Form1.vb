Imports ValidationComponents

Public Class Form1

    Private Sub cmdOK_Click(ByVal sender As Object, ByVal e As EventArgs) _
      Handles cmdOK.Click
        If BaseValidator.IsFormValid(Me.components) Then
            Me.Close()
        Else
            MessageBox.Show("You still have invalid input.", "Invalid Input", _
              MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class
