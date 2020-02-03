Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO
    Public Class TableDAO
        Private Shared instance As TableDAO

        Public Shared Property _Instance As TableDAO
            Get
                If instance Is Nothing Then instance = New TableDAO()
                Return TableDAO.instance
            End Get
            Private Set(ByVal value As TableDAO)
                TableDAO.instance = value
            End Set
        End Property

        Public Shared TableWidth As Integer = 90
        Public Shared TableHeigth As Integer = 90

        Private Sub New()
        End Sub

        Public Sub SwitchTable(ByVal id1 As Integer, ByVal id2 As Integer)
            DataProvider._Instance.ExecuteQuery("PC_SwitchTable @idTable1 , @idTable2", New Object() {id1, id2})
        End Sub

        Public Function LoadTableList() As List(Of Tables)
            Dim tableList As List(Of Tables) = New List(Of Tables)()
            Dim data As DataTable = DataProvider._Instance.ExecuteQuery("PC_GetTableList")

            For Each item As DataRow In data.Rows
                Dim table As Tables = New Tables(item)
                tableList.Add(table)
            Next

            Return tableList
        End Function

        Public Function GetListTable() As List(Of Tables)
            Dim list As List(Of Tables) = New List(Of Tables)()
            Dim query As String = "SELECT * FROM TABLES"
            Dim data As DataTable = DataProvider._Instance.ExecuteQuery(query)

            For Each item As DataRow In data.Rows
                Dim table As Tables = New Tables(item)
                list.Add(table)
            Next

            Return list
        End Function

        Public Function InsertTableFood(ByVal name As String) As Boolean
            Dim query As String = String.Format("INSERT INTO TABLES ( name ) VALUES  ( N'{0}' )", name)
            Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
            Return result > 0
        End Function

        Public Function UpdateTableFood(ByVal id As Integer, ByVal name As String) As Boolean
            Dim query As String = String.Format("UPDATE TABLES SET name = N'{0}' WHERE id = {1}", name, id)
            Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
            Return result > 0
        End Function

        Public Function DeleteTableFood(ByVal id As Integer) As Boolean
            Dim query As String = String.Format("DELETE TABLES where id = {0}", id)
            Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
            Return result > 0
        End Function
    End Class
End Namespace

