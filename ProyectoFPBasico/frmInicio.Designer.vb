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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.btnJugar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnIns = New System.Windows.Forms.Button()
        Me.btnRanking = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnJugar
        '
        Me.btnJugar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnJugar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnJugar.Font = New System.Drawing.Font("Arial Unicode MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJugar.Location = New System.Drawing.Point(187, 301)
        Me.btnJugar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnJugar.Name = "btnJugar"
        Me.btnJugar.Size = New System.Drawing.Size(652, 277)
        Me.btnJugar.TabIndex = 0
        Me.btnJugar.Text = "JUGAR"
        Me.btnJugar.UseVisualStyleBackColor = False
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCrear.Font = New System.Drawing.Font("Arial Unicode MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrear.Location = New System.Drawing.Point(156, 60)
        Me.btnCrear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(257, 119)
        Me.btnCrear.TabIndex = 1
        Me.btnCrear.Text = "CREAR CUENTA"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'btnIns
        '
        Me.btnIns.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIns.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIns.Location = New System.Drawing.Point(604, 61)
        Me.btnIns.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIns.Name = "btnIns"
        Me.btnIns.Size = New System.Drawing.Size(257, 119)
        Me.btnIns.TabIndex = 2
        Me.btnIns.Text = "INSTRUCCIONES"
        Me.btnIns.UseVisualStyleBackColor = False
        '
        'btnRanking
        '
        Me.btnRanking.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRanking.Font = New System.Drawing.Font("Arial Unicode MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRanking.Location = New System.Drawing.Point(1058, 60)
        Me.btnRanking.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRanking.Name = "btnRanking"
        Me.btnRanking.Size = New System.Drawing.Size(257, 118)
        Me.btnRanking.TabIndex = 3
        Me.btnRanking.Text = "RANKING"
        Me.btnRanking.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Arial Unicode MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(989, 362)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(338, 147)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1498, 658)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnRanking)
        Me.Controls.Add(Me.btnIns)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.btnJugar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnJugar As Button
    Friend WithEvents btnCrear As Button
    Friend WithEvents btnIns As Button
    Friend WithEvents btnRanking As Button
    Friend WithEvents btnSalir As Button
End Class
