Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO

Namespace PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO
    Public Class StaffDAO
        Public Shared instance As StaffDAO
        Private _item As DataRow

        Sub New(item As DataRow)
            ' TODO: Complete member initialization 
            _item = item
        End Sub

        Public Shared Property _Instance As StaffDAO
            Get
                If instance Is Nothing Then instance = New StaffDAO()
                Return instance
            End Get
            Private Set(value As StaffDAO)
                instance = value
            End Set
        End Property

        Private Sub New()
        End Sub

        Public Function GetInfoStaffById(id As Integer) As Staffs
            Dim data As DataTable = DataProvider._Instance.ExecuteQuery("SELECT * FROM STAFFS WHERE id = " & id)

            For Each item As DataRow In data.Rows
                Return New Staffs(item)
            Next

            Return Nothing
        End Function

        Public Function UpdateInfoStaff(id As Integer, name As String, dateofbirth As String, idCard As String, address As String, phone As String) As Boolean
            Dim query As String = String.Format("Update STAFFS SET fullname = N'{1}' , dateofbirth = '{2}' , idCard = '{3}' , address = N'{4}' , phone = '{5}' where id = {0}", id, name, dateofbirth, idCard, address, phone)
            Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
            Return result > 0
        End Function

        Public Function InsertStaff(fullname As String, dateofbirth As String, idCard As String, address As String, phone As String) As Boolean
            Dim query As String = "PC_AddNewStaff @fullname , @dateofbirth , @idCard , @address , @phone "
            Dim result As DataTable = DataProvider._Instance.ExecuteQuery(query, New Object() {fullname, dateofbirth, idCard, address, phone})
            Return result.Rows.Count > 0
        End Function

        Public Function GetListStaff() As List(Of Staffs)
            Dim list As List(Of Staffs) = New List(Of Staffs)()
            Dim query As String = "SELECT * FROM dbo.STAFFS EXCEPT SELECT * FROM dbo.STAFFS WHERE id = 1"
            Dim data As DataTable = DataProvider._Instance.ExecuteQuery(query)

            For Each item As DataRow In data.Rows
                Dim staff As Staffs = New Staffs(item)
                list.Add(staff)
            Next

            Return list
        End Function
    End Class
End Namespace

