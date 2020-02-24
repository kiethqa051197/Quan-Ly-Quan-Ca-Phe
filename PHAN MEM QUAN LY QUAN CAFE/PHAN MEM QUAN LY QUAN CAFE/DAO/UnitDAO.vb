Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO

Public Class UnitDAO
    Public Shared instance As UnitDAO
    Private _item As DataRow

    Sub New(item As DataRow)
        ' TODO: Complete member initialization 
        _item = item
    End Sub

    Public Shared Property _Instance As UnitDAO
        Get
            If instance Is Nothing Then instance = New UnitDAO()
            Return instance
        End Get
        Private Set(ByVal value As UnitDAO)
            instance = value
        End Set
    End Property

    Private Sub New()
    End Sub

    Public Function GetListUnit() As List(Of Units)
        Dim list As List(Of Units) = New List(Of Units)()
        Dim query As String = "select * from UNITS where status = 0"
        Dim data As DataTable = DataProvider._Instance.ExecuteQuery(query)

        For Each item As DataRow In data.Rows
            Dim unit As Units = New Units(item)
            list.Add(unit)
        Next

        Return list
    End Function

    Public Function InsertUnit(name As String) As Boolean
        Dim query As String = String.Format("INSERT INTO UNITS (name) VALUES  (N'{0}')", name)
        Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
        Return result > 0
    End Function

    Public Function UpdateUnit(id As Integer, name As String) As Boolean
        Dim query As String = String.Format("UPDATE UNITS SET name = N'{1}' WHERE id = {0}", id, name)
        Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
        Return result > 0
    End Function

    Public Function DeleteUnit(id As Integer) As Boolean
        Dim query As String = String.Format("DELETE UNITS WHERE id = {0}", id)
        Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
        Return result > 0
    End Function

    Public Function GetUnitByID(id As Integer) As Units
        Dim unit As Units = Nothing
        Dim query As String = "SELECT * FROM UNITS WHERE id = " & id
        Dim data As DataTable = DataProvider._Instance.ExecuteQuery(query)

        For Each item As DataRow In data.Rows
            unit = New Units(item)
            Return unit
        Next

        Return unit
    End Function
End Class
