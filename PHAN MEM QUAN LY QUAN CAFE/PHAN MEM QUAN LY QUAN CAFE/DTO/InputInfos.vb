Public Class InputInfos
    Private id As Integer
    Private idObject As Integer
    Private idInput As Integer
    Private count As Integer
    Private inputPrice As Double
    Private status As String

    Public Sub New(id As Integer, idObject As Integer, idInput As Integer, count As Integer, inputPrice As Double, status As String)
        Me.id = id
        Me.idObject = idObject
        Me.idInput = idInput
        Me.count = count
        Me.inputPrice = inputPrice
        Me.status = status
    End Sub

    Public Sub New(row As DataRow)
        Me.id = CInt(row("id"))
        Me.idObject = CInt(row("idObject"))
        Me.idInput = CInt(row("idInput"))
        Me.count = CInt(row("count"))
        Me.inputPrice = CSng(Convert.ToDouble(row("inputPrice").ToString()))
        Me.status = row("status").ToString()
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

    Public Property _idInput As Integer
        Get
            Return idInput
        End Get
        Set(value As Integer)
            idInput = value
        End Set
    End Property

    Public Property _inputPrice() As Double
        Get
            Return inputPrice
        End Get
        Set(value As Double)
            inputPrice = value
        End Set
    End Property

    Public Property _status As String
        Get
            Return status
        End Get
        Set(value As String)
            status = value
        End Set
    End Property
End Class

