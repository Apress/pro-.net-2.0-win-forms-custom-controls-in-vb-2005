Public Class Form1

    Private Sub cmdSetText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetText.Click
        ' There is no width boundary.
        label1.MaximumSize = New Size(0, 0)
        label1.Text = ""
        label1.Text = textBox1.Text
    End Sub

    Private Sub cmdSetTextConstraint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetTextConstraint.Click
        ' There is a width boundary.
        label1.MaximumSize = New Size(200, 0)
        label1.Text = textBox1.Text
    End Sub
End Class
