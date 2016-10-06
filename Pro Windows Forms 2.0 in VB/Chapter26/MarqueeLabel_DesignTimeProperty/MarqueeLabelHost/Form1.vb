Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tbAmount_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbAmount.Scroll
        marqueeLabel1.ScrollPixelAmount = tbAmount.Value
    End Sub

    Private Sub tbInterval_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbInterval.Scroll
        MarqueeLabel1.ScrollTimeInterval = tbInterval.Value
    End Sub
End Class
