Imports System.ComponentModel
Imports System.Drawing.Design

Public Class Progress

    <Description("The current value (between 0 and Maximum) which sets " & _
     "the position of the progress bar")> _
    <Category("Behavior")> _
    <Editor(GetType(ProgressValueEditor), GetType(UITypeEditor))> _
    Public Property Value() As Integer
        Get
            Return Bar.Value
        End Get
        Set(ByVal value As Integer)
            Bar.Value = value
            UpdateLabel()
        End Set
    End Property

    <Description("The maximum value of the progress bar")> _
  <Category("Behavior")> _
  <DefaultValue(100)> _
  Public Property Maximum() As Integer
        Get
            Return Bar.Maximum
        End Get
        Set(ByVal value As Integer)
            Bar.Maximum = value
        End Set
    End Property

    <Description("The increment that the value is increased when PerformStep() is called.")> _
    <Category("Behavior")> _
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
