Namespace PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
    Public Class Categories
        Private id As Integer
        Private name As String

        Public Sub New(ByVal id As Integer, ByVal name As String)
            Me.id = id
            Me.name = name
        End Sub

        Public Sub New(ByVal row As DataRow)
            Me.id = CInt(row("id"))
            Me.name = row("name").ToString()
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
    End Class
End Namespace
