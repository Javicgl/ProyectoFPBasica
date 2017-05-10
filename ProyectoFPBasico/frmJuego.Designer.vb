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
        Me.lblPedido = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbCarrito = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.grbAlmacen = New System.Windows.Forms.GroupBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.btnReservas = New System.Windows.Forms.Button()
        Me.lblAlmacen = New System.Windows.Forms.Label()
        Me.grbPedido.SuspendLayout()
        Me.grbCarrito.SuspendLayout()
        Me.grbAlmacen.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbPedido
        '
        Me.grbPedido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grbPedido.Controls.Add(Me.lblPedido)
        Me.grbPedido.Controls.Add(Me.Label1)
        Me.grbPedido.Location = New System.Drawing.Point(13, 11)
        Me.grbPedido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbPedido.Name = "grbPedido"
        Me.grbPedido.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbPedido.Size = New System.Drawing.Size(413, 709)
        Me.grbPedido.TabIndex = 0
        Me.grbPedido.TabStop = False
        '
        'lblPedido
        '
        Me.lblPedido.BackColor = System.Drawing.SystemColors.Control
        Me.lblPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPedido.Location = New System.Drawing.Point(51, 107)
        Me.lblPedido.Name = "lblPedido"
        Me.lblPedido.Size = New System.Drawing.Size(297, 561)
        Me.lblPedido.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(152, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pedido"
        '
        'grbCarrito
        '
        Me.grbCarrito.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbCarrito.AutoSize = True
        Me.grbCarrito.Controls.Add(Me.Label3)
        Me.grbCarrito.Location = New System.Drawing.Point(953, 12)
        Me.grbCarrito.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbCarrito.Name = "grbCarrito"
        Me.grbCarrito.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbCarrito.Size = New System.Drawing.Size(442, 633)
        Me.grbCarrito.TabIndex = 2
        Me.grbCarrito.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Carrito"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(998, 674)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(351, 46)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Enviar pedido"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'grbAlmacen
        '
        Me.grbAlmacen.Controls.Add(Me.lblAlmacen)
        Me.grbAlmacen.Controls.Add(Me.label2)
        Me.grbAlmacen.Location = New System.Drawing.Point(432, 12)
        Me.grbAlmacen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbAlmacen.Name = "grbAlmacen"
        Me.grbAlmacen.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbAlmacen.Size = New System.Drawing.Size(515, 522)
        Me.grbAlmacen.TabIndex = 5
        Me.grbAlmacen.TabStop = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(173, 31)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(62, 17)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Almacen"
        '
        'btnReservas
        '
        Me.btnReservas.Location = New System.Drawing.Point(517, 589)
        Me.btnReservas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReservas.Name = "btnReservas"
        Me.btnReservas.Size = New System.Drawing.Size(344, 90)
        Me.btnReservas.TabIndex = 6
        Me.btnReservas.Text = "Ver reservas"
        Me.btnReservas.UseVisualStyleBackColor = True
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlmacen.Location = New System.Drawing.Point(68, 69)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(386, 431)
        Me.lblAlmacen.TabIndex = 1
        '
        'frmJuego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1420, 731)
        Me.Controls.Add(Me.btnReservas)
        Me.Controls.Add(Me.grbCarrito)
        Me.Controls.Add(Me.grbAlmacen)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.grbPedido)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmJuego"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Juego"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grbPedido.ResumeLayout(False)
        Me.grbPedido.PerformLayout()
        Me.grbCarrito.ResumeLayout(False)
        Me.grbCarrito.PerformLayout()
        Me.grbAlmacen.ResumeLayout(False)
        Me.grbAlmacen.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grbPedido As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grbCarrito As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents lblPedido As Label
    Friend WithEvents grbAlmacen As GroupBox
    Friend WithEvents label2 As Label
    Friend WithEvents btnReservas As Button
    Friend WithEvents lblAlmacen As Label
End Class
