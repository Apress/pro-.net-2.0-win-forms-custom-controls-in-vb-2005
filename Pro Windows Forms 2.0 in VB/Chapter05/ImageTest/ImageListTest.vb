Imports System.IO

Public Class ImageListTest

    Private Sub cmdFillImageList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFillImageList.Click
        ' Configure the ImageList.
        iconImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        iconImages.ImageSize = New System.Drawing.Size(16, 16)

        ' Get all the icon files in the current directory.
        Dim iconFiles() As String = Directory.GetFiles( _
          Application.StartupPath, "*.ico")

        ' Create an Image object for each file and add it to the ImageList.
        ' You can also use an Image subclass (like Icon).
        For Each iconFile As String In iconFiles
            Dim newIcon As New Icon(iconFile)
            iconImages.Images.Add(newIcon)
        Next
    End Sub

    Private Sub cmdPaintImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPaintImages.Click
        ' Get the graphics device context for the form.
        Dim g As Graphics = Me.CreateGraphics()

        ' Draw each image using the ImageList.Draw() method.
        For i As Integer = 0 To iconImages.Images.Count - 1
            iconImages.Draw(g, 30 + i * 30, 30, i)
        Next

        ' Release the graphics device context.
        g.Dispose()

    End Sub
End Class