Public Class FormVentas
    Private Sub BtnRegistrarVenta_Click(sender As Object, e As EventArgs) Handles BtnRegistrarVenta.Click
        Dim idventas As Integer
        Dim idcliente As Integer = Convert.ToInt32(TxtBxIdCliente.Text)
        Dim fecha As Date = TxtBxFechaVenta.Text
        Dim total As Integer = Convert.ToInt32(TxtBxToTalVenta.Text)
        Try
            Dim ventas1 As New Ventas(idventas, idcliente, fecha, total)
            ventas1.registrar(idventas, idcliente, fecha, total)
            Dim valortabla As DataTable = ventas1.cargar()
            DtGrdVwVENTAS.DataSource = valortabla
        Catch ex As Exception
            MsgBox("Error al registrar la venta: " & ex.Message)
        End Try

    End Sub

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ventas1 As New Ventas(0, 0, Date.Today, 1)
        Dim valortabla = ventas1.cargar()
        DtGrdVwVENTAS.DataSource = valortabla
    End Sub

    Private Sub BtnBuscarPorfecha_Click(sender As Object, e As EventArgs) Handles BtnBuscarPorfecha.Click
        Dim fecha1 As Date = TxtBxFecha1Buscar.Text
        Dim fecha2 As Date = TxtBxFecha2Buscar.Text
        Try
            Dim ventas1 As New Ventas(0, 0, Date.Today, 1)
            Dim valortabla As DataTable = ventas1.ventasrealizadas(fecha1, fecha2)
            DtGrdVwVENTAS.DataSource = valortabla
        Catch ex As Exception
            MsgBox("Error al buscar las ventas: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnSeleccionarVentaADDITEMS_Click(sender As Object, e As EventArgs) Handles BtnSeleccionarVentaADDITEMS.Click
        Dim idventa = Convert.ToInt32(TxtBxIdVentaAñadirItem.Text)
        GrpBxItems.Enabled = True
        GrpBx1RegistroVenta.Enabled = False
        GrpBx2BuscarVentas.Enabled = False

        Dim item1 As New VentasItems(0, 0, 0, 1, 1, 1)
        item1.cargaritemsdeventaseleccionada(idventa)
        Dim valortabla As DataTable = item1.cargaritems()
        DtGrdVwVENTAS.DataSource = valortabla
    End Sub

    Private Sub BtnAñadirItem_Click(sender As Object, e As EventArgs) Handles BtnAñadirItem.Click
        Dim iditems As Integer
        Dim idventas = Convert.ToInt32(TxtBxIdVentaAñadirItem.Text)
        Dim idproductos = Convert.ToInt32(TxtBxIDPRODUCTO.Text)
        Dim preciounitario = Convert.ToInt32(TxtBxPrecioUnitario.Text)
        Dim cantidad = Convert.ToInt32(TxtBxCantidadProducto.Text)
        Dim total = preciounitario * cantidad
        TxtBxTotalDELPRODUCTOSOLO.Text = total.ToString

        Try
            Dim item1 As New VentasItems(0, idventas, idproductos, preciounitario, cantidad, total)
            item1.añadiritem(iditems, idventas, idproductos, preciounitario, cantidad, total)
            item1.cargaritemsdeventaseleccionada(idventas)
            Dim valortabla As DataTable = item1.cargaritems
            DtGrdVwVENTAS.DataSource = valortabla
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GrpBx2BuscarVentas.Enabled = True
        GrpBx1RegistroVenta.Enabled = True
        GrpBxItems.Enabled = False
    End Sub

    Private Sub BtnVolvverDesdeProducto_Click(sender As Object, e As EventArgs) Handles BtnVolvverDesdeProducto.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub BtnVolverDesdeProductos_Click(sender As Object, e As EventArgs) Handles BtnVolverDesdeProductos.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class