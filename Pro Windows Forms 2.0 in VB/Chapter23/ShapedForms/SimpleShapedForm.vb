Imports System.Drawing.Drawing2D

Public Class SimpleShapedForm

    Private Sub SimpleShapedForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, Me.Width, Me.Height)
        Me.Region = New Region(path)
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.Close()
    End Sub
End Class