Imports MySql.Data.MySqlClient
Public Class BaseDeDatos
    Public conexion As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=ventas_tpfinal")
    Public comando As MySqlCommand

    Public Function abrirconexion()
        conexion.Open()
    End Function
    Public Function cerrarconexion()
        conexion.Close()
    End Function

End Class
