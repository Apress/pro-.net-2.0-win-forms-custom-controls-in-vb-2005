Imports System.IO

Public Class MediaPlayer

    ' The FilgraphManager is the central source for all other interfaces.
    Private graphManager As QuartzTypeLib.FilgraphManager

    ' The IMediaControl interface allows you control playback.
    Private mc As QuartzTypeLib.IMediaControl

    ' IBasicAudio exposes Volume and Balance properties.
    Private audio As QuartzTypeLib.IBasicAudio

    ' IMediaPosition exposes the CurrentPosition property.
    Private position As QuartzTypeLib.IMediaPosition

    ' IMediaEventEx allows you to receive events, including when playback stops.
    Private mEventEx As QuartzTypeLib.IMediaEventEx

    Private Const WM_APP As Integer = &H8000
    Private Const WM_GRAPHNOTIFY As Integer = WM_APP + 1
    Private Const EC_COMPLETE As Integer = &H1


    Private Sub cmdPlay_Click(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles cmdPlay.Click
        If mc Is Nothing Then
            ' This audio is being played for the first time.

            ' Get access to the IMediaControl interface.
            graphManager = New QuartzTypeLib.FilgraphManager()
            mc = CType(graphManager, QuartzTypeLib.IMediaControl)
            audio = CType(graphManager, QuartzTypeLib.IBasicAudio)
            position = CType(graphManager, QuartzTypeLib.IMediaPosition)
            mEventEx = CType(graphManager, QuartzTypeLib.IMediaEventEx)

            ' Load the file.
            Try
                mc.RenderFile(Path.Combine(Application.StartupPath, "test.mp3"))
                mEventEx.SetNotifyWindow(Me.Handle, WM_GRAPHNOTIFY, 0)
            Catch err As FileNotFoundException
                MessageBox.Show("File not found.")
                Return
            End Try
        End If

        ' Start playing the audio asynchronously.
        Try
            statusLabel1.Text = "Total: " & ConvertTimeToString(position.Duration)
            mc.Run()
            timer1.Start()
        Catch err As System.Runtime.InteropServices.COMException
            ' Indicates a problem interpreting the file.
            MessageBox.Show("COM error.")
        End Try
    End Sub

    Private Sub cmdPause_Click(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles cmdPause.Click
        If mc IsNot Nothing Then mc.Pause()
    End Sub

    Private Sub MediaPlayer_FormClosed(ByVal sender As System.Object, _
      ByVal e As System.Windows.Forms.FormClosedEventArgs) _
      Handles MyBase.FormClosed
        If mc IsNot Nothing Then mc.Stop()
    End Sub

    Private Sub cmdStop_Click(ByVal sender As System.Object, _
     ByVal e As System.EventArgs) Handles cmdStop.Click
        If mc IsNot Nothing Then mc.Stop()
        position.CurrentPosition = 0
        statusLabel2.Text = "Current: 00:00:00"
    End Sub

    Private Function ConvertTimeToString(ByVal seconds As Integer) As String
        Dim hours As Integer = seconds \ 3600
        Dim minutes As Integer = (seconds - (hours * 3600)) \ 60
        seconds = seconds - (hours * 3600 + minutes * 60)
        Return String.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds)
    End Function

    Private Sub timer1_Tick(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles timer1.Tick
        If position IsNot Nothing Then
            statusLabel2.Text = "Current: " & _
              ConvertTimeToString(position.CurrentPosition)
        End If
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        ' Check if it's a notification message from the Quartz component.
        If m.Msg = WM_GRAPHNOTIFY Then

            Dim lEventCode, lParam1, lParam2 As Integer
            Try
                ' Retrieve the message.
                mEventEx.GetEvent(lEventCode, lParam1, lParam2, 0)
                mEventEx.FreeEventParams(lEventCode, lParam1, lParam2)

                ' Check if it's the end-of-file message.
                If lEventCode = EC_COMPLETE Then
                    ' Restart the playback.
                    mc.Stop()
                    position.CurrentPosition = 0
                    mc.Run()
                End If
            Catch err As Exception
                ' Never throw an exception from WndProc().
                ' You may want to log it, however.
            End Try
        End If

        ' Pass the message along to .NET.
        MyBase.WndProc(m)
    End Sub

End Class
