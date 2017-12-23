Public Class Agregar_Producto
    Private Sub btn_GuardarCambios_Click(sender As Object, e As EventArgs) Handles btn_GuardarCambios.Click
        If txt_producto.Text = "" Then
            MsgBox("El producto debe tener un nombre")
            txt_producto.Focus()
            Exit Sub
        End If
        Dim ban As Boolean = True
        ban = IsNumeric(txt_idProducto.Text)
        If ban = False Then
            MsgBox("Ingrese un codigo de producto.")
            Exit Sub
        End If
        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM Producto WHERE Codigo = " + txt_idProducto.Text)
        If tabla.Rows.Count = 1 Then
            MsgBox("El codigo de producto ingresado ya esta en uso, por favor modifiquelo")
            Exit Sub
        End If
        Dim i As Integer
        Dim cmd As String = "Insert into Producto(Codigo, Producto, Borrado, Precio_Lista_1, Precio_Lista_2, Precio_Lista_3, Precio_Lista_4, Precio_Lista_5, Precio_Lista_6, Precio_Lista_7, Precio_Lista_8) values(" + txt_idProducto.Text + ", '" + txt_producto.Text + "', 0, "
        If ch_box1.Checked Then
            If txt_precio1.Text = "." Then
                MsgBox("Ingrese un precio para la lista 1")
                txt_precio1.Focus()
                Exit Sub
            End If
            cmd = cmd + txt_precio1.Text + ", "
        Else
            cmd = cmd + "0, "
        End If
        If ch_box2.Checked Then
            If txt_precio2.Text = "." Then
                MsgBox("Ingrese un precio para la lista 2")
                txt_precio2.Focus()
                Exit Sub
            End If
            cmd = cmd + txt_precio2.Text + ", "
        Else
            cmd = cmd + "0, "
        End If
        If ch_box3.Checked Then
            If txt_precio3.Text = "." Then
                MsgBox("Ingrese un precio para la lista 3")
                txt_precio3.Focus()
                Exit Sub
            End If
            cmd = cmd + txt_precio3.Text + ", "
        Else
            cmd = cmd + "0, "
        End If
        If ch_box4.Checked Then
            If txt_precio4.Text = "." Then
                MsgBox("Ingrese un precio para la lista 4")
                txt_precio4.Focus()
                Exit Sub
            End If
            cmd = cmd + txt_precio4.Text + ", "
        Else
            cmd = cmd + "0, "
        End If
        If ch_box5.Checked Then
            If txt_precio5.Text = "." Then
                MsgBox("Ingrese un precio para la lista 5")
                txt_precio5.Focus()
                Exit Sub
            End If
            cmd = cmd + txt_precio5.Text + ", "
        Else
            cmd = cmd + "0, "
        End If
        If ch_box6.Checked Then
            If txt_precio6.Text = "." Then
                MsgBox("Ingrese un precio para la lista 6")
                txt_precio6.Focus()
                Exit Sub
            End If
            cmd = cmd + txt_precio6.Text + ", "
        Else
            cmd = cmd + "0, "
        End If
        If ch_box7.Checked Then
            If txt_precio7.Text = "." Then
                MsgBox("Ingrese un precio para la lista 7")
                txt_precio7.Focus()
                Exit Sub
            End If
            cmd = cmd + txt_precio7.Text + ", "
        Else
            cmd = cmd + "0, "
        End If
        If ch_box8.Checked Then
            If txt_precio8.Text = "." Then
                MsgBox("Ingrese un precio para la lista 8")
                txt_precio8.Focus()
                Exit Sub
            End If
            cmd = cmd + txt_precio8.Text + ")"
        Else
            cmd = cmd + "0)"
        End If
        i = BDHelper.getDBHelper().EjecutarSQL(cmd)
        If i <> 0 Then
            MsgBox("Producto ingresado correctamente.")
            Me.Dispose()
            Me.Close()
        Else : MsgBox("Error al cargar el producto, revise los datos ingresados")
        End If
    End Sub

    Private Sub Agregar_Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r As New Globalization.CultureInfo("es-ES")
        r.NumberFormat.CurrencyDecimalSeparator = "."
        r.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture = r
        MaximizeBox = False
        Top = Precios.Top
        Left = Precios.Left
        txt_precio1.Enabled = False
        txt_precio2.Enabled = False
        txt_precio3.Enabled = False
        txt_precio4.Enabled = False
        txt_precio5.Enabled = False
        txt_precio6.Enabled = False
        txt_precio7.Enabled = False
        txt_precio8.Enabled = False
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

    Private Sub validar_datos(txt As MaskedTextBox)
        If txt.Text = "" Then
            txt.Text = "0"
        End If
    End Sub

    Private Sub ch_box1_CheckedChanged(sender As Object, e As EventArgs) Handles ch_box1.CheckedChanged
        check(ch_box1, txt_precio1)
    End Sub
    Private Sub ch_box2_CheckedChanged(sender As Object, e As EventArgs) Handles ch_box2.CheckedChanged
        check(ch_box2, txt_precio2)
    End Sub
    Private Sub ch_box3_CheckedChanged(sender As Object, e As EventArgs) Handles ch_box3.CheckedChanged
        check(ch_box3, txt_precio3)
    End Sub
    Private Sub ch_box4_CheckedChanged(sender As Object, e As EventArgs) Handles ch_box4.CheckedChanged
        check(ch_box4, txt_precio4)
    End Sub
    Private Sub ch_box5_CheckedChanged(sender As Object, e As EventArgs) Handles ch_box5.CheckedChanged
        check(ch_box5, txt_precio5)
    End Sub
    Private Sub ch_box6_CheckedChanged(sender As Object, e As EventArgs) Handles ch_box6.CheckedChanged
        check(ch_box6, txt_precio6)
    End Sub
    Private Sub ch_box7_CheckedChanged(sender As Object, e As EventArgs) Handles ch_box7.CheckedChanged
        check(ch_box7, txt_precio7)
    End Sub
    Private Sub ch_box8_CheckedChanged(sender As Object, e As EventArgs) Handles ch_box8.CheckedChanged
        check(ch_box8, txt_precio8)
    End Sub
    Private Sub check(chk As CheckBox, txt1 As TextBox)
        If chk.Checked Then
            txt1.Enabled = True
        Else
            txt1.Enabled = False
        End If
    End Sub
End Class