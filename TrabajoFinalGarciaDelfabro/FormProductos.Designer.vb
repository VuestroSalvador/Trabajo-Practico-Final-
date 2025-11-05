<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductos
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
        BtnAgregarProducto = New Button()
        BtnEliminarProducto = New Button()
        BtnModificarProducto = New Button()
        DtGrdViewPRODUCTOS = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TxtBxNombreProducto = New TextBox()
        TxtBxPrecioProducto = New TextBox()
        TxtBxCategoriaProducto = New TextBox()
        TxtBxIdProducto = New TextBox()
        TxtBxBuscarProducto = New TextBox()
        BtnBuscarProducto = New Button()
        ComBoxFiltrosProductos = New ComboBox()
        Label6 = New Label()
        BtnVolverDesdeProductos = New Button()
        BtnVolvverDesdeProducto = New Button()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        GroupBox4 = New GroupBox()
        CType(DtGrdViewPRODUCTOS, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtnAgregarProducto
        ' 
        BtnAgregarProducto.Location = New Point(31, 120)
        BtnAgregarProducto.Name = "BtnAgregarProducto"
        BtnAgregarProducto.Size = New Size(281, 30)
        BtnAgregarProducto.TabIndex = 0
        BtnAgregarProducto.Text = "Agregar "
        BtnAgregarProducto.UseVisualStyleBackColor = True
        ' 
        ' BtnEliminarProducto
        ' 
        BtnEliminarProducto.Location = New Point(201, 15)
        BtnEliminarProducto.Name = "BtnEliminarProducto"
        BtnEliminarProducto.Size = New Size(120, 32)
        BtnEliminarProducto.TabIndex = 1
        BtnEliminarProducto.Text = "eliminar"
        BtnEliminarProducto.UseVisualStyleBackColor = True
        ' 
        ' BtnModificarProducto
        ' 
        BtnModificarProducto.Location = New Point(19, 25)
        BtnModificarProducto.Name = "BtnModificarProducto"
        BtnModificarProducto.Size = New Size(281, 32)
        BtnModificarProducto.TabIndex = 2
        BtnModificarProducto.Text = "Modificar"
        BtnModificarProducto.UseVisualStyleBackColor = True
        ' 
        ' DtGrdViewPRODUCTOS
        ' 
        DtGrdViewPRODUCTOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DtGrdViewPRODUCTOS.Location = New Point(345, 12)
        DtGrdViewPRODUCTOS.Name = "DtGrdViewPRODUCTOS"
        DtGrdViewPRODUCTOS.Size = New Size(534, 452)
        DtGrdViewPRODUCTOS.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(19, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 21)
        Label1.TabIndex = 4
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(32, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 21)
        Label2.TabIndex = 5
        Label2.Text = "Precio"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(6, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 21)
        Label3.TabIndex = 6
        Label3.Text = "Categoria"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(9, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 21)
        Label4.TabIndex = 7
        Label4.Text = "ID:"
        ' 
        ' TxtBxNombreProducto
        ' 
        TxtBxNombreProducto.Location = New Point(111, 20)
        TxtBxNombreProducto.Name = "TxtBxNombreProducto"
        TxtBxNombreProducto.Size = New Size(188, 26)
        TxtBxNombreProducto.TabIndex = 9
        ' 
        ' TxtBxPrecioProducto
        ' 
        TxtBxPrecioProducto.Location = New Point(111, 51)
        TxtBxPrecioProducto.Name = "TxtBxPrecioProducto"
        TxtBxPrecioProducto.Size = New Size(188, 26)
        TxtBxPrecioProducto.TabIndex = 10
        ' 
        ' TxtBxCategoriaProducto
        ' 
        TxtBxCategoriaProducto.Location = New Point(111, 83)
        TxtBxCategoriaProducto.Name = "TxtBxCategoriaProducto"
        TxtBxCategoriaProducto.Size = New Size(188, 26)
        TxtBxCategoriaProducto.TabIndex = 11
        ' 
        ' TxtBxIdProducto
        ' 
        TxtBxIdProducto.Location = New Point(46, 19)
        TxtBxIdProducto.Name = "TxtBxIdProducto"
        TxtBxIdProducto.Size = New Size(149, 26)
        TxtBxIdProducto.TabIndex = 12
        ' 
        ' TxtBxBuscarProducto
        ' 
        TxtBxBuscarProducto.Location = New Point(5, 54)
        TxtBxBuscarProducto.Name = "TxtBxBuscarProducto"
        TxtBxBuscarProducto.Size = New Size(188, 26)
        TxtBxBuscarProducto.TabIndex = 13
        ' 
        ' BtnBuscarProducto
        ' 
        BtnBuscarProducto.Location = New Point(199, 50)
        BtnBuscarProducto.Name = "BtnBuscarProducto"
        BtnBuscarProducto.Size = New Size(120, 32)
        BtnBuscarProducto.TabIndex = 14
        BtnBuscarProducto.Text = "Buscar"
        BtnBuscarProducto.UseVisualStyleBackColor = True
        ' 
        ' ComBoxFiltrosProductos
        ' 
        ComBoxFiltrosProductos.FormattingEnabled = True
        ComBoxFiltrosProductos.Items.AddRange(New Object() {"Nombre", "Categoria"})
        ComBoxFiltrosProductos.Location = New Point(5, 21)
        ComBoxFiltrosProductos.Name = "ComBoxFiltrosProductos"
        ComBoxFiltrosProductos.Size = New Size(121, 27)
        ComBoxFiltrosProductos.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(132, 26)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 21)
        Label6.TabIndex = 16
        Label6.Text = "Filtrar"
        ' 
        ' BtnVolverDesdeProductos
        ' 
        BtnVolverDesdeProductos.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnVolverDesdeProductos.Location = New Point(31, 416)
        BtnVolverDesdeProductos.Name = "BtnVolverDesdeProductos"
        BtnVolverDesdeProductos.Size = New Size(68, 48)
        BtnVolverDesdeProductos.TabIndex = 17
        BtnVolverDesdeProductos.Text = "🏡"
        BtnVolverDesdeProductos.UseVisualStyleBackColor = True
        ' 
        ' BtnVolvverDesdeProducto
        ' 
        BtnVolvverDesdeProducto.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnVolvverDesdeProducto.Location = New Point(13, 416)
        BtnVolvverDesdeProducto.Name = "BtnVolvverDesdeProducto"
        BtnVolvverDesdeProducto.Size = New Size(21, 48)
        BtnVolvverDesdeProducto.TabIndex = 18
        BtnVolvverDesdeProducto.Text = "<-"
        BtnVolvverDesdeProducto.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TxtBxNombreProducto)
        GroupBox1.Controls.Add(TxtBxPrecioProducto)
        GroupBox1.Controls.Add(TxtBxCategoriaProducto)
        GroupBox1.Controls.Add(BtnAgregarProducto)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(327, 161)
        GroupBox1.TabIndex = 19
        GroupBox1.TabStop = False
        GroupBox1.Text = "Ingrese Los Campos del Producto a Agregar"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.White
        GroupBox2.Controls.Add(BtnEliminarProducto)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(TxtBxIdProducto)
        GroupBox2.Location = New Point(12, 179)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(327, 54)
        GroupBox2.TabIndex = 20
        GroupBox2.TabStop = False
        GroupBox2.Text = "Ingrese ID Del Producto a Eliminar"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.White
        GroupBox3.Controls.Add(BtnModificarProducto)
        GroupBox3.Location = New Point(12, 241)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(327, 67)
        GroupBox3.TabIndex = 21
        GroupBox3.TabStop = False
        GroupBox3.Text = "Click en la propiedad que se desee modificar"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.White
        GroupBox4.Controls.Add(TxtBxBuscarProducto)
        GroupBox4.Controls.Add(BtnBuscarProducto)
        GroupBox4.Controls.Add(ComBoxFiltrosProductos)
        GroupBox4.Controls.Add(Label6)
        GroupBox4.Location = New Point(13, 315)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(326, 95)
        GroupBox4.TabIndex = 22
        GroupBox4.TabStop = False
        GroupBox4.Text = "Ingrese Filtro Junto a lo que desee buscar"
        ' 
        ' FormProductos
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Maroon
        ClientSize = New Size(884, 476)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(BtnVolvverDesdeProducto)
        Controls.Add(BtnVolverDesdeProductos)
        Controls.Add(DtGrdViewPRODUCTOS)
        Name = "FormProductos"
        Text = "FormProductos"
        CType(DtGrdViewPRODUCTOS, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnAgregarProducto As Button
    Friend WithEvents BtnEliminarProducto As Button
    Friend WithEvents BtnModificarProducto As Button
    Friend WithEvents DtGrdViewPRODUCTOS As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBxNombreProducto As TextBox
    Friend WithEvents TxtBxPrecioProducto As TextBox
    Friend WithEvents TxtBxCategoriaProducto As TextBox
    Friend WithEvents TxtBxIdProducto As TextBox
    Friend WithEvents TxtBxBuscarProducto As TextBox
    Friend WithEvents BtnBuscarProducto As Button
    Friend WithEvents ComBoxFiltrosProductos As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnVolverDesdeProductos As Button
    Friend WithEvents BtnVolvverDesdeProducto As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
