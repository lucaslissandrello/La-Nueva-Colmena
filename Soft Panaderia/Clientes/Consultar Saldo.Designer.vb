<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultar_Saldo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consultar_Saldo))
        Me.dgv_consultarSaldo = New System.Windows.Forms.DataGridView()
        Me.cbo_cliente = New System.Windows.Forms.ComboBox()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_consultarSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_consultarSaldo
        '
        Me.dgv_consultarSaldo.AllowUserToAddRows = False
        Me.dgv_consultarSaldo.AllowUserToDeleteRows = False
        Me.dgv_consultarSaldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_consultarSaldo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha, Me.nro_comprobante, Me.debe, Me.haber, Me.saldo})
        Me.dgv_consultarSaldo.Location = New System.Drawing.Point(13, 13)
        Me.dgv_consultarSaldo.Name = "dgv_consultarSaldo"
        Me.dgv_consultarSaldo.ReadOnly = True
        Me.dgv_consultarSaldo.Size = New System.Drawing.Size(513, 347)
        Me.dgv_consultarSaldo.TabIndex = 0
        '
        'cbo_cliente
        '
        Me.cbo_cliente.FormattingEnabled = True
        Me.cbo_cliente.Location = New System.Drawing.Point(61, 366)
        Me.cbo_cliente.Name = "cbo_cliente"
        Me.cbo_cliente.Size = New System.Drawing.Size(121, 21)
        Me.cbo_cliente.TabIndex = 0
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.Location = New System.Drawing.Point(13, 370)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(42, 13)
        Me.lbl_cliente.TabIndex = 2
        Me.lbl_cliente.Text = "Cliente:"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(387, 370)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(34, 13)
        Me.lbl_total.TabIndex = 3
        Me.lbl_total.Text = "Total:"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(426, 366)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(100, 20)
        Me.txt_total.TabIndex = 1
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(451, 392)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver.TabIndex = 2
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'nro_comprobante
        '
        Me.nro_comprobante.HeaderText = "Nro Comprobante"
        Me.nro_comprobante.Name = "nro_comprobante"
        Me.nro_comprobante.ReadOnly = True
        '
        'debe
        '
        Me.debe.HeaderText = "Debe"
        Me.debe.Name = "debe"
        Me.debe.ReadOnly = True
        '
        'haber
        '
        Me.haber.HeaderText = "Haber"
        Me.haber.Name = "haber"
        Me.haber.ReadOnly = True
        '
        'saldo
        '
        Me.saldo.HeaderText = "Saldo"
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        '
        'Consultar_Saldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaNuevaColmena.My.Resources.Resources.panalinado1
        Me.ClientSize = New System.Drawing.Size(539, 421)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_cliente)
        Me.Controls.Add(Me.cbo_cliente)
        Me.Controls.Add(Me.dgv_consultarSaldo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Consultar_Saldo"
        Me.Text = "Consultar Saldo"
        CType(Me.dgv_consultarSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_consultarSaldo As System.Windows.Forms.DataGridView
    Friend WithEvents cbo_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_cliente As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents nro_comprobante As DataGridViewTextBoxColumn
    Friend WithEvents debe As DataGridViewTextBoxColumn
    Friend WithEvents haber As DataGridViewTextBoxColumn
    Friend WithEvents saldo As DataGridViewTextBoxColumn
End Class
