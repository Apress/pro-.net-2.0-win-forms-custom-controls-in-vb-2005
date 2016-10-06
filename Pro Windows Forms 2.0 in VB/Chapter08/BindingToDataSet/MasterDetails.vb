Public Class MasterDetails

    Private categoryBinding As BindingManagerBase
    Private ds As DataSet

    Private Sub MasterDetails_Load(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles MyBase.Load
        ds = Program.StoreDB.GetCategoriesAndProducts()

        ' Bind the lists to different tables.
        lstCategory.DataSource = ds.Tables("Categories")
        lstCategory.DisplayMember = "CategoryName"

        lstProduct.DataSource = ds.Tables("Products")
        lstProduct.DisplayMember = "ModelName"

        ' Track the binding context and handle position changing.
        categoryBinding = Me.BindingContext(ds.Tables("Categories"))
        AddHandler categoryBinding.PositionChanged, _
          AddressOf Binding_PositionChanged

        ' Update child table at startup.
        UpdateProducts()
    End Sub

    Private Sub Binding_PositionChanged(ByVal sender As Object, _
  ByVal e As System.EventArgs)
        UpdateProducts()
    End Sub

    Private Sub UpdateProducts()
        ' Find the current category row.
        Dim selectedRow As DataRow
        selectedRow = ds.Tables("Categories").Rows(categoryBinding.Position)

        ' Create a filter expression using its CategoryID.
        Dim filter As String
        filter = "CategoryID='" & selectedRow("CategoryID").ToString() & "'"

        ' Modify the view onto the product table.
        ds.Tables("Products").DefaultView.RowFilter = filter
    End Sub

End Class