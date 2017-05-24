Public Class frmInstrucciones
    Private Sub frmInstrucciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmInicio.btnIns.Enabled = True
        activarBotonesJuego(True)
    End Sub
End Class