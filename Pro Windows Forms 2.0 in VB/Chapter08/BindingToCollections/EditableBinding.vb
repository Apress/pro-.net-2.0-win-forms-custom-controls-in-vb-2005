Public Class EditableBinding

    Private Sub EditableBinding_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Get the data object.
        Dim products As ProductList = Program.StoreDB.GetProducts()

        cboModelName.DataSource = products
        cboModelName.DisplayMember = "ModelName"

        txtModelName.DataBindings.Add("Text", products, "ModelName")
        txtModelNumber.DataBindings.Add("Text", products, "ModelNumber")
        txtDescription.DataBindings.Add("Text", products, "Description")

        ' Create the binding.
        Dim costBinding As New Binding("Text", products, "UnitCost")

        ' Connect the methods for formatting and parsing data.
        AddHandler costBinding.Format, AddressOf DecimalToCurrencyString
        AddHandler costBinding.Parse, AddressOf CurrencyStringToDecimal

        ' Add the binding.
        txtUnitCost.DataBindings.Add(costBinding)

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

End Class