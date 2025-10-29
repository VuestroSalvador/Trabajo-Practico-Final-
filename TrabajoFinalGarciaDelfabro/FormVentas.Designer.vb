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
        TxtBxIdCliente = New TextBox()
        TxtBxFechaVenta = New TextBox()
        TxtBxToTalVenta = New TextBox()
        BtnRegistrarVenta = New Button()
        DtGrdVwVENTAS = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        GrpBx1RegistroVenta = New GroupBox()
        GrpBx2BuscarVentas = New GroupBox()
        BtnBuscarPorfecha = New Button()
        TxtBxFecha2Buscar = New TextBox()
        TxtBxFecha1Buscar = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        GroupBox3 = New GroupBox()
        BtnSeleccionarVentaADDITEMS = New Button()
        TxtBxIdVentaAñadirItem = New TextBox()
        Label6 = New Label()
        GrpBxItems = New GroupBox()
        BtnVolvverDesdeProducto = New Button()
        Button1 = New Button()
        BtnVolverDesdeProductos = New Button()
        BtnAñadirItem = New Button()
        TxtBxTotalDELPRODUCTOSOLO = New TextBox()
        TxtBxPrecioUnitario = New TextBox()
        TxtBxCantidadProducto = New TextBox()
        TxtBxIDPRODUCTO = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        CType(DtGrdVwVENTAS, ComponentModel.ISupportInitialize).BeginInit()
        GrpBx1RegistroVenta.SuspendLayout()
        GrpBx2BuscarVentas.SuspendLayout()
        GroupBox3.SuspendLayout()
        GrpBxItems.SuspendLayout()
        SuspendLayout()
        ' 
        ' TxtBxIdCliente
        ' 
        TxtBxIdCliente.Location = New Point(112, 28)
        TxtBxIdCliente.Name = "TxtBxIdCliente"
        TxtBxIdCliente.Size = New Size(179, 26)
        TxtBxIdCliente.TabIndex = 3
        ' 
        ' TxtBxFechaVenta
        ' 
        TxtBxFechaVenta.Location = New Point(112, 60)
        TxtBxFechaVenta.Name = "TxtBxFechaVenta"
        TxtBxFechaVenta.Size = New Size(179, 26)
        TxtBxFechaVenta.TabIndex = 4
        ' 
        ' TxtBxToTalVenta
        ' 
        TxtBxToTalVenta.Location = New Point(112, 92)
        TxtBxToTalVenta.Name = "TxtBxToTalVenta"
        TxtBxToTalVenta.Size = New Size(179, 26)
        TxtBxToTalVenta.TabIndex = 5
        ' 
        ' BtnRegistrarVenta
        ' 
        BtnRegistrarVenta.Location = New Point(9, 124)
        BtnRegistrarVenta.Name = "BtnRegistrarVenta"
        BtnRegistrarVenta.Size = New Size(282, 28)
        BtnRegistrarVenta.TabIndex = 6
        BtnRegistrarVenta.Text = "Registrar"
        BtnRegistrarVenta.UseVisualStyleBackColor = True
        ' 
        ' DtGrdVwVENTAS
        ' 
        DtGrdVwVENTAS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DtGrdVwVENTAS.Location = New Point(13, 12)
        DtGrdVwVENTAS.Name = "DtGrdVwVENTAS"
        DtGrdVwVENTAS.Size = New Size(487, 316)
        DtGrdVwVENTAS.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(9, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 8
        Label1.Text = "ID Cliente"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(43, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 25)
        Label2.TabIndex = 9
        Label2.Text = "Fecha"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(43, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 25)
        Label3.TabIndex = 10
        Label3.Text = "Total"
        ' 
        ' GrpBx1RegistroVenta
        ' 
        GrpBx1RegistroVenta.Controls.Add(TxtBxToTalVenta)
        GrpBx1RegistroVenta.Controls.Add(Label3)
        GrpBx1RegistroVenta.Controls.Add(TxtBxIdCliente)
        GrpBx1RegistroVenta.Controls.Add(Label2)
        GrpBx1RegistroVenta.Controls.Add(TxtBxFechaVenta)
        GrpBx1RegistroVenta.Controls.Add(Label1)
        GrpBx1RegistroVenta.Controls.Add(BtnRegistrarVenta)
        GrpBx1RegistroVenta.Location = New Point(506, 12)
        GrpBx1RegistroVenta.Name = "GrpBx1RegistroVenta"
        GrpBx1RegistroVenta.Size = New Size(291, 168)
        GrpBx1RegistroVenta.TabIndex = 11
        GrpBx1RegistroVenta.TabStop = False
        GrpBx1RegistroVenta.Text = "Registrar Una Venta"
        ' 
        ' GrpBx2BuscarVentas
        ' 
        GrpBx2BuscarVentas.Controls.Add(BtnBuscarPorfecha)
        GrpBx2BuscarVentas.Controls.Add(TxtBxFecha2Buscar)
        GrpBx2BuscarVentas.Controls.Add(TxtBxFecha1Buscar)
        GrpBx2BuscarVentas.Controls.Add(Label5)
        GrpBx2BuscarVentas.Controls.Add(Label4)
        GrpBx2BuscarVentas.Location = New Point(506, 186)
        GrpBx2BuscarVentas.Name = "GrpBx2BuscarVentas"
        GrpBx2BuscarVentas.Size = New Size(291, 142)
        GrpBx2BuscarVentas.TabIndex = 12
        GrpBx2BuscarVentas.TabStop = False
        GrpBx2BuscarVentas.Text = "Buscar Ventas Entre Dos Fechas"
        ' 
        ' BtnBuscarPorfecha
        ' 
        BtnBuscarPorfecha.Location = New Point(9, 108)
        BtnBuscarPorfecha.Name = "BtnBuscarPorfecha"
        BtnBuscarPorfecha.Size = New Size(282, 28)
        BtnBuscarPorfecha.TabIndex = 11
        BtnBuscarPorfecha.Text = "Buscar"
        BtnBuscarPorfecha.UseVisualStyleBackColor = True
        ' 
        ' TxtBxFecha2Buscar
        ' 
        TxtBxFecha2Buscar.Location = New Point(106, 67)
        TxtBxFecha2Buscar.Name = "TxtBxFecha2Buscar"
        TxtBxFecha2Buscar.Size = New Size(179, 26)
        TxtBxFecha2Buscar.TabIndex = 13
        ' 
        ' TxtBxFecha1Buscar
        ' 
        TxtBxFecha1Buscar.Location = New Point(106, 31)
        TxtBxFecha1Buscar.Name = "TxtBxFecha1Buscar"
        TxtBxFecha1Buscar.Size = New Size(179, 26)
        TxtBxFecha1Buscar.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(1, 68)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 25)
        Label5.TabIndex = 12
        Label5.Text = "Fecha Máx."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(6, 32)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 25)
        Label4.TabIndex = 11
        Label4.Text = "Fecha Min."
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(BtnSeleccionarVentaADDITEMS)
        GroupBox3.Controls.Add(TxtBxIdVentaAñadirItem)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Location = New Point(506, 333)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(291, 105)
        GroupBox3.TabIndex = 13
        GroupBox3.TabStop = False
        GroupBox3.Text = "Añadir items a una Venta"
        ' 
        ' BtnSeleccionarVentaADDITEMS
        ' 
        BtnSeleccionarVentaADDITEMS.Location = New Point(3, 68)
        BtnSeleccionarVentaADDITEMS.Name = "BtnSeleccionarVentaADDITEMS"
        BtnSeleccionarVentaADDITEMS.Size = New Size(282, 28)
        BtnSeleccionarVentaADDITEMS.TabIndex = 14
        BtnSeleccionarVentaADDITEMS.Text = "Seleccionar"
        BtnSeleccionarVentaADDITEMS.UseVisualStyleBackColor = True
        ' 
        ' TxtBxIdVentaAñadirItem
        ' 
        TxtBxIdVentaAñadirItem.Location = New Point(129, 36)
        TxtBxIdVentaAñadirItem.Name = "TxtBxIdVentaAñadirItem"
        TxtBxIdVentaAñadirItem.Size = New Size(153, 26)
        TxtBxIdVentaAñadirItem.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(9, 34)
        Label6.Name = "Label6"
        Label6.Size = New Size(114, 25)
        Label6.TabIndex = 14
        Label6.Text = "ID de Venta"
        ' 
        ' GrpBxItems
        ' 
        GrpBxItems.Controls.Add(BtnVolvverDesdeProducto)
        GrpBxItems.Controls.Add(Button1)
        GrpBxItems.Controls.Add(BtnVolverDesdeProductos)
        GrpBxItems.Controls.Add(BtnAñadirItem)
        GrpBxItems.Controls.Add(TxtBxTotalDELPRODUCTOSOLO)
        GrpBxItems.Controls.Add(TxtBxPrecioUnitario)
        GrpBxItems.Controls.Add(TxtBxCantidadProducto)
        GrpBxItems.Controls.Add(TxtBxIDPRODUCTO)
        GrpBxItems.Controls.Add(Label9)
        GrpBxItems.Controls.Add(Label10)
        GrpBxItems.Controls.Add(Label8)
        GrpBxItems.Controls.Add(Label7)
        GrpBxItems.Enabled = False
        GrpBxItems.Location = New Point(13, 338)
        GrpBxItems.Name = "GrpBxItems"
        GrpBxItems.Size = New Size(487, 100)
        GrpBxItems.TabIndex = 14
        GrpBxItems.TabStop = False
        GrpBxItems.Text = "Datos Del Item a Añadir"
        ' 
        ' BtnVolvverDesdeProducto
        ' 
        BtnVolvverDesdeProducto.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnVolvverDesdeProducto.Location = New Point(-1, 71)
        BtnVolvverDesdeProducto.Name = "BtnVolvverDesdeProducto"
        BtnVolvverDesdeProducto.Size = New Size(21, 29)
        BtnVolvverDesdeProducto.TabIndex = 20
        BtnVolvverDesdeProducto.Text = "<-"
        BtnVolvverDesdeProducto.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(412, 66)
        Button1.Name = "Button1"
        Button1.Size = New Size(58, 27)
        Button1.TabIndex = 22
        Button1.Text = "Volver"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BtnVolverDesdeProductos
        ' 
        BtnVolverDesdeProductos.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnVolverDesdeProductos.Location = New Point(15, 71)
        BtnVolverDesdeProductos.Name = "BtnVolverDesdeProductos"
        BtnVolverDesdeProductos.Size = New Size(40, 29)
        BtnVolverDesdeProductos.TabIndex = 19
        BtnVolverDesdeProductos.Text = "🏡"
        BtnVolverDesdeProductos.TextAlign = ContentAlignment.TopCenter
        BtnVolverDesdeProductos.UseVisualStyleBackColor = True
        ' 
        ' BtnAñadirItem
        ' 
        BtnAñadirItem.Location = New Point(345, 27)
        BtnAñadirItem.Name = "BtnAñadirItem"
        BtnAñadirItem.Size = New Size(136, 28)
        BtnAñadirItem.TabIndex = 15
        BtnAñadirItem.Text = "Añadir"
        BtnAñadirItem.UseVisualStyleBackColor = True
        ' 
        ' TxtBxTotalDELPRODUCTOSOLO
        ' 
        TxtBxTotalDELPRODUCTOSOLO.Enabled = False
        TxtBxTotalDELPRODUCTOSOLO.Location = New Point(273, 67)
        TxtBxTotalDELPRODUCTOSOLO.Name = "TxtBxTotalDELPRODUCTOSOLO"
        TxtBxTotalDELPRODUCTOSOLO.Size = New Size(120, 26)
        TxtBxTotalDELPRODUCTOSOLO.TabIndex = 21
        ' 
        ' TxtBxPrecioUnitario
        ' 
        TxtBxPrecioUnitario.Location = New Point(273, 31)
        TxtBxPrecioUnitario.Name = "TxtBxPrecioUnitario"
        TxtBxPrecioUnitario.Size = New Size(50, 26)
        TxtBxPrecioUnitario.TabIndex = 20
        ' 
        ' TxtBxCantidadProducto
        ' 
        TxtBxCantidadProducto.Location = New Point(153, 68)
        TxtBxCantidadProducto.Name = "TxtBxCantidadProducto"
        TxtBxCantidadProducto.Size = New Size(50, 26)
        TxtBxCantidadProducto.TabIndex = 19
        ' 
        ' TxtBxIDPRODUCTO
        ' 
        TxtBxIDPRODUCTO.Location = New Point(153, 29)
        TxtBxIDPRODUCTO.Name = "TxtBxIDPRODUCTO"
        TxtBxIDPRODUCTO.Size = New Size(50, 26)
        TxtBxIDPRODUCTO.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(56, 69)
        Label9.Name = "Label9"
        Label9.Size = New Size(91, 25)
        Label9.TabIndex = 17
        Label9.Text = "Cantidad"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(212, 68)
        Label10.Name = "Label10"
        Label10.Size = New Size(57, 25)
        Label10.TabIndex = 18
        Label10.Text = "Total"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(212, 31)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 25)
        Label8.TabIndex = 16
        Label8.Text = "Precio"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(6, 30)
        Label7.Name = "Label7"
        Label7.Size = New Size(141, 25)
        Label7.TabIndex = 15
        Label7.Text = "ID de Producto"
        ' 
        ' FormVentas
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GrpBxItems)
        Controls.Add(GroupBox3)
        Controls.Add(GrpBx2BuscarVentas)
        Controls.Add(GrpBx1RegistroVenta)
        Controls.Add(DtGrdVwVENTAS)
        Name = "FormVentas"
        Text = "FormVentas"
        CType(DtGrdVwVENTAS, ComponentModel.ISupportInitialize).EndInit()
        GrpBx1RegistroVenta.ResumeLayout(False)
        GrpBx1RegistroVenta.PerformLayout()
        GrpBx2BuscarVentas.ResumeLayout(False)
        GrpBx2BuscarVentas.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GrpBxItems.ResumeLayout(False)
        GrpBxItems.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TxtBxIdCliente As TextBox
    Friend WithEvents TxtBxFechaVenta As TextBox
    Friend WithEvents TxtBxToTalVenta As TextBox
    Friend WithEvents BtnRegistrarVenta As Button
    Friend WithEvents DtGrdVwVENTAS As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GrpBx1RegistroVenta As GroupBox
    Friend WithEvents GrpBx2BuscarVentas As GroupBox
    Friend WithEvents TxtBxFecha2Buscar As TextBox
    Friend WithEvents TxtBxFecha1Buscar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnBuscarPorfecha As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtBxIdVentaAñadirItem As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnSeleccionarVentaADDITEMS As Button
    Friend WithEvents GrpBxItems As GroupBox
    Friend WithEvents BtnAñadirItem As Button
    Friend WithEvents TxtBxTotalDELPRODUCTOSOLO As TextBox
    Friend WithEvents TxtBxPrecioUnitario As TextBox
    Friend WithEvents TxtBxCantidadProducto As TextBox
    Friend WithEvents TxtBxIDPRODUCTO As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnVolvverDesdeProducto As Button
    Friend WithEvents BtnVolverDesdeProductos As Button
End Class
