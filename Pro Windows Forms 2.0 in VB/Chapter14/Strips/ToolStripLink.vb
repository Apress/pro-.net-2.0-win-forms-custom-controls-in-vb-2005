Public Class ToolStripLink

    Private Sub ToolStripLinkLabel_Click(ByVal sender As Object, ByVal e As EventArgs) _
   Handles ToolStripLinkLabel.Click
        Dim lbl As ToolStripLabel = CType(sender, ToolStripLabel)
        Try
            Process.Start(New ProcessStartInfo(lbl.Tag.ToString()))
        Catch Err As Exception
            MessageBox.Show("Error launching browser.")
        End Try
    End Sub

End Class