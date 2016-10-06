Imports System.IO

Public Class BindToImage

    Private Sub BindToImage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DataTable = Program.StoreDB.GetProducts()
        cboModelName.DataSource = dt
        cboModelName.DisplayMember = "ModelName"

        Dim pictureBinding As New Binding("Image", dt, "ProductImage")
        AddHandler pictureBinding.Format, AddressOf FileToImage
        AddHandler pictureBinding.Parse, AddressOf ImageToFile
        picProduct.DataBindings.Add(pictureBinding)
    End Sub

    Private Sub FileToImage(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If e.DesiredType Is GetType(Image) Then
            ' Store the filename.
            picProduct.Tag = e.Value

            ' Look up the corresponding file, and create an Image object.
            Try
                lblStatus.Text = "Retrieved picture " & e.Value
                e.Value = Image.FromFile( _
                  Path.Combine(Application.StartupPath, e.Value))

            Catch err As System.IO.FileNotFoundException
                lblStatus.Text = "Could not find picture " & e.Value

                ' You could return an error picture here.
                ' This code uses a blank 1x1 pixel image.
                e.Value = New Bitmap(1, 1)

            Catch err As OutOfMemoryException
                lblStatus.Text = "Picture " & e.Value & "has an unsupported format."
                e.Value = New Bitmap(1, 1)
            End Try
        End If
    End Sub

    Private Sub ImageToFile(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If e.DesiredType Is GetType(String) Then
            ' Substitute the filename.
            e.Value = picProduct.Tag
        End If
    End Sub

End Class