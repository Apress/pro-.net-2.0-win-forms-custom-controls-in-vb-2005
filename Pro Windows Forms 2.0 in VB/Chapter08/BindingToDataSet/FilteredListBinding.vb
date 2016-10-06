Public Class FilteredListBinding

    Private Sub FilteredListBinding_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DataTable = Program.StoreDB.GetProducts()
        dt.DefaultView.RowFilter = "UnitCost < 5"

        lstModelName.DataSource = dt
        lstModelName.DisplayMember = "ModelName"
    End Sub
End Class