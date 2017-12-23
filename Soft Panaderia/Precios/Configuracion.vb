Public Class Configuracion

    Private Sub Configuracion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub Configuracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        Top = Principal.Top
        Left = Principal.Left
        txt_1.Enabled = False
        txt_2.Enabled = False
        txt_3.Enabled = False
        txt_4.Enabled = False
        txt_5.Enabled = False
        txt_6.Enabled = False
        txt_7.Enabled = False
        txt_8.Enabled = False

        Dim tabla As Data.DataTable
        tabla = BDHelper.getDBHelper.ConsultaSQL("Select * From ListaPrecios")
        txt_1.Text = tabla.Rows(0).Item(1).ToString
        txt_2.Text = tabla.Rows(1).Item(1).ToString
        txt_3.Text = tabla.Rows(2).Item(1).ToString
        txt_4.Text = tabla.Rows(3).Item(1).ToString
        txt_5.Text = tabla.Rows(4).Item(1).ToString
        txt_6.Text = tabla.Rows(5).Item(1).ToString
        txt_7.Text = tabla.Rows(6).Item(1).ToString
        txt_8.Text = tabla.Rows(7).Item(1).ToString
    End Sub



    Private Sub chk_1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_1.CheckedChanged
        If chk_1.Checked = True Then
            txt_1.Enabled = True
        Else
            txt_1.Enabled = False
        End If
    End Sub
    Private Sub chk_2_CheckedChanged(sender As Object, e As EventArgs) Handles chk_2.CheckedChanged
        If chk_2.Checked = True Then
            txt_2.Enabled = True
        Else
            txt_2.Enabled = False
        End If
    End Sub
    Private Sub chk_3_CheckedChanged(sender As Object, e As EventArgs) Handles chk_3.CheckedChanged
        If chk_3.Checked = True Then
            txt_3.Enabled = True
        Else
            txt_3.Enabled = False
        End If
    End Sub
    Private Sub chk_4_CheckedChanged(sender As Object, e As EventArgs) Handles chk_4.CheckedChanged
        If chk_4.Checked = True Then
            txt_4.Enabled = True
        Else
            txt_4.Enabled = False
        End If
    End Sub
    Private Sub chk_5_CheckedChanged(sender As Object, e As EventArgs) Handles chk_5.CheckedChanged
        If chk_5.Checked = True Then
            txt_5.Enabled = True
        Else
            txt_5.Enabled = False
        End If
    End Sub
    Private Sub chk_6_CheckedChanged(sender As Object, e As EventArgs) Handles chk_6.CheckedChanged
        If chk_6.Checked = True Then
            txt_6.Enabled = True
        Else
            txt_6.Enabled = False
        End If
    End Sub
    Private Sub chk_7_CheckedChanged(sender As Object, e As EventArgs) Handles chk_7.CheckedChanged
        If chk_7.Checked = True Then
            txt_7.Enabled = True
        Else
            txt_7.Enabled = False
        End If
    End Sub
    Private Sub chk_8_CheckedChanged(sender As Object, e As EventArgs) Handles chk_8.CheckedChanged
        If chk_8.Checked = True Then
            txt_8.Enabled = True
        Else
            txt_8.Enabled = False
        End If
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If txt_1.Text = "" Or txt_2.Text = "" Or txt_3.Text = "" Or txt_4.Text = "" Or txt_5.Text = "" Or txt_6.Text = "" Or txt_7.Text = "" Or txt_8.Text = "" Then
            MsgBox("Los Campos no pueden quedar vacios.")
            Exit Sub
        End If
        BDHelper.getDBHelper.EjecutarSQL("Update ListaPrecios set Descripcion = '" + txt_1.Text + "' Where Id = 1")
        BDHelper.getDBHelper.EjecutarSQL("Update ListaPrecios set Descripcion = '" + txt_2.Text + "' Where Id = 2")
        BDHelper.getDBHelper.EjecutarSQL("Update ListaPrecios set Descripcion = '" + txt_3.Text + "' Where Id = 3")
        BDHelper.getDBHelper.EjecutarSQL("Update ListaPrecios set Descripcion = '" + txt_4.Text + "' Where Id = 4")
        BDHelper.getDBHelper.EjecutarSQL("Update ListaPrecios set Descripcion = '" + txt_5.Text + "' Where Id = 5")
        BDHelper.getDBHelper.EjecutarSQL("Update ListaPrecios set Descripcion = '" + txt_6.Text + "' Where Id = 6")
        BDHelper.getDBHelper.EjecutarSQL("Update ListaPrecios set Descripcion = '" + txt_7.Text + "' Where Id = 7")
        BDHelper.getDBHelper.EjecutarSQL("Update ListaPrecios set Descripcion = '" + txt_8.Text + "' Where Id = 8")
        MsgBox("Cambios guardados correctamente.")
        Me.Close()
    End Sub
End Class