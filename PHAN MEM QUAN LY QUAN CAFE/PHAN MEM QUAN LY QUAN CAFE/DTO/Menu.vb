Namespace PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
    Public Class Menu
        Private name As String
        Private count As Integer
        Private price As Single
        Private totalPrice As Single

        Public Sub New(name As String, price As Integer, count As Single, Optional totalPrice As Single = 0)
            Me.name = name
            Me.price = price
            Me.count = count
            Me.totalPrice = totalPrice
        End Sub

        Public Sub New(row As DataRow)
            Me.name = row("name").ToString()
            Me.count = CInt(row("count"))
            Me.price = CSng(Convert.ToDouble(row("price").ToString()))
            Me.totalPrice = CSng(Convert.ToDouble(row("totalPrice").ToString()))
        End Sub

        Public Property _name As String
            Get
                Return name
            End Get
            Set(value As String)
                name = value
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

        Public Property _price As Single
            Get
                Return price
            End Get
            Set(value As Single)
                price = value
            End Set
        End Property

        Public Property _totalPrice As Single
            Get
                Return totalPrice
            End Get
            Set(value As Single)
                totalPrice = value
            End Set
        End Property
    End Class
End Namespace

