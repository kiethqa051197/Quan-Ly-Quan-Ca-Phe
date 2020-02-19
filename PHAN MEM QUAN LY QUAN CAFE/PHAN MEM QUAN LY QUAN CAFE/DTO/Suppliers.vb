Public Class Suppliers
    Private id As Integer
    Private name As String
    Private address As String
    Private phone As String
    Private email As String
    Private status As Integer

    Public Sub New(id As Integer, name As String, address As String, phone As String, email As String, status As Integer)
        Me.id = id
        Me.name = name
        Me.address = address
        Me.phone = phone
        Me.email = email
        Me.status = status
    End Sub

    Public Sub New(row As DataRow)
        Me.id = CInt(row("id"))
        Me.name = row("name").ToString()
        Me.address = row("address").ToString()
        Me.phone = row("phone").ToString()
        Me.email = row("email").ToString()
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

    Public Property _email() As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
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