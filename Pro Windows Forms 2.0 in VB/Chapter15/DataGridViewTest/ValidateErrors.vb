Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DataGridViewTest
	Public Partial Class ValidateErrors : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ValidateErrors_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim ds As DataSet = Program.StoreDB.GetCategoriesAndProducts()
			dataGridView1.DataSource = ds.Tables("Products")

		End Sub

		Private Sub dataGridView1_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dataGridView1.DataError
				' Check if it's an error during the commit stage.
			If (e.Context And DataGridViewDataErrorContexts.Commit) = DataGridViewDataErrorContexts.Commit Then
				' Check the column.
				If dataGridView1.Columns(e.ColumnIndex).Name = "CategoryID" Then
					' Check if it's a constraint exception.
					If TypeOf e.Exception Is System.Data.InvalidConstraintException Then
						MessageBox.Show("This category does not exist.")
						' The following two lines suppress the exception for this error
						' and cancel the attempted action (like row navigation) so focus
						' remains on the cell. However, these are the defaults, so these
						' lines aren't required.
						e.ThrowException = False
						e.Cancel = True
					' Check if it's a formatting exception.
					ElseIf (Not e.Exception.InnerException Is Nothing) AndAlso (TypeOf e.Exception.InnerException Is FormatException) Then
						MessageBox.Show("This field can only contain numbers.")
						e.ThrowException = False
						e.Cancel = True
					End If
				End If
			End If
		End Sub

		Private Sub dataGridView1_UserDeletingRow(ByVal sender As Object, ByVal e As DataGridViewRowCancelEventArgs) Handles dataGridView1.UserDeletingRow
			Dim id As String = e.Row.Cells("ProductID").FormattedValue.ToString()
			Dim name As String = e.Row.Cells("ModelName").FormattedValue.ToString()

			Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete product " & id & " - " & name & "?", "Delete?", MessageBoxButtons.OKCancel)

			If result = DialogResult.Cancel Then
				' Cancel the delete operation.
				e.Cancel = True
			End If

		End Sub


		Private Sub dataGridView1_CellValidating(ByVal sender As Object, ByVal e As DataGridViewCellValidatingEventArgs) Handles dataGridView1.CellValidating
            ' Check if it's a column you want to validate.
            If dataGridView1.Columns(e.ColumnIndex).Name = "ProductImage" Then
                ' Apply the appropriate rule.
                If System.IO.Path.GetExtension(e.FormattedValue.ToString()) <> ".gif" Then
                    ' There's a problem. Alert the user and cancel navigation.
                    dataGridView1.Rows(e.RowIndex).ErrorText = "Invalid Product Image"
                    dataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).ErrorText = "The file name must end with '.gif'."
                End If
            End If
        End Sub
	End Class
End Namespace