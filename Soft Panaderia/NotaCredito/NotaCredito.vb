Public Class NotaCredito
    Private cantidad_total As Double
    Public desdeFactura As Boolean = False
    Dim total As Double
    Dim ban As Boolean
    Dim primeraVuelta As Boolean = True
    Dim precio1 As Integer
    Dim precio2 As Double
    Dim tabla2 As Data.DataTable
    Private Sub NotaCredito_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ban = False Then
            If MsgBox("¿Desea salir sin guardar los cambios?", MsgBoxStyle.YesNo, "Salir") = MsgBoxResult.No Then
                e.Cancel = True
                Exit Sub
            End If
        End If
        Me.Dispose()
    End Sub
    Private Sub NotaCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r As New Globalization.CultureInfo("es-ES")
        r.NumberFormat.CurrencyDecimalSeparator = "."
        r.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture = r
        MaximizeBox = False
        Top = Facturacion.Top
        Left = Facturacion.Left
        ban = False
        txt_cantidad.Enabled = False
        cbo_factura.Enabled = False
        cbo_producto.Enabled = False
        lbl_codigo.Text = ""
        lbl_id.Text = ""
        lbl_cantidad_total.Text = "0"
        lbl_total.Text = "0"
        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT Codigo, Razon_Social, Lista_precio FROM Cliente WHERE Borrado = 0")
        cbo_cliente.DataSource = tabla
        cbo_cliente.DisplayMember = "Razon_Social"
        cbo_cliente.ValueMember = "Codigo"
        tabla2 = BDHelper.getDBHelper.ConsultaSQL("SELECT Codigo, Producto FROM Producto WHERE Borrado = 0")
        cbo_producto.DataSource = tabla2
        cbo_producto.DisplayMember = "Producto"
        cbo_producto.ValueMember = "Codigo"
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT MAX(Id) FROM NotaCredito")
        If tabla.Rows(0).Item(0).ToString = "" Then
            lbl_id.Text = "1"
        Else
            lbl_id.Text = (tabla.Rows(0).Item(0) + 1)
        End If
        cbo_cliente.SelectedValue = -1
        cbo_cliente.DropDownStyle = ComboBoxStyle.DropDownList
        cbo_factura.DropDownStyle = ComboBoxStyle.DropDownList
        cbo_producto.DropDownStyle = ComboBoxStyle.DropDownList
        txt_codigo.Enabled = False
        primeraVuelta = False
        chk_comprobantes.Enabled = False
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

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Close()
    End Sub
    Private Sub cbo_cliente_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_cliente.SelectedValueChanged
        If primeraVuelta Then
            Exit Sub
        Else
            lbl_codigo.Text = cbo_cliente.SelectedValue.ToString
            Dim tabla As Data.DataTable
            txt_cantidad.Enabled = True
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
            tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT Id FROM Factura WHERE Cancelada = 0 AND Saldo = 0 AND Id_cliente = " + cbo_cliente.SelectedValue.ToString)
            cbo_factura.DataSource = tabla
            cbo_factura.ValueMember = "Id"
            cbo_factura.DisplayMember = "Id"
            chk_comprobantes.Enabled = True
            If tabla.Rows.Count = 0 Then
                chk_comprobantes.Enabled = False
            End If
        End If
    End Sub

    Private Sub cbo_factura_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_factura.SelectedValueChanged
        If cbo_factura.Enabled = True Then
            If primeraVuelta Then
                Exit Sub
            Else
                Dim tabla As Data.DataTable
                tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT P.Codigo, DF.Cantidad, P.Producto, DF.Precio_facturado FROM DetalleFactura DF INNER JOIN Producto P ON DF.Id_producto = P.Codigo WHERE DF.Id_factura = " + cbo_factura.SelectedValue.ToString)
                Dim monto As Double = 0
                Dim total As Double = 0
                Dim cantidad As Integer = 0
                dgv_detalles.Rows.Clear()
                For i As Integer = 0 To tabla.Rows.Count - 1
                    monto = tabla.Rows(i).Item(1) * tabla.Rows(i).Item(3)
                    total = total + monto
                    cantidad = cantidad + tabla.Rows(i).Item(1)
                    dgv_detalles.Rows.Add(New Object() {tabla.Rows(i).Item(0), tabla.Rows(i).Item(1), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), monto})
                Next
                lbl_cantidad_total.Text = cantidad
                cantidad_total = cantidad
                lbl_total.Text = total
                Me.total = total
            End If
        End If
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If cbo_cliente.SelectedIndex = -1 Then
            MsgBox("Seleccione un cliente, no hay un cliente seleccionado.")
            Exit Sub
        End If
        If dgv_detalles.Rows.Count = 0 Then
            MsgBox("Seleccione una factura o cargue un producto")
            Exit Sub
        End If
        If BDHelper.getDBHelper.finalizarNotaCredito() Then
            MsgBox("Nota de credito generada con exito")
            ban = True
            Me.Close()
        Else
            MsgBox("No se pudo generar la nota de credito, verifique los datos")
        End If
    End Sub
    Private Sub txt_codigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_codigo.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                txt_codigo.Text = txt_codigo.Text.Replace(" "c, String.Empty)
                For i As Integer = 0 To tabla2.Rows.Count - 1
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
                txt_codigo.Enabled = True
                txt_codigo.Focus()
        End Select
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
    End Sub


    Private Sub chk_comprobantes_CheckedChanged(sender As Object, e As EventArgs) Handles chk_comprobantes.CheckedChanged
        If chk_comprobantes.Checked Then
            cbo_factura.Enabled = True
            cbo_factura.ResetText()
            txt_cantidad.Enabled = False
            txt_codigo.Enabled = False
            dgv_detalles.Rows.Clear()
            cantidad_total = 0
            total = 0
            lbl_cantidad_total.Text = "0"
            lbl_total.Text = "0"
        Else
            cbo_factura.Enabled = False
            txt_cantidad.Enabled = True
            dgv_detalles.Rows.Clear()
            cantidad_total = 0
            total = 0
            lbl_cantidad_total.Text = "0"
            lbl_total.Text = "0"
        End If
    End Sub
End Class