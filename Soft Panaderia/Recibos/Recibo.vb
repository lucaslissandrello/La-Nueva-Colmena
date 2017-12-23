Public Class Recibo
    Dim ban As Boolean = False
    Dim primeraVuelta As Boolean = True
    Private Sub Recibo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        
        If ban = False Then
            If MsgBox("¿Desea salir sin guardar los cambios?", MsgBoxStyle.YesNo, "Salir") = MsgBoxResult.No Then
                e.Cancel = True
                Exit Sub
            End If
        End If
        Me.Dispose()
    End Sub

    Private Sub Recibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r As New Globalization.CultureInfo("es-ES")
        r.NumberFormat.CurrencyDecimalSeparator = "."
        r.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture = r
        If Factura.desdeFactura Then
            primeraVuelta = False
        End If
        MaximizeBox = False
        Top = Recibos.Top
        Left = Recibos.Left
        txt_montoM.Enabled = False
        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT Codigo, Razon_Social FROM Cliente WHERE Borrado = 0 AND Saldo > 0")
        cbo_cliente.DataSource = tabla
        cbo_cliente.DisplayMember = "Razon_Social"
        cbo_cliente.ValueMember = "Codigo"
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT MAX(Id_recibo) FROM Recibo")
        If tabla.Rows(0).Item(0).ToString = "" Then
            lbl_recibo.Text = "1"
        Else
            lbl_recibo.Text = (tabla.Rows(0).Item(0) + 1)
        End If
        If primeraVuelta Then
            cbo_cliente.SelectedValue = -1
            primeraVuelta = False
        Else
            cbo_cliente.SelectedValue = Factura.cbo_cliente.SelectedValue
            cbo_cliente.Enabled = False
            dtp_fecha.Value = (Factura.dtp_fecha.Value).AddSeconds(1)
            dtp_fecha.Enabled = False
        End If
        cbo_cliente.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If cbo_cliente.SelectedIndex = -1 Then
            MsgBox("Seleccione un cliente, no hay un cliente seleccionado.")
            Exit Sub
        End If
        'listar_precio(txt_montoM, txt_montoM)
        If txt_montoM.Text = "0." Then
            MsgBox("Ingrese un monto a abonar")
            Exit Sub
        End If
        If Val(txt_montoM.Text) > Val(lbl_total.Text) Then
            MsgBox("El monto a abonar por parte del cliente es superior a la deuda total de facturas del cliente")
            Exit Sub
        End If
        txt_montoM.Enabled = False
        If BDHelper.getDBHelper.finalizarRecibo = True Then
            ban = True
            MsgBox("Recibo guardado con exito")
            Me.Close()
        Else
            MsgBox("Recibo no guardado, verifique los datos")
        End If
    End Sub

    Private Sub cargar_grilla()
        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper().ConsultaSQL("SELECT F.Id, F.Fecha, F.Total, F.Saldo FROM Factura F WHERE F.Id_cliente = " + lbl_codigo.Text.ToString + " AND F.Cancelada = 0 ORDER BY F.Fecha, F.Id")
        Dim total As Double = 0
        For i As Integer = 0 To tabla.Rows.Count - 1
            If tabla.Rows(i).Item(3) <> 0 Then
                total = total + tabla.Rows(i).Item(3)
                dgv_facturas.Rows.Add(New Object() {"SI", tabla.Rows(i).Item(0).ToString, tabla.Rows(i).Item(1).ToString, tabla.Rows(i).Item(2).ToString, tabla.Rows(i).Item(3)})
                txt_montoM.Enabled = True
            End If
        Next
        lbl_total.Text = total.ToString
    End Sub

    Private Sub cbo_cliente_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_cliente.SelectedValueChanged
        If primeraVuelta = False Then
            If cbo_cliente.SelectedValue.ToString = "System.Data.DataRowView" Then
                Exit Sub
            End If
            txt_montoM.Enabled = True
            btn_guardar.Enabled = True
            dtp_fecha.Enabled = True
            txt_montoM.Enabled = True
            lbl_codigo.Text = cbo_cliente.SelectedValue.ToString
            dgv_facturas.Rows.Clear()
            cargar_grilla()
        End If
    End Sub
    Private Sub dgv_facturas_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_facturas.CellMouseDoubleClick
        If dgv_facturas.CurrentRow.Cells(0).Value = "SI" Then
            dgv_facturas.CurrentRow.Cells(0).Value = "NO"
            Dim total As Double = dgv_facturas.CurrentRow.Cells(4).Value
            total = lbl_total.Text - total
            lbl_total.Text = total.ToString
        Else
            dgv_facturas.CurrentRow.Cells(0).Value = "SI"
            Dim total As Double = dgv_facturas.CurrentRow.Cells(4).Value
            total = lbl_total.Text + total
            lbl_total.Text = total.ToString
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class