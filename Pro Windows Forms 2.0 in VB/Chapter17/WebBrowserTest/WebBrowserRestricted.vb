Public Class WebBrowserRestricted
    Private Sub WebBrowserRestricted_Load(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles MyBase.Load
        webBrowser1.Navigate("http://msdn.microsoft.com")
    End Sub

    Private Sub webBrowser1_Navigating(ByVal sender As System.Object, _
      ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) _
      Handles webBrowser1.Navigating
        ' Here you decide whether to allow navigation to the selected page.

        ' Check the domain.
        ' In this case, allow only the home site.
        If Not e.Url.Host.Contains("microsoft.com") Then
            MessageBox.Show("Site restricted for demonstration purposes.")
            e.Cancel = True
        End If
    End Sub

    Private Sub webBrowser1_Navigated(ByVal sender As System.Object, _
      ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) _
      Handles webBrowser1.Navigated
        ' Show the progress bar.
        progressBar.Visible = True
    End Sub

    Private Sub webBrowser1_ProgressChanged(ByVal sender As System.Object, _
      ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) _
      Handles webBrowser1.ProgressChanged
        ' Update the progress bar.
        progressBar.Maximum = CInt(e.MaximumProgress)
        If e.CurrentProgress >= 0 And e.CurrentProgress <= e.MaximumProgress Then
            progressBar.Value = CInt(e.CurrentProgress)
        End If
    End Sub

    Private Sub webBrowser1_DocumentCompleted(ByVal sender As System.Object, _
      ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) _
      Handles webBrowser1.DocumentCompleted
        ' Hide the progress bar.
        progressBar.Visible = False
    End Sub

    Private Sub webBrowser1_StatusTextChanged(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles webBrowser1.StatusTextChanged
        ' Display the text that IE would ordinarily show
        ' in the status bar.
        statusBar.Text = webBrowser1.StatusText
    End Sub

    Private Sub webBrowser1_NewWindow(ByVal sender As Object, _
      ByVal e As System.ComponentModel.CancelEventArgs) _
      Handles webBrowser1.NewWindow
        ' Never allow external windows.
        e.Cancel = True
    End Sub

End Class