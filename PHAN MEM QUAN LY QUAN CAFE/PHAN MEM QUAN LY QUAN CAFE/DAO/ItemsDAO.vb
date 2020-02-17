Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.Ultils

Namespace PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO
    Public Class ItemsDAO
        Private Shared instance As ItemsDAO

        Public Shared Property _Instance As ItemsDAO
            Get
                If instance Is Nothing Then instance = New ItemsDAO()
                Return ItemsDAO.instance
            End Get
            Private Set(value As ItemsDAO)
                ItemsDAO.instance = value
            End Set
        End Property

        Private Sub New()
        End Sub

        Public Function GetListCategoryID(id As Integer) As List(Of Items)
            Dim list As List(Of Items) = New List(Of Items)()
            Dim query As String = "SELECT * FROM ITEMS WHERE idCategory = " & id & " and status = 0"
            Dim data As DataTable = DataProvider._Instance.ExecuteQuery(query)

            For Each item As DataRow In data.Rows
                Dim food As Items = New Items(item)
                list.Add(food)
            Next

            Return list
        End Function

        Public Function GetListFood() As List(Of Items)
            Dim list As List(Of Items) = New List(Of Items)()
            Dim query As String = "SELECT * FROM ITEMS WHERE STATUS = 0"
            Dim data As DataTable = DataProvider._Instance.ExecuteQuery(query)

            For Each item As DataRow In data.Rows
                Dim food As Items = New Items(item)
                list.Add(food)
            Next

            Return list
        End Function

        Public Function InsertFood(name As String, price As Integer, id As Integer) As Boolean
            Dim query As String = String.Format("INSERT INTO ITEMS ( name, price, idcategory) VALUES  ( N'{0}', {1}, {2})", name, price, id)
            Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
            Return result > 0
        End Function

        Public Function UpdateFood(idFood As Integer, name As String, id As Integer, price As Single) As Boolean
            Dim query As String = String.Format("UPDATE ITEMS SET name = N'{0}', idcategory = {1}, price = {2} WHERE id = {3}", name, id, price, idFood)
            Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
            Return result > 0
        End Function

        Public Function DeleteFood(idFood As Integer) As Boolean
            Dim query As String = String.Format("UPDATE ITEMS SET status = 1 WHERE id = {0}", idFood)
            Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
            Return result > 0
        End Function

        Public Function SearchFoodByName(name As String) As List(Of Items)
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
