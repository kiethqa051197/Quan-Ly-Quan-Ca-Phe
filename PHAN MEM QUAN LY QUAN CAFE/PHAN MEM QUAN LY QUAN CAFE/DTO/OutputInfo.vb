Public Class OutputInfos
    Private id As Integer
    Private idObject As Integer
    Private idOutput As Integer
    Private count As Integer

    Public Sub New(id As Integer, idObject As Integer, idOutput As Integer, count As Integer)
        Me.id = id
        Me.idObject = idObject
        Me.idOutput = idOutput
        Me.count = count
    End Sub

    Public Sub New(row As DataRow)
        Me.id = CInt(row("id"))
        Me.idObject = CInt(row("idObject"))
        Me.idOutput = CInt(row("idOutput"))
        Me.count = CInt(row("count"))
    End Sub

    Public Property _id As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property _idObject As Integer
        Get
            Return idObject
        End Get
        Set(value As Integer)
            idObject = value
        End Set
    End Property

    Public Property _idOutput As Integer
        Get
            Return idOutput
        End Get
        Set(value As Integer)
            idOutput = value
        End Set
    End Property
End Class