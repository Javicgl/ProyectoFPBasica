Public Class Almacen
    Public productos As New List(Of Producto)

    Public Function añadirProducto(prod As Producto) As String
        If String.IsNullOrWhiteSpace(prod.Nombre) Then
            Return "El producto debe tener un nombre válido"
        End If
        If prod.Cantidad <= 0 Then
            Return "La cantidad debe ser superior a 0"
        End If
        If Me.productos.Contains(prod) Then
            productos.ElementAt(productos.IndexOf(prod)).Cantidad += prod.Cantidad
            Return "Añadidas"
        End If
        productos.Add(prod)
        Return prod.Cantidad & " unidades se han añadido del producto " & prod.Nombre
    End Function

    Public Function borrarProducto(prod As Producto) As String
        If Not Me.productos.Contains(prod) Then
            Return "El producto no se encuentra"
        ElseIf prod.Cantidad <= 0 Then
            Return "La cantidad a eliminar debe ser mayor que 0"
        ElseIf prod.Cantidad >= productos.ElementAt(productos.IndexOf(prod)).Cantidad Then
            productos.Remove(productos.ElementAt(productos.IndexOf(prod)))
            Return "Producto eliminado por completo"
        End If
        productos.ElementAt(productos.IndexOf(prod)).Cantidad -= prod.Cantidad
        Return "Se han eliminado " & prod.Cantidad & " unidades del producto " & prod.Nombre
    End Function

    Public Sub eliminarAlmacen()
        For i = 0 To productos.Count() - 1
            productos.RemoveAt(0)
        Next
    End Sub
End Class
