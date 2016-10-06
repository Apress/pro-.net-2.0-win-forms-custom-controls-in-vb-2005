Public Class ControlBased

    Private Sub ControlBased_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HelpProvider1.HelpNamespace = "sample.chm"
        HelpProvider1.SetHelpKeyword(TextBox1, "1007.html")
        HelpProvider1.SetHelpNavigator(TextBox1, HelpNavigator.Topic)
        HelpProvider1.SetHelpKeyword(ListBox1, "1006.html")
        HelpProvider1.SetHelpNavigator(ListBox1, HelpNavigator.Topic)
    End Sub
End Class