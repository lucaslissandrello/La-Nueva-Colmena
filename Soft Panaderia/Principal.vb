Imports System.ComponentModel
Imports System.IO

Public Class Principal
    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        Clientes.ShowDialog()
    End Sub

    Private Sub btn_precios_Click(sender As Object, e As EventArgs) Handles btn_precios.Click
        Precios.ShowDialog()
    End Sub

    Private Sub btn_backup_Click(sender As Object, e As EventArgs) Handles btn_backup.Click
        dialogo.DefaultExt = "mdb"
        dialogo.ShowDialog()
    End Sub

    Private Sub dialogo_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dialogo.FileOk
        FileCopy(System.Environment.CurrentDirectory.ToString + "\La Nueva colmena.mdb", dialogo.FileName.ToString)
        MsgBox("Backup exitoso")
    End Sub

    Private Sub btn_factura_Click(sender As Object, e As EventArgs) Handles btn_factura.Click
        Facturacion.ShowDialog()
    End Sub

    Private Sub btn_cargarBD_Click(sender As Object, e As EventArgs) Handles btn_cargarBD.Click
        dialogo_abrir.Filter = "mdb files |*.mdb"
        dialogo_abrir.ShowDialog()
    End Sub

    Private Sub dialogo_abrir_FileOk(sender As Object, e As CancelEventArgs) Handles dialogo_abrir.FileOk
        If MsgBox("¿Esta seguro que desea modificar la base de datos? Se perderan los datos actuales del sistema", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim nombre As String = DateTime.Now.ToString("dd-MM-yyyy H-mm-ss")
        My.Computer.FileSystem.RenameFile(System.Environment.CurrentDirectory.ToString + "\La Nueva colmena.mdb", nombre.ToString + ".mdb")
        MsgBox(System.Environment.CurrentDirectory.ToString)
        File.Copy(dialogo_abrir.FileName, System.Environment.CurrentDirectory.ToString + "\La Nueva colmena.mdb")
    End Sub

    Private Sub btn_recibos_Click(sender As Object, e As EventArgs) Handles btn_recibos.Click
        Recibos.ShowDialog()
    End Sub

    Private Sub btn_ListaPrecios_Click(sender As Object, e As EventArgs) Handles btn_ListaPrecios.Click
        Configuracion.ShowDialog()
    End Sub

    Private Sub Principal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case Keys.Alt + Keys.L
                MsgBox(System.Environment.CurrentDirectory.ToString)
        End Select
    End Sub
End Class
