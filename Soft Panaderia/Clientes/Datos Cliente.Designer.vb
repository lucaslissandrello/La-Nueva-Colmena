<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Datos_Cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Datos_Cliente))
        Me.btn_modificar_cliente = New System.Windows.Forms.Button()
        Me.btn_borrar_cliente = New System.Windows.Forms.Button()
        Me.lbl_razon_social = New System.Windows.Forms.Label()
        Me.lbl_cuit = New System.Windows.Forms.Label()
        Me.lbl_dni = New System.Windows.Forms.Label()
        Me.lbl_domicilio = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.lbl_id_cliente = New System.Windows.Forms.Label()
        Me.btn_guardar_cambios = New System.Windows.Forms.Button()
        Me.txt_razo_social = New System.Windows.Forms.TextBox()
        Me.txt_domicilio = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.txt_cuit = New System.Windows.Forms.MaskedTextBox()
        Me.txt_dni = New System.Windows.Forms.MaskedTextBox()
        Me.txt_telefono = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_lista_Precios = New System.Windows.Forms.Label()
        Me.cbo_lista = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btn_modificar_cliente
        '
        Me.btn_modificar_cliente.Location = New System.Drawing.Point(50, 200)
        Me.btn_modificar_cliente.Name = "btn_modificar_cliente"
        Me.btn_modificar_cliente.Size = New System.Drawing.Size(97, 23)
        Me.btn_modificar_cliente.TabIndex = 0
        Me.btn_modificar_cliente.Text = "Modificar Cliente"
        Me.btn_modificar_cliente.UseVisualStyleBackColor = True
        '
        'btn_borrar_cliente
        '
        Me.btn_borrar_cliente.Location = New System.Drawing.Point(269, 200)
        Me.btn_borrar_cliente.Name = "btn_borrar_cliente"
        Me.btn_borrar_cliente.Size = New System.Drawing.Size(99, 23)
        Me.btn_borrar_cliente.TabIndex = 9
        Me.btn_borrar_cliente.Text = "Borrar Cliente"
        Me.btn_borrar_cliente.UseVisualStyleBackColor = True
        '
        'lbl_razon_social
        '
        Me.lbl_razon_social.AutoSize = True
        Me.lbl_razon_social.Location = New System.Drawing.Point(12, 15)
        Me.lbl_razon_social.Name = "lbl_razon_social"
        Me.lbl_razon_social.Size = New System.Drawing.Size(70, 13)
        Me.lbl_razon_social.TabIndex = 2
        Me.lbl_razon_social.Text = "Razon Social"
        '
        'lbl_cuit
        '
        Me.lbl_cuit.AutoSize = True
        Me.lbl_cuit.Location = New System.Drawing.Point(12, 41)
        Me.lbl_cuit.Name = "lbl_cuit"
        Me.lbl_cuit.Size = New System.Drawing.Size(32, 13)
        Me.lbl_cuit.TabIndex = 3
        Me.lbl_cuit.Text = "CUIT"
        '
        'lbl_dni
        '
        Me.lbl_dni.AutoSize = True
        Me.lbl_dni.Location = New System.Drawing.Point(12, 67)
        Me.lbl_dni.Name = "lbl_dni"
        Me.lbl_dni.Size = New System.Drawing.Size(26, 13)
        Me.lbl_dni.TabIndex = 4
        Me.lbl_dni.Text = "DNI"
        '
        'lbl_domicilio
        '
        Me.lbl_domicilio.AutoSize = True
        Me.lbl_domicilio.Location = New System.Drawing.Point(12, 93)
        Me.lbl_domicilio.Name = "lbl_domicilio"
        Me.lbl_domicilio.Size = New System.Drawing.Size(49, 13)
        Me.lbl_domicilio.TabIndex = 5
        Me.lbl_domicilio.Text = "Domicilio"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(12, 119)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(32, 13)
        Me.lbl_email.TabIndex = 6
        Me.lbl_email.Text = "Email"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(12, 145)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(49, 13)
        Me.lbl_telefono.TabIndex = 7
        Me.lbl_telefono.Text = "Telefono"
        '
        'lbl_id_cliente
        '
        Me.lbl_id_cliente.AutoSize = True
        Me.lbl_id_cliente.Location = New System.Drawing.Point(402, 15)
        Me.lbl_id_cliente.Name = "lbl_id_cliente"
        Me.lbl_id_cliente.Size = New System.Drawing.Size(52, 13)
        Me.lbl_id_cliente.TabIndex = 8
        Me.lbl_id_cliente.Text = "id_cliente"
        '
        'btn_guardar_cambios
        '
        Me.btn_guardar_cambios.Location = New System.Drawing.Point(153, 200)
        Me.btn_guardar_cambios.Name = "btn_guardar_cambios"
        Me.btn_guardar_cambios.Size = New System.Drawing.Size(110, 23)
        Me.btn_guardar_cambios.TabIndex = 8
        Me.btn_guardar_cambios.Text = "Guardar Cambios"
        Me.btn_guardar_cambios.UseVisualStyleBackColor = True
        '
        'txt_razo_social
        '
        Me.txt_razo_social.Location = New System.Drawing.Point(90, 12)
        Me.txt_razo_social.Name = "txt_razo_social"
        Me.txt_razo_social.Size = New System.Drawing.Size(306, 20)
        Me.txt_razo_social.TabIndex = 1
        '
        'txt_domicilio
        '
        Me.txt_domicilio.Location = New System.Drawing.Point(90, 90)
        Me.txt_domicilio.Name = "txt_domicilio"
        Me.txt_domicilio.Size = New System.Drawing.Size(306, 20)
        Me.txt_domicilio.TabIndex = 4
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(90, 116)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(306, 20)
        Me.txt_email.TabIndex = 5
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(374, 200)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver.TabIndex = 10
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'txt_cuit
        '
        Me.txt_cuit.Location = New System.Drawing.Point(90, 38)
        Me.txt_cuit.Mask = "999999999999"
        Me.txt_cuit.Name = "txt_cuit"
        Me.txt_cuit.Size = New System.Drawing.Size(306, 20)
        Me.txt_cuit.TabIndex = 2
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(90, 64)
        Me.txt_dni.Mask = "999999999"
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(306, 20)
        Me.txt_dni.TabIndex = 3
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(90, 142)
        Me.txt_telefono.Mask = "99999999999999"
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(306, 20)
        Me.txt_telefono.TabIndex = 6
        '
        'lbl_lista_Precios
        '
        Me.lbl_lista_Precios.AutoSize = True
        Me.lbl_lista_Precios.Location = New System.Drawing.Point(12, 171)
        Me.lbl_lista_Precios.Name = "lbl_lista_Precios"
        Me.lbl_lista_Precios.Size = New System.Drawing.Size(135, 13)
        Me.lbl_lista_Precios.TabIndex = 10
        Me.lbl_lista_Precios.Text = "Lista de Precios Asignada: "
        '
        'cbo_lista
        '
        Me.cbo_lista.FormattingEnabled = True
        Me.cbo_lista.Location = New System.Drawing.Point(153, 168)
        Me.cbo_lista.Name = "cbo_lista"
        Me.cbo_lista.Size = New System.Drawing.Size(121, 21)
        Me.cbo_lista.TabIndex = 7
        '
        'Datos_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaNuevaColmena.My.Resources.Resources.panalinado1
        Me.ClientSize = New System.Drawing.Size(488, 239)
        Me.Controls.Add(Me.cbo_lista)
        Me.Controls.Add(Me.lbl_lista_Precios)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_dni)
        Me.Controls.Add(Me.txt_cuit)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_domicilio)
        Me.Controls.Add(Me.txt_razo_social)
        Me.Controls.Add(Me.btn_guardar_cambios)
        Me.Controls.Add(Me.lbl_id_cliente)
        Me.Controls.Add(Me.lbl_telefono)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_domicilio)
        Me.Controls.Add(Me.lbl_dni)
        Me.Controls.Add(Me.lbl_cuit)
        Me.Controls.Add(Me.lbl_razon_social)
        Me.Controls.Add(Me.btn_borrar_cliente)
        Me.Controls.Add(Me.btn_modificar_cliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Datos_Cliente"
        Me.Text = "Datos Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_modificar_cliente As System.Windows.Forms.Button
    Friend WithEvents btn_borrar_cliente As System.Windows.Forms.Button
    Friend WithEvents lbl_razon_social As System.Windows.Forms.Label
    Friend WithEvents lbl_cuit As System.Windows.Forms.Label
    Friend WithEvents lbl_dni As System.Windows.Forms.Label
    Friend WithEvents lbl_domicilio As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents lbl_id_cliente As System.Windows.Forms.Label
    Friend WithEvents btn_guardar_cambios As System.Windows.Forms.Button
    Friend WithEvents txt_razo_social As System.Windows.Forms.TextBox
    Friend WithEvents txt_domicilio As System.Windows.Forms.TextBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents txt_cuit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_dni As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_lista_Precios As System.Windows.Forms.Label
    Friend WithEvents cbo_lista As System.Windows.Forms.ComboBox
End Class
