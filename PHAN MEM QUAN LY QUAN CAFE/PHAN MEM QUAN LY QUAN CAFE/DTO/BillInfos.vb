Namespace PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
    Public Class BillInfos

        Private id As Integer
        Private idBill As Integer
        Private idItems As Integer
        Private count As Integer

        Public Sub New(ByVal id As Integer, ByVal idBill As Integer, ByVal idItems As Integer, ByVal count As Integer)
            Me.id = id
            Me.idBill = idBill
            Me.idItems = idItems
            Me.count = count
        End Sub

        Public Sub New(ByVal row As DataRow)
            Me.id = CInt(row("id"))
            Me.idBill = CInt(row("idBill"))
            Me.idItems = CInt(row("idItems"))
            Me.count = CInt(row("count"))
        End Sub

        Public Property _id As Integer
            Get
                Return id
            End Get
            Set(ByVal value As Integer)
                id = value
            End Set
        End Property

        Public Property _idBill As Integer
            Get
                Return idBill
            End Get
            Set(ByVal value As Integer)
                idBill = value
            End Set
        End Property

        Public Property _idItems As Integer
            Get
                Return idItems
            End Get
            Set(ByVal value As Integer)
                idItems = value
            End Set
        End Property

        Public Property _count As Integer
            Get
                Return count
            End Get
            Set(ByVal value As Integer)
                count = value
            End Set
        End Property
    End Class
End Namespace
