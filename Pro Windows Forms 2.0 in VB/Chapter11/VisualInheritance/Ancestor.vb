Public Class Ancestor

    Public Property HeaderText() As String
        Get
            Return lblHeader.Text
        End Get
        Set(ByVal value As String)
            lblHeader.Text = value
        End Set
    End Property

    Protected Overridable Sub OnNextButtonClick(ByVal sender As Object, _
  ByVal e As EventArgs) Handles cmdNext.Click
        MessageBox.Show("Ancestor form event handler.")
    End Sub

End Class