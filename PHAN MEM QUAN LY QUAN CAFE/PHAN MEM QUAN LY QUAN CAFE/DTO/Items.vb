﻿
Public Class Items
    Private id As Integer
    Private name As String
    Private price As Integer
    Private idCategory As Integer
    Private status As Integer

    Public Sub New(id As Integer, name As String, price As Integer, idCategory As Integer, status As Integer)
        Me.id = id
        Me.name = name
        Me.price = price
        Me.idCategory = idCategory
        Me.status = status
    End Sub

    Public Sub New(row As DataRow)
        Me.id = CInt(row("id"))
        Me.name = row("name").ToString()
        Me.price = CInt(row("price"))
        Me.idCategory = CInt(row("idCategory"))
        Me.status = CInt(row("status"))
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

    Public Property _price() As Integer
        Get
            Return price
        End Get
        Set(value As Integer)
            price = value
        End Set
    End Property

    Public Property _idCategory() As Integer
        Get
            Return idCategory
        End Get
        Set(value As Integer)
            idCategory = value
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