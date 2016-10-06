Imports Microsoft.VisualBasic
Imports System


Partial Public Class ModularPortal
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (Not components Is Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.collapsiblePanel1 = New CollabsiblePanelControl.CollapsiblePanel()
        Me.collapsiblePanel3 = New CollabsiblePanelControl.CollapsiblePanel()
        Me.collapsiblePanel4 = New CollabsiblePanelControl.CollapsiblePanel()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstModules = New System.Windows.Forms.CheckedListBox()
        Me.webBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.collapsiblePanel2 = New CollabsiblePanelControl.CollapsiblePanel()
        Me.webBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.checkBox2 = New System.Windows.Forms.CheckBox()
        Me.checkBox3 = New System.Windows.Forms.CheckBox()
        Me.checkBox4 = New System.Windows.Forms.CheckBox()
        Me.checkBox5 = New System.Windows.Forms.CheckBox()
        Me.checkBox6 = New System.Windows.Forms.CheckBox()
        Me.checkBox7 = New System.Windows.Forms.CheckBox()
        Me.checkBox8 = New System.Windows.Forms.CheckBox()
        Me.checkBox9 = New System.Windows.Forms.CheckBox()
        Me.checkBox10 = New System.Windows.Forms.CheckBox()
        Me.checkBox11 = New System.Windows.Forms.CheckBox()
        Me.checkBox12 = New System.Windows.Forms.CheckBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.flowLayoutPanel1.SuspendLayout()
        Me.collapsiblePanel1.SuspendLayout()
        Me.collapsiblePanel3.SuspendLayout()
        Me.collapsiblePanel4.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.collapsiblePanel2.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' flowLayoutPanel1
        ' 
        Me.flowLayoutPanel1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.flowLayoutPanel1.AutoScroll = True
        Me.flowLayoutPanel1.Controls.Add(Me.collapsiblePanel4)
        Me.flowLayoutPanel1.Controls.Add(Me.collapsiblePanel1)
        Me.flowLayoutPanel1.Controls.Add(Me.collapsiblePanel3)
        Me.flowLayoutPanel1.Controls.Add(Me.collapsiblePanel2)
        Me.flowLayoutPanel1.Location = New System.Drawing.Point(7, 91)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Size = New System.Drawing.Size(667, 463)
        Me.flowLayoutPanel1.TabIndex = 0
        ' 
        ' collapsiblePanel1
        ' 
        Me.collapsiblePanel1.Collapsed = False
        Me.collapsiblePanel1.Controls.Add(Me.panel1)
        Me.collapsiblePanel1.Location = New System.Drawing.Point(321, 3)
        Me.collapsiblePanel1.Name = "collapsiblePanel1"
        Me.collapsiblePanel1.Size = New System.Drawing.Size(311, 239)
        Me.collapsiblePanel1.TabIndex = 0
        Me.collapsiblePanel1.Text = "PreferencePanel"
        ' 
        ' collapsiblePanel3
        ' 
        Me.collapsiblePanel3.Collapsed = False
        Me.collapsiblePanel3.Controls.Add(Me.panel2)
        Me.collapsiblePanel3.Location = New System.Drawing.Point(3, 251)
        Me.collapsiblePanel3.Name = "collapsiblePanel3"
        Me.collapsiblePanel3.Size = New System.Drawing.Size(200, 242)
        Me.collapsiblePanel3.TabIndex = 3
        Me.collapsiblePanel3.Text = "InfoPanel"
        ' 
        ' collapsiblePanel4
        ' 
        Me.collapsiblePanel4.Collapsed = False
        Me.collapsiblePanel4.Controls.Add(Me.webBrowser1)
        Me.collapsiblePanel4.Location = New System.Drawing.Point(3, 3)
        Me.collapsiblePanel4.Name = "collapsiblePanel4"
        Me.collapsiblePanel4.Size = New System.Drawing.Size(312, 242)
        Me.collapsiblePanel4.TabIndex = 4
        Me.collapsiblePanel4.Text = "WebPanel"
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.groupBox1.Controls.Add(Me.lstModules)
        Me.groupBox1.Location = New System.Drawing.Point(7, 5)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(404, 80)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Loaded Modules"
        ' 
        ' lstModules
        ' 
        Me.lstModules.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.lstModules.FormattingEnabled = True
        Me.lstModules.Location = New System.Drawing.Point(12, 19)
        Me.lstModules.MultiColumn = True
        Me.lstModules.Name = "lstModules"
        Me.lstModules.Size = New System.Drawing.Size(378, 52)
        Me.lstModules.TabIndex = 0
        '            Me.lstModules.ItemCheck += New System.Windows.Forms.ItemCheckEventHandler(Me.lstModules_ItemCheck);
        ' 
        ' webBrowser1
        ' 
        Me.webBrowser1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.webBrowser1.Location = New System.Drawing.Point(3, 27)
        Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webBrowser1.Name = "webBrowser1"
        Me.webBrowser1.Size = New System.Drawing.Size(305, 212)
        Me.webBrowser1.TabIndex = 1
        Me.webBrowser1.Url = New System.Uri("http://www.google.ca", System.UriKind.Absolute)
        ' 
        ' collapsiblePanel2
        ' 
        Me.collapsiblePanel2.Collapsed = False
        Me.collapsiblePanel2.Controls.Add(Me.webBrowser2)
        Me.collapsiblePanel2.Location = New System.Drawing.Point(209, 251)
        Me.collapsiblePanel2.Name = "collapsiblePanel2"
        Me.collapsiblePanel2.Size = New System.Drawing.Size(423, 242)
        Me.collapsiblePanel2.TabIndex = 5
        Me.collapsiblePanel2.Text = "HelpPanel"
        ' 
        ' webBrowser2
        ' 
        Me.webBrowser2.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.webBrowser2.Location = New System.Drawing.Point(3, 27)
        Me.webBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webBrowser2.Name = "webBrowser2"
        Me.webBrowser2.Size = New System.Drawing.Size(416, 212)
        Me.webBrowser2.TabIndex = 1
        Me.webBrowser2.Url = New System.Uri("http://msdn.microsoft.com", System.UriKind.Absolute)
        ' 
        ' panel1
        ' 
        Me.panel1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.panel1.BackColor = System.Drawing.Color.White
        Me.panel1.Controls.Add(Me.checkBox7)
        Me.panel1.Controls.Add(Me.checkBox8)
        Me.panel1.Controls.Add(Me.checkBox9)
        Me.panel1.Controls.Add(Me.checkBox10)
        Me.panel1.Controls.Add(Me.checkBox11)
        Me.panel1.Controls.Add(Me.checkBox12)
        Me.panel1.Controls.Add(Me.checkBox6)
        Me.panel1.Controls.Add(Me.checkBox5)
        Me.panel1.Controls.Add(Me.checkBox4)
        Me.panel1.Controls.Add(Me.checkBox3)
        Me.panel1.Controls.Add(Me.checkBox2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Location = New System.Drawing.Point(8, 29)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(293, 206)
        Me.panel1.TabIndex = 1
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.AutoSize = True
        Me.checkBox1.Location = New System.Drawing.Point(19, 17)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(77, 17)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "checkBox1"
        Me.checkBox1.UseVisualStyleBackColor = True
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.AutoSize = True
        Me.checkBox2.Location = New System.Drawing.Point(19, 40)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(77, 17)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "checkBox2"
        Me.checkBox2.UseVisualStyleBackColor = True
        ' 
        ' checkBox3
        ' 
        Me.checkBox3.AutoSize = True
        Me.checkBox3.Location = New System.Drawing.Point(19, 63)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(77, 17)
        Me.checkBox3.TabIndex = 2
        Me.checkBox3.Text = "checkBox3"
        Me.checkBox3.UseVisualStyleBackColor = True
        ' 
        ' checkBox4
        ' 
        Me.checkBox4.AutoSize = True
        Me.checkBox4.Location = New System.Drawing.Point(19, 86)
        Me.checkBox4.Name = "checkBox4"
        Me.checkBox4.Size = New System.Drawing.Size(77, 17)
        Me.checkBox4.TabIndex = 3
        Me.checkBox4.Text = "checkBox4"
        Me.checkBox4.UseVisualStyleBackColor = True
        ' 
        ' checkBox5
        ' 
        Me.checkBox5.AutoSize = True
        Me.checkBox5.Location = New System.Drawing.Point(19, 109)
        Me.checkBox5.Name = "checkBox5"
        Me.checkBox5.Size = New System.Drawing.Size(77, 17)
        Me.checkBox5.TabIndex = 4
        Me.checkBox5.Text = "checkBox5"
        Me.checkBox5.UseVisualStyleBackColor = True
        ' 
        ' checkBox6
        ' 
        Me.checkBox6.AutoSize = True
        Me.checkBox6.Location = New System.Drawing.Point(19, 132)
        Me.checkBox6.Name = "checkBox6"
        Me.checkBox6.Size = New System.Drawing.Size(77, 17)
        Me.checkBox6.TabIndex = 5
        Me.checkBox6.Text = "checkBox6"
        Me.checkBox6.UseVisualStyleBackColor = True
        ' 
        ' checkBox7
        ' 
        Me.checkBox7.AutoSize = True
        Me.checkBox7.Location = New System.Drawing.Point(124, 132)
        Me.checkBox7.Name = "checkBox7"
        Me.checkBox7.Size = New System.Drawing.Size(77, 17)
        Me.checkBox7.TabIndex = 11
        Me.checkBox7.Text = "checkBox7"
        Me.checkBox7.UseVisualStyleBackColor = True
        ' 
        ' checkBox8
        ' 
        Me.checkBox8.AutoSize = True
        Me.checkBox8.Location = New System.Drawing.Point(124, 109)
        Me.checkBox8.Name = "checkBox8"
        Me.checkBox8.Size = New System.Drawing.Size(77, 17)
        Me.checkBox8.TabIndex = 10
        Me.checkBox8.Text = "checkBox8"
        Me.checkBox8.UseVisualStyleBackColor = True
        ' 
        ' checkBox9
        ' 
        Me.checkBox9.AutoSize = True
        Me.checkBox9.Location = New System.Drawing.Point(124, 86)
        Me.checkBox9.Name = "checkBox9"
        Me.checkBox9.Size = New System.Drawing.Size(77, 17)
        Me.checkBox9.TabIndex = 9
        Me.checkBox9.Text = "checkBox9"
        Me.checkBox9.UseVisualStyleBackColor = True
        ' 
        ' checkBox10
        ' 
        Me.checkBox10.AutoSize = True
        Me.checkBox10.Location = New System.Drawing.Point(124, 63)
        Me.checkBox10.Name = "checkBox10"
        Me.checkBox10.Size = New System.Drawing.Size(83, 17)
        Me.checkBox10.TabIndex = 8
        Me.checkBox10.Text = "checkBox10"
        Me.checkBox10.UseVisualStyleBackColor = True
        ' 
        ' checkBox11
        ' 
        Me.checkBox11.AutoSize = True
        Me.checkBox11.Location = New System.Drawing.Point(124, 40)
        Me.checkBox11.Name = "checkBox11"
        Me.checkBox11.Size = New System.Drawing.Size(83, 17)
        Me.checkBox11.TabIndex = 7
        Me.checkBox11.Text = "checkBox11"
        Me.checkBox11.UseVisualStyleBackColor = True
        ' 
        ' checkBox12
        ' 
        Me.checkBox12.AutoSize = True
        Me.checkBox12.Location = New System.Drawing.Point(124, 17)
        Me.checkBox12.Name = "checkBox12"
        Me.checkBox12.Size = New System.Drawing.Size(83, 17)
        Me.checkBox12.TabIndex = 6
        Me.checkBox12.Text = "checkBox12"
        Me.checkBox12.UseVisualStyleBackColor = True
        ' 
        ' panel2
        ' 
        Me.panel2.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.panel2.BackColor = System.Drawing.Color.White
        Me.panel2.Controls.Add(Me.label1)
        Me.panel2.Location = New System.Drawing.Point(5, 31)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(188, 201)
        Me.panel2.TabIndex = 2
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(17, 20)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(132, 133)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Lorum ipsum dolorum. Lorum ipsum dolorum. Lorum ipsum dolorum. Lorum ipsum doloru" & "m."
        ' 
        ' ModularPortal
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(674, 554)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.flowLayoutPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.Name = "ModularPortal"
        Me.Text = "ModularPortal"
        '            Me.Load += New System.EventHandler(Me.ModularPortal_Load);
        Me.flowLayoutPanel1.ResumeLayout(False)
        Me.collapsiblePanel1.ResumeLayout(False)
        Me.collapsiblePanel3.ResumeLayout(False)
        Me.collapsiblePanel4.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.collapsiblePanel2.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private flowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Private collapsiblePanel1 As CollabsiblePanelControl.CollapsiblePanel
    Private collapsiblePanel3 As CollabsiblePanelControl.CollapsiblePanel
    Private collapsiblePanel4 As CollabsiblePanelControl.CollapsiblePanel
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents lstModules As System.Windows.Forms.CheckedListBox
    Private webBrowser1 As System.Windows.Forms.WebBrowser
    Private collapsiblePanel2 As CollabsiblePanelControl.CollapsiblePanel
    Private webBrowser2 As System.Windows.Forms.WebBrowser
    Private panel1 As System.Windows.Forms.Panel
    Private checkBox7 As System.Windows.Forms.CheckBox
    Private checkBox8 As System.Windows.Forms.CheckBox
    Private checkBox9 As System.Windows.Forms.CheckBox
    Private checkBox10 As System.Windows.Forms.CheckBox
    Private checkBox11 As System.Windows.Forms.CheckBox
    Private checkBox12 As System.Windows.Forms.CheckBox
    Private checkBox6 As System.Windows.Forms.CheckBox
    Private checkBox5 As System.Windows.Forms.CheckBox
    Private checkBox4 As System.Windows.Forms.CheckBox
    Private checkBox3 As System.Windows.Forms.CheckBox
    Private checkBox2 As System.Windows.Forms.CheckBox
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private panel2 As System.Windows.Forms.Panel
    Private label1 As System.Windows.Forms.Label
End Class
