Public Class Jugador

    Public Property Usuario As String
    Public Property Contraseña As String
    Public Property Puntuacion As Integer
    Public Property EsAdministrador As Boolean

    Public Sub New(user As String, pass As String)
        Me.Usuario = user
        Me.Contraseña = pass
        Me.Puntuacion = 0
        Me.EsAdministrador = False
    End Sub

    Public Sub New()
        Me.New("Invitado", "")
    End Sub

End Class
