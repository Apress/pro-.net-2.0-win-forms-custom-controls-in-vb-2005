Public Class SelectDrive

    ' Store the selected drive.
    Private _driveSelection As Char
    Public Property DriveSelection() As Char
        Get
            Return _driveSelection
        End Get
        Set(ByVal value As Char)
            _driveSelection = value

            ' Select the current drive.
            lstDrives.SelectedIndex = lstDrives.FindString( _
              DriveSelection.ToString())
        End Set
    End Property

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim drives() As String = System.IO.Directory.GetLogicalDrives()
        lstDrives.DataSource = drives
    End Sub
    

    Private Sub lstDrives_SelectedIndexChanged(ByVal sender As Object, _
     ByVal e As EventArgs) Handles lstDrives.SelectedIndexChanged
        DriveSelection = lstDrives.Text(0)
    End Sub

    ' Allow quick select-and-close.
    Private Sub lstDrives_DoubleClick(ByVal sender As Object, _
     ByVal e As EventArgs) Handles lstDrives.DoubleClick
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class