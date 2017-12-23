Public Class Agregar_Cliente

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Agregar_Cliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Agregar_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        Top = Clientes.Top
        Left = Clientes.Left
        Dim idProductoNuevo As Integer
        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper().ConsultaSQL("Select MAX(Codigo) From Cliente")
        If tabla.Rows(0).Item(0).ToString = "" Then
            idProductoNuevo = 1
        Else
            idProductoNuevo = (tabla.Rows(0).Item(0) + 1)
        End If
        lbl_id_cliente.Text = idProductoNuevo
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM ListaPrecios")
        cbo_lista.DataSource = tabla
        cbo_lista.DisplayMember = "Descripcion"
        cbo_lista.ValueMember = "Id"
        cbo_lista.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btn_guardar_cambios_Click(sender As Object, e As EventArgs) Handles btn_guardar_cambios.Click
        If txt_razo_social.Text = "" Then
            MsgBox("El cliente debe tener una razon social")
            txt_razo_social.Focus()
            Exit Sub
        End If
        Dim i As Integer
        validar_datos(txt_cuit)
        txt_cuit.Text = txt_cuit.Text.Replace(" "c, String.Empty)
        validar_datos(txt_dni)
        txt_dni.Text = txt_dni.Text.Replace(" "c, String.Empty)
        validar_datos(txt_telefono)
        txt_telefono.Text = txt_telefono.Text.Replace(" "c, String.Empty)
        i = BDHelper.getDBHelper().EjecutarSQL("Insert into Cliente(Codigo, Razon_Social, Saldo, CUIT, DNI, Domicilio, Email, Telefono, Borrado, Lista_precio) values(" + lbl_id_cliente.Text + ", '" + txt_razo_social.Text + "', 0, " + txt_cuit.Text + ", " + txt_dni.Text + ", '" + txt_domicilio.Text + "', '" + txt_email.Text + "'," + txt_telefono.Text + ", 0, '[Precio Lista " + cbo_lista.SelectedValue.ToString + "]')")
        If i <> 0 Then
            MsgBox("Cliente registrado correctamente.")
            Me.Close()
        Else : MsgBox("Error al registrar el Cliente, revise los datos ingresados.")
        End If


    End Sub


    Private Sub validar_datos(txt As MaskedTextBox)
        If txt.Text = "" Then
            txt.Text = "0"
        End If
    End Sub
End Class