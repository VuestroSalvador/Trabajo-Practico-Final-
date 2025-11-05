Public Class ManipulacionVentas
    Private Sub BtnFiltroFechas_Click(sender As Object, e As EventArgs) Handles BtnFiltroFechas.Click

        Try
            Dim fecha1 As Date = TxtBxFecha1.Text
            Dim fecha2 As Date = TxtBxFecha2.Text
            Dim ventas1 As New Ventas(0, 0, Date.Today, 1)
            Dim valortabla As DataTable = ventas1.ventasrealizadas(fecha1, fecha2)
            DgVwVentasSoloVentas.DataSource = valortabla
            MsgBox("Ventas filtradas Con Exito")
        Catch ex As Exception
            Throw New ArgumentException("Error al buscar las ventas: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnAñadirOtraVenta_Click(sender As Object, e As EventArgs) Handles BtnAñadirOtraVenta.Click
        Hide()
        FormVentas.Show()
    End Sub

    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles BtnInicio.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub ManipulacionVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim idventa As Integer
        Dim idcliente As Integer
        Dim fecha As Date
        Dim total As Integer
        Try
            Dim ventas1 As New Ventas(0, 0, Date.Today, 1)
            Dim valortabla As DataTable = ventas1.cargar()
            DgVwVentasSoloVentas.DataSource = valortabla
            MsgBox("Ventas Cargadas Con Exito")
        Catch ex As Exception
            Throw New ArgumentException("Error al cargar Tabla De Ventas: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim ventas1 As New Ventas(0, 0, Date.Today, 1)
            Dim valortabla As DataTable = ventas1.cargar()
            DgVwVentasSoloVentas.DataSource = valortabla
            MsgBox("Ventas Cargadas Con Exito")
        Catch ex As Exception
            MsgBox("Error al cargar Tabla De Ventas: " & ex.Message)
        End Try
    End Sub
End Class