Imports System.ComponentModel
Imports System.Drawing.Text

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' These are our final data sources: two ArrayList objects.
        Dim fontList As New List(Of Font)()
        Dim colorList As New List(Of Color)()

        ' The InstalledFonts collection allows us to enumerate installed fonts.
        ' Each FontFamily needs to be converted to a genuine Font object
        ' before it is suitable for data binding to the Control.Font property.
        Dim fonts As New InstalledFontCollection()
        For Each family As FontFamily In fonts.Families
            Try
                fontList.Add(New Font(family, 12))
            Catch
                ' We end up here if the font could not be created
                ' with the default style.
            End Try
        Next

        ' To retrieve the list of colors, we need to first retrieve
        ' the strings for the KnownColor enumeration, and then convert each one
        ' into a suitable color object.
        Dim colorNames() As String
        colorNames = System.Enum.GetNames(GetType(KnownColor))
        Dim cnvrt As TypeConverter = TypeDescriptor.GetConverter(GetType(KnownColor))


        For Each colorName As String In colorNames
            colorList.Add( _
              Color.FromKnownColor( _
                CType(cnvrt.ConvertFromString(colorName), KnownColor)))
        Next

        ' We can now bind both of our list controls.
        lstColors.DataSource = colorList
        lstColors.DisplayMember = "Name"
        lstFonts.DataSource = fontList
        lstFonts.DisplayMember = "Name"

        ' The label is bound to both data sources.
        lblSampleText.DataBindings.Add("ForeColor", colorList, "")
        lblSampleText.DataBindings.Add("Font", fontList, "")

    End Sub
End Class
