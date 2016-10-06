Imports System.Drawing.Text
Imports System.IO

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Create color list.
        Dim colorNames() As String
        colorNames = System.Enum.GetNames(GetType(KnownColor))
        For Each colorName As String In colorNames
            lstColors.DropDown.Items.Add(colorName)
        Next

        ' Create font list.
        Dim fonts As New InstalledFontCollection()
        For Each family As FontFamily In fonts.Families
            lstFonts.DropDown.Items.Add(family.Name)
        Next

        ' Create zoom list.
        For i As Integer = 25 To 525 Step 25
            lstZoom.DropDown.Items.Add(i.ToString() & "%")
        Next

        ' Create font size list.
        For i As Integer = 5 To 60 Step 5
            lstFontSize.DropDown.Items.Add(i.ToString())
        Next
    End Sub

    Private Sub cmdBold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBold.Click
        If richTextBox1.SelectionFont Is Nothing Then
            ' The selection includes multiple fonts. Sadly, there's
            ' no way to get information about any of them.
            ' You could fall back on the RichTextBox.Font property,
            ' but if you make any change to the SelectionFont you will
            ' override the current fonts, so it's safer to do nothing.
            Return
        End If

        ' Get the current style.
        Dim style As FontStyle = richTextBox1.SelectionFont.Style

        ' Adjust as required.
        If richTextBox1.SelectionFont.Bold Then
            style = style And Not FontStyle.Bold
        Else
            style = style Or FontStyle.Bold
        End If

        ' Assign font with new style.
        richTextBox1.SelectionFont = New Font(richTextBox1.SelectionFont, style)
    End Sub

    Private Sub cmdItalic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdItalic.Click
        If richTextBox1.SelectionFont Is Nothing Then
            ' The selection includes multiple fonts. Sadly, there's
            ' no way to get information about any of them.
            ' You could fall back on the RichTextBox.Font property,
            ' but if you make any change to the SelectionFont you will
            ' override the current fonts, so it's safer to do nothing.
            Return
        End If

        ' Get the current style.
        Dim style As FontStyle = richTextBox1.SelectionFont.Style

        ' Adjust as required.
        If richTextBox1.SelectionFont.Italic Then
            style = style And Not FontStyle.Italic
        Else
            style = style Or FontStyle.Italic
        End If

        ' Assign font with new style.
        richTextBox1.SelectionFont = New Font(richTextBox1.SelectionFont, style)
    End Sub


    Private Sub cmdUnderline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnderline.Click
        If richTextBox1.SelectionFont Is Nothing Then
            ' The selection includes multiple fonts. Sadly, there's
            ' no way to get information about any of them.
            ' You could fall back on the RichTextBox.Font property,
            ' but if you make any change to the SelectionFont you will
            ' override the current fonts, so it's safer to do nothing.
            Return
        End If

        ' Get the current style.
        Dim style As FontStyle = richTextBox1.SelectionFont.Style

        ' Adjust as required.
        If richTextBox1.SelectionFont.Underline Then
            style = style And Not FontStyle.Underline
        Else
            style = style Or FontStyle.Underline
        End If

        ' Assign font with new style.
        richTextBox1.SelectionFont = New Font(richTextBox1.SelectionFont, style)
    End Sub


    Private Sub lstColors_DropDownItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles lstColors.DropDownItemClicked
        Dim selectedColor As KnownColor
        selectedColor = CType( _
        System.Enum.Parse(GetType(KnownColor), e.ClickedItem.Text), KnownColor)
        richTextBox1.SelectionColor = Color.FromKnownColor(selectedColor)
    End Sub

    Private Sub lstFonts_DropDownItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles lstFonts.DropDownItemClicked

        If richTextBox1.SelectionFont Is Nothing Then
            ' The selection includes multiple fonts. Sadly,
            ' there's no way to get information about any
            ' of them.
            ' We'll ignore this command.
            Return
        End If
        Try
            richTextBox1.SelectionFont = New Font(e.ClickedItem.Text, richTextBox1.SelectionFont.Size)
        Catch
            ' Some rogue fonts might not support regular style.
        End Try

    End Sub

    Private Sub lstFontSize_DropDownItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles lstFontSize.DropDownItemClicked
        If richTextBox1.SelectionFont Is Nothing Then
            ' The selection includes multiple fonts. Sadly,
            ' there's no way to get information about any
            ' of them.
            ' We'll ignore this command.
            Return
        End If
        richTextBox1.SelectionFont = _
            New Font(richTextBox1.SelectionFont.FontFamily, _
            CSng(e.ClickedItem.Text), richTextBox1.SelectionFont.Style)
    End Sub

    Private Sub lstZoom_DropDownItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles lstZoom.DropDownItemClicked
        Dim zoomPercent As Single = Val(e.ClickedItem.Text)
        richTextBox1.ZoomFactor = zoomPercent / 100
    End Sub

    Private Sub cmdAddImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddImage.Click
        ' Get the image.
        Dim img As Image = Image.FromFile( _
          Path.Combine(Application.StartupPath, "planet.jpg"))

        ' Place it on the clipboard.
        Clipboard.SetImage(img)

        ' Move to the start of the text box.
        richTextBox1.SelectionStart = 0

        ' Paste the image.
        richTextBox1.Paste()

        ' Optionally, remove the data from the clipboard.
        Clipboard.Clear()

    End Sub

    Private Sub richTextBox1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles richTextBox1.SelectionChanged
        If richTextBox1.SelectionFont IsNot Nothing Then
            cmdBold.Checked = richTextBox1.SelectionFont.Bold
            cmdItalic.Checked = richTextBox1.SelectionFont.Italic
            cmdUnderline.Checked = richTextBox1.SelectionFont.Underline
        End If
    End Sub
End Class
