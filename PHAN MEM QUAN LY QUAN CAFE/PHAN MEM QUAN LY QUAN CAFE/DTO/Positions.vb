Namespace PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
    Public Class Posotions

        Private id As Integer
        Private name As String
        Private salary As Integer

        Public Sub New(ByVal id As Integer, ByVal name As String, ByVal salary As Integer)
            Me.id = id
            Me.name = name
            Me.salary = salary
        End Sub

        Public Sub New(ByVal row As DataRow)
            Me.id = CInt(row("id"))
            Me.name = row("name").ToString()
            Me.salary = CInt(row("salary"))
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

        Public Property _salary() As Integer
            Get
                Return salary
            End Get
            Set(ByVal value As Integer)
                salary = value
            End Set
        End Property
    End Class
End Namespace

