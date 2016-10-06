Public Class Form1

    Private Sub cmdCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCapture.Click
        If pictureBox1.Image IsNot Nothing Then
            pictureBox1.Image.Dispose()
        End If

        Dim bmp As New Bitmap(Screen.PrimaryScreen.Bounds.Width, _
          Screen.PrimaryScreen.Bounds.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)
        g.CopyFromScreen(0, 0, 0, 0, bmp.Size)
        g.Dispose()
        pictureBox1.Image = bmp
        pictureBox1.Size = bmp.Size

    End Sub
End Class
