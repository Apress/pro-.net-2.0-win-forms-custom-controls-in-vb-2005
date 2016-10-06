Imports Microsoft.VisualBasic
Imports System
Namespace MultithreadingClient
    Friend Partial Class AsyncTest
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
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
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.lblTimeTaken = New System.Windows.Forms.Label()
            Me.txtResults = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.cmdFind = New System.Windows.Forms.Button()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtTo = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtFrom = New System.Windows.Forms.TextBox()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
' 
' GroupBox1
' 
            Me.GroupBox1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.GroupBox1.Controls.Add(Me.lblTimeTaken)
            Me.GroupBox1.Controls.Add(Me.txtResults)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.cmdFind)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.txtTo)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.txtFrom)
            Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox1.Location = New System.Drawing.Point(9, 11)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(487, 315)
            Me.GroupBox1.TabIndex = 1
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Find Prime Numbers"
' 
' lblTimeTaken
' 
            Me.lblTimeTaken.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.lblTimeTaken.Location = New System.Drawing.Point(80, 279)
            Me.lblTimeTaken.Name = "lblTimeTaken"
            Me.lblTimeTaken.Size = New System.Drawing.Size(395, 20)
            Me.lblTimeTaken.TabIndex = 8
' 
' txtResults
' 
            Me.txtResults.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.txtResults.Location = New System.Drawing.Point(80, 108)
            Me.txtResults.Multiline = True
            Me.txtResults.Name = "txtResults"
            Me.txtResults.ReadOnly = True
            Me.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtResults.Size = New System.Drawing.Size(395, 155)
            Me.txtResults.TabIndex = 7
' 
' Label4
' 
            Me.Label4.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
            Me.Label4.Location = New System.Drawing.Point(16, 279)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(72, 16)
            Me.Label4.TabIndex = 6
            Me.Label4.Text = "Time Taken:"
' 
' cmdFind
' 
            Me.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cmdFind.Location = New System.Drawing.Point(210, 53)
            Me.cmdFind.Name = "cmdFind"
            Me.cmdFind.Size = New System.Drawing.Size(112, 24)
            Me.cmdFind.TabIndex = 5
            Me.cmdFind.Text = "Find Primes"
'            Me.cmdFind.Click += New System.EventHandler(Me.cmdFind_Click);
' 
' Label3
' 
            Me.Label3.Location = New System.Drawing.Point(16, 60)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(52, 20)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "To:"
' 
' txtTo
' 
            Me.txtTo.Location = New System.Drawing.Point(80, 56)
            Me.txtTo.Name = "txtTo"
            Me.txtTo.TabIndex = 3
            Me.txtTo.Text = "500000"
' 
' Label2
' 
            Me.Label2.Location = New System.Drawing.Point(16, 32)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(52, 20)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "From:"
' 
' Label1
' 
            Me.Label1.Location = New System.Drawing.Point(16, 104)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(48, 16)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Results:"
' 
' txtFrom
' 
            Me.txtFrom.Location = New System.Drawing.Point(80, 28)
            Me.txtFrom.Name = "txtFrom"
            Me.txtFrom.TabIndex = 0
            Me.txtFrom.Text = "1"
' 
' AsyncTest
' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(508, 338)
            Me.Controls.Add(Me.GroupBox1)
            Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.MinimumSize = New System.Drawing.Size(354, 254)
            Me.Name = "AsyncTest"
            Me.Text = "Asynchronous Test"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Friend GroupBox1 As System.Windows.Forms.GroupBox
        Friend lblTimeTaken As System.Windows.Forms.Label
        Friend txtResults As System.Windows.Forms.TextBox
        Friend Label4 As System.Windows.Forms.Label
        Friend WithEvents cmdFind As System.Windows.Forms.Button
        Friend Label3 As System.Windows.Forms.Label
        Friend txtTo As System.Windows.Forms.TextBox
        Friend Label2 As System.Windows.Forms.Label
        Friend Label1 As System.Windows.Forms.Label
        Friend txtFrom As System.Windows.Forms.TextBox

    End Class
End Namespace

