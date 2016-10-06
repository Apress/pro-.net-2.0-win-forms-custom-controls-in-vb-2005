Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports Microsoft.Win32
Imports System.Runtime.InteropServices

Public Class FormPositionHelper

    Private Declare Function GetWindowPlacement Lib "User32.dll" ( _
     ByVal handle As IntPtr, <[In](), Out()> ByVal placement As ManagedWindowPlacement) _
     As Boolean

    Private Declare Function SetWindowPlacement Lib "User32.dll" ( _
      ByVal handle As IntPtr, ByVal placement As ManagedWindowPlacement) _
      As Boolean

    Public Shared RegPath As String = "Software\App\"


    Public Shared Sub SaveSize(ByVal frm As System.Windows.Forms.Form)
        Dim key As RegistryKey
        key = Registry.LocalMachine.CreateSubKey(RegPath & frm.Name)

        ' Get the window placement.
        Dim placement As New ManagedWindowPlacement()
        GetWindowPlacement(frm.Handle, placement)

        ' Serialize it.
        Dim ms As New MemoryStream()
        Dim f As New BinaryFormatter()
        f.Serialize(ms, placement)

        ' Store it as a byte array.
        key.SetValue("Placement", ms.ToArray())

    End Sub

    Public Shared Sub SetSize(ByVal frm As System.Windows.Forms.Form)
        Dim key As RegistryKey
        key = Registry.LocalMachine.OpenSubKey(RegPath & frm.Name)

        If key IsNot Nothing Then
            Dim ms As New MemoryStream( _
             CType(key.GetValue("Placement"), Byte()))

            Dim f As New BinaryFormatter()
            Dim placement As ManagedWindowPlacement
            placement = CType(f.Deserialize(ms), ManagedWindowPlacement)
            SetWindowPlacement(frm.Handle, placement)
        End If
    End Sub

    <Serializable(), StructLayout(LayoutKind.Sequential)> _
    Private Class ManagedPt

        Public X As Integer = 0
        Public Y As Integer = 0

        Public Sub New()
        End Sub
			
        Public Sub New(ByVal x As Integer, ByVal y As Integer)
            Me.X = x
            Me.Y = y
        End Sub
    End Class

    <Serializable(), StructLayout(LayoutKind.Sequential)> _
    Private Class ManagedRect

        Public X As Integer = 0
        Public Y As Integer = 0
        Public Right As Integer = 0
        Public Bottom As Integer = 0

        Public Sub New()
        End Sub

        Public Sub New(ByVal x As Integer, ByVal y As Integer, ByVal right As Integer, ByVal bottom As Integer)
            Me.X = x
            Me.Y = y
            Me.Right = right
            Me.Bottom = bottom
        End Sub
    End Class

    <Serializable(), StructLayout(LayoutKind.Sequential)> _
    Private Class ManagedWindowPlacement

        Public Length As UInteger = 0
        Public Flags As UInteger = 0
        Public ShowCmd As UInteger = 0
        Public MinPosition As ManagedPt
        Public MaxPosition As ManagedPt
        Public NormalPosition As ManagedRect

        Public Sub New()
            Length = CUInt(Marshal.SizeOf(Me))
        End Sub
    End Class

End Class