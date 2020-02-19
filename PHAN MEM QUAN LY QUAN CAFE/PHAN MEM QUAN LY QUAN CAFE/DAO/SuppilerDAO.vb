Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO

Public Class SuppilerDAO
    Public Shared instance As SuppilerDAO
    Private _item As DataRow

    Sub New(item As DataRow)
        ' TODO: Complete member initialization 
        _item = item
    End Sub

    Public Shared Property _Instance As SuppilerDAO
        Get
            If instance Is Nothing Then instance = New SuppilerDAO()
            Return instance
        End Get
        Private Set(ByVal value As SuppilerDAO)
            instance = value
        End Set
    End Property

    Private Sub New()
    End Sub

    Public Function GetListSupplier() As List(Of Suppliers)
        Dim list As List(Of Suppliers) = New List(Of Suppliers)()
        Dim query As String = "select * from SUPPLIERS where status = 0"
        Dim data As DataTable = DataProvider._Instance.ExecuteQuery(query)

        For Each item As DataRow In data.Rows
            Dim supplier As Suppliers = New Suppliers(item)
            list.Add(supplier)
        Next

        Return list
    End Function

    Public Function InsertSupplier(name As String, address As String, phone As String, email As String) As Boolean
        Dim query As String = String.Format("INSERT SUPPLIERS (name, address, phone, email) VALUES (N'{0}' , '{1}' , '{2}' , '{3}' )", name, address, phone, email)
        Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
        Return result > 0
    End Function

    Public Function UpdateSupplier(id As Integer, name As String, address As String, phone As String, email As String) As Boolean
        Dim query As String = String.Format("UPDATE SUPPLIERS SET name = N'{1}' , address = N'{2}' , phone = N'{3}' , email = '{4}' WHERE id = {0}", id, name, address, phone, email)
        Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
        Return result > 0
    End Function

    Public Function DeleteSupplier(id As Integer) As Boolean
        Dim query As String = String.Format("Update SUPPLIERS SET status = 1 WHERE id = {0}", id)
        Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
        Return result > 0
    End Function
End Class
