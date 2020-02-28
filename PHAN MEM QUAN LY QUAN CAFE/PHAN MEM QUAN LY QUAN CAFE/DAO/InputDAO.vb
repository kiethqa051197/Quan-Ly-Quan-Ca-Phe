Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO

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

    Public Function GetListInput() As List(Of Inputs)
        Dim list As List(Of Inputs) = New List(Of Inputs)()
        Dim query As String = "select * from Inputs"
        Dim data As DataTable = DataProvider._Instance.ExecuteQuery(query)

        For Each item As DataRow In data.Rows
            Dim input As Inputs = New Inputs(item)
            list.Add(input)
        Next

        Return list
    End Function

    Public Function getInventory(mothStart As String, mothEnd As String, idObject As Integer) As Integer
        Dim query As String = "DECLARE @get VARCHAR(20); EXEC PC_INVENTORY '" & mothStart + "' , '" & mothEnd + "' , " & idObject & ", @get output; SELECT @get "

        If DataProvider._Instance.ExecuteScalar(query) Is DBNull.Value Then
            Return 0
        Else
            Dim ton As Integer = DataProvider._Instance.ExecuteScalar(query)
            Return ton
        End If
    End Function

    Public Function getPrice(mothStart As String, mothEnd As String, idObject As Integer) As Integer
        Dim query As String = "DECLARE @get VARCHAR(20); EXEC PC_GETPRICE_INPUT '" & mothStart + "' , '" & mothEnd + "' , " & idObject & ", @get output; SELECT @get "

        If DataProvider._Instance.ExecuteScalar(query) Is DBNull.Value Then
            Return 0
        Else
            Dim price As Integer = DataProvider._Instance.ExecuteScalar(query)
            Return price
        End If
    End Function

    Public Function getCount(mothStart As String, mothEnd As String, idObject As Integer) As Integer
        Dim query As String = "DECLARE @get VARCHAR(20); EXEC PC_GETCOUNT_INPUT '" & mothStart + "' , '" & mothEnd + "' , " & idObject & ", @get output; SELECT @get "

        If DataProvider._Instance.ExecuteScalar(query) Is DBNull.Value Then
            Return 0
        Else
            Dim price As Integer = DataProvider._Instance.ExecuteScalar(query)
            Return price
        End If
    End Function

    Public Function getListObject() As List(Of Objects)
        Dim list As List(Of Objects) = New List(Of Objects)()
        Dim query As String = "select * from OBJECTS where id In (select ii.idObject from INPUTS as i join INPUTINFOS as ii on ii.idInput = i.id group by ii.idObject)"
        Dim data As DataTable = DataProvider._Instance.ExecuteQuery(query)

        For Each item As DataRow In data.Rows
            Dim input As Objects = New Objects(item)
            list.Add(input)
        Next

        Return list
    End Function
End Class
