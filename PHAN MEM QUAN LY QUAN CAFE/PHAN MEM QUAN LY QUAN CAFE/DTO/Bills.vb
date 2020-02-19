Public Class Bills
    Private id As Integer
    Private idTable As Integer
    Private idCustomer As Integer
    Private dateCheckIn As DateTime?
    Private dateCheckOut As DateTime?
    Private status As Integer
    Private discount As Integer
    Private idStaff As Integer

    Public Sub New(id As Integer, idTable As Integer, idCustomer As Integer, dateCheckIn As DateTime?, dateCheckOut As DateTime?,
                   status As Integer, idStaff As Integer, Optional discount As Integer = 0)
        Me.id = id
        Me.idTable = idTable
        Me.idCustomer = idCustomer
        Me.dateCheckIn = dateCheckIn
        Me.dateCheckOut = dateCheckOut
        Me.status = status
        Me.discount = discount
        Me.idStaff = idStaff
    End Sub

    Public Sub New(row As DataRow)
        Me.id = CInt(row("id"))
        Me.idTable = CInt(row("idTable"))
        Me.idCustomer = CInt(row("idCustomer"))

        Me.dateCheckIn = CType(row("dateCheckIn"), DateTime?)
        Dim dateCheckOutTemp = row("dateCheckOut")

        If dateCheckOutTemp.ToString() <> "" Then
            Me.dateCheckOut = CType(dateCheckOutTemp, DateTime?)
        End If

        Me.status = CInt(row("status"))
        If row("discount").ToString() <> "" Then Me.discount = CInt(row("discount"))

        Me.idStaff = CInt(row("idStaff"))
    End Sub

    Public Property _id As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property _idTable As Integer
        Get
            Return idTable
        End Get
        Set(value As Integer)
            idTable = value
        End Set
    End Property

    Public Property _idCustomer As Integer
        Get
            Return idCustomer
        End Get
        Set(value As Integer)
            idCustomer = value
        End Set
    End Property

    Public Property _dateCheckIn As DateTime?
        Get
            Return dateCheckIn
        End Get
        Set(value As DateTime?)
            dateCheckIn = value
        End Set
    End Property

    Public Property _dateCheckOut As DateTime?
        Get
            Return dateCheckOut
        End Get
        Set(value As DateTime?)
            dateCheckOut = value
        End Set
    End Property

    Public Property _status As Integer
        Get
            Return status
        End Get
        Set(value As Integer)
            status = value
        End Set
    End Property

    Public Property _discount As Integer
        Get
            Return discount
        End Get
        Set(value As Integer)
            discount = value
        End Set
    End Property

    Public Property _idStaff As Integer
        Get
            Return idStaff
        End Get
        Set(value As Integer)
            idStaff = value
        End Set
    End Property
End Class