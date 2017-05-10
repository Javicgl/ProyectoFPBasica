Public Class frmInicio
    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        Dim frmInicioSesion As New frmLogeo
        frmInicioSesion.Show()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim crear As New frmReg
        crear.Show()
    End Sub
End Class
