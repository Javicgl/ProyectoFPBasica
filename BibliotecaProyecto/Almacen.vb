Public Class Almacen
    Public productos As New List(Of Producto)
    Public Function AñadirProducto(nom As String, cant As Integer) As String
        For i = 0 To cant - 1
            productos.Add(New Producto(nom))
        Next
        Return "Se han añadido los " & cant & " productos."
    End Function

    Public Function BorrarProducto(nom As String, cant As Integer) As String
        For i = 0 To cant - 1
            productos.Remove(New Producto(nom))
        Next
        Return "Se han eliminado los " & cant & " productos."
    End Function

    Public Function EliminarProducto(nom As String) As String
        Dim condicion As Boolean = False
        For i = 0 To productos.Count() - 1
            If productos(i).Nombre = nom Then
                productos.Remove(productos(i))
                condicion = True
            End If
        Next
        If condicion = True Then
            Return "El producto ha sido eliminado."
        Else
            Return "El producto no se encuentra en el almacén."
        End If
    End Function
End Class