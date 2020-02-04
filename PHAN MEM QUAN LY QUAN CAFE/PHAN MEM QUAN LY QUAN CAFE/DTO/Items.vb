Namespace PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
    Public Class Items
        Private id As Integer
        Private name As String
        Private price As Single
        Private idCategory As Integer

        Public Sub New(ByVal id As Integer, ByVal name As String, ByVal price As Single, ByVal idCategory As Integer)
            Me.id = id
            Me.name = name
            Me.price = price
            Me.idCategory = idCategory
        End Sub

        Public Sub New(ByVal row As DataRow)
            Me.id = CInt(row("id"))
            Me.name = row("name").ToString()
            Me.price = CSng(Convert.ToDouble(row("price").ToString()))
            Me.idCategory = CInt(row("idCategory"))
        End Sub

        Public Property _id() As Integer
            Get
                Return id
            End Get
            Set(ByVal value As Integer)
                id = value
            End Set
        End Property

        Public Property _name() As String
            Get
                Return name
            End Get
            Set(ByVal value As String)
                name = value
            End Set
        End Property

        Public Property _price() As Single
            Get
                Return price
            End Get
            Set(ByVal value As Single)
                price = value
            End Set
        End Property

        Public Property _idCategory() As Integer
            Get
                Return idCategory
            End Get
            Set(ByVal value As Integer)
                idCategory = value
            End Set
        End Property
    End Class
End Namespace
