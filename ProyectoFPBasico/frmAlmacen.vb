Imports System.IO

Public Class frmAlmacen
    Private Sub frmAlmacen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        activarBotonesJuego(True)
    End Sub

    Private Sub frmAlmacen_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmAlmacen_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        Me.DoubleBuffered = True
    End Sub
End Class