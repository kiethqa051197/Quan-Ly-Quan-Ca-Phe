Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO
Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO

Namespace PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO
    Public Class BillsInfoDAO
        Private Shared instance As BillsInfoDAO

        Public Shared Property _Instance As BillsInfoDAO
            Get
                If instance Is Nothing Then instance = New BillsInfoDAO()
                Return BillsInfoDAO.instance
            End Get
            Private Set(ByVal value As BillsInfoDAO)
                BillsInfoDAO.instance = value
            End Set
        End Property

        Private Sub New()
        End Sub

        Public Sub DeleteBillInfo(ByVal id As Integer)
            DataProvider._Instance.ExecuteQuery("DELETE dbo.BillInfo WHERE idFood = " & id)
        End Sub

        Public Function GetListBillInfo(ByVal id As Integer) As List(Of BillInfos)
            Dim listBillInfo As List(Of BillInfos) = New List(Of BillInfos)()
            Dim data As DataTable = DataProvider._Instance.ExecuteQuery("SELECT * FROM dbo.BillInfo WHERE idBill = " & id)

            For Each item As DataRow In data.Rows
                Dim info As BillInfos = New BillInfos(item)
                listBillInfo.Add(info)
            Next

            Return listBillInfo
        End Function

        Public Sub InsertBillInfo(ByVal idBill As Integer, ByVal idFood As Integer, ByVal count As Integer)
            DataProvider._Instance.ExecuteNoneQuery("EXEC PC_InsertBillInfo @idBill , @idFood , @count", New Object() {idBill, idFood, count})
        End Sub
    End Class
End Namespace
