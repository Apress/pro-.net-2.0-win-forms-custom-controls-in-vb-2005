Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstCustomers.Items.Add(New Customer("Maurice", "Respighi", DateTime.Now))
        lstCustomers.Items.Add(New Customer("Sam", "Digweed", DateTime.Now))
        lstCustomers.Items.Add(New Customer("Faria", "Khan", DateTime.Now))
    End Sub

    Private Sub lstCustomers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCustomers.SelectedIndexChanged
        Dim cust As Customer = CType(lstCustomers.SelectedItem, Customer)
        MessageBox.Show("Birth Date: " & cust.BirthDate.ToShortDateString())
    End Sub
End Class
