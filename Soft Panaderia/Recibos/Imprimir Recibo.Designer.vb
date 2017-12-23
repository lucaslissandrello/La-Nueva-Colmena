<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Imprimir_Recibo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Imprimir_Recibo))
        Me.RecibosXFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReciboDataSet = New LaNuevaColmena.ReciboDataSet()
        Me.visor1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RecibosXFacturaTableAdapter = New LaNuevaColmena.ReciboDataSetTableAdapters.RecibosXFacturaTableAdapter()
        CType(Me.RecibosXFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReciboDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RecibosXFacturaBindingSource
        '
        Me.RecibosXFacturaBindingSource.DataMember = "RecibosXFactura"
        Me.RecibosXFacturaBindingSource.DataSource = Me.ReciboDataSet
        '
        'ReciboDataSet
        '
        Me.ReciboDataSet.DataSetName = "ReciboDataSet"
        Me.ReciboDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'visor1
        '
        Me.visor1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ReciboDataSet"
        ReportDataSource1.Value = Me.RecibosXFacturaBindingSource
        Me.visor1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.visor1.LocalReport.ReportEmbeddedResource = "LaNuevaColmena.ImprimirRecibos.rdlc"
        Me.visor1.Location = New System.Drawing.Point(0, 0)
        Me.visor1.Name = "visor1"
        Me.visor1.Size = New System.Drawing.Size(685, 530)
        Me.visor1.TabIndex = 0
        '
        'RecibosXFacturaTableAdapter
        '
        Me.RecibosXFacturaTableAdapter.ClearBeforeFill = True
        '
        'Imprimir_Recibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 530)
        Me.Controls.Add(Me.visor1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Imprimir_Recibo"
        Me.Text = "Imprimir Recibo"
        CType(Me.RecibosXFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReciboDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents visor1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RecibosXFacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReciboDataSet As LaNuevaColmena.ReciboDataSet
    Friend WithEvents RecibosXFacturaTableAdapter As LaNuevaColmena.ReciboDataSetTableAdapters.RecibosXFacturaTableAdapter
End Class
