Namespace PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
    Public Class Accounts
        Private id As Integer
        Private username As String
        Private passWord As String
        Private idStaff As Integer
        Private type As Integer

        Public Sub New(id As Integer, username As String, password As String, idStaff As Integer, type As Integer)
            Me.id = id
            Me.username = username
            Me.passWord = password
            Me.idStaff = idStaff
            Me.type = type
        End Sub

        Public Sub New(row As DataRow)
            Me.id = CInt(row("id"))
            Me.username = row("username").ToString()
            Me.passWord = row("passWord").ToString()
            Me.idStaff = CInt(row("idStaff"))
            Me.type = CInt(row("type"))
        End Sub

        Public Property _id() As Integer
            Get
                Return id
            End Get
            Set(value As Integer)
                id = value
            End Set
        End Property

        Public Property _username() As String
            Get
                Return username
            End Get
            Set(value As String)
                username = value
            End Set
        End Property

        Public Property _passWord() As String
            Get
                Return passWord
            End Get
            Set(value As String)
                passWord = value
            End Set
        End Property

        Public Property _idStaff() As Integer
            Get
                Return idStaff
            End Get
            Set(value As Integer)
                idStaff = value
            End Set
        End Property

        Public Property _type() As Integer
            Get
                Return type
            End Get
            Set(value As Integer)
                type = value
            End Set
        End Property
    End Class
End Namespace
