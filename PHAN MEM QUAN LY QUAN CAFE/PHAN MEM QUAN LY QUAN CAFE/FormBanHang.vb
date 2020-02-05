Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO
Imports System.Globalization

Public Class FormBanHang

#Region "Initialize"
    Dim acc As Accounts
    Dim idStaff As Integer

    Public Property _acc As Accounts
        Get
            Return acc
        End Get
        Set(ByVal value As Accounts)
            acc = value
            ChangeAccount(acc._type)
        End Set
    End Property

    Public Sub New(ByVal loginAcc As Accounts)
        InitializeComponent()
        Me._acc = loginAcc
    End Sub
#End Region

#Region "method"

#Region "Load tất cả các bàn từ CSDL"
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
                Case "Trống"
                    btn.BackColor = Color.Aqua
                Case Else
                    btn.BackColor = Color.LightPink
            End Select

            tableLayout.Controls.Add(btn)
        Next
    End Sub
#End Region

#Region "Change Account"
    Private Sub ChangeAccount(ByVal type As Integer)
        AdminStripMenu.Visible = type = 1
        PersonalInfoToolStripMenu.Text += " (" + acc._username + ")"
        idStaff = acc._idStaff
    End Sub
#End Region

#Region "Lấy danh sách danh mục sản phẩm"
    Private Sub LoadListCategory()
        Dim listCategory As List(Of Categories) = CategoriesDAO._Instance.GetListCategory()
        cbCategory.DataSource = listCategory
        cbCategory.DisplayMember = "_name"
    End Sub
#End Region

#Region "Lấy danh sách các món ăn theo mã danh mục"
    Private Sub LoadFoodListByCategoryID(ByVal id As Integer)
        Dim listFood As List(Of Items) = ItemsDAO._Instance.GetListCategoryID(id)
        cbObject.DataSource = listFood
        cbObject.DisplayMember = "_name"
    End Sub
#End Region

#Region "Lấy danh sách tất cả các bàn"
    Private Sub LoadComboboxTable(ByVal cb As ComboBox)
        cb.DataSource = TableDAO._Instance.LoadTableList()
        cb.DisplayMember = "_name"
    End Sub
#End Region

#Region "Hiển thị món đã gọi"
    Private Sub ShowBill(ByVal id As Integer)
        listBill.Items.Clear()
        Dim listBillInfo As List(Of Menu) = MenuDAO._Instance.GetListMenuByTable(id)
        Dim totalPrice As Single = 0

        For Each item As Menu In listBillInfo
            Dim lsvItem As ListViewItem = New ListViewItem(item._name.ToString())
            lsvItem.SubItems.Add(item._count.ToString())
            lsvItem.SubItems.Add(item._price.ToString())
            lsvItem.SubItems.Add(item._totalPrice.ToString())
            totalPrice += item._totalPrice
            listBill.Items.Add(lsvItem)
        Next

        Dim culture As CultureInfo = New CultureInfo("vi-VN")
        txtTotal.Text = totalPrice.ToString("c", culture)
    End Sub
#End Region

#End Region

#Region "event"

#Region "Chọn danh mục"
    Private Sub cbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategory.SelectedIndexChanged
        Dim id As Integer = 0
        Dim cb As ComboBox = TryCast(sender, ComboBox)
        If cb.SelectedItem Is Nothing Then Return
        Dim selected As Categories = TryCast(cb.SelectedItem, Categories)
        id = selected._id
        LoadFoodListByCategoryID(id)
    End Sub
#End Region

#Region "Click menu đăng xuất"
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        FormDangNhap.Show()
    End Sub
#End Region

#Region "Click menu Admin"
    Private Sub AdminStripMenu_Click(sender As Object, e As EventArgs) Handles AdminStripMenu.Click
        FormAdmin.Show()
    End Sub
#End Region

#Region "Chức năng click cho mỗi nút được tạo trong Flow Panel"
    Private Sub btn_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim tableID As Integer = (TryCast((TryCast(sender, Button)).Tag, Tables))._id
        listBill.Tag = (TryCast(sender, Button)).Tag
        ShowBill(tableID)
    End Sub
#End Region

#Region "Đóng form"
    Private Sub FormBanHang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
#End Region

#Region "Thực hiện tất cả các function khi load Form"
    Private Sub FormBanHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
        LoadListCategory()
        LoadComboboxTable(cbSwichTable)
    End Sub
#End Region

#Region "Gọi món"
    Private Sub btnAddObject_Click(sender As Object, e As EventArgs) Handles btnAddObject.Click
        Dim table As Tables = TryCast(listBill.Tag, Tables)

        If table Is Nothing Then
            MessageBox.Show("Hãy chọn bàn")
            Return
        End If

        Dim idBill As Integer = BillsDAO._Instance.GetUncheckBillIDByTableID(table._id)
        Dim foodID As Integer = (TryCast(cbObject.SelectedItem, Items))._id
        Dim count As Integer = CInt(nmCount.Value)

        If idBill = -1 Then
            BillsDAO._Instance.InsertBill(table._id, idStaff)
            BillsInfoDAO._Instance.InsertBillInfo(BillsDAO._Instance.GetMaxIDBill(), foodID, count)
            TableDAO._Instance.UpdateStatusTable(table._id, "Có người")
        Else
            BillsInfoDAO._Instance.InsertBillInfo(idBill, foodID, count)
        End If

        ShowBill(table._id)
        LoadTable()
    End Sub
#End Region

#Region "Thanh toán"
    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Dim table As Tables = TryCast(listBill.Tag, Tables)
        Dim idBill As Integer = BillsDAO._Instance.GetUncheckBillIDByTableID(table._id)
        Dim discount As Integer = CInt(nmDiscount.Value)
        Dim totalPrice As Double = Convert.ToDouble(txtTotal.Text.Split(","c)(0))
        Dim finalTotalPrice As Double = totalPrice - (totalPrice / 100) * discount

        If idBill <> -1 Then

            If MessageBox.Show(String.Format("Bạn có chắc thanh toán hoá đơn cho bàn {0}" & vbLf & "Tổng tiền - (Tổng tiền / 100) x Giảm giá" & vbLf & " => {1}000 - ({1}000 / 100) x {2} = {3}000", table._name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                BillsDAO._Instance.CheckOut(idBill, 3, discount, idStaff)
                TableDAO._Instance.UpdateStatusTable(table._id, "Trống")
                ShowBill(table._id)
                LoadTable()
            End If
        End If
    End Sub
#End Region

#Region "Chuyển bàn"
    Private Sub btnSwichTable_Click(sender As Object, e As EventArgs) Handles btnSwichTable.Click
        Dim id1 As Integer = (TryCast(listBill.Tag, Tables))._id
        Dim id2 As Integer = (TryCast(cbSwichTable.SelectedItem, Tables))._id

        If MessageBox.Show(String.Format("Bạn có thực sự muốn chuyển bàn {0} qua bàn {1}", (TryCast(listBill.Tag, Tables))._name, (TryCast(cbSwichTable.SelectedItem, Tables))._name), "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            TableDAO._Instance.SwitchTable(id1, id2, idStaff)
            LoadTable()
        End If
    End Sub
#End Region

#End Region

End Class