Imports WizardComponent

Public Class RegistrationStep
    Implements IWizardItem

    Public ReadOnly Property HeaderTitle() As String Implements WizardComponent.IWizardItem.HeaderTitle
        Get
            Return "Select a registration method"
        End Get
    End Property

    ' Store the state for this step.
    Private values As New Dictionary(Of String, String)()

    Public Function GetValues() As System.Collections.Generic.Dictionary(Of String, String) Implements WizardComponent.IWizardItem.GetValues
        values.Clear()
        For Each opt As RadioButton In Controls
            If opt.Checked Then
                values.Add(opt.Name, "True")
            End If
        Next
        Return values
    End Function

    Public Sub ApplyValues(ByVal values As System.Collections.Generic.Dictionary(Of String, String)) Implements WizardComponent.IWizardItem.ApplyValues
        Me.values = values
        For Each opt As RadioButton In Controls
            If values(opt.Name) IsNot Nothing Then
                opt.Checked = True
            End If
        Next
    End Sub

End Class
