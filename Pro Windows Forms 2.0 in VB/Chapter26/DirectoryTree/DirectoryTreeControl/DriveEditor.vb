Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Drawing.Design

Public Class DriveEditor
    Inherits UITypeEditor

    Public Overrides Function GetEditStyle( _
      ByVal context As ITypeDescriptorContext) _
      As System.Drawing.Design.UITypeEditorEditStyle
        ' Use a dialog box for property editing.
        Return UITypeEditorEditStyle.Modal
    End Function

    Public Overrides Function EditValue( _
      ByVal context As ITypeDescriptorContext, _
      ByVal provider As IServiceProvider, ByVal value As Object) _
      As Object
        Dim frm As New SelectDrive()

        ' Set current drive in window.
        frm.DriveSelection = CType(value, Char)

        ' Show the dialog box.
        If frm.ShowDialog() = DialogResult.OK Then
            ' Return the new value.
            Return frm.DriveSelection
        Else
            ' Return the old value.
            Return value
        End If
    End Function

    Public Overrides Function GetPaintValueSupported( _
      ByVal context As ITypeDescriptorContext) As Boolean
        ' No special thumbnail will be shown in the Properties window.
        Return False
    End Function

End Class
