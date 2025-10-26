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
        SuspendLayout()
        ' 
        ' BtnFormClientes
        ' 
        BtnFormClientes.Location = New Point(117, 343)
        BtnFormClientes.Name = "BtnFormClientes"
        BtnFormClientes.Size = New Size(143, 76)
        BtnFormClientes.TabIndex = 0
        BtnFormClientes.Text = "Clientes"
        BtnFormClientes.UseVisualStyleBackColor = True
        ' 
        ' BtnFormProductos
        ' 
        BtnFormProductos.Location = New Point(395, 343)
        BtnFormProductos.Name = "BtnFormProductos"
        BtnFormProductos.Size = New Size(143, 76)
        BtnFormProductos.TabIndex = 1
        BtnFormProductos.Text = "Productos"
        BtnFormProductos.UseVisualStyleBackColor = True
        ' 
        ' BtnFormVentas
        ' 
        BtnFormVentas.Location = New Point(689, 343)
        BtnFormVentas.Name = "BtnFormVentas"
        BtnFormVentas.Size = New Size(143, 76)
        BtnFormVentas.TabIndex = 2
        BtnFormVentas.Text = "Ventas"
        BtnFormVentas.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 570)
        Controls.Add(BtnFormVentas)
        Controls.Add(BtnFormProductos)
        Controls.Add(BtnFormClientes)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnFormClientes As Button
    Friend WithEvents BtnFormProductos As Button
    Friend WithEvents BtnFormVentas As Button

End Class
