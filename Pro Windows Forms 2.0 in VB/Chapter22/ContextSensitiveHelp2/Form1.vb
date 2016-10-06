Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim frm1 As New FormBased()
        Dim frm2 As New FrameBased()
        Dim frm3 As New ControlBased()

        frm1.MdiParent = Me
        frm2.MdiParent = Me
        frm3.MdiParent = Me

        frm1.Show()
        frm2.Show()
        frm3.Show()
    End Sub
End Class
