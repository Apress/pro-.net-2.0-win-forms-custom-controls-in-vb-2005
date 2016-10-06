Public Class Player

    Private WithEvents player As New System.Media.SoundPlayer

    Private Sub selectFileButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectFileButton.Click
        ' Create a new OpenFileDialog.
        Dim dlg As New OpenFileDialog()

        ' Make sure the dialog checks for existence of the 
        ' selected file.
        dlg.CheckFileExists = True

        ' Allow selection of .wav files only.
        dlg.Filter = "WAV files (*.wav)|*.wav"
        dlg.DefaultExt = ".wav"

        ' Activate the file selection dialog.
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then

            ' Get the selected file's path from the dialog.
            filepathTextbox.Text = dlg.FileName

            ' Assign the selected file path.  
            player.SoundLocation = filepathTextbox.Text
        End If
    End Sub

    ' Convenience method for setting message text in 
    ' the status bar.
    Private Sub ReportStatus(ByVal statusMessage As String)
        ' If the caller passed in a message...
        If statusMessage <> String.Empty Then
            ' ...post the caller's message to the status bar.
            statusLabel.Text = statusMessage
        End If
    End Sub

    ' Enables and disables play controls.
    Private Sub EnablePlaybackControls(ByVal enabled As Boolean)
        playOnceSyncButton.Enabled = enabled
        playOnceAsyncButton.Enabled = enabled
        playLoopAsyncButton.Enabled = enabled
        stopButton.Enabled = enabled
    End Sub

    Private Sub loadSyncButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loadSyncButton.Click
        ' Disable playback controls until the .wav is 
        ' successfully loaded. The LoadCompleted event 
        ' handler will enable them.
        EnablePlaybackControls(False)

        Try
            ' Assign the selected file path.  
            player.SoundLocation = filepathTextbox.Text

            ' Load the .wav file.
            player.Load()

        Catch err As Exception
            ReportStatus(err.Message)
        End Try
    End Sub

    Private Sub loadAsyncButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loadAsyncButton.Click
        ' Disable playback controls until the .wav is 
        ' successfully loaded. The LoadCompleted event 
        ' handler will enable them.
        EnablePlaybackControls(False)

        Try
            ' Assign the selected file path.  
            player.SoundLocation = filepathTextbox.Text

            ' Load the .wav file.
            player.LoadAsync()

        Catch err As Exception
            ReportStatus(err.Message)
        End Try
    End Sub

    ' Synchronously plays the selected .wav file once.
    ' If the file is large, UI response will be visibly 
    ' affected.
    Private Sub playOnceSyncButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playOnceSyncButton.Click
        ReportStatus("Playing .wav file synchronously.")
        player.PlaySync()
        ReportStatus("Finished playing .wav file synchronously.")
    End Sub

    ' Asynchronously plays the selected .wav file once.
    Private Sub playOnceAsyncButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playOnceAsyncButton.Click
        ReportStatus("Playing .wav file asynchronously.")
        player.Play()
    End Sub

    ' Asynchronously plays the selected .wav file until the user
    ' clicks the Stop button.
    Private Sub playLoopAsyncButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playLoopAsyncButton.Click
        ReportStatus("Looping .wav file asynchronously.")
        player.PlayLooping()
    End Sub

    ' Stops the currently playing .wav file, if any.
    Private Sub stopButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stopButton.Click
        player.Stop()
        ReportStatus("Stopped by user.")
    End Sub

    Private Sub sound_LoadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) _
      Handles player.LoadCompleted
        Dim message As String = String.Format("LoadCompleted: {0}", filepathTextbox.Text)
        ReportStatus(message)
        EnablePlaybackControls(True)
    End Sub

    Private Sub sound_LocationChanged(ByVal sender As Object, ByVal e As EventArgs) _
      Handles player.SoundLocationChanged
        Dim message As String = String.Format("SoundLocationChanged: {0}", player.SoundLocation)
        ReportStatus(message)
    End Sub

    Private Sub Player_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Media.SystemSounds.Beep.Play()
    End Sub
End Class
