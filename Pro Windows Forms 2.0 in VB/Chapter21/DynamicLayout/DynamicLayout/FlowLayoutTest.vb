Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms


Partial Public Class FlowLayoutTest : Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FlowLayoutTest_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        lstFlowDirection.Items.AddRange(System.Enum.GetNames(GetType(FlowDirection)))
        lstFlowDirection.Text = flowLayoutPanel1.FlowDirection.ToString()
    End Sub

    Private Sub lstFlowDirection_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lstFlowDirection.SelectedIndexChanged
        If lstFlowDirection.SelectedIndex <> -1 Then
            flowLayoutPanel1.FlowDirection = CType(System.Enum.Parse(GetType(FlowDirection), lstFlowDirection.Text), FlowDirection)
        End If
    End Sub

    Private Sub chkWrap_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkWrap.CheckedChanged
        flowLayoutPanel1.WrapContents = chkWrap.Checked
    End Sub

    Private Sub chkAutoScroll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAutoScroll.CheckedChanged
        flowLayoutPanel1.AutoScroll = chkAutoScroll.Checked
    End Sub
End Class
