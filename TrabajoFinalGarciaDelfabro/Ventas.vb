Public Class Ventas
    Private ReadOnly _id As Integer
    Private _fecha As Date
    Private _total As Integer

    Dim fechaMinima As Date = Date.Today.AddYears(-18)
    Public Property fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            If value < fechaMinima Then
                _fecha = value
            Else
                MsgBox("La fecha no puede ser mayor a " & fechaMinima.ToShortDateString())
            End If
        End Set
    End Property

    Public Property total As Integer
        Get
            Return _total
        End Get
        Set(value As Integer)
            If (value > 0) Then
                _total = value
            Else
                MsgBox("El total debe ser mayor a 0")
            End If
        End Set
    End Property
    Public ReadOnly Property id As Integer
        Get
            Return _id
        End Get
    End Property


End Class
