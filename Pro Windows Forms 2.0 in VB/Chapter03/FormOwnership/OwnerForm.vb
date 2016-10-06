Public Class OwnerForm
    Private frmOwned As New OwnedForm()

    Private Sub OwnerForm_Load(ByVal sender As Object, _
  ByVal e As EventArgs) Handles MyBase.Load
        Me.Show()
        frmOwned.Show()
    End Sub

    Private Sub cmdAddOwnership_Click(ByVal sender As Object, _
      ByVal e As EventArgs) Handles cmdAddOwnership.Click
        Me.AddOwnedForm(frmOwned)
        frmOwned.lblState.Text = "I'm Owned"
    End Sub

    Private Sub cmdReleaseOwnership_Click(ByVal sender As Object, _
      ByVal e As EventArgs) Handles cmdReleaseOwnership.Click
        Me.RemoveOwnedForm(frmOwned)
        frmOwned.lblState.Text = "I'm Free!"
    End Sub

End Class
