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
            Private Set(ByVal value As StaffDAO)
                instance = value
            End Set
        End Property

        Private Sub New()
        End Sub

        Public Function GetInfoStaffById(ByVal id As Integer) As Staffs
            Dim data As DataTable = DataProvider._Instance.ExecuteQuery("SELECT * FROM STAFFS WHERE id = " & id)

            For Each item As DataRow In data.Rows
                Return New Staffs(item)
            Next

            Return Nothing
        End Function
    End Class
End Namespace

