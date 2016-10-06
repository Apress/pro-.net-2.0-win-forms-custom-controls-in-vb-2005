Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms


Partial Public Class DynamicMenu : Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub panel_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles panel2.Enter, panel1.Enter
        Dim panel As Panel = CType(sender, Panel)
        mnuTopLevel.DropDown = panel.ContextMenuStrip
        Dim item As ToolStripMenuItem = CType(panel.ContextMenuStrip.Items(0), ToolStripMenuItem)
        mnuTopLevel.DropDown = item.DropDown
        mnuTopLevel.Text = item.Text
    End Sub

    Private Sub panel_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles panel2.Leave, panel1.Leave


    End Sub


    Private Sub DynamicMenu_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub

End Class
