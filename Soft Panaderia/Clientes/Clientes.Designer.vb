<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.txt_buscador = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.razon_social = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_agregar_cliente = New System.Windows.Forms.Button()
        Me.btn_consultar_saldo = New System.Windows.Forms.Button()
        Me.btn_mostrar_datos = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_imprimir = New System.Windows.Forms.Button()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_buscador
        '
        Me.txt_buscador.Location = New System.Drawing.Point(12, 8)
        Me.txt_buscador.Name = "txt_buscador"
        Me.txt_buscador.Size = New System.Drawing.Size(195, 20)
        Me.txt_buscador.TabIndex = 0
        '
        'dgv_clientes
        '
        Me.dgv_clientes.AllowUserToAddRows = False
        Me.dgv_clientes.AllowUserToDeleteRows = False
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.razon_social, Me.saldo})
        Me.dgv_clientes.Location = New System.Drawing.Point(13, 35)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.ReadOnly = True
        Me.dgv_clientes.Size = New System.Drawing.Size(369, 304)
        Me.dgv_clientes.TabIndex = 7
        '
        'codigo
        '
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'razon_social
        '
        Me.razon_social.HeaderText = "Razon Social"
        Me.razon_social.Name = "razon_social"
        Me.razon_social.ReadOnly = True
        '
        'saldo
        '
        Me.saldo.HeaderText = "Saldo"
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        '
        'btn_agregar_cliente
        '
        Me.btn_agregar_cliente.Location = New System.Drawing.Point(388, 64)
        Me.btn_agregar_cliente.Name = "btn_agregar_cliente"
        Me.btn_agregar_cliente.Size = New System.Drawing.Size(104, 23)
        Me.btn_agregar_cliente.TabIndex = 4
        Me.btn_agregar_cliente.Text = "Agregar Cliente"
        Me.btn_agregar_cliente.UseVisualStyleBackColor = True
        '
        'btn_consultar_saldo
        '
        Me.btn_consultar_saldo.Location = New System.Drawing.Point(388, 35)
        Me.btn_consultar_saldo.Name = "btn_consultar_saldo"
        Me.btn_consultar_saldo.Size = New System.Drawing.Size(104, 23)
        Me.btn_consultar_saldo.TabIndex = 3
        Me.btn_consultar_saldo.Text = "Consultar Saldo"
        Me.btn_consultar_saldo.UseVisualStyleBackColor = True
        '
        'btn_mostrar_datos
        '
        Me.btn_mostrar_datos.Location = New System.Drawing.Point(388, 93)
        Me.btn_mostrar_datos.Name = "btn_mostrar_datos"
        Me.btn_mostrar_datos.Size = New System.Drawing.Size(104, 23)
        Me.btn_mostrar_datos.TabIndex = 5
        Me.btn_mostrar_datos.Text = "Mostrar Datos"
        Me.btn_mostrar_datos.UseVisualStyleBackColor = True
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(388, 151)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(104, 23)
        Me.btn_volver.TabIndex = 6
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(213, 8)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 1
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(294, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Mostrar Todos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Location = New System.Drawing.Point(389, 122)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(103, 23)
        Me.btn_imprimir.TabIndex = 8
        Me.btn_imprimir.Text = "Imprimir Saldo"
        Me.btn_imprimir.UseVisualStyleBackColor = True
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaNuevaColmena.My.Resources.Resources.panalinado1
        Me.ClientSize = New System.Drawing.Size(539, 351)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_mostrar_datos)
        Me.Controls.Add(Me.btn_consultar_saldo)
        Me.Controls.Add(Me.btn_agregar_cliente)
        Me.Controls.Add(Me.dgv_clientes)
        Me.Controls.Add(Me.txt_buscador)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Clientes"
        Me.Text = "Cliente"
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_buscador As System.Windows.Forms.TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgv_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents btn_agregar_cliente As System.Windows.Forms.Button
    Friend WithEvents btn_consultar_saldo As System.Windows.Forms.Button
    Friend WithEvents btn_mostrar_datos As System.Windows.Forms.Button
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents razon_social As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
End Class
