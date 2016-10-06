Imports WizardComponent

Public Class NameStep
    Implements IWizardItem

    Public ReadOnly Property HeaderTitle() As String Implements WizardComponent.IWizardItem.HeaderTitle
        Get
            Return "Please enter your first and last name."
        End Get
    End Property
    
    ' Store the state for this step.
    Private values As New Dictionary(Of String, String)()

    Public Function GetValues() As System.Collections.Generic.Dictionary(Of String, String) Implements WizardComponent.IWizardItem.GetValues
        values.Clear()
        values.Add("FirstName", txtFirstName.Text)
        values.Add("LastName", txtLastName.Text)
        Return values
    End Function

    Public Sub ApplyValues(ByVal values As System.Collections.Generic.Dictionary(Of String, String)) Implements WizardComponent.IWizardItem.ApplyValues
        Me.values = values
        txtFirstName.Text = values("FirstName")
        txtFirstName.Text = values("LastName")
    End Sub


End Class
