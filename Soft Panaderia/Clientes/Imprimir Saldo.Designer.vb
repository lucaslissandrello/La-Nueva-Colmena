<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Imprimir_Saldo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.visor = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SaldoDataSet = New LaNuevaColmena.SaldoDataSet()
        Me.SaldoDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SaldoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaldoDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'visor
        '
        Me.visor.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SaldoDataSetBindingSource
        Me.visor.LocalReport.DataSources.Add(ReportDataSource1)
        Me.visor.LocalReport.ReportEmbeddedResource = "LaNuevaColmena.ImprimirSaldo.rdlc"
        Me.visor.Location = New System.Drawing.Point(0, 0)
        Me.visor.Name = "visor"
        Me.visor.ServerReport.ReportServerUrl = New System.Uri("", System.UriKind.Relative)
        Me.visor.Size = New System.Drawing.Size(594, 590)
        Me.visor.TabIndex = 0
        '
        'SaldoDataSet
        '
        Me.SaldoDataSet.DataSetName = "SaldoDataSet"
        Me.SaldoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SaldoDataSetBindingSource
        '
        Me.SaldoDataSetBindingSource.DataSource = Me.SaldoDataSet
        Me.SaldoDataSetBindingSource.Position = 0
        '
        'Imprimir_Saldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 590)
        Me.Controls.Add(Me.visor)
        Me.Name = "Imprimir_Saldo"
        Me.Text = "Imprimir Saldo"
        CType(Me.SaldoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaldoDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents visor As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SaldoDataSetBindingSource As BindingSource
    Friend WithEvents SaldoDataSet As SaldoDataSet
End Class
