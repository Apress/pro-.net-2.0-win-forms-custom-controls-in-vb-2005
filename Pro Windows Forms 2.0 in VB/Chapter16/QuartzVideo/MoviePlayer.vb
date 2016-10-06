Imports QuartzTypeLib
Imports System.IO

Public Class MoviePlayer

    Private Const WS_CHILD As Integer = &H40000000
    Private Const WS_CLIPCHILDREN As Integer = &H2000000

    Private mc As QuartzTypeLib.IMediaControl
    Private videoWindow As QuartzTypeLib.IVideoWindow

    Private Sub MoviePlayer_FormClosed(ByVal sender As System.Object, _
      ByVal e As System.Windows.Forms.FormClosedEventArgs) _
      Handles MyBase.FormClosed
        If mc IsNot Nothing Then mc.Stop()
    End Sub

    Private Sub pictureBox1_SizeChanged(ByVal sender As System.Object, _
     ByVal e As System.EventArgs) Handles pictureBox1.SizeChanged

        If videoWindow IsNot Nothing Then
            Try
                videoWindow.SetWindowPosition( _
                  pictureBox1.ClientRectangle.Left, pictureBox1.ClientRectangle.Top, _
                  pictureBox1.ClientRectangle.Width, _
                  pictureBox1.ClientRectangle.Height)
            Catch
                ' Ignore the exception thrown when resizing the form
                ' when the file does not have a video source.
            End Try
        End If
    End Sub


    Private Sub cmdOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpen.Click
        ' Allow the user to choose a file.
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Media Files|*.mpg;*.avi;*.wma;*.mov;*.wav;*.mp2;*.mp3|All Files|*.*"

        If openFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ' Stop the playback for the current movie, if it exists.
            If mc IsNot Nothing Then mc.Stop()
            mc = Nothing
            videoWindow = Nothing

            ' Load the movie file.
            Dim graphManager As New FilgraphManager()
            graphManager.RenderFile(openFileDialog.FileName)

            ' Attach the view to a picture box on the form.
            Try
                videoWindow = CType(graphManager, IVideoWindow)
                videoWindow.Owner = pictureBox1.Handle
                videoWindow.WindowStyle = WS_CHILD Or WS_CLIPCHILDREN
                videoWindow.SetWindowPosition(pictureBox1.ClientRectangle.Left, _
                        pictureBox1.ClientRectangle.Top, _
                        pictureBox1.ClientRectangle.Width, _
                        pictureBox1.ClientRectangle.Height)
            Catch

                ' An error can occur if the file does not have a vide
                ' source (for example, an MP3 file.)
                ' You can ignore this error and still allow playback to
                ' continue (without any visualization).
            End Try

            ' Start the playback (asynchronously).
            mc = CType(graphManager, IMediaControl)
            mc.Run()
        End If
    End Sub

End Class
