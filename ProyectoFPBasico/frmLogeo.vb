Imports System.IO

Public Class frmLogeo

    Private Sub btnInicioSesion_Click(sender As Object, e As EventArgs) Handles btnInicioSesion.Click
        Dim condicionDebug As Boolean = False
        Try
            Dim reader As New StreamReader("Documentos\Usuarios.txt")
            If btnInicioSesion.Text = "Regístrate" Then
                Dim usuarios As New List(Of String)

                Do
                    usuarios.Add(reader.ReadLine().Split(",")(0))
                Loop Until reader.EndOfStream
                reader.Close()

                If txtUsuario.Text = "" OrElse txtContraseña.Text = "" Then
                    MessageBox.Show("Tienes que rellenar el usuario y contraseña.")
                    Exit Sub
                ElseIf usuarios.Contains(txtUsuario.Text) Then
                    MessageBox.Show("El usuario ya existe.")
                    Exit Sub
                End If

                Dim writer As New StreamWriter("Documentos\Usuarios.txt", True)

                writer.Write(ControlChars.CrLf & txtUsuario.Text & "," & txtContraseña.Text)
                writer.Close()
                MessageBox.Show("La cuenta ha sido creada.")
                Me.Close()

            Else
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
                ElseIf pedidosUsados.Count >= totalPedidos Then
                    MessageBox.Show("Ya has jugado con todos los pedidos.")
                    Application.Exit()
                ElseIf esUsuario Then
                    Me.Close()
                    juego.Show()
                Else
                    MessageBox.Show("El usuario o la contraseña se han introducido mal.")
                End If
            End If
        Catch ex As System.IO.IOException
            MessageBox.Show("No se ha encontrado el fichero Usuarios")
        End Try
    End Sub

    Private Sub frmLogeo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmInicio.btnCrear.Enabled = True
        frmInicio.btnJugar.Enabled = True
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub frmLogeo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
    End Sub

    'Private Sub frmLogeo_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
    '    If e.KeyCode = Keys.Escape Then
    '        Me.Close()
    '    End If
    'End Sub

    'Private Sub frmLogeo_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    Me.KeyPreview = True 'Considerar teclas por defecto para el formulario.
    'End Sub
End Class