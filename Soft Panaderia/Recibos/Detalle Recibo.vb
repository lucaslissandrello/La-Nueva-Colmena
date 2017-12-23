Public Class Detalle_Recibo

    Private Sub Detalle_Recibo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Detalle_Recibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        Top = Recibos.Top
        Left = Recibos.Left
        Dim tabla As Data.DataTable

        tabla = BDHelper.getDBHelper.ConsultaSQL("Select * From Recibo where Id_recibo = " + Recibos.dgv_recibos.CurrentRow.Cells(0).Value.ToString)
        dtp_fecha.Value = tabla.Rows(0).Item("Fecha").ToString
        dtp_fecha.Enabled = False
        tabla = BDHelper.getDBHelper.ConsultaSQL("Select * From Cliente where Codigo = " + tabla.Rows(0).Item("Id_cliente").ToString)
        lbl_codigo.Text = tabla.Rows(0).Item("Codigo").ToString
        lbl_razonSocial.Text = tabla.Rows(0).Item("Razon_Social").ToString
        lbl_recibo.Text = Recibos.dgv_recibos.CurrentRow.Cells(0).Value.ToString


        tabla = BDHelper.getDBHelper.ConsultaSQL("Select * From RecibosXFactura Rf INNER JOIN Factura F ON F.Id = Rf.Id_factura where Rf.Id_recibo = " + Recibos.dgv_recibos.CurrentRow.Cells(0).Value.ToString)
        Dim var As Double = 0
        For i As Integer = 0 To tabla.Rows.Count - 1
            dgv_detallesDeRecibo.Rows.Add(New Object() {tabla.Rows(i).Item("Id_factura").ToString, tabla.Rows(i).Item("Fecha").ToString, tabla.Rows(i).Item("Total").ToString, tabla.Rows(i).Item("Saldo").ToString})
            var = var + tabla.Rows(i).Item("Total")
        Next
        lbl_total.Text = var.ToString
        lbl_MontoAbonado.Text = Recibos.dgv_recibos.CurrentRow.Cells(3).Value.ToString

    End Sub



    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub


End Class