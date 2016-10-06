Public Class ControlPaintTest

    Private Sub ControlPaintTest_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        ControlPaint.DrawCheckBox(e.Graphics, New Rectangle(10, 10, 50, 50), ButtonState.Checked)
        ControlPaint.DrawCheckBox(e.Graphics, New Rectangle(70, 10, 30, 30), ButtonState.Normal)
        ControlPaint.DrawCheckBox(e.Graphics, New Rectangle(110, 10, 20, 20), ButtonState.Checked)

        ControlPaint.DrawButton(e.Graphics, New Rectangle(10, 80, 20, 20), ButtonState.Checked)
        ControlPaint.DrawButton(e.Graphics, New Rectangle(50, 80, 20, 20), ButtonState.Flat)
        ControlPaint.DrawButton(e.Graphics, New Rectangle(90, 80, 20, 20), ButtonState.Normal)
        ControlPaint.DrawFocusRectangle(e.Graphics, New Rectangle(130, 80, 20, 20))

        ControlPaint.DrawGrid(e.Graphics, New Rectangle(10, 120, 250, 50), New Size(5, 5), Color.Blue)
        ControlPaint.DrawScrollButton(e.Graphics, New Rectangle(10, 180, 20, 20), ScrollButton.Left, ButtonState.Normal)
        ControlPaint.DrawScrollButton(e.Graphics, New Rectangle(50, 180, 20, 20), ScrollButton.Max, ButtonState.Pushed)
        ControlPaint.DrawScrollButton(e.Graphics, New Rectangle(90, 180, 20, 20), ScrollButton.Up, ButtonState.Normal)

        ControlPaint.DrawMenuGlyph(e.Graphics, New Rectangle(10, 220, 20, 20), MenuGlyph.Arrow)
        ControlPaint.DrawMenuGlyph(e.Graphics, New Rectangle(50, 220, 20, 20), MenuGlyph.Checkmark)
        ControlPaint.DrawMenuGlyph(e.Graphics, New Rectangle(90, 220, 20, 20), MenuGlyph.Max)

    End Sub
End Class