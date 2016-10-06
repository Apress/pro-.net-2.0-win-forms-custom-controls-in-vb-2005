Public Class Descendant

    Protected Overrides Sub OnNextButtonClick(ByVal sender As Object, _
  ByVal e As EventArgs)
        ' Call the original version.
        MyBase.OnNextButtonClick(sender, e)

        MessageBox.Show("Descendant form event handler.")
    End Sub

End Class
