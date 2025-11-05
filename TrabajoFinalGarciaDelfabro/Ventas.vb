Imports System.Runtime.InteropServices.JavaScript.JSType
Imports MySql.Data.MySqlClient

Public Class Ventas
    Inherits BaseDeDatos
    Private ReadOnly _id, _idcliente As Integer
    Private _fecha As Date
    Private _total As Integer
    Dim fechaMinima As Date = Date.Today.AddYears(-1)
    Public Property fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            If value > fechaMinima And value <= Date.Today Then
                _fecha = value
            Else
                Throw New ArgumentException("La fecha debe estar dentro del último año y no puede ser una fecha futura.")
            End If
        End Set
    End Property

    Public Property total As Integer
        Get
            Return _total
        End Get
        Set(value As Integer)
            If (value >= 0) Then
                _total = value
            Else
                Throw New ArgumentException("El total no puede ser negativo.")
            End If
        End Set
    End Property
    Public ReadOnly Property id As Integer
        Get
            Return _id
        End Get
    End Property

    Public ReadOnly Property idcliente As Integer
        Get
            Return _idcliente
        End Get
    End Property

    Public Sub New(id As Integer, idcliente As Integer, fecha As Date, total As Integer)
        Me.fecha = fecha
        Me.total = total
    End Sub


    Public Function cargar()
        Try
            abrirconexion()
            Dim consulta As String = "SELECT * FROM ventas"
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
    Public Function registrar(id, idcliente, fecha, total)
        Try
            abrirconexion()
            Dim consulta As String = "INSERT INTO ventas (ID_Ventas,ID_Cliente,Fecha,Total) VALUES (@id,@idcliente,@fecha,@total)"
            comando = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@id", id)
            comando.Parameters.AddWithValue("@idcliente", idcliente)
            comando.Parameters.AddWithValue("@fecha", fecha)
            comando.Parameters.AddWithValue("@total", total)
            comando.ExecuteNonQuery()
            MessageBox.Show("Venta Registrada")
            cargar()
        Catch ex As Exception
            MessageBox.Show("ERROR:" & ex.Message)
        Finally
            cerrarconexion()
        End Try
    End Function

    Public Function ventasrealizadas(fecha1, fecha2)
        Try
            abrirconexion()
            Dim consulta As String = "SELECT * FROM ventas WHERE Fecha BETWEEN @fecha1 AND @fecha2"
            comando = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@fecha1", fecha1)
            comando.Parameters.AddWithValue("@fecha2", fecha2)
            Dim adaptador As New MySqlDataAdapter(comando)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)
            Return tabla
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        Finally
            cerrarconexion()
        End Try
    End Function

    Public Function IDactualdeventa()
        Try
            abrirconexion()
            Dim consulta As String = "SELECT MAX(ID_Ventas) AS ID_Ventas FROM ventas"
            comando = New MySqlCommand(consulta, conexion)
            Dim resultado As Object = comando.ExecuteScalar()
            Dim idactual As Integer
            If IsDBNull(resultado) Then
                idactual = 1
            Else
                idactual = Convert.ToInt32(resultado) + 1
            End If
            Return idactual
        Catch ex As Exception
            MsgBox("Error al obtener el ID de la venta actual: " & ex.Message)
        Finally
            cerrarconexion()
        End Try
    End Function

    Public Function finalizarventa(idventaactual, total)
        Try
            abrirconexion()
            Dim consulta As String = "UPDATE ventas SET Total=@total WHERE ID_Ventas=@idventas"
            comando = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@idventas", idventaactual)
            comando.Parameters.AddWithValue("@total", total)
            comando.ExecuteNonQuery()
            MsgBox("Venta Finalizada")
        Catch ex As Exception
            Throw New ArgumentException("Error al finalizar la venta: " & ex.Message)
        Finally
            cerrarconexion()
        End Try
    End Function


End Class
