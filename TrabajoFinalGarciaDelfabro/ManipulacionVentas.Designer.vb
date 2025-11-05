<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManipulacionVentas
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
        DgVwVentasSoloVentas = New DataGridView()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        TxtBxFecha1 = New TextBox()
        TxtBxFecha2 = New TextBox()
        BtnFiltroFechas = New Button()
        BtnAñadirOtraVenta = New Button()
        BtnInicio = New Button()
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        CType(DgVwVentasSoloVentas, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DgVwVentasSoloVentas
        ' 
        DgVwVentasSoloVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgVwVentasSoloVentas.Location = New Point(12, 12)
        DgVwVentasSoloVentas.Name = "DgVwVentasSoloVentas"
        DgVwVentasSoloVentas.Size = New Size(828, 286)
        DgVwVentasSoloVentas.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(173, 2)
        Label3.Name = "Label3"
        Label3.Size = New Size(498, 30)
        Label3.TabIndex = 14
        Label3.Text = "Seleccionar Ventas Dentro De Un Lapso De Tiempo"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(6, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 30)
        Label1.TabIndex = 15
        Label1.Text = "Fecha Inicio"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(6, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 30)
        Label2.TabIndex = 16
        Label2.Text = "Fecha Final"
        ' 
        ' TxtBxFecha1
        ' 
        TxtBxFecha1.Location = New Point(137, 53)
        TxtBxFecha1.Name = "TxtBxFecha1"
        TxtBxFecha1.Size = New Size(358, 26)
        TxtBxFecha1.TabIndex = 17
        ' 
        ' TxtBxFecha2
        ' 
        TxtBxFecha2.Location = New Point(137, 100)
        TxtBxFecha2.Name = "TxtBxFecha2"
        TxtBxFecha2.Size = New Size(358, 26)
        TxtBxFecha2.TabIndex = 18
        ' 
        ' BtnFiltroFechas
        ' 
        BtnFiltroFechas.Location = New Point(511, 73)
        BtnFiltroFechas.Name = "BtnFiltroFechas"
        BtnFiltroFechas.Size = New Size(101, 31)
        BtnFiltroFechas.TabIndex = 19
        BtnFiltroFechas.Text = "Filtrar Ventas"
        BtnFiltroFechas.UseVisualStyleBackColor = True
        ' 
        ' BtnAñadirOtraVenta
        ' 
        BtnAñadirOtraVenta.Location = New Point(618, 62)
        BtnAñadirOtraVenta.Name = "BtnAñadirOtraVenta"
        BtnAñadirOtraVenta.Size = New Size(132, 29)
        BtnAñadirOtraVenta.TabIndex = 20
        BtnAñadirOtraVenta.Text = "Añadir Otra Venta"
        BtnAñadirOtraVenta.UseVisualStyleBackColor = True
        ' 
        ' BtnInicio
        ' 
        BtnInicio.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnInicio.Location = New Point(756, 73)
        BtnInicio.Name = "BtnInicio"
        BtnInicio.Size = New Size(69, 51)
        BtnInicio.TabIndex = 25
        BtnInicio.Text = "🏡"
        BtnInicio.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(BtnInicio)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(BtnAñadirOtraVenta)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(BtnFiltroFechas)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TxtBxFecha2)
        GroupBox1.Controls.Add(TxtBxFecha1)
        GroupBox1.Location = New Point(12, 304)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(828, 152)
        GroupBox1.TabIndex = 26
        GroupBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(618, 95)
        Button1.Name = "Button1"
        Button1.Size = New Size(132, 29)
        Button1.TabIndex = 26
        Button1.Text = "Mostrar Todas"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ManipulacionVentas
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Maroon
        ClientSize = New Size(852, 468)
        Controls.Add(GroupBox1)
        Controls.Add(DgVwVentasSoloVentas)
        Name = "ManipulacionVentas"
        Text = "ManipulacionVentas"
        CType(DgVwVentasSoloVentas, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DgVwVentasSoloVentas As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBxFecha1 As TextBox
    Friend WithEvents TxtBxFecha2 As TextBox
    Friend WithEvents BtnFiltroFechas As Button
    Friend WithEvents BtnAñadirOtraVenta As Button
    Friend WithEvents BtnInicio As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
End Class
