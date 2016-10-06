

Public Interface IWizardItem

    ReadOnly Property HeaderTitle() As String

    Function GetValues() As Dictionary(Of String, String)
    Sub ApplyValues(ByVal values As Dictionary(Of String, String))

End Interface
