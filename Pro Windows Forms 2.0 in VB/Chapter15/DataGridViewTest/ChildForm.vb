Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DataGridViewTest
	Public Partial Class ChildForm : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ChildForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub

        Private _categoryID As Integer

		Public Property CategoryID() As Integer
			Get
                Return _categoryID
			End Get
			Set
                _categoryID = Value
				Dim ds As DataSet = Program.StoreDB.GetCategoriesAndProducts()
				dataGridView1.DataSource = ds.Tables("Products")
                ds.Tables("Products").DefaultView.RowFilter = "CategoryID =" & _categoryID.ToString()
			End Set
		End Property

	End Class
End Namespace