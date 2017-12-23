<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Imprimir_Lista_Precios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Imprimir_Lista_Precios))
        Me.PreciosDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreciosDataSet = New LaNuevaColmena.PreciosDataSet()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.visor1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ProductoTableAdapter = New LaNuevaColmena.PreciosDataSetTableAdapters.ProductoTableAdapter()
        CType(Me.PreciosDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreciosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PreciosDataSetBindingSource
        '
        Me.PreciosDataSetBindingSource.DataSource = Me.PreciosDataSet
        Me.PreciosDataSetBindingSource.Position = 0
        '
        'PreciosDataSet
        '
        Me.PreciosDataSet.DataSetName = "PreciosDataSet"
        Me.PreciosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.PreciosDataSet
        '
        'visor1
        '
        Me.visor1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "PreciosDataSet"
        ReportDataSource1.Value = Me.PreciosDataSetBindingSource
        Me.visor1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.visor1.LocalReport.ReportEmbeddedResource = "LaNuevaColmena.Report1.rdlc"
        Me.visor1.Location = New System.Drawing.Point(0, 0)
        Me.visor1.Name = "visor1"
        Me.visor1.ShowBackButton = False
        Me.visor1.ShowExportButton = False
        Me.visor1.ShowFindControls = False
        Me.visor1.ShowStopButton = False
        Me.visor1.Size = New System.Drawing.Size(649, 537)
        Me.visor1.TabIndex = 0
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'Imprimir_Lista_Precios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 537)
        Me.Controls.Add(Me.visor1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Imprimir_Lista_Precios"
        Me.Text = "Imprimir Lista Precios"
        CType(Me.PreciosDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreciosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents visor1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PreciosDataSet As LaNuevaColmena.PreciosDataSet
    Friend WithEvents ProductoTableAdapter As LaNuevaColmena.PreciosDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents PreciosDataSetBindingSource As System.Windows.Forms.BindingSource
End Class
