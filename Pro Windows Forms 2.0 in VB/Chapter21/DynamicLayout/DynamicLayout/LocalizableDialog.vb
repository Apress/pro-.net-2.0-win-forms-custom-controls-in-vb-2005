Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms


Partial Public Class LocalizableDialog : Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub optShort_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles optShort.CheckedChanged
        button2.Text = "button2"
    End Sub

    Private Sub optLong_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles optLong.CheckedChanged
        button2.Text = "This is the much longer text string."
    End Sub
End Class
