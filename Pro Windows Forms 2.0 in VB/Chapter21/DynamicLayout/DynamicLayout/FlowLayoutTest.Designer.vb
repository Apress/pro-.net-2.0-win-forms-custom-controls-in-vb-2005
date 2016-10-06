Imports Microsoft.VisualBasic
Imports System

Partial Public Class FlowLayoutTest
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
        Me.chkWrap = New System.Windows.Forms.CheckBox()
        Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.button9 = New System.Windows.Forms.Button()
        Me.button10 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lstFlowDirection = New System.Windows.Forms.ComboBox()
        Me.chkAutoScroll = New System.Windows.Forms.CheckBox()
        Me.flowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' chkWrap
        ' 
        Me.chkWrap.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
        Me.chkWrap.AutoSize = True
        Me.chkWrap.Location = New System.Drawing.Point(12, 193)
        Me.chkWrap.Name = "chkWrap"
        Me.chkWrap.Size = New System.Drawing.Size(155, 17)
        Me.chkWrap.TabIndex = 3
        Me.chkWrap.Text = "Wrap the FlowLayoutPanel"
        '            Me.chkWrap.CheckedChanged += New System.EventHandler(Me.chkWrap_CheckedChanged);
        ' 
        ' flowLayoutPanel1
        ' 
        Me.flowLayoutPanel1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flowLayoutPanel1.Controls.Add(Me.button1)
        Me.flowLayoutPanel1.Controls.Add(Me.button2)
        Me.flowLayoutPanel1.Controls.Add(Me.button3)
        Me.flowLayoutPanel1.Controls.Add(Me.button4)
        Me.flowLayoutPanel1.Controls.Add(Me.button5)
        Me.flowLayoutPanel1.Controls.Add(Me.button6)
        Me.flowLayoutPanel1.Controls.Add(Me.button7)
        Me.flowLayoutPanel1.Controls.Add(Me.button8)
        Me.flowLayoutPanel1.Controls.Add(Me.button9)
        Me.flowLayoutPanel1.Controls.Add(Me.button10)
        Me.flowLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Size = New System.Drawing.Size(317, 142)
        Me.flowLayoutPanel1.TabIndex = 2
        Me.flowLayoutPanel1.WrapContents = False
        ' 
        ' button1
        ' 
        Me.button1.Location = New System.Drawing.Point(3, 3)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 43)
        Me.button1.TabIndex = 0
        Me.button1.Text = "button1"
        Me.button1.UseVisualStyleBackColor = True
        ' 
        ' button2
        ' 
        Me.button2.Location = New System.Drawing.Point(84, 3)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 43)
        Me.button2.TabIndex = 1
        Me.button2.Text = "button2"
        Me.button2.UseVisualStyleBackColor = True
        ' 
        ' button3
        ' 
        Me.button3.Location = New System.Drawing.Point(165, 3)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(75, 43)
        Me.button3.TabIndex = 2
        Me.button3.Text = "button3"
        Me.button3.UseVisualStyleBackColor = True
        ' 
        ' button4
        ' 
        Me.button4.Location = New System.Drawing.Point(246, 3)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(75, 43)
        Me.button4.TabIndex = 3
        Me.button4.Text = "button4"
        Me.button4.UseVisualStyleBackColor = True
        ' 
        ' button5
        ' 
        Me.button5.Location = New System.Drawing.Point(327, 3)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(75, 43)
        Me.button5.TabIndex = 4
        Me.button5.Text = "button5"
        Me.button5.UseVisualStyleBackColor = True
        ' 
        ' button6
        ' 
        Me.button6.Location = New System.Drawing.Point(408, 3)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(75, 43)
        Me.button6.TabIndex = 5
        Me.button6.Text = "button6"
        Me.button6.UseVisualStyleBackColor = True
        ' 
        ' button7
        ' 
        Me.button7.Location = New System.Drawing.Point(489, 3)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(75, 43)
        Me.button7.TabIndex = 6
        Me.button7.Text = "button7"
        Me.button7.UseVisualStyleBackColor = True
        ' 
        ' button8
        ' 
        Me.button8.Location = New System.Drawing.Point(570, 3)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(75, 43)
        Me.button8.TabIndex = 7
        Me.button8.Text = "button8"
        Me.button8.UseVisualStyleBackColor = True
        ' 
        ' button9
        ' 
        Me.button9.Location = New System.Drawing.Point(651, 3)
        Me.button9.Name = "button9"
        Me.button9.Size = New System.Drawing.Size(75, 43)
        Me.button9.TabIndex = 8
        Me.button9.Text = "button9"
        Me.button9.UseVisualStyleBackColor = True
        ' 
        ' button10
        ' 
        Me.button10.Location = New System.Drawing.Point(732, 3)
        Me.button10.Name = "button10"
        Me.button10.Size = New System.Drawing.Size(75, 43)
        Me.button10.TabIndex = 9
        Me.button10.Text = "button10"
        Me.button10.UseVisualStyleBackColor = True
        ' 
        ' label1
        ' 
        Me.label1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(9, 220)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(78, 13)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Flow Direction:"
        ' 
        ' lstFlowDirection
        ' 
        Me.lstFlowDirection.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
        Me.lstFlowDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstFlowDirection.FormattingEnabled = True
        Me.lstFlowDirection.Location = New System.Drawing.Point(92, 216)
        Me.lstFlowDirection.Name = "lstFlowDirection"
        Me.lstFlowDirection.Size = New System.Drawing.Size(121, 21)
        Me.lstFlowDirection.TabIndex = 5
        '            Me.lstFlowDirection.SelectedIndexChanged += New System.EventHandler(Me.lstFlowDirection_SelectedIndexChanged);
        ' 
        ' chkAutoScroll
        ' 
        Me.chkAutoScroll.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
        Me.chkAutoScroll.AutoSize = True
        Me.chkAutoScroll.Location = New System.Drawing.Point(12, 170)
        Me.chkAutoScroll.Name = "chkAutoScroll"
        Me.chkAutoScroll.Size = New System.Drawing.Size(177, 17)
        Me.chkAutoScroll.TabIndex = 6
        Me.chkAutoScroll.Text = "AutoScroll the FlowLayoutPanel"
        '            Me.chkAutoScroll.CheckedChanged += New System.EventHandler(Me.chkAutoScroll_CheckedChanged);
        ' 
        ' FlowLayoutTest
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 257)
        Me.Controls.Add(Me.chkAutoScroll)
        Me.Controls.Add(Me.lstFlowDirection)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.chkWrap)
        Me.Controls.Add(Me.flowLayoutPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.Name = "FlowLayoutTest"
        Me.Text = "FlowLayoutTest"
        '            Me.Load += New System.EventHandler(Me.FlowLayoutTest_Load);
        Me.flowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents chkWrap As System.Windows.Forms.CheckBox
    Private flowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Private label1 As System.Windows.Forms.Label
    Private WithEvents lstFlowDirection As System.Windows.Forms.ComboBox

    Private WithEvents chkAutoScroll As System.Windows.Forms.CheckBox
    Private button1 As System.Windows.Forms.Button
    Private button2 As System.Windows.Forms.Button
    Private button3 As System.Windows.Forms.Button
    Private button4 As System.Windows.Forms.Button
    Private button5 As System.Windows.Forms.Button
    Private button6 As System.Windows.Forms.Button
    Private button7 As System.Windows.Forms.Button
    Private button8 As System.Windows.Forms.Button
    Private button9 As System.Windows.Forms.Button
    Private button10 As System.Windows.Forms.Button

End Class
