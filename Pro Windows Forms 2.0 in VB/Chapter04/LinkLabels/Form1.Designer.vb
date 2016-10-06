<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lnkBuy = New System.Windows.Forms.LinkLabel
        Me.lnkWebSite = New System.Windows.Forms.LinkLabel
        Me.SuspendLayout()
        '
        'lnkBuy
        '
        Me.lnkBuy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkBuy.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.lnkBuy.Location = New System.Drawing.Point(50, 119)
        Me.lnkBuy.Name = "lnkBuy"
        Me.lnkBuy.Size = New System.Drawing.Size(244, 48)
        Me.lnkBuy.TabIndex = 9
        Me.lnkBuy.Text = "Buy it at Amazon.com or Barnes and Noble."
        '
        'lnkWebSite
        '
        Me.lnkWebSite.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkWebSite.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.lnkWebSite.Location = New System.Drawing.Point(50, 75)
        Me.lnkWebSite.Name = "lnkWebSite"
        Me.lnkWebSite.Size = New System.Drawing.Size(248, 36)
        Me.lnkWebSite.TabIndex = 8
        Me.lnkWebSite.Text = "See www.prosetech.com for more information."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 243)
        Me.Controls.Add(Me.lnkBuy)
        Me.Controls.Add(Me.lnkWebSite)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents lnkBuy As System.Windows.Forms.LinkLabel
    Private WithEvents lnkWebSite As System.Windows.Forms.LinkLabel

End Class
