<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BindToImage
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
        Me.lblStatus = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.picProduct = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboModelName = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.picProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblStatus.Location = New System.Drawing.Point(0, 254)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Padding = New System.Windows.Forms.Padding(3)
        Me.lblStatus.Size = New System.Drawing.Size(379, 21)
        Me.lblStatus.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.picProduct)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(191, 148)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Display Value for ProductImage"
        '
        'picProduct
        '
        Me.picProduct.Location = New System.Drawing.Point(16, 24)
        Me.picProduct.Name = "picProduct"
        Me.picProduct.Size = New System.Drawing.Size(128, 88)
        Me.picProduct.TabIndex = 18
        Me.picProduct.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Product:"
        '
        'cboModelName
        '
        Me.cboModelName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModelName.FormattingEnabled = True
        Me.cboModelName.Location = New System.Drawing.Point(84, 11)
        Me.cboModelName.Name = "cboModelName"
        Me.cboModelName.Size = New System.Drawing.Size(248, 21)
        Me.cboModelName.TabIndex = 28
        '
        'BindToImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 275)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboModelName)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "BindToImage"
        Me.Text = "BindToImage"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.picProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents lblStatus As System.Windows.Forms.Label
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents picProduct As System.Windows.Forms.PictureBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents cboModelName As System.Windows.Forms.ComboBox
End Class
