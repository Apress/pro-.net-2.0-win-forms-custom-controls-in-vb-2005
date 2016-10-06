Public Class LookupTable

    Private Sub LookupTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As DataSet = Program.StoreDB.GetCategoriesAndProducts()

        ' Connect the product list used for navigation.
        cboModelName.DataSource = ds.Tables("Products")
        cboModelName.DisplayMember = "ModelName"

        ' Connect the category list used for editing.
        cboCategory.DataSource = ds.Tables("Categories")
        cboCategory.DisplayMember = "CategoryName"
        cboCategory.ValueMember = "CategoryID"

        cboCategory.DataBindings.Add("SelectedValue", ds.Tables("Products"), _
          "CategoryID")

    End Sub
End Class