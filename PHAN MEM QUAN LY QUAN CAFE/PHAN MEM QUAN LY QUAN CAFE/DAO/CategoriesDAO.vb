Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.Ultils

Namespace PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO
    Public Class CategoriesDAO
        Private Shared instance As CategoriesDAO

        Public Shared Property _Instance As CategoriesDAO
            Get
                If instance Is Nothing Then instance = New CategoriesDAO()
                Return CategoriesDAO.instance
            End Get
            Private Set(value As CategoriesDAO)
                CategoriesDAO.instance = value
            End Set
        End Property

        Private Sub New()
        End Sub

        Public Function GetListCategory() As List(Of Categories)
            Dim list As List(Of Categories) = New List(Of Categories)()
            Dim query As String = "SELECT * FROM CATEGORIES WHERE STATUS = 0 EXCEPT (SELECT * FROM CATEGORIES WHERE name = 'Khác' AND id = 1)"
            Dim data As DataTable = DataProvider._Instance.ExecuteQuery(query)

            For Each item As DataRow In data.Rows
                Dim category As Categories = New Categories(item)
                list.Add(category)
            Next

            Return list
        End Function

        Public Function GetCategoryByID(id As Integer) As Categories
            Dim category As Categories = Nothing
            Dim query As String = "SELECT * FROM CATEGORIES WHERE id = " & id
            Dim data As DataTable = DataProvider._Instance.ExecuteQuery(query)

            For Each item As DataRow In data.Rows
                category = New Categories(item)
                Return category
            Next

            Return category
        End Function

        Public Function InsertCategory(name As String) As Boolean
            Dim query As String = String.Format("INSERT INTO CATEGORIES ( name ) VALUES  ( N'{0}' )", name)
            Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
            Return result > 0
        End Function

        Public Function UpdateCategory(id As Integer, name As String) As Boolean
            Dim query As String = String.Format("UPDATE CATEGORIES SET name = N'{0}' WHERE id = {1}", name, id)
            Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
            Return result > 0
        End Function

        Public Function DeleteCategory(id As Integer) As Boolean
            Dim query As String = String.Format("DELETE CATEGORIES where id = {0}", id)
            Dim result As Integer = DataProvider._Instance.ExecuteNoneQuery(query)
            Return result > 0
        End Function
    End Class
End Namespace
