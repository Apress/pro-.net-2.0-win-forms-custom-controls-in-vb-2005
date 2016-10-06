Public Class ExploreDOM

    Private Sub cmdBuildTree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuildTree.Click
        ' Analyzing a page takes a non-trivial amount of time.
        ' Use the hourglass cursor to warn the user.
        Me.Cursor = Cursors.WaitCursor

        ' Show the title.
        Me.Text = webBrowser1.Document.Title

        treeDOM.SuspendLayout()

        ' Process all the HTML elements on the page.
        ProcessElement(webBrowser1.Document.Body.Children, treeDOM.Nodes)

        treeDOM.ExpandAll()
        treeDOM.ResumeLayout()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ProcessElement(ByVal elements As HtmlElementCollection, _
  ByVal nodes As TreeNodeCollection)

        ' Scan through the collection of elements.
        For Each element As HtmlElement In elements
            ' Create a new node that shows the tag name.
            Dim node As New TreeNode("<" & element.TagName & ">")
            nodes.Add(node)

            If element.Children.Count = 0 And _
              element.InnerText <> String.Empty Then
                ' If this element doesn't contain any other elements, add
                ' any leftover text content as a new node.
                node.Nodes.Add(element.InnerText)
            Else
                ' If this element contains other elements, process them recursively.
                ProcessElement(element.Children, node.Nodes)
            End If
        Next
    End Sub

    Private Sub ExploreDOM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        webBrowser1.Navigate("http://www.nytimes.com")
    End Sub

    Private Sub webBrowser_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles webBrowser1.DocumentCompleted
        cmdBuildTree.Enabled = True
    End Sub
End Class