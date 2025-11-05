Imports MySql.Data.MySqlClient
Public Class VentasItems
    Inherits BaseDeDatos
    Private ReadOnly _iditems, _idventas, _idproductos As Integer
    Private _Preciounitario, _cantidad, _preciototal As Integer

    Public Property Preciounitario As Integer
        Get
            Return _Preciounitario
        End Get
        Set(value As Integer)
            If (value > 0) Then
                _Preciounitario = value
            Else
                Throw New ArgumentException("El precio unitario no puede ser negativo.")
            End If
        End Set
    End Property
    Public Property cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            If (value > 0) Then
                _cantidad = value
            Else
                Throw New ArgumentException("La cantidad no puede ser negativa")
            End If
        End Set
    End Property
    Public Property preciototal As Integer
        Get
            Return _preciototal
        End Get
        Set(value As Integer)
            If (value >= 0) Then
                _preciototal = value
            Else
                Throw New ArgumentException("El precio total debe ser igual al precio unitario por la cantidad de Unidades")
            End If
        End Set
    End Property
    Public ReadOnly Property iditems As Integer
        Get
            Return _iditems
        End Get
    End Property

    Public ReadOnly Property idventas As Integer
        Get
            Return _idventas
        End Get
    End Property

    Public ReadOnly Property idproductos As Integer
        Get
            Return _idproductos
        End Get
    End Property
    Public Sub New(iditems As Integer, idventas As Integer, idproductos As Integer, Preciounitario As Integer, cantidad As Integer, preciototal As Integer)
        Me.Preciounitario = Preciounitario
        Me.cantidad = cantidad
        Me.preciototal = preciototal
    End Sub

    Public Function cargaritems()
        Try
            abrirconexion()
            Dim consulta As String = "SELECT * FROM ventasitems "
            Dim adaptador As New MySqlDataAdapter(consulta, conexion)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)
            Return tabla
        Catch ex As Exception
            Throw New Exception("Error al cargar los items de venta: " & ex.Message)
        Finally
            cerrarconexion()
        End Try
    End Function

    Public Function cargaritemsdeventaseleccionada(id)
        Try
            abrirconexion()
            Dim consulta As String = "SELECT * FROM ventasitems WHERE ID_Ventas=@idventas"
            Dim adaptador As New MySqlDataAdapter(consulta, conexion)
            adaptador.SelectCommand.Parameters.AddWithValue("@idventas", id)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)
            Return tabla
            MsgBox("Items de venta cargados con éxito.")
        Catch ex As Exception
            Throw New ArgumentException("Error al cargar los items de venta: " & ex.Message)
        Finally
            cerrarconexion()
        End Try
    End Function
    Public Function añadiritem(iditems, idventas, idproducto, preciounitario, cantidad, preciototal)
        Try
            abrirconexion()
            Dim consulta As String = "INSERT INTO ventasitems (ID_Vitems,ID_Ventas,ID_Producto,PrecioUnitario,Cantidad,PrecioTotal) VALUES (@idvitems,@idventas, @idproductos, @preciounitario, @cantidad, @preciototal)"
            Dim comando As New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@idvitems", iditems)
            comando.Parameters.AddWithValue("@idventas", idventas)
            comando.Parameters.AddWithValue("@idproductos", idproducto)
            comando.Parameters.AddWithValue("@preciounitario", preciounitario)
            comando.Parameters.AddWithValue("@cantidad", cantidad)
            comando.Parameters.AddWithValue("@preciototal", preciototal)
            comando.ExecuteNonQuery()
            MsgBox("Item de venta agregado con éxito.")
            cargaritems()
        Catch ex As Exception
            MsgBox("Error al agregar el item de venta: " & ex.Message)
        Finally
            cerrarconexion()

        End Try
    End Function

    Public Function preciounitarioactual(idproducto)
        Try
            abrirconexion()
            Dim consulta As String = "SELECT Precio FROM productos WHERE ID_Producto=@idproducto"
            comando = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@idproducto", idproducto)
            Dim resultado As Object = comando.ExecuteScalar()
            Dim preciounitario = Convert.ToInt32(resultado)
            Return preciounitario
        Catch ex As Exception
            MsgBox("error al obtener el precio unitario: " & ex.Message)
        Finally
            cerrarconexion()
        End Try
    End Function

End Class
