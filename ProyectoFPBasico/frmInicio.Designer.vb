<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnJugar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnIns = New System.Windows.Forms.Button()
        Me.btnRanking = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnJugar
        '
        Me.btnJugar.Location = New System.Drawing.Point(395, 286)
        Me.btnJugar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnJugar.Name = "btnJugar"
        Me.btnJugar.Size = New System.Drawing.Size(652, 277)
        Me.btnJugar.TabIndex = 0
        Me.btnJugar.Text = "Jugar"
        Me.btnJugar.UseVisualStyleBackColor = True
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(156, 60)
        Me.btnCrear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(204, 73)
        Me.btnCrear.TabIndex = 1
        Me.btnCrear.Text = "Crear cuenta"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'btnIns
        '
        Me.btnIns.Location = New System.Drawing.Point(621, 60)
        Me.btnIns.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIns.Name = "btnIns"
        Me.btnIns.Size = New System.Drawing.Size(204, 73)
        Me.btnIns.TabIndex = 2
        Me.btnIns.Text = "Instrucciones"
        Me.btnIns.UseVisualStyleBackColor = True
        '
        'btnRanking
        '
        Me.btnRanking.Location = New System.Drawing.Point(1160, 60)
        Me.btnRanking.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRanking.Name = "btnRanking"
        Me.btnRanking.Size = New System.Drawing.Size(204, 73)
        Me.btnRanking.TabIndex = 3
        Me.btnRanking.Text = "Ranking"
        Me.btnRanking.UseVisualStyleBackColor = True
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1498, 658)
        Me.Controls.Add(Me.btnRanking)
        Me.Controls.Add(Me.btnIns)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.btnJugar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnJugar As Button
    Friend WithEvents btnCrear As Button
    Friend WithEvents btnIns As Button
    Friend WithEvents btnRanking As Button
End Class
