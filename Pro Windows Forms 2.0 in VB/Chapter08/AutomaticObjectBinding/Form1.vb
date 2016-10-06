Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProductListBindingSource.DataSource = Program.StoreDB.GetProducts()
    End Sub
End Class
