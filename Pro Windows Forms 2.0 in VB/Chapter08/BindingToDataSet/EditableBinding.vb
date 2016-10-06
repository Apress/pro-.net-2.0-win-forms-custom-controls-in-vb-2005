Public Class EditableBinding

    Private Sub EditableBinding_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Get the data object.
        Dim dt As DataTable = Program.StoreDB.GetProducts()

        cboModelName.DataSource = dt
        cboModelName.DisplayMember = "ModelName"

        txtModelName.DataBindings.Add("Text", dt, "ModelName")
        txtModelNumber.DataBindings.Add("Text", dt, "ModelNumber")
        txtDescription.DataBindings.Add("Text", dt, "Description")

        ' Create the binding.
        Dim costBinding As New Binding("Text", dt, "UnitCost")

        ' Connect the methods for formatting and parsing data.
        AddHandler costBinding.Format, AddressOf DecimalToCurrencyString
        AddHandler costBinding.Parse, AddressOf CurrencyStringToDecimal

        ' Add the binding.
        txtUnitCost.DataBindings.Add(costBinding)

        ' Register an event handler for changes to the DataTable (optional).
        AddHandler dt.ColumnChanged, AddressOf TableChanged

    End Sub

    Private previousUnitCost As Object

    Private Sub DecimalToCurrencyString(ByVal sender As Object, _
      ByVal e As ConvertEventArgs)
        If e.DesiredType Is GetType(String) Then
            previousUnitCost = e.Value

            ' Use the ToString method to format the value as currency ("c").
            e.Value = (CType(e.Value, Decimal)).ToString("c")
        End If
    End Sub

    Private Sub CurrencyStringToDecimal(ByVal sender As Object, _
  ByVal e As ConvertEventArgs)

        If e.DesiredType Is GetType(Decimal) Then
            ' Convert the string back to decimal using the shared Parse method.
            ' Use exception handling code in case the text can't be interpreted
            ' as a decimal.
            Try
                e.Value = Decimal.Parse(e.Value.ToString(), System.Globalization.NumberStyles.Any)

            Catch
                e.Value = previousUnitCost
            End Try
        End If
    End Sub

    Private Sub TableChanged(ByVal sender As Object, _
  ByVal e As System.Data.DataColumnChangeEventArgs)

        lblStatus.Text = "Detected change. Column " & e.Column.ColumnName
        lblStatus.Text &= " updated to " & e.ProposedValue.ToString() & "."
    End Sub

End Class