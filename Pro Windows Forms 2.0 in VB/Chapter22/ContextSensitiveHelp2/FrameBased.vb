Public Class FrameBased

    Private Sub FrameBased_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HelpProvider1.HelpNamespace = "sample.chm"
        HelpProvider1.SetHelpKeyword(GroupBox1, "1003.html")
        HelpProvider1.SetHelpNavigator(GroupBox1, HelpNavigator.Topic)
        HelpProvider1.SetHelpKeyword(GroupBox2, "1004.html")
        HelpProvider1.SetHelpNavigator(GroupBox2, HelpNavigator.Topic)
    End Sub
End Class