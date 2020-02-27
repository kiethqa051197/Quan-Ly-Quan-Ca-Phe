Public Class Units
    Private id As Integer
    Private name As String
    Private status As Boolean

    Public Sub New(id As Integer, name As String, status As Boolean)
        Me.id = id
        Me.name = name
        Me.status = status
    End Sub

    Public Sub New(row As DataRow)
        Me.id = CInt(row("id"))
        Me.name = row("name").ToString()
        Me.status = CType(row("status"), Boolean)
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

    Public Property _status() As Boolean
        Get
            Return status
        End Get
        Set(value As Boolean)
            status = value
        End Set
    End Property
End Class
