Namespace PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
    Public Class Customers

        Private id As Integer
        Private gender As Boolean
        Private name As String
        Private idCard As Integer
        Private dateofbirth As Date
        Private address As String
        Private phone As String
        Private createDate As Date

        Public Sub New(id As Integer, gender As Boolean, name As String, idCard As Integer,
                       dateofbirth As Date, address As String, phone As String, createDate As Date)
            Me.id = id
            Me.gender = gender
            Me.name = name
            Me.idCard = idCard
            Me.dateofbirth = dateofbirth
            Me.address = address
            Me.phone = phone
            Me.createDate = createDate
        End Sub

        Public Sub New(row As DataRow)
            Me.id = CInt(row("id"))
            Me.gender = CBool(row("gender"))
            Me.name = row("name").ToString()
            Me.idCard = CInt(row("idCard"))
            Me.dateofbirth = CType(row("idCard"), Date)
            Me.address = row("address").ToString()
            Me.phone = row("phone").ToString()
            Me.createDate = CType(row("createDate"), Date)
        End Sub

        Public Property _id() As Integer
            Get
                Return id
            End Get
            Set(value As Integer)
                id = value
            End Set
        End Property

        Public Property _gender() As Boolean
            Get
                Return gender
            End Get
            Set(value As Boolean)
                gender = value
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

        Public Property _idCard() As Integer
            Get
                Return idCard
            End Get
            Set(value As Integer)
                idCard = value
            End Set
        End Property

        Public Property _dateofbirth() As Date
            Get
                Return dateofbirth
            End Get
            Set(value As Date)
                dateofbirth = value
            End Set
        End Property

        Public Property _address() As String
            Get
                Return address
            End Get
            Set(value As String)
                address = value
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
    End Class
End Namespace
