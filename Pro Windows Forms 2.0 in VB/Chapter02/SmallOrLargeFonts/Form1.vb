Imports Microsoft.Win32

Public Class Form1

    Public Sub New()
        Me.Font = SystemFonts.IconTitleFont
        InitializeComponent()
        AddHandler SystemEvents.UserPreferenceChanged, _
          AddressOf SystemEvents_UserPreferenceChanged
    End Sub

    Private Sub SystemEvents_UserPreferenceChanged( _
      ByVal sender As Object, _
      ByVal e As UserPreferenceChangedEventArgs)

        If e.Category = UserPreferenceCategory.Window Then
            Me.Font = SystemFonts.IconTitleFont
        End If

    End Sub

    Private Sub Form1_Disposed(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles Me.Disposed
        RemoveHandler SystemEvents.UserPreferenceChanged, _
              AddressOf SystemEvents_UserPreferenceChanged
    End Sub
End Class
