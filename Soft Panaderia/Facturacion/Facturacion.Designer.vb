<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturacion))
        Me.dgv_facturas = New System.Windows.Forms.DataGridView()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_mostrar_todos = New System.Windows.Forms.Button()
        Me.btn_ver = New System.Windows.Forms.Button()
        Me.btn_imprimir = New System.Windows.Forms.Button()
        Me.btn_nueva = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.gb_ordenar = New System.Windows.Forms.GroupBox()
        Me.rb_cliente = New System.Windows.Forms.RadioButton()
        Me.rb_numero = New System.Windows.Forms.RadioButton()
        Me.rb_fecha = New System.Windows.Forms.RadioButton()
        Me.btn_nota_credito = New System.Windows.Forms.Button()
        Me.cod_factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fnc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_ordenar.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_facturas
        '
        Me.dgv_facturas.AllowUserToAddRows = False
        Me.dgv_facturas.AllowUserToDeleteRows = False
        Me.dgv_facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_facturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_factura, Me.fecha, Me.cliente, Me.total, Me.id_cliente, Me.saldo, Me.fnc})
        Me.dgv_facturas.Location = New System.Drawing.Point(12, 36)
        Me.dgv_facturas.Name = "dgv_facturas"
        Me.dgv_facturas.ReadOnly = True
        Me.dgv_facturas.Size = New System.Drawing.Size(535, 326)
        Me.dgv_facturas.TabIndex = 0
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(12, 6)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(145, 20)
        Me.txt_buscar.TabIndex = 0
        Me.txt_buscar.Text = "Buscar cliente..."
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(163, 4)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 1
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_mostrar_todos
        '
        Me.btn_mostrar_todos.Location = New System.Drawing.Point(244, 4)
        Me.btn_mostrar_todos.Name = "btn_mostrar_todos"
        Me.btn_mostrar_todos.Size = New System.Drawing.Size(100, 23)
        Me.btn_mostrar_todos.TabIndex = 2
        Me.btn_mostrar_todos.Text = "Mostrar Todos"
        Me.btn_mostrar_todos.UseVisualStyleBackColor = True
        '
        'btn_ver
        '
        Me.btn_ver.Location = New System.Drawing.Point(553, 36)
        Me.btn_ver.Name = "btn_ver"
        Me.btn_ver.Size = New System.Drawing.Size(118, 23)
        Me.btn_ver.TabIndex = 3
        Me.btn_ver.Text = "Ver Comprobante"
        Me.btn_ver.UseVisualStyleBackColor = True
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Location = New System.Drawing.Point(553, 66)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(118, 23)
        Me.btn_imprimir.TabIndex = 4
        Me.btn_imprimir.Text = "Imprimir Comprobante"
        Me.btn_imprimir.UseVisualStyleBackColor = True
        '
        'btn_nueva
        '
        Me.btn_nueva.Location = New System.Drawing.Point(553, 96)
        Me.btn_nueva.Name = "btn_nueva"
        Me.btn_nueva.Size = New System.Drawing.Size(118, 23)
        Me.btn_nueva.TabIndex = 5
        Me.btn_nueva.Text = "Nueva Factura"
        Me.btn_nueva.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(553, 154)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(118, 23)
        Me.btn_cancelar.TabIndex = 6
        Me.btn_cancelar.Text = "Cancelar Factura"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(553, 282)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(118, 23)
        Me.btn_volver.TabIndex = 8
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'gb_ordenar
        '
        Me.gb_ordenar.Controls.Add(Me.rb_cliente)
        Me.gb_ordenar.Controls.Add(Me.rb_numero)
        Me.gb_ordenar.Controls.Add(Me.rb_fecha)
        Me.gb_ordenar.Location = New System.Drawing.Point(553, 183)
        Me.gb_ordenar.Name = "gb_ordenar"
        Me.gb_ordenar.Size = New System.Drawing.Size(118, 93)
        Me.gb_ordenar.TabIndex = 7
        Me.gb_ordenar.TabStop = False
        Me.gb_ordenar.Text = "Ordenar"
        '
        'rb_cliente
        '
        Me.rb_cliente.AutoSize = True
        Me.rb_cliente.Location = New System.Drawing.Point(7, 68)
        Me.rb_cliente.Name = "rb_cliente"
        Me.rb_cliente.Size = New System.Drawing.Size(76, 17)
        Me.rb_cliente.TabIndex = 2
        Me.rb_cliente.TabStop = True
        Me.rb_cliente.Text = "Por Cliente"
        Me.rb_cliente.UseVisualStyleBackColor = True
        '
        'rb_numero
        '
        Me.rb_numero.AutoSize = True
        Me.rb_numero.Location = New System.Drawing.Point(7, 44)
        Me.rb_numero.Name = "rb_numero"
        Me.rb_numero.Size = New System.Drawing.Size(81, 17)
        Me.rb_numero.TabIndex = 1
        Me.rb_numero.TabStop = True
        Me.rb_numero.Text = "Por Número"
        Me.rb_numero.UseVisualStyleBackColor = True
        '
        'rb_fecha
        '
        Me.rb_fecha.AutoSize = True
        Me.rb_fecha.Location = New System.Drawing.Point(7, 20)
        Me.rb_fecha.Name = "rb_fecha"
        Me.rb_fecha.Size = New System.Drawing.Size(74, 17)
        Me.rb_fecha.TabIndex = 0
        Me.rb_fecha.TabStop = True
        Me.rb_fecha.Text = "Por Fecha"
        Me.rb_fecha.UseVisualStyleBackColor = True
        '
        'btn_nota_credito
        '
        Me.btn_nota_credito.Location = New System.Drawing.Point(553, 125)
        Me.btn_nota_credito.Name = "btn_nota_credito"
        Me.btn_nota_credito.Size = New System.Drawing.Size(118, 23)
        Me.btn_nota_credito.TabIndex = 9
        Me.btn_nota_credito.Text = "Nueva N. Credito"
        Me.btn_nota_credito.UseVisualStyleBackColor = True
        '
        'cod_factura
        '
        Me.cod_factura.HeaderText = "Nro de Comprobante"
        Me.cod_factura.Name = "cod_factura"
        Me.cod_factura.ReadOnly = True
        Me.cod_factura.Width = 90
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'cliente
        '
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "Total $"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 75
        '
        'id_cliente
        '
        Me.id_cliente.HeaderText = "id_cliente"
        Me.id_cliente.Name = "id_cliente"
        Me.id_cliente.ReadOnly = True
        Me.id_cliente.Visible = False
        '
        'saldo
        '
        Me.saldo.HeaderText = "Deuda $"
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        Me.saldo.Width = 75
        '
        'fnc
        '
        Me.fnc.HeaderText = "F/NC"
        Me.fnc.Name = "fnc"
        Me.fnc.ReadOnly = True
        Me.fnc.Width = 40
        '
        'Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaNuevaColmena.My.Resources.Resources.panalinadoxs323
        Me.ClientSize = New System.Drawing.Size(675, 378)
        Me.Controls.Add(Me.btn_nota_credito)
        Me.Controls.Add(Me.gb_ordenar)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_nueva)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.btn_ver)
        Me.Controls.Add(Me.btn_mostrar_todos)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.dgv_facturas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Facturacion"
        Me.Text = "Facturación"
        CType(Me.dgv_facturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_ordenar.ResumeLayout(False)
        Me.gb_ordenar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_facturas As System.Windows.Forms.DataGridView
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_mostrar_todos As System.Windows.Forms.Button
    Friend WithEvents btn_ver As System.Windows.Forms.Button
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents btn_nueva As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents gb_ordenar As System.Windows.Forms.GroupBox
    Friend WithEvents rb_numero As System.Windows.Forms.RadioButton
    Friend WithEvents rb_fecha As System.Windows.Forms.RadioButton
    Friend WithEvents rb_cliente As System.Windows.Forms.RadioButton
    Friend WithEvents btn_nota_credito As System.Windows.Forms.Button
    Friend WithEvents cod_factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fnc As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
