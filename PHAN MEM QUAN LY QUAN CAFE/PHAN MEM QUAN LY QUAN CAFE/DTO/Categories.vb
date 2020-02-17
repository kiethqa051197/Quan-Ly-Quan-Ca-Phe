Namespace PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
    Public Class Categories
        Private id As Integer
        Private name As String

        Public Sub New(id As Integer, name As String)
            Me.id = id
            Me.name = name
        End Sub

        Public Sub New(row As DataRow)
            Me.id = CInt(row("id"))
            Me.name = row("name").ToString()
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
    End Class
End Namespace
