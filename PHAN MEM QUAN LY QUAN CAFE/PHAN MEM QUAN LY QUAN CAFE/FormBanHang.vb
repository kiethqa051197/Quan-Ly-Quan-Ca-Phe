Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO

Public Class FormBanHang

    Private Sub FormBanHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
        LoadListCategory()
        LoadComboboxTable(cbSwichTable)
    End Sub

    Private Sub LoadTable()
        tableLayout.Controls.Clear()
        Dim tableList As List(Of Tables) = TableDAO._Instance.LoadTableList()

        For Each item As Tables In tableList

            Dim btn As Button = New Button() With {
                .Width = TableDAO.TableWidth,
                .Height = TableDAO.TableHeigth
            }

            btn.Text = item._name + Environment.NewLine + item._status
            AddHandler btn.Click, AddressOf btn_Click
            btn.Tag = item

            Select Case item._status
                Case "Bàn trống"
                    btn.BackColor = Color.Aqua
                Case Else
                    btn.BackColor = Color.LightPink
            End Select

            tableLayout.Controls.Add(btn)
        Next
    End Sub

    Private Sub AdminStripMenu_Click(sender As Object, e As EventArgs) Handles AdminStripMenu.Click
        FormAdmin.Show()
    End Sub

    Private Sub btn_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim tableID As Integer = (TryCast((TryCast(sender, Button)).Tag, Tables))._id
        listBill.Tag = (TryCast(sender, Button)).Tag
    End Sub

    Private Sub FormBanHang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub LoadListCategory()
        Dim listCategory As List(Of Categories) = CategoriesDAO._Instance.GetListCategory()
        cbCategory.DataSource = listCategory
        cbCategory.DisplayMember = "_name"
    End Sub

    Private Sub LoadFoodListByCategoryID(ByVal id As Integer)
        Dim listFood As List(Of Items) = ItemsDAO._Instance.GetListCategoryID(id)
        cbObject.DataSource = listFood
        cbObject.DisplayMember = "_name"
    End Sub

    Private Sub cbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategory.SelectedIndexChanged
        Dim id As Integer = 0
        Dim cb As ComboBox = TryCast(sender, ComboBox)
        If cb.SelectedItem Is Nothing Then Return
        Dim selected As Categories = TryCast(cb.SelectedItem, Categories)
        id = selected._id
        LoadFoodListByCategoryID(id)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        FormDangNhap.Show()
    End Sub

    Private Sub LoadComboboxTable(ByVal cb As ComboBox)
        cb.DataSource = TableDAO._Instance.LoadTableList()
        cb.DisplayMember = "_name"
    End Sub

End Class