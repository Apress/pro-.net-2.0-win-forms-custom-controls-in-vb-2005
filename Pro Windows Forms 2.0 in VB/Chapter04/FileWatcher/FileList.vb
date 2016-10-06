Public Class FileList

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.Close()
    End Sub

    Public Sub FillList(ByVal list As List(Of String))
        lstFiles.DataSource = List
    End Sub
End Class