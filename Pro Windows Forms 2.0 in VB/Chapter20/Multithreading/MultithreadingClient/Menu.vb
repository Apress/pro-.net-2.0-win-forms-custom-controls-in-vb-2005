Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Reflection

Namespace MultithreadingClient
    Public Partial Class Menu : Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub cmd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click, button2.Click, button3.Click, button4.Click, button5.Click, button6.Click
            Dim ctrl As Control = CType(sender, Control)
            Dim [assembly] As System.Reflection.Assembly = System.Reflection.Assembly.GetAssembly(GetType(Menu))
            Dim frm As Form = CType([assembly].CreateInstance("MultithreadingClient." & ctrl.Text), Form)
            frm.ShowDialog()
        End Sub
    End Class
End Namespace