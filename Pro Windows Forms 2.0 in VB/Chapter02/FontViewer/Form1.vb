Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fonts As New System.Drawing.Text.InstalledFontCollection()
        For Each family As FontFamily In fonts.Families
            lstFonts.Items.Add(family.Name)
        Next
    End Sub

    Private Sub lstFonts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFonts.SelectedIndexChanged
        Me.Invalidate()
    End Sub

    Private Sub Form1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        If lstFonts.SelectedIndex <> -1 Then
            Try
                e.Graphics.DrawString(lstFonts.Text, New Font(lstFonts.Text, 50), Brushes.Black, 10, 50)
                statusBar.Items(0).Text = ""
            Catch err As ArgumentException
                statusBar.Items(0).Text = err.Message
            End Try
        End If
    End Sub
End Class
