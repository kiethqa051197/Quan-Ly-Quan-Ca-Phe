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
End Class
