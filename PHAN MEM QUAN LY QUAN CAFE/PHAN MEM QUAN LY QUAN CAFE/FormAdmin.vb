Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO

Public Class FormAdmin

#Region "KHỞI TẠO"

    Private foodList As BindingSource = New BindingSource()
    Private categoryFoodList As BindingSource = New BindingSource()
    Private tableFoodList As BindingSource = New BindingSource()
    Private staffList As BindingSource = New BindingSource()

    Public loginAccount As Accounts

    Public Sub New()
        InitializeComponent()
        LoadData()
    End Sub

#End Region

#Region "PHƯƠNG THỨC"

    'Load Data
    Private Sub LoadData()
        dgvFood.DataSource = foodList
        dgvCategory.DataSource = categoryFoodList
        dgvTable.DataSource = tableFoodList
        dgvStaff.DataSource = staffList
        'LoadDateTimePickerBill()
        'LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value)
        LoadListFood()
        AddFoodBindding()
        LoadCatagoryIntoCombobox(cbCategoryFood)
        LoadListCategoryFood()
        AddCategoryFoodBindding()
        LoadListTableFood()
        AddTableFoodBindding()
        LoadStaff()
        AddStaffBindding()

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


#Region "Đưa dữ liệu lên các textbox tương ứng"

    'Thức ăn
    Private Sub AddFoodBindding()
        txtIDFood.DataBindings.Add(New Binding("Text", dgvFood.DataSource, "_id", True, DataSourceUpdateMode.Never))
        txtNameFood.DataBindings.Add(New Binding("Text", dgvFood.DataSource, "_name", True, DataSourceUpdateMode.Never))
        nmPriceFood.DataBindings.Add(New Binding("Value", dgvFood.DataSource, "_price", True, DataSourceUpdateMode.Never))
    End Sub

    'Danh mục
    Private Sub AddCategoryFoodBindding()
        txtIDCategory.DataBindings.Add(New Binding("Text", dgvFood.DataSource, "_id", True, DataSourceUpdateMode.Never))
        txtNameCategory.DataBindings.Add(New Binding("Text", dgvCategory.DataSource, "_name", True, DataSourceUpdateMode.Never))
    End Sub

    'Bàn ăn
    Private Sub AddTableFoodBindding()
        txtIDTable.DataBindings.Add(New Binding("Text", dgvFood.DataSource, "_id", True, DataSourceUpdateMode.Never))
        txtTableName.DataBindings.Add(New Binding("Text", dgvTable.DataSource, "_name", True, DataSourceUpdateMode.Never))
        txtStatusTable.DataBindings.Add(New Binding("Text", dgvTable.DataSource, "_status", True, DataSourceUpdateMode.Never))
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

#End Region

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
    Private Sub LoadStaff()
        staffList.DataSource = StaffDAO._Instance.GetListStaff()
    End Sub

    'Thêm nhân viên
    Private Sub AddStaff(fullname As String, dateofbirth As String, gender As Integer, idCard As String, address As String, phone As String)
        If StaffDAO._Instance.InsertStaff(fullname, dateofbirth, gender, idCard, address, phone) Then
            MessageBox.Show("Thêm tài khoản thành công")
        Else
            MessageBox.Show("Thêm tài khoản thất bại")
        End If

        LoadStaff()
    End Sub

    Private Sub AddTableFood(name As String)
        If TableDAO._Instance.InsertTableFood(name) Then
            MessageBox.Show("Thêm thành công")
            LoadListTableFood()
            RaiseEvent InsertTables(Me, New EventArgs())
        Else
            MessageBox.Show("Có lỗi khi thêm")
        End If
    End Sub

    'Sửa bàn ăn
    Private Sub EditTableFood(id As Integer, name As String)
        If TableDAO._Instance.UpdateTableFood(id, name) Then
            MessageBox.Show("Sửa thành công")
            LoadListTableFood()
            RaiseEvent UpdateTables(Me, New EventArgs())
        Else
            MessageBox.Show("Có lỗi khi sửa")
        End If
    End Sub

    'Xóa bàn ăn
    Private Sub DeleteTable(id As Integer)
        If TableDAO._Instance.DeleteTableFood(id) Then
            MessageBox.Show("Xoá thành công")
            LoadListTableFood()
            RaiseEvent DeleteTables(Me, New EventArgs())
        Else
            MessageBox.Show("Có lỗi khi xoá")
        End If
    End Sub

    'Thêm danh mục
    Private Sub AddCategoryFood(name As String)
        If CategoriesDAO._Instance.InsertCategory(name) Then
            MessageBox.Show("Thêm thành công")
            LoadListCategoryFood()
            LoadCatagoryIntoCombobox(cbCategoryFood)
            RaiseEvent InsertCategoryFoods(Me, New EventArgs())
        Else
            MessageBox.Show("Có lỗi khi thêm")
        End If
    End Sub

    ' Chỉnh sửa danh mục
    Private Sub EditCategory(id As Integer, name As String)
        If CategoriesDAO._Instance.UpdateCategory(id, name) Then
            MessageBox.Show("Sửa thành công")
            LoadListCategoryFood()
            LoadCatagoryIntoCombobox(cbCategoryFood)
            RaiseEvent UpdateCategoryFoods(Me, New EventArgs())
        Else
            MessageBox.Show("Có lỗi khi sửa")
        End If
    End Sub

    'Xóa danh mục
    Private Sub DeleteCategory(id As Integer)
        If CategoriesDAO._Instance.DeleteCategory(id) Then
            MessageBox.Show("Xoá thành công")
            LoadListCategoryFood()
            LoadCatagoryIntoCombobox(cbCategoryFood)
            RaiseEvent DeleteCategoryFoods(Me, New EventArgs())
        Else
            MessageBox.Show("Có lỗi khi xoá")
        End If
    End Sub

    'Đổi tên Column
    Private Sub ChangeColumnName()
        'Bảng Món Ăn
        gridFood.Columns(0).Caption = "Mã món"
        gridFood.Columns(1).Caption = "Tên món"
        gridFood.Columns(2).Caption = "Mã danh mục"
        gridFood.Columns(3).Caption = "Giá tiền"

        'Bảng Danh Mục
        gridCategory.Columns(0).Caption = "Mã danh mục"
        gridCategory.Columns(1).Caption = "Tên danh mục"

        'Bảng Bàn Ăn
        gridTable.Columns(0).Caption = "Mã bàn"
        gridTable.Columns(1).Caption = "Tên bàn"
        gridTable.Columns(2).Caption = "Trạng thái"

        'Bảng Nhân Viên
        gridStaff.Columns(0).Caption = "Mã nhân viên"
        gridStaff.Columns(1).Caption = "Tên nhân viên"
        gridStaff.Columns(2).Caption = "Ngày sinh"
        gridStaff.Columns(3).Caption = "Giớ tính"
        gridStaff.Columns(4).Caption = "CMND/CCCD"
        gridStaff.Columns(5).Caption = "Địa Chỉ"
        gridStaff.Columns(6).Caption = "SĐT"
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

#End Region

#Region "Bắt sự kiện"

    'Nút thêm Món Ăn
    Private Sub btnAddFood_Click(sender As Object, e As EventArgs) Handles btnAddFood.Click
        Dim name As String = txtNameFood.Text
        Dim categoryID As Integer = (TryCast(cbCategoryFood.SelectedItem, Categories))._id
        Dim price As Single = CSng(nmPriceFood.Value)

        If ItemsDAO._Instance.InsertFood(name, categoryID, price) Then
            MessageBox.Show("Thêm thành công")
            LoadListFood()
            RaiseEvent InsertFoods(Me, New EventArgs())
        Else
            MessageBox.Show("Có lỗi khi thêm")
        End If
    End Sub

    'Nút Cập nhật Món ăn
    Private Sub btnEditFood_Click(sender As Object, e As EventArgs) Handles btnEditFood.Click
        Dim name As String = txtNameFood.Text
        Dim categoryID As Integer = (TryCast(cbCategoryFood.SelectedItem, Categories))._id
        Dim price As Single = CSng(nmPriceFood.Value)
        Dim id As Integer = Convert.ToInt32(txtIDFood.Text)

        If ItemsDAO._Instance.UpdateFood(id, name, categoryID, price) Then
            MessageBox.Show("Sửa thành công")
            LoadListFood()
            RaiseEvent UpdateFoods(Me, New EventArgs())
        Else
            MessageBox.Show("Có lỗi khi sửa")
        End If
    End Sub

    'Nút Xóa Món Ăn
    Private Sub btnDeleteFood_Click(sender As Object, e As EventArgs) Handles btnDeleteFood.Click
        Dim id As Integer = Convert.ToInt32(txtIDFood.Text)

        If ItemsDAO._Instance.DeleteFood(id) Then
            MessageBox.Show("Xoá thành công")
            LoadListFood()
            RaiseEvent DeleteFoods(Me, New EventArgs())
        Else
            MessageBox.Show("Có lỗi khi xoá")
        End If
    End Sub

    'Nút thêm Danh Mục
    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click
        Dim name As String = txtNameCategory.Text
        AddCategoryFood(name)
    End Sub

    'Nút Cập nhật Danh Mục
    Private Sub btnEditCategory_Click(sender As Object, e As EventArgs) Handles btnEditCategory.Click
        Dim name As String = txtNameCategory.Text
        Dim id As Integer = Convert.ToInt32(txtIDCategory.Text)
        EditCategory(id, name)
    End Sub

    'Nút Xóa Danh Mục
    Private Sub btnDeleteCategory_Click(sender As Object, e As EventArgs) Handles btnDeleteCategory.Click
        Dim id As Integer = Convert.ToInt32(txtIDCategory.Text)
        DeleteCategory(id)
    End Sub

    'Nút Xóa Bàn Ăn
    Private Sub btnDeleteTable_Click(sender As Object, e As EventArgs) Handles btnDeleteTable.Click
        Dim id As Integer = Convert.ToInt32(txtIDTable.Text)
        DeleteTable(id)
    End Sub

    'Nút Câp nhật Bàn Ăn
    Private Sub btnEditTable_Click(sender As Object, e As EventArgs) Handles btnEditTable.Click
        Dim name As String = txtTableName.Text
        Dim id As Integer = Convert.ToInt32(txtIDTable.Text)
        EditTableFood(id, name)
    End Sub

    'Nút Thêm Bàn Ăn
    Private Sub btnAddTable_Click(sender As Object, e As EventArgs) Handles btnAddTable.Click
        Dim name As String = txtTableName.Text
        AddTableFood(name)
    End Sub

    'Nút Tìm Kiếm Món Ăn
    Private Sub btnSearchFood_Click(sender As Object, e As EventArgs) Handles btnSearchFood.Click
        foodList.DataSource = SearchFoodByName(txtSearchFood.Text)
    End Sub

    'Nút thêm nhân viên
    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click
        Dim fullname As String = txtNameStaff.Text
        Dim dob As String = dtpDOBStaff.Value.Year & "-" & dtpDOBStaff.Value.Month & "-" & dtpDOBStaff.Value.Day

        Dim gender As Integer

        If cbbGenderStaff.SelectedIndex = 1 Then
            gender = 0
        Else
            gender = 1
        End If

        Dim idCard As String = txtIDCardStaff.Text
        Dim address As String = txtAddressStaff.Text
        Dim phone As String = txtPhoneStaff.Text

        AddStaff(fullname, dob, gender, idCard, address, phone)
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

                If staff._gender <> True Then
                    cbbGenderStaff.SelectedIndex = 1
                Else
                    cbbGenderStaff.SelectedIndex = 0
                End If
            End If
        Catch
        End Try
    End Sub
#End Region

End Class