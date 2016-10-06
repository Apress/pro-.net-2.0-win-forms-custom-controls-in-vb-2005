Public Class SimpleListBinding

    Private Sub SimpleListBinding_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstModelName.DataSource = Program.StoreDB.GetProducts()
        'lstModelName.DisplayMember = "ModelName"
    End Sub

    Private Sub lstModelName_DoubleClick(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles lstModelName.DoubleClick
        If lstModelName.SelectedItem IsNot Nothing Then
            Dim product As Product = CType(lstModelName.SelectedItem, Product)
            MessageBox.Show(String.Format("Costs {0:C}", product.UnitCost))
        End If
    End Sub

End Class