Imports System.IO

Public Class BitmapViewer

    ' The directory that will be scanned for image.
    Dim _directory As String

    ' Each picture box will be a square of dimension X dimension pixels.
    Dim _dimension As Integer = 80

    ' The space between the images and the top, left, and right sides.
    Dim _border As Integer = 5

    ' The space between each image.
    Dim _spacing As Integer = 10

    ' The images that were found in the selected directory.
    Dim images As New List(Of NamedImage)()

    Public Property Directory() As String
        Get
            Return _directory
        End Get
        Set(ByVal value As String)
            _directory = value
            GetImages()
            UpdateDisplay()
        End Set
    End Property

    Public Property Dimension() As Integer
        Get
            Return _dimension
        End Get
        Set(ByVal value As Integer)
            _dimension = value
            UpdateDisplay()
        End Set
    End Property

    Public Property Spacing() As Integer
        Get
            Return _spacing
        End Get
        Set(ByVal value As Integer)
            _spacing = value
            UpdateDisplay()
        End Set
    End Property

    Public Property Border() As Integer
        Get
            Return _border
        End Get
        Set(ByVal value As Integer)
            _border = value
            UpdateDisplay()
        End Set
    End Property

    Private Sub GetImages()
        If Directory <> "" Then
            images.Clear()
            Dim dir As New DirectoryInfo(Directory)

            For Each file As FileInfo In dir.GetFiles("*.bmp")
                images.Add(New NamedImage(Bitmap.FromFile(file.FullName), _
                  file.FullName))
            Next
        End If
    End Sub

    Private Sub UpdateDisplay()
        ' Suspend layout to prevent multiple window refreshes.
        pnlPictures.SuspendLayout()

        ' Clear the current display.
        For Each ctrl As Control In pnlPictures.Controls
            ctrl.Dispose()
        Next
        pnlPictures.Controls.Clear()

        ' row and col will track the current position where pictures are
        ' being inserted. They begin at the top-left corner.
        Dim row As Integer = border
        Dim col As Integer = border

        ' Iterate through the images collection, and create PictureBox controls.
        For Each image As NamedImage In images
            Dim pic As New PictureBox()
            pic.Image = image.Image
            pic.Tag = image.FileName
            pic.Size = New Size(Dimension, Dimension)
            pic.Location = New Point(col, row)
            pic.BorderStyle = BorderStyle.FixedSingle

            ' StretchImage mode gives us the "thumbnail" ability.
            pic.SizeMode = PictureBoxSizeMode.StretchImage

            ' Display the picture.
            AddHandler pic.Click, AddressOf Me.pic_Click
            pnlPictures.Controls.Add(pic)

            ' Move to the next column.
            col += dimension + spacing

            ' Move to next line if no more pictures will fit.
            If (col + dimension + spacing + border) > Me.Width Then
                col = border
                row += dimension + spacing
            End If
        Next

        pnlPictures.ResumeLayout()
    End Sub

    Public Sub RefreshImages()
        GetImages()
        UpdateDisplay()
    End Sub

    Protected Overrides Sub OnSizeChanged(ByVal e As System.EventArgs)
        UpdateDisplay()
        MyBase.OnSizeChanged(e)
    End Sub

    Public Event PictureSelected(ByVal sender As Object, ByVal e As PictureSelectedEventArgs)
    Private picSelected As PictureBox

    Private Sub pic_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ' Clear the border style from the last selected picture box.
        If picSelected IsNot Nothing Then
            picSelected.BorderStyle = BorderStyle.FixedSingle
        End If

        ' Get the new selection.
        picSelected = CType(sender, PictureBox)
        picSelected.BorderStyle = BorderStyle.Fixed3D

        ' Fire the selection event.
        Dim args As New PictureSelectedEventArgs( _
          picSelected.Image, CType(picSelected.Tag, String))

        RaiseEvent PictureSelected(Me, args)
    End Sub

End Class
