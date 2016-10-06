Public Class Form1

    Private Sub ctrlClick(ByVal sender As Object, ByVal e As EventArgs) _
   Handles Button1.Click, TextBox1.Click, Label1.Click
        Dim ctrl As Control = CType(sender, Control)
        MessageBox.Show("You clicked: " & ctrl.Name)
    End Sub

End Class
