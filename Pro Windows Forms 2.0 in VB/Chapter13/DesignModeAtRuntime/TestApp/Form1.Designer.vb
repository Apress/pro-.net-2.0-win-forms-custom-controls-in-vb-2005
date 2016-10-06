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
        Me.button3 = New System.Windows.Forms.Button
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.button1 = New System.Windows.Forms.Button
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.tabControl1 = New System.Windows.Forms.TabControl
        Me.tabPage1 = New System.Windows.Forms.TabPage
        Me.button2 = New System.Windows.Forms.Button
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.button4 = New System.Windows.Forms.Button
        Me.tabPage2 = New System.Windows.Forms.TabPage
        Me.dataGridView1 = New System.Windows.Forms.DataGridView
        Me.DesignModeDialog1 = New Microsoft.Samples.DesignModeDialog
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(18, 13)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(75, 23)
        Me.button3.TabIndex = 8
        Me.button3.Text = "button3"
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Location = New System.Drawing.Point(235, 37)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.numericUpDown1.TabIndex = 7
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(316, 67)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(160, 23)
        Me.button1.TabIndex = 4
        Me.button1.Text = "Click to go to design mode"
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(74, 55)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(121, 21)
        Me.comboBox1.TabIndex = 6
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Location = New System.Drawing.Point(80, 97)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(403, 260)
        Me.tabControl1.TabIndex = 5
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.button2)
        Me.tabPage1.Controls.Add(Me.groupBox1)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(395, 234)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "tabPage1"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(37, 178)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 1
        Me.button2.Text = "button2"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.button4)
        Me.groupBox1.Location = New System.Drawing.Point(71, 62)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(200, 100)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "groupBox1"
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(53, 20)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(75, 23)
        Me.button4.TabIndex = 0
        Me.button4.Text = "button4"
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.dataGridView1)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(395, 234)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "tabPage2"
        '
        'dataGridView1
        '
        Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(389, 228)
        Me.dataGridView1.TabIndex = 0
        '
        'DesignModeDialog1
        '
        Me.DesignModeDialog1.HostForm = Me
        Me.DesignModeDialog1.PropertiesToDesign.Add("Items")
        Me.DesignModeDialog1.PropertiesToDesign.Add("AutoSize")
        Me.DesignModeDialog1.PropertiesToDesign.Add("Size")
        Me.DesignModeDialog1.PropertiesToDesign.Add("Text")
        Me.DesignModeDialog1.PropertiesToDesign.Add("Font")
        Me.DesignModeDialog1.PropertiesToDesign.Add("Location")
        Me.DesignModeDialog1.PropertiesToDesign.Add("ForeColor")
        Me.DesignModeDialog1.PropertiesToDesign.Add("BackColor")
        Me.DesignModeDialog1.PropertiesToDesign.Add("Anchor")
        Me.DesignModeDialog1.PropertiesToDesign.Add("Dock")
        Me.DesignModeDialog1.PropertiesToDesign.Add("ClientSize")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 371)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.numericUpDown1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.tabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.tabPage2.ResumeLayout(False)
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tabPage1 As System.Windows.Forms.TabPage
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents button4 As System.Windows.Forms.Button
    Private WithEvents tabPage2 As System.Windows.Forms.TabPage
    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DesignModeDialog1 As Microsoft.Samples.DesignModeDialog

End Class
