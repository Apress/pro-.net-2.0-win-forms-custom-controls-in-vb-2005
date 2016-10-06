Imports System.ComponentModel

Public Class DriveCharConverter
    Inherits CharConverter

    ' Cache the collection of values so you don't need to re-create it each time.
    Private Shared svc As StandardValuesCollection

    ' Advertise that the standard values are available.
    Public Overrides Function GetStandardValuesSupported( _
      ByVal context As ITypeDescriptorContext) As Boolean
        Return True
    End Function

    ' Don't limit property values to the values in the list.
    Public Overrides Function GetStandardValuesExclusive( _
      ByVal context As ITypeDescriptorContext) As Boolean
        Return False
    End Function

    ' Provide the list of standard values.
    Public Overrides Function GetStandardValues( _
      ByVal context As ITypeDescriptorContext) As StandardValuesCollection
        If svc Is Nothing Then
            ' First, build the list of values using any ICollection.
            ' Make sure you use the right data type. In this case, Drive is a char,
            ' so all values must be chars.
            Dim drives As New List(Of Char)()

            ' Use exception-handling code here to prevent a file access error from
            ' crashing the IDE.
            Try
                For Each drive As String In System.IO.Directory.GetLogicalDrives()
                    drives.Add(drive(0))
                Next

                ' Now wrap the real values in the StandarValuesCollection object.
                svc = New TypeConverter.StandardValuesCollection(drives)
            Catch
            End Try
        End If

        Return svc
    End Function

End Class

