Public Class WebBrowserDynamicContent

    Private Sub txtHtml_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHtml.TextChanged
        webBrowser.DocumentText = txtHtml.Text
    End Sub
End Class