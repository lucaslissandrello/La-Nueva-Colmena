<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recibo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recibo))
        Me.dgv_facturas = New System.Windows.Forms.DataGridView()
        Me.abonar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbo_cliente = New System.Windows.Forms.ComboBox()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.lbl_recibo = New System.Windows.Forms.Label()
        Me.lbl_numero_factura = New System.Windows.Forms.Label()
        Me.lbl_fecha_comprobante = New System.Windows.Forms.Label()
        Me.lbl_razon = New System.Windows.Forms.Label()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.lbl_codigo_cliente = New System.Windows.Forms.Label()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_facturas = New System.Windows.Forms.Label()
        Me.lbl_total_facturas = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_monto = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.txt_montoM = New System.Windows.Forms.TextBox()
        CType(Me.dgv_facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_facturas
        '
        Me.dgv_facturas.AllowUserToAddRows = False
        Me.dgv_facturas.AllowUserToDeleteRows = False
        Me.dgv_facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_facturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.abonar, Me.nro_comprobante, Me.fecha, Me.total, Me.saldo})
        Me.dgv_facturas.Location = New System.Drawing.Point(12, 92)
        Me.dgv_facturas.Name = "dgv_facturas"
        Me.dgv_facturas.ReadOnly = True
        Me.dgv_facturas.Size = New System.Drawing.Size(593, 290)
        Me.dgv_facturas.TabIndex = 2
        '
        'abonar
        '
        Me.abonar.HeaderText = "Abonar"
        Me.abonar.Name = "abonar"
        Me.abonar.ReadOnly = True
        Me.abonar.Width = 50
        '
        'nro_comprobante
        '
        Me.nro_comprobante.HeaderText = "Número Comprobante"
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
        'cbo_cliente
        '
        Me.cbo_cliente.FormattingEnabled = True
        Me.cbo_cliente.Location = New System.Drawing.Point(254, 50)
        Me.cbo_cliente.Name = "cbo_cliente"
        Me.cbo_cliente.Size = New System.Drawing.Size(138, 21)
        Me.cbo_cliente.TabIndex = 1
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Location = New System.Drawing.Point(406, 9)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(200, 20)
        Me.dtp_fecha.TabIndex = 0
        '
        'lbl_recibo
        '
        Me.lbl_recibo.AutoSize = True
        Me.lbl_recibo.Location = New System.Drawing.Point(540, 53)
        Me.lbl_recibo.Name = "lbl_recibo"
        Me.lbl_recibo.Size = New System.Drawing.Size(52, 13)
        Me.lbl_recibo.TabIndex = 38
        Me.lbl_recibo.Text = "lbl_recibo"
        '
        'lbl_numero_factura
        '
        Me.lbl_numero_factura.AutoSize = True
        Me.lbl_numero_factura.Location = New System.Drawing.Point(429, 53)
        Me.lbl_numero_factura.Name = "lbl_numero_factura"
        Me.lbl_numero_factura.Size = New System.Drawing.Size(116, 13)
        Me.lbl_numero_factura.TabIndex = 37
        Me.lbl_numero_factura.Text = "Numero Comprobante: "
        '
        'lbl_fecha_comprobante
        '
        Me.lbl_fecha_comprobante.AutoSize = True
        Me.lbl_fecha_comprobante.Location = New System.Drawing.Point(295, 12)
        Me.lbl_fecha_comprobante.Name = "lbl_fecha_comprobante"
        Me.lbl_fecha_comprobante.Size = New System.Drawing.Size(109, 13)
        Me.lbl_fecha_comprobante.TabIndex = 36
        Me.lbl_fecha_comprobante.Text = "Fecha Comprobante: "
        '
        'lbl_razon
        '
        Me.lbl_razon.AutoSize = True
        Me.lbl_razon.Location = New System.Drawing.Point(172, 53)
        Me.lbl_razon.Name = "lbl_razon"
        Me.lbl_razon.Size = New System.Drawing.Size(76, 13)
        Me.lbl_razon.TabIndex = 35
        Me.lbl_razon.Text = "Razon Social: "
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Location = New System.Drawing.Point(89, 53)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(55, 13)
        Me.lbl_codigo.TabIndex = 34
        Me.lbl_codigo.Text = "lbl_codigo"
        '
        'lbl_codigo_cliente
        '
        Me.lbl_codigo_cliente.AutoSize = True
        Me.lbl_codigo_cliente.Location = New System.Drawing.Point(12, 53)
        Me.lbl_codigo_cliente.Name = "lbl_codigo_cliente"
        Me.lbl_codigo_cliente.Size = New System.Drawing.Size(81, 13)
        Me.lbl_codigo_cliente.TabIndex = 33
        Me.lbl_codigo_cliente.Text = "Codigo Cliente: "
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(6, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(261, 31)
        Me.lbl_titulo.TabIndex = 32
        Me.lbl_titulo.Text = "La Nueva Colmena"
        '
        'lbl_facturas
        '
        Me.lbl_facturas.AutoSize = True
        Me.lbl_facturas.Location = New System.Drawing.Point(9, 76)
        Me.lbl_facturas.Name = "lbl_facturas"
        Me.lbl_facturas.Size = New System.Drawing.Size(102, 13)
        Me.lbl_facturas.TabIndex = 41
        Me.lbl_facturas.Text = "Facturas del cliente:"
        '
        'lbl_total_facturas
        '
        Me.lbl_total_facturas.AutoSize = True
        Me.lbl_total_facturas.Location = New System.Drawing.Point(12, 394)
        Me.lbl_total_facturas.Name = "lbl_total_facturas"
        Me.lbl_total_facturas.Size = New System.Drawing.Size(84, 13)
        Me.lbl_total_facturas.TabIndex = 42
        Me.lbl_total_facturas.Text = "Total facturas: $"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(93, 394)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(43, 13)
        Me.lbl_total.TabIndex = 43
        Me.lbl_total.Text = "lbl_total"
        '
        'lbl_monto
        '
        Me.lbl_monto.AutoSize = True
        Me.lbl_monto.Location = New System.Drawing.Point(157, 394)
        Me.lbl_monto.Name = "lbl_monto"
        Me.lbl_monto.Size = New System.Drawing.Size(85, 13)
        Me.lbl_monto.TabIndex = 45
        Me.lbl_monto.Text = "Monto a abonar:"
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(306, 389)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(94, 23)
        Me.btn_guardar.TabIndex = 3
        Me.btn_guardar.Text = "Guardar Recibo"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Location = New System.Drawing.Point(157, 76)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(295, 13)
        Me.lbl_mensaje.TabIndex = 48
        Me.lbl_mensaje.Text = "[Para de/seleccionar una factura haga doble click sobre ella]"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(406, 388)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 4
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'txt_montoM
        '
        Me.txt_montoM.Location = New System.Drawing.Point(248, 390)
        Me.txt_montoM.Name = "txt_montoM"
        Me.txt_montoM.Size = New System.Drawing.Size(52, 20)
        Me.txt_montoM.TabIndex = 2
        '
        'Recibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaNuevaColmena.My.Resources.Resources.panalinadoxs323
        Me.ClientSize = New System.Drawing.Size(617, 416)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.txt_montoM)
        Me.Controls.Add(Me.lbl_monto)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_total_facturas)
        Me.Controls.Add(Me.lbl_facturas)
        Me.Controls.Add(Me.cbo_cliente)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.lbl_recibo)
        Me.Controls.Add(Me.lbl_numero_factura)
        Me.Controls.Add(Me.lbl_fecha_comprobante)
        Me.Controls.Add(Me.lbl_razon)
        Me.Controls.Add(Me.lbl_codigo)
        Me.Controls.Add(Me.lbl_codigo_cliente)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.dgv_facturas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Recibo"
        Me.Text = "Recibo"
        CType(Me.dgv_facturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_facturas As System.Windows.Forms.DataGridView
    Friend WithEvents cbo_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_recibo As System.Windows.Forms.Label
    Friend WithEvents lbl_numero_factura As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha_comprobante As System.Windows.Forms.Label
    Friend WithEvents lbl_razon As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo_cliente As System.Windows.Forms.Label
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents lbl_facturas As System.Windows.Forms.Label
    Friend WithEvents lbl_total_facturas As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents lbl_monto As System.Windows.Forms.Label
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents lbl_mensaje As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents abonar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_comprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_montoM As System.Windows.Forms.TextBox
End Class
