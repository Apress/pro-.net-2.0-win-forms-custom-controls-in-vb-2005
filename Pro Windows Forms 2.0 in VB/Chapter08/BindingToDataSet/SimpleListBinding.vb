Public Class SimpleListBinding

    Private Sub SimpleListBinding_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstModelName.DataSource = Program.StoreDB.GetProducts()
        lstModelName.DisplayMember = "ModelName"
    End Sub
End Class