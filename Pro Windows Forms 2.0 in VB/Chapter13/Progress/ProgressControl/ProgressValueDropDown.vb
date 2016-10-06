Imports System.ComponentModel
Imports System.Windows.Forms.Design

<ToolboxItem(False)> _
Public Class ProgressValueDropDown

    Private _progressValue As Integer
    Public Property ProgressValue() As Integer
        Get
            Return _progressValue
        End Get
        Set(ByVal value As Integer)
            _progressValue = value
        End Set
    End Property

    Private editorService As IWindowsFormsEditorService

    Public Sub New(ByVal value As Integer, ByVal maximum As Integer, _
     ByVal editorService As IWindowsFormsEditorService)
        InitializeComponent()

        ' Store this information for later use.
        Me.ProgressValue = value
        Me.editorService = editorService

        ' Apply the current information.
        trackBar1.Maximum = maximum
        lblRange.Text = "Allowed Range: (0, " & maximum.ToString() & ")"
        trackBar1.Value = value

        trackBar1.SmallChange = 1
        trackBar1.LargeChange = 5
    End Sub

    Public Sub New()
        ' Default constructor required for designing
        ' this control in Visual Studio.
        InitializeComponent()
    End Sub

    Private Sub trackBar1_ValueChanged(ByVal sender As Object, _
  ByVal e As EventArgs) Handles trackBar1.ValueChanged
        ProgressValue = trackBar1.Value
        lblValue.Text = "Current Value = " & trackBar1.Value.ToString()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As Object, ByVal e As EventArgs) _
  Handles cmdClose.Click
        editorService.CloseDropDown()
    End Sub

End Class
