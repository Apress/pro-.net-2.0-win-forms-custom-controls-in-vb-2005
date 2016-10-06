Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms


Partial Public Class ButtonMaker : Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Private buttonCount As Integer = 0
    Private Sub cmdCreate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdCreate.Click
        buttonCount += 1

        ' Create the button.
        Dim newButton As New Button()
        newButton.Text = "Button " & buttonCount.ToString()
        newButton.Location = New Point(Int32.Parse(txtLeft.Text), Int32.Parse(txtTop.Text))

        ' Attach the event handler.
        AddHandler newButton.Click, AddressOf ButtonHandler

        Me.Controls.Add(newButton)
    End Sub

    Private Sub ButtonHandler(ByVal sender As Object, ByVal e As System.EventArgs)
        lblStatus.Text = " You clicked ... "
        lblStatus.Text += (CType(sender, Button)).Text
    End Sub

End Class
