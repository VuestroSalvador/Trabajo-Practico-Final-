Imports MySql.Data.MySqlClient

Public Class FormProductos

    Dim conexion As New MySqlConnection("server=localhost;port=3000;user id=root;password=;database=ventas_tpfinal")
    Dim comando As MySqlCommand
    Private Sub FormProductos_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim producto1 As New producto(0, "a", 1, "a")
        Dim valortabla As DataTable = producto1.cargarproductos()
        DtGrdViewPRODUCTOS.DataSource = valortabla
    End Sub
    Private Sub BtnAgregarProducto_Click(sender As Object, e As EventArgs) Handles BtnAgregarProducto.Click
        Dim id As Integer = 0
        Dim nombre As String = TxtBxNombreProducto.Text
        Dim precio As Integer = Convert.ToInt32(TxtBxPrecioProducto.Text)
        Dim categoria As String = TxtBxCategoriaProducto.Text
        Try
            Dim producto1 As New producto(id, nombre, precio, categoria)
            producto1.agregarproducto(id, nombre, precio, categoria)
            Dim valortabla As DataTable = producto1.cargarproductos()
            DtGrdViewPRODUCTOS.DataSource = valortabla
        Catch ex As Exception
            MsgBox("Error al agregar el producto: " & ex.Message)
        End Try

    End Sub

    Dim idseleccionado As Integer
    Private Sub BtnEliminarProducto_Click(sender As Object, e As EventArgs) Handles BtnEliminarProducto.Click
        If idseleccionado < 0 Then
            MsgBox("no hay nada seleccionado")
        Else
            idseleccionado = Convert.ToInt32(TxtBxIdProducto.Text)
            Dim producto1 As New producto(idseleccionado, "a", 1, "a")
            producto1.eliminar(idseleccionado)
            Dim valortabla As DataTable = producto1.cargarproductos()
            DtGrdViewPRODUCTOS.DataSource = valortabla
        End If

    End Sub

    Private Sub BtnModificarProducto_Click(sender As Object, e As EventArgs) Handles BtnModificarProducto.Click

        Try
            Dim idseleccionado = DtGrdViewPRODUCTOS.CurrentRow.Cells("ID_Producto").Value
            Dim nombrem As String = DtGrdViewPRODUCTOS.CurrentRow.Cells("Nombre").Value
            Dim preciom As Integer = DtGrdViewPRODUCTOS.CurrentRow.Cells("Precio").Value
            Dim categoriam As String = DtGrdViewPRODUCTOS.CurrentRow.Cells("Categoria").Value
            Dim producto1 As New producto(idseleccionado, nombrem, preciom, categoriam)
            producto1.actualizar(idseleccionado, nombrem, preciom, categoriam)
            Dim valortabla As DataTable = producto1.cargarproductos()
            DtGrdViewPRODUCTOS.DataSource = valortabla
        Catch ex As Exception
            MsgBox("Error al agregar el producto: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnBuscarProducto_Click(sender As Object, e As EventArgs) Handles BtnBuscarProducto.Click
        If ComBoxFiltrosProductos.SelectedIndex <> -1 Then
            Dim buscar As String = TxtBxBuscarProducto.Text
            Dim valorcombo As String = ComBoxFiltrosProductos.SelectedItem.ToString()
            Select Case valorcombo
                Case "Nombre"
                    Dim producto1 As New producto(1, buscar, 1, "a")
                    Dim valortabla As DataTable = producto1.buscar(buscar, "a", buscar)
                    DtGrdViewPRODUCTOS.DataSource = valortabla
                Case "Categoria"
                    Dim producto1 As New producto(1, "a", 1, buscar)
                    Dim valortabla As DataTable = producto1.buscar("a", buscar, buscar)
                    DtGrdViewPRODUCTOS.DataSource = valortabla
            End Select

        Else
            MsgBox("Seleccione un filtro para buscar")
        End If


    End Sub

    Private Sub BtnVolverDesdeProductos_Click(sender As Object, e As EventArgs) Handles BtnVolverDesdeProductos.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub BtnVolvverDesdeProducto_Click(sender As Object, e As EventArgs) Handles BtnVolvverDesdeProducto.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class