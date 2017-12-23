Public Class Precios
    Private Sub txt_buscar_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_buscar.MouseClick
        txt_buscar.Text = ""
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Close()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Agregar_Producto.ShowDialog()
        dgv_productos.Rows.Clear()
        cargar_grilla()

    End Sub

    Private Sub cargar_grilla()
        
        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper().ConsultaSQL("SELECT * FROM Producto WHERE Borrado = 0")
        For i As Integer = 0 To tabla.Rows.Count - 1
            dgv_productos.Rows.Add(New Object() {tabla.Rows(i).Item(0).ToString, tabla.Rows(i).Item(1).ToString, tabla.Rows(i).Item(3).ToString, tabla.Rows(i).Item(4).ToString, tabla.Rows(i).Item(5).ToString, tabla.Rows(i).Item(6).ToString, tabla.Rows(i).Item(7).ToString, tabla.Rows(i).Item(8).ToString, tabla.Rows(i).Item(9).ToString, tabla.Rows(i).Item(10).ToString})
        Next

    End Sub

    Private Sub Precios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Precios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        Top = Principal.Top
        Left = Principal.Left
        btn_modificar.Enabled = False
        btn_borrar.Enabled = False
        cargar_grilla()
        chk_todos.Checked = True
        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper.ConsultaSQL("Select * From ListaPrecios")
        dgv_productos.Columns(2).HeaderText = tabla.Rows(0).Item(1).ToString
        chk_precio1.Text = tabla.Rows(0).Item(1).ToString

        dgv_productos.Columns(3).HeaderText = tabla.Rows(1).Item(1).ToString
        chk_precio2.Text = tabla.Rows(1).Item(1).ToString

        dgv_productos.Columns(4).HeaderText = tabla.Rows(2).Item(1).ToString
        chk_precio3.Text = tabla.Rows(2).Item(1).ToString

        dgv_productos.Columns(5).HeaderText = tabla.Rows(3).Item(1).ToString
        chk_precio4.Text = tabla.Rows(3).Item(1).ToString

        dgv_productos.Columns(6).HeaderText = tabla.Rows(4).Item(1).ToString
        chk_precio5.Text = tabla.Rows(4).Item(1).ToString

        dgv_productos.Columns(7).HeaderText = tabla.Rows(5).Item(1).ToString
        chk_precio6.Text = tabla.Rows(5).Item(1).ToString

        dgv_productos.Columns(8).HeaderText = tabla.Rows(6).Item(1).ToString
        chk_precio7.Text = tabla.Rows(6).Item(1).ToString

        dgv_productos.Columns(9).HeaderText = tabla.Rows(7).Item(1).ToString
        chk_precio8.Text = tabla.Rows(7).Item(1).ToString
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        modificar_producto.ShowDialog()
        dgv_productos.Rows.Clear()
        cargar_grilla()
    End Sub

    Private Sub dgv_productos_Click(sender As Object, e As EventArgs) Handles dgv_productos.Click
        If dgv_productos.CurrentRow Is Nothing Then
            Exit Sub
        End If
        btn_modificar.Enabled = True
        btn_borrar.Enabled = True
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        If MsgBox("¿Desea Borrar el Producto seleccionado?", MsgBoxStyle.YesNo, "Borrar Producto") = MsgBoxResult.Yes Then
            Dim i As Integer
            i = BDHelper.getDBHelper().EjecutarSQL("UPDATE Producto set Borrado = 1 where Codigo = " + dgv_productos.CurrentRow.Cells("Codigo").Value)
            If i <> 0 Then
                MsgBox("Producto eliminado correctamente.")
                dgv_productos.Rows.Clear()
                cargar_grilla()
            End If
        End If
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim texto As String = txt_buscar.Text
        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper().ConsultaSQL("SELECT * FROM Producto WHERE Borrado = 0 and  Producto LIKE '" + texto + "%'")
        If tabla.Rows.Count = 0 Then
            MsgBox("Producto no encontrado.")
        Else
            dgv_productos.Rows.Clear()
        End If
        For i As Integer = 0 To tabla.Rows.Count - 1
            dgv_productos.Rows.Add(New Object() {tabla.Rows(i).Item(0).ToString, tabla.Rows(i).Item(1).ToString, tabla.Rows(i).Item(3).ToString, tabla.Rows(i).Item(4).ToString, tabla.Rows(i).Item(5).ToString, tabla.Rows(i).Item(6).ToString, tabla.Rows(i).Item(7).ToString, tabla.Rows(i).Item(8).ToString, tabla.Rows(i).Item(9).ToString, tabla.Rows(i).Item(10).ToString})
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgv_productos.Rows.Clear()
        cargar_grilla()
        txt_buscar.Text = ""
    End Sub

    Private Sub chk_todos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos.CheckedChanged
        If chk_todos.Checked = True Then
            chk_precio1.Enabled = False
            chk_precio1.Checked = False
            chk_precio2.Enabled = False
            chk_precio2.Checked = False
            chk_precio3.Enabled = False
            chk_precio3.Checked = False
            chk_precio4.Enabled = False
            chk_precio4.Checked = False
            chk_precio5.Enabled = False
            chk_precio5.Checked = False
            chk_precio6.Enabled = False
            chk_precio6.Checked = False
            chk_precio7.Enabled = False
            chk_precio7.Checked = False
            chk_precio8.Enabled = False
            chk_precio8.Checked = False
            dgv_productos.Columns.Item(2).Visible = True
            dgv_productos.Columns.Item(3).Visible = True
            dgv_productos.Columns.Item(4).Visible = True
            dgv_productos.Columns.Item(5).Visible = True
            dgv_productos.Columns.Item(6).Visible = True
            dgv_productos.Columns.Item(7).Visible = True
            dgv_productos.Columns.Item(8).Visible = True
            dgv_productos.Columns.Item(9).Visible = True
        Else
            dgv_productos.Columns.Item(2).Visible = False
            dgv_productos.Columns.Item(3).Visible = False
            dgv_productos.Columns.Item(4).Visible = False
            dgv_productos.Columns.Item(5).Visible = False
            dgv_productos.Columns.Item(6).Visible = False
            dgv_productos.Columns.Item(7).Visible = False
            dgv_productos.Columns.Item(8).Visible = False
            dgv_productos.Columns.Item(9).Visible = False
            chk_precio1.Enabled = True
            chk_precio2.Enabled = True
            chk_precio3.Enabled = True
            chk_precio4.Enabled = True
            chk_precio5.Enabled = True
            chk_precio6.Enabled = True
            chk_precio7.Enabled = True
            chk_precio8.Enabled = True
        End If
    End Sub
    Private Sub chk_precio1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_precio1.CheckedChanged
        If chk_precio1.Checked = True Then
            dgv_productos.Columns.Item(2).Visible = True
        Else
            dgv_productos.Columns.Item(2).Visible = False
        End If
    End Sub
    Private Sub chk_precio2_CheckedChanged(sender As Object, e As EventArgs) Handles chk_precio2.CheckedChanged
        If chk_precio2.Checked = True Then
            dgv_productos.Columns.Item(3).Visible = True
        Else
            dgv_productos.Columns.Item(3).Visible = False
        End If
    End Sub
    Private Sub chk_precio3_CheckedChanged(sender As Object, e As EventArgs) Handles chk_precio3.CheckedChanged
        If chk_precio3.Checked = True Then
            dgv_productos.Columns.Item(4).Visible = True
        Else
            dgv_productos.Columns.Item(4).Visible = False
        End If
    End Sub
    Private Sub chk_precio4_CheckedChanged(sender As Object, e As EventArgs) Handles chk_precio4.CheckedChanged
        If chk_precio4.Checked = True Then
            dgv_productos.Columns.Item(5).Visible = True
        Else
            dgv_productos.Columns.Item(5).Visible = False
        End If
    End Sub
    Private Sub chk_precio5_CheckedChanged(sender As Object, e As EventArgs) Handles chk_precio5.CheckedChanged
        If chk_precio5.Checked = True Then
            dgv_productos.Columns.Item(6).Visible = True
        Else
            dgv_productos.Columns.Item(6).Visible = False
        End If
    End Sub
    Private Sub chk_precio6_CheckedChanged(sender As Object, e As EventArgs) Handles chk_precio6.CheckedChanged
        If chk_precio6.Checked = True Then
            dgv_productos.Columns.Item(7).Visible = True
        Else
            dgv_productos.Columns.Item(7).Visible = False
        End If
    End Sub
    Private Sub chk_precio7_CheckedChanged(sender As Object, e As EventArgs) Handles chk_precio7.CheckedChanged
        If chk_precio7.Checked = True Then
            dgv_productos.Columns.Item(8).Visible = True
        Else
            dgv_productos.Columns.Item(8).Visible = False
        End If
    End Sub
    Private Sub chk_precio8_CheckedChanged(sender As Object, e As EventArgs) Handles chk_precio8.CheckedChanged
        If chk_precio8.Checked = True Then
            dgv_productos.Columns.Item(9).Visible = True
        Else
            dgv_productos.Columns.Item(9).Visible = False
        End If
    End Sub

    Private Sub btn_imprimar_Click(sender As Object, e As EventArgs) Handles btn_imprimar.Click
        Imprimir_Lista_Precios.ShowDialog()
    End Sub
End Class