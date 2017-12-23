Public Class Facturacion

    Private Sub Facturacion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        Top = Principal.Top
        Left = Principal.Left
        btn_ver.Enabled = False
        btn_imprimir.Enabled = False
        btn_cancelar.Enabled = False
        rb_fecha.Checked = True
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Close()
    End Sub

    Private Sub cargar_grilla()
        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper().ConsultaSQL("SELECT F.Id, F.Fecha, C.Razon_Social, F.Total, C.Codigo, F.Saldo FROM Factura F INNER JOIN Cliente C ON F.Id_cliente = C.Codigo WHERE C.Borrado = 0 AND F.Cancelada = 0 ORDER BY F.Fecha DESC, F.Id")
        For i As Integer = 0 To tabla.Rows.Count - 1
            dgv_facturas.Rows.Add(New Object() {tabla.Rows(i).Item(0).ToString, Convert.ToDateTime(tabla.Rows(i).Item(1).ToString), tabla.Rows(i).Item(2).ToString, tabla.Rows(i).Item(3).ToString, tabla.Rows(i).Item(4).ToString, tabla.Rows(i).Item(5), "F"})
        Next
        tabla = BDHelper.getDBHelper().ConsultaSQL("SELECT NC.Id, NC.Fecha, C.Razon_Social, NC.Monto, C.Codigo, NC.Saldo FROM NotaCredito NC INNER JOIN Cliente C ON NC.Id_Cliente = C.Codigo WHERE C.Borrado = 0 ORDER BY NC.Fecha, NC.Id")
        For i As Integer = 0 To tabla.Rows.Count - 1
            dgv_facturas.Rows.Add(New Object() {tabla.Rows(i).Item(0).ToString, Convert.ToDateTime(tabla.Rows(i).Item(1).ToString), tabla.Rows(i).Item(2).ToString, tabla.Rows(i).Item(3).ToString, tabla.Rows(i).Item(4).ToString, tabla.Rows(i).Item(5), "NC"})
        Next
        dgv_facturas.Sort(dgv_facturas.Columns(1), System.ComponentModel.ListSortDirection.Descending)
    End Sub
    Private Sub cargar_grilla_numero()
        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper().ConsultaSQL("SELECT F.Id, F.Fecha, C.Razon_Social, F.Total, C.Codigo, F.Saldo FROM Factura F INNER JOIN Cliente C ON F.Id_cliente = C.Codigo WHERE C.Borrado = 0 AND F.Cancelada = 0 ORDER BY F.Id")
        For i As Integer = 0 To tabla.Rows.Count - 1
            dgv_facturas.Rows.Add(New Object() {tabla.Rows(i).Item(0).ToString, tabla.Rows(i).Item(1).ToString, tabla.Rows(i).Item(2).ToString, tabla.Rows(i).Item(3).ToString, tabla.Rows(i).Item(4).ToString, tabla.Rows(i).Item(5), "F"})
        Next
        tabla = BDHelper.getDBHelper().ConsultaSQL("SELECT NC.Id, NC.Fecha, C.Razon_Social, NC.Monto, C.Codigo, NC.Saldo FROM NotaCredito NC INNER JOIN Cliente C ON NC.Id_Cliente = C.Codigo WHERE C.Borrado = 0 ORDER BY NC.Id")
        For i As Integer = 0 To tabla.Rows.Count - 1
            dgv_facturas.Rows.Add(New Object() {tabla.Rows(i).Item(0).ToString, tabla.Rows(i).Item(1).ToString, tabla.Rows(i).Item(2).ToString, tabla.Rows(i).Item(3).ToString, tabla.Rows(i).Item(4).ToString, tabla.Rows(i).Item(5), "NC"})
        Next
    End Sub

    Private Sub cargar_grilla_cliente()
        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper().ConsultaSQL("SELECT F.Id, F.Fecha, C.Razon_Social, F.Total, C.Codigo, F.Saldo FROM Factura F INNER JOIN Cliente C ON F.Id_cliente = C.Codigo WHERE C.Borrado = 0 AND F.Cancelada = 0 ORDER BY C.Razon_Social, F.Id")
        For i As Integer = 0 To tabla.Rows.Count - 1
            dgv_facturas.Rows.Add(New Object() {tabla.Rows(i).Item(0).ToString, tabla.Rows(i).Item(1).ToString, tabla.Rows(i).Item(2).ToString, tabla.Rows(i).Item(3).ToString, tabla.Rows(i).Item(4).ToString, tabla.Rows(i).Item(5), "F"})
        Next
        tabla = BDHelper.getDBHelper().ConsultaSQL("SELECT NC.Id, NC.Fecha, C.Razon_Social, NC.Monto, C.Codigo, NC.Saldo FROM NotaCredito NC INNER JOIN Cliente C ON NC.Id_Cliente = C.Codigo WHERE C.Borrado = 0 ORDER BY C.Razon_Social, NC.Id")
        For i As Integer = 0 To tabla.Rows.Count - 1
            dgv_facturas.Rows.Add(New Object() {tabla.Rows(i).Item(0).ToString, tabla.Rows(i).Item(1).ToString, tabla.Rows(i).Item(2).ToString, tabla.Rows(i).Item(3).ToString, tabla.Rows(i).Item(4).ToString, tabla.Rows(i).Item(5), "NC"})
        Next
    End Sub

    Private Sub txt_buscar_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_buscar.MouseClick
        txt_buscar.Text = ""
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim texto As String = txt_buscar.Text
        Dim tabla As Data.DataTable
        Dim tablaCliente As Data.DataTable
        Dim cmd As String
        cmd = "SELECT Codigo FROM Cliente WHERE Borrado = 0 AND Razon_Social LIKE '%" + texto + "%'"
        tablaCliente = BDHelper.getDBHelper.ConsultaSQL(cmd)
        If tablaCliente.Rows.Count = 0 Then
            MsgBox("Cliente no encontrado, verifique que ha ingresado correctamente los datos.")
            Exit Sub
        Else
            dgv_facturas.Rows.Clear()
            For j As Integer = 0 To tablaCliente.Rows.Count - 1
                cmd = "SELECT F.Id, F.Fecha, C.Razon_Social, F.Total, C.Codigo, F.Saldo FROM Factura F INNER JOIN Cliente C ON F.Id_cliente = C.Codigo WHERE F.Cancelada = 0 and C.Codigo = " + tablaCliente.Rows(j).Item(0).ToString
                If rb_fecha.Checked = True Then
                    cmd = cmd + " ORDER BY F.Fecha, F.Id"
                ElseIf rb_numero.Checked = True Then
                    cmd = cmd + " ORDER BY F.Id"
                Else
                    cmd = cmd + " ORDER BY C.Razon_Social, F.Id"
                End If
                tabla = BDHelper.getDBHelper.ConsultaSQL(cmd)
                For i As Integer = 0 To tabla.Rows.Count - 1
                    dgv_facturas.Rows.Add(New Object() {tabla.Rows(i).Item(0).ToString, tabla.Rows(i).Item(1).ToString, tabla.Rows(i).Item(2).ToString, tabla.Rows(i).Item(3).ToString, tabla.Rows(i).Item(4).ToString, tabla.Rows(i).Item(5), "F"})
                Next
                cmd = "SELECT NC.Id, NC.Fecha, C.Razon_Social, NC.Monto, C.Codigo, NC.Saldo FROM NotaCredito NC INNER JOIN Cliente C ON NC.Id_Cliente = C.Codigo WHERE C.Codigo = " + tablaCliente.Rows(j).Item(0).ToString
                If rb_fecha.Checked = True Then
                    cmd = cmd + " ORDER BY NC.Fecha, NC.Id"
                ElseIf rb_numero.Checked = True Then
                    cmd = cmd + " ORDER BY NC.Id"
                Else
                    cmd = cmd + " ORDER BY C.Razon_Social, NC.Id"
                End If
                tabla = BDHelper.getDBHelper.ConsultaSQL(cmd)
                For i = 0 To tabla.Rows.Count - 1
                    dgv_facturas.Rows.Add(New Object() {tabla.Rows(i).Item(0).ToString, tabla.Rows(i).Item(1).ToString, tabla.Rows(i).Item(2).ToString, tabla.Rows(i).Item(3).ToString, tabla.Rows(i).Item(4).ToString, tabla.Rows(i).Item(5), "NC"})
                Next
            Next
        End If
        If dgv_facturas.Rows.Count = 0 Then
            MsgBox("No hay facturas/nota de credito para el cliente buscado")
            If rb_fecha.Checked = True Then
                cargar_grilla()
            ElseIf rb_numero.Checked = True Then
                cargar_grilla_numero()
            Else
                cargar_grilla_cliente()
            End If
        End If
    End Sub

    Private Sub btn_mostrar_todos_Click(sender As Object, e As EventArgs) Handles btn_mostrar_todos.Click
        txt_buscar.Text = ""
        dgv_facturas.Rows.Clear()
        If rb_fecha.Checked = True Then
            cargar_grilla()
        ElseIf rb_numero.Checked Then
            cargar_grilla_numero()
        Else
            cargar_grilla_cliente()
        End If
    End Sub

    Private Sub dgv_facturas_Click(sender As Object, e As EventArgs) Handles dgv_facturas.Click
        If dgv_facturas.CurrentRow Is Nothing Then
            Exit Sub
        End If
        btn_imprimir.Enabled = True
        btn_ver.Enabled = True
        If dgv_facturas.CurrentRow.Cells(6).Value = "F" Then
            btn_cancelar.Enabled = True
        Else
            btn_cancelar.Enabled = False
        End If
    End Sub

    Private Sub btn_ver_Click(sender As Object, e As EventArgs) Handles btn_ver.Click
        Detalle_Factura.ShowDialog()
    End Sub

    Private Sub btn_nueva_Click(sender As Object, e As EventArgs) Handles btn_nueva.Click
        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT Codigo, Razon_Social, Lista_precio FROM Cliente WHERE Borrado = 0")
        If tabla.Rows.Count = 0 Then
            MsgBox("No se encuentran clientes registrados para generar una factura")
            Exit Sub
        End If
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT Codigo, Producto FROM Producto WHERE Borrado = 0")
        If tabla.Rows.Count = 0 Then
            MsgBox("No se encuentran productos registrados para generar una factura")
            Exit Sub
        End If
        Factura.ShowDialog()
        dgv_facturas.Rows.Clear()
        cargar_grilla()
    End Sub

    Private Sub rb_fecha_CheckedChanged(sender As Object, e As EventArgs) Handles rb_fecha.CheckedChanged
        If txt_buscar.Text = "" Or txt_buscar.Text = "Buscar cliente..." Then
            dgv_facturas.Rows.Clear()
            cargar_grilla()
        Else
            btn_buscar_Click(sender, e)
        End If
    End Sub

    Private Sub rb_numero_CheckedChanged(sender As Object, e As EventArgs) Handles rb_numero.CheckedChanged
        If txt_buscar.Text = "" Or txt_buscar.Text = "Buscar cliente..." Then
            dgv_facturas.Rows.Clear()
            cargar_grilla_numero()
        Else
            btn_buscar_Click(sender, e)
        End If
    End Sub
    Private Sub rb_cliente_CheckedChanged(sender As Object, e As EventArgs) Handles rb_cliente.CheckedChanged
        If txt_buscar.Text = "" Or txt_buscar.Text = "Buscar cliente..." Then
            dgv_facturas.Rows.Clear()
            cargar_grilla_cliente()
        Else
            btn_buscar_Click(sender, e)
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If dgv_facturas.CurrentRow.Cells(3).Value <> dgv_facturas.CurrentRow.Cells(5).Value Then
            MsgBox("La factura presenta un pago realizado por lo que no puede ser borrada")
            Exit Sub
        End If
        'fijarse si es la ultima factura o recibo
        Dim clienteNombre As String = dgv_facturas.CurrentRow.Cells(2).Value
        Dim tabla As DataTable = BDHelper.getDBHelper.ConsultaSQL("SELECT MAX(F.Fecha) AS Expr1 FROM Factura F INNER JOIN Cliente C ON C.Codigo = F.Id_cliente WHERE (F.Cancelada = 0 AND C.Razon_Social = '" + clienteNombre + "')")
        Dim fecha1 As DateTime
        Dim fecha2 As DateTime
        If (tabla.Rows(0).Item(0) Is DBNull.Value) Then
            Dim dateString As String = "01/01/1900"
            fecha1 = Convert.ToDateTime(dateString)
        Else
            fecha1 = Convert.ToDateTime(tabla.Rows(0).Item(0))
        End If
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT MAX(R.Fecha) AS Expr2 FROM Recibo R INNER JOIN Cliente C ON C.Codigo = R.Id_cliente WHERE (C.Razon_Social = '" + clienteNombre + "')")
        If (tabla.Rows(0).Item(0) Is DBNull.Value) Then
            Dim dateString1 As String = "01/01/1900"
            fecha2 = Convert.ToDateTime(dateString1)
        Else
            fecha2 = Convert.ToDateTime(tabla.Rows(0).Item(0))
        End If
        Dim mayor As DateTime
        If (fecha1 >= fecha2) Then
            mayor = fecha1
        Else mayor = fecha2
        End If
        If (mayor <> dgv_facturas.CurrentRow.Cells(1).Value) Then
            MsgBox("Hay otro Recibo/Factura mas nuevo que el que intenta borrar, primero borre ese y luego podra borrar este.")
            Exit Sub
        End If

        If MsgBox("¿Esta seguro que desea cancelar esta factura? La factura no podra ser recuperada", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        If BDHelper.getDBHelper.cancelarFactura() Then
            MsgBox("Factura cancelada con exito")
        Else
            MsgBox("No se pudo cancelar la factura")
        End If
        dgv_facturas.Rows.Clear()
        If rb_fecha.Checked = True Then
            cargar_grilla()
        Else
            cargar_grilla_numero()
        End If
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        If dgv_facturas.CurrentRow.Cells(6).Value = "F" Then
            Imprimir_Factura.ShowDialog()
        Else
            ImprimirNotaCredito.ShowDialog()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_nota_credito.Click
        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT Codigo, Razon_Social, Lista_precio FROM Cliente WHERE Borrado = 0")
        If tabla.Rows.Count = 0 Then
            MsgBox("No se encuentran clientes registrados para generar una nota de credito")
            Exit Sub
        End If
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT Codigo, Producto FROM Producto WHERE Borrado = 0")
        If tabla.Rows.Count = 0 Then
            MsgBox("No se encuentran productos registrados para generar una nota de credito")
            Exit Sub
        End If
        NotaCredito.ShowDialog()
        dgv_facturas.Rows.Clear()
        cargar_grilla()
    End Sub
End Class