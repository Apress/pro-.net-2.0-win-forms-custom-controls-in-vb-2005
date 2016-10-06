Public Class AdvancedCursors

    Private Declare Function LoadCursorFromFile Lib "User32.dll" Alias "LoadCursorFromFileA" ( _
      ByVal str As String) As IntPtr

    Public Shared Function Create(ByVal filename As String) As Cursor
        ' Get a handle to the cursor.
        Dim hCursor As IntPtr = LoadCursorFromFile(filename)

        ' Check if it succeeded.
        If Not IntPtr.Zero.Equals(hCursor) Then
            Return New Cursor(hCursor)
        Else
            Throw New ApplicationException( _
              "Could not create cursor from file " & filename)
        End If
    End Function

End Class
