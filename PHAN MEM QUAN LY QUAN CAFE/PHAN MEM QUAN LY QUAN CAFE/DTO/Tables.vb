Public Class Tables
    Private id As Integer
    Private name As String
    Private status As String
    Private statusDel As Integer

    Public Sub New(id As Integer, name As String, status As String, statusDel As Integer)
        Me.id = id
        Me.name = name
        Me.status = status
        Me.statusDel = statusDel
    End Sub

    Public Sub New(row As DataRow)
        Me.id = CInt(row("id"))
        Me.name = row("name").ToString()
        Me.status = row("status").ToString()
        Me.statusDel = CInt(row("statusDel"))
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

    Public Property _status() As String
        Get
            Return status
        End Get
        Set(value As String)
            status = value
        End Set
    End Property

    Public Property _statusDel() As Integer
        Get
            Return statusDel
        End Get
        Set(value As Integer)
            statusDel = value
        End Set
    End Property
End Class
