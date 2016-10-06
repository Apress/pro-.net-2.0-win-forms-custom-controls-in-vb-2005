Public Class CustomColorTable
    Inherits ProfessionalColorTable

    Public Overrides ReadOnly Property ToolStripGradientBegin() As Color
        Get
            Return Color.FromArgb(50, 50, 50)
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripGradientMiddle() As Color
        Get
            Return Color.FromArgb(60, 50, 50)
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripGradientEnd() As Color
        Get
            Return Color.LimeGreen
        End Get
    End Property

End Class
