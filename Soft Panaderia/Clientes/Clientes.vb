Public Class Clientes

    Private Sub Clientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        MaximizeBox = False
        Top = Principal.Top
        Left = Principal.Left
        cargar_grilla()
        txt_buscador.Text = "Buscar..."
        btn_mostrar_datos.Enabled = False
        btn_consultar_saldo.Enabled = False
        btn_imprimir.Enabled = False
    End Sub
    Private Sub txt_buscador_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_buscador.MouseClick
        txt_buscador.Text = ""
    End Sub
    Private Sub btn_consultar_saldo_Click(sender As Object, e As EventArgs) Handles btn_consultar_saldo.Click
        Consultar_Saldo.ShowDialog()
    End Sub
    Private Sub btn_agregar_cliente_Click(sender As Object, e As EventArgs) Handles btn_agregar_cliente.Click
        Agregar_Cliente.ShowDialog()
        dgv_clientes.Rows.Clear()
        cargar_grilla()
    End Sub
    Private Sub btn_mostrar_datos_Click(sender As Object, e As EventArgs) Handles btn_mostrar_datos.Click
        Datos_Cliente.ShowDialog()
        dgv_clientes.Rows.Clear()
        cargar_grilla()
    End Sub
    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Close()
    End Sub
    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim texto As String = txt_buscador.Text
        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper.ConsultaSQL("Select * From Cliente where Borrado = 0 and Razon_Social LIKE '%" + texto + "%'")
        If tabla.Rows.Count = 0 Then
            MsgBox("Cliente no encontrado, verifique que ha ingresado correctamente los datos.")
        Else
            dgv_clientes.Rows.Clear()
            For i As Integer = 0 To tabla.Rows.Count - 1
                dgv_clientes.Rows.Add(New Object() {tabla.Rows(i).Item(0).ToString, tabla.Rows(i).Item(1).ToString, tabla.Rows(i).Item(2).ToString})
            Next
        End If
    End Sub
    Private Sub cargar_grilla()

        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper().ConsultaSQL("SELECT * FROM Cliente WHERE Borrado = 0")
        For i As Integer = 0 To tabla.Rows.Count - 1
            dgv_clientes.Rows.Add(New Object() {tabla.Rows(i).Item(0).ToString, tabla.Rows(i).Item(1).ToString, tabla.Rows(i).Item(2).ToString})
        Next

    End Sub


    Private Sub dgv_clientes_Click(sender As Object, e As EventArgs) Handles dgv_clientes.Click
        If dgv_clientes.CurrentRow Is Nothing Then
            Exit Sub
        End If
        btn_mostrar_datos.Enabled = True
        btn_consultar_saldo.Enabled = True
        btn_imprimir.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgv_clientes.Rows.Clear()
        cargar_grilla()
        txt_buscador.Text = ""
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        Imprimir_Saldo.ShowDialog()
    End Sub
End Class