<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes
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
        GroupBox4 = New GroupBox()
        TxtBxBuscarCliente = New TextBox()
        BtnBuscarCliente = New Button()
        CmBoxFiltroCliente = New ComboBox()
        Label6 = New Label()
        GroupBox3 = New GroupBox()
        BtnModificarCliente = New Button()
        GroupBox2 = New GroupBox()
        BtnEliminarCliente = New Button()
        Label4 = New Label()
        TxtBxIdCliente = New TextBox()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TxtBxNombreCliente = New TextBox()
        TxtBxTelefonoCliente = New TextBox()
        TxtBxCorreoCliente = New TextBox()
        BtnAgregarCliente = New Button()
        BtnVolvverDesdeClientes = New Button()
        BtnVolverDesdeClientes = New Button()
        DtGrdViewCLIENTES = New DataGridView()
        GroupBox4.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(DtGrdViewCLIENTES, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(TxtBxBuscarCliente)
        GroupBox4.Controls.Add(BtnBuscarCliente)
        GroupBox4.Controls.Add(CmBoxFiltroCliente)
        GroupBox4.Controls.Add(Label6)
        GroupBox4.Location = New Point(32, 332)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(326, 95)
        GroupBox4.TabIndex = 29
        GroupBox4.TabStop = False
        GroupBox4.Text = "Ingrese Filtro Junto a lo que desee buscar"
        ' 
        ' TxtBxBuscarCliente
        ' 
        TxtBxBuscarCliente.Location = New Point(5, 54)
        TxtBxBuscarCliente.Name = "TxtBxBuscarCliente"
        TxtBxBuscarCliente.Size = New Size(188, 26)
        TxtBxBuscarCliente.TabIndex = 13
        ' 
        ' BtnBuscarCliente
        ' 
        BtnBuscarCliente.Location = New Point(199, 50)
        BtnBuscarCliente.Name = "BtnBuscarCliente"
        BtnBuscarCliente.Size = New Size(120, 32)
        BtnBuscarCliente.TabIndex = 14
        BtnBuscarCliente.Text = "Buscar"
        BtnBuscarCliente.UseVisualStyleBackColor = True
        ' 
        ' CmBoxFiltroCliente
        ' 
        CmBoxFiltroCliente.FormattingEnabled = True
        CmBoxFiltroCliente.Items.AddRange(New Object() {"Nombre", "Telefono", "Correo"})
        CmBoxFiltroCliente.Location = New Point(5, 21)
        CmBoxFiltroCliente.Name = "CmBoxFiltroCliente"
        CmBoxFiltroCliente.Size = New Size(121, 27)
        CmBoxFiltroCliente.TabIndex = 15
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
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(BtnModificarCliente)
        GroupBox3.Location = New Point(31, 258)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(327, 67)
        GroupBox3.TabIndex = 28
        GroupBox3.TabStop = False
        GroupBox3.Text = "Click en la propiedad que se desee modificar"
        ' 
        ' BtnModificarCliente
        ' 
        BtnModificarCliente.Location = New Point(19, 25)
        BtnModificarCliente.Name = "BtnModificarCliente"
        BtnModificarCliente.Size = New Size(281, 32)
        BtnModificarCliente.TabIndex = 2
        BtnModificarCliente.Text = "Modificar"
        BtnModificarCliente.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(BtnEliminarCliente)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(TxtBxIdCliente)
        GroupBox2.Location = New Point(31, 196)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(327, 54)
        GroupBox2.TabIndex = 27
        GroupBox2.TabStop = False
        GroupBox2.Text = "Ingrese ID Del Cliente a Eliminar"
        ' 
        ' BtnEliminarCliente
        ' 
        BtnEliminarCliente.Location = New Point(201, 15)
        BtnEliminarCliente.Name = "BtnEliminarCliente"
        BtnEliminarCliente.Size = New Size(120, 32)
        BtnEliminarCliente.TabIndex = 1
        BtnEliminarCliente.Text = "eliminar"
        BtnEliminarCliente.UseVisualStyleBackColor = True
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
        ' TxtBxIdCliente
        ' 
        TxtBxIdCliente.Location = New Point(46, 19)
        TxtBxIdCliente.Name = "TxtBxIdCliente"
        TxtBxIdCliente.Size = New Size(149, 26)
        TxtBxIdCliente.TabIndex = 12
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TxtBxNombreCliente)
        GroupBox1.Controls.Add(TxtBxTelefonoCliente)
        GroupBox1.Controls.Add(TxtBxCorreoCliente)
        GroupBox1.Controls.Add(BtnAgregarCliente)
        GroupBox1.Location = New Point(31, 29)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(327, 161)
        GroupBox1.TabIndex = 26
        GroupBox1.TabStop = False
        GroupBox1.Text = "Ingrese Los Datos Del Cliente a Agregar"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 21)
        Label1.TabIndex = 4
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(15, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 21)
        Label2.TabIndex = 5
        Label2.Text = "Telefono"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(32, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 21)
        Label3.TabIndex = 6
        Label3.Text = "Correo"
        ' 
        ' TxtBxNombreCliente
        ' 
        TxtBxNombreCliente.Location = New Point(111, 20)
        TxtBxNombreCliente.Name = "TxtBxNombreCliente"
        TxtBxNombreCliente.Size = New Size(188, 26)
        TxtBxNombreCliente.TabIndex = 9
        ' 
        ' TxtBxTelefonoCliente
        ' 
        TxtBxTelefonoCliente.Location = New Point(111, 51)
        TxtBxTelefonoCliente.Name = "TxtBxTelefonoCliente"
        TxtBxTelefonoCliente.Size = New Size(188, 26)
        TxtBxTelefonoCliente.TabIndex = 10
        ' 
        ' TxtBxCorreoCliente
        ' 
        TxtBxCorreoCliente.Location = New Point(111, 83)
        TxtBxCorreoCliente.Name = "TxtBxCorreoCliente"
        TxtBxCorreoCliente.Size = New Size(188, 26)
        TxtBxCorreoCliente.TabIndex = 11
        ' 
        ' BtnAgregarCliente
        ' 
        BtnAgregarCliente.Location = New Point(31, 120)
        BtnAgregarCliente.Name = "BtnAgregarCliente"
        BtnAgregarCliente.Size = New Size(281, 30)
        BtnAgregarCliente.TabIndex = 0
        BtnAgregarCliente.Text = "Agregar "
        BtnAgregarCliente.UseVisualStyleBackColor = True
        ' 
        ' BtnVolvverDesdeClientes
        ' 
        BtnVolvverDesdeClientes.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnVolvverDesdeClientes.Location = New Point(32, 433)
        BtnVolvverDesdeClientes.Name = "BtnVolvverDesdeClientes"
        BtnVolvverDesdeClientes.Size = New Size(21, 29)
        BtnVolvverDesdeClientes.TabIndex = 25
        BtnVolvverDesdeClientes.Text = "<-"
        BtnVolvverDesdeClientes.UseVisualStyleBackColor = True
        ' 
        ' BtnVolverDesdeClientes
        ' 
        BtnVolverDesdeClientes.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnVolverDesdeClientes.Location = New Point(50, 433)
        BtnVolverDesdeClientes.Name = "BtnVolverDesdeClientes"
        BtnVolverDesdeClientes.Size = New Size(49, 29)
        BtnVolverDesdeClientes.TabIndex = 24
        BtnVolverDesdeClientes.Text = "🏡"
        BtnVolverDesdeClientes.TextAlign = ContentAlignment.TopCenter
        BtnVolverDesdeClientes.UseVisualStyleBackColor = True
        ' 
        ' DtGrdViewCLIENTES
        ' 
        DtGrdViewCLIENTES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DtGrdViewCLIENTES.Location = New Point(364, 29)
        DtGrdViewCLIENTES.Name = "DtGrdViewCLIENTES"
        DtGrdViewCLIENTES.Size = New Size(443, 426)
        DtGrdViewCLIENTES.TabIndex = 23
        ' 
        ' FormClientes
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(838, 490)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(BtnVolvverDesdeClientes)
        Controls.Add(BtnVolverDesdeClientes)
        Controls.Add(DtGrdViewCLIENTES)
        Name = "FormClientes"
        Text = "FormClientes"
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DtGrdViewCLIENTES, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtBxBuscarCliente As TextBox
    Friend WithEvents BtnBuscarCliente As Button
    Friend WithEvents CmBoxFiltroCliente As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnModificarCliente As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnEliminarCliente As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBxIdCliente As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBxNombreCliente As TextBox
    Friend WithEvents TxtBxTelefonoCliente As TextBox
    Friend WithEvents TxtBxCorreoCliente As TextBox
    Friend WithEvents BtnAgregarCliente As Button
    Friend WithEvents BtnVolvverDesdeClientes As Button
    Friend WithEvents BtnVolverDesdeClientes As Button
    Friend WithEvents DtGrdViewCLIENTES As DataGridView
End Class
