Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class Imprimir_Saldo
    'estas?sii bueno, ni idea jaja
    'ahi capaz qeu funque, o ya habias probado con eso? por que antes estaba datetime nono, no habia probado jajaj, proba :D yo toy mirando batman oka jajaj
    Private Sub Imprimir_Saldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Top = Clientes.Top
        Left = Clientes.Left
        Dim id_cliente = Clientes.dgv_clientes.CurrentRow.Cells(0).Value.ToString
        Dim tabla As Data.DataTable = New Data.DataTable
        tabla.Columns.Add("Fecha", GetType(Date))
        tabla.Columns.Add("Id")
        tabla.Columns.Add("Debe")
        tabla.Columns.Add("Haber")
        tabla.Columns.Add("Saldo")
        Dim tabla2 As Data.DataTable
        tabla2 = BDHelper.getDBHelper().ConsultaSQL("SELECT F.Fecha, F.Id, F.Total, F.SaldoCliente FROM Factura F WHERE F.Id_cliente = " + id_cliente + " AND F.Cancelada = 0 AND F.Cuenta_corriente = 1 ORDER BY F.Fecha DESC")
        For i As Integer = 0 To tabla2.Rows.Count - 1
            tabla.Rows.Add(New Object() {Convert.ToDateTime(tabla2.Rows(i).Item(0)).ToString, tabla2.Rows(i).Item(1).ToString, tabla2.Rows(i).Item(2).ToString, "", tabla2.Rows(i).Item(3).ToString})
        Next
        tabla2 = BDHelper.getDBHelper.ConsultaSQL("SELECT R.Fecha, R.Id_recibo, R.Monto, R.SaldoCliente FROM Recibo R WHERE R.Cuenta_corriente = 1 AND R.Id_cliente = " + id_cliente + " ORDER BY R.Fecha DESC")
        For i = 0 To tabla2.Rows.Count - 1
            tabla.Rows.Add(New Object() {Convert.ToDateTime(tabla2.Rows(i).Item(0)).ToString, tabla2.Rows(i).Item(1).ToString, "", tabla2.Rows(i).Item(2).ToString, tabla2.Rows(i).Item(3).ToString})
        Next
        tabla2 = BDHelper.getDBHelper.ConsultaSQL("SELECT Fecha, Id, Monto, SaldoCliente FROM NotaCredito WHERE Id_Cliente = " + id_cliente + " ORDER BY Fecha DESC")
        For i = 0 To tabla2.Rows.Count - 1
            tabla.Rows.Add(New Object() {Convert.ToDateTime(tabla2.Rows(i).Item(0).ToString), tabla2.Rows(i).Item(1).ToString, "", tabla2.Rows(i).Item(2).ToString, tabla2.Rows(i).Item(3).ToString})
        Next
        tabla.DefaultView.Sort = "Fecha DESC"
        'Dim dataView As New DataView(tabla)
        'For i As Integer = 0 To dataView.Count - 1
        '    Convert.ToDateTime(dataView.Item(i).Item(0).ToString)
        '    MsgBox(dataView.Item(i).Item(0).ToString)
        'Next
        'dataView.Sort = "Fecha DESC"
        'tabla = dataView.ToTable()
        SaldoDataSetBindingSource.DataSource = tabla
        Dim parametro As New List(Of ReportParameter)
        parametro.Add(New ReportParameter("Fecha", Date.Now))
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT Saldo, Razon_Social FROM Cliente WHERE Codigo = " + Clientes.dgv_clientes.CurrentRow.Cells(0).Value.ToString)
        parametro.Add(New ReportParameter("Razon_Social", tabla.Rows(0).Item(1).ToString))
        parametro.Add(New ReportParameter("Saldo", tabla.Rows(0).Item(0).ToString))
        visor.LocalReport.SetParameters(parametro)
        visor.RefreshReport()
    End Sub
End Class