Imports Microsoft.Reporting.WinForms

Public Class ImprimirNotaCredito

    Private Sub ImprimirNotaCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Top = Facturacion.Top
        Left = Facturacion.Left
        Me.ProductoTableAdapter.Fill(Me.FacturaDataSet.Producto)
        Dim tabla As Data.DataTable
        Dim cmd As String
        If Facturacion.dgv_facturas.CurrentRow.Cells(6).Value = "F" Then
            cmd = "SELECT * FROM DetalleFactura WHERE Id_factura = " + Facturacion.dgv_facturas.CurrentRow.Cells(0).Value.ToString
        Else
            cmd = "SELECT Id_Factura FROM NotaCredito WHERE Id = " + Facturacion.dgv_facturas.CurrentRow.Cells(0).Value.ToString
            tabla = BDHelper.getDBHelper.ConsultaSQL(cmd)
            If tabla.Rows(0).Item(0) = 0 Then
                cmd = "SELECT * FROM DetalleNotaCredito WHERE Id_nota_credito = " + Facturacion.dgv_facturas.CurrentRow.Cells(0).Value.ToString
            Else
                cmd = "SELECT * FROM DetalleFactura WHERE Id_factura = " + tabla.Rows(0).Item(0).ToString
            End If
        End If
        tabla = BDHelper.getDBHelper.ConsultaSQL(cmd)
        DetalleFacturaBindingSource.DataSource = tabla
        Dim tabla2 As New Data.DataTable
        Dim str(tabla.Rows.Count - 1) As String
        For i As Integer = 0 To tabla.Rows.Count - 1
            tabla2 = BDHelper.getDBHelper.ConsultaSQL("SELECT Producto FROM Producto WHERE Codigo = " + tabla.Rows(i).Item(2).ToString())
            str(i) = tabla2.Rows(0).Item(0)
        Next
        Dim parametro As New List(Of ReportParameter)
        parametro.Add(New ReportParameter("Producto", str))
        parametro.Add(New ReportParameter("Fecha", Facturacion.dgv_facturas.CurrentRow.Cells(1).Value.ToString))
        parametro.Add(New ReportParameter("Id_Factura", Facturacion.dgv_facturas.CurrentRow.Cells(0).Value.ToString))
        parametro.Add(New ReportParameter("Total", Facturacion.dgv_facturas.CurrentRow.Cells(3).Value.ToString))
        parametro.Add(New ReportParameter("Razon_Social", Facturacion.dgv_facturas.CurrentRow.Cells(2).Value.ToString))
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT SaldoCliente FROM NotaCredito WHERE Id =" + Facturacion.dgv_facturas.CurrentRow.Cells(0).Value.ToString)
        Dim saldo As Integer
        If tabla.Rows(0).Item(0).ToString = "" Then
            saldo = 0
        Else
            saldo = tabla.Rows(0).Item(0).ToString
        End If
        parametro.Add(New ReportParameter("Saldo", saldo))
        visor1.LocalReport.SetParameters(parametro)
        visor1.RefreshReport()
    End Sub
End Class