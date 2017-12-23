<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recibos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recibos))
        Me.gb_ordenar = New System.Windows.Forms.GroupBox()
        Me.rb_cliente = New System.Windows.Forms.RadioButton()
        Me.rb_numero = New System.Windows.Forms.RadioButton()
        Me.rb_fecha = New System.Windows.Forms.RadioButton()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_imprimir = New System.Windows.Forms.Button()
        Me.btn_ver = New System.Windows.Forms.Button()
        Me.btn_mostrar_todos = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.dgv_recibos = New System.Windows.Forms.DataGridView()
        Me.cod_recibo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gb_ordenar.SuspendLayout()
        CType(Me.dgv_recibos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_ordenar
        '
        Me.gb_ordenar.Controls.Add(Me.rb_cliente)
        Me.gb_ordenar.Controls.Add(Me.rb_numero)
        Me.gb_ordenar.Controls.Add(Me.rb_fecha)
        Me.gb_ordenar.Location = New System.Drawing.Point(564, 161)
        Me.gb_ordenar.Name = "gb_ordenar"
        Me.gb_ordenar.Size = New System.Drawing.Size(110, 94)
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
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(564, 261)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(89, 23)
        Me.btn_volver.TabIndex = 8
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(564, 132)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(98, 23)
        Me.btn_cancelar.TabIndex = 6
        Me.btn_cancelar.Text = "Cancelar Recibo"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(564, 102)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(98, 23)
        Me.btn_nuevo.TabIndex = 5
        Me.btn_nuevo.Text = "Nuevo Recibo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Location = New System.Drawing.Point(564, 72)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(98, 23)
        Me.btn_imprimir.TabIndex = 4
        Me.btn_imprimir.Text = "Imprimir Recibo"
        Me.btn_imprimir.UseVisualStyleBackColor = True
        '
        'btn_ver
        '
        Me.btn_ver.Location = New System.Drawing.Point(564, 42)
        Me.btn_ver.Name = "btn_ver"
        Me.btn_ver.Size = New System.Drawing.Size(98, 23)
        Me.btn_ver.TabIndex = 3
        Me.btn_ver.Text = "Ver Recibo"
        Me.btn_ver.UseVisualStyleBackColor = True
        '
        'btn_mostrar_todos
        '
        Me.btn_mostrar_todos.Location = New System.Drawing.Point(244, 10)
        Me.btn_mostrar_todos.Name = "btn_mostrar_todos"
        Me.btn_mostrar_todos.Size = New System.Drawing.Size(100, 23)
        Me.btn_mostrar_todos.TabIndex = 2
        Me.btn_mostrar_todos.Text = "Mostrar Todos"
        Me.btn_mostrar_todos.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(163, 10)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 1
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(12, 12)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(145, 20)
        Me.txt_buscar.TabIndex = 0
        Me.txt_buscar.Text = "Buscar cliente..."
        '
        'dgv_recibos
        '
        Me.dgv_recibos.AllowUserToAddRows = False
        Me.dgv_recibos.AllowUserToDeleteRows = False
        Me.dgv_recibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_recibos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_recibo, Me.fecha, Me.cliente, Me.monto, Me.id_cliente, Me.tipo})
        Me.dgv_recibos.Location = New System.Drawing.Point(12, 42)
        Me.dgv_recibos.Name = "dgv_recibos"
        Me.dgv_recibos.ReadOnly = True
        Me.dgv_recibos.Size = New System.Drawing.Size(545, 326)
        Me.dgv_recibos.TabIndex = 11
        '
        'cod_recibo
        '
        Me.cod_recibo.HeaderText = "Nro de Recibo"
        Me.cod_recibo.Name = "cod_recibo"
        Me.cod_recibo.ReadOnly = True
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
        'monto
        '
        Me.monto.HeaderText = "Monto $"
        Me.monto.Name = "monto"
        Me.monto.ReadOnly = True
        '
        'id_cliente
        '
        Me.id_cliente.HeaderText = "id_cliente"
        Me.id_cliente.Name = "id_cliente"
        Me.id_cliente.ReadOnly = True
        Me.id_cliente.Visible = False
        '
        'tipo
        '
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        '
        'Recibos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaNuevaColmena.My.Resources.Resources.panalinado1
        Me.ClientSize = New System.Drawing.Size(686, 385)
        Me.Controls.Add(Me.gb_ordenar)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.btn_ver)
        Me.Controls.Add(Me.btn_mostrar_todos)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.dgv_recibos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Recibos"
        Me.Text = "Recibo"
        Me.gb_ordenar.ResumeLayout(False)
        Me.gb_ordenar.PerformLayout()
        CType(Me.dgv_recibos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gb_ordenar As System.Windows.Forms.GroupBox
    Friend WithEvents rb_numero As System.Windows.Forms.RadioButton
    Friend WithEvents rb_fecha As System.Windows.Forms.RadioButton
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents btn_ver As System.Windows.Forms.Button
    Friend WithEvents btn_mostrar_todos As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents dgv_recibos As System.Windows.Forms.DataGridView
    Friend WithEvents cod_recibo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rb_cliente As System.Windows.Forms.RadioButton
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
