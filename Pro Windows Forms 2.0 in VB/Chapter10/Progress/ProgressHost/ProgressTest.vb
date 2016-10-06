Public Class ProgressTest

    Private Sub cmdStart_Click(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles cmdStart.Click
        tmrIncrementBar.Stop()

        ' Reset the progress.
        status.Value = 0
        status.Maximum = 20
        status.Step = 1

        ' Start incrementing.
        tmrIncrementBar.Start()
    End Sub


    Private Sub tmrIncrementBar_Tick(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles tmrIncrementBar.Tick
        status.PerformStep()
        If status.Maximum = status.Value Then
            tmrIncrementBar.Stop()
        End If
    End Sub

End Class