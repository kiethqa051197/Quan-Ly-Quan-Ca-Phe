Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO

Public Class ObjectDAO
    Public Shared instance As ObjectDAO
    Private _item As DataRow

    Sub New(item As DataRow)
        _item = item
    End Sub

    Public Shared Property _Instance As ObjectDAO
        Get
            If instance Is Nothing Then instance = New ObjectDAO()
            Return instance
        End Get
        Private Set(ByVal value As ObjectDAO)
            instance = value
        End Set
    End Property

    Private Sub New()
    End Sub

    Public Function GetListObject() As List(Of Objects)
        Dim list As List(Of Objects) = New List(Of Objects)()
        Dim query As String = "select * from OBJECTS where status = 0"
        Dim data As DataTable = DataProvider._Instance.ExecuteQuery(query)

        For Each item As DataRow In data.Rows
            Dim unit As Objects = New Objects(item)
            list.Add(unit)
        Next

        Return list
    End Function

    Public Function InsertObject(name As String, idUnit As Integer, idSupplier As Integer) As Boolean
        Dim query As String = String.Format("INSERT INTO OBJECTS (name, idUnit, idSupplier) VALUES  (N'{0}', {1}, {2})", name, idUnit, idSupplier)
        Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
        Return result > 0
    End Function

    Public Function UpdateObject(id As Integer, name As String, idUnit As Integer, idSupplier As Integer) As Boolean
        Dim query As String = String.Format("UPDATE OBJECTS SET name = N'{1}' , idUnit = {2} , idSupplier = {3} WHERE id = {0}", id, name, idUnit, idSupplier)
        Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
        Return result > 0
    End Function

    Public Function DeleteObject(id As Integer) As Boolean
        Dim query As String = String.Format("DELETE OBJECTS WHERE id = {0}", id)
        Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
        Return result > 0
    End Function
End Class
