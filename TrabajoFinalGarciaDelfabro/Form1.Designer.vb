<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BtnFormClientes = New Button()
        BtnFormProductos = New Button()
        BtnFormVentas = New Button()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnFormClientes
        ' 
        BtnFormClientes.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BtnFormClientes.Location = New Point(472, 357)
        BtnFormClientes.Name = "BtnFormClientes"
        BtnFormClientes.Size = New Size(421, 46)
        BtnFormClientes.TabIndex = 0
        BtnFormClientes.Text = "Clientes"
        BtnFormClientes.UseVisualStyleBackColor = True
        ' 
        ' BtnFormProductos
        ' 
        BtnFormProductos.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BtnFormProductos.Location = New Point(29, 357)
        BtnFormProductos.Name = "BtnFormProductos"
        BtnFormProductos.Size = New Size(421, 46)
        BtnFormProductos.TabIndex = 1
        BtnFormProductos.Text = "Productos"
        BtnFormProductos.UseVisualStyleBackColor = True
        ' 
        ' BtnFormVentas
        ' 
        BtnFormVentas.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BtnFormVentas.Location = New Point(29, 425)
        BtnFormVentas.Name = "BtnFormVentas"
        BtnFormVentas.Size = New Size(421, 46)
        BtnFormVentas.TabIndex = 2
        BtnFormVentas.Text = "Registro Ventas"
        BtnFormVentas.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.baluartedata_removebg_preview
        PictureBox1.Location = New Point(167, 59)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(588, 210)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(352, 521)
        Button1.Name = "Button1"
        Button1.Size = New Size(222, 37)
        Button1.TabIndex = 4
        Button1.Text = "Cerrar Sistema"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(472, 425)
        Button2.Name = "Button2"
        Button2.Size = New Size(421, 46)
        Button2.TabIndex = 5
        Button2.Text = "Visualizacion Ventas"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        ClientSize = New Size(914, 570)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(BtnFormVentas)
        Controls.Add(BtnFormClientes)
        Controls.Add(BtnFormProductos)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnFormClientes As Button
    Friend WithEvents BtnFormProductos As Button
    Friend WithEvents BtnFormVentas As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
