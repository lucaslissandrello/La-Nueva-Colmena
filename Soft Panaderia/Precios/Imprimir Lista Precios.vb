Imports Microsoft.Reporting.WinForms

Public Class Imprimir_Lista_Precios

    Private Sub Imprimir_Lista_Precios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Imprimir_Lista_Precios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As Data.DataTable
        Top = Precios.Top
        Left = Precios.Left
        tabla = BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM ListaPrecios")
        Dim parametros As New List(Of ReportParameter)
        Dim cmd As String = "SELECT Codigo, Producto"
        If Precios.chk_todos.Checked = True Then
            cmd = cmd + ", Precio_Lista_1, Precio_Lista_2, Precio_Lista_3, Precio_Lista_4, Precio_Lista_5, Precio_Lista_6, Precio_Lista_7, Precio_Lista_8"
            parametros.Add(New ReportParameter("Precio1", tabla.Rows(0).Item(1).ToString))
            parametros.Add(New ReportParameter("Precio2", tabla.Rows(1).Item(1).ToString))
            parametros.Add(New ReportParameter("Precio3", tabla.Rows(2).Item(1).ToString))
            parametros.Add(New ReportParameter("Precio4", tabla.Rows(3).Item(1).ToString))
            parametros.Add(New ReportParameter("Precio5", tabla.Rows(4).Item(1).ToString))
            parametros.Add(New ReportParameter("Precio6", tabla.Rows(5).Item(1).ToString))
            parametros.Add(New ReportParameter("Precio7", tabla.Rows(6).Item(1).ToString))
            parametros.Add(New ReportParameter("Precio8", tabla.Rows(7).Item(1).ToString))
        Else
            If Precios.chk_precio1.Checked = True Then
                cmd = cmd + ", Precio_Lista_1"
                parametros.Add(New ReportParameter("Precio1", tabla.Rows(0).Item(1).ToString))
            Else
                parametros.Add(New ReportParameter("Precio1", "No mostrar"))
            End If
            If Precios.chk_precio2.Checked = True Then
                cmd = cmd + ", Precio_Lista_2"
                parametros.Add(New ReportParameter("Precio2", tabla.Rows(1).Item(1).ToString))
            Else
                parametros.Add(New ReportParameter("Precio2", "No mostrar"))
            End If
            If Precios.chk_precio3.Checked = True Then
                cmd = cmd + ", Precio_Lista_3"
                parametros.Add(New ReportParameter("Precio3", tabla.Rows(2).Item(1).ToString))
            Else
                parametros.Add(New ReportParameter("Precio3", "No mostrar"))
            End If
            If Precios.chk_precio4.Checked = True Then
                cmd = cmd + ", Precio_Lista_4"
                parametros.Add(New ReportParameter("Precio4", tabla.Rows(3).Item(1).ToString))
            Else
                parametros.Add(New ReportParameter("Precio4", "No mostrar"))
            End If
            If Precios.chk_precio5.Checked = True Then
                cmd = cmd + ", Precio_Lista_5"
                parametros.Add(New ReportParameter("Precio5", tabla.Rows(4).Item(1).ToString))
            Else
                parametros.Add(New ReportParameter("Precio5", "No mostrar"))
            End If
            If Precios.chk_precio6.Checked = True Then
                cmd = cmd + ", Precio_Lista_6"
                parametros.Add(New ReportParameter("Precio6", tabla.Rows(5).Item(1).ToString))
            Else
                parametros.Add(New ReportParameter("Precio6", "No mostrar"))
            End If
            If Precios.chk_precio7.Checked = True Then
                cmd = cmd + ", Precio_Lista_7"
                parametros.Add(New ReportParameter("Precio7", tabla.Rows(6).Item(1).ToString))
            Else
                parametros.Add(New ReportParameter("Precio7", "No mostrar"))
            End If
            If Precios.chk_precio8.Checked = True Then
                cmd = cmd + ", Precio_Lista_8"
                parametros.Add(New ReportParameter("Precio8", tabla.Rows(7).Item(1).ToString))
            Else
                parametros.Add(New ReportParameter("Precio8", "No mostrar"))
            End If
        End If
        cmd = cmd + " FROM Producto WHERE Borrado = 0"
        PreciosDataSetBindingSource.DataSource = BDHelper.getDBHelper.ConsultaSQL(cmd)
        Me.ProductoTableAdapter.Fill(Me.PreciosDataSet.Producto)
        visor1.LocalReport.SetParameters(parametros)
        visor1.RefreshReport()
    End Sub

    Private Sub Imprimir_Lista_Precios_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.visor1.RefreshReport()
    End Sub

    Private Sub ProductoBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ProductoBindingSource.CurrentChanged

    End Sub

    Private Sub PreciosDataSetBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles PreciosDataSetBindingSource.CurrentChanged

    End Sub
End Class