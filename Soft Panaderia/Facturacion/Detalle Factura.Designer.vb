<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detalle_Factura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Detalle_Factura))
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.dgv_detalles = New System.Windows.Forms.DataGridView()
        Me.codigo_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_codigo_cliente = New System.Windows.Forms.Label()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.lbl_razon = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_fecha_comprobante = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lbl_numero_factura = New System.Windows.Forms.Label()
        Me.lbl_factura = New System.Windows.Forms.Label()
        Me.lbl_total_cantidad = New System.Windows.Forms.Label()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.lbl_total_importe = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.btn_volver = New System.Windows.Forms.Button()
        CType(Me.dgv_detalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(9, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(261, 31)
        Me.lbl_titulo.TabIndex = 0
        Me.lbl_titulo.Text = "La Nueva Colmena"
        '
        'dgv_detalles
        '
        Me.dgv_detalles.AllowUserToAddRows = False
        Me.dgv_detalles.AllowUserToDeleteRows = False
        Me.dgv_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo_producto, Me.cantidad, Me.producto, Me.precio, Me.importe})
        Me.dgv_detalles.Location = New System.Drawing.Point(12, 79)
        Me.dgv_detalles.Name = "dgv_detalles"
        Me.dgv_detalles.Size = New System.Drawing.Size(548, 292)
        Me.dgv_detalles.TabIndex = 1
        '
        'codigo_producto
        '
        Me.codigo_producto.HeaderText = "Codigo Producto"
        Me.codigo_producto.Name = "codigo_producto"
        Me.codigo_producto.Visible = False
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        '
        'producto
        '
        Me.producto.HeaderText = "Detalle"
        Me.producto.Name = "producto"
        '
        'precio
        '
        Me.precio.HeaderText = "Precio Unitario $"
        Me.precio.Name = "precio"
        '
        'importe
        '
        Me.importe.HeaderText = "Importe $"
        Me.importe.Name = "importe"
        '
        'lbl_codigo_cliente
        '
        Me.lbl_codigo_cliente.AutoSize = True
        Me.lbl_codigo_cliente.Location = New System.Drawing.Point(12, 53)
        Me.lbl_codigo_cliente.Name = "lbl_codigo_cliente"
        Me.lbl_codigo_cliente.Size = New System.Drawing.Size(81, 13)
        Me.lbl_codigo_cliente.TabIndex = 2
        Me.lbl_codigo_cliente.Text = "Codigo Cliente: "
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Location = New System.Drawing.Point(86, 53)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(55, 13)
        Me.lbl_codigo.TabIndex = 3
        Me.lbl_codigo.Text = "lbl_codigo"
        '
        'lbl_razon
        '
        Me.lbl_razon.AutoSize = True
        Me.lbl_razon.Location = New System.Drawing.Point(163, 53)
        Me.lbl_razon.Name = "lbl_razon"
        Me.lbl_razon.Size = New System.Drawing.Size(76, 13)
        Me.lbl_razon.TabIndex = 4
        Me.lbl_razon.Text = "Razon Social: "
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(234, 53)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(58, 13)
        Me.lbl_nombre.TabIndex = 5
        Me.lbl_nombre.Text = "lbl_nombre"
        '
        'lbl_fecha_comprobante
        '
        Me.lbl_fecha_comprobante.AutoSize = True
        Me.lbl_fecha_comprobante.Location = New System.Drawing.Point(347, 9)
        Me.lbl_fecha_comprobante.Name = "lbl_fecha_comprobante"
        Me.lbl_fecha_comprobante.Size = New System.Drawing.Size(109, 13)
        Me.lbl_fecha_comprobante.TabIndex = 6
        Me.lbl_fecha_comprobante.Text = "Fecha Comprobante: "
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(450, 9)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(50, 13)
        Me.lbl_fecha.TabIndex = 7
        Me.lbl_fecha.Text = "lbl_fecha"
        '
        'lbl_numero_factura
        '
        Me.lbl_numero_factura.AutoSize = True
        Me.lbl_numero_factura.Location = New System.Drawing.Point(380, 53)
        Me.lbl_numero_factura.Name = "lbl_numero_factura"
        Me.lbl_numero_factura.Size = New System.Drawing.Size(116, 13)
        Me.lbl_numero_factura.TabIndex = 8
        Me.lbl_numero_factura.Text = "Numero Comprobante: "
        '
        'lbl_factura
        '
        Me.lbl_factura.AutoSize = True
        Me.lbl_factura.Location = New System.Drawing.Point(491, 53)
        Me.lbl_factura.Name = "lbl_factura"
        Me.lbl_factura.Size = New System.Drawing.Size(56, 13)
        Me.lbl_factura.TabIndex = 9
        Me.lbl_factura.Text = "lbl_factura"
        '
        'lbl_total_cantidad
        '
        Me.lbl_total_cantidad.AutoSize = True
        Me.lbl_total_cantidad.Location = New System.Drawing.Point(12, 378)
        Me.lbl_total_cantidad.Name = "lbl_total_cantidad"
        Me.lbl_total_cantidad.Size = New System.Drawing.Size(82, 13)
        Me.lbl_total_cantidad.TabIndex = 10
        Me.lbl_total_cantidad.Text = "Total Cantidad: "
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Location = New System.Drawing.Point(86, 378)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(64, 13)
        Me.lbl_cantidad.TabIndex = 11
        Me.lbl_cantidad.Text = "lbl_cantidad"
        '
        'lbl_total_importe
        '
        Me.lbl_total_importe.AutoSize = True
        Me.lbl_total_importe.Location = New System.Drawing.Point(337, 378)
        Me.lbl_total_importe.Name = "lbl_total_importe"
        Me.lbl_total_importe.Size = New System.Drawing.Size(46, 13)
        Me.lbl_total_importe.TabIndex = 12
        Me.lbl_total_importe.Text = "Total:  $"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(383, 378)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(43, 13)
        Me.lbl_total.TabIndex = 13
        Me.lbl_total.Text = "lbl_total"
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(485, 414)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver.TabIndex = 0
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'Detalle_Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaNuevaColmena.My.Resources.Resources.panalinadoxs323
        Me.ClientSize = New System.Drawing.Size(572, 449)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_total_importe)
        Me.Controls.Add(Me.lbl_cantidad)
        Me.Controls.Add(Me.lbl_total_cantidad)
        Me.Controls.Add(Me.lbl_factura)
        Me.Controls.Add(Me.lbl_numero_factura)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.lbl_fecha_comprobante)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_razon)
        Me.Controls.Add(Me.lbl_codigo)
        Me.Controls.Add(Me.lbl_codigo_cliente)
        Me.Controls.Add(Me.dgv_detalles)
        Me.Controls.Add(Me.lbl_titulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Detalle_Factura"
        Me.Text = "Detalle de Factura"
        CType(Me.dgv_detalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents dgv_detalles As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_codigo_cliente As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo As System.Windows.Forms.Label
    Friend WithEvents lbl_razon As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha_comprobante As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_numero_factura As System.Windows.Forms.Label
    Friend WithEvents lbl_factura As System.Windows.Forms.Label
    Friend WithEvents lbl_total_cantidad As System.Windows.Forms.Label
    Friend WithEvents lbl_cantidad As System.Windows.Forms.Label
    Friend WithEvents lbl_total_importe As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents codigo_producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
