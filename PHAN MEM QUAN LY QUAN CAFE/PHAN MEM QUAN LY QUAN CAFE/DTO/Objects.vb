Public Class Objects
    Private id As Integer
    Private name As String
    Private idUnit As Integer
    Private idSupplier As Integer
    Private status As Integer

    Public Sub New(id As Integer, name As String, idUnit As Integer, idSupplier As Integer, status As Integer)
        Me.id = id
        Me.name = name
        Me.idUnit = idUnit
        Me.idSupplier = idSupplier
        Me.status = status
    End Sub

    Public Sub New(row As DataRow)
        Me.id = CInt(row("id"))
        Me.name = row("name").ToString()
        Me.idUnit = CInt(row("idUnit"))
        Me.idSupplier = CInt(row("idSupplier"))
        Me.status = CInt(row("status"))
    End Sub

    Public Property _id As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property _name As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property _idUnit As Integer
        Get
            Return idUnit
        End Get
        Set(value As Integer)
            idUnit = value
        End Set
    End Property

  
    Public Property _idSupplier As Integer
        Get
            Return idSupplier
        End Get
        Set(value As Integer)
            idSupplier = value
        End Set
    End Property

    Public Property _status As Integer
        Get
            Return status
        End Get
        Set(value As Integer)
            status = value
        End Set
    End Property
End Class
