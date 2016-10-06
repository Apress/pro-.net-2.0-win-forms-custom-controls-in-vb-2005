Public Class TransparencyKey

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.Close()
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        ' Allow the base class to handle all messages first.
        MyBase.WndProc(m)

        ' Look for the WM_NCHITTEST message.
        Dim WM_NCHITTEST As Integer = &H84
        If m.Msg = WM_NCHITTEST Then
            ' Treat this click as a click on the caption.
            Dim HTCLIENT As Integer = 1
            Dim HTCAPTION As Integer = 2
            If m.Result.ToInt32() = HTCLIENT Then
                m.Result = CType(HTCAPTION, IntPtr)
            End If
        End If
    End Sub

End Class