﻿Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO

Namespace PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO
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

        Public Function UpdateAccount(ByVal userName As String, ByVal displayName As String, ByVal pass As String, ByVal newPass As String) As Boolean
            Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery("EXEC USP_UpdateAccount @userName , @displayName , @password , @newPassword ", New Object() {userName, displayName, pass, newPass})
            Return result > 0
        End Function

        Public Function GetAccountByUserName(ByVal userName As String) As Accounts
            Dim data As DataTable = DataProvider._Instance.ExecuteQuery("SELECT * FROM ACCOUNTS WHERE userName = '" & userName & "'")

            For Each item As DataRow In data.Rows
                Return New Accounts(item)
            Next

            Return Nothing
        End Function

        Public Function GetListAccount() As DataTable
            Return DataProvider._Instance.ExecuteQuery("SELECT userName, displayName, type FROM ACCOUNTS ")
        End Function

        Public Function InsertAccount(ByVal username As String, ByVal displayname As String, ByVal type As Integer) As Boolean
            Dim query As String = String.Format("INSERT INTO dbo.ACCOUNTS ( username, displayname, type, password ) VALUES  ( N'{0}', N'{1}', {2}, N'{3}')", username, displayname, type, "1962026656160185351301320480154111117132155")
            Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
            Return result > 0
        End Function

        Public Function UpdateAccount(ByVal username As String, ByVal displayname As String, ByVal type As Integer) As Boolean
            Dim query As String = String.Format("UPDATE dbo.ACCOUNTS SET displayname = N'{1}', type = {2} WHERE username = N'{0}'", username, displayname, type)
            Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
            Return result > 0
        End Function

        Public Function DeleteAccount(ByVal username As String) As Boolean
            Dim query As String = String.Format("DELETE ACCOUNTS where username = N'{0}'", username)
            Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
            Return result > 0
        End Function

        Public Function ResetPass(ByVal username As String) As Boolean
            Dim query As String = String.Format("Update ACCOUNTS SET password = N'1962026656160185351301320480154111117132155' where username = N'{0}'", username)
            Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
            Return result > 0
        End Function
    End Class
End Namespace
