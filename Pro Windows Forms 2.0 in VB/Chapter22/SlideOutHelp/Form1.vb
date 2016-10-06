Public Class Form1

    Private Sub cmdShowHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShowHide.Click
        splitContainer1.Panel2Collapsed = True
    End Sub

    Private Sub toolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripButton1.Click
        splitContainer1.Panel2Collapsed = False
    End Sub

    Private Sub textBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles textBox1.Enter, textBox2.Enter, textBox3.Enter
        Dim ctrl As Control = CType(sender, Control)
        webBrowser1.Navigate(Application.StartupPath & "\..\..\Help\" & ctrl.Tag)

    End Sub
End Class
