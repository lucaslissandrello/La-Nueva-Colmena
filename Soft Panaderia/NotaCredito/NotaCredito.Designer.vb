<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotaCredito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotaCredito))
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.cbo_cliente = New System.Windows.Forms.ComboBox()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_total_importe = New System.Windows.Forms.Label()
        Me.lbl_cantidad_total = New System.Windows.Forms.Label()
        Me.lbl_total_cantidad = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_numero_factura = New System.Windows.Forms.Label()
        Me.lbl_fecha_comprobante = New System.Windows.Forms.Label()
        Me.lbl_razon = New System.Windows.Forms.Label()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.lbl_codigo_cliente = New System.Windows.Forms.Label()
        Me.dgv_detalles = New System.Windows.Forms.DataGridView()
        Me.codigo_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.cbo_factura = New System.Windows.Forms.ComboBox()
        Me.txt_cod = New System.Windows.Forms.Label()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.lbl_producto = New System.Windows.Forms.Label()
        Me.cbo_producto = New System.Windows.Forms.ComboBox()
        Me.chk_comprobantes = New System.Windows.Forms.CheckBox()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        CType(Me.dgv_detalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(412, 435)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(140, 23)
        Me.btn_guardar.TabIndex = 51
        Me.btn_guardar.Text = "Guardar Nota de Credito"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'cbo_cliente
        '
        Me.cbo_cliente.FormattingEnabled = True
        Me.cbo_cliente.Location = New System.Drawing.Point(260, 50)
        Me.cbo_cliente.Name = "cbo_cliente"
        Me.cbo_cliente.Size = New System.Drawing.Size(138, 21)
        Me.cbo_cliente.TabIndex = 45
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Location = New System.Drawing.Point(412, 9)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(200, 20)
        Me.dtp_fecha.TabIndex = 44
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(558, 435)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver.TabIndex = 52
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(607, 411)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(13, 13)
        Me.lbl_total.TabIndex = 65
        Me.lbl_total.Text = "0"
        '
        'lbl_total_importe
        '
        Me.lbl_total_importe.AutoSize = True
        Me.lbl_total_importe.Location = New System.Drawing.Point(561, 411)
        Me.lbl_total_importe.Name = "lbl_total_importe"
        Me.lbl_total_importe.Size = New System.Drawing.Size(49, 13)
        Me.lbl_total_importe.TabIndex = 64
        Me.lbl_total_importe.Text = "Total:  $-"
        '
        'lbl_cantidad_total
        '
        Me.lbl_cantidad_total.AutoSize = True
        Me.lbl_cantidad_total.Location = New System.Drawing.Point(89, 411)
        Me.lbl_cantidad_total.Name = "lbl_cantidad_total"
        Me.lbl_cantidad_total.Size = New System.Drawing.Size(13, 13)
        Me.lbl_cantidad_total.TabIndex = 63
        Me.lbl_cantidad_total.Text = "0"
        '
        'lbl_total_cantidad
        '
        Me.lbl_total_cantidad.AutoSize = True
        Me.lbl_total_cantidad.Location = New System.Drawing.Point(15, 411)
        Me.lbl_total_cantidad.Name = "lbl_total_cantidad"
        Me.lbl_total_cantidad.Size = New System.Drawing.Size(82, 13)
        Me.lbl_total_cantidad.TabIndex = 62
        Me.lbl_total_cantidad.Text = "Total Cantidad: "
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(546, 53)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(56, 13)
        Me.lbl_id.TabIndex = 61
        Me.lbl_id.Text = "lbl_factura"
        '
        'lbl_numero_factura
        '
        Me.lbl_numero_factura.AutoSize = True
        Me.lbl_numero_factura.Location = New System.Drawing.Point(435, 53)
        Me.lbl_numero_factura.Name = "lbl_numero_factura"
        Me.lbl_numero_factura.Size = New System.Drawing.Size(116, 13)
        Me.lbl_numero_factura.TabIndex = 60
        Me.lbl_numero_factura.Text = "Numero Comprobante: "
        '
        'lbl_fecha_comprobante
        '
        Me.lbl_fecha_comprobante.AutoSize = True
        Me.lbl_fecha_comprobante.Location = New System.Drawing.Point(307, 12)
        Me.lbl_fecha_comprobante.Name = "lbl_fecha_comprobante"
        Me.lbl_fecha_comprobante.Size = New System.Drawing.Size(109, 13)
        Me.lbl_fecha_comprobante.TabIndex = 59
        Me.lbl_fecha_comprobante.Text = "Fecha Comprobante: "
        '
        'lbl_razon
        '
        Me.lbl_razon.AutoSize = True
        Me.lbl_razon.Location = New System.Drawing.Point(178, 53)
        Me.lbl_razon.Name = "lbl_razon"
        Me.lbl_razon.Size = New System.Drawing.Size(76, 13)
        Me.lbl_razon.TabIndex = 58
        Me.lbl_razon.Text = "Razon Social: "
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Location = New System.Drawing.Point(89, 53)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(55, 13)
        Me.lbl_codigo.TabIndex = 57
        Me.lbl_codigo.Text = "lbl_codigo"
        '
        'lbl_codigo_cliente
        '
        Me.lbl_codigo_cliente.AutoSize = True
        Me.lbl_codigo_cliente.Location = New System.Drawing.Point(15, 53)
        Me.lbl_codigo_cliente.Name = "lbl_codigo_cliente"
        Me.lbl_codigo_cliente.Size = New System.Drawing.Size(81, 13)
        Me.lbl_codigo_cliente.TabIndex = 56
        Me.lbl_codigo_cliente.Text = "Codigo Cliente: "
        '
        'dgv_detalles
        '
        Me.dgv_detalles.AllowUserToAddRows = False
        Me.dgv_detalles.AllowUserToDeleteRows = False
        Me.dgv_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo_producto, Me.cantidad, Me.producto, Me.precio, Me.importe})
        Me.dgv_detalles.Location = New System.Drawing.Point(15, 105)
        Me.dgv_detalles.Name = "dgv_detalles"
        Me.dgv_detalles.ReadOnly = True
        Me.dgv_detalles.Size = New System.Drawing.Size(618, 274)
        Me.dgv_detalles.TabIndex = 55
        '
        'codigo_producto
        '
        Me.codigo_producto.HeaderText = "Codigo Producto"
        Me.codigo_producto.Name = "codigo_producto"
        Me.codigo_producto.ReadOnly = True
        Me.codigo_producto.Visible = False
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'producto
        '
        Me.producto.HeaderText = "Detalle"
        Me.producto.Name = "producto"
        Me.producto.ReadOnly = True
        '
        'precio
        '
        Me.precio.HeaderText = "Precio Unitario $"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'importe
        '
        Me.importe.HeaderText = "Importe $"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(12, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(261, 31)
        Me.lbl_titulo.TabIndex = 54
        Me.lbl_titulo.Text = "La Nueva Colmena"
        '
        'cbo_factura
        '
        Me.cbo_factura.FormattingEnabled = True
        Me.cbo_factura.Location = New System.Drawing.Point(150, 78)
        Me.cbo_factura.Name = "cbo_factura"
        Me.cbo_factura.Size = New System.Drawing.Size(208, 21)
        Me.cbo_factura.TabIndex = 66
        '
        'txt_cod
        '
        Me.txt_cod.AutoSize = True
        Me.txt_cod.Location = New System.Drawing.Point(118, 388)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(75, 13)
        Me.txt_cod.TabIndex = 75
        Me.txt_cod.Text = "Cod Producto:"
        '
        'btn_quitar
        '
        Me.btn_quitar.Location = New System.Drawing.Point(539, 385)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(94, 23)
        Me.btn_quitar.TabIndex = 72
        Me.btn_quitar.Text = "Quitar Producto"
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(433, 385)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(100, 23)
        Me.btn_agregar.TabIndex = 71
        Me.btn_agregar.Text = "Agregar Producto"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Location = New System.Drawing.Point(15, 388)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(52, 13)
        Me.lbl_cantidad.TabIndex = 74
        Me.lbl_cantidad.Text = "Cantidad:"
        '
        'lbl_producto
        '
        Me.lbl_producto.AutoSize = True
        Me.lbl_producto.Location = New System.Drawing.Point(244, 388)
        Me.lbl_producto.Name = "lbl_producto"
        Me.lbl_producto.Size = New System.Drawing.Size(56, 13)
        Me.lbl_producto.TabIndex = 73
        Me.lbl_producto.Text = "Producto: "
        '
        'cbo_producto
        '
        Me.cbo_producto.FormattingEnabled = True
        Me.cbo_producto.Location = New System.Drawing.Point(306, 385)
        Me.cbo_producto.Name = "cbo_producto"
        Me.cbo_producto.Size = New System.Drawing.Size(121, 21)
        Me.cbo_producto.TabIndex = 70
        '
        'chk_comprobantes
        '
        Me.chk_comprobantes.AutoSize = True
        Me.chk_comprobantes.Location = New System.Drawing.Point(14, 80)
        Me.chk_comprobantes.Name = "chk_comprobantes"
        Me.chk_comprobantes.Size = New System.Drawing.Size(130, 17)
        Me.chk_comprobantes.TabIndex = 76
        Me.chk_comprobantes.Text = "Desde comprobantes:"
        Me.chk_comprobantes.UseVisualStyleBackColor = True
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(73, 385)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(39, 20)
        Me.txt_cantidad.TabIndex = 77
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(199, 385)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(39, 20)
        Me.txt_codigo.TabIndex = 78
        '
        'NotaCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaNuevaColmena.My.Resources.Resources.panalinadoxs323
        Me.ClientSize = New System.Drawing.Size(645, 466)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.chk_comprobantes)
        Me.Controls.Add(Me.txt_cod)
        Me.Controls.Add(Me.btn_quitar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.lbl_cantidad)
        Me.Controls.Add(Me.lbl_producto)
        Me.Controls.Add(Me.cbo_producto)
        Me.Controls.Add(Me.cbo_factura)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.cbo_cliente)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_total_importe)
        Me.Controls.Add(Me.lbl_cantidad_total)
        Me.Controls.Add(Me.lbl_total_cantidad)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_numero_factura)
        Me.Controls.Add(Me.lbl_fecha_comprobante)
        Me.Controls.Add(Me.lbl_razon)
        Me.Controls.Add(Me.lbl_codigo)
        Me.Controls.Add(Me.lbl_codigo_cliente)
        Me.Controls.Add(Me.dgv_detalles)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NotaCredito"
        Me.Text = "Nota de Credito"
        CType(Me.dgv_detalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents cbo_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents lbl_total_importe As System.Windows.Forms.Label
    Friend WithEvents lbl_cantidad_total As System.Windows.Forms.Label
    Friend WithEvents lbl_total_cantidad As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents lbl_numero_factura As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha_comprobante As System.Windows.Forms.Label
    Friend WithEvents lbl_razon As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo_cliente As System.Windows.Forms.Label
    Friend WithEvents dgv_detalles As System.Windows.Forms.DataGridView
    Friend WithEvents codigo_producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents cbo_factura As System.Windows.Forms.ComboBox
    Friend WithEvents txt_cod As System.Windows.Forms.Label
    Friend WithEvents btn_quitar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents lbl_cantidad As System.Windows.Forms.Label
    Friend WithEvents lbl_producto As System.Windows.Forms.Label
    Friend WithEvents cbo_producto As System.Windows.Forms.ComboBox
    Friend WithEvents chk_comprobantes As System.Windows.Forms.CheckBox
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents txt_codigo As TextBox
End Class
