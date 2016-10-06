Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms


Partial Public Class TextBoxColumn : Inherits Form
    Public Sub New()
        InitializeComponent()

        ' Reduce the number of times the layout logic is executed.
        tableLayoutPanel1.SuspendLayout()

        ' Add the controls.
        For i As Integer = 1 To 14
            ' Create an auto-sizing label for the left column.
            Dim lbl As New Label()
            lbl.Text = "This is Setting " & i.ToString()

            lbl.Margin = New Padding(3, 7, 3, 3)
            lbl.AutoSize = True

            ' Create a text box that's docked to fill up the entire second column.
            Dim txt As New TextBox()
            txt.Dock = DockStyle.Fill

            Dim cmd As New Button()
            cmd.Text = "Browse..."
            cmd.Width = 60

            ' Add the controls
            tableLayoutPanel1.Controls.Add(lbl)
            tableLayoutPanel1.Controls.Add(txt)
            tableLayoutPanel1.Controls.Add(cmd)
        Next

        tableLayoutPanel1.ResumeLayout()

    End Sub

    Private Sub TextBoxColumn_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub
End Class
