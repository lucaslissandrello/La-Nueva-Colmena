Public Class Recibos
    Private Sub Recibo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Recibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        Top = Principal.Top
        Left = Principal.Left
        btn_ver.Enabled = False
        btn_imprimir.Enabled = False
        btn_cancelar.Enabled = False
        rb_fecha.Checked = True
        Dim i As Integer
        For i = 0 To dgv_recibos.Columns.Count - 1
            dgv_recibos.Columns.Item(i).SortMode = DataGridViewColumnSortMode.Programmatic
        Next
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Close()
    End Sub

    Private Sub cargar_grilla()

        Dim tabla As Data.DataTable
        Dim cuenta_corriente As String
        tabla = BDHelper.getDBHelper().ConsultaSQL("SELECT R.Id_recibo, R.Fecha, C.Razon_Social, R.Monto, C.Codigo, R.Cuenta_corriente FROM Recibo R INNER JOIN Cliente C ON R.Id_cliente = C.Codigo WHERE C.Borrado = 0 ORDER BY R.Fecha DESC, R.Id_recibo")
        For i As Integer = 0 To tabla.Rows.Count - 1
            If tabla.Rows(i).Item(5) = 1 Then
                cuenta_corriente = "Cuenta Corriente"
            Else
                cuenta_corriente = "Contado"
            End If
            dgv_recibos.Rows.Add(New Object() {tabla.Rows(i).Item(0).ToString, tabla.Rows(i).Item(1).ToString, tabla.Rows(i).Item(2).ToString, tabla.Rows(i).Item(3).ToString, tabla.Rows(i).Item(4).ToString, cuenta_corriente})
        Next

    End Sub
    Private Sub cargar_grilla_numero()
        Dim tabla As Data.DataTable
        Dim cuenta_corriente As String
        tabla = BDHelper.getDBHelper().ConsultaSQL("SELECT R.Id_recibo, R.Fecha, C.Razon_Social, R.Monto, C.Codigo, R.Cuenta_corriente FROM Recibo R INNER JOIN Cliente C ON R.Id_cliente = C.Codigo WHERE C.Borrado = 0 ORDER BY R.Id_recibo, R.Fecha")
        For i As Integer = 0 To tabla.Rows.Count - 1
            If tabla.Rows(i).Item(5) = 1 Then
                cuenta_corriente = "Cuenta Corriente"
            Else
                cuenta_corriente = "Contado"
            End If
            dgv_recibos.Rows.Add(New Object() {tabla.Rows(i).Item(0).ToString, tabla.Rows(i).Item(1).ToString, tabla.Rows(i).Item(2).ToString, tabla.Rows(i).Item(3).ToString, tabla.Rows(i).Item(4).ToString, cuenta_corriente})
        Next
    End Sub


    Private Sub cargar_grilla_cliente()
        Dim tabla As Data.DataTable
        Dim cuenta_corriente As String
        tabla = BDHelper.getDBHelper().ConsultaSQL("SELECT R.Id_recibo, R.Fecha, C.Razon_Social, R.Monto, C.Codigo, R.Cuenta_corriente FROM Recibo R INNER JOIN Cliente C ON R.Id_cliente = C.Codigo WHERE C.Borrado = 0 ORDER BY C.Razon_Social, R.Id_recibo")
        For i As Integer = 0 To tabla.Rows.Count - 1
            If tabla.Rows(i).Item(5) = 1 Then
                cuenta_corriente = "Cuenta Corriente"
            Else
                cuenta_corriente = "Contado"
            End If
            dgv_recibos.Rows.Add(New Object() {tabla.Rows(i).Item(0).ToString, tabla.Rows(i).Item(1).ToString, tabla.Rows(i).Item(2).ToString, tabla.Rows(i).Item(3).ToString, tabla.Rows(i).Item(4).ToString, cuenta_corriente})
        Next
    End Sub

    Private Sub txt_buscar_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_buscar.MouseClick
        txt_buscar.Text = ""
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim texto As String = txt_buscar.Text
        Dim tabla As Data.DataTable
        Dim cuenta_corriente As String
        Dim cmd As String = "SELECT R.Id_recibo, R.Fecha, C.Razon_Social, R.Monto, C.Codigo, R.Cuenta_corriente FROM Recibo R INNER JOIN Cliente C ON R.Id_cliente = C.Codigo WHERE C.Borrado = 0 and C.Razon_Social LIKE '" + texto + "%'"
        If rb_fecha.Checked = True Then
            cmd = cmd + " ORDER BY R.Fecha, R.Id_Recibo"
        ElseIf rb_numero.Checked Then
            cmd = cmd + " ORDER BY R.Id_Recibo, R.Fecha"
        Else
            cmd = cmd + " ORDER BY C.Razon_Social, R.Id_Recibo"
        End If
        tabla = BDHelper.getDBHelper.ConsultaSQL(cmd)
        If tabla.Rows.Count = 0 Then
            MsgBox("Cliente no encontrado, verifique que ha ingresado correctamente los datos.")
        Else
            dgv_recibos.Rows.Clear()
            For i As Integer = 0 To tabla.Rows.Count - 1
                If tabla.Rows(i).Item(5) = 1 Then
                    cuenta_corriente = "Cuenta Corriente"
                Else
                    cuenta_corriente = "Contado"
                End If
                dgv_recibos.Rows.Add(New Object() {tabla.Rows(i).Item(0).ToString, tabla.Rows(i).Item(1).ToString, tabla.Rows(i).Item(2).ToString, tabla.Rows(i).Item(3).ToString, tabla.Rows(i).Item(4).ToString, cuenta_corriente})
            Next

        End If

    End Sub

    Private Sub btn_mostrar_todos_Click(sender As Object, e As EventArgs) Handles btn_mostrar_todos.Click
        txt_buscar.Text = ""
        dgv_recibos.Rows.Clear()
        If rb_fecha.Checked = True Then
            cargar_grilla()
        Else
            cargar_grilla_numero()
        End If
    End Sub

    Private Sub dgv_recibos_Click(sender As Object, e As EventArgs) Handles dgv_recibos.Click
        If dgv_recibos.CurrentRow Is Nothing Then
            Exit Sub
        End If
        If dgv_recibos.CurrentRow.Cells(5).Value = "Contado" Then
            btn_imprimir.Enabled = True
            btn_ver.Enabled = True
            btn_cancelar.Enabled = False
        Else
            btn_imprimir.Enabled = True
            btn_ver.Enabled = True
            btn_cancelar.Enabled = True
        End If
    End Sub

    Private Sub btn_ver_Click(sender As Object, e As EventArgs) Handles btn_ver.Click
        Detalle_Recibo.ShowDialog()
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT Codigo, Razon_Social FROM Cliente WHERE Borrado = 0 AND Saldo > 0")
        If tabla.Rows.Count = 0 Then
            MsgBox("No se encuentran facturas/clientes registrados para generar un recibo")
            Exit Sub
        End If
        Recibo.ShowDialog()
        dgv_recibos.Rows.Clear()
        cargar_grilla()
    End Sub

    Private Sub rb_fecha_CheckedChanged(sender As Object, e As EventArgs) Handles rb_fecha.CheckedChanged
        If txt_buscar.Text = "" Or txt_buscar.Text = "Buscar cliente..." Then
            dgv_recibos.Rows.Clear()
            cargar_grilla()
        Else
            btn_buscar_Click(sender, e)
        End If
    End Sub

    Private Sub rb_numero_CheckedChanged(sender As Object, e As EventArgs) Handles rb_numero.CheckedChanged
        If txt_buscar.Text = "" Or txt_buscar.Text = "Buscar cliente..." Then
            dgv_recibos.Rows.Clear()
            cargar_grilla_numero()
        Else
            btn_buscar_Click(sender, e)
        End If
    End Sub

    Private Sub rb_cliente_CheckedChanged(sender As Object, e As EventArgs) Handles rb_cliente.CheckedChanged
        If txt_buscar.Text = "" Or txt_buscar.Text = "Buscar cliente..." Then
            dgv_recibos.Rows.Clear()
            cargar_grilla_cliente()
        Else
            btn_buscar_Click(sender, e)
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Dim clienteNombre As String = dgv_recibos.CurrentRow.Cells(2).Value
        Dim tabla As DataTable = BDHelper.getDBHelper.ConsultaSQL("SELECT MAX(F.Fecha) AS Expr1 FROM Factura F INNER JOIN Cliente C ON C.Codigo = F.Id_cliente WHERE (F.Cancelada = 0 AND C.Razon_Social = '" + clienteNombre + "')")
        Dim fecha1 As DateTime = Convert.ToDateTime(tabla.Rows(0).Item(0))
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT MAX(R.Fecha) AS Expr2 FROM Recibo R INNER JOIN Cliente C ON C.Codigo = R.Id_cliente WHERE (C.Razon_Social = '" + clienteNombre + "')")
        Dim fecha2 As DateTime = Convert.ToDateTime(tabla.Rows(0).Item(0))
        Dim mayor As DateTime
        If (fecha1 > fecha2) Then
            mayor = fecha1
        Else mayor = fecha2
        End If
        If (mayor <> dgv_recibos.CurrentRow.Cells(1).Value) Then
            MsgBox("Hay otro Recibo/Factura mas nuevo que el que intenta borrar, primero borre ese y luego podra borrar este.")
            Exit Sub
        End If
        If MsgBox("¿Esta seguro que desea cancelar este recibo? El recibo no podra ser recuperado", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        If BDHelper.getDBHelper.cancelarRecibo() Then
            MsgBox("Recibo cancelado con exito")
        Else
            MsgBox("Error, no se pudo cancelar el recibo")
        End If
        dgv_recibos.Rows.Clear()
        If rb_fecha.Checked = True Then
            cargar_grilla()
        Else
            cargar_grilla_numero()
        End If
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        Imprimir_Recibo.ShowDialog()
    End Sub
End Class