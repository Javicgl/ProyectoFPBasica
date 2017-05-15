
Imports System.Drawing

Public Class Producto : Implements IEquatable(Of Producto)
    Public Property Nombre As String

    Public Property Img As Image

    Private _Cantidad As Integer
    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(value As Integer)
            _Cantidad = value
        End Set
    End Property

    Public Sub New(nom As String, cant As Integer)
        Me.Nombre = nom
        Me.Cantidad = cant
        Me.Img = Image.FromFile(My.Application.Info.DirectoryPath & "\Imagenes\" & nom & ".jpg")
    End Sub

    Public Sub New(nom As String)
        Me.New(nom, 1)
    End Sub

    Public Overloads Function Equals(other As Producto) As Boolean Implements IEquatable(Of Producto).Equals
        Return other IsNot Nothing AndAlso other._Nombre.ToLower = Me._Nombre.ToLower
    End Function
End Class
