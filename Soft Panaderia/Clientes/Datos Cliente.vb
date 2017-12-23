Public Class Datos_Cliente

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Close()
    End Sub

    Private Sub Datos_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        Top = Clientes.Top
        Left = Clientes.Left
        btn_guardar_cambios.Enabled = False
        btn_borrar_cliente.Enabled = False
        lbl_id_cliente.Text = Clientes.dgv_clientes.CurrentRow.Cells(0).Value
        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper().ConsultaSQL("SELECT * FROM Cliente WHERE Codigo = " + Clientes.dgv_clientes.CurrentRow.Cells(0).Value)
        txt_razo_social.Text = tabla.Rows(0).Item(1).ToString
        txt_cuit.Text = tabla.Rows(0).Item(3).ToString
        txt_dni.Text = tabla.Rows(0).Item(4).ToString
        txt_domicilio.Text = tabla.Rows(0).Item(5).ToString
        txt_email.Text = tabla.Rows(0).Item(6).ToString
        txt_telefono.Text = tabla.Rows(0).Item(7).ToString
        Dim tabla1 As Data.DataTable = BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM ListaPrecios")
        Dim var As Integer = tabla.Rows(0).Item(9).ToString.ElementAt(14).ToString
        cbo_lista.DataSource = tabla1
        cbo_lista.DisplayMember = "Descripcion"
        cbo_lista.ValueMember = "Id"
        cbo_lista.SelectedValue = var
        cbo_lista.Enabled = False
        txt_razo_social.Enabled = False
        txt_cuit.Enabled = False
        txt_dni.Enabled = False
        txt_domicilio.Enabled = False
        txt_email.Enabled = False
        txt_telefono.Enabled = False
        cbo_lista.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btn_modificar_cliente_Click(sender As Object, e As EventArgs) Handles btn_modificar_cliente.Click
        cbo_lista.Enabled = True
        txt_razo_social.Enabled = True
        txt_cuit.Enabled = True
        txt_dni.Enabled = True
        txt_domicilio.Enabled = True
        txt_email.Enabled = True
        txt_telefono.Enabled = True

        btn_guardar_cambios.Enabled = True
        btn_borrar_cliente.Enabled = True
    End Sub

    Private Sub btn_guardar_cambios_Click(sender As Object, e As EventArgs) Handles btn_guardar_cambios.Click
        Dim i As Integer
        validar_datos(txt_cuit)
        txt_cuit.Text = txt_cuit.Text.Replace(" "c, String.Empty)
        validar_datos(txt_dni)
        txt_dni.Text = txt_dni.Text.Replace(" "c, String.Empty)
        validar_datos(txt_telefono)
        txt_telefono.Text = txt_telefono.Text.Replace(" "c, String.Empty)
        i = BDHelper.getDBHelper().EjecutarSQL("UPDATE Cliente set Razon_Social = '" + txt_razo_social.Text + "', CUIT = " + txt_cuit.Text + ", DNI = " + txt_dni.Text + ", Domicilio = '" + txt_domicilio.Text + "', Email ='" + txt_email.Text + "', Telefono = " + txt_telefono.Text + ", Lista_precio = '[Precio Lista " + cbo_lista.SelectedValue.ToString + "]' where Codigo = " + lbl_id_cliente.Text)
        If i <> 0 Then
            MsgBox("Cliente actualizado correctamente.")
            Me.Close()

        Else : MsgBox("Error al modificar datos del cliente, revise los datos ingresados.")
        End If
    End Sub

    Private Sub btn_borrar_cliente_Click(sender As Object, e As EventArgs) Handles btn_borrar_cliente.Click
        If MsgBox("¿Desea Borrar el Cliente seleccionado? Si lo hace perdera los datos de dicho cliente.", MsgBoxStyle.YesNo, "Borrar Cliente") = MsgBoxResult.Yes Then
            Dim i As Integer
            i = BDHelper.getDBHelper().EjecutarSQL("UPDATE Cliente set Borrado = 1 where Codigo = " + Clientes.dgv_clientes.CurrentRow.Cells(0).Value)
            If i <> 0 Then
                MsgBox("Cliente eliminado correctamente.")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub validar_datos(txt As MaskedTextBox)
        If txt.Text = "" Then
            txt.Text = "0"
        End If
    End Sub
End Class