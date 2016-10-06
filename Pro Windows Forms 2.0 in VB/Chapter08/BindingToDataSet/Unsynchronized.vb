Public Class Unsynchronized

    Private Sub Unsynchronized_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Make sure all the controls in the second group box have a different binding.
        grpB.BindingContext = New BindingContext()

        Dim dt As DataTable = Program.StoreDB.GetProducts()

        ' Configure the first group.
        lstModelNameA.DataSource = dt
        lstModelNameA.DisplayMember = "ModelName"

        ' Configure the second group.
        lstModelNameB.DataSource = dt
        lstModelNameB.DisplayMember = "ModelName"

    End Sub
End Class