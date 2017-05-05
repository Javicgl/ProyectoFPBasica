Imports System.IO
Imports BibliotecaProyecto
Public Class Juego
    Private Sub btnVerAlmacen_Click(sender As Object, e As EventArgs) Handles btnVerAlmacen.Click
        Dim frmalm As New frmAlmacen
        frmalm.Show()
        Dim listaComprobacion As New List(Of Producto)
        Dim numerosComprobacion As New List(Of Integer)
        For i = 0 To nuevoAlmacen.productos.Count() - 1
            If Not listaComprobacion.Contains(nuevoAlmacen.productos(i)) Then
                listaComprobacion.Add(nuevoAlmacen.productos(i))
                numerosComprobacion.Add(1)
            Else
                numerosComprobacion(listaComprobacion.IndexOf(nuevoAlmacen.productos(i))) += 1
            End If
        Next

        For i = 0 To listaComprobacion.Count() - 1
            Dim newLabel As New Label
            newLabel.Text = listaComprobacion(i).Nombre
            Me.Controls.Add(newLabel)

            Dim newLabel2 As New Label
            newLabel2.Text = numerosComprobacion(i)
            Me.Controls.Add(newLabel2)
        Next
    End Sub

    Private Sub Juego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reader As New StreamReader("Pedidos.txt")
        Dim rnd As New Random
        reader.ReadLine()
        Dim lineaCompleta As String = reader.ReadLine()
        Dim aleatorio As Integer = rnd.Next(1, lineaCompleta.Length) 'Revisar, no coge el ultimo pedido
        Dim nom As New List(Of String)
        Dim cant As New List(Of Integer)
        'Encuentro el pedido
        Do
            lineaCompleta = reader.ReadLine()
        Loop Until lineaCompleta = aleatorio & "@"
        'Leo los datos del pedido
        Do
            lineaCompleta = reader.ReadLine()
            If Not lineaCompleta.Contains("@") Then
                nom.Add(lineaCompleta.Split(",")(0))
                cant.Add(lineaCompleta.Split(",")(1))
            End If
        Loop Until lineaCompleta.Contains("@")
        'Imprimo los datos
        Dim lbl As New Label
        For i = 0 To nom.Count - 1
            lblPedido.Text += nom(i) & " -- " & cant(i) & ControlChars.CrLf
        Next
    End Sub
End Class