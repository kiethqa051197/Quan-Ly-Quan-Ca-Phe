Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO
Imports System.Globalization

Public Class FormBanHang

#Region "KHỞI TẠO"

    Dim acc As Accounts
    Dim idStaff As Integer

    Public Property _acc As Accounts
        Get
            Return acc
        End Get
        Set(value As Accounts)
            acc = value
            ChangeAccount(acc._type)
        End Set
    End Property

    Public Sub New(loginAcc As Accounts)
        InitializeComponent()
        Me._acc = loginAcc
    End Sub

#End Region

#Region "CÁC HÀM CHỨC NĂNG"

    'Load tất cả các bàn từ CSDL
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

    'Change Account
    Private Sub ChangeAccount(type As Integer)
        AdminStripMenu.Visible = type = 1
        PersonalInfoToolStripMenu.Text += " (" + _acc._username + ")"
        idStaff = _acc._idStaff
    End Sub

    'Lấy danh sách danh mục sản phẩm
    Private Sub LoadListCategory()
        Dim listCategory As List(Of Categories) = CategoriesDAO._Instance.GetListCategory()
        cbbCategory.Properties.DataSource = listCategory
        cbbCategory.Properties.DisplayMember = "_name"
    End Sub

    'Lấy danh sách các món ăn theo mã danh mục
    Private Sub LoadFoodListByCategoryID(id As Integer)
        Dim listFood As List(Of Items) = ItemsDAO._Instance.GetListCategoryID(id)
        cbbFoodName.Properties.DataSource = listFood
        cbbFoodName.Properties.DisplayMember = "_name"
    End Sub

    'Lấy danh sách tất cả các bàn
    Private Sub LoadComboboxTable(lookUpEdit As DevExpress.XtraEditors.LookUpEdit)
        lookUpEdit.Properties.DataSource = TableDAO._Instance.LoadTableList()
        lookUpEdit.Properties.DisplayMember = "_name"
    End Sub

    'Hiển thị món đã gọi
    Private Sub ShowBill(id As Integer)
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

#Region "BẮT SỰ KIỆN"

    'Chọn danh mục trong combobox danh mục
    Private Sub cbbCategory_EditValueChanged(sender As Object, e As EventArgs) Handles cbbCategory.EditValueChanged
        Dim id As Integer = 0
        Dim cb As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        If cb.EditValue Is Nothing Then Return
        Dim selected As Categories = TryCast(cb.EditValue, Categories)
        id = selected._id
        LoadFoodListByCategoryID(id)
    End Sub

    'Click menu đăng xuất
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        FormDangNhap.Show()
    End Sub

    'Click menu Admin
    Private Sub AdminStripMenu_Click(sender As Object, e As EventArgs) Handles AdminStripMenu.Click
        Dim f As FormAdmin = New FormAdmin

        AddHandler f.InsertFoods, AddressOf f_InsertFood
        AddHandler f.DeleteFoods, AddressOf f_DeleteFood
        AddHandler f.UpdateFoods, AddressOf f_UpdateFood
        AddHandler f.InsertCategoryFoods, AddressOf f_InsertCategoryFood
        AddHandler f.DeleteCategoryFoods, AddressOf f_DeleteCategoryFood
        AddHandler f.UpdateCategoryFoods, AddressOf f_UpdateCategoryFood
        AddHandler f.InsertTables, AddressOf f_InsertTableFood
        AddHandler f.DeleteTables, AddressOf f_DeleteTableFood
        AddHandler f.UpdateTables, AddressOf f_UpdateTableFood

        f.ShowDialog()
    End Sub

    'Chức năng click cho mỗi nút được tạo trong Flow Panel
    Private Sub btn_Click(sender As Object, e As EventArgs)
        Dim tableID As Integer = (TryCast((TryCast(sender, Button)).Tag, Tables))._id
        listBill.Tag = (TryCast(sender, Button)).Tag
        ShowBill(tableID)
    End Sub

    'Đóng form
    Private Sub FormBanHang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    'Load form
    Private Sub FormBanHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
        LoadListCategory()
        LoadComboboxTable(cbbSwitchTable)
    End Sub

    'Click nút thêm món
    Private Sub btnAddObject_Click(sender As Object, e As EventArgs) Handles btnAddObject.Click
        Dim table As Tables = TryCast(listBill.Tag, Tables)

        If table Is Nothing Then
            MessageBox.Show("Hãy chọn bàn")
            Return
        End If

        Dim idBill As Integer = BillsDAO._Instance.GetUncheckBillIDByTableID(table._id)
        Dim idItem As Integer = (TryCast(cbbFoodName.EditValue, Items))._id
        Dim price As Integer = (TryCast(cbbFoodName.EditValue, Items))._price
        Dim count As Integer = CInt(nmCount.Value)

        If idBill = -1 Then
            BillsDAO._Instance.InsertBill(table._id, idStaff)
            BillsInfoDAO._Instance.InsertBillInfo(BillsDAO._Instance.GetMaxIDBill(), idItem, price, count)
            TableDAO._Instance.UpdateStatusTable(table._id, "Có người")
        Else
            BillsInfoDAO._Instance.InsertBillInfo(idBill, idItem, price, count)
        End If

        ShowBill(table._id)
        LoadTable()
    End Sub

    'Click nút Thanh toán"
    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Dim table As Tables = TryCast(listBill.Tag, Tables)
        Dim idBill As Integer = BillsDAO._Instance.GetUncheckBillIDByTableID(table._id)
        Dim discount As Integer = CInt(nmDiscount.Value)
        Dim totalPrice As Double = Convert.ToDouble(txtTotal.Text.Split(","c)(0))
        Dim finalTotalPrice As Double = totalPrice - (totalPrice / 100) * discount

        If idBill <> -1 Then

            If MessageBox.Show(String.Format("Bạn có chắc thanh toán hoá đơn cho bàn {0}" & vbLf & "Tổng tiền - (Tổng tiền / 100) x Giảm giá" & vbLf & " => {1}000 - ({1}000 / 100) x {2} = {3}000", table._name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                BillsDAO._Instance.CheckOut(idBill, 1, discount, idStaff)
                TableDAO._Instance.UpdateStatusTable(table._id, "Trống")
                ShowBill(table._id)
                LoadTable()
            End If
        End If
    End Sub

    'Click nút Chuyển bàn
    Private Sub btnSwichTable_Click(sender As Object, e As EventArgs) Handles btnSwichTable.Click
        Dim id1 As Integer = (TryCast(listBill.Tag, Tables))._id
        Dim id2 As Integer = (TryCast(cbbSwitchTable.EditValue, Tables))._id

        If MessageBox.Show(String.Format("Bạn có thực sự muốn chuyển bàn {0} qua bàn {1}", (TryCast(listBill.Tag, Tables))._name, (TryCast(cbbSwitchTable.EditValue, Tables))._name), "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            TableDAO._Instance.SwitchTable(id1, id2, idStaff)
            LoadTable()
        End If
    End Sub

    'Click menu 'Khách hàng' (chưa xong)
    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Dim f As FormKhachHang = New FormKhachHang()
        f.ShowDialog()
    End Sub

    'Thông tin cá nhân
    Private Sub PersonalInfoToolStripMenu_Click(sender As Object, e As EventArgs) Handles PersonalInfoToolStripMenu.Click
        Dim staff As Staffs = StaffDAO._Instance.GetInfoStaffById(idStaff)

        Dim f As FormThongTinNhanVien = New FormThongTinNhanVien(staff)
        AddHandler f.updateAccount, AddressOf f_UpdateAccount
        f.ShowDialog()
    End Sub

    'Change text thông tin tài khoản
    Private Sub f_UpdateAccount(sender As Object, e As AccountEvent)
        PersonalInfoToolStripMenu.Text = "Thông tin tài khoản (" & e._acc._username & ")"
    End Sub

    'Cập nhật bàn ăn
    Private Sub f_UpdateTableFood(sender As Object, e As EventArgs)
        LoadTable()
        If listBill.Tag IsNot Nothing Then ShowBill((TryCast(listBill.Tag, Tables))._id)
    End Sub

    'Xóa bàn ăn
    Private Sub f_DeleteTableFood(sender As Object, e As EventArgs)
        If listBill.Tag IsNot Nothing Then ShowBill((TryCast(listBill.Tag, Tables))._id)
        LoadTable()
    End Sub

    'Thêm bàn ăn
    Private Sub f_InsertTableFood(sender As Object, e As EventArgs)
        LoadTable()
        If listBill.Tag IsNot Nothing Then ShowBill((TryCast(listBill.Tag, Tables))._id)
    End Sub

    'Cập nhât danh mục
    Private Sub f_UpdateCategoryFood(sender As Object, e As EventArgs)
        LoadListCategory()
        If listBill.Tag IsNot Nothing Then ShowBill((TryCast(listBill.Tag, Tables))._id)
    End Sub

    'Xóa danh mục
    Private Sub f_DeleteCategoryFood(sender As Object, e As EventArgs)
        LoadListCategory()
        If listBill.Tag IsNot Nothing Then ShowBill((TryCast(listBill.Tag, Tables))._id)
        LoadTable()
    End Sub

    'Thêm danh mục
    Private Sub f_InsertCategoryFood(sender As Object, e As EventArgs)
        LoadListCategory()
        If listBill.Tag IsNot Nothing Then ShowBill((TryCast(listBill.Tag, Tables))._id)
    End Sub

    'Cập nhật món ăn
    Private Sub f_UpdateFood(sender As Object, e As EventArgs)
        LoadFoodListByCategoryID((TryCast(cbbCategory.EditValue, Categories))._id)
        If listBill.Tag IsNot Nothing Then ShowBill((TryCast(listBill.Tag, Tables))._id)
    End Sub

    'Xóa món ăn
    Private Sub f_DeleteFood(sender As Object, e As EventArgs)
        LoadFoodListByCategoryID((TryCast(cbbCategory.EditValue, Categories))._id)
        If listBill.Tag IsNot Nothing Then ShowBill((TryCast(listBill.Tag, Tables))._id)
        LoadTable()
    End Sub

    'Thêm món ăn
    Private Sub f_InsertFood(sender As Object, e As EventArgs)
        LoadFoodListByCategoryID((TryCast(cbbCategory.EditValue, Categories))._id)
        If listBill.Tag IsNot Nothing Then ShowBill((TryCast(listBill.Tag, Tables))._id)
    End Sub

#End Region

End Class