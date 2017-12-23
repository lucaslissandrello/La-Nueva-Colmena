<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.btn_factura = New System.Windows.Forms.Button()
        Me.btn_clientes = New System.Windows.Forms.Button()
        Me.btn_precios = New System.Windows.Forms.Button()
        Me.btn_backup = New System.Windows.Forms.Button()
        Me.dialogo = New System.Windows.Forms.SaveFileDialog()
        Me.btn_cargarBD = New System.Windows.Forms.Button()
        Me.dialogo_abrir = New System.Windows.Forms.OpenFileDialog()
        Me.btn_recibos = New System.Windows.Forms.Button()
        Me.btn_ListaPrecios = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_factura
        '
        Me.btn_factura.Location = New System.Drawing.Point(12, 29)
        Me.btn_factura.Name = "btn_factura"
        Me.btn_factura.Size = New System.Drawing.Size(89, 37)
        Me.btn_factura.TabIndex = 0
        Me.btn_factura.Text = "Facturacion"
        Me.btn_factura.UseVisualStyleBackColor = True
        '
        'btn_clientes
        '
        Me.btn_clientes.Location = New System.Drawing.Point(12, 115)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(89, 37)
        Me.btn_clientes.TabIndex = 2
        Me.btn_clientes.Text = "Clientes"
        Me.btn_clientes.UseVisualStyleBackColor = True
        '
        'btn_precios
        '
        Me.btn_precios.Location = New System.Drawing.Point(12, 158)
        Me.btn_precios.Name = "btn_precios"
        Me.btn_precios.Size = New System.Drawing.Size(89, 37)
        Me.btn_precios.TabIndex = 3
        Me.btn_precios.Text = "Precios"
        Me.btn_precios.UseVisualStyleBackColor = True
        '
        'btn_backup
        '
        Me.btn_backup.Location = New System.Drawing.Point(12, 244)
        Me.btn_backup.Name = "btn_backup"
        Me.btn_backup.Size = New System.Drawing.Size(89, 37)
        Me.btn_backup.TabIndex = 5
        Me.btn_backup.Text = "Back Up"
        Me.btn_backup.UseVisualStyleBackColor = True
        '
        'dialogo
        '
        Me.dialogo.Title = "Destino del Back up"
        '
        'btn_cargarBD
        '
        Me.btn_cargarBD.Location = New System.Drawing.Point(12, 287)
        Me.btn_cargarBD.Name = "btn_cargarBD"
        Me.btn_cargarBD.Size = New System.Drawing.Size(89, 37)
        Me.btn_cargarBD.TabIndex = 6
        Me.btn_cargarBD.Text = "Cargar Base de Datos"
        Me.btn_cargarBD.UseVisualStyleBackColor = True
        '
        'dialogo_abrir
        '
        Me.dialogo_abrir.Title = "Seleccione la Base de Datos a cargar:"
        '
        'btn_recibos
        '
        Me.btn_recibos.Location = New System.Drawing.Point(12, 72)
        Me.btn_recibos.Name = "btn_recibos"
        Me.btn_recibos.Size = New System.Drawing.Size(89, 37)
        Me.btn_recibos.TabIndex = 1
        Me.btn_recibos.Text = "Cobranzas"
        Me.btn_recibos.UseVisualStyleBackColor = True
        '
        'btn_ListaPrecios
        '
        Me.btn_ListaPrecios.Location = New System.Drawing.Point(12, 201)
        Me.btn_ListaPrecios.Name = "btn_ListaPrecios"
        Me.btn_ListaPrecios.Size = New System.Drawing.Size(89, 37)
        Me.btn_ListaPrecios.TabIndex = 4
        Me.btn_ListaPrecios.Text = "Configurar Lista de Precios"
        Me.btn_ListaPrecios.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaNuevaColmena.My.Resources.Resources.panalinado1
        Me.ClientSize = New System.Drawing.Size(539, 351)
        Me.Controls.Add(Me.btn_ListaPrecios)
        Me.Controls.Add(Me.btn_recibos)
        Me.Controls.Add(Me.btn_cargarBD)
        Me.Controls.Add(Me.btn_backup)
        Me.Controls.Add(Me.btn_precios)
        Me.Controls.Add(Me.btn_clientes)
        Me.Controls.Add(Me.btn_factura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Principal"
        Me.Text = "La Nueva Colmena"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_factura As System.Windows.Forms.Button
    Friend WithEvents btn_clientes As System.Windows.Forms.Button
    Friend WithEvents btn_precios As System.Windows.Forms.Button
    Friend WithEvents btn_backup As System.Windows.Forms.Button
    Friend WithEvents dialogo As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btn_cargarBD As Button
    Friend WithEvents dialogo_abrir As OpenFileDialog
    Friend WithEvents btn_recibos As System.Windows.Forms.Button
    Friend WithEvents btn_ListaPrecios As System.Windows.Forms.Button
End Class
