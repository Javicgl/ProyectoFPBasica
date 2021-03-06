﻿Imports System.IO
Imports BibliotecaProyecto


Public Class frmJuego
    Dim pos0 As Point
    Dim condicionNuevoPedido As Boolean = False
    Dim generado As Boolean = False
    Dim rnd As New Random
    Dim strGuess As String
    Dim guess As Integer
    Dim aleatorio As Integer = rnd.Next(1, totalPedidos() + 1)
    Dim espacio As New Size(150, 0)
    Dim pedidoCorrecto As Integer
    Public Function mostrarLabels() As String

        If totalPedidos() = pedidosUsados.Count() Then
            Return "Ya has jugado con todos los pedidos."
        End If

        If condicionNuevoPedido Then
            If pedidosUsados.Contains(aleatorio) Then
                generado = True
            End If

            If generado Then
                Do
                    aleatorio = rnd.Next(1, num+1)
                Loop While pedidosUsados.Contains(aleatorio)
            End If
        End If

        Dim aux As Integer = 25
        generado = True
        grbAlmacen.Controls.Clear()
        grbCarrito.Controls.Clear()
        grbPedido.Controls.Clear()
        frmAlmacen.Controls.Clear()

        For i = 0 To prodsAlmacen.productos.Count - 1
            Dim miCantidadCarro As New Label
            Dim miCantidadCarroImg As New Button
            miCantidadCarroImg.Enabled = False
            AddHandler miCantidadCarro.Click, AddressOf clickedProduct_Click
            pos0 = New Point(15, aux)
            miCantidadCarro.Location = pos0
            miCantidadCarroImg.Location = miCantidadCarro.Location + espacio
            aux += 65
            miCantidadCarro.Text = prodsAlmacen.productos(i).Nombre
            miCantidadCarroImg.BackgroundImageLayout = ImageLayout.Stretch
            miCantidadCarroImg.BackgroundImage = prodsAlmacen.productos(i).Img
            miCantidadCarroImg.Width = 80
            miCantidadCarroImg.Height = 50
            frmAlmacen.Controls.Add(miCantidadCarro)
            frmAlmacen.Controls.Add(miCantidadCarroImg)
        Next
        aux = 50
        For i = 0 To prodsAlmacen.productos.Count - 1
            Dim miCantidadCarro As New Label
            Dim miCantidadCarroImg As New Button
            miCantidadCarroImg.Enabled = False
            AddHandler miCantidadCarro.Click, AddressOf clickedProductCarro_Click
            pos0 = New Point(15, aux)
            miCantidadCarro.Location = pos0
            miCantidadCarroImg.Location = miCantidadCarro.Location + espacio
            aux += 65
            miCantidadCarro.AutoSize = True
            miCantidadCarro.Text = prodsAlmacen.productos(i).Nombre & "," & prodsAlmacen.productos(i).Cantidad
            miCantidadCarroImg.BackgroundImageLayout = ImageLayout.Stretch
            miCantidadCarroImg.BackgroundImage = prodsAlmacen.productos(i).Img
            miCantidadCarroImg.Width = 80
            miCantidadCarroImg.Height = 50
            grbAlmacen.Controls.Add(miCantidadCarro)
            grbAlmacen.Controls.Add(miCantidadCarroImg)
        Next
        aux = 50
        For i = 0 To prodsCarrito.productos.Count - 1
            Dim miCantidadCarro As New Label
            Dim miCantidadCarroImg As New Button
            miCantidadCarroImg.Enabled = False
            AddHandler miCantidadCarro.Click, AddressOf clickedCarrito_Click
            pos0 = New Point(15, aux)
            miCantidadCarro.Location = pos0
            miCantidadCarroImg.Location = miCantidadCarro.Location + espacio
            aux += 65
            miCantidadCarro.AutoSize = True
            miCantidadCarro.Text = prodsCarrito.productos(i).Nombre & "," & prodsCarrito.productos(i).Cantidad
            miCantidadCarroImg.BackgroundImageLayout = ImageLayout.Stretch
            miCantidadCarroImg.BackgroundImage = prodsCarrito.productos(i).Img
            miCantidadCarroImg.Width = 80
            miCantidadCarroImg.Height = 50
            grbCarrito.Controls.Add(miCantidadCarro)
            grbCarrito.Controls.Add(miCantidadCarroImg)
        Next
        aux = 50
        For i = 0 To prodsPedido.Item(aleatorio - 1).productos.Count - 1
            Dim lblPedido As New Label
            Dim miCantidadCarroImg As New Button
            miCantidadCarroImg.Enabled = False
            lblPedido.Text = prodsPedido.Item(aleatorio - 1).productos(i).Nombre & "," & prodsPedido.Item(aleatorio - 1).productos(i).Cantidad
            miCantidadCarroImg.BackgroundImageLayout = ImageLayout.Stretch
            miCantidadCarroImg.BackgroundImage = prodsPedido.Item(aleatorio - 1).productos(i).Img
            pos0 = New Point(15, aux)
            lblPedido.Location = pos0
            miCantidadCarroImg.Location = lblPedido.Location + espacio
            aux += 65
            lblPedido.AutoSize = True
            miCantidadCarroImg.Width = 80
            miCantidadCarroImg.Height = 50
            grbPedido.Controls.Add(lblPedido)
            grbPedido.Controls.Add(miCantidadCarroImg)
        Next
        Return "Etiquetas actualizadas"
    End Function
    Private Sub btnVerAlmacen_Click(sender As Object, e As EventArgs) Handles btnReservas.Click
        frmAlmacen.Show()
        mostrarLabels()
        activarBotonesJuego(False)
    End Sub
    Private Sub clickedProduct_Click(sender As Object, e As EventArgs)
        Dim clicked As Label = TryCast(sender, Label)
        'lógica from reserva to almacen
        Dim amount, auxI As Integer
        Dim strAmount As String
        Dim añadido As Boolean
        Do
            añadido = True
            strAmount = InputBox("¿Qué cantidad de " & clicked.Text.Split(",")(0) & " quieres añadir?", "Añadiendo al almacen")
            If strAmount = "" Then
                MessageBox.Show("No has introducido nada")
            ElseIf Not Integer.TryParse(strAmount, amount) OrElse amount <= 0 Then
                añadido = False
                MessageBox.Show("Introduce una cantidad válida")
            ElseIf strAmount > 200 Then
                añadido = False
                MessageBox.Show("Solo puedes añadir un máximo de 200 unidades.")
            End If
        Loop Until añadido
        If Not strAmount = "" Then
            For i = 0 To prodsAlmacen.productos.Count - 1
                If prodsAlmacen.productos(i).Nombre = clicked.Text Then
                    auxI = i
                End If
            Next
            strGuess = InputBox("Si en el almacen tenías " & prodsAlmacen.productos(auxI).Cantidad & " " & prodsAlmacen.productos(auxI).Nombre & " y le has añadido " & amount & "... ¿Cuántas unidades tienes en el almacén?")
            If Not Integer.TryParse(strGuess, guess) OrElse guess <> prodsAlmacen.productos(auxI).Cantidad + amount Then
                MessageBox.Show("Lo siento, el resultado no es correcto. ¡Inténtalo de nuevo!")
            Else
                prodsAlmacen.productos(auxI).Cantidad += amount
                MessageBox.Show("¡ENHORABUENA, HAS ACERTADO!")
            End If
            mostrarLabels()
        End If
    End Sub

    Private Sub clickedProductCarro_Click(sender As Object, e As EventArgs)
        Dim clickedCarro As Label = TryCast(sender, Label)
        Dim currentAmount As Integer = CInt(clickedCarro.Text.Split(",")(1))
        Dim strAmount As String
        Dim amount, auxi As Integer
        Dim aux As Integer = 50
        Dim añadido As Boolean = True
        Dim encontrado As Boolean = False
        For i = 0 To prodsAlmacen.productos.Count - 1
            If prodsAlmacen.productos(i).Nombre = clickedCarro.Text.Split(",")(0) Then
                auxi = i
            End If
        Next

        Do
            añadido = True
            strAmount = InputBox("¿Qué cantidad de " & clickedCarro.Text.Split(",")(0) & " quieres añadir?", "Añadiendo al carrito")
            If strAmount = "" Then
                MessageBox.Show("No has introducido nada")
            ElseIf Not Integer.TryParse(strAmount, amount) OrElse amount <= 0 OrElse amount > currentAmount Then
                añadido = False
                MessageBox.Show("Introduce una cantidad válida")
            End If
        Loop Until añadido
        If Not strAmount = "" Then
            strGuess = InputBox("Si en el almacen tenías " & prodsAlmacen.productos(auxi).Cantidad & " " & prodsAlmacen.productos(auxi).Nombre & " y has pasado al carrito " & amount & "... ¿Cuántas unidades tienes en el almacén?")
            If Not Integer.TryParse(strGuess, guess) OrElse guess <> prodsAlmacen.productos(auxi).Cantidad - amount Then
                MessageBox.Show("Lo siento, el resultado no es correcto. ¡Inténtalo de nuevo!")
            Else
                For i = 0 To prodsCarrito.productos.Count - 1
                    If prodsCarrito.productos(i).Nombre = clickedCarro.Text.Split(",")(0) Then
                        prodsCarrito.productos(i).Cantidad += amount
                        encontrado = True
                    End If
                Next
                If Not encontrado Then
                    prodsCarrito.añadirProducto(New Producto(clickedCarro.Text.Split(",")(0), amount))
                End If
                prodsAlmacen.productos(auxi).Cantidad -= amount
                MessageBox.Show("¡Has acertado la cuenta!")
            End If
            mostrarLabels()
        End If

        'from almacen to carro
    End Sub

    Private Sub clickedCarrito_Click(sender As Object, e As EventArgs)
        Dim clickedCarro As Label = TryCast(sender, Label)
        Dim currentAmount As Integer = CInt(clickedCarro.Text.Split(",")(1))
        Dim producto As String = clickedCarro.Text.Split(",")(0)
        Dim strAmount As String
        Dim auxI As Integer = 0
        Dim amount As Integer
        Dim añadido As Boolean = True

        For i = 0 To prodsCarrito.productos.Count - 1
            If prodsCarrito.productos(i).Nombre = producto Then
                auxI = i
                'prodsCarrito.productos(i).Cantidad -= amount
            End If
        Next
        Do
            añadido = True
            strAmount = InputBox("¿Qué cantidad de " & clickedCarro.Text.Split(",")(0) & " quieres devolver al almacén?", "Devolviendo al almacén")
            If strAmount = "" Then
                MessageBox.Show("No has introducido nada.")
                añadido = False
            ElseIf Not Integer.TryParse(strAmount, amount) OrElse amount <= 0 OrElse amount > currentAmount Then
                añadido = False
                MessageBox.Show("Introduce una cantidad válida")
                strAmount = ""
            End If
        Loop Until Not añadido

        If Not strAmount = "" Then
            strGuess = InputBox("Si en el carrito tenías " & prodsCarrito.productos(auxI).Cantidad & " " & prodsCarrito.productos(auxI).Nombre & " y has devuelto al almacén " & amount & "... ¿Cuántas unidades tienes en el carrito?")
            If Not Integer.TryParse(strGuess, guess) OrElse guess <> prodsCarrito.productos(auxI).Cantidad - amount Then
                MessageBox.Show("Lo siento, el resultado no es correcto. ¡Inténtalo de nuevo!")
            Else
                For i = 0 To prodsAlmacen.productos.Count - 1
                    If prodsAlmacen.productos(i).Nombre = clickedCarro.Text.Split(",")(0) Then
                        prodsAlmacen.productos(i).Cantidad += amount
                        prodsCarrito.productos(auxI).Cantidad -= amount
                    End If
                Next
                MessageBox.Show("¡ENHORABUENA, HAS ACERTADO!")
            End If
            mostrarLabels()
        End If
        'from carrito to almacen
    End Sub

    Private Sub Juego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Module1.lectura()
        Dim nom As New List(Of String)
        Dim cant As New List(Of Integer)
        Dim aux As Integer = 50
        If found Then mostrarLabels()
    End Sub

    'Típex
    'Rotulador
    'Goma
    'Folio
    'Grapadora
    'Taladradora
    'Calculadora
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pedidoCorrecto = 0

        For i = 0 To prodsCarrito.productos.Count - 1
            For j = 0 To prodsPedido.Item(aleatorio - 1).productos.Count - 1
                If prodsPedido.Item(aleatorio - 1).productos.Contains(prodsCarrito.productos(i)) AndAlso prodsPedido.Item(aleatorio - 1).productos(j).Cantidad = prodsCarrito.productos(i).Cantidad Then
                    pedidoCorrecto += 1
                End If
            Next
        Next

        If pedidoCorrecto = prodsPedido.Item(aleatorio - 1).productos.Count Then
            MessageBox.Show("¡¡ENHORABUENA!! El pedido se ha enviado correctamente.")
            pedidosUsados.Add(aleatorio)
            If pedidosUsados.Count() >= totalPedidos() Then
                MessageBox.Show("Ya has jugado con todos los pedidos posibles. ¡Buen trabajo!")
                Me.Close()
            Else
                Dim result As DialogResult
                result = MessageBox.Show("¿Quieres jugar con otro pedido?", "", MessageBoxButtons.YesNo)
                If result = System.Windows.Forms.DialogResult.Yes Then
                    condicionNuevoPedido = True
                    prodsCarrito.eliminarAlmacen()
                    mostrarLabels()
                    condicionNuevoPedido = False
                Else
                    Me.Close()
                End If
            End If
                Else
                MessageBox.Show("Pedido INCORRECTO, vuelve a intentarlo.")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim x As DialogResult
        x = MessageBox.Show("¿Seguro que quieres salir del juego?", "", MessageBoxButtons.YesNo)
        If x = System.Windows.Forms.DialogResult.Yes Then
            frmAlmacen.Close()
            frmInstrucciones.Close()
            frmLogeo.Close()
            frmInicio.Close()
            Me.Close()
        End If
    End Sub

    Private Sub btnInstruccionesJ_Click(sender As Object, e As EventArgs) Handles btnInstruccionesJ.Click
        frmInstrucciones.Show()
        activarBotonesJuego(False)
    End Sub
End Class
