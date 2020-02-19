Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO

Public Class AccountDAO
    Public Shared instance As AccountDAO
    Private _item As DataRow

    Sub New(item As DataRow)
        ' TODO: Complete member initialization 
        _item = item
    End Sub

    Public Shared Property _Instance As AccountDAO
        Get
            If instance Is Nothing Then instance = New AccountDAO()
            Return instance
        End Get
        Private Set(ByVal value As AccountDAO)
            instance = value
        End Set
    End Property

    Private Sub New()
    End Sub

    Public Function Login(ByVal userName As String, ByVal password As String) As Boolean
        Dim query As String = "PC_Login @userName , @passWord"
        Dim result As DataTable = DataProvider._Instance.ExecuteQuery(query, New Object() {userName, password})
        Return result.Rows.Count > 0
    End Function

    Public Function GetAccountByIdStaff(ByVal idStaff As Integer) As Accounts
        Dim data As DataTable = DataProvider._Instance.ExecuteQuery("SELECT * FROM ACCOUNTS WHERE idStaff = " & idStaff)

        For Each item As DataRow In data.Rows
            Return New Accounts(item)
        Next

        Return Nothing
    End Function

    Public Function GetAccountByUsername(ByVal username As String) As Accounts
        Dim data As DataTable = DataProvider._Instance.ExecuteQuery("SELECT * FROM ACCOUNTS WHERE username = '" & username & "'")

        For Each item As DataRow In data.Rows
            Return New Accounts(item)
        Next

        Return Nothing
    End Function

    Public Function GetListAccount() As DataTable
        Return DataProvider._Instance.ExecuteQuery("SELECT userName, displayName, type FROM ACCOUNTS ")
    End Function

    Public Function ResetPass(ByVal username As String) As Boolean
        Dim query As String = String.Format("Update ACCOUNTS SET password = N'123456' where username = N'{0}'", username)
        Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
        Return result > 0
    End Function

    Public Function UpdateAccountStaff(id As Integer, username As String, password As String, idStaff As Integer) As Boolean
        Dim query As String = String.Format("Update ACCOUNTS SET username = N'{1}' , password = N'{2}' , idStaff = {3} where id = {0}", id, username, password, idStaff)
        Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
        Return result > 0
    End Function

    Public Function UpdateUsernameAccountStaff(id As Integer, username As String) As Boolean
        Dim query As String = String.Format("Update ACCOUNTS SET username = N'{1}' where id = {0}", id, username)
        Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
        Return result > 0
    End Function
End Class