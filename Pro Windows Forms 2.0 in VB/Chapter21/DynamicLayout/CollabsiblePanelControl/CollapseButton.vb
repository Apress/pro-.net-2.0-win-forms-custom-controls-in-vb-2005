Imports System.Drawing.Drawing2D
Imports System.Drawing.Design
Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles


Public Class CollapseButton
    Inherits StateButtonBase

    ' Property fields
    Private _collapsed As Boolean


    Public Sub New()
        Me.SetStyle(ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
        Me.DoubleBuffered = True
    End Sub


    Public Property Collapsed() As Boolean
        Get
            Return _collapsed
        End Get
        Set(ByVal value As Boolean)
            If value <> _collapsed Then
                _collapsed = value
                Invalidate()
            End If
        End Set
    End Property

    Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim renderer As VisualStyleRenderer

        ' Paint parent background
        InvokePaintBackground(Me, New PaintEventArgs(e.Graphics, ClientRectangle))

        ' Paint background
        renderer = New VisualStyleRenderer(VisualStyleElement.ExplorerBar.NormalGroupHead.Normal)
        'renderer.DrawBackground(e.Graphics, new Rectangle(0, 0, e.ClipRectangle.Width, 25));
        renderer.DrawBackground(e.Graphics, ClientRectangle)

        ' Draw Text
        Dim fontRect As New Rectangle(17, 6, Me.Width - 17 - 24, Me.Height)

        If (State And StateButtonState.Pressed) <> 0 Then
            TextRenderer.DrawText(e.Graphics, Me.Text, Me.Font, fontRect, SystemColors.InactiveCaption, TextFormatFlags.Top Or TextFormatFlags.Left)
        Else
            If (State And StateButtonState.MouseHover) <> 0 Then
                TextRenderer.DrawText(e.Graphics, Me.Text, Me.Font, fontRect, SystemColors.InactiveCaption, TextFormatFlags.Top Or TextFormatFlags.Left)
            Else
                If Not Enabled Then
                    TextRenderer.DrawText(e.Graphics, Me.Text, Me.Font, fontRect, SystemColors.GrayText, TextFormatFlags.Top Or TextFormatFlags.Left)
                Else
                    TextRenderer.DrawText(e.Graphics, Me.Text, Me.Font, fontRect, SystemColors.MenuHighlight, TextFormatFlags.Top Or TextFormatFlags.Left)
                End If
            End If
        End If
        If Not Collapsed Then
            If (State And StateButtonState.Pressed) <> 0 Then
                renderer = New VisualStyleRenderer(VisualStyleElement.ExplorerBar.NormalGroupCollapse.Pressed)

                ' If hot
            Else
                If (State And StateButtonState.MouseHover) <> 0 Then
                    renderer = New VisualStyleRenderer(VisualStyleElement.ExplorerBar.NormalGroupCollapse.Hot)

                    ' If disabled
                Else
                    If Not Enabled Then
                        renderer = New VisualStyleRenderer(VisualStyleElement.ExplorerBar.NormalGroupCollapse.Normal)

                        ' If normal
                    Else
                        renderer = New VisualStyleRenderer(VisualStyleElement.ExplorerBar.NormalGroupCollapse.Normal)
                    End If
                End If
            End If
        Else
            ' If pressed
            If (State And StateButtonState.Pressed) <> 0 Then
                renderer = New VisualStyleRenderer(VisualStyleElement.ExplorerBar.NormalGroupExpand.Pressed)

                ' If hot
            Else
                If (State And StateButtonState.MouseHover) <> 0 Then
                    renderer = New VisualStyleRenderer(VisualStyleElement.ExplorerBar.NormalGroupExpand.Hot)

                    ' If disabled
                Else
                    If Not Enabled Then
                        renderer = New VisualStyleRenderer(VisualStyleElement.ExplorerBar.NormalGroupExpand.Normal)

                        ' If normal
                    Else
                        renderer = New VisualStyleRenderer(VisualStyleElement.ExplorerBar.NormalGroupExpand.Normal)
                    End If
                End If
            End If
        End If
        renderer.DrawBackground(e.Graphics, New Rectangle(Me.Width - 22, 3, 20, 20))

        MyBase.OnPaint(e)
    End Sub
End Class 