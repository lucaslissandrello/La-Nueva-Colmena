<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Precios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Precios))
        Me.dgv_productos = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.chk_precio1 = New System.Windows.Forms.CheckBox()
        Me.chk_precio2 = New System.Windows.Forms.CheckBox()
        Me.chk_precio3 = New System.Windows.Forms.CheckBox()
        Me.chk_precio4 = New System.Windows.Forms.CheckBox()
        Me.chk_precio5 = New System.Windows.Forms.CheckBox()
        Me.chk_precio6 = New System.Windows.Forms.CheckBox()
        Me.chk_precio7 = New System.Windows.Forms.CheckBox()
        Me.chk_precio8 = New System.Windows.Forms.CheckBox()
        Me.btn_imprimar = New System.Windows.Forms.Button()
        CType(Me.dgv_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_productos
        '
        Me.dgv_productos.AllowUserToAddRows = False
        Me.dgv_productos.AllowUserToDeleteRows = False
        Me.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.producto, Me.precio1, Me.precio2, Me.precio3, Me.precio4, Me.precio5, Me.precio6, Me.precio7, Me.precio8})
        Me.dgv_productos.Location = New System.Drawing.Point(13, 31)
        Me.dgv_productos.Name = "dgv_productos"
        Me.dgv_productos.ReadOnly = True
        Me.dgv_productos.Size = New System.Drawing.Size(694, 377)
        Me.dgv_productos.TabIndex = 16
        '
        'codigo
        '
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 50
        '
        'producto
        '
        Me.producto.HeaderText = "Producto"
        Me.producto.Name = "producto"
        Me.producto.ReadOnly = True
        '
        'precio1
        '
        Me.precio1.HeaderText = "Precio Lista 1 $"
        Me.precio1.Name = "precio1"
        Me.precio1.ReadOnly = True
        Me.precio1.Width = 50
        '
        'precio2
        '
        Me.precio2.HeaderText = "Precio Lista 2 $"
        Me.precio2.Name = "precio2"
        Me.precio2.ReadOnly = True
        Me.precio2.Width = 50
        '
        'precio3
        '
        Me.precio3.HeaderText = "Precio Lista 3 $"
        Me.precio3.Name = "precio3"
        Me.precio3.ReadOnly = True
        Me.precio3.Width = 50
        '
        'precio4
        '
        Me.precio4.HeaderText = "Precio Lista 4 $"
        Me.precio4.Name = "precio4"
        Me.precio4.ReadOnly = True
        Me.precio4.Width = 50
        '
        'precio5
        '
        Me.precio5.HeaderText = "Precio Lista 5 $"
        Me.precio5.Name = "precio5"
        Me.precio5.ReadOnly = True
        Me.precio5.Width = 50
        '
        'precio6
        '
        Me.precio6.HeaderText = "Precio Lista 6 $"
        Me.precio6.Name = "precio6"
        Me.precio6.ReadOnly = True
        Me.precio6.Width = 50
        '
        'precio7
        '
        Me.precio7.HeaderText = "Precio Lista 7 $"
        Me.precio7.Name = "precio7"
        Me.precio7.ReadOnly = True
        Me.precio7.Width = 50
        '
        'precio8
        '
        Me.precio8.HeaderText = "Precio Lista 8 $"
        Me.precio8.Name = "precio8"
        Me.precio8.ReadOnly = True
        Me.precio8.Width = 50
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(13, 5)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(247, 20)
        Me.txt_buscar.TabIndex = 0
        Me.txt_buscar.Text = "Buscar..."
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(713, 43)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(109, 23)
        Me.btn_agregar.TabIndex = 3
        Me.btn_agregar.Text = "Agregar Producto"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(713, 73)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(109, 23)
        Me.btn_modificar.TabIndex = 4
        Me.btn_modificar.Text = "Modificar Producto"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.Location = New System.Drawing.Point(713, 103)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(109, 23)
        Me.btn_borrar.TabIndex = 5
        Me.btn_borrar.Text = "Borrar Producto"
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(713, 369)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(109, 23)
        Me.btn_volver.TabIndex = 16
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(266, 3)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(89, 23)
        Me.btn_buscar.TabIndex = 1
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(361, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Mostrar Todos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.Location = New System.Drawing.Point(713, 132)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_todos.TabIndex = 6
        Me.chk_todos.Text = "Todos"
        Me.chk_todos.UseVisualStyleBackColor = True
        '
        'chk_precio1
        '
        Me.chk_precio1.AutoSize = True
        Me.chk_precio1.Location = New System.Drawing.Point(712, 155)
        Me.chk_precio1.Name = "chk_precio1"
        Me.chk_precio1.Size = New System.Drawing.Size(90, 17)
        Me.chk_precio1.TabIndex = 7
        Me.chk_precio1.Text = "Precio Lista 1"
        Me.chk_precio1.UseVisualStyleBackColor = True
        '
        'chk_precio2
        '
        Me.chk_precio2.AutoSize = True
        Me.chk_precio2.Location = New System.Drawing.Point(712, 178)
        Me.chk_precio2.Name = "chk_precio2"
        Me.chk_precio2.Size = New System.Drawing.Size(90, 17)
        Me.chk_precio2.TabIndex = 8
        Me.chk_precio2.Text = "Precio Lista 2"
        Me.chk_precio2.UseVisualStyleBackColor = True
        '
        'chk_precio3
        '
        Me.chk_precio3.AutoSize = True
        Me.chk_precio3.Location = New System.Drawing.Point(712, 201)
        Me.chk_precio3.Name = "chk_precio3"
        Me.chk_precio3.Size = New System.Drawing.Size(90, 17)
        Me.chk_precio3.TabIndex = 9
        Me.chk_precio3.Text = "Precio Lista 3"
        Me.chk_precio3.UseVisualStyleBackColor = True
        '
        'chk_precio4
        '
        Me.chk_precio4.AutoSize = True
        Me.chk_precio4.Location = New System.Drawing.Point(712, 224)
        Me.chk_precio4.Name = "chk_precio4"
        Me.chk_precio4.Size = New System.Drawing.Size(90, 17)
        Me.chk_precio4.TabIndex = 10
        Me.chk_precio4.Text = "Precio Lista 4"
        Me.chk_precio4.UseVisualStyleBackColor = True
        '
        'chk_precio5
        '
        Me.chk_precio5.AutoSize = True
        Me.chk_precio5.Location = New System.Drawing.Point(712, 247)
        Me.chk_precio5.Name = "chk_precio5"
        Me.chk_precio5.Size = New System.Drawing.Size(90, 17)
        Me.chk_precio5.TabIndex = 11
        Me.chk_precio5.Text = "Precio Lista 5"
        Me.chk_precio5.UseVisualStyleBackColor = True
        '
        'chk_precio6
        '
        Me.chk_precio6.AutoSize = True
        Me.chk_precio6.Location = New System.Drawing.Point(712, 270)
        Me.chk_precio6.Name = "chk_precio6"
        Me.chk_precio6.Size = New System.Drawing.Size(90, 17)
        Me.chk_precio6.TabIndex = 12
        Me.chk_precio6.Text = "Precio Lista 6"
        Me.chk_precio6.UseVisualStyleBackColor = True
        '
        'chk_precio7
        '
        Me.chk_precio7.AutoSize = True
        Me.chk_precio7.Location = New System.Drawing.Point(712, 293)
        Me.chk_precio7.Name = "chk_precio7"
        Me.chk_precio7.Size = New System.Drawing.Size(90, 17)
        Me.chk_precio7.TabIndex = 13
        Me.chk_precio7.Text = "Precio Lista 7"
        Me.chk_precio7.UseVisualStyleBackColor = True
        '
        'chk_precio8
        '
        Me.chk_precio8.AutoSize = True
        Me.chk_precio8.Location = New System.Drawing.Point(712, 316)
        Me.chk_precio8.Name = "chk_precio8"
        Me.chk_precio8.Size = New System.Drawing.Size(90, 17)
        Me.chk_precio8.TabIndex = 14
        Me.chk_precio8.Text = "Precio Lista 8"
        Me.chk_precio8.UseVisualStyleBackColor = True
        '
        'btn_imprimar
        '
        Me.btn_imprimar.Location = New System.Drawing.Point(713, 340)
        Me.btn_imprimar.Name = "btn_imprimar"
        Me.btn_imprimar.Size = New System.Drawing.Size(109, 23)
        Me.btn_imprimar.TabIndex = 15
        Me.btn_imprimar.Text = "Imprimir Precios"
        Me.btn_imprimar.UseVisualStyleBackColor = True
        '
        'Precios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaNuevaColmena.My.Resources.Resources.panalinado1
        Me.ClientSize = New System.Drawing.Size(832, 420)
        Me.Controls.Add(Me.btn_imprimar)
        Me.Controls.Add(Me.chk_precio8)
        Me.Controls.Add(Me.chk_precio7)
        Me.Controls.Add(Me.chk_precio6)
        Me.Controls.Add(Me.chk_precio5)
        Me.Controls.Add(Me.chk_precio4)
        Me.Controls.Add(Me.chk_precio3)
        Me.Controls.Add(Me.chk_precio2)
        Me.Controls.Add(Me.chk_precio1)
        Me.Controls.Add(Me.chk_todos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.dgv_productos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Precios"
        Me.Text = "Precios"
        CType(Me.dgv_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_productos As System.Windows.Forms.DataGridView
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_borrar As System.Windows.Forms.Button
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chk_todos As System.Windows.Forms.CheckBox
    Friend WithEvents chk_precio1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_precio2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_precio3 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_precio4 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_precio5 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_precio6 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_precio7 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_precio8 As System.Windows.Forms.CheckBox
    Friend WithEvents btn_imprimar As System.Windows.Forms.Button
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
