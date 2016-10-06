Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFirstName.Select()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub txtName_Validating(ByVal sender As Object, _
      ByVal e As System.ComponentModel.CancelEventArgs) _
      Handles txtFirstName.Validating, txtLastName.Validating

        Dim ctrl As Control = CType(sender, Control)
        If ctrl.Text = "" Then
            errProvider.SetError(ctrl, "You must enter a first and last name.")
        Else
            errProvider.SetError(ctrl, "")
        End If
    End Sub

    Private Sub cmdOK_Click(ByVal sender As Object, ByVal e As EventArgs) _
  Handles cmdOK.Click
        Dim invalidInput As Boolean = False

        For Each ctrl As Control In grpValidation.Controls
            If errProvider.GetError(ctrl) <> "" Then
                invalidInput = True
                Exit For
            End If
        Next

        If invalidInput Then
            MessageBox.Show("You still have invalid input.", _
              "Invalid Input", MessageBoxButtons.OK, _
              MessageBoxIcon.Warning)
        Else
            Me.Close()
        End If
    End Sub

    Private Sub txtEmail_TextChanged(ByVal sender As Object, ByVal e As EventArgs) _
  Handles txtEmail.TextChanged
        Dim regex As System.Text.RegularExpressions.Regex
        regex = New System.Text.RegularExpressions.Regex("^\S+@\S+\.\S+$")

        Dim ctrl As Control = CType(sender, Control)
        If regex.IsMatch(ctrl.Text) Then
            errProvider.SetError(ctrl, "")
        Else
            errProvider.SetError(ctrl, "Not a valid email.")
        End If
    End Sub

End Class
