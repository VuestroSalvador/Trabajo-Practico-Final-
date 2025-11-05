Public Class FormVentas

    Private Sub BtnIniciarVenta_Click(sender As Object, e As EventArgs) Handles BtnIniciarVenta.Click
        Dim idventas As Integer
        Dim idcliente = Convert.ToInt32(TxtBxIdClienteVenta.Text)
        Dim fecha As Date = TxtBxFechaVenta.Text
        Dim total = 0
        Try
            Dim ventas1 As New Ventas(idventas, idcliente, fecha, total)

            TxtBxAUTOtotalVenta.Text = total
            BtnFinalizarVenta.Enabled = False
            Dim nventa As Integer = ventas1.IDactualdeventa()
            TxtBxNVenta.Text = nventa.ToString()
            ventas1.registrar(idventas, idcliente, fecha, total)
            GrpBxProductos.Enabled = True
            GrpBxIniciarVenta.Enabled = False
        Catch ex As Exception
            Throw New ArgumentException("Error al registrar la venta: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnAñadirProducto_Click(sender As Object, e As EventArgs) Handles BtnAñadirProducto.Click
        Dim iditems As Integer
        Dim idventas As Integer = Convert.ToInt32(TxtBxNVenta.Text)
        Dim idproductos = Convert.ToInt32(TxtBxIdProductoVENTA.Text)
        Dim cantidad = Convert.ToInt32(TxtBxCantidadVENTA.Text)
        Dim preciounitario As Integer = 0
        Dim total = 0
        Try
            Dim item1 As New VentasItems(iditems, idventas, idproductos, 1, cantidad, total)
            preciounitario = item1.preciounitarioactual(idproductos)
            total = preciounitario * cantidad
            item1.añadiritem(iditems, idventas, idproductos, preciounitario, cantidad, total)
            Dim valortabla As DataTable = item1.cargaritemsdeventaseleccionada(idventas)
            DtGrdVwVentasItems.DataSource = valortabla
            Dim totalventa As Integer = Convert.ToInt32(TxtBxAUTOtotalVenta.Text) + total
            TxtBxAUTOtotalVenta.Text = totalventa.ToString()
            GrpBxFinalizarVenta.Enabled = True
            BtnFinalizarVenta.Enabled = True
        Catch ex As Exception
            MsgBox("Error al añadir producto a la venta: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnFinalizarVenta_Click(sender As Object, e As EventArgs) Handles BtnFinalizarVenta.Click
        Dim idventa As Integer = Convert.ToInt32(TxtBxNVenta.Text)
        Dim idcliente = Convert.ToInt32(TxtBxIdClienteVenta.Text)
        Dim fecha As Date = TxtBxFechaVenta.Text
        Dim total As Integer = Convert.ToInt32(TxtBxAUTOtotalVenta.Text)

        Try
            Dim ventaFinal As New Ventas(idventa, idcliente, fecha, total)

            ventaFinal.finalizarventa(idventa, total)
            MessageBox.Show("Venta finalizada con éxito.")
            GrpBxIniciarVenta.Enabled = True
            GrpBxProductos.Enabled = False
            GrpBxFinalizarVenta.Enabled = False
            Me.Hide()
            ManipulacionVentas.Show()
        Catch ex As Exception
            Throw New ArgumentException("Error al finalizar la venta: " & ex.Message)
        Finally
            TxtBxAUTOtotalVenta.Clear()
            TxtBxFechaVenta.Clear()
            TxtBxCantidadVENTA.Clear()
            TxtBxIdClienteVenta.Clear()
            TxtBxIdProductoVENTA.Clear()
            TxtBxNVenta.Clear()
            DtGrdVwVentasItems.DataSource = Nothing
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub


End Class