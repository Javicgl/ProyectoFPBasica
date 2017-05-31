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
        Dim inst As New frmInstrucciones
        inst.Show()
        Me.btnIns.Enabled = False
    End Sub

    Private Sub btnRanking_Click(sender As Object, e As EventArgs) Handles btnRanking.Click
        Dim rank As New frmRanking
        rank.Show()
        Me.btnRanking.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
    End Sub
End Class