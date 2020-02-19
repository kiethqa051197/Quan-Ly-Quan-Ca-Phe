Public Class Outputs
    Private id As Integer
    Private dateOutput As DateTime

    Public Sub New(id As Integer, dateOutput As DateTime)
        Me.id = id
        Me.dateOutput = dateOutput
    End Sub

    Public Sub New(row As DataRow)
        Me.id = CInt(row("id"))
        Me.dateOutput = CType(row("dateOutput"), DateTime)
    End Sub

    Public Property _id() As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property _dateOutput() As DateTime
        Get
            Return dateOutput
        End Get
        Set(value As DateTime)
            dateOutput = value
        End Set
    End Property
End Class

