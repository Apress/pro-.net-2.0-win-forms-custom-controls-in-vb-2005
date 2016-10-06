Public Class Form1

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        MessageBox.Show("When in the design dialog, you can select and move controls.  Other properties can be set using the property grid. Close the dialog to save the changes.")
        Me.DesignModeDialog1.ShowDialog()
    End Sub
End Class
