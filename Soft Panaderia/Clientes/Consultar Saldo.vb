Public Class Consultar_Saldo

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Close()
    End Sub

    Private Sub Consultar_Saldo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Consultar_Saldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        Top = Clientes.Top
        Left = Clientes.Left
        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT Codigo, Razon_Social FROM Cliente WHERE Borrado = 0")
        cbo_cliente.DataSource = tabla
        cbo_cliente.DisplayMember = "Razon_Social"
        cbo_cliente.ValueMember = "Codigo"
        cbo_cliente.SelectedValue = Clientes.dgv_clientes.CurrentRow.Cells(0).Value.ToString
        txt_total.Enabled = False
        cbo_cliente.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cargar_grilla(id_cliente As String)
        Dim tabla As Data.DataTable
        Dim total As Double = 0
        tabla = BDHelper.getDBHelper().ConsultaSQL("SELECT F.Fecha, F.Id, F.Total, F.SaldoCliente FROM Factura F WHERE F.Id_cliente = " + id_cliente + " AND F.Cancelada = 0 AND Cuenta_corriente = 1 ORDER BY F.Fecha DESC")
        For i As Integer = 0 To tabla.Rows.Count - 1
            dgv_consultarSaldo.Rows.Add(New Object() {Convert.ToDateTime(tabla.Rows(i).Item(0).ToString), "Factura: " + tabla.Rows(i).Item(1).ToString, tabla.Rows(i).Item(2).ToString, "", tabla.Rows(i).Item(3).ToString})
            total = total + tabla.Rows(i).Item(2)
        Next
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT R.Fecha, R.Id_recibo, R.Monto, R.SaldoCliente FROM Recibo R WHERE R.Cuenta_corriente = 1 AND R.Id_cliente = " + id_cliente + " ORDER BY R.Fecha DESC")
        For i = 0 To tabla.Rows.Count - 1
            dgv_consultarSaldo.Rows.Add(New Object() {Convert.ToDateTime(tabla.Rows(i).Item(0).ToString), "Recibo: " + tabla.Rows(i).Item(1).ToString, "", tabla.Rows(i).Item(2).ToString, tabla.Rows(i).Item(3).ToString})
            total = total - tabla.Rows(i).Item(2)
        Next
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT Fecha, Id, Monto, SaldoCliente FROM NotaCredito WHERE Id_Cliente = " + id_cliente + " ORDER BY Fecha DESC")
        For i = 0 To tabla.Rows.Count - 1
            dgv_consultarSaldo.Rows.Add(New Object() {Convert.ToDateTime(tabla.Rows(i).Item(0).ToString), "N. Credito: " + tabla.Rows(i).Item(1).ToString, "", tabla.Rows(i).Item(2).ToString, tabla.Rows(i).Item(3).ToString})
            total = total - tabla.Rows(i).Item(2)
        Next
        total = Math.Round(total, 3)
        txt_total.Text = total.ToString
        dgv_consultarSaldo.Sort(dgv_consultarSaldo.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub cbo_cliente_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_cliente.SelectedValueChanged
        dgv_consultarSaldo.Rows.Clear()
        If cbo_cliente.SelectedValue.ToString = "System.Data.DataRowView" Then
            Exit Sub
        Else
            cargar_grilla(cbo_cliente.SelectedValue.ToString)
        End If
    End Sub
End Class