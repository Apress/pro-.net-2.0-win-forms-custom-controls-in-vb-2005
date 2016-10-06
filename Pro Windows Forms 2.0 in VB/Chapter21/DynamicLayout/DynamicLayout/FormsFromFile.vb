Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms


Partial Public Class FormsFromFile : Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FormsFromFile_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        openFileDialog.InitialDirectory = Application.StartupPath
    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdBrowse.Click
        If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtFileName.Text = openFileDialog.FileName
            Dim surveyReader As New SurveyDeserializer(openFileDialog.FileName, tableLayoutPanel1)
            tableLayoutPanel1.SuspendLayout()
            surveyReader.LoadForm()
            tableLayoutPanel1.ResumeLayout()
        End If
    End Sub


End Class
