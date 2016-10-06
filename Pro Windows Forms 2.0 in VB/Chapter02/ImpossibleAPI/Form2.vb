Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Me.MdiParent = Nothing
        Me.IsMdiContainer = True
        Me.Show()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Me.IsMdiContainer = False
        Me.MdiParent = Startup.Main2
        Me.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Me.IsMdiContainer = False
        Me.MdiParent = Startup.Main1
        Me.Show()
    End Sub
End Class