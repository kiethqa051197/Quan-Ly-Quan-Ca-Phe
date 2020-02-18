Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO

Public Class CustomerDAO
    Private Shared instance As CustomerDAO

    Public Shared Property _Instance As CustomerDAO
        Get
            If instance Is Nothing Then instance = New CustomerDAO()
            Return CustomerDAO.instance
        End Get
        Private Set(value As CustomerDAO)
            CustomerDAO.instance = value
        End Set
    End Property

    Private Sub New()
    End Sub

    Public Function GetListCustomer() As List(Of Customers)
        Dim list As List(Of Customers) = New List(Of Customers)()
        Dim query As String = "SELECT * FROM CUSTOMERS WHERE status = 0"
        Dim data As DataTable = DataProvider._Instance.ExecuteQuery(query)

        For Each item As DataRow In data.Rows
            Dim customer As Customers = New Customers(item)
            list.Add(customer)
        Next

        Return list
    End Function

    Public Function InsertCustomer(name As String, phone As String) As Boolean
        Dim query As String = String.Format("INSERT CUSTOMERS (name, phone) VALUES (N'{0}', '{1}')", name, phone)
        Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
        Return result > 0
    End Function

    Public Function UpdateCustomer(id As Integer, name As String, phone As String) As Boolean
        Dim query As String = String.Format("UPDATE CUSTOMERS SET name = N'{1}' , phone = '{2}' WHERE id = {0}", id, name, phone)
        Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
        Return result > 0
    End Function

    Public Function DeleteCustomer(id As Integer) As Boolean
        Dim query As String = String.Format("Update CUSTOMERS SET status = 1 WHERE id = {0}", id)
        Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
        Return result > 0
    End Function
End Class
