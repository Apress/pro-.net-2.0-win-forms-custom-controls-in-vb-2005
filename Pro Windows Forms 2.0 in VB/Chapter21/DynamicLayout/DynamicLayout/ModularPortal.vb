Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms


Partial Public Class ModularPortal : Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ModularPortal_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        For Each ctrl As Control In flowLayoutPanel1.Controls
            If TypeOf ctrl Is Panel Then
                lstModules.Items.Add(ctrl.Text, True)
            End If

        Next
    End Sub

    Private Sub lstModules_ItemCheck(ByVal sender As Object, ByVal e As ItemCheckEventArgs) Handles lstModules.ItemCheck
        For Each ctrl As Control In flowLayoutPanel1.Controls
            If ctrl.Text = lstModules.Text Then
                If e.NewValue = CheckState.Checked Then
                    ctrl.Visible = True
                Else
                    ctrl.Visible = False
                End If

                Return
            End If
        Next
    End Sub

End Class
