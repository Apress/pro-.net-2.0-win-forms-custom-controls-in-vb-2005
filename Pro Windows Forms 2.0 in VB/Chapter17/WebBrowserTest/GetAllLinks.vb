Public Class GetAllLinks

    Private Sub webBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles webBrowser1.DocumentCompleted
        cmdGetAllLinks.Enabled = True
    End Sub

    Private Sub cmdGetAllLinks_Click(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles cmdGetAllLinks.Click

        If webBrowser1.ReadyState = WebBrowserReadyState.Complete Then
            ' Use an hourglass mouse pointer, because it takes a short delay
            ' to build the document tree.
            Me.Cursor = Cursors.WaitCursor
            lstLinks.Items.Clear()

            Dim elements As HtmlElementCollection = _
              webBrowser1.Document.GetElementsByTagName("A")
            For Each element As HtmlElement In elements
                lstLinks.Items.Add(element.GetAttribute("href"))
            Next

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private previous As HtmlElement

    Private Sub lstLinks_SelectedIndexChanged(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles lstLinks.SelectedIndexChanged
        Dim elements As HtmlElementCollection = _
         webBrowser1.Document.GetElementsByTagName("A")

        If previous IsNot Nothing Then
            previous.InnerText = previous.InnerText.Substring(3)
        End If

        previous = elements(lstLinks.SelectedIndex)
        previous.InnerText = ">>>" & previous.InnerText
    End Sub

End Class