Imports System.Drawing.Drawing2D

Public Class Form1

    Private Sub chkShowBufferedPanel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowBufferedPanel.CheckedChanged
        BufferedPanel1.Visible = chkShowBufferedPanel.Checked
    End Sub

    Private Sub chkShowPanel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowPanel.CheckedChanged
        panel1.Visible = chkShowPanel.Checked
    End Sub

    Private Sub chkShowManualBufferedPanel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowManualBufferedPanel.CheckedChanged
        panel2.Visible = chkShowManualBufferedPanel.Checked
    End Sub

    Private Sub logo_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panel2.Paint, panel1.Paint, BufferedPanel1.Paint
        Const RINGCOUNT As Integer = 100
        Const SWEEP As Single = 2
        Const INTERVAL As Single = 5
        Const INCREMENTS As Integer = 72 ' usually 360/INTERVAL

        Dim ctrl As Control = CType(sender, Control)
        ' intentionally slow painting algorith here

        ' Decide whether or not to use manual double-buffering.
        Dim g As Graphics
        Dim bitmap As Bitmap = Nothing
        If sender Is panel2 Then
            ' Use double buffering. 
            bitmap = New Bitmap(ctrl.ClientRectangle.Width, ctrl.ClientRectangle.Height)
            g = Graphics.FromImage(bitmap)
        Else
            ' Don't use double buffering.
            g = e.Graphics
        End If

        g.SmoothingMode = SmoothingMode.AntiAlias
        Dim paintRect As New Rectangle(ctrl.Width / 2, ctrl.Height / 2, 0, 0)
        Dim borderRect As Rectangle = ctrl.ClientRectangle

        borderRect.Size = New Size(borderRect.Width - 1, borderRect.Height - 1)
        g.DrawRectangle(Pens.Yellow, borderRect)
        Dim hScale As Single = Me.Width / (RINGCOUNT * 2)
        Dim vScale As Integer = Me.Height / (RINGCOUNT * 2)

        For i As Integer = 0 To RINGCOUNT
            paintRect.Inflate(hScale, vScale)

            For j As Integer = 0 To INCREMENTS
                g.DrawArc(Pens.Yellow, paintRect, j * INTERVAL, SWEEP)
            Next
        Next

        ' If using double buffering, render the final image and dispose of it.
        If sender Is panel2 Then
            e.Graphics.DrawImageUnscaled(bitmap, 0, 0)
            g.Dispose()
            bitmap.Dispose()
        End If
    End Sub
End Class
