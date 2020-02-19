Public Class BillInfos

    Private id As Integer
    Private idBill As Integer
    Private idItems As Integer
    Private price As Single
    Private count As Integer

    Public Sub New(id As Integer, idBill As Integer, idItems As Integer, price As Single, count As Integer)
        Me.id = id
        Me.idBill = idBill
        Me.idItems = idItems
        Me.price = price
        Me.count = count
    End Sub

    Public Sub New(row As DataRow)
        Me.id = CInt(row("id"))
        Me.idBill = CInt(row("idBill"))
        Me.idItems = CInt(row("idItems"))
        Me.price = CSng(Convert.ToDouble(row("price").ToString()))
        Me.count = CInt(row("count"))
    End Sub

    Public Property _id As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property _idBill As Integer
        Get
            Return idBill
        End Get
        Set(value As Integer)
            idBill = value
        End Set
    End Property

    Public Property _idItems As Integer
        Get
            Return idItems
        End Get
        Set(value As Integer)
            idItems = value
        End Set
    End Property

    Public Property _price() As Single
        Get
            Return price
        End Get
        Set(value As Single)
            price = value
        End Set
    End Property

    Public Property _count As Integer
        Get
            Return count
        End Get
        Set(value As Integer)
            count = value
        End Set
    End Property
End Class
