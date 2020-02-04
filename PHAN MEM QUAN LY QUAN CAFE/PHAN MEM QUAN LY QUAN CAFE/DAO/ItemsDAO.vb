Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO

Namespace PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO
    Public Class ItemsDAO
        Private Shared instance As ItemsDAO

        Public Shared Property _Instance As ItemsDAO
            Get
                If instance Is Nothing Then instance = New ItemsDAO()
                Return ItemsDAO.instance
            End Get
            Private Set(ByVal value As ItemsDAO)
                ItemsDAO.instance = value
            End Set
        End Property

        Private Sub New()
        End Sub

        Public Function GetListCategoryID(ByVal id As Integer) As List(Of Items)
            Dim list As List(Of Items) = New List(Of Items)()
            Dim query As String = "SELECT * FROM ITEMS WHERE idCategory = " & id
            Dim data As DataTable = DataProvider._Instance.ExecuteQuery(query)

            For Each item As DataRow In data.Rows
                Dim food As Items = New Items(item)
                list.Add(food)
            Next

            Return list
        End Function

        Public Function GetListFood() As List(Of Items)
            Dim list As List(Of Items) = New List(Of Items)()
            Dim query As String = "SELECT * FROM ITEMS"
            Dim data As DataTable = DataProvider._Instance.ExecuteQuery(query)

            For Each item As DataRow In data.Rows
                Dim food As Items = New Items(item)
                list.Add(food)
            Next

            Return list
        End Function

        Public Function InsertFood(ByVal name As String, ByVal id As Integer, ByVal price As Single) As Boolean
            Dim query As String = String.Format("INSERT INTO ITEMS ( name, idcategory, price ) VALUES  ( N'{0}', {1}, {2})", name, id, price)
            Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
            Return result > 0
        End Function

        Public Function UpdateFood(ByVal idFood As Integer, ByVal name As String, ByVal id As Integer, ByVal price As Single) As Boolean
            Dim query As String = String.Format("UPDATE ITEMS SET name = N'{0}', idcategory = {1}, price = {2} WHERE id = {3}", name, id, price, idFood)
            Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
            Return result > 0
        End Function

        Public Function DeleteFood(ByVal idFood As Integer) As Boolean
            'BillInfoDAO.Instance.DeleteBillInfo(idFood)
            Dim query As String = String.Format("DELETE ITEMS where id = {0}", idFood)
            Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
            Return result > 0
        End Function

        Public Function SearchFoodByName(ByVal name As String) As List(Of Items)
            Dim list As List(Of Items) = New List(Of Items)()
            Dim query As String = String.Format("SELECT * FROM ITEMS WHERE dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name)
            Dim data As DataTable = DataProvider._Instance.ExecuteQuery(query)

            For Each item As DataRow In data.Rows
                Dim food As Items = New Items(item)
                list.Add(food)
            Next

            Return list
        End Function
    End Class
End Namespace
