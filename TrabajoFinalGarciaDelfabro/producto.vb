Public Class producto
    Private _precio As Integer
    Public nombre, categoria As String
    Private _id As Integer
    Public Property precio As Integer
        Get
            Return _precio
        End Get
        Set(value As Integer)
            If (value > 0) Then
                _precio = value
            End If
        End Set
    End Property

    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            If (value > 0) Then
                _precio = value
            End If
        End Set
    End Property

End Class
