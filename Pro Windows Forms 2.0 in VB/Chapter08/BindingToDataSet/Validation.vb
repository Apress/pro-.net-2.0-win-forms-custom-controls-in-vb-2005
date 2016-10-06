Public Class Validation

    Private currentRecord As Integer
    Private errFlag As Boolean
    Private storeBinding As BindingManagerBase

    Private Sub Validation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DataTable = Program.StoreDB.GetProducts()

        cboModelName.DataSource = dt
        cboModelName.DisplayMember = "ModelName"

        Dim costBinding As New Binding("Text", dt, "UnitCost")
        txtUnitCost.DataBindings.Add(costBinding)
        txtModelName.DataBindings.Add("Text", dt, "ModelName")
        txtModelNumber.DataBindings.Add("Text", dt, "ModelNumber")
        txtDescription.DataBindings.Add("Text", dt, "Description")

        ' Keep track of the binding context.
        storeBinding = Me.BindingContext(dt)

        AddHandler storeBinding.PositionChanged, AddressOf Binding_PositionChanged
        AddHandler dt.ColumnChanged, AddressOf TableChanged
    End Sub

    Private Sub TableChanged(ByVal sender As Object, _
  ByVal e As System.Data.DataColumnChangeEventArgs)
        Dim errors As String = Program.StoreDB.ValidateProduct(e.Row)

        If errors.Length = 0 Then
            errFlag = False
        Else
            errFlag = True
        End If
        lblStatus.Text = errors
    End Sub

    Private Sub Binding_PositionChanged(ByVal sender As Object, _
  ByVal e As System.EventArgs)
        If errFlag Then
            ' Reset the page.
            storeBinding.Position = currentRecord
        Else
            ' Allow the page to change and update the currentPage variable.
            currentRecord = storeBinding.Position
        End If
    End Sub

End Class