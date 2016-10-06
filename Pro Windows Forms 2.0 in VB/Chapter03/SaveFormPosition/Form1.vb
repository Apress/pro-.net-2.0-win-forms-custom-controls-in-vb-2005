Public Class Form1


    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        FormPositionHelper.SaveSize(Me)
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        FormPositionHelper.SetSize(Me)
    End Sub
End Class
