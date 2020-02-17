Namespace PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
    Public Class Customers

        Private id As Integer
        Private name As String
        Private phone As String
        Private createDate As Date
        Private status As Integer

        Public Sub New(id As Integer, name As String, phone As String, createDate As Date, status As Integer)
            Me.id = id
            Me.name = name
            Me.phone = phone
            Me.createDate = createDate
            Me.status = status
        End Sub

        Public Sub New(row As DataRow)
            Me.id = CInt(row("id"))
            Me.name = row("name").ToString()
            Me.phone = row("phone").ToString()
            Me.createDate = CType(row("createDate"), Date)
            Me.status = CInt(row("status"))
        End Sub

        Public Property _id() As Integer
            Get
                Return id
            End Get
            Set(value As Integer)
                id = value
            End Set
        End Property

        Public Property _name() As String
            Get
                Return name
            End Get
            Set(value As String)
                name = value
            End Set
        End Property

        Public Property _phone() As String
            Get
                Return phone
            End Get
            Set(value As String)
                phone = value
            End Set
        End Property

        Public Property _createDate() As Date
            Get
                Return createDate
            End Get
            Set(value As Date)
                createDate = value
            End Set
        End Property

        Public Property _status() As Integer
            Get
                Return status
            End Get
            Set(value As Integer)
                status = value
            End Set
        End Property

    End Class
End Namespace
