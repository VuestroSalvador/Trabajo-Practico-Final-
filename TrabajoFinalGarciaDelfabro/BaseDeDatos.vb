Imports MySql.Data.MySqlClient
Public Class BaseDeDatos
    Public conexion As New MySqlConnection("server=localhost;port=3000;user id=root;password=;database=ventas_tpfinal")
    Public comando As MySqlCommand

<<<<<<< HEAD
    Public Function abrirconexion()
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
    End Function
    Public Function cerrarconexion()
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
=======
    Public Overridable Function abrirconexion() As MySqlConnection
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        Return conexion

    End Function
    Public Overridable Function cerrarconexion()

        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If

>>>>>>> 8138afcb0b99cb990252be7051bacacfb5261d14
    End Function

End Class
