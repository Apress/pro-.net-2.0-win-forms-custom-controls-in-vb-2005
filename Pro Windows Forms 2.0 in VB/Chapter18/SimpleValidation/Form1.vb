Public Class Form1

    Private Sub txtName_Validating(ByVal sender As Object, _
      ByVal e As System.ComponentModel.CancelEventArgs) _
      Handles txtFirstName.Validating, txtLastName.Validating
        If CType(sender, TextBox).Text = "" Then
            MessageBox.Show("You must enter a first and last name.", "Invalid Input", _
              MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True
        End If
    End Sub


    Private Sub Form1_FormClosing(ByVal sender As Object, _
      ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' If e.Cancel is True, the cancel flag has been set by a validation routine.
        If e.Cancel Then
            Dim result As DialogResult = MessageBox.Show( _
              "There are still errors on the form. Do you wish to close the form?", _
              "Errors found", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then e.Cancel = False
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As Object, ByVal e As EventArgs) _
     Handles cmdClose.Click
        ' This triggers validation.
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFirstName.Select()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
