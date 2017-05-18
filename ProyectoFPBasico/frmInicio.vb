Public Class frmInicio
    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        Dim frmInicioSesion As New frmLogeo
        frmInicioSesion.Show()
        btnCrear.Enabled = False
        btnJugar.Enabled = False
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim crear As New frmLogeo
        crear.Show()
        crear.btnInicioSesion.Text = "Regístrate"
        btnCrear.Enabled = False
        btnJugar.Enabled = False
    End Sub

    Private Sub btnIns_Click(sender As Object, e As EventArgs) Handles btnIns.Click
        frmInstrucciones.Show()
        Me.btnIns.Enabled = False
    End Sub
End Class
