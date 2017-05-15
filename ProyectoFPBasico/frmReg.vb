Imports System.IO

Public Class frmReg
    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        Dim usuarios As New List(Of String)
        Dim reader As New StreamReader("Usuarios.txt")
        Do
            usuarios.Add(reader.ReadLine().Split(",")(0))
        Loop Until reader.EndOfStream
        reader.Close()
        Dim writer As New StreamWriter("Usuarios.txt", True)
        If txtUsuario.Text = "" OrElse txtContraseña.Text = "" Then
            MessageBox.Show("Tienes que rellenar el usuario y contraseña.")
            Exit Sub
        ElseIf usuarios.Contains(txtUsuario.Text) Then
            MessageBox.Show("El usuario ya existe.")
            Exit Sub
        End If
        writer.Write(ControlChars.CrLf & txtUsuario.Text & "," & txtContraseña.Text)
        writer.Close()
        MessageBox.Show("La cuenta ha sido creada.")
    End Sub
End Class