Imports System.IO
Imports System.Threading

Public Class ImprovedBitmapViewer

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

    Public ReadOnly Property Directory() As String
        Get
            Return _directory
        End Get
    End Property

    Public Property Dimension() As Integer
        Get
            Return _dimension
        End Get
        Set(ByVal value As Integer)
            _dimension = value
            GetImages()
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

    Private Sub UpdateDisplay()
        ' Suspend layout to prevent multiple window refreshes.
        pnlFlow.SuspendLayout()

        ' Clear the current display.
        For Each ctrl As Control In pnlFlow.Controls
            ctrl.Dispose()
        Next
        pnlFlow.Controls.Clear()

        ' row and col will track the current position where pictures are
        ' being inserted. They begin at the top-left corner.
        Dim row As Integer = Border
        Dim col As Integer = Border

        ' Iterate through the images collection, and create PictureBox controls.
        For Each image As NamedImage In images
            Dim pic As New PictureBox()
            pic.Image = image.Image
            pic.Tag = image.FileName
            pic.Size = New Size(Dimension, Dimension)
            pic.Margin = New Padding(Spacing)
            pic.BorderStyle = BorderStyle.FixedSingle

            ' Display the picture.
            pnlFlow.Controls.Add(pic)

            ' Handle the event.
            AddHandler pic.Click, AddressOf Me.pic_Click
        Next

        pnlFlow.ResumeLayout()
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

    Public Sub StartLoadingImages(ByVal directory As String)
        _directory = directory
        GetImages()
    End Sub

    Private Sub GetImages()
        ' Create a delegate that points to the method
        ' that you want to run asynchronously.
        ' The MethodInvoker delegate works because it
        ' matches the signature (no parameters or return value).
        Dim asyncTask As New MethodInvoker(AddressOf Me.ReadImagesFromFile)

        ' Borrow a thread from the CLR.
        asyncTask.BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub ReadImagesFromFile()

        SyncLock images
            images.Clear()
            If directory <> "" Then
                Dim thumbnail As Image
                Dim dir As New DirectoryInfo(directory)

                For Each file As FileInfo In dir.GetFiles("*.bmp")
                    thumbnail = Bitmap.FromFile(file.Name).GetThumbnailImage( _
                      Dimension, Dimension, Nothing, IntPtr.Zero)
                    images.Add(New NamedImage(thumbnail, file.Name))
                Next
            End If
        End SyncLock

        ' Update the display on the UI thread.
        pnlFlow.Invoke(New MethodInvoker(AddressOf UpdateDisplay))
    End Sub

End Class
