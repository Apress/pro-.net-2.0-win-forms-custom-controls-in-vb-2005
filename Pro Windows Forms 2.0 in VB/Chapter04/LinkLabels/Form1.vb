Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lnkBuy.Links.Add(10, 10, "http://www.amazon.com")
        lnkBuy.Links.Add(24, 16, "http://www.bn.com")
        lnkWebSite.Links.Add(4, 17, "http://www.prosetech.com")
    End Sub

    Private Sub lnk_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkWebSite.LinkClicked, lnkBuy.LinkClicked
        e.Link.Visited = True
        System.Diagnostics.Process.Start(CStr(e.Link.LinkData))
    End Sub
End Class
