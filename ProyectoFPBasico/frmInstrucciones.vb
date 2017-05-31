Public Class frmInstrucciones
    Private Sub frmInstrucciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmInicio.btnIns.Enabled = True
        activarBotonesJuego(True)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub frmInstrucciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
    End Sub
End Class