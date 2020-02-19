Public Class Inputs
    Private id As Integer
    Private dateInput As DateTime

    Public Sub New(id As Integer, dateInput As DateTime)
        Me.id = id
        Me.dateInput = dateInput
    End Sub

    Public Sub New(row As DataRow)
        Me.id = CInt(row("id"))
        Me.dateInput = CType(row("dateInput"), DateTime)
    End Sub

    Public Property _id() As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property _dateInput() As DateTime
        Get
            Return dateInput
        End Get
        Set(value As DateTime)
            dateInput = value
        End Set
    End Property
End Class

