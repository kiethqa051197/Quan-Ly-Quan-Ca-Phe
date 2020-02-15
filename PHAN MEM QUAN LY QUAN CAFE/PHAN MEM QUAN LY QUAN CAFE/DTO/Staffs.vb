Namespace PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
    Public Class Staffs

        Private id As Integer
        Private fullname As String
        Private dateofbirth As Date
        Private gender As Boolean
        Private idCard As String
        Private address As String
        Private phone As String
        Private status As Integer

        Public Sub New(id As Integer, fullname As String, dateofbirth As Date, gender As Boolean,
                       idCard As String, address As String, phone As String, status As Integer)
            Me.id = id
            Me.fullname = fullname
            Me.dateofbirth = dateofbirth
            Me.gender = gender
            Me.idCard = idCard
            Me.address = address
            Me.phone = phone
            Me.status = status
        End Sub

        Public Sub New(row As DataRow)
            Me.id = CInt(row("id"))
            Me.fullname = row("fullname").ToString()
            Me.dateofbirth = CType(row("dateofbirth"), Date)
            Me.gender = CBool(row("gender"))
            Me.idCard = row("idCard").ToString()
            Me.address = row("address").ToString()
            Me.phone = row("phone").ToString()
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

        Public Property _fullname() As String
            Get
                Return fullname
            End Get
            Set(value As String)
                fullname = value
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

        Public Property _gender() As Boolean
            Get
                Return gender
            End Get
            Set(value As Boolean)
                gender = value
            End Set
        End Property

        Public Property _idCard() As String
            Get
                Return idCard
            End Get
            Set(value As String)
                idCard = value
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
