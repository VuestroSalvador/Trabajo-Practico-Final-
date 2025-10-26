Public Class Clientes

    Private _nombre, _telefono, _correo As String
    Private ReadOnly _id As Integer

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value <> "" Or value <> "  " Then
                _nombre = value
            Else
                MsgBox("el nombre no puede estar vacio")
            End If
        End Set
    End Property
    Public Property telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            If value <> "" Or value <> "  " Then
                _telefono = value
            Else
                MsgBox("el telefono no puede estar vacio")
            End If
        End Set
    End Property
    Public Property correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            If value <> "" Or value <> "  " Then
                _correo = value
            Else
                MsgBox("el correo no puede estar vacio")
            End If
        End Set
    End Property

    Public ReadOnly Property id As String
        Get
            Return _id
        End Get
    End Property

    Public Sub New(id As Integer, nombre As String, telefono As String, correo As String)
        Me._id = id
        Me._nombre = nombre
        Me._telefono = telefono
        Me._correo = correo
    End Sub

End Class
