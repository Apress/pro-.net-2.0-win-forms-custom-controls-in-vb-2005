Public Class Menu

    Private Sub button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click, button1.Click, button3.Click, button11.Click
        Dim ctrl As Control = CType(sender, Control)
        Dim Asm As System.Reflection.Assembly
        Asm = System.Reflection.Assembly.GetAssembly(GetType(Menu))
        Dim frm As Form = CType( _
          Asm.CreateInstance("ShapedForms." & ctrl.Text), Form)
        frm.ShowDialog()
    End Sub

End Class
