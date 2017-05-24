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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJuego))
        Me.grbPedido = New System.Windows.Forms.GroupBox()
        Me.grbCarrito = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.grbAlmacen = New System.Windows.Forms.GroupBox()
        Me.btnReservas = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnInstruccionesJ = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'grbPedido
        '
        Me.grbPedido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grbPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grbPedido.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbPedido.Location = New System.Drawing.Point(13, 57)
        Me.grbPedido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbPedido.Name = "grbPedido"
        Me.grbPedido.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbPedido.Size = New System.Drawing.Size(413, 815)
        Me.grbPedido.TabIndex = 0
        Me.grbPedido.TabStop = False
        Me.grbPedido.Text = "PEDIDO"
        '
        'grbCarrito
        '
        Me.grbCarrito.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbCarrito.AutoSize = True
        Me.grbCarrito.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grbCarrito.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbCarrito.Location = New System.Drawing.Point(1225, 57)
        Me.grbCarrito.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbCarrito.Name = "grbCarrito"
        Me.grbCarrito.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbCarrito.Size = New System.Drawing.Size(349, 740)
        Me.grbCarrito.TabIndex = 2
        Me.grbCarrito.TabStop = False
        Me.grbCarrito.Text = "CARRITO"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1177, 826)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(351, 46)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "ENVIAR PEDIDO"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'grbAlmacen
        '
        Me.grbAlmacen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grbAlmacen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grbAlmacen.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbAlmacen.Location = New System.Drawing.Point(551, 57)
        Me.grbAlmacen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbAlmacen.Name = "grbAlmacen"
        Me.grbAlmacen.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbAlmacen.Size = New System.Drawing.Size(558, 704)
        Me.grbAlmacen.TabIndex = 5
        Me.grbAlmacen.TabStop = False
        Me.grbAlmacen.Text = "ALMACÉN"
        '
        'btnReservas
        '
        Me.btnReservas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReservas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReservas.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservas.Location = New System.Drawing.Point(674, 778)
        Me.btnReservas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReservas.Name = "btnReservas"
        Me.btnReservas.Size = New System.Drawing.Size(253, 47)
        Me.btnReservas.TabIndex = 6
        Me.btnReservas.Text = "VER RESERVAS"
        Me.btnReservas.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(504, 832)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(274, 39)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "SALIR DEL JUEGO"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnInstruccionesJ
        '
        Me.btnInstruccionesJ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnInstruccionesJ.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnInstruccionesJ.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstruccionesJ.Location = New System.Drawing.Point(832, 829)
        Me.btnInstruccionesJ.Name = "btnInstruccionesJ"
        Me.btnInstruccionesJ.Size = New System.Drawing.Size(263, 42)
        Me.btnInstruccionesJ.TabIndex = 11
        Me.btnInstruccionesJ.Text = "INSTRUCCIONES"
        Me.btnInstruccionesJ.UseVisualStyleBackColor = False
        '
        'frmJuego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1599, 883)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnInstruccionesJ)
        Me.Controls.Add(Me.btnSalir)
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
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnInstruccionesJ As Button
End Class
