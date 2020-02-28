Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO

Public Class OutputDAO
    Public Shared instance As OutputDAO
    Private _item As DataRow

    Sub New(item As DataRow)
        ' TODO: Complete member initialization 
        _item = item
    End Sub

    Public Shared Property _Instance As OutputDAO
        Get
            If instance Is Nothing Then instance = New OutputDAO()
            Return instance
        End Get
        Private Set(ByVal value As OutputDAO)
            instance = value
        End Set
    End Property

    Private Sub New()
    End Sub

    Public Function getCount(mothStart As String, mothEnd As String, idObject As Integer) As Integer
        Dim query As String = "DECLARE @get VARCHAR(20); EXEC PC_GETCOUNT_OUTPUT '" & mothStart + "' , '" & mothEnd + "' , " & idObject & ", @get output; SELECT @get "

        If DataProvider._Instance.ExecuteScalar(query) Is DBNull.Value Then
            Return 0
        Else
            Dim price As Integer = DataProvider._Instance.ExecuteScalar(query)
            Return price
        End If
    End Function
End Class
