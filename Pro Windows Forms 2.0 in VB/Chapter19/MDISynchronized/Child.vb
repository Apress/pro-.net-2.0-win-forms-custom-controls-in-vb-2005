Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace MdiSynchronized
	Public Partial Class Child : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private isUpdating As Boolean

		Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles textBox1.TextChanged
            If Me.MdiParent IsNot Nothing And Not isUpdating Then
                ' The reference to the MDI parent must be converted to the appropriate
                ' form class in order to access the custom RefreshChildren() method.
                CType(Me.MdiParent, Parent).RefreshChildren(Me, textBox1.Text)
            End If

        End Sub

		Public Sub RefreshText(ByVal text As String)
			' Disable the event to prevent an endless string of updates.
			isUpdating = True

			' Update the control.
			textBox1.Text = text

			' Re-enable the event handler.
			isUpdating = False
		End Sub
	End Class
End Namespace