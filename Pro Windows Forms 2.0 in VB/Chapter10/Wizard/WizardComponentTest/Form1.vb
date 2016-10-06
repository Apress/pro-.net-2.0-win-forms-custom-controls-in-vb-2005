Imports WizardComponent

Public Class Form1

    Private items As New List(Of IWizardItem)()

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        items.Add(New NameStep())
        items.Add(New RegistrationStep())
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Dim wizard As New Wizard(items)
        wizard.ShowDialog()
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        For Each item As IWizardItem In items

            Dim text As String = ""
            For Each setting As KeyValuePair(Of String, String) In item.GetValues()
                text &= String.Format("Key: {0}, Value: {1}", setting.Key, setting.Value)
                text &= vbNewLine
            Next
            MessageBox.Show(text)
        Next
    End Sub
End Class
