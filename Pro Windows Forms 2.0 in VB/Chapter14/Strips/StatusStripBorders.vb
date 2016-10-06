Public Class StatusStripBorders

    Private Sub StatusStripBorders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim names() As String = [Enum].GetNames(GetType(Border3DStyle))
        comboBox1.Items.AddRange(names)
        comboBox2.Items.AddRange(names)
        comboBox3.Items.AddRange(names)
        names = [Enum].GetNames(GetType(ToolStripStatusLabelBorderSides))
        checkedListBox1.Items.AddRange(names)
        checkedListBox2.Items.AddRange(names)
        checkedListBox3.Items.AddRange(names)
        groupBox1.Tag = toolStripStatusLabel1
        groupBox2.Tag = toolStripStatusLabel2
        groupBox3.Tag = toolStripStatusLabel3

        comboBox1.Text = toolStripStatusLabel1.BorderStyle.ToString()
        comboBox2.Text = toolStripStatusLabel2.BorderStyle.ToString()
        comboBox3.Text = toolStripStatusLabel3.BorderStyle.ToString()
    End Sub

    Private Sub comboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles comboBox1.SelectedIndexChanged, comboBox2.SelectedIndexChanged, comboBox3.SelectedIndexChanged
        Dim selection As Border3DStyle
        Dim ctrl As Control = CType(sender, Control)
        selection = CType([Enum].Parse(GetType(Border3DStyle), ctrl.Text), Border3DStyle)
        Dim lbl As ToolStripStatusLabel = CType(ctrl.Parent.Tag, ToolStripStatusLabel)
        If lbl IsNot Nothing Then lbl.BorderStyle = selection
    End Sub

  
    Private Sub checkedListBox_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) _
      Handles checkedListBox1.ItemCheck, checkedListBox2.ItemCheck, checkedListBox3.ItemCheck
        Dim ctrl As CheckedListBox = CType(sender, CheckedListBox)
        Dim lbl As ToolStripStatusLabel = CType(ctrl.Parent.Tag, ToolStripStatusLabel)
        Dim selection As ToolStripStatusLabelBorderSides = CType([Enum].Parse(GetType(ToolStripStatusLabelBorderSides), ctrl.Items(e.Index)), ToolStripStatusLabelBorderSides)

        If e.NewValue = CheckState.Checked Then
            lbl.BorderSides = lbl.BorderSides Or selection
        Else
            lbl.BorderSides = lbl.BorderSides And Not selection
        End If
    End Sub
End Class