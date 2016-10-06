Public Class GridBinding

    Private Sub GridBinding_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataGridView1.DataSource = Program.StoreDB.GetProducts()
    End Sub
End Class