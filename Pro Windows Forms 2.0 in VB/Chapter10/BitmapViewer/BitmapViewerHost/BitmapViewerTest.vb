Public Class BitmapViewerTest

    Private Sub BitmapViewerTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BitmapViewer1.Directory = Application.StartupPath
    End Sub

    Private Sub bitmapViewer1_PictureSelected(ByVal sender As Object, _
  ByVal e As BitmapViewerControls.PictureSelectedEventArgs)
        MessageBox.Show("You chose " & e.FileName)
    End Sub

End Class