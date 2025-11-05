Imports MySql.Data.MySqlClient
Public Class Form1

    Private Sub BtnFormClientes_Click(sender As Object, e As EventArgs) Handles BtnFormClientes.Click
        Hide
        FormClientes.Show
    End Sub

    Private Sub BtnFormProductos_Click(sender As Object, e As EventArgs) Handles BtnFormProductos.Click
        Me.Hide()
        FormProductos.Show()
    End Sub

    Private Sub BtnFormVentas_Click(sender As Object, e As EventArgs) Handles BtnFormVentas.Click
        Me.Hide()
        FormVentas.Show
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        ManipulacionVentas.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
