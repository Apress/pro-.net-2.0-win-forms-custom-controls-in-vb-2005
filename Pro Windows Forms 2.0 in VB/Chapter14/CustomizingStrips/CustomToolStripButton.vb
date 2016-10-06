Imports System.Windows.Forms.Design

<ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip Or _
 ToolStripItemDesignerAvailability.StatusStrip)> _
 Public Class CustomToolStripButton
    Inherits ToolStripButton

    Protected Overrides Sub OnPaint(ByVal pe As PaintEventArgs)
        Parent.Renderer.DrawButtonBackground( _
          New ToolStripItemRenderEventArgs(pe.Graphics, Me))

        pe.Graphics.DrawEllipse(Pens.Blue, 0, 0, Me.Width, Me.Height)
        pe.Graphics.FillEllipse(Brushes.Yellow, 0, 0, Me.Width, Me.Height)
    End Sub


End Class
