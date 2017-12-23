Imports Microsoft.Reporting.WinForms

Public Class Imprimir_Recibo

    Private Sub Imprimir_Recibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Top = Recibos.Top
        Left = Recibos.Left
        Me.RecibosXFacturaTableAdapter.Fill(Me.ReciboDataSet.RecibosXFactura)
        Dim tabla As Data.DataTable = BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM RecibosXFactura WHERE Id_recibo = " + Recibos.dgv_recibos.CurrentRow.Cells(0).Value.ToString)
        RecibosXFacturaBindingSource.DataSource = tabla
        Dim parametro As New List(Of ReportParameter)
        parametro.Add(New ReportParameter("Id_Recibo", tabla.Rows(0).Item("Id_recibo").ToString))
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM Recibo R INNER JOIN Cliente C ON R.Id_cliente = C.Codigo WHERE R.Id_recibo = " + Recibos.dgv_recibos.CurrentRow.Cells(0).Value.ToString)
        parametro.Add(New ReportParameter("Total", tabla.Rows(0).Item("Monto").ToString))
        parametro.Add(New ReportParameter("Fecha", tabla.Rows(0).Item("Fecha").ToString))
        parametro.Add(New ReportParameter("Razon_Social", tabla.Rows(0).Item("Razon_Social").ToString))
        Dim saldo As Integer
        If tabla.Rows(0).Item("SaldoCliente").ToString = "" Then
            saldo = 0
        Else
            saldo = tabla.Rows(0).Item("SaldoCliente").ToString
        End If
        parametro.Add(New ReportParameter("Saldo", saldo))
        visor1.LocalReport.SetParameters(parametro)
        Me.visor1.RefreshReport()
    End Sub
End Class