Public Class Wizard

    Private currentStep As Integer
    Private totalSteps As Integer
    Private steps As List(Of IWizardItem)

    Public Sub New(ByVal steps As List(Of IWizardItem))
        InitializeComponent()
        If steps.Count > 0 Then
            Me.steps = steps
            totalSteps = steps.Count
            currentStep = 1
            ShowStep()
        End If
    End Sub

    Public Sub New(ByVal steps As List(Of IWizardItem), ByVal state() As Dictionary(Of String, String))
        Me.New(steps)
        _state = state
    End Sub

    Private Sub ShowStep()
        ' Update buttons.
        cmdPrev.Visible = (currentStep <> 1)

        If currentStep = totalSteps Then
            cmdNext.Text = "Finish"
        Else
            cmdNext.Text = "Next >"
        End If

        ' Get headings.
        lblHeader.Text = steps(currentStep - 1).HeaderTitle
        Text = "Step " & currentStep & " of " & totalSteps

        ' See if there's state to be restored.
        If State IsNot Nothing AndAlso State(currentStep - 1) IsNot Nothing Then
            steps(currentStep - 1).ApplyValues(State(currentStep - 1))
        End If

        ' Show step content.
        panelStep.Controls.Clear()
        Dim ctrl As UserControl = CType(steps(currentStep - 1), UserControl)
        panelStep.Controls.Add(ctrl)
    End Sub

    Private _state() As Dictionary(Of String, String)
    Public ReadOnly Property State() As Dictionary(Of String, String)()
        Get
            Return _state
        End Get
    End Property


    Private Sub cmdPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrev.Click
        currentStep -= 1
        ShowStep()
    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        If currentStep = totalSteps Then
            ' The Finish button was clicked.
            ' Save the state and close the form.  
            ReDim _state(totalSteps)

            For i As Integer = 0 To totalSteps - 1
                State(i) = steps(i).GetValues()
            Next
            Close()
        Else
            currentStep += 1
            ShowStep()
        End If

    End Sub
End Class