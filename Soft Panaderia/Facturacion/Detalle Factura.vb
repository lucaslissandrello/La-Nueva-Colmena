Public Class Detalle_Factura

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Close()
    End Sub
    Private Sub Detalle_Factura_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub Detalle_Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        Top = Facturacion.Top
        Left = Facturacion.Left
        If Facturacion.dgv_facturas.CurrentRow.Cells(6).Value = "NC" Then
            Me.Text = "Detalle Nota Credito"
            lbl_total_importe.Text = lbl_total_importe.Text + "-"
        End If
        cargar_grilla()
    End Sub
    Private Sub cargar_grilla()
        Dim id_factura As Integer = Facturacion.dgv_facturas.CurrentRow.Cells(0).Value
        Dim importe As Double = 0
        Dim cantidad As Double = 0
        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper().ConsultaSQL("SELECT DF.Id_producto, DF.Cantidad, P.Producto, DF.Precio_facturado FROM DetalleFactura DF INNER JOIN Producto P ON DF.Id_producto = P.Codigo WHERE DF.Id_factura = " + id_factura.ToString)
        For i As Integer = 0 To tabla.Rows.Count - 1
            importe = (tabla.Rows(i).Item(1) * tabla.Rows(i).Item(3))
            cantidad = cantidad + tabla.Rows(i).Item(1).ToString
            dgv_detalles.Rows.Add(New Object() {tabla.Rows(i).Item(0).ToString, tabla.Rows(i).Item(1).ToString, tabla.Rows(i).Item(2).ToString, tabla.Rows(i).Item(3).ToString, importe.ToString})
        Next
        tabla = BDHelper.getDBHelper().ConsultaSQL("SELECT F.Id_cliente, C.Razon_Social, F.Fecha, F.Id, F.Total FROM  Factura F INNER JOIN Cliente C ON F.Id_cliente = C.Codigo WHERE F.Id = " + id_factura.ToString)
        lbl_codigo.Text = tabla.Rows(0).Item(0).ToString
        lbl_nombre.Text = tabla.Rows(0).Item(1).ToString
        lbl_fecha.Text = tabla.Rows(0).Item(2).ToString
        lbl_factura.Text = tabla.Rows(0).Item(3).ToString
        lbl_total.Text = tabla.Rows(0).Item(4).ToString
        lbl_cantidad.Text = cantidad.ToString
    End Sub
End Class