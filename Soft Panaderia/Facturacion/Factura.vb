Public Class Factura
    Private cantidad_total As Double
    Public desdeFactura As Boolean = False
    Dim total As Double
    Dim ban As Boolean
    Dim primeraVuelta As Boolean = True
    Dim precio1 As Integer
    Dim precio2 As Double
    Dim tabla2 As Data.DataTable
    Dim cantidadProd As String
    Dim x As Double
   
    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Close()
    End Sub

    Private Sub Factura_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ban = False Then
            If MsgBox("¿Desea salir sin guardar los cambios?", MsgBoxStyle.YesNo, "Salir") = MsgBoxResult.No Then
                e.Cancel = True
                Exit Sub
            End If
        End If
        Me.Dispose()
    End Sub
    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r As New Globalization.CultureInfo("es-ES")
        r.NumberFormat.CurrencyDecimalSeparator = "."
        r.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture = r
        MaximizeBox = False
        Top = Facturacion.Top
        Left = Facturacion.Left
        ban = False
        lbl_codigo.Text = ""
        txt_cantidad.Enabled = False
        txt_codigo.Enabled = False
        cbo_producto.Enabled = False
        lbl_factura.Text = ""
        lbl_cantidad_total.Text = "0"
        lbl_total.Text = "0"
        btn_quitar.Enabled = False
        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT Codigo, Razon_Social, Lista_precio FROM Cliente WHERE Borrado = 0")
        cbo_cliente.DataSource = tabla
        cbo_cliente.DisplayMember = "Razon_Social"
        cbo_cliente.ValueMember = "Codigo"
        tabla2 = BDHelper.getDBHelper.ConsultaSQL("SELECT Codigo, Producto FROM Producto WHERE Borrado = 0")
        cbo_producto.DataSource = tabla2
        cbo_producto.DisplayMember = "Producto"
        cbo_producto.ValueMember = "Codigo"
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT MAX(Id) FROM Factura")
        If tabla.Rows(0).Item(0).ToString = "" Then
            lbl_factura.Text = "1"
        Else
            lbl_factura.Text = (tabla.Rows(0).Item(0) + 1)
        End If
        btn_agregar.Enabled = False
        cbo_cliente.SelectedValue = 0
        cbo_cliente.DropDownStyle = ComboBoxStyle.DropDownList
        cbo_forma_pago.DropDownStyle = ComboBoxStyle.DropDownList
        cbo_producto.DropDownStyle = ComboBoxStyle.DropDownList
        primeraVuelta = False
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT Precio_Lista_" + precio1.ToString + " FROM Producto WHERE Codigo = " + cbo_producto.SelectedValue.ToString)
        precio2 = tabla.Rows(0).Item(0)
        Dim importe As Double
        'listar_precio(txt_cantidad)
        importe = Double.Parse(txt_cantidad.Text)
        importe = importe * precio2
        Dim ban As Boolean = True
        If dgv_detalles.Rows.Count > 0 Then
            For j As Integer = 0 To dgv_detalles.Rows.Count - 1
                If ban Then
                    If precio2 = dgv_detalles.Rows(j).Cells(3).Value Then
                        If dgv_detalles.Rows(j).Cells(0).Value = cbo_producto.SelectedValue Then
                            ban = False
                            total = (total - dgv_detalles.Rows(j).Cells(4).Value)
                            Dim cantidad As Integer = Double.Parse(txt_cantidad.Text)
                            dgv_detalles.Rows(j).Cells(1).Value = dgv_detalles.Rows(j).Cells(1).Value + cantidad
                            importe = importe + dgv_detalles.Rows(j).Cells(4).Value
                            dgv_detalles.Rows(j).Cells(4).Value = importe
                        End If
                    End If
                End If
            Next
        End If
        If ban Then
            dgv_detalles.Rows.Add(New Object() {cbo_producto.SelectedValue, Double.Parse(txt_cantidad.Text), cbo_producto.Text, precio2, importe})
        End If
        cantidad_total = cantidad_total + Val(txt_cantidad.ToString)
        lbl_cantidad_total.Text = cantidad_total
        total = total + importe
        lbl_total.Text = total
        txt_cantidad.Text = ""
        txt_codigo.Text = ""
        txt_codigo.Enabled = False
        btn_agregar.Enabled = False
        txt_cantidad.Focus()
    End Sub

    Private Sub dgv_detalles_Click(sender As Object, e As EventArgs) Handles dgv_detalles.Click
        btn_quitar.Enabled = True
    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        cantidad_total = cantidad_total - dgv_detalles.CurrentRow.Cells(1).Value
        lbl_cantidad_total.Text = cantidad_total
        total = total - dgv_detalles.CurrentRow.Cells(4).Value
        lbl_total.Text = total
        dgv_detalles.Rows.Remove(dgv_detalles.CurrentRow)
        If dgv_detalles.Rows.Count = 0 Then
            lbl_total.Text = "0"
            btn_quitar.Enabled = False
        End If
    End Sub
    Private Sub cbo_cliente_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_cliente.SelectedValueChanged
        If primeraVuelta Then
            Exit Sub
        Else
            lbl_codigo.Text = cbo_cliente.SelectedValue.ToString
            txt_codigo.Enabled = True
            txt_cantidad.Enabled = True
            Dim tabla As Data.DataTable
            tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT Lista_precio FROM Cliente WHERE Borrado = 0 AND Codigo = " + cbo_cliente.SelectedValue.ToString)
            precio1 = tabla.Rows(0).Item(0).ToString.ElementAt(14).ToString
            If dgv_detalles.Rows.Count > 0 Then
                total = 0
                For i As Integer = 0 To dgv_detalles.Rows.Count - 1
                    tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT Precio_Lista_" + precio1.ToString + " FROM Producto WHERE Codigo = " + dgv_detalles.Rows(i).Cells(0).Value.ToString)
                    dgv_detalles.Rows(i).Cells(3).Value = tabla.Rows(0).Item(0)
                    dgv_detalles.Rows(i).Cells(4).Value = dgv_detalles.Rows(i).Cells(3).Value * dgv_detalles.Rows(i).Cells(1).Value
                    total = total + dgv_detalles.Rows(i).Cells(4).Value
                    lbl_total.Text = total.ToString
                Next
            End If
        End If
    End Sub

    'Private Sub listar_precio(txt_precioL As MaskedTextBox)
    '    cantidadProd = ""
    '    Dim ban As Boolean = False
    '    For j As Integer = 0 To 3
    '        If txt_precioL.Text.ElementAt(j) <> " " Then
    '            cantidadProd = cantidadProd.ToString + txt_precioL.Text.ElementAt(j)
    '        End If
    '    Next
    '    If cantidadProd = "" Then
    '        cantidadProd = "0"
    '    End If
    '    cantidadProd = cantidadProd.ToString + "."c
    '    For j = 5 To (txt_precioL.Text.Length - 1)
    '        If txt_precioL.Text.ElementAt(j) <> " " Then
    '            cantidadProd = cantidadProd.ToString + txt_precioL.Text.ElementAt(j)
    '            ban = True
    '        End If
    '    Next
    '    If ban = False Then
    '        cantidadProd = cantidadProd.ToString + "0"c
    '    End If

    'End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If cbo_cliente.SelectedIndex = -1 Then
            MsgBox("Seleccione un cliente, no hay un cliente seleccionado.")
            Exit Sub
        End If
        If dgv_detalles.Rows.Count < 1 Then
            MsgBox("La factura debe contener al menos un producto")
            Exit Sub
        End If
        If cbo_forma_pago.SelectedIndex = -1 Then
            MsgBox("Seleccione una forma de pago")
            Exit Sub
        End If
        ban = BDHelper.getDBHelper.finalizarFactura()
        If ban Then
            MsgBox("Factura guardada correctamente")
            If cbo_forma_pago.SelectedIndex = 1 Then
                If MsgBox("¿Desea generar un recibo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    desdeFactura = True
                    Recibo.ShowDialog()
                End If
            Else
                BDHelper.getDBHelper.reciboContado()
                MsgBox("Se ha generado un recibo, para verlo/imprimirlo vaya a Cobranzas")
            End If
            Me.Close()
        Else
            MsgBox("Factura no guardada, verifique los datos")
        End If
    End Sub

    Private Sub cbo_producto_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_producto.SelectedValueChanged
        If primeraVuelta Then
            Exit Sub
        Else
            Dim tabla As Data.DataTable
            tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT Precio_Lista_" + precio1.ToString + " FROM Producto WHERE Borrado = 0 AND Codigo = " + cbo_producto.SelectedValue.ToString)
            precio2 = tabla.Rows(0).Item(0).ToString
        End If
    End Sub

    Private Sub txt_codigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_codigo.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If txt_codigo.Text = "" Then
                    MsgBox("Ingrese un codigo")
                    Exit Sub
                End If
                For i As Integer = 0 To tabla2.Rows.Count - 1
                    txt_codigo.Refresh()
                    If tabla2.Rows(i).Item(0).ToString = txt_codigo.Text Then
                        cbo_producto.SelectedValue = txt_codigo.Text
                        Dim tabla As Data.DataTable
                        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT Precio_Lista_" + precio1.ToString + " FROM Producto WHERE Codigo = " + cbo_producto.SelectedValue.ToString)
                        precio2 = tabla.Rows(0).Item(0)
                        Dim importe As Double
                        'listar_precio(txt_cantidad)                        
                        importe = Double.Parse(txt_cantidad.Text)
                        importe = importe * precio2
                        Dim ban As Boolean = True
                        If dgv_detalles.Rows.Count > 0 Then
                            For j As Integer = 0 To dgv_detalles.Rows.Count - 1
                                If ban Then
                                    If precio2 = dgv_detalles.Rows(j).Cells(3).Value Then
                                        If dgv_detalles.Rows(j).Cells(0).Value = cbo_producto.SelectedValue Then
                                            ban = False
                                            total = (total - dgv_detalles.Rows(j).Cells(4).Value)
                                            Dim cantidad As Double = Double.Parse(txt_cantidad.Text)
                                            dgv_detalles.Rows(j).Cells(1).Value = dgv_detalles.Rows(j).Cells(1).Value + cantidad
                                            importe = importe + dgv_detalles.Rows(j).Cells(4).Value
                                            dgv_detalles.Rows(j).Cells(4).Value = importe
                                        End If
                                    End If
                                End If
                            Next
                        End If
                        If ban Then
                            dgv_detalles.Rows.Add(New Object() {cbo_producto.SelectedValue, Double.Parse(txt_cantidad.Text), cbo_producto.Text, precio2, importe})
                        End If
                        cantidad_total = cantidad_total + Double.Parse(txt_cantidad.Text)
                        lbl_cantidad_total.Text = cantidad_total
                        total = total + importe
                        lbl_total.Text = total
                        txt_cantidad.Text = ""
                        txt_codigo.Text = ""
                        txt_codigo.Enabled = False
                        btn_agregar.Enabled = False
                        txt_cantidad.Focus()
                        Exit Sub
                    End If
                Next
                MsgBox("Producto no encontrado, verifique el codigo ingresado")
                txt_codigo.Text = ""
                txt_codigo.Refresh()
        End Select
    End Sub

    Private Sub txt_cantidad_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cantidad.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If cbo_cliente.SelectedValue = 0 Then
                    MsgBox("Seleccione un cliente")
                    Exit Sub
                End If
                If txt_cantidad.Text = "" Then
                    MsgBox("Ingrese una cantidad")
                    Exit Sub
                End If
                btn_agregar.Enabled = True
                txt_codigo.Text = ""
                txt_codigo.Enabled = True
                txt_codigo.Focus()
        End Select
    End Sub
End Class