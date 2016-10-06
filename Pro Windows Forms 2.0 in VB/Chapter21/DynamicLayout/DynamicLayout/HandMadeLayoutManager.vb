Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms


Partial Public Class HandMadeLayoutManager : Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub HandMadeLayoutManager_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Create and attach the layout manager.
        Dim layoutManager As New SingleLineFlowLayoutManager(tabPage1, 20)

        tabPage1.SuspendLayout()
        ' Add 10 sample checkboxes.
        Dim chkbox As CheckBox

        For i As Integer = 1 To 10
            chkbox = New CheckBox()
            chkbox.Name = "checkBox" & i.ToString()
            chkbox.Text = "Setting " & i.ToString()
            tabPage1.Controls.Add(chkbox)
        Next
        tabPage1.ResumeLayout()
    End Sub
End Class
