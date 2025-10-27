Public Class Clientes

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

End Class
