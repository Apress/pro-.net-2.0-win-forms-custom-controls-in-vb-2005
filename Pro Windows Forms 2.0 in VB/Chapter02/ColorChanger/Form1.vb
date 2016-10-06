Public Class Form1

    Private Sub ColorChanger_Load(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles MyBase.Load
        Dim colorNames() As String
        colorNames = System.Enum.GetNames(GetType(KnownColor))
        lstColors.Items.AddRange(colorNames)
    End Sub

    Private Sub lstColors_SelectedIndexChanged(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles lstColors.SelectedIndexChanged
        Dim selectedColorObject As Object
        selectedColorObject = [Enum].Parse(GetType(KnownColor), lstColors.Text)

        Dim selectedColor As KnownColor
        selectedColor = CType(selectedColorObject, KnownColor)

        Me.BackColor = System.Drawing.Color.FromKnownColor(selectedColor)

        ' Display color information.
        lblBrightness.Text = "Brightness = " & _
          Me.BackColor.GetBrightness().ToString()
        lblHue.Text = "Hue = " & Me.BackColor.GetHue().ToString()
        lblSaturation.Text = "Saturation = " & _
          Me.BackColor.GetSaturation().ToString()
    End Sub

End Class
