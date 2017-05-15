Imports System.IO
Imports BibliotecaProyecto
Module Module1
    Public prodsAlmacen, prodsCarrito As New Almacen
    Public prodsPedido As New List(Of Almacen)
    Public readerPedidos As New StreamReader("Pedidos.txt")
    Dim readerAlmacen As New StreamReader("Productos.txt")
    Dim lineaCompleta As String
    Public num As Integer = CInt(readerPedidos.ReadLine().Split(":")(1))
    Public Sub lectura()
        Do
            prodsAlmacen.añadirProducto(New Producto(readerAlmacen.ReadLine, 60))
        Loop Until readerAlmacen.EndOfStream

        For i = 0 To num - 1
            Dim alm As New Almacen
            prodsPedido.Add(alm)
        Next
        Do
            Dim linea As String = readerPedidos.ReadLine
            Dim miPedido As Integer

            If linea.Contains("@") Then
                miPedido = CInt(linea.ElementAt(0).ToString)
            Else
                prodsPedido.Item(miPedido - 1).añadirProducto(New Producto(linea.Split(",")(0), CInt(linea.Split(",")(1))))
            End If
        Loop Until readerPedidos.EndOfStream
    End Sub

End Module
