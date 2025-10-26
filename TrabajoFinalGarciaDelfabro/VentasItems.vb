Public Class VentasItems
    Private ReadOnly _id As Integer
    Private _Preciounitario, _cantidad, _preciototal As Integer

    Public Property Preciounitario As Integer
        Get
            Return _Preciounitario
        End Get
        Set(value As Integer)
            If (value > 0) Then
                _Preciounitario = value
            Else
                MsgBox("El precio unitario debe ser mayor a 0")
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
                MsgBox("La cantidad debe ser mayor a 0")
            End If
        End Set
    End Property
    Public Property preciototal As Integer
        Get
            Return _preciototal
        End Get
        Set(value As Integer)
            If (value > 0) Then
                _preciototal = value
            Else
                MsgBox("El precio total debe ser mayor a 0")
            End If
        End Set
    End Property
    Public ReadOnly Property id As Integer
        Get
            Return _id
        End Get
    End Property
    Public Sub New(id As Integer, preciounitario As Integer, cantidad As Integer, preciototal As Integer)
        Me._id = id
        Me._Preciounitario = preciounitario
        Me._cantidad = cantidad
        Me._preciototal = preciototal
    End Sub


End Class
