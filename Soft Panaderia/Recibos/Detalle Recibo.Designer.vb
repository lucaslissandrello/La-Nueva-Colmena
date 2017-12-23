<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detalle_Recibo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Detalle_Recibo))
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.lbl_monto = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_total_facturas = New System.Windows.Forms.Label()
        Me.lbl_facturas = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.lbl_recibo = New System.Windows.Forms.Label()
        Me.lbl_numero_factura = New System.Windows.Forms.Label()
        Me.lbl_fecha_comprobante = New System.Windows.Forms.Label()
        Me.lbl_razon = New System.Windows.Forms.Label()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.lbl_codigo_cliente = New System.Windows.Forms.Label()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.dgv_detallesDeRecibo = New System.Windows.Forms.DataGridView()
        Me.lbl_MontoAbonado = New System.Windows.Forms.Label()
        Me.lbl_razonSocial = New System.Windows.Forms.Label()
        Me.nro_comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_detallesDeRecibo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(537, 378)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 0
        Me.btn_cancelar.Text = "Volver"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'lbl_monto
        '
        Me.lbl_monto.AutoSize = True
        Me.lbl_monto.Location = New System.Drawing.Point(163, 383)
        Me.lbl_monto.Name = "lbl_monto"
        Me.lbl_monto.Size = New System.Drawing.Size(97, 13)
        Me.lbl_monto.TabIndex = 64
        Me.lbl_monto.Text = "Monto  abonado: $"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(104, 383)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(43, 13)
        Me.lbl_total.TabIndex = 62
        Me.lbl_total.Text = "lbl_total"
        '
        'lbl_total_facturas
        '
        Me.lbl_total_facturas.AutoSize = True
        Me.lbl_total_facturas.Location = New System.Drawing.Point(14, 383)
        Me.lbl_total_facturas.Name = "lbl_total_facturas"
        Me.lbl_total_facturas.Size = New System.Drawing.Size(84, 13)
        Me.lbl_total_facturas.TabIndex = 61
        Me.lbl_total_facturas.Text = "Total facturas: $"
        '
        'lbl_facturas
        '
        Me.lbl_facturas.AutoSize = True
        Me.lbl_facturas.Location = New System.Drawing.Point(15, 76)
        Me.lbl_facturas.Name = "lbl_facturas"
        Me.lbl_facturas.Size = New System.Drawing.Size(102, 13)
        Me.lbl_facturas.TabIndex = 60
        Me.lbl_facturas.Text = "Facturas del cliente:"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Location = New System.Drawing.Point(412, 9)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(200, 20)
        Me.dtp_fecha.TabIndex = 58
        '
        'lbl_recibo
        '
        Me.lbl_recibo.AutoSize = True
        Me.lbl_recibo.Location = New System.Drawing.Point(546, 53)
        Me.lbl_recibo.Name = "lbl_recibo"
        Me.lbl_recibo.Size = New System.Drawing.Size(52, 13)
        Me.lbl_recibo.TabIndex = 57
        Me.lbl_recibo.Text = "lbl_recibo"
        '
        'lbl_numero_factura
        '
        Me.lbl_numero_factura.AutoSize = True
        Me.lbl_numero_factura.Location = New System.Drawing.Point(435, 53)
        Me.lbl_numero_factura.Name = "lbl_numero_factura"
        Me.lbl_numero_factura.Size = New System.Drawing.Size(87, 13)
        Me.lbl_numero_factura.TabIndex = 56
        Me.lbl_numero_factura.Text = "Número Recibo: "
        '
        'lbl_fecha_comprobante
        '
        Me.lbl_fecha_comprobante.AutoSize = True
        Me.lbl_fecha_comprobante.Location = New System.Drawing.Point(307, 12)
        Me.lbl_fecha_comprobante.Name = "lbl_fecha_comprobante"
        Me.lbl_fecha_comprobante.Size = New System.Drawing.Size(109, 13)
        Me.lbl_fecha_comprobante.TabIndex = 55
        Me.lbl_fecha_comprobante.Text = "Fecha Comprobante: "
        '
        'lbl_razon
        '
        Me.lbl_razon.AutoSize = True
        Me.lbl_razon.Location = New System.Drawing.Point(178, 53)
        Me.lbl_razon.Name = "lbl_razon"
        Me.lbl_razon.Size = New System.Drawing.Size(76, 13)
        Me.lbl_razon.TabIndex = 54
        Me.lbl_razon.Text = "Razon Social: "
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Location = New System.Drawing.Point(95, 53)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(55, 13)
        Me.lbl_codigo.TabIndex = 53
        Me.lbl_codigo.Text = "lbl_codigo"
        '
        'lbl_codigo_cliente
        '
        Me.lbl_codigo_cliente.AutoSize = True
        Me.lbl_codigo_cliente.Location = New System.Drawing.Point(18, 53)
        Me.lbl_codigo_cliente.Name = "lbl_codigo_cliente"
        Me.lbl_codigo_cliente.Size = New System.Drawing.Size(81, 13)
        Me.lbl_codigo_cliente.TabIndex = 52
        Me.lbl_codigo_cliente.Text = "Codigo Cliente: "
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(12, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(261, 31)
        Me.lbl_titulo.TabIndex = 51
        Me.lbl_titulo.Text = "La Nueva Colmena"
        '
        'dgv_detallesDeRecibo
        '
        Me.dgv_detallesDeRecibo.AllowUserToAddRows = False
        Me.dgv_detallesDeRecibo.AllowUserToDeleteRows = False
        Me.dgv_detallesDeRecibo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detallesDeRecibo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nro_comprobante, Me.fecha, Me.total, Me.saldo})
        Me.dgv_detallesDeRecibo.Location = New System.Drawing.Point(18, 92)
        Me.dgv_detallesDeRecibo.Name = "dgv_detallesDeRecibo"
        Me.dgv_detallesDeRecibo.ReadOnly = True
        Me.dgv_detallesDeRecibo.Size = New System.Drawing.Size(593, 277)
        Me.dgv_detallesDeRecibo.TabIndex = 50
        '
        'lbl_MontoAbonado
        '
        Me.lbl_MontoAbonado.AutoSize = True
        Me.lbl_MontoAbonado.Location = New System.Drawing.Point(257, 383)
        Me.lbl_MontoAbonado.Name = "lbl_MontoAbonado"
        Me.lbl_MontoAbonado.Size = New System.Drawing.Size(96, 13)
        Me.lbl_MontoAbonado.TabIndex = 69
        Me.lbl_MontoAbonado.Text = "lbl_MontoAbonado"
        '
        'lbl_razonSocial
        '
        Me.lbl_razonSocial.AutoSize = True
        Me.lbl_razonSocial.Location = New System.Drawing.Point(260, 53)
        Me.lbl_razonSocial.Name = "lbl_razonSocial"
        Me.lbl_razonSocial.Size = New System.Drawing.Size(78, 13)
        Me.lbl_razonSocial.TabIndex = 70
        Me.lbl_razonSocial.Text = "lbl_razonSocial"
        '
        'nro_comprobante
        '
        Me.nro_comprobante.HeaderText = "Número Factura"
        Me.nro_comprobante.Name = "nro_comprobante"
        Me.nro_comprobante.ReadOnly = True
        Me.nro_comprobante.Width = 200
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "Total $"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'saldo
        '
        Me.saldo.HeaderText = "Saldo $"
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        '
        'Detalle_Recibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaNuevaColmena.My.Resources.Resources.panalinadoxs323
        Me.ClientSize = New System.Drawing.Size(624, 414)
        Me.Controls.Add(Me.lbl_razonSocial)
        Me.Controls.Add(Me.lbl_MontoAbonado)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.lbl_monto)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_total_facturas)
        Me.Controls.Add(Me.lbl_facturas)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.lbl_recibo)
        Me.Controls.Add(Me.lbl_numero_factura)
        Me.Controls.Add(Me.lbl_fecha_comprobante)
        Me.Controls.Add(Me.lbl_razon)
        Me.Controls.Add(Me.lbl_codigo)
        Me.Controls.Add(Me.lbl_codigo_cliente)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.dgv_detallesDeRecibo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Detalle_Recibo"
        Me.Text = "Detalle Recibo"
        CType(Me.dgv_detallesDeRecibo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_monto As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents lbl_total_facturas As System.Windows.Forms.Label
    Friend WithEvents lbl_facturas As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_recibo As System.Windows.Forms.Label
    Friend WithEvents lbl_numero_factura As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha_comprobante As System.Windows.Forms.Label
    Friend WithEvents lbl_razon As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo_cliente As System.Windows.Forms.Label
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents dgv_detallesDeRecibo As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_MontoAbonado As System.Windows.Forms.Label
    Friend WithEvents lbl_razonSocial As System.Windows.Forms.Label
    Friend WithEvents nro_comprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents saldo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
