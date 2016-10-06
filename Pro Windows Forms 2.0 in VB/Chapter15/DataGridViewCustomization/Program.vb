Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace DataGridViewCustomization
	Friend Class Program
		Private Shared storeDB_Renamed As StoreDB = New StoreDB()
		Private Sub New()
		End Sub
		Public Shared ReadOnly Property StoreDB() As StoreDB
			Get
				Return storeDB_Renamed
			End Get
		End Property

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.Run(New Menu())
		End Sub
	End Class
End Namespace