Imports MySql.Data.MySqlClient

Public Class Clientes
    Inherits BaseDeDatos

    Private _nombre, _telefono, _correo As String
    Private ReadOnly _id As Integer

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value <> "" And value <> "  " Then
                _nombre = value
            Else
                Throw New ArgumentException("El nombre no puede estar vacio")
            End If
        End Set
    End Property
    Public Property telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            If value.Length = 11 Then
                _telefono = value
            Else
                Throw New ArgumentException("El telefono debe tener 11 digitos")
            End If
        End Set
    End Property
    Public Property correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            If value <> "" And value <> "  " Then
                _correo = value
            Else
                Throw New ArgumentException("El Correo No Puede estar vacio")
            End If
        End Set
    End Property

    Public ReadOnly Property id As String
        Get
            Return _id
        End Get
    End Property

    Public Sub New(id As Integer, nombre As String, telefono As String, correo As String)
        id = id
        Me.nombre = nombre
        Me.telefono = telefono
        Me.correo = correo
    End Sub

    Public Sub New()

    End Sub
    Public Function cargar()
        Try
            abrirconexion()
            Dim consulta As String = "SELECT * FROM clientes"
            Dim adaptador As New MySqlDataAdapter(consulta, conexion)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)
            Return tabla
        Catch ex As Exception
            MessageBox.Show("ERROR:" & ex.Message)
        Finally
            cerrarconexion()
        End Try
    End Function

    Public Function agregar(id As Integer, nombre As String, telefono As String, correo As String)
        Try
            abrirconexion()
            Dim consulta As String = "INSERT INTO clientes (ID_Clientes,Cliente,Telefono,Correo) VALUES (@id,@nombre,@telefono,@correo)"
            comando = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@id", id)
            comando.Parameters.AddWithValue("@nombre", nombre)
            comando.Parameters.AddWithValue("@telefono", telefono)
            comando.Parameters.AddWithValue("@correo", correo)
            comando.ExecuteNonQuery()
            MessageBox.Show("Cliente Agregado")
            cargar()
        Catch ex As Exception
            MessageBox.Show("ERROR:" & ex.Message)
        Finally
            cerrarconexion()
        End Try
    End Function

    Public Function eliminar(id As Integer)
        Try
            abrirconexion()
            Dim consulta As String = "DELETE FROM clientes WHERE ID_Clientes=@ID_Clientes"
            comando = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@ID_Clientes", id)
            comando.ExecuteNonQuery()
            MessageBox.Show("Cliente eliminado")

        Catch ex As Exception
            MessageBox.Show("ERROR:" & ex.Message)
        Finally
            cerrarconexion()
        End Try
    End Function

    Public Function actualizar(id, nombre, telefono, correo)
        Try
            abrirconexion()
            Dim consulta As String = "UPDATE clientes SET Cliente=@nombre, Telefono=@telefono, Correo=@correo WHERE ID_Clientes=@idseleccion"
            comando = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@idseleccion", id)
            comando.Parameters.AddWithValue("@nombre", nombre)
            comando.Parameters.AddWithValue("@telefono", telefono)
            comando.Parameters.AddWithValue("@correo", correo)
            comando.ExecuteNonQuery()
            MsgBox("Cliente Modificado")

        Catch ex As Exception
            MsgBox("ERROR:" & ex.Message)
        Finally
            cerrarconexion()
        End Try
    End Function

    Public Function buscar(nombre, telefono, correo, variablebuscar)
        If nombre = variablebuscar Then
            Try
                abrirconexion()
                Dim consulta As String = "SELECT * FROM clientes WHERE Cliente LIKE @nombreBD"
                comando = New MySqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@nombreBD", "%" & nombre & "%")
                Dim adaptador As New MySqlDataAdapter(comando)
                Dim tabla As New DataTable()
                adaptador.Fill(tabla)
                Return tabla
            Catch ex As Exception
                MsgBox("ERROR:" & ex.Message)
            Finally
                cerrarconexion()
            End Try
        End If
        If correo = variablebuscar Then
            Try
                abrirconexion()
                Dim consulta As String = "SELECT * FROM clientes WHERE Correo LIKE @correoBD"
                comando = New MySqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@correoBD", "%" & correo & "%")
                Dim adaptador As New MySqlDataAdapter(comando)
                Dim tabla As New DataTable()
                adaptador.Fill(tabla)
                Return tabla
            Catch ex As Exception
                MsgBox("ERROR:" & ex.Message)
            Finally
                cerrarconexion()
            End Try
        End If
        If telefono = variablebuscar Then
            Try
                abrirconexion()
                Dim consulta As String = "SELECT * FROM clientes WHERE Telefono LIKE @telefonoBD"
                comando = New MySqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@telefonoBD", "%" & telefono & "%")
                Dim adaptador As New MySqlDataAdapter(comando)
                Dim tabla As New DataTable()
                adaptador.Fill(tabla)
                Return tabla
            Catch ex As Exception
                MsgBox("ERROR:" & ex.Message)
            Finally
                cerrarconexion()
            End Try
        End If

    End Function

    Public Function seleccionarnombre()
        Try
            abrirconexion()
            Dim consulta As String = "SELECT ID_Clientes, Cliente FROM clientes"
            comando = New MySqlCommand(consulta, conexion)
            Dim adaptador As New MySqlDataAdapter(comando)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)
            Return tabla
        Catch ex As Exception
            MsgBox("Error al obtener Clientes:" & ex.Message)
        Finally
            cerrarconexion()
        End Try
    End Function
End Class
