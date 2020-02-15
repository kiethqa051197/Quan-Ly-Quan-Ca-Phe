Namespace PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
    Public Class Categories
        Private id As Integer
        Private name As String
        Private status As Integer

        Public Sub New(id As Integer, name As String, status As Integer)
            Me.id = id
            Me.name = name
            Me.status = status
        End Sub

        Public Sub New(row As DataRow)
            Me.id = CInt(row("id"))
            Me.name = row("name").ToString()
            Me.status = row("status").ToString()
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
