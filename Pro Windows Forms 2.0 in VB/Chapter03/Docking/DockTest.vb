Imports System.ComponentModel

Public Class DockTest
    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Me.DockPadding.All = udDockPaddingForm.Value
        pnlDock.DockPadding.All = udDockPaddingPanel.Value

        ' Now we use some rather unusual code to translate the string
        '  in the listbox into an enumeration object that can be used
        '  to set the Dock property.
        ' This looks quite strange, but is actually just one more
        '  part of the shared class library.

        ' First we get the converter that can do the job.
        Dim Converter As TypeConverter
        Converter = TypeDescriptor.GetConverter(Dock.GetType)

        ' Then we use it to convert the string.
        pnlDock.Dock = Converter.ConvertFromString(lstDockPanel.Text)
        txtDock.Dock = Converter.ConvertFromString(lstDockTextBox.Text)
    End Sub

    Private Sub DockForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstDockPanel.Items.AddRange([Enum].GetNames(Dock.GetType))
        lstDockTextBox.Items.AddRange([Enum].GetNames(Dock.GetType))
        lstDockPanel.Text = pnlDock.Dock.ToString()
        lstDockTextBox.Text = txtDock.Dock.ToString()
    End Sub
End Class