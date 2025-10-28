Imports MySql.Data.MySqlClient
Public Class producto
    Inherits BaseDeDatos

    Private _precio As Integer
    Private _nombre, _categoria As String
    Private ReadOnly _id As Integer
    Public Property precio As Integer
        Get
            Return _precio
        End Get
        Set(value As Integer)
            If value <> "" And value <> "  " Then
                If (value > 0) Then
                    _precio = value
                Else
                    Throw New ArgumentException("El precio debe ser un número mayor a 0.")
                End If
            Else
                Throw New ArgumentException("El precio no puede estar vacio")
            End If

        End Set
    End Property
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
    Public Property categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            If value <> "" And value <> "  " Then
                _categoria = value
            Else
                Throw New ArgumentException("la Categoria No puede estar Vacia.")
            End If
        End Set
    End Property
    Public ReadOnly Property id As Integer
        Get
            Return _id
        End Get
    End Property

    Public Sub New(id As Integer, nombre As String, precio As Integer, categoria As String)
        id = id
        Me.nombre = nombre
        Me.precio = precio
        Me.categoria = categoria
    End Sub

    Public Function cargarproductos()
        Try
            abrirconexion()
            Dim consulta As String = "SELECT * FROM productos"
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
    Public Function agregarproducto(id As Integer, nombre As String, precio As Integer, categoria As String)
        Try
            abrirconexion()
            Dim consulta As String = "INSERT INTO productos (ID_Producto,Nombre,Precio,Categoria) VALUES (@id,@nombre,@precio,@categoria)"
            comando = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@id", id)
            comando.Parameters.AddWithValue("@nombre", nombre)
            comando.Parameters.AddWithValue("@precio", precio)
            comando.Parameters.AddWithValue("@categoria", categoria)
            comando.ExecuteNonQuery()
            MessageBox.Show("Producto Agregado")
            cargarproductos()
        Catch ex As Exception
            MessageBox.Show("ERROR:" & ex.Message)
        Finally
            cerrarconexion()
        End Try
    End Function

    Public Function eliminar(id As Integer)
        Try
            abrirconexion()
            Dim consulta As String = "DELETE FROM productos WHERE ID_Producto=@ID_Producto"
            comando = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@ID_Producto", id)
            comando.ExecuteNonQuery()
            MessageBox.Show("Producto eliminado")

        Catch ex As Exception
            MessageBox.Show("ERROR:" & ex.Message)
        Finally
            cerrarconexion()
        End Try
    End Function

    Public Function actualizar(id, nombre, precio, categoria)
        Try
            abrirconexion()
            Dim consulta As String = "UPDATE productos SET Nombre=@nombre, Precio=@precio, Categoria=@categoria WHERE ID_Producto=@idseleccion"
            comando = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@idseleccion", id)
            comando.Parameters.AddWithValue("@nombre", nombre)
            comando.Parameters.AddWithValue("@precio", precio)
            comando.Parameters.AddWithValue("@categoria", categoria)
            comando.ExecuteNonQuery()
            MsgBox("Producto Modificado")

        Catch ex As Exception
            MsgBox("ERROR:" & ex.Message)
        Finally
            cerrarconexion()
        End Try
    End Function

    Public Function buscar(nombre, categoria, variablebuscar)
        If nombre = variablebuscar Then
            Try
                abrirconexion()
                Dim consulta As String = "SELECT * FROM productos WHERE Nombre LIKE @nombreBD"
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
        If categoria = variablebuscar Then
            Try
                abrirconexion()
                Dim consulta As String = "SELECT * FROM productos WHERE Categoria LIKE @categoriaBD"
                comando = New MySqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@categoriaBD", "%" & categoria & "%")
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

End Class
