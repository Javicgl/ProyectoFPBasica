Imports System.IO

Public Class frmLogeo

    Private Sub btnInicioSesion_Click(sender As Object, e As EventArgs) Handles btnInicioSesion.Click

        Dim reader As New StreamReader("Usuarios.txt")
        Dim lineaCompleta As String
        Dim user As String
        Dim pass As String
        Dim esUsuario As Boolean = False
        Dim esAdmin As Boolean = False
        Dim contador As Integer = 0

        Do
            lineaCompleta = reader.ReadLine()
            user = lineaCompleta.Split(",")(0)
            pass = lineaCompleta.Split(",")(1)
            If txtUsuario.Text = user AndAlso txtContraseña.Text = pass Then
                esUsuario = True
                If contador = 0 Then
                    esAdmin = True
                End If
            End If
            contador += 1
        Loop Until esUsuario = True OrElse reader.EndOfStream
        reader.Close()

        If esAdmin Then
            'abrir la ventana de admin
        ElseIf esUsuario Then
            Dim juego As New frmJuego
            juego.Show()
        Else
            MessageBox.Show("El usuario no existe.")
        End If
    End Sub
End Class