Public Class FormBased

    Private Sub FormBased_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HelpProvider1.HelpNamespace = "sample.chm"
        HelpProvider1.SetHelpKeyword(Me, "1001.html")
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.Topic)
    End Sub
End Class