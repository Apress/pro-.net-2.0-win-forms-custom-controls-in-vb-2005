Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DocumentView
    Partial Public Class Parent : Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub
        Private lastDir As String = "C:\Temp"

        Private Sub cmdOpen(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton2.Click
            Dim dlgOpen As OpenFileDialog = New OpenFileDialog()
            dlgOpen.InitialDirectory = lastDir
            dlgOpen.Filter = "Order Files (*.ord)|*.ord"

            ' Show the open dialog.
            If dlgOpen.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim doc As Order = New Order()

                Try
                    doc.Open(dlgOpen.FileName)
                Catch err As Exception
                    ' All exceptions bubble up to this level.
                    MessageBox.Show(err.ToString())
                    Return
                End Try

                ' Create the child form for the selected file.
                Dim frmChild As Child = New Child(doc, Child.ViewType.ItemGrid)
                frmChild.MdiParent = Me
                frmChild.Show()
            End If
        End Sub

        Private Sub cmdNew(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton1.Click
            ' Create a new order.
            Dim doc As Order = New Order()
            Dim frmChild As Child = New Child(doc, Child.ViewType.ItemGrid)
            frmChild.MdiParent = Me
            frmChild.Show()
        End Sub

        Private Sub cmdSave(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton4.Click
            ' Save the current order.
            If Not ActiveMdiChild Is Nothing Then
                Dim dlgSave As SaveFileDialog = New SaveFileDialog()
                Dim doc As Order = (CType(ActiveMdiChild, Child)).Document
                dlgSave.FileName = doc.LastFileName
                dlgSave.Filter = "Order Files (*.ord)|*.ord"

                If dlgSave.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Try
                        doc.Save(dlgSave.FileName)
                        ActiveMdiChild.Text = dlgSave.FileName
                    Catch err As Exception
                        ' All exceptions bubble up to this level.
                        MessageBox.Show(err.ToString())
                        Return
                    End Try
                End If
            End If
        End Sub

        Private Sub cmdClose(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton3.Click
            If Not ActiveMdiChild Is Nothing Then
                ActiveMdiChild.Close()
            End If
        End Sub

        Private Sub cmdPreview(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton5.Click
            ' Launch a print preview child for the active order.
            If Not ActiveMdiChild Is Nothing Then
                Dim doc As Order = (CType(ActiveMdiChild, Child)).Document

                Dim frmChild As Child = New Child(doc, Child.ViewType.PrintPreview)
                frmChild.MdiParent = Me
                frmChild.Show()
            End If
        End Sub

        Private Sub Parent_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            toolStrip1.Items(0).Image = imgButtons.Images(0)
            toolStrip1.Items(1).Image = imgButtons.Images(1)
            toolStrip1.Items(2).Image = imgButtons.Images(2)
            toolStrip1.Items(3).Image = imgButtons.Images(3)
            toolStrip1.Items(5).Image = imgButtons.Images(4)

        End Sub

    End Class
End Namespace