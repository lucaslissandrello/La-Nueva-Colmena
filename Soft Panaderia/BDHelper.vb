Imports System.Data.OleDb

Public Class BDHelper
    ' La clase BDHelper permite quitar del código del formulario todo lo relacionado con el acceso a bd.
    ' Permite ejecutar comandos sql y retornar resultados a la capa de datos.
    ' Implementa el patrón SINGLETON, que garantiza tener solo una instancia de esta clase.

    Private string_conexion As String
    Private Shared instance As BDHelper 'Unica instancia de la clase

    Private Sub New()
        string_conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.Environment.CurrentDirectory.ToString + "\La Nueva colmena.mdb"
    End Sub

    Public Shared Function getDBHelper() As BDHelper
        If IsNothing(instance) Then
            instance = New BDHelper()
        End If
        Return instance
    End Function

    Public Function EjecutarSQL(ByVal strSql As String) As Integer
        ' La función EjecutarSQL es una función compartida y puede ser invocada desde cualquier componente del proyecto
        ' Establece la conexión con la base de datos usando la clase SqlConnection
        ' Dimensiona los objetos conexion y sqlcomand 

        Dim conexion As New OleDbConnection
        Dim cmd As New OleDbCommand

        'Try Catch Finally
        'Trata de ejecutar el código contenido dentro del bloque Try - Catch
        'Si hay error lo capta a través de una excepción
        'Si no hubo error
        Try
            ' Establece que conexión usar
            conexion.ConnectionString = string_conexion
            ' Abre la conexión
            conexion.Open()

            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            ' Establece la instrucción a ejecutar
            cmd.CommandText = strSql
            ' Retorna el resultado de ejecutar la consulta
            Return cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            ' Cierra la conexión
            conexion.Close()
            conexion.Dispose()

        End Try
    End Function

    Public Function ConsultaSQL(ByVal strSql As String) As Data.DataTable
        ' La función ConsultaSQL es una función compartida y puede ser invocada desde cualquier componente del proyecto
        ' Se utiliza para sentencias SQL del tipo “Select”
        ' La función recibe por valor una sentencia sql como string, devuelve un objeto de tipo DataTable
        Dim conexion As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim tabla As New DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            ' El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos
            tabla.Load(cmd.ExecuteReader())
            ' La función retorna el objeto datatable con 0, 1 o mas registros
            Return tabla
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function

    Public Function finalizarFactura() As Boolean
        Dim ban As Boolean = True
        Dim conexion As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim trans As OleDbTransaction
        Dim tabla As New Data.DataTable
        Dim saldo As Double = 0
        Dim acu As Double = Factura.lbl_total.Text
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            trans = conexion.BeginTransaction
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.Transaction = trans
            If Factura.cbo_forma_pago.SelectedIndex = 1 Then
                cmd.CommandText = "SELECT Saldo FROM Cliente WHERE Codigo = " + Factura.lbl_codigo.Text.ToString
                tabla.Load(cmd.ExecuteReader)
                saldo = tabla.Rows(0).Item(0).ToString
                If saldo < 0 Then
                    cmd.CommandText = "SELECT Id, Saldo FROM NotaCredito WHERE Saldo > 0"
                    tabla = New DataTable
                    tabla.Load(cmd.ExecuteReader)
                    If tabla.Rows.Count > 0 Then
                        For i As Integer = 0 To tabla.Rows.Count - 1
                            If acu >= tabla.Rows(i).Item(1) Then
                                acu = acu - tabla.Rows(i).Item(1)
                                cmd.CommandText = "UPDATE NotaCredito SET Saldo = 0 WHERE Id = " + tabla.Rows(i).Item(0).ToString
                                cmd.ExecuteNonQuery()
                            Else
                                acu = tabla.Rows(i).Item(1) - acu
                                cmd.CommandText = "UPDATE NotaCredito SET Saldo = " + acu.ToString + " WHERE Id = " + tabla.Rows(i).Item(0).ToString
                                cmd.ExecuteNonQuery()
                                acu = 0
                                Exit For
                            End If
                        Next
                    End If
                End If
                saldo = saldo + Factura.lbl_total.Text.ToString
                cmd.CommandText = "UPDATE Cliente SET Saldo = " + saldo.ToString + " WHERE Codigo = " + Factura.lbl_codigo.Text.ToString
                cmd.ExecuteNonQuery()
            Else : acu = 0
            End If
            cmd.CommandText = "INSERT INTO Factura(Id, Fecha, Total, Id_cliente, Saldo, Cuenta_corriente, Cancelada, SaldoCliente) VALUES(" + Factura.lbl_factura.Text.ToString + ",'" + Factura.dtp_fecha.Value.ToString + "'," + Factura.lbl_total.Text.ToString + "," + Factura.lbl_codigo.Text.ToString + ", " + acu.ToString + ", " + Factura.cbo_forma_pago.SelectedIndex.ToString + ", 0, " + saldo.ToString + ")"
            cmd.ExecuteNonQuery()
            For i As Integer = 0 To (Factura.dgv_detalles.Rows.Count - 1)
                Dim j As Integer = i + 1
                cmd.CommandText = "INSERT INTO DetalleFactura(Id_detalle,Id_factura,Id_producto,Cantidad,Precio_facturado) VALUES(" + j.ToString + "," + Factura.lbl_factura.Text + "," + Factura.dgv_detalles.Rows(i).Cells(0).Value.ToString + "," + Factura.dgv_detalles.Rows(i).Cells(1).Value.ToString + "," + Factura.dgv_detalles.Rows(i).Cells(3).Value.ToString + ")"
                cmd.ExecuteNonQuery()
            Next
            trans.Commit()
        Catch ex As SqlClient.SqlException
            MsgBox(ex.ToString)
            ban = False
            trans.Rollback()
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
        Return ban
    End Function

    Public Function cancelarFactura() As Boolean
        Dim saldo As Double
        saldo = Facturacion.dgv_facturas.CurrentRow.Cells(3).Value
        Dim ban As Boolean = True
        Dim conexion As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim trans As OleDbTransaction
        Dim tabla As New Data.DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            trans = conexion.BeginTransaction
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.Transaction = trans
            cmd.CommandText = "SELECT Cuenta_corriente FROM Factura WHERE Id = " + Facturacion.dgv_facturas.CurrentRow.Cells(0).Value.ToString
            tabla.Load(cmd.ExecuteReader)
            If tabla.Rows(0).Item(0) = 1 Then
                cmd.CommandText = "SELECT Saldo FROM Cliente WHERE Codigo = " + Facturacion.dgv_facturas.CurrentRow.Cells(4).Value.ToString
                tabla = New DataTable
                tabla.Load(cmd.ExecuteReader)
                saldo = tabla.Rows(0).Item(0).ToString - saldo
                cmd.CommandText = "UPDATE Cliente SET Saldo = " + saldo.ToString + " WHERE Codigo = " + Facturacion.dgv_facturas.CurrentRow.Cells(4).Value.ToString
                cmd.ExecuteNonQuery()
            End If
            cmd.CommandText = "UPDATE Factura SET Cancelada = 1 WHERE Id = " + Facturacion.dgv_facturas.CurrentRow.Cells(0).Value.ToString
            cmd.ExecuteNonQuery()
            trans.Commit()
        Catch ex As SqlClient.SqlException
            MsgBox(ex.ToString)
            ban = False
            trans.Rollback()
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
        Return ban
    End Function

    Public Function finalizarRecibo() As Boolean
        Dim ban As Boolean = True
        Dim conexion As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim trans As OleDbTransaction
        Dim tabla As New Data.DataTable
        Dim monto As String = Recibo.txt_montoM.Text
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            trans = conexion.BeginTransaction
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.Transaction = trans
            
            cmd.CommandText = "SELECT Saldo FROM Cliente WHERE Codigo = " + Recibo.cbo_cliente.SelectedValue.ToString
            tabla.Load(cmd.ExecuteReader)
            Dim saldo As String = ""

            ' Esto es lo que modifique y ademas  cambie saldo y monto a String
            saldo = Val(tabla.Rows(0).Item(0)) - Val(monto)
            saldo = Replace(saldo, ",", ".")
            ' Lo que modifique 

            cmd.CommandText = "UPDATE Cliente SET Saldo = " + saldo.ToString + " WHERE Codigo = " + Recibo.cbo_cliente.SelectedValue.ToString
            cmd.ExecuteNonQuery()
            cmd.CommandText = "INSERT INTO Recibo(Id_recibo, Id_cliente, Fecha, Monto, Cuenta_corriente, SaldoCliente) VALUES(" + Recibo.lbl_recibo.Text.ToString + "," + Recibo.lbl_codigo.Text.ToString + ",'" + Recibo.dtp_fecha.Value.ToString + "'," + Recibo.txt_montoM.Text.ToString + ", 1," + saldo.ToString + ")"
            cmd.ExecuteNonQuery()
            For i As Integer = 0 To (Recibo.dgv_facturas.Rows.Count - 1)
                If Recibo.dgv_facturas.Rows(i).Cells(0).Value.ToString = "SI" Then
                    If monto <> 0 Then
                        If monto >= Recibo.dgv_facturas.Rows(i).Cells(4).Value Then
                            cmd.CommandText = "INSERT INTO RecibosXFactura(Id_factura,Id_recibo,Monto_cancelado) VALUES(" + Recibo.dgv_facturas.Rows(i).Cells(1).Value.ToString + "," + Recibo.lbl_recibo.Text.ToString + "," + Recibo.dgv_facturas.Rows(i).Cells(4).Value.ToString + ")"
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "UPDATE Factura SET Saldo = 0 WHERE Id = " + Recibo.dgv_facturas.Rows(i).Cells(1).Value.ToString
                            cmd.ExecuteNonQuery()
                            monto = monto - Recibo.dgv_facturas.Rows(i).Cells(4).Value
                        ElseIf monto < Recibo.dgv_facturas.Rows(i).Cells(4).Value Then
                            cmd.CommandText = "INSERT INTO RecibosXFactura(Id_factura,Id_recibo,Monto_cancelado) VALUES(" + Recibo.dgv_facturas.Rows(i).Cells(1).Value.ToString + "," + Recibo.lbl_recibo.Text.ToString + "," + monto.ToString + ")"
                            cmd.ExecuteNonQuery()
                            monto = Recibo.dgv_facturas.Rows(i).Cells(4).Value - monto
                            cmd.CommandText = "UPDATE Factura SET Saldo = " + monto.ToString + " WHERE Id = " + Recibo.dgv_facturas.Rows(i).Cells(1).Value.ToString
                            cmd.ExecuteNonQuery()
                            monto = 0
                        End If
                    End If
                End If
            Next
            trans.Commit()
        Catch ex As SqlClient.SqlException
            MsgBox(ex.ToString)
            ban = False
            trans.Rollback()
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
        Return ban
    End Function

    Public Function cancelarRecibo() As Boolean
        Dim saldo As Double
        saldo = Recibos.dgv_recibos.CurrentRow.Cells(3).Value
        Dim ban As Boolean = True
        Dim conexion As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim trans As OleDbTransaction
        Dim tabla As New Data.DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            trans = conexion.BeginTransaction
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.Transaction = trans
            cmd.CommandText = "SELECT Saldo FROM Cliente WHERE Codigo = " + Recibos.dgv_recibos.CurrentRow.Cells(4).Value.ToString
            tabla.Load(cmd.ExecuteReader)
            saldo = tabla.Rows(0).Item(0).ToString + saldo
            cmd.CommandText = "UPDATE Cliente SET Saldo = " + saldo.ToString + " WHERE Codigo = " + Recibos.dgv_recibos.CurrentRow.Cells(4).Value.ToString
            cmd.ExecuteNonQuery()
            cmd.CommandText = "SELECT Id_factura, Monto_cancelado FROM RecibosXFactura WHERE Id_recibo = " + Recibos.dgv_recibos.CurrentRow.Cells(0).Value.ToString
            tabla = New Data.DataTable
            tabla.Load(cmd.ExecuteReader)
            Dim monto As Double
            For i As Integer = 0 To (tabla.Rows.Count.ToString - 1)
                Dim tabla2 As New Data.DataTable
                monto = tabla.Rows(i).Item(1)
                cmd.CommandText = "SELECT Saldo FROM Factura WHERE Id = " + tabla.Rows(i).Item(0).ToString
                tabla2.Load(cmd.ExecuteReader)
                monto = tabla2.Rows(0).Item(0) + monto
                cmd.CommandText = "UPDATE Factura SET Saldo = " + monto.ToString + " WHERE Id = " + tabla.Rows(i).Item(0).ToString
                cmd.ExecuteNonQuery()
            Next
            cmd.CommandText = "DELETE FROM RecibosXFactura WHERE Id_recibo = " + Recibos.dgv_recibos.CurrentRow.Cells(0).Value.ToString
            cmd.ExecuteNonQuery()
            cmd.CommandText = "DELETE FROM Recibo WHERE Id_recibo = " + Recibos.dgv_recibos.CurrentRow.Cells(0).Value.ToString
            cmd.ExecuteNonQuery()
            trans.Commit()
        Catch ex As SqlClient.SqlException
            MsgBox(ex.ToString)
            ban = False
            trans.Rollback()
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
        Return ban
    End Function

    Public Function finalizarNotaCredito() As Boolean
        Dim ban = True
        Dim conexion As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim trans As OleDbTransaction
        Dim saldoCliente As Double
        Dim tabla As New Data.DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            trans = conexion.BeginTransaction
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.Transaction = trans
            Dim id_factura As Integer = 0
            If NotaCredito.chk_comprobantes.Checked Then
                id_factura = NotaCredito.cbo_factura.SelectedValue
                cmd.CommandText = "SELECT Cuenta_corriente FROM Factura WHERE Id = " + id_factura.ToString
                tabla.Load(cmd.ExecuteReader)
                If tabla.Rows(0).Item(0) = 0 Then
                    cmd.CommandText = "UPDATE Factura SET Cancelada = 1 WHERE Id = " + id_factura.ToString
                    cmd.ExecuteNonQuery()
                End If
            Else
                For i As Integer = 0 To NotaCredito.dgv_detalles.Rows.Count - 1
                    cmd.CommandText = "INSERT INTO DetalleNotaCredito (Id_detalle, Id_nota_credito, Id_producto, Cantidad, Precio_facturado) VALUES(" + (i + 1).ToString + ", " + NotaCredito.lbl_id.Text + ", " + NotaCredito.dgv_detalles.Rows(i).Cells(0).Value.ToString + ", " + NotaCredito.dgv_detalles.Rows(i).Cells(1).Value.ToString + ", " + NotaCredito.dgv_detalles.Rows(i).Cells(3).Value.ToString + ")"
                    cmd.ExecuteNonQuery()
                Next
            End If
            tabla = New DataTable
            cmd.CommandText = "SELECT Saldo FROM Cliente WHERE Codigo = " + NotaCredito.cbo_cliente.SelectedValue.ToString
            tabla.Load(cmd.ExecuteReader)
            Dim saldo As Double = tabla.Rows(0).Item(0)
            saldo = saldo - NotaCredito.lbl_total.Text
            cmd.CommandText = "UPDATE Cliente SET Saldo = " + saldo.ToString + " WHERE Codigo = " + NotaCredito.cbo_cliente.SelectedValue.ToString
            cmd.ExecuteNonQuery()
            saldoCliente = saldo

            tabla = New Data.DataTable
            cmd.CommandText = "SELECT Id, Saldo FROM Factura WHERE Cancelada = 0 AND Saldo > 0 AND Id_cliente = " + NotaCredito.cbo_cliente.SelectedValue.ToString + " ORDER BY Saldo"
            tabla.Load(cmd.ExecuteReader)
            saldo = Val(NotaCredito.lbl_total.Text)
            For i = 0 To tabla.Rows.Count - 1
                If tabla.Rows(i).Item(1) < saldo Then
                    cmd.CommandText = "UPDATE Factura SET Saldo = 0 WHERE Id = " + tabla.Rows(i).Item(0).ToString
                    cmd.ExecuteNonQuery()
                    saldo = saldo - tabla.Rows(i).Item(1)
                Else
                    If tabla.Rows(i).Item(1) >= saldo Then
                        saldo = tabla.Rows(i).Item(1) - saldo
                        cmd.CommandText = "UPDATE Factura SET Saldo = " + saldo.ToString + " WHERE Id = " + tabla.Rows(i).Item(0).ToString
                        cmd.ExecuteNonQuery()
                        saldo = 0
                        Exit For
                    End If
                End If
            Next
            cmd.CommandText = "INSERT INTO NotaCredito(Id, Id_Cliente, Id_Factura, Monto, Fecha, Saldo, SaldoCliente) VALUES(" + NotaCredito.lbl_id.Text + ", " + NotaCredito.cbo_cliente.SelectedValue.ToString + ", " + id_factura.ToString + ", " + NotaCredito.lbl_total.Text + ", '" + NotaCredito.dtp_fecha.Value.ToString + "', " + saldo.ToString + "," + saldoCliente.ToString + ")"
            cmd.ExecuteNonQuery()
            trans.Commit()
        Catch ex As SqlClient.SqlException
            MsgBox(ex.ToString)
            ban = False
            trans.Rollback()
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
        Return ban
    End Function

    Public Sub reciboContado()
        Dim conexion As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim trans As OleDbTransaction
        Dim tabla As New Data.DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            trans = conexion.BeginTransaction
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.Transaction = trans
            Dim id As Integer = 1
            cmd.CommandText = "SELECT MAX(Id_recibo) FROM Recibo"
            tabla.Load(cmd.ExecuteReader)
            If tabla.Rows(0).Item(0).ToString <> "" Then
                id = tabla.Rows(0).Item(0) + 1
            End If
            cmd.CommandText = "INSERT INTO Recibo(Id_recibo, Id_cliente, Fecha, Monto, Cuenta_corriente) VALUES(" + id.ToString + ", " + Factura.cbo_cliente.SelectedValue.ToString + ", '" + Factura.dtp_fecha.Value.ToString + "', " + Factura.lbl_total.Text.ToString + ", 0)"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "INSERT INTO RecibosXFactura(Id_factura, Id_recibo, Monto_cancelado) VALUES(" + Factura.lbl_codigo.Text.ToString + ", " + id.ToString + ", " + Factura.lbl_total.Text + ")"
            cmd.ExecuteNonQuery()
            trans.Commit()
        Catch ex As SqlClient.SqlException
            MsgBox(ex.ToString)
            trans.Rollback()
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Sub
End Class