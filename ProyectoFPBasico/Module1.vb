Imports System.IO
Imports BibliotecaProyecto
Module Module1
    Public found As Boolean = True
    Public juego As New frmJuego
    Public prodsAlmacen, prodsCarrito As New Almacen
    Public prodsPedido As New List(Of Almacen)
    Public readerPedidos As StreamReader 'New StreamReader("Documentos\Pedidos.txt")
    Dim readerAlmacen As StreamReader
    Public pedidosUsados As New List(Of Integer)
    Dim lineaCompleta As String
    Public num As Integer = totalPedidos() 'CInt(readerPedidos.ReadLine().Split(":")(1))
    Public Sub lectura()
        Try
            readerPedidos = New StreamReader("Documentos\Pedidos.txt")
            readerAlmacen = New StreamReader("Documentos\Productos.txt")
            lineaCompleta = readerPedidos.ReadLine
            Do
                prodsAlmacen.añadirProducto(New Producto(readerAlmacen.ReadLine, 60))
            Loop Until readerAlmacen.EndOfStream
            readerAlmacen.Close()
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
        Catch ex As System.IO.IOException
            found = False
            MessageBox.Show("No se ha encontrado el fichero Productos/Pedidos. Por favor, salga del juego y contacte con el soporte.")
        End Try
    End Sub

    Public Function totalPedidos()
        Try
            Dim readerTotalPedidos As New StreamReader("Documentos\Pedidos.txt")
            Dim numTemp As Integer = readerTotalPedidos.ReadLine().Split(":")(1)
            readerTotalPedidos.Close()
            Return numTemp
        Catch ex As System.IO.IOException
            MessageBox.Show("No se encontró el fichero Pedidos")
        End Try
        Return ""
    End Function
    Public Sub activarBotonesJuego(aux As Boolean)
        juego.grbPedido.Enabled = aux
        juego.Enabled = aux
        juego.grbCarrito.Enabled = aux
        juego.btnInstruccionesJ.Enabled = aux
        juego.btnReservas.Enabled = aux
        juego.btnSalir.Enabled = aux
        juego.Button2.Enabled = aux
    End Sub

End Module
