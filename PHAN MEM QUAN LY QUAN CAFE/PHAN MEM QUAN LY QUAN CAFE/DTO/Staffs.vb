Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
    Public Class Staffs

        Private id As Integer
        Private fullname As String
        Private dateofbirth As Date
        Private gender As Boolean
        Private idCard As Integer
        Private address As String
        Private phone As String
        Private idPosition As Integer

        Public Sub New(ByVal id As Integer, ByVal fullname As String, ByVal dateofbirth As Date, ByVal gender As Boolean,
                       ByVal idCard As Integer, ByVal address As String, ByVal phone As String, ByVal idPosition As Integer)
            Me.id = id
            Me.fullname = fullname
            Me.dateofbirth = dateofbirth
            Me.gender = gender
            Me.idCard = idCard
            Me.address = address
            Me.phone = phone
            Me.idPosition = idPosition
        End Sub

        Public Sub New(ByVal row As DataRow)
            Me.id = CInt(row("id"))
            Me.fullname = row("fullname").ToString()
            Me.dateofbirth = CType(row("dateofbirth"), Date)
            Me.gender = CBool(row("gender"))
            Me.idCard = CInt(row("idCard"))
            Me.address = row("address").ToString()
            Me.phone = row("phone").ToString()
            Me.idPosition = CInt(row("idPosition"))
        End Sub

        Public Property _id() As Integer
            Get
                Return id
            End Get
            Set(ByVal value As Integer)
                id = value
            End Set
        End Property

        Public Property _fullname() As String
            Get
                Return fullname
            End Get
            Set(ByVal value As String)
                fullname = value
            End Set
        End Property

        Public Property _dateofbirth() As Date
            Get
                Return dateofbirth
            End Get
            Set(ByVal value As Date)
                dateofbirth = value
            End Set
        End Property

        Public Property _gender() As Boolean
            Get
                Return gender
            End Get
            Set(ByVal value As Boolean)
                gender = value
            End Set
        End Property

        Public Property _idCard() As Integer
            Get
                Return idCard
            End Get
            Set(ByVal value As Integer)
                idCard = value
            End Set
        End Property

        Public Property _address() As String
            Get
                Return address
            End Get
            Set(ByVal value As String)
                address = value
            End Set
        End Property

        Public Property _phone() As String
            Get
                Return phone
            End Get
            Set(ByVal value As String)
                phone = value
            End Set
        End Property

        Public Property _idPosition() As Integer
            Get
                Return idPosition
            End Get
            Set(ByVal value As Integer)
                idPosition = value
            End Set
        End Property
    End Class
End Namespace
