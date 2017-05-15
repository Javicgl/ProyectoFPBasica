Imports System.IO
Imports BibliotecaProyecto


Public Class frmJuego
    Dim pos0 As Point
    Dim espacio As New Size(35, 0)
    Private rnd As New Random
    Private aleatorio2 As Integer
    Public Function mostrarLabels() As String
        Dim aux As Integer = 50
        grbAlmacen.Controls.Clear()
        grbCarrito.Controls.Clear()
        frmAlmacen.Controls.Clear()

        For i = 0 To prodsAlmacen.productos.Count - 1
            Dim miCantidadCarro As New Label
            Dim miCantidadCarroImg As New Label
            AddHandler miCantidadCarro.Click, AddressOf clickedProduct_Click
            pos0 = New Point(15, aux)
            miCantidadCarro.Location = pos0
            miCantidadCarroImg.Location = miCantidadCarro.Location + espacio
            aux += 50
            miCantidadCarro.Text = prodsAlmacen.productos(i).Nombre
            miCantidadCarroImg.Image = prodsAlmacen.productos(i).Img
            frmAlmacen.Controls.Add(miCantidadCarro)
            frmAlmacen.Controls.Add(miCantidadCarroImg)
        Next
        aux = 50
        For i = 0 To prodsAlmacen.productos.Count - 1
            Dim miCantidadCarro As New Label
            Dim miCantidadCarroImg As New Label
            AddHandler miCantidadCarro.Click, AddressOf clickedProductCarro_Click
            pos0 = New Point(15, aux)
            miCantidadCarro.Location = pos0
            miCantidadCarroImg.Location = miCantidadCarro.Location + espacio
            aux += 50
            miCantidadCarro.Text = prodsAlmacen.productos(i).Nombre & "," & prodsAlmacen.productos(i).Cantidad
            miCantidadCarroImg.Image = prodsAlmacen.productos(i).Img
            grbAlmacen.Controls.Add(miCantidadCarro)
            grbAlmacen.Controls.Add(miCantidadCarroImg)
        Next
        aux = 50
        For i = 0 To prodsCarrito.productos.Count - 1
            Dim miCantidadCarro As New Label
            Dim miCantidadCarroImg As New Label
            AddHandler miCantidadCarro.Click, AddressOf clickedCarrito_Click
            pos0 = New Point(15, aux)
            miCantidadCarro.Location = pos0
            miCantidadCarroImg.Location = miCantidadCarro.Location + espacio
            aux += 50
            miCantidadCarro.Text = prodsCarrito.productos(i).Nombre & "," & prodsCarrito.productos(i).Cantidad
            miCantidadCarroImg.Image = prodsCarrito.productos(i).Img
            grbCarrito.Controls.Add(miCantidadCarro)
            grbCarrito.Controls.Add(miCantidadCarroImg)
        Next
        Return "Etiquetas actualizadas"
    End Function
    Private Sub btnVerAlmacen_Click(sender As Object, e As EventArgs) Handles btnReservas.Click
        frmAlmacen.Show()
        mostrarLabels()
    End Sub
    Private Sub clickedProduct_Click(sender As Object, e As EventArgs)
        Dim clicked As Label = TryCast(sender, Label)
        'lógica from reserva to almacen
        Dim amount As Integer
        Dim strAmount As String
        Dim añadido As Boolean = True
        Do
            strAmount = InputBox("¿Qué cantidad quieres añadir?", "Añadiendo al almacen")
            If String.IsNullOrWhiteSpace(strAmount) OrElse Not Integer.TryParse(strAmount, amount) OrElse amount <= 0 Then
                añadido = False
                MessageBox.Show("Introduce una cantidad válida")
            End If
        Loop Until añadido
        For i = 0 To prodsAlmacen.productos.Count - 1
            If prodsAlmacen.productos(i).Nombre = clicked.Text Then
                prodsAlmacen.productos(i).Cantidad += amount
            End If
        Next

        mostrarLabels()
    End Sub

    Private Sub clickedProductCarro_Click(sender As Object, e As EventArgs)
        Dim clickedCarro As Label = TryCast(sender, Label)
        Dim auxi As Integer
        For i = 0 To prodsAlmacen.productos.Count - 1
            If prodsAlmacen.productos(i).Nombre = clickedCarro.Text.Split(",")(0) Then
                auxi = i
            End If
        Next
        Dim currentAmount As Integer = CInt(clickedCarro.Text.Split(",")(1))
        Dim strAmount As String
        Dim amount As Integer
        Dim aux As Integer = 50
        Dim añadido As Boolean = True
        Dim encontrado As Boolean = False
        Do
            añadido = True
            strAmount = InputBox("¿Qué cantidad quieres añadir?", "Añadiendo al carrito")
            If Not Integer.TryParse(strAmount, amount) OrElse amount <= 0 OrElse amount > currentAmount Then
                añadido = False
                MessageBox.Show("Introduce una cantidad válida")
            End If
        Loop Until añadido

        For i = 0 To prodsCarrito.productos.Count - 1
            If prodsCarrito.productos(i).Nombre = clickedCarro.Text.Split(",")(0) Then
                prodsCarrito.productos(i).Cantidad += amount
                encontrado = True
            End If
        Next

        If Not encontrado Then prodsCarrito.añadirProducto(New Producto(clickedCarro.Text.Split(",")(0), amount))

        prodsAlmacen.productos(auxi).Cantidad -= amount
        mostrarLabels()
        'from almacen to carro
    End Sub

    Private Sub clickedCarrito_Click(sender As Object, e As EventArgs)
        Dim clickedCarro As Label = TryCast(sender, Label)
        Dim currentAmount As Integer = CInt(clickedCarro.Text.Split(",")(1))
        Dim producto As String = clickedCarro.Text.Split(",")(0)
        Dim strAmount As String
        Dim amount As Integer
        Dim añadido As Boolean = True
        Do
            añadido = True
            strAmount = InputBox("¿Qué cantidad quieres devolver al almacén?", "Devolviendo al almacén")
            If Not Integer.TryParse(strAmount, amount) OrElse amount <= 0 OrElse amount > currentAmount Then
                añadido = False
                MessageBox.Show("Introduce una cantidad válida")
            End If
        Loop Until añadido

        For i = 0 To prodsCarrito.productos.Count - 1
            If prodsCarrito.productos(i).Nombre = producto Then
                prodsCarrito.productos(i).Cantidad -= amount
            End If
        Next
        For i = 0 To prodsAlmacen.productos.Count - 1
            If prodsAlmacen.productos(i).Nombre = producto Then
                prodsAlmacen.productos(i).Cantidad += amount
            End If
        Next
        mostrarLabels()
        'from carrito to almacen
    End Sub

    Private Sub Juego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.lectura()
        'Pedido.
        Dim aleatorio As Integer = rnd.Next(1, num)
        Dim nom As New List(Of String)
        Dim cant As New List(Of Integer)
        Dim aux As Integer = 50
        Dim pos0 As Point

        'Encuentro el pedido
        For i = 0 To prodsPedido.Item(aleatorio - 1).productos.Count - 1
            Dim lblPedido As New Label
            Dim btnImagen As New Button
            lblPedido.Text = prodsPedido.Item(aleatorio - 1).productos(i).Nombre & "," & prodsPedido.Item(aleatorio - 1).productos(i).Cantidad
            btnImagen.Image = prodsPedido.Item(aleatorio - 1).productos(i).Img
            grbPedido.Controls.Add(lblPedido)
            grbPedido.Controls.Add(btnImagen)
            pos0 = New Point(15, aux)
            lblPedido.Location = pos0
            btnImagen.Location = lblPedido.Location + espacio
            aux += 50
        Next
        aux = 50
        'Productos
        'Leer productos, boli, tipex, lapiz, rotulador, goma, folio, grapadora, taladradora, calculadora, tijera
        For i = 0 To prodsAlmacen.productos.Count - 1
            Dim miCantidadCarro As New Label
            Dim miCantidadCarroImg As New Button
            AddHandler miCantidadCarro.Click, AddressOf clickedProductCarro_Click
            pos0 = New Point(15, aux)
            miCantidadCarro.Location = pos0
            miCantidadCarroImg.Location = miCantidadCarro.Location + espacio
            aux += 50
            miCantidadCarro.Text = prodsAlmacen.productos(i).Nombre & "," & prodsAlmacen.productos(i).Cantidad
            miCantidadCarroImg.Image = prodsAlmacen.productos(i).Img
            grbAlmacen.Controls.Add(miCantidadCarro)
            grbAlmacen.Controls.Add(miCantidadCarroImg)
        Next
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles Button2.Click

        For i = 0 To prodsCarrito.productos.Count - 1
            For j = 0 To prodsPedido.Item(aleatorio2 - 1).productos.Count - 1
                If prodsPedido.Item(aleatorio2 - 1).productos(j).Nombre = prodsCarrito.productos(i).Nombre Then

                End If
            Next
        Next
        For i = 1 To grbCarrito.Controls.Count - 1
            If Not grbPedido.Controls.Contains(grbCarrito.Controls(i)) OrElse grbPedido.Controls.Count() <> grbCarrito.Controls.Count() Then
                MessageBox.Show("Pedido INCORRECTO")
                Exit Sub
            End If
        Next
    End Sub


End Class
