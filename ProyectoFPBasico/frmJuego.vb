Imports System.IO
Imports BibliotecaProyecto
Public Class frmJuego
    Private Sub btnVerAlmacen_Click(sender As Object, e As EventArgs) Handles btnReservas.Click
        'Dim frmalm As New frmAlmacen
        'frmalm.Show()
        'Dim listaComprobacion As New List(Of Producto)
        'Dim numerosComprobacion As New List(Of Integer)
        'For i = 0 To nuevoAlmacen.productos.Count() - 1
        '    If Not listaComprobacion.Contains(nuevoAlmacen.productos(i)) Then
        '        listaComprobacion.Add(nuevoAlmacen.productos(i))
        '        numerosComprobacion.Add(1)
        '        'Dim btnDinamico As New Button
        '        'btnDinamico.Name = nuevoAlmacen.productos(i).Nombre
        '        'frmalm.Controls.Add(btnDinamico)
        '        ''FALTA LA POSICION DEL BOTÓN
        '        'Dim labelDinamico As New Label
        '        'labelDinamico.Text = nuevoAlmacen.productos(i).Nombre
        '        'frmalm.Controls.Add(labelDinamico)
        '        ''FALTA LA POSICION DEL LABEL

        '    Else
        '        numerosComprobacion(listaComprobacion.IndexOf(nuevoAlmacen.productos(i))) += 1
        '    End If
        'Next

        'frmAlmacen.Show()
        'For i = 0 To listaComprobacion.Count() - 1
        '    Dim newLabel As New Label
        '    newLabel.Text = listaComprobacion(i).Nombre
        '    frmAlmacen.Controls.Add(newLabel)

        '    Dim newLabel2 As New Label
        '    newLabel2.Text = numerosComprobacion(i)
        '    frmAlmacen.Controls.Add(newLabel2)
        'Next
        frmAlmacen.Show()
    End Sub

    Private Function btnReservas_Click() As Button
        Throw New NotImplementedException()
    End Function

    Private Sub Juego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Pedido
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
        reader.Close()
        'Imprimo los datos
        For i = 0 To nom.Count - 1
            lblPedido.Text += nom(i) & " -- " & cant(i) & ControlChars.CrLf
        Next

        'Productos
        'Leer productos
        Dim reader2 As New StreamReader("Productos.txt")
        Dim prods As New List(Of String)
        Do
            prods.Add(reader2.ReadLine())
        Loop Until reader2.EndOfStream
        reader2.Close()
        'Imprimir productos
        For i = 0 To prods.Count - 1
            lblAlmacen.Text += prods(i) & ControlChars.CrLf
        Next
    End Sub

    Private Sub btnReservas_Click(sender As Object, e As EventArgs) Handles btnReservas.Click
        frmAlmacen.Show()
    End Sub
End Class