Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Reflection


Partial Public Class Menu : Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub cmd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click, button11.Click, button2.Click
        Dim ctrl As Control = CType(sender, Control)
        Dim assm As System.Reflection.Assembly = System.Reflection.Assembly.GetAssembly(GetType(Menu))
        Dim frm As Form = CType(assm.CreateInstance("DynamicUI." & ctrl.Text), Form)
        frm.ShowDialog()
    End Sub

    Private Sub Menu_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub
End Class
