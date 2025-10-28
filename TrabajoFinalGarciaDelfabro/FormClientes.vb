Imports MySql.Data.MySqlClient
Public Class FormClientes
    Dim conexion As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=ventas_tpfinal")
    Dim comando As MySqlCommand
    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cliente1 As New Clientes(0, "a", "aaaaaaaaaaa", "a")
        Dim valortabla As DataTable = cliente1.cargar()
        DtGrdViewCLIENTES.DataSource = valortabla
    End Sub

    Private Sub BtnAgregarCliente_Click(sender As Object, e As EventArgs) Handles BtnAgregarCliente.Click
        Dim id As Integer = 0
        Dim nombre As String = TxtBxNombreCliente.Text
        Dim telefono As String = TxtBxTelefonoCliente.Text
        Dim correo As String = TxtBxCorreoCliente.Text
        Try
            Dim cliente1 As New Clientes(id, nombre, telefono, correo)
            cliente1.agregar(id, nombre, telefono, correo)
            Dim valortabla As DataTable = cliente1.cargar()
            DtGrdViewCLIENTES.DataSource = valortabla
        Catch ex As Exception
            MsgBox("Error al agregar el cliente: " & ex.Message)
        End Try
    End Sub

    Dim idseleccionado As Integer
    Private Sub BtnEliminarCliente_Click(sender As Object, e As EventArgs) Handles BtnEliminarCliente.Click

        If idseleccionado < 0 Then
            MsgBox("no hay nada seleccionado")
        Else
            idseleccionado = Convert.ToInt32(TxtBxIdCliente.Text)
            Dim cliente1 As New Clientes(idseleccionado, "a", "aaaaaaaaaaa", "a")
            cliente1.eliminar(idseleccionado)
            Dim valortabla As DataTable = cliente1.cargar()
            DtGrdViewCLIENTES.DataSource = valortabla
        End If
    End Sub

    Private Sub BtnModificarCliente_Click(sender As Object, e As EventArgs) Handles BtnModificarCliente.Click
        Try
            Dim idseleccionado = DtGrdViewCLIENTES.CurrentRow.Cells("ID_Clientes").Value
            Dim nombrem As String = DtGrdViewCLIENTES.CurrentRow.Cells("Cliente").Value
            Dim telefonom As String = DtGrdViewCLIENTES.CurrentRow.Cells("Telefono").Value
            Dim correom As String = DtGrdViewCLIENTES.CurrentRow.Cells("Correo").Value
            Dim cliente1 As New Clientes(idseleccionado, nombrem, telefonom, correom)
            cliente1.actualizar(idseleccionado, nombrem, telefonom, correom)
            Dim valortabla As DataTable = cliente1.cargar()
            DtGrdViewCLIENTES.DataSource = valortabla
        Catch ex As Exception
            MsgBox("Error al Modificar el cliente: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click
        If CmBoxFiltroCliente.SelectedIndex <> -1 Then
            Dim buscar As String = TxtBxBuscarCliente.Text
            Dim valorcombo As String = CmBoxFiltroCliente.SelectedItem.ToString()
            Select Case valorcombo
                Case "Nombre"
                    Dim cliente1 As New Clientes(1, buscar, "aaaaaaaaaaa", "a")
                    Dim valortabla As DataTable = cliente1.buscar(buscar, "aaaaaaaaaaa", "a", buscar)
                    DtGrdViewCLIENTES.DataSource = valortabla
                Case "Telefono"
                    Dim cliente1 As New Clientes(1, "a", buscar, "a")
                    Dim valortabla As DataTable = cliente1.buscar("a", buscar, "a", buscar)
                    DtGrdViewCLIENTES.DataSource = valortabla
                Case "Correo"
                    Dim cliente1 As New Clientes(1, "a", "aaaaaaaaaaa", buscar)
                    Dim valortabla As DataTable = cliente1.buscar("a", "aaaaaaaaaaa", buscar, buscar)
                    DtGrdViewCLIENTES.DataSource = valortabla
            End Select

        Else
            MsgBox("Seleccione un filtro para buscar")
        End If
    End Sub

    Private Sub BtnVolverDesdeClientes_Click(sender As Object, e As EventArgs) Handles BtnVolverDesdeClientes.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub BtnVolvverDesdeClientes_Click(sender As Object, e As EventArgs) Handles BtnVolvverDesdeClientes.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class