Public Class frmRanking
    Private Sub frmRanking_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmInicio.btnRanking.Enabled = True
    End Sub
End Class