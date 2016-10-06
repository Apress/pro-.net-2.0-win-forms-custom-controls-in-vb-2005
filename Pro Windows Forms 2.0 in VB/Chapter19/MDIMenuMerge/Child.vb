Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace MdiMenuMerge
	Public Partial Class Child : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub SetNoMerge()
			menuStrip1.AllowMerge = False
		End Sub
	End Class
End Namespace