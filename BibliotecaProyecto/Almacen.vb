Public Class Almacen
    Public productos As New List(Of Producto)

    'añadirproducto
    'borrarproducto
    'mostrarproductos
    Public Function añadirProducto(prod As Producto) As String
        productos.Add(prod)
        Return "hola"
    End Function
    Public Function borrarProducto(prod As Producto) As String
        productos.Remove(prod)
        Return "hola"
    End Function
    Public Function mostrarProductos() As String
        Return "hola"
    End Function
End Class
