Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Windows.Forms.Design

Public Class ProgressValueEditor
    Inherits UITypeEditor

    Public Overrides Function GetEditStyle( _
  ByVal context As ITypeDescriptorContext) _
  As System.Drawing.Design.UITypeEditorEditStyle
        Return UITypeEditorEditStyle.DropDown
    End Function

    Public Overrides Function GetPaintValueSupported( _
      ByVal context As ITypeDescriptorContext) _
      As Boolean
        Return False
    End Function

    Public Overrides Function EditValue( _
 ByVal context As ITypeDescriptorContext, _
 ByVal provider As IServiceProvider, ByVal value As Object) _
  As Object
        If provider IsNot Nothing Then
            Dim editorService As IWindowsFormsEditorService = _
             CType(provider.GetService(GetType(IWindowsFormsEditorService)), _
              IWindowsFormsEditorService)

            If editorService IsNot Nothing Then
                ' Create the editing control.
                Dim ctrl As Progress = CType(context.Instance, Progress)
                Dim selectionControl As New ProgressValueDropDown( _
                   CInt(value), ctrl.Maximum, editorService)

                ' Show the editing control.
                editorService.DropDownControl(selectionControl)
                value = selectionControl.ProgressValue
            End If
        End If
        Return value
    End Function

End Class
