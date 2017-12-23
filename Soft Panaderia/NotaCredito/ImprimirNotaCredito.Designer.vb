<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimirNotaCredito
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.visor1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.FacturaDataSet = New LaNuevaColmena.FacturaDataSet()
        Me.DetalleFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetalleFacturaTableAdapter = New LaNuevaColmena.FacturaDataSetTableAdapters.DetalleFacturaTableAdapter()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New LaNuevaColmena.FacturaDataSetTableAdapters.ProductoTableAdapter()
        Me.ProductoDetalleFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.FacturaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoDetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'visor1
        '
        Me.visor1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "DetalleDataSet"
        ReportDataSource3.Value = Me.DetalleFacturaBindingSource
        Me.visor1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.visor1.LocalReport.ReportEmbeddedResource = "LaNuevaColmena.Imprimir_Nota_Credito.rdlc"
        Me.visor1.Location = New System.Drawing.Point(0, 0)
        Me.visor1.Name = "visor1"
        Me.visor1.Size = New System.Drawing.Size(594, 590)
        Me.visor1.TabIndex = 0
        '
        'FacturaDataSet
        '
        Me.FacturaDataSet.DataSetName = "FacturaDataSet"
        Me.FacturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetalleFacturaBindingSource
        '
        Me.DetalleFacturaBindingSource.DataMember = "DetalleFactura"
        Me.DetalleFacturaBindingSource.DataSource = Me.FacturaDataSet
        '
        'DetalleFacturaTableAdapter
        '
        Me.DetalleFacturaTableAdapter.ClearBeforeFill = True
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.FacturaDataSet
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'ProductoDetalleFacturaBindingSource
        '
        Me.ProductoDetalleFacturaBindingSource.DataMember = "ProductoDetalle Factura"
        Me.ProductoDetalleFacturaBindingSource.DataSource = Me.ProductoBindingSource
        '
        'ImprimirNotaCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 590)
        Me.Controls.Add(Me.visor1)
        Me.Name = "ImprimirNotaCredito"
        Me.Text = "ImprimirNotaCredito"
        CType(Me.FacturaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoDetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents visor1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DetalleFacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FacturaDataSet As LaNuevaColmena.FacturaDataSet
    Friend WithEvents DetalleFacturaTableAdapter As LaNuevaColmena.FacturaDataSetTableAdapters.DetalleFacturaTableAdapter
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoTableAdapter As LaNuevaColmena.FacturaDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents ProductoDetalleFacturaBindingSource As System.Windows.Forms.BindingSource
End Class
