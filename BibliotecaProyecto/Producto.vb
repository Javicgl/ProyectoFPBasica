
Imports System.Drawing

Public Class Producto : Implements IEquatable(Of Producto)

    Public Property Nombre As String

    Public Property img As Image
    'Private _Codigo As String
    'Public Property Codigo As String
    '    Get
    '        Return _Codigo
    '    End Get
    '    Set(value As String)
    '        _Codigo = value
    '    End Set
    'End Property

    'Private _Cantidad As Integer
    'Public Property Cantidad As Integer
    '    Get
    '        Return _Cantidad
    '    End Get
    '    Set(value As Integer)
    '        _Cantidad = value
    '    End Set
    'End Property

    'Public Sub New(nom As String, cant As Integer)
    '    Me.Nombre = nom
    '    Me.Cantidad = cant
    'End Sub

    Public Sub New(nom As String)
        Me.Nombre = nom
    End Sub

    Public Overloads Function Equals(other As Producto) As Boolean Implements IEquatable(Of Producto).Equals
        Return other IsNot Nothing AndAlso other._Nombre.ToLower = Me._Nombre.ToLower
    End Function

End Class
