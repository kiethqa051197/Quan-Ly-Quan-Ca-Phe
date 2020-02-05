Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO

Namespace PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO
    Public Class MenuDAO
        Private Shared instance As MenuDAO

        Public Shared Property _Instance As MenuDAO
            Get
                If instance Is Nothing Then instance = New MenuDAO()
                Return instance
            End Get
            Private Set(ByVal value As MenuDAO)
                MenuDAO.instance = value
            End Set
        End Property

        Private Sub New()
        End Sub

        Public Function GetListMenuByTable(ByVal id As Integer) As List(Of Menu)
            Dim listMenu As List(Of Menu) = New List(Of Menu)()
            Dim query As String = "SELECT i.name, bi.count, i.price, i.price*bi.count AS totalPrice FROM BILLINFOS AS bi, BILLS AS b, ITEMS AS i WHERE bi.idBill = b.id AND bi.idItems = i.id AND b.status = 0 AND b.idTable = " & id
            Dim data As DataTable = DataProvider._Instance.ExecuteQuery(query)

            For Each item As DataRow In data.Rows
                Dim menu As Menu = New Menu(item)
                listMenu.Add(menu)
            Next

            Return listMenu
        End Function
    End Class
End Namespace
