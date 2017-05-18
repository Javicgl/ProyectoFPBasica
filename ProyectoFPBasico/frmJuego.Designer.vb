<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmJuego
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grbPedido = New System.Windows.Forms.GroupBox()
        Me.grbCarrito = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.grbAlmacen = New System.Windows.Forms.GroupBox()
        Me.btnReservas = New System.Windows.Forms.Button()
        Me.lblPedido = New System.Windows.Forms.Label()
        Me.lblAlmacen = New System.Windows.Forms.Label()
        Me.lblCarrito = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnInstruccionesJ = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'grbPedido
        '
        Me.grbPedido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grbPedido.Location = New System.Drawing.Point(13, 57)
        Me.grbPedido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbPedido.Name = "grbPedido"
        Me.grbPedido.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbPedido.Size = New System.Drawing.Size(413, 815)
        Me.grbPedido.TabIndex = 0
        Me.grbPedido.TabStop = False
        '
        'grbCarrito
        '
        Me.grbCarrito.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbCarrito.AutoSize = True
        Me.grbCarrito.Location = New System.Drawing.Point(1225, 57)
        Me.grbCarrito.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbCarrito.Name = "grbCarrito"
        Me.grbCarrito.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbCarrito.Size = New System.Drawing.Size(349, 740)
        Me.grbCarrito.TabIndex = 2
        Me.grbCarrito.TabStop = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(1177, 826)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(351, 46)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Enviar pedido"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'grbAlmacen
        '
        Me.grbAlmacen.Location = New System.Drawing.Point(432, 57)
        Me.grbAlmacen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbAlmacen.Name = "grbAlmacen"
        Me.grbAlmacen.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbAlmacen.Size = New System.Drawing.Size(787, 608)
        Me.grbAlmacen.TabIndex = 5
        Me.grbAlmacen.TabStop = False
        '
        'btnReservas
        '
        Me.btnReservas.Location = New System.Drawing.Point(600, 671)
        Me.btnReservas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReservas.Name = "btnReservas"
        Me.btnReservas.Size = New System.Drawing.Size(253, 47)
        Me.btnReservas.TabIndex = 6
        Me.btnReservas.Text = "Ver reservas"
        Me.btnReservas.UseVisualStyleBackColor = True
        '
        'lblPedido
        '
        Me.lblPedido.AutoSize = True
        Me.lblPedido.Location = New System.Drawing.Point(156, 21)
        Me.lblPedido.Name = "lblPedido"
        Me.lblPedido.Size = New System.Drawing.Size(60, 17)
        Me.lblPedido.TabIndex = 7
        Me.lblPedido.Text = "PEDIDO"
        '
        'lblAlmacen
        '
        Me.lblAlmacen.AutoSize = True
        Me.lblAlmacen.Location = New System.Drawing.Point(675, 21)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(73, 17)
        Me.lblAlmacen.TabIndex = 8
        Me.lblAlmacen.Text = "ALMACEN"
        '
        'lblCarrito
        '
        Me.lblCarrito.AutoSize = True
        Me.lblCarrito.Location = New System.Drawing.Point(1385, 21)
        Me.lblCarrito.Name = "lblCarrito"
        Me.lblCarrito.Size = New System.Drawing.Size(69, 17)
        Me.lblCarrito.TabIndex = 9
        Me.lblCarrito.Text = "CARRITO"
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(502, 758)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(246, 131)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir del juego"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnInstruccionesJ
        '
        Me.btnInstruccionesJ.Location = New System.Drawing.Point(830, 758)
        Me.btnInstruccionesJ.Name = "btnInstruccionesJ"
        Me.btnInstruccionesJ.Size = New System.Drawing.Size(246, 131)
        Me.btnInstruccionesJ.TabIndex = 11
        Me.btnInstruccionesJ.Text = "Instrucciones"
        Me.btnInstruccionesJ.UseVisualStyleBackColor = True
        '
        'frmJuego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1599, 883)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnInstruccionesJ)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblCarrito)
        Me.Controls.Add(Me.lblAlmacen)
        Me.Controls.Add(Me.lblPedido)
        Me.Controls.Add(Me.btnReservas)
        Me.Controls.Add(Me.grbCarrito)
        Me.Controls.Add(Me.grbAlmacen)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.grbPedido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmJuego"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Juego"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grbPedido As GroupBox
    Friend WithEvents grbCarrito As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents grbAlmacen As GroupBox
    Friend WithEvents btnReservas As Button
    Friend WithEvents lblPedido As Label
    Friend WithEvents lblAlmacen As Label
    Friend WithEvents lblCarrito As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnInstruccionesJ As Button
End Class
