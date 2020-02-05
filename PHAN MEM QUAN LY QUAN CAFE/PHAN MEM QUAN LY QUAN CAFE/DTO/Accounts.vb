Namespace PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
    Public Class Accounts
        Private id As Integer
        Private username As String
        Private passWord As String
        Private idStaff As Integer
        Private type As Integer

        Public Sub New(ByVal id As Integer, ByVal username As String, ByVal password As String, ByVal idStaff As Integer, ByVal type As Integer)
            Me.id = id
            Me.username = username
            Me.passWord = password
            Me.idStaff = idStaff
            Me.type = type
        End Sub

        Public Sub New(ByVal row As DataRow)
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
            Set(ByVal value As Integer)
                id = value
            End Set
        End Property

        Public Property _username() As String
            Get
                Return username
            End Get
            Set(ByVal value As String)
                username = value
            End Set
        End Property

        Public Property _passWord() As String
            Get
                Return passWord
            End Get
            Set(ByVal value As String)
                passWord = value
            End Set
        End Property

        Public Property _idStaff() As Integer
            Get
                Return idStaff
            End Get
            Set(ByVal value As Integer)
                idStaff = value
            End Set
        End Property

        Public Property _type() As Integer
            Get
                Return type
            End Get
            Set(ByVal value As Integer)
                type = value
            End Set
        End Property
    End Class
End Namespace
