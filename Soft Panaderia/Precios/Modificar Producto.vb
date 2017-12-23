Public Class modificar_producto
    Private Sub modificar_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r As New Globalization.CultureInfo("es-ES")
        r.NumberFormat.CurrencyDecimalSeparator = "."
        r.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture = r
        MaximizeBox = False
        Top = Precios.Top
        Left = Precios.Left
        lbl_idproducto.Text = Precios.dgv_productos.CurrentRow.Cells("Codigo").Value
        txt_producto.Text = Precios.dgv_productos.CurrentRow.Cells("Producto").Value
        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM Producto WHERE Codigo = " + lbl_idproducto.Text)
        txt_precioL1.Text = tabla.Rows(0).Item("Precio_Lista_1").ToString
        txt_precioL1.Enabled = False
        txt_precioL2.Text = tabla.Rows(0).Item("Precio_Lista_2").ToString
        txt_precioL2.Enabled = False
        txt_precioL3.Text = tabla.Rows(0).Item("Precio_Lista_3").ToString
        txt_precioL3.Enabled = False
        txt_precioL4.Text = tabla.Rows(0).Item("Precio_Lista_4").ToString
        txt_precioL4.Enabled = False
        txt_precioL5.Text = tabla.Rows(0).Item("Precio_Lista_5").ToString
        txt_precioL5.Enabled = False
        txt_precioL6.Text = tabla.Rows(0).Item("Precio_Lista_6").ToString
        txt_precioL6.Enabled = False
        txt_precioL7.Text = tabla.Rows(0).Item("Precio_Lista_7").ToString
        txt_precioL7.Enabled = False
        txt_precioL8.Text = tabla.Rows(0).Item("Precio_Lista_8").ToString
        txt_precioL8.Enabled = False
        Dim tabla1 As Data.DataTable
        tabla1 = BDHelper.getDBHelper.ConsultaSQL("Select * From ListaPrecios")
        ch_box1.Text = tabla1.Rows(0).Item(1).ToString
        ch_box2.Text = tabla1.Rows(1).Item(1).ToString
        ch_box3.Text = tabla1.Rows(2).Item(1).ToString
        ch_box4.Text = tabla1.Rows(3).Item(1).ToString
        ch_box5.Text = tabla1.Rows(4).Item(1).ToString
        ch_box6.Text = tabla1.Rows(5).Item(1).ToString
        ch_box7.Text = tabla1.Rows(6).Item(1).ToString
        ch_box8.Text = tabla1.Rows(7).Item(1).ToString
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim i As Integer
        Dim cmd As String
        cmd = "UPDATE Producto set Producto = '" + txt_producto.Text
        If ch_box1.Checked Then
            cmd = cmd + "', Precio_Lista_1 = " + txt_precioL1.Text
        End If
        If ch_box2.Checked Then
            cmd = cmd + "', Precio_Lista_2 = " + txt_precioL2.Text
        End If
        If ch_box3.Checked Then
            cmd = cmd + "', Precio_Lista_3 = " + txt_precioL3.Text
        End If
        If ch_box4.Checked Then
            cmd = cmd + "', Precio_Lista_4 = " + txt_precioL4.Text
        End If
        If ch_box5.Checked Then
            cmd = cmd + "', Precio_Lista_5 = " + txt_precioL5.Text
        End If
        If ch_box6.Checked Then
            cmd = cmd + "', Precio_Lista_6 = " + txt_precioL6.Text
        End If
        If ch_box7.Checked Then
            cmd = cmd + "', Precio_Lista_7 = " + txt_precioL7.Text
        End If
        If ch_box8.Checked Then
            cmd = cmd + "', Precio_Lista_8 = " + txt_precioL8.Text
        End If
        cmd = cmd + " where Codigo = " + lbl_idproducto.Text
        i = BDHelper.getDBHelper().EjecutarSQL(cmd)
        If i <> 0 Then
            MsgBox("Producto actualizado correctamente.")
            Me.Dispose()
            Me.Close()
        Else : MsgBox("Error al modificar datos del producto, revise los datos ingresados.")
        End If
    End Sub
    Private Sub ch_box1_CheckedChanged(sender As Object, e As EventArgs) Handles ch_box1.CheckedChanged
        check(ch_box1, txt_precioL1)
    End Sub
    Private Sub ch_box2_CheckedChanged(sender As Object, e As EventArgs) Handles ch_box2.CheckedChanged
        check(ch_box2, txt_precioL2)
    End Sub
    Private Sub ch_box3_CheckedChanged(sender As Object, e As EventArgs) Handles ch_box3.CheckedChanged
        check(ch_box3, txt_precioL3)
    End Sub
    Private Sub ch_box4_CheckedChanged(sender As Object, e As EventArgs) Handles ch_box4.CheckedChanged
        check(ch_box4, txt_precioL4)
    End Sub
    Private Sub ch_box5_CheckedChanged(sender As Object, e As EventArgs) Handles ch_box5.CheckedChanged
        check(ch_box5, txt_precioL5)
    End Sub
    Private Sub ch_box6_CheckedChanged(sender As Object, e As EventArgs) Handles ch_box6.CheckedChanged
        check(ch_box6, txt_precioL6)
    End Sub
    Private Sub ch_box7_CheckedChanged(sender As Object, e As EventArgs) Handles ch_box7.CheckedChanged
        check(ch_box7, txt_precioL7)
    End Sub
    Private Sub ch_box8_CheckedChanged(sender As Object, e As EventArgs) Handles ch_box8.CheckedChanged
        check(ch_box8, txt_precioL8)
    End Sub
    Private Sub check(chk As CheckBox, txt1 As TextBox)
        If chk.Checked Then
            txt1.Enabled = True
        Else
            txt1.Enabled = False
        End If
    End Sub

End Class