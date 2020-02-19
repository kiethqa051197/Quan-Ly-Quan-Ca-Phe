﻿Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO

Public Class InputDAO
    Public Shared instance As InputDAO
    Private _item As DataRow

    Sub New(item As DataRow)
        ' TODO: Complete member initialization 
        _item = item
    End Sub

    Public Shared Property _Instance As InputDAO
        Get
            If instance Is Nothing Then instance = New InputDAO()
            Return instance
        End Get
        Private Set(ByVal value As InputDAO)
            instance = value
        End Set
    End Property

    Private Sub New()
    End Sub

    Public Function GetListUnit() As List(Of Inputs)
        Dim list As List(Of Inputs) = New List(Of Inputs)()
        Dim query As String = "select * from Inputs"
        Dim data As DataTable = DataProvider._Instance.ExecuteQuery(query)

        For Each item As DataRow In data.Rows
            Dim input As Inputs = New Inputs(item)
            list.Add(input)
        Next

        Return list
    End Function
End Class