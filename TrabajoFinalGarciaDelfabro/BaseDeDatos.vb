Imports MySql.Data.MySqlClient
Public Class BaseDeDatos
    Public conexion As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=ventas_tpfinal")
    Public comando As MySqlCommand


    Public Function abrirconexion()
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
    End Function
    Public Function cerrarconexion()
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Function

End Class
