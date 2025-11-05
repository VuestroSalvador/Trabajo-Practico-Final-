<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentas
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
        DtGrdVwVentasItems = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        TxtBxIdClienteVenta = New TextBox()
        TxtBxFechaVenta = New TextBox()
        BtnIniciarVenta = New Button()
        GrpBxIniciarVenta = New GroupBox()
        GrpBxProductos = New GroupBox()
        BtnAñadirProducto = New Button()
        TxtBxCantidadVENTA = New TextBox()
        Label4 = New Label()
        TxtBxIdProductoVENTA = New TextBox()
        Label3 = New Label()
        Label7 = New Label()
        TxtBxAUTOtotalVenta = New TextBox()
        BtnFinalizarVenta = New Button()
        Label8 = New Label()
        TxtBxNVenta = New TextBox()
        Button1 = New Button()
        GrpBxFinalizarVenta = New GroupBox()
        GroupBox4 = New GroupBox()
        CType(DtGrdVwVentasItems, ComponentModel.ISupportInitialize).BeginInit()
        GrpBxIniciarVenta.SuspendLayout()
        GrpBxProductos.SuspendLayout()
        GrpBxFinalizarVenta.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' DtGrdVwVentasItems
        ' 
        DtGrdVwVentasItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DtGrdVwVentasItems.Enabled = False
        DtGrdVwVentasItems.Location = New Point(447, 12)
        DtGrdVwVentasItems.Name = "DtGrdVwVentasItems"
        DtGrdVwVentasItems.Size = New Size(535, 422)
        DtGrdVwVentasItems.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(49, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 30)
        Label1.TabIndex = 8
        Label1.Text = "ID Cliente"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(49, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 30)
        Label2.TabIndex = 9
        Label2.Text = "Fecha"
        ' 
        ' TxtBxIdClienteVenta
        ' 
        TxtBxIdClienteVenta.Location = New Point(167, 33)
        TxtBxIdClienteVenta.Name = "TxtBxIdClienteVenta"
        TxtBxIdClienteVenta.Size = New Size(235, 26)
        TxtBxIdClienteVenta.TabIndex = 10
        ' 
        ' TxtBxFechaVenta
        ' 
        TxtBxFechaVenta.Location = New Point(167, 74)
        TxtBxFechaVenta.Name = "TxtBxFechaVenta"
        TxtBxFechaVenta.Size = New Size(235, 26)
        TxtBxFechaVenta.TabIndex = 11
        ' 
        ' BtnIniciarVenta
        ' 
        BtnIniciarVenta.Location = New Point(49, 116)
        BtnIniciarVenta.Name = "BtnIniciarVenta"
        BtnIniciarVenta.Size = New Size(353, 29)
        BtnIniciarVenta.TabIndex = 12
        BtnIniciarVenta.Text = "iniciar Venta"
        BtnIniciarVenta.UseVisualStyleBackColor = True
        ' 
        ' GrpBxIniciarVenta
        ' 
        GrpBxIniciarVenta.BackColor = Color.White
        GrpBxIniciarVenta.Controls.Add(TxtBxFechaVenta)
        GrpBxIniciarVenta.Controls.Add(BtnIniciarVenta)
        GrpBxIniciarVenta.Controls.Add(Label1)
        GrpBxIniciarVenta.Controls.Add(Label2)
        GrpBxIniciarVenta.Controls.Add(TxtBxIdClienteVenta)
        GrpBxIniciarVenta.Location = New Point(12, 12)
        GrpBxIniciarVenta.Name = "GrpBxIniciarVenta"
        GrpBxIniciarVenta.Size = New Size(429, 155)
        GrpBxIniciarVenta.TabIndex = 13
        GrpBxIniciarVenta.TabStop = False
        ' 
        ' GrpBxProductos
        ' 
        GrpBxProductos.BackColor = Color.White
        GrpBxProductos.Controls.Add(BtnAñadirProducto)
        GrpBxProductos.Controls.Add(TxtBxCantidadVENTA)
        GrpBxProductos.Controls.Add(Label4)
        GrpBxProductos.Controls.Add(TxtBxIdProductoVENTA)
        GrpBxProductos.Controls.Add(Label3)
        GrpBxProductos.Enabled = False
        GrpBxProductos.Location = New Point(12, 173)
        GrpBxProductos.Name = "GrpBxProductos"
        GrpBxProductos.Size = New Size(429, 177)
        GrpBxProductos.TabIndex = 14
        GrpBxProductos.TabStop = False
        GrpBxProductos.Text = "Productos"
        ' 
        ' BtnAñadirProducto
        ' 
        BtnAñadirProducto.Location = New Point(49, 116)
        BtnAñadirProducto.Name = "BtnAñadirProducto"
        BtnAñadirProducto.Size = New Size(353, 29)
        BtnAñadirProducto.TabIndex = 13
        BtnAñadirProducto.Text = "Añadir Producto"
        BtnAñadirProducto.UseVisualStyleBackColor = True
        ' 
        ' TxtBxCantidadVENTA
        ' 
        TxtBxCantidadVENTA.Location = New Point(180, 72)
        TxtBxCantidadVENTA.Name = "TxtBxCantidadVENTA"
        TxtBxCantidadVENTA.Size = New Size(222, 26)
        TxtBxCantidadVENTA.TabIndex = 17
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(49, 72)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 30)
        Label4.TabIndex = 14
        Label4.Text = "Cantidad"
        ' 
        ' TxtBxIdProductoVENTA
        ' 
        TxtBxIdProductoVENTA.Location = New Point(180, 40)
        TxtBxIdProductoVENTA.Name = "TxtBxIdProductoVENTA"
        TxtBxIdProductoVENTA.Size = New Size(222, 26)
        TxtBxIdProductoVENTA.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(49, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 30)
        Label3.TabIndex = 13
        Label3.Text = "ID Producto"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(50, 22)
        Label7.Name = "Label7"
        Label7.Size = New Size(124, 30)
        Label7.TabIndex = 20
        Label7.Text = "Total Venta"
        ' 
        ' TxtBxAUTOtotalVenta
        ' 
        TxtBxAUTOtotalVenta.Enabled = False
        TxtBxAUTOtotalVenta.Location = New Point(180, 25)
        TxtBxAUTOtotalVenta.Name = "TxtBxAUTOtotalVenta"
        TxtBxAUTOtotalVenta.Size = New Size(161, 26)
        TxtBxAUTOtotalVenta.TabIndex = 20
        ' 
        ' BtnFinalizarVenta
        ' 
        BtnFinalizarVenta.Location = New Point(91, 66)
        BtnFinalizarVenta.Name = "BtnFinalizarVenta"
        BtnFinalizarVenta.Size = New Size(196, 29)
        BtnFinalizarVenta.TabIndex = 21
        BtnFinalizarVenta.Text = "Finalizar Venta"
        BtnFinalizarVenta.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(18, 7)
        Label8.Name = "Label8"
        Label8.Size = New Size(136, 30)
        Label8.TabIndex = 22
        Label8.Text = "N° De Venta:"
        ' 
        ' TxtBxNVenta
        ' 
        TxtBxNVenta.Enabled = False
        TxtBxNVenta.Location = New Point(160, 11)
        TxtBxNVenta.Name = "TxtBxNVenta"
        TxtBxNVenta.Size = New Size(211, 26)
        TxtBxNVenta.TabIndex = 23
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(904, 440)
        Button1.Name = "Button1"
        Button1.Size = New Size(78, 42)
        Button1.TabIndex = 24
        Button1.Text = "🏡"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GrpBxFinalizarVenta
        ' 
        GrpBxFinalizarVenta.BackColor = Color.White
        GrpBxFinalizarVenta.Controls.Add(TxtBxAUTOtotalVenta)
        GrpBxFinalizarVenta.Controls.Add(Label7)
        GrpBxFinalizarVenta.Controls.Add(BtnFinalizarVenta)
        GrpBxFinalizarVenta.Enabled = False
        GrpBxFinalizarVenta.Location = New Point(12, 356)
        GrpBxFinalizarVenta.Name = "GrpBxFinalizarVenta"
        GrpBxFinalizarVenta.Size = New Size(429, 126)
        GrpBxFinalizarVenta.TabIndex = 25
        GrpBxFinalizarVenta.TabStop = False
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.White
        GroupBox4.Controls.Add(TxtBxNVenta)
        GroupBox4.Controls.Add(Label8)
        GroupBox4.Location = New Point(447, 439)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(451, 43)
        GroupBox4.TabIndex = 26
        GroupBox4.TabStop = False
        ' 
        ' FormVentas
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Maroon
        ClientSize = New Size(994, 497)
        Controls.Add(GroupBox4)
        Controls.Add(GrpBxFinalizarVenta)
        Controls.Add(Button1)
        Controls.Add(GrpBxProductos)
        Controls.Add(GrpBxIniciarVenta)
        Controls.Add(DtGrdVwVentasItems)
        Name = "FormVentas"
        Text = "FormVentas"
        CType(DtGrdVwVentasItems, ComponentModel.ISupportInitialize).EndInit()
        GrpBxIniciarVenta.ResumeLayout(False)
        GrpBxIniciarVenta.PerformLayout()
        GrpBxProductos.ResumeLayout(False)
        GrpBxProductos.PerformLayout()
        GrpBxFinalizarVenta.ResumeLayout(False)
        GrpBxFinalizarVenta.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents DtGrdVwVentasItems As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBxIdClienteVenta As TextBox
    Friend WithEvents TxtBxFechaVenta As TextBox
    Friend WithEvents BtnIniciarVenta As Button
    Friend WithEvents GrpBxIniciarVenta As GroupBox
    Friend WithEvents GrpBxProductos As GroupBox
    Friend WithEvents BtnAñadirProducto As Button
    Friend WithEvents TxtBxCantidadVENTA As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBxIdProductoVENTA As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtBxAUTOtotalVenta As TextBox
    Friend WithEvents BtnFinalizarVenta As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtBxNVenta As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GrpBxFinalizarVenta As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
