Public Class Progress

    Public Property Value() As Integer
        Get
            Return Bar.Value
        End Get
        Set(ByVal value As Integer)
            Bar.Value = value
            UpdateLabel()
        End Set
    End Property

    Public Property Maximum() As Integer
        Get
            Return Bar.Maximum
        End Get
        Set(ByVal value As Integer)
            Bar.Maximum = value
        End Set
    End Property

    Public Property [Step]() As Integer
        Get
            Return Bar.Step
        End Get
        Set(ByVal value As Integer)
            Bar.Step = value
        End Set
    End Property

    Public Sub PerformStep()
        Bar.PerformStep()
        UpdateLabel()
    End Sub

    Private Sub UpdateLabel()
        lblProgress.Text = (Bar.Value * 100 / Bar.Maximum).ToString()
        lblProgress.Text &= "% Done"
    End Sub

End Class
