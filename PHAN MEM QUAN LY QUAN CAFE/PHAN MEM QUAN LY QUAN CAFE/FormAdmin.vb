Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO
Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.Ultils
Imports System.Text.RegularExpressions

Public Class FormAdmin

#Region "KHỞI TẠO"

    Private foodList As BindingSource = New BindingSource()
    Private categoryFoodList As BindingSource = New BindingSource()
    Private tableFoodList As BindingSource = New BindingSource()
    Private staffList As BindingSource = New BindingSource()
    Private customerList As BindingSource = New BindingSource()
    Private supplierList As BindingSource = New BindingSource()
    Private unitList As BindingSource = New BindingSource()

    Private isUpdateTable As Boolean = False
    Private isAddTable As Boolean = False

    Private isUpdateCategory As Boolean = False
    Private isAddCategory As Boolean = False

    Private isUpdateFood As Boolean = False
    Private isAddFood As Boolean = False

    Private isUpdateCustomer As Boolean = False
    Private isAddCustomer As Boolean = False

    Private isUpdateStaff As Boolean = False
    Private isAddStaff As Boolean = False

    Private isUpdateSupplier As Boolean = False
    Private isAddSupplier As Boolean = False

    Private _idStaff As Integer

    Public Sub New(idStaff As Integer)
        InitializeComponent()
        LoadData()

        _idStaff = idStaff
    End Sub

#End Region

#Region "PHƯƠNG THỨC"

    'Load Data
    Private Sub LoadData()
        dgvFood.DataSource = foodList
        dgvCategory.DataSource = categoryFoodList
        dgvTable.DataSource = tableFoodList
        dgvStaff.DataSource = staffList
        dgvCustomer.DataSource = customerList
        dgvSuplier.DataSource = supplierList
        dgvUnit.DataSource = unitList

        'LoadDateTimePickerBill()
        'LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value)
        LoadListFood()
        AddFoodBindding()

        LoadCatagoryIntoCombobox(cbCategoryFood)
        LoadListCategoryFood()
        AddCategoryFoodBindding()

        LoadListTableFood()
        AddTableFoodBindding()

        LoadListStaff()
        AddStaffBindding()

        LoadListCustomer()
        AddCustomerBindding()

        LoadListSupplier()
        AddSupplierBindding()

        LoadListUnit()
        AddUnitBindding()

        ChangeColumnName()
    End Sub

    'Tìm kiếm theo tên thức ăn
    Private Function SearchFoodByName(name As String) As List(Of Items)
        Dim listFood As List(Of Items) = ItemsDAO._Instance.SearchFoodByName(name)
        Return listFood
    End Function

    'Load Danh Mục lên combobox
    Private Sub LoadCatagoryIntoCombobox(cb As ComboBox)
        cb.DataSource = CategoriesDAO._Instance.GetListCategory()
        cb.DisplayMember = "_name"
    End Sub

    'Load các text tương ứng từ datagrid lên các box
    'Thức ăn
    Private Sub AddFoodBindding()
        txtIDFood.DataBindings.Add(New Binding("Text", dgvFood.DataSource, "_id", True, DataSourceUpdateMode.Never))
        txtNameFood.DataBindings.Add(New Binding("Text", dgvFood.DataSource, "_name", True, DataSourceUpdateMode.Never))
        nmPriceFood.DataBindings.Add(New Binding("Value", dgvFood.DataSource, "_price", True, DataSourceUpdateMode.Never))
    End Sub

    'Danh mục
    Private Sub AddUnitBindding()
        txtIDUnit.DataBindings.Add(New Binding("Text", dgvUnit.DataSource, "_id", True, DataSourceUpdateMode.Never))
        txtNameUnit.DataBindings.Add(New Binding("Text", dgvUnit.DataSource, "_name", True, DataSourceUpdateMode.Never))
    End Sub

    'Bàn ăn
    Private Sub AddTableFoodBindding()
        txtIDTable.DataBindings.Add(New Binding("Text", dgvTable.DataSource, "_id", True, DataSourceUpdateMode.Never))
        txtNameTable.DataBindings.Add(New Binding("Text", dgvTable.DataSource, "_name", True, DataSourceUpdateMode.Never))
    End Sub

    'Nhân viên
    Private Sub AddStaffBindding()
        txtIDStaff.DataBindings.Add(New Binding("Text", dgvStaff.DataSource, "_id", True, DataSourceUpdateMode.Never))
        txtNameStaff.DataBindings.Add(New Binding("Text", dgvStaff.DataSource, "_fullname", True, DataSourceUpdateMode.Never))
        dtpDOBStaff.DataBindings.Add(New Binding("Value", dgvStaff.DataSource, "_dateofbirth", True, DataSourceUpdateMode.Never))
        txtIDCardStaff.DataBindings.Add(New Binding("Text", dgvStaff.DataSource, "_idCard", True, DataSourceUpdateMode.Never))
        txtAddressStaff.DataBindings.Add(New Binding("Text", dgvStaff.DataSource, "_address", True, DataSourceUpdateMode.Never))
        txtPhoneStaff.DataBindings.Add(New Binding("Text", dgvStaff.DataSource, "_phone", True, DataSourceUpdateMode.Never))
    End Sub

    'Khách hàng
    Private Sub AddCustomerBindding()
        txtIDCustomer.DataBindings.Add(New Binding("Text", dgvCustomer.DataSource, "_id", True, DataSourceUpdateMode.Never))
        txtNameCustomer.DataBindings.Add(New Binding("Text", dgvCustomer.DataSource, "_name", True, DataSourceUpdateMode.Never))
        txtPhoneCustomer.DataBindings.Add(New Binding("Text", dgvCustomer.DataSource, "_phone", True, DataSourceUpdateMode.Never))
    End Sub

    Private Sub AddSupplierBindding()
        txtIDSupplier.DataBindings.Add(New Binding("Text", dgvSuplier.DataSource, "_id", True, DataSourceUpdateMode.Never))
        txtNameSupplier.DataBindings.Add(New Binding("Text", dgvSuplier.DataSource, "_name", True, DataSourceUpdateMode.Never))
        txtAddressSupplier.DataBindings.Add(New Binding("Text", dgvSuplier.DataSource, "_address", True, DataSourceUpdateMode.Never))
        txtPhoneSupplier.DataBindings.Add(New Binding("Text", dgvSuplier.DataSource, "_phone", True, DataSourceUpdateMode.Never))
        txtEmailSupplier.DataBindings.Add(New Binding("Text", dgvSuplier.DataSource, "_email", True, DataSourceUpdateMode.Never))
    End Sub

    'Danh mục
    Private Sub AddCategoryFoodBindding()
        txtIDCategory.DataBindings.Add(New Binding("Text", dgvCategory.DataSource, "_id", True, DataSourceUpdateMode.Never))
        txtNameCategory.DataBindings.Add(New Binding("Text", dgvCategory.DataSource, "_name", True, DataSourceUpdateMode.Never))
    End Sub

    'Danh mục
    Private Sub AddUnitFoodBindding()
        txtIDUnit.DataBindings.Add(New Binding("Text", dgvUnit.DataSource, "_id", True, DataSourceUpdateMode.Never))
        txtNameUnit.DataBindings.Add(New Binding("Text", dgvUnit.DataSource, "_name", True, DataSourceUpdateMode.Never))
    End Sub

    ' Lấy danh sách các món ăn
    Private Sub LoadListFood()
        foodList.DataSource = ItemsDAO._Instance.GetListFood()
    End Sub

    'Lấy danh sách danh mục
    Private Sub LoadListCategoryFood()
        categoryFoodList.DataSource = CategoriesDAO._Instance.GetListCategory()
    End Sub

    'Lấy danh sách bàn ăn
    Private Sub LoadListTableFood()
        tableFoodList.DataSource = TableDAO._Instance.GetListTable()
    End Sub

    'Lấy danh sách nhân viên
    Private Sub LoadListStaff()
        staffList.DataSource = StaffDAO._Instance.GetListStaff()
    End Sub

    'Lấy danh sách khách hàng
    Private Sub LoadListCustomer()
        customerList.DataSource = CustomerDAO._Instance.GetListCustomer()
    End Sub

    'Lấy danh sách nhà cung cấp
    Private Sub LoadListSupplier()
        supplierList.DataSource = SuppilerDAO._Instance.GetListSupplier()
        cbbSuplierObject.DataSource = SuppilerDAO._Instance.GetListSupplier()
        cbbSuplierObject.DisplayMember = "_name"
    End Sub

    'Lấy danh sách Đơn vị tính
    Private Sub LoadListUnit()
        unitList.DataSource = UnitDAO._Instance.GetListUnit()
        cbbUnitObject.DataSource = UnitDAO._Instance.GetListUnit()
        cbbUnitObject.DisplayMember = "_name"
    End Sub

    'Thêm nhân viên
    Private Sub AddStaff(fullname As String, dateofbirth As String, idCard As String, address As String, phone As String)
        If CheckEmpty(fullname) <> True Or CheckEmpty(dateofbirth) <> True Then
            StaffDAO._Instance.InsertStaff(fullname, dateofbirth, idCard, address, phone)
            MessageBox.Show("Thêm tài khoản thành công")
            LoadListStaff()

            isAddStaff = False
            Enable()
        Else
            MessageBox.Show("Không được để trống các trường dữ liệu")
        End If
    End Sub

    'Xoá nhân viên
    Private Sub DeleteStaff(id As Integer)
        If StaffDAO._Instance.DeleteStaff(id) Then
            MessageBox.Show("Xóa thành công")
            LoadListStaff()
        Else
            MessageBox.Show("Xóa thất bại")
        End If
    End Sub

    'Chỉnh sửa nhân viên
    Private Sub UpdateStaff(id As Integer, fullname As String, dateofbirth As String, idCard As String, address As String, phone As String)
        If StaffDAO._Instance.UpdateInfoStaff(id, fullname, dateofbirth, idCard, address, phone) Then
            Dim acc As Accounts = AccountDAO._Instance.GetAccountByIdStaff(id)
            If AccountDAO._Instance.UpdateUsernameAccountStaff(acc._id, idCard) Then
                MessageBox.Show("Sửa thành công")
                LoadListStaff()

                isUpdateStaff = False
                Enable()

                RaiseEvent updateAccount(Me, New AccountEvent(AccountDAO._Instance.GetAccountByIdStaff(acc._idStaff)))
            End If
        Else
            MessageBox.Show("Sửa thất bại")
        End If
    End Sub

    'Thêm bàn ăn
    Private Sub AddTableFood(name As String)
        If CheckEmpty(name) <> True Then
            If TableDAO._Instance.InsertTableFood(name) Then
                MessageBox.Show("Thêm thành công")
                LoadListTableFood()

                isAddTable = False
                Enable()

                RaiseEvent InsertTables(Me, New EventArgs())
            Else
                MessageBox.Show("Có lỗi khi thêm")
            End If
        Else
            MessageBox.Show("Không được để trống")
        End If
    End Sub

    'Sửa bàn ăn
    Private Sub EditTableFood(id As Integer, name As String)
        If CheckEmpty(name) <> True Then
            If TableDAO._Instance.UpdateTableFood(id, name) Then
                MessageBox.Show("Sửa thành công")
                LoadListTableFood()

                isUpdateTable = False
                Enable()

                RaiseEvent UpdateTables(Me, New EventArgs())
            Else
                MessageBox.Show("Có lỗi khi sửa")
            End If
        Else
            MessageBox.Show("Không được để trống")
        End If
    End Sub

    'Xóa bàn ăn
    Private Sub DeleteTable(id As Integer)
        If MessageBox.Show(String.Format("Bạn có chắc muốn xóa Bàn ăn này hay không?"), "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            If TableDAO._Instance.DeleteTableFood(id) Then
                MessageBox.Show("Xoá thành công")
                LoadListTableFood()
                RaiseEvent DeleteTables(Me, New EventArgs())
            Else
                MessageBox.Show("Có lỗi khi xoá")
            End If
        End If
    End Sub

    'Thêm danh mục
    Private Sub AddCategoryFood(name As String)
        If CheckEmpty(name) <> True Then
            If CategoriesDAO._Instance.InsertCategory(name) Then
                MessageBox.Show("Thêm thành công")
                LoadListCategoryFood()
                LoadCatagoryIntoCombobox(cbCategoryFood)

                isAddCategory = False
                Enable()

                RaiseEvent InsertCategoryFoods(Me, New EventArgs())
            Else
                MessageBox.Show("Có lỗi khi thêm")
            End If
        Else
            MessageBox.Show("Không được để trống tên bàn ăn")
        End If
    End Sub

    'Chỉnh sửa danh mục
    Private Sub EditCategory(id As Integer, name As String)
        If CheckEmpty(name) <> True Then
            If CategoriesDAO._Instance.UpdateCategory(id, name) Then
                MessageBox.Show("Sửa thành công")
                LoadListCategoryFood()
                LoadCatagoryIntoCombobox(cbCategoryFood)

                isUpdateCategory = False
                Enable()

                RaiseEvent UpdateCategoryFoods(Me, New EventArgs())
            Else
                MessageBox.Show("Có lỗi khi sửa")
            End If
        Else
            MessageBox.Show("Không được để trống tên bàn ăn")
        End If
    End Sub

    'Xóa danh mục
    Private Sub DeleteCategory(id As Integer)
        If MessageBox.Show(String.Format("Bạn có chắc muốn xóa danh mục này hay không?"), "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            CategoriesDAO._Instance.DeleteCategory(id)
            MessageBox.Show("Xoá thành công")
            LoadListCategoryFood()
            LoadCatagoryIntoCombobox(cbCategoryFood)
            RaiseEvent DeleteCategoryFoods(Me, New EventArgs())
        End If
    End Sub

    'Thêm món ăn
    Private Sub AddFood(name As String, price As Integer, categoryID As Integer)
        If CheckEmpty(name) <> True Or CheckEmpty(price) <> True Then
            If ItemsDAO._Instance.InsertFood(name, price, categoryID) Then
                MessageBox.Show("Thêm thành công")
                LoadListFood()

                isAddFood = False
                Enable()

                RaiseEvent InsertFoods(Me, New EventArgs())
            Else
                MessageBox.Show("Có lỗi khi thêm")
            End If
        Else
            MessageBox.Show("Không được để trống các trường dữ liệu")
        End If
    End Sub

    'Chỉnh sửa món ăn
    Private Sub EditFood(id As Integer, name As String, categoryID As Integer, price As Integer)
        If CheckEmpty(name) <> True Or CheckEmpty(price) <> True Then
            If ItemsDAO._Instance.UpdateFood(id, name, categoryID, price) Then
                MessageBox.Show("Sửa thành công")
                LoadListFood()

                isUpdateFood = False
                Enable()

                RaiseEvent UpdateFoods(Me, New EventArgs())
            Else
                MessageBox.Show("Có lỗi khi sửa")
            End If
        Else
            MessageBox.Show("Không được để trống các trường dữ liệu")
        End If
    End Sub

    'Xoá món ăn
    Private Sub DeleteFood(id As Integer)
        If MessageBox.Show(String.Format("Bạn có chắc muốn xóa món ăn này hay không?"), "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            If ItemsDAO._Instance.DeleteFood(id) Then
                MessageBox.Show("Xoá thành công")
                LoadListFood()
                RaiseEvent DeleteFoods(Me, New EventArgs())
            Else
                MessageBox.Show("Có lỗi khi xoá")
            End If
        End If
    End Sub

    'Thêm khách hàng
    Private Sub AddCustomer(name As String, phone As String)
        If CheckEmpty(name) <> True Then
            If CustomerDAO._Instance.InsertCustomer(name, phone) Then
                MessageBox.Show("Thêm thành công")
                LoadListCustomer()

                isAddCustomer = False
                Enable()

                RaiseEvent AddCustomers(Me, New EventArgs())
            Else
                MessageBox.Show("Có lỗi khi thêm")
            End If
        Else
            MessageBox.Show("Không được để trống tên khách hàng")
        End If
    End Sub

    'Chỉnh sửa khách hàng
    Private Sub EditCustomer(id As Integer, name As String, phone As String)
        If CheckEmpty(name) <> True Then
            If CustomerDAO._Instance.UpdateCustomer(id, name, phone) Then
                MessageBox.Show("Sửa thành công")
                LoadListCustomer()

                isUpdateFood = False
                Enable()

                RaiseEvent UpdateCustomers(Me, New EventArgs())
            Else
                MessageBox.Show("Có lỗi khi sửa")
            End If
        Else
            MessageBox.Show("Không được để trống tên khách hàng")
        End If
    End Sub

    'Xoá khách hàng
    Private Sub DeleteCustomer(id As Integer)
        If MessageBox.Show(String.Format("Bạn có chắc muốn xóa khách hàng này hay không?"), "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            If CustomerDAO._Instance.DeleteCustomer(id) Then
                MessageBox.Show("Xoá thành công")
                LoadListCustomer()
                RaiseEvent DeleteCustomers(Me, New EventArgs())
            Else
                MessageBox.Show("Có lỗi khi xoá")
            End If
        End If
    End Sub

    'Thêm Nhà cung cấp
    Private Sub AddSupplier(name As String, address As String, phone As String, email As String)
        If CheckEmpty(name) <> True Or CheckEmpty(address) <> True Then
            If SuppilerDAO._Instance.InsertSupplier(name, address, phone, email) Then
                MessageBox.Show("Thêm thành công")

                isAddSupplier = False
                Enable()

                LoadListSupplier()
            Else
                MessageBox.Show("Thêm thất bại")
            End If
        Else
            MessageBox.Show("Không được để trống tên nhà cung cấp")
        End If
    End Sub

    'Chỉnh sửa Nhà cung cấp
    Private Sub EditSupplier(id As Integer, name As String, address As String, phone As String, email As String)
        If CheckEmpty(name) <> True Then
            If SuppilerDAO._Instance.UpdateSupplier(id, name, address, phone, email) Then
                MessageBox.Show("Sửa thành công")

                isAddSupplier = False
                Enable()

                LoadListSupplier()
            Else
                MessageBox.Show("Sửa thất bại")
            End If
        Else
            MessageBox.Show("Không được để trống")
        End If
    End Sub

    'Xoá Nhà cung cấp
    Private Sub DeleteSupplier(id As Integer)
        If MessageBox.Show(String.Format("Bạn có chắc muốn xóa Nhà cung cấp này hay không?"), "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            If SuppilerDAO._Instance.DeleteSupplier(id) Then
                MessageBox.Show("Xoá thành công")
                LoadListSupplier()

            End If
        End If
    End Sub

    'Đổi tên Column
    Private Sub ChangeColumnName()
        'Bảng Món Ăn
        gridFood.Columns(0).Caption = "Mã món"
        gridFood.Columns(1).Caption = "Tên món"
        gridFood.Columns(2).Caption = "Giá tiền"
        gridFood.Columns(3).Caption = "Mã danh mục"
        gridFood.Columns(4).Caption = "Đã xoá"
        gridFood.BestFitColumns()

        'Bảng Danh Mục
        gridCategory.Columns(0).Caption = "Mã danh mục"
        gridCategory.Columns(1).Caption = "Tên danh mục"
        gridCategory.BestFitColumns()

        'Bảng Bàn Ăn
        gridTable.Columns(0).Caption = "Mã bàn"
        gridTable.Columns(1).Caption = "Tên bàn"
        gridTable.Columns(2).Caption = "Trạng thái"
        gridTable.Columns(3).Caption = "Đã xoá"
        gridTable.BestFitColumns()

        'Bảng Nhân Viên
        gridStaff.Columns(0).Caption = "Mã nhân viên"
        gridStaff.Columns(1).Caption = "Tên nhân viên"
        gridStaff.Columns(2).Caption = "Ngày sinh"
        gridStaff.Columns(3).Caption = "CMND/CCCD"
        gridStaff.Columns(4).Caption = "Địa Chỉ"
        gridStaff.Columns(5).Caption = "SĐT"
        gridStaff.Columns(6).Caption = "Đã xoá"
        gridStaff.BestFitColumns()

        'Bảng Danh Mục
        gridCustomer.Columns(0).Caption = "Mã khách hàng"
        gridCustomer.Columns(1).Caption = "Tên khách hàng"
        gridCustomer.Columns(2).Caption = "SĐT"
        gridCustomer.Columns(3).Caption = "Ngày tạo"
        gridCustomer.Columns(4).Caption = "Đã Xoá"
        gridCustomer.BestFitColumns()

        'Bảng Nhà cung cấp
        gridSupplier.Columns(0).Caption = "Mã nhà cung cấp"
        gridSupplier.Columns(1).Caption = "Tên nhà cung cấp"
        gridSupplier.Columns(2).Caption = "Địa chỉ"
        gridSupplier.Columns(3).Caption = "SĐT"
        gridSupplier.Columns(4).Caption = "Email"
        gridSupplier.Columns(5).Caption = "Đã Xoá"
        gridSupplier.BestFitColumns()
    End Sub

    'Mở/Đóng các items
    Private Sub Enable()
        If isAddTable = True Or isUpdateTable = True Then
            txtNameTable.Enabled = True

            EnableButton(False, True, btnAddTable, btnEditTable, btnDeleteTable, btnSaveTable, btnCancelTable)

            If isAddTable = True Then
                txtNameTable.Text = ""
                txtIDTable.Text = "Mã bàn được lấy tự động"
            End If
        ElseIf isAddTable = False Or isUpdateTable = False Then
            txtNameTable.Enabled = False

            EnableButton(True, False, btnAddTable, btnEditTable, btnDeleteTable, btnSaveTable, btnCancelTable)
        End If

        If isAddCategory = True Or isUpdateCategory = True Then
            txtNameCategory.Enabled = True
            EnableButton(False, True, btnAddCategory, btnEditCategory, btnDeleteCategory, btnSaveCategory, btnCancelCategory)

            If isAddCategory = True Then
                txtNameCategory.Text = ""
                txtIDCategory.Text = "Mã danh mục được lấy tự động"
            End If
        ElseIf isAddCategory = False Or isUpdateCategory = False Then
            txtNameCategory.Enabled = False
            EnableButton(True, False, btnAddCategory, btnEditCategory, btnDeleteCategory, btnSaveCategory, btnCancelCategory)
        End If

        If isAddFood = True Or isUpdateFood = True Then
            txtNameFood.Enabled = True
            cbCategoryFood.Enabled = True
            nmPriceFood.Enabled = True

            EnableButton(False, True, btnAddFood, btnEditFood, btnDeleteFood, btnSaveFood, btnCancelFood)

            If isAddFood = True Then
                txtNameFood.Text = ""
                txtIDFood.Text = "Mã thức ăn được lấy tự động"
            End If
        ElseIf isAddFood = False Or isUpdateFood = False Then
            txtNameFood.Enabled = False
            cbCategoryFood.Enabled = False
            nmPriceFood.Enabled = False
            EnableButton(True, False, btnAddFood, btnEditFood, btnDeleteFood, btnSaveFood, btnCancelFood)
        End If

        If isAddCustomer = True Or isUpdateCustomer = True Then
            txtNameCustomer.Enabled = True
            txtPhoneCustomer.Enabled = True

            EnableButton(False, True, btnAddCustomer, btnEditCustomer, btnDeleteCustomer, btnSaveCustomer, btnCancelCustomer)

            If isAddCustomer = True Then
                txtNameCustomer.Text = ""
                txtPhoneCustomer.Text = ""
                txtIDCustomer.Text = "Mã khách hàng được lấy tự động"
            End If
        ElseIf isAddCustomer = False Or isUpdateCustomer = False Then
            txtNameCustomer.Enabled = False
            txtPhoneCustomer.Enabled = False

            EnableButton(True, False, btnAddCustomer, btnEditCustomer, btnDeleteCustomer, btnSaveCustomer, btnCancelCustomer)
        End If

        If isAddStaff = True Or isUpdateStaff = True Then
            txtNameStaff.Enabled = True
            dtpDOBStaff.Enabled = True
            txtAddressStaff.Enabled = True
            txtIDCardStaff.Enabled = True
            txtPhoneStaff.Enabled = True

            EnableButton(False, True, btnAddStaff, btnEditStaff, btnDeleteStaff, btnSaveStaff, btnCancelStaff)
            btnResetPass.Enabled = False

            If isAddStaff = True Then
                txtNameStaff.Text = ""
                txtAddressStaff.Text = ""
                txtIDCardStaff.Text = ""
                txtPhoneStaff.Text = ""
                txtIDStaff.Text = "Mã nhân viên được lấy tự động"
            End If
        ElseIf isAddStaff = False Or isUpdateStaff = False Then
            txtNameStaff.Enabled = False
            dtpDOBStaff.Enabled = False
            txtAddressStaff.Enabled = False
            txtIDCardStaff.Enabled = False
            txtPhoneStaff.Enabled = False

            EnableButton(True, False, btnAddStaff, btnEditStaff, btnDeleteStaff, btnSaveStaff, btnCancelStaff)
            btnResetPass.Enabled = True
        End If

        If isAddSupplier = True Or isUpdateSupplier = True Then
            txtNameSupplier.Enabled = True
            txtAddressSupplier.Enabled = True
            txtPhoneSupplier.Enabled = True
            txtEmailSupplier.Enabled = True

            EnableButton(False, True, btnAddSupplier, btnEditSupplier, btnDeleteSupplier, btnSaveSupplier, btnCancelSupplier)

            If isAddCustomer = True Then
                txtNameSupplier.Text = ""
                txtAddressSupplier.Text = ""
                txtPhoneSupplier.Text = ""
                txtEmailSupplier.Text = ""
                txtIDSupplier.Text = "Mã nhà cung cấp được lấy tự động"
            End If
        ElseIf isAddSupplier = False Or isUpdateSupplier = False Then
            txtNameSupplier.Enabled = False
            txtAddressSupplier.Enabled = False
            txtPhoneSupplier.Enabled = False
            txtEmailSupplier.Enabled = False

            EnableButton(True, False, btnAddSupplier, btnEditSupplier, btnDeleteSupplier, btnSaveSupplier, btnCancelSupplier)
        End If
    End Sub

    'Mở các button
    Private Sub EnableButton(enableAED As Boolean, enableSC As Boolean,
                             buttonAdd As DevExpress.XtraEditors.SimpleButton,
                             buttonEdit As DevExpress.XtraEditors.SimpleButton,
                             buttonDelete As DevExpress.XtraEditors.SimpleButton,
                             buttonSave As DevExpress.XtraEditors.SimpleButton,
                             buttonCancel As DevExpress.XtraEditors.SimpleButton)

        buttonSave.Enabled = enableSC
        buttonCancel.Enabled = enableSC

        buttonAdd.Enabled = enableAED
        buttonEdit.Enabled = enableAED
        buttonDelete.Enabled = enableAED
    End Sub

#End Region

#Region "Bắt sự kiện"

    'Nút thêm Món Ăn
    Private Sub btnAddFood_Click(sender As Object, e As EventArgs) Handles btnAddFood.Click
        isAddFood = True
        isUpdateFood = False

        Enable()
    End Sub

    'Nút Cập nhật Món ăn
    Private Sub btnEditFood_Click(sender As Object, e As EventArgs) Handles btnEditFood.Click
        isAddFood = False
        isUpdateFood = True

        Enable()
    End Sub

    'Nút Xóa Món Ăn
    Private Sub btnDeleteFood_Click(sender As Object, e As EventArgs) Handles btnDeleteFood.Click
        Dim id As Integer = Convert.ToInt32(txtIDFood.Text)
        DeleteFood(id)
    End Sub

    'Nút Lưu Món ăn
    Private Sub btnSaveFood_Click(sender As Object, e As EventArgs) Handles btnSaveFood.Click
        Dim name As String = txtNameFood.Text
        Dim categoryID As Integer = (TryCast(cbCategoryFood.SelectedItem, Categories))._id
        Dim price As Integer = Convert.ToInt32(nmPriceFood.Value)

        If isAddFood = True Then
            AddFood(name, price, categoryID)
        ElseIf isUpdateFood = True Then
            Dim id As Integer = Convert.ToInt32(txtIDFood.Text)
            EditFood(id, name, categoryID, price)
        End If
    End Sub

    'Nút Huỷ Món ăn
    Private Sub btnCancelFood_Click(sender As Object, e As EventArgs) Handles btnCancelFood.Click
        isAddFood = False
        isUpdateFood = False

        Enable()
    End Sub

    'Nút Thêm Danh Mục
    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click
        isAddCategory = True
        isUpdateCategory = False

        Enable()
    End Sub

    'Nút Cập nhật Danh Mục
    Private Sub btnEditCategory_Click(sender As Object, e As EventArgs) Handles btnEditCategory.Click
        isAddCategory = False
        isUpdateCategory = True

        Enable()
    End Sub

    'Nút Xóa Danh Mục
    Private Sub btnDeleteCategory_Click(sender As Object, e As EventArgs) Handles btnDeleteCategory.Click
        Dim id As Integer = Convert.ToInt32(txtIDCategory.Text)
        DeleteCategory(id)
    End Sub

    'Nút Lưu Danh Mục
    Private Sub btnSaveCategory_Click(sender As Object, e As EventArgs) Handles btnSaveCategory.Click
        Dim name As String = txtNameCategory.Text

        If isAddCategory = True Then
            AddCategoryFood(name)
        ElseIf isUpdateCategory = True Then
            Dim id As Integer = Convert.ToInt32(txtIDCategory.Text)
            EditCategory(id, name)
        End If
    End Sub

    'Nút Huỷ Danh Mục
    Private Sub btnCancelCategory_Click(sender As Object, e As EventArgs) Handles btnCancelCategory.Click
        isAddCategory = False
        isUpdateCategory = False

        Enable()
    End Sub

    'Nút Thêm Bàn Ăn
    Private Sub btnAddTable_Click(sender As Object, e As EventArgs) Handles btnAddTable.Click
        isAddTable = True
        isUpdateTable = False

        Enable()
    End Sub

    'Nút Câp nhật Bàn Ăn
    Private Sub btnEditTable_Click(sender As Object, e As EventArgs) Handles btnEditTable.Click
        isAddTable = False
        isUpdateTable = True

        Enable()
    End Sub

    'Nút Xóa Bàn Ăn
    Private Sub btnDeleteTable_Click(sender As Object, e As EventArgs) Handles btnDeleteTable.Click
        Dim id As Integer = Convert.ToInt32(txtIDTable.Text)
        DeleteTable(id)
    End Sub

    'Nút Lưu Bàn Ăn
    Private Sub btnSaveTable_Click(sender As Object, e As EventArgs) Handles btnSaveTable.Click
        Dim name As String = txtNameTable.Text

        If isAddTable = True Then
            AddTableFood(name)
        ElseIf isUpdateTable = True Then
            Dim id As Integer = Convert.ToInt32(txtIDTable.Text)
            EditTableFood(id, name)
        End If
    End Sub

    'Nút Huỷ Bàn Ăn
    Private Sub btnCancelTable_Click(sender As Object, e As EventArgs) Handles btnCancelTable.Click
        isAddTable = False
        isUpdateTable = False

        Enable()
    End Sub

    'Thêm khách hàng
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        isAddCustomer = True
        isUpdateCustomer = False

        Enable()
    End Sub

    'Lưu khách hàng
    Private Sub btnSaveCustomer_Click(sender As Object, e As EventArgs) Handles btnSaveCustomer.Click
        Dim name As String = txtNameCustomer.Text
        Dim phone As String = txtPhoneCustomer.Text

        If isAddCustomer = True Then
            AddCustomer(name, phone)
        ElseIf isUpdateCustomer = True Then
            Dim id As Integer = Convert.ToInt32(txtIDCustomer.Text)
            EditCustomer(id, name, phone)
        End If
    End Sub

    'Chỉnh sửa khách hàng
    Private Sub btnEditCustomer_Click(sender As Object, e As EventArgs) Handles btnEditCustomer.Click
        isAddCustomer = False
        isUpdateCustomer = True

        Enable()
    End Sub

    'Xoá khách hàng
    Private Sub btnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles btnDeleteCustomer.Click
        Dim id As Integer = Convert.ToInt32(txtIDCustomer.Text)
        DeleteCustomer(id)
    End Sub

    'Nút huỷ quy trình khách hàng
    Private Sub btnCancelCustomer_Click(sender As Object, e As EventArgs) Handles btnCancelCustomer.Click
        isAddCustomer = False
        isUpdateCustomer = False

        Enable()
    End Sub

    'Nút Tìm Kiếm Món Ăn
    Private Sub btnSearchFood_Click(sender As Object, e As EventArgs) Handles btnSearchFood.Click
        foodList.DataSource = SearchFoodByName(txtSearchFood.Text)
    End Sub

    'Nút Thêm nhân viên
    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click
        isAddStaff = True
        isUpdateStaff = False

        Enable()
    End Sub

    'Thay đổi tên hiển thị danh mục khi ID món ăn thay đổi
    Private Sub txtIDFood_TextChanged(sender As Object, e As EventArgs) Handles txtIDFood.TextChanged
        Try
            If gridFood.SelectedRowsCount > 0 Then
                Dim owningRow As Integer() = gridFood.GetSelectedRows()
                Dim id As Integer = gridFood.GetRowCellValue(owningRow(0), gridFood.Columns(3))

                Dim category As Categories = CategoriesDAO._Instance.GetCategoryByID(id)
                cbCategoryFood.SelectedItem = category

                Dim index As Integer = -1
                Dim i As Integer = 0

                For Each item As Categories In cbCategoryFood.Items
                    If item._id = category._id Then
                        index = i
                        Exit For
                    End If

                    i += 1
                Next

                cbCategoryFood.SelectedIndex = index
            End If

        Catch
        End Try
    End Sub

    'Thay đổi text combobox giới tính
    Private Sub txtIDStaff_TextChanged(sender As Object, e As EventArgs) Handles txtIDStaff.TextChanged
        Try
            If gridStaff.SelectedRowsCount > 0 Then
                Dim owningRow As Integer() = gridStaff.GetSelectedRows()
                Dim id As Integer = gridStaff.GetRowCellValue(owningRow(0), gridStaff.Columns(0))

                Dim staff As Staffs = StaffDAO._Instance.GetInfoStaffById(id)
            End If
        Catch
        End Try
    End Sub

    'Nút chỉnh sửa staff
    Private Sub btnEditStaff_Click(sender As Object, e As EventArgs) Handles btnEditStaff.Click
        isAddStaff = False
        isUpdateStaff = True

        Enable()
    End Sub

    'Nút Thay đổi mật khẩu
    Private Sub btnResetPass_Click(sender As Object, e As EventArgs) Handles btnResetPass.Click
        If MessageBox.Show(String.Format("Bạn có chắc muốn đổi mật khẩu cho tài khoản này hay không?"), "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            Dim username As String = txtIDCardStaff.Text
            If (AccountDAO._Instance.ResetPass(username)) Then
                MessageBox.Show("Mật khẩu của tài khoản này đã được đặt lại")
            Else
                MessageBox.Show("Có lỗi xảy ra")
            End If
        End If
    End Sub

    'Nút xoá nhân viên
    Private Sub btnDeleteStaff_Click(sender As Object, e As EventArgs) Handles btnDeleteStaff.Click
        If MessageBox.Show(String.Format("Bạn có chắc muốn xóa nhân viên này hay không?"), "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            Dim id As Integer = Convert.ToInt32(txtIDStaff.Text)
            If id = _idStaff Then
                MessageBox.Show("Không nên xóa bạn chứ!!!")
            Else
                If (StaffDAO._Instance.DeleteStaff(id)) Then
                    MessageBox.Show("Xóa thành công")
                    LoadListStaff()
                Else
                    MessageBox.Show("Có lỗi khi xóa")
                End If
            End If
        End If
    End Sub

    'Nút lưu nhân viên
    Private Sub btnSaveStaff_Click(sender As Object, e As EventArgs) Handles btnSaveStaff.Click
        Dim fullname As String = txtNameStaff.Text
        Dim dob As String = dtpDOBStaff.Value.Year & "-" & dtpDOBStaff.Value.Month & "-" & dtpDOBStaff.Value.Day

        Dim idCard As String = txtIDCardStaff.Text
        Dim address As String = txtAddressStaff.Text
        Dim phone As String = txtPhoneStaff.Text

        If isAddStaff = True Then
            AddStaff(fullname, dob, idCard, address, phone)
        ElseIf isUpdateStaff = True Then
            Dim id As Integer = Convert.ToInt32(txtIDStaff.Text)
            UpdateStaff(id, fullname, dob, idCard, address, phone)
        End If
    End Sub

    'Nút huỷ nhân viên
    Private Sub btnCancelStaff_Click(sender As Object, e As EventArgs) Handles btnCancelStaff.Click
        isAddStaff = False
        isUpdateStaff = False

        Enable()
    End Sub

    'Sự kiện không cho nhập chữ

    Private Sub txtPhoneCustomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneCustomer.KeyPress
        CheckInputOnlyNumber(e)
    End Sub

    Private Sub txtIDCardStaff_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDCardStaff.KeyPress
        CheckInputOnlyNumber(e)
    End Sub

    Private Sub txtPhoneStaff_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneStaff.KeyPress
        CheckInputOnlyNumber(e)
    End Sub

#End Region

#Region "CUSTOM EVENT"

    'Thêm sửa xóa Thức Ăn

    Public Custom Event InsertFoods As EventHandler
        AddHandler(value As EventHandler)
            Me.Events.AddHandler("InsertFood", value)
        End AddHandler

        RemoveHandler(value As EventHandler)
            Me.Events.RemoveHandler("InsertFood", value)
        End RemoveHandler

        RaiseEvent(sender As Object, e As System.EventArgs)
            CType(Me.Events("InsertFood"), EventHandler).Invoke(sender, e)
        End RaiseEvent
    End Event

    Public Custom Event UpdateFoods As EventHandler
        AddHandler(value As EventHandler)
            Me.Events.AddHandler("UpdateFood", value)
        End AddHandler

        RemoveHandler(value As EventHandler)
            Me.Events.RemoveHandler("UpdateFood", value)
        End RemoveHandler

        RaiseEvent(sender As Object, e As System.EventArgs)
            CType(Me.Events("UpdateFood"), EventHandler).Invoke(sender, e)
        End RaiseEvent
    End Event

    Public Custom Event DeleteFoods As EventHandler
        AddHandler(value As EventHandler)
            Me.Events.AddHandler("DeleteFood", value)
        End AddHandler

        RemoveHandler(value As EventHandler)
            Me.Events.RemoveHandler("DeleteFood", value)
        End RemoveHandler

        RaiseEvent(sender As Object, e As System.EventArgs)
            CType(Me.Events("DeleteFood"), EventHandler).Invoke(sender, e)
        End RaiseEvent
    End Event

    'Thêm sửa xóa Danh Mục

    Public Custom Event InsertCategoryFoods As EventHandler
        AddHandler(value As EventHandler)
            Me.Events.AddHandler("InsertCategoryFood", value)
        End AddHandler

        RemoveHandler(value As EventHandler)
            Me.Events.RemoveHandler("InsertCategoryFood", value)
        End RemoveHandler

        RaiseEvent(sender As Object, e As System.EventArgs)
            CType(Me.Events("InsertCategoryFood"), EventHandler).Invoke(sender, e)
        End RaiseEvent
    End Event

    Public Custom Event UpdateCategoryFoods As EventHandler
        AddHandler(value As EventHandler)
            Me.Events.AddHandler("UpdateCategoryFood", value)
        End AddHandler

        RemoveHandler(value As EventHandler)
            Me.Events.RemoveHandler("UpdateCategoryFood", value)
        End RemoveHandler

        RaiseEvent(sender As Object, e As System.EventArgs)
            CType(Me.Events("UpdateCategoryFood"), EventHandler).Invoke(sender, e)
        End RaiseEvent
    End Event

    Public Custom Event DeleteCategoryFoods As EventHandler
        AddHandler(value As EventHandler)
            Me.Events.AddHandler("DeleteCategoryFood", value)
        End AddHandler

        RemoveHandler(value As EventHandler)
            Me.Events.RemoveHandler("DeleteCategoryFood", value)
        End RemoveHandler

        RaiseEvent(sender As Object, e As System.EventArgs)
            CType(Me.Events("DeleteCategoryFood"), EventHandler).Invoke(sender, e)
        End RaiseEvent
    End Event

    'Thêm sửa xóa Bàn Ăn

    Public Custom Event InsertTables As EventHandler
        AddHandler(value As EventHandler)
            Me.Events.AddHandler("InsertTable", value)
        End AddHandler

        RemoveHandler(value As EventHandler)
            Me.Events.RemoveHandler("InsertTable", value)
        End RemoveHandler

        RaiseEvent(sender As Object, e As System.EventArgs)
            CType(Me.Events("InsertTable"), EventHandler).Invoke(sender, e)
        End RaiseEvent
    End Event

    Public Custom Event UpdateTables As EventHandler
        AddHandler(value As EventHandler)
            Me.Events.AddHandler("UpdateTable", value)
        End AddHandler

        RemoveHandler(value As EventHandler)
            Me.Events.RemoveHandler("UpdateTable", value)
        End RemoveHandler

        RaiseEvent(sender As Object, e As System.EventArgs)
            CType(Me.Events("UpdateTable"), EventHandler).Invoke(sender, e)
        End RaiseEvent
    End Event

    Public Custom Event DeleteTables As EventHandler
        AddHandler(value As EventHandler)
            Me.Events.AddHandler("DeleteTable", value)
        End AddHandler

        RemoveHandler(value As EventHandler)
            Me.Events.RemoveHandler("DeleteTable", value)
        End RemoveHandler

        RaiseEvent(sender As Object, e As System.EventArgs)
            CType(Me.Events("DeleteTable"), EventHandler).Invoke(sender, e)
        End RaiseEvent
    End Event

    'Thêm sửa xoá khách hàng

    Public Custom Event AddCustomers As EventHandler
        AddHandler(value As EventHandler)
            Me.Events.AddHandler("addCustomer", value)
        End AddHandler

        RemoveHandler(value As EventHandler)
            Me.Events.RemoveHandler("addCustomer", value)
        End RemoveHandler

        RaiseEvent(sender As Object, e As System.EventArgs)
            CType(Me.Events("addCustomer"), EventHandler).Invoke(sender, e)
        End RaiseEvent
    End Event

    Public Custom Event UpdateCustomers As EventHandler
        AddHandler(value As EventHandler)
            Me.Events.AddHandler("updateCustomer", value)
        End AddHandler

        RemoveHandler(value As EventHandler)
            Me.Events.RemoveHandler("updateCustomer", value)
        End RemoveHandler

        RaiseEvent(sender As Object, e As System.EventArgs)
            CType(Me.Events("updateCustomer"), EventHandler).Invoke(sender, e)
        End RaiseEvent
    End Event

    Public Custom Event DeleteCustomers As EventHandler
        AddHandler(value As EventHandler)
            Me.Events.AddHandler("deleteCustomer", value)
        End AddHandler

        RemoveHandler(value As EventHandler)
            Me.Events.RemoveHandler("deleteCustomer", value)
        End RemoveHandler

        RaiseEvent(sender As Object, e As System.EventArgs)
            CType(Me.Events("deleteCustomer"), EventHandler).Invoke(sender, e)
        End RaiseEvent
    End Event

    'Chỉnh sửa nhân viên

    'Sự kiện ở đây được định nghĩa là nếu có chỉnh sửa từ phía form bên đây thì form bán hàng sẽ thay đổi theo
    Public Custom Event updateAccount As EventHandler(Of AccountEvent)
        AddHandler(value As EventHandler(Of AccountEvent))
            Me.Events.AddHandler("updatedAccount", value)
        End AddHandler

        RemoveHandler(value As EventHandler(Of AccountEvent))
            Me.Events.RemoveHandler("updatedAccount", value)
        End RemoveHandler

        RaiseEvent(sender As Object, e As System.EventArgs)
            CType(Me.Events("updatedAccount"), EventHandler(Of AccountEvent)).Invoke(sender, e)
        End RaiseEvent
    End Event

#End Region

    Private Sub btnAddObjectInput_Click(sender As Object, e As EventArgs) Handles btnAddObjectInput.Click
        tcInputOutput.SelectedTabPage = tpObject
    End Sub

    Private Sub btnAddSupplierObject_Click(sender As Object, e As EventArgs) Handles btnAddSupplierObject.Click
        tcInputOutput.SelectedTabPage = tpSupplier
    End Sub

    Private Function validateEmail(emailAddress) As Boolean
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnAddSuplier_Click(sender As Object, e As EventArgs) Handles btnAddSupplier.Click
        isAddSupplier = True
        isUpdateSupplier = False

        Enable()
    End Sub

    Private Sub txtPhoneSuplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneSupplier.KeyPress
        CheckInputOnlyNumber(e)
    End Sub

    Private Sub CheckInputOnlyNumber(e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnEditSupplier_Click(sender As Object, e As EventArgs) Handles btnEditSupplier.Click
        isAddSupplier = False
        isUpdateSupplier = True

        Enable()
    End Sub

    Private Sub btnSaveSupplier_Click(sender As Object, e As EventArgs) Handles btnSaveSupplier.Click
        Dim name As String = txtNameSupplier.Text
        Dim address As String = txtAddressSupplier.Text
        Dim phone As String = txtPhoneSupplier.Text
        Dim email As String = txtEmailSupplier.Text

        If isAddSupplier = True Then
            AddSupplier(name, address, phone, email)
        ElseIf isUpdateSupplier = True Then
            Dim id As Integer = Convert.ToInt32(txtIDSupplier.Text)
            EditSupplier(id, name, address, phone, email)
        End If
    End Sub

    Private Sub btnCancelSupplier_Click(sender As Object, e As EventArgs) Handles btnCancelSupplier.Click
        isAddSupplier = False
        isUpdateSupplier = False

        Enable()
    End Sub

    Private Sub btnDeleteSupplier_Click(sender As Object, e As EventArgs) Handles btnDeleteSupplier.Click
        Dim id As Integer = Convert.ToInt32(txtIDSupplier.Text)
        DeleteSupplier(id)
    End Sub

    Private Sub btnAddUnitObject_Click(sender As Object, e As EventArgs) Handles btnAddUnitObject.Click
        tcInputOutput.SelectedTabPage = tpUnit
    End Sub
End Class