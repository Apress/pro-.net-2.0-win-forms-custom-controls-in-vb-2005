Public Class AutoProgress

    Private _percentPerSecond As Integer = 5
    Public Property PercentPerSecond() As Integer
        Get
            Return _percentPerSecond
        End Get
        Set(ByVal value As Integer)
            If value < 0 Then
                Throw New ArgumentException("Progress cannot go backward.")
            ElseIf value = 0 Then
                Throw New ArgumentException("Progress must go on.")
            End If
            _percentPerSecond = value
        End Set
    End Property

    Public Sub Start()
        ' The maximum controls how fine-grained
        ' the progress bar is. 200 is a good choice.
        Bar.Maximum = 200

        ' Calculation is based on a timer that
        ' fires 10 times per second (an interval of 100).
        tmrIncrementBar.Interval = 100
        Dim timerStep As Single = Bar.Maximum * PercentPerSecond / 1000
        Bar.Step = Int(timerStep)

        ' Reset the progress and start counting.
        Bar.Value = 0
        tmrIncrementBar.Start()
    End Sub

    Public Sub [Stop]()
        tmrIncrementBar.Stop()
        Bar.Value = 0
    End Sub

    Public Sub Finish()
        tmrIncrementBar.Stop()
        Bar.Value = Bar.Maximum
    End Sub

    Private Sub tmrIncrementBar_Tick(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles tmrIncrementBar.Tick
        Bar.PerformStep()
        If Bar.Value = Bar.Maximum Then
            Bar.Value = 0
        End If
    End Sub

End Class
