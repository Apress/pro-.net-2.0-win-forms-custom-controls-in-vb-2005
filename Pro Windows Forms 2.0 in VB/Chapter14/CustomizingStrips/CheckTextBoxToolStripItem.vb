Imports System.Windows.Forms.Design

<ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip Or _
 ToolStripItemDesignerAvailability.StatusStrip)> _
Public Class CheckTextBoxToolStripItem
    Inherits ToolStripControlHost

    ' Controls in this item.
    Private controlPanel As New FlowLayoutPanel
    Private chk As New CheckBox()
    Private txt As New TextBox()

    Public Sub New()
        MyBase.New(New FlowLayoutPanel())

        ' Set up the FlowLayouPanel.
        controlPanel = CType(MyBase.Control, FlowLayoutPanel)
        controlPanel.BackColor = Color.Transparent

        ' Add two child controls.
        chk.AutoSize = True
        controlPanel.Controls.Add(chk)
        controlPanel.Controls.Add(txt)
        TextEnabled = True

        AddHandler chk.CheckedChanged, AddressOf CheckedChanged
    End Sub

    Public Property TextEnabled() As Boolean
        Get
            Return chk.Checked
        End Get
        Set(ByVal value As Boolean)
            chk.Checked = value
        End Set
    End Property

    Private Sub CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        ' Enable or disable the TextBox according to the 
        ' current CheckBox selection.
        txt.Enabled = TextEnabled
    End Sub

End Class
