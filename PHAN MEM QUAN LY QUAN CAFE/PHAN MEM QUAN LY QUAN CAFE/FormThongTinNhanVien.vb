Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO

Public Class FormThongTinNhanVien

#Region "KHỞI TẠO"

    Dim staff As Staffs

    Dim FROM_HEIGH_OLD As Integer = 463
    Dim FROM_HEIGH_NEW As Integer = 564

    Dim PANEL_HEIGH_OLD As Integer = 400
    Dim PANEL_HEIGH_NEW As Integer = 505

    Dim BTN_LOCATION_OLD As New Point(129, 341)
    Dim BTN_LOCATION_NEW As New Point(165, 450)

    Dim BTN_WIDTH_OLD As Integer = 177
    Dim BTN_WIDTH_NEW As Integer = 141

    Public Property _staff As Staffs
        Get
            Return staff
        End Get
        Set(value As Staffs)
            staff = value
        End Set
    End Property

    Public Sub New(staff As Staffs)
        InitializeComponent()
        Me._staff = staff

        ChangeAccountAndUpdateInfoForm()
    End Sub
#End Region

#Region "PHƯƠNG THỨC"

    'Change Account
    Private Sub ChangeAccountAndUpdateInfoForm()
        txtNameStaff.Text = _staff._fullname
        dtpDOBStaff.Value = _staff._dateofbirth
        txtAddressStaff.Text = _staff._address
        txtIDStaff.Text = _staff._idCard

        If _staff._gender <> True Then
            cbGender.SelectedIndex = 1
        Else
            cbGender.SelectedIndex = 0
        End If

        txtPhoneStaff.Text = _staff._phone
    End Sub

    'Thay đổi kích thước form
    Private Sub ResizeForm(form_height As Integer, panel_height As Integer, visible As Boolean, location As Point, btn_width As Integer)
        Me.Height = form_height

        panelInfoStaff.Height = panel_height

        panelChangePass.Visible = visible

        btnChangeInfo.Location = location
        btnChangeInfo.Width = btn_width
    End Sub

    'Mở / Đóng textbox
    Private Sub Enable(enable As Boolean)
        txtNameStaff.Enabled = enable
        dtpDOBStaff.Enabled = enable
        txtAddressStaff.Enabled = enable
        txtIDStaff.Enabled = enable
        cbGender.Enabled = enable
        txtPhoneStaff.Enabled = enable
    End Sub

    'Cập nhật thông tin nhân viên
    Private Sub UpdateInfo()
        Dim acc As Accounts = AccountDAO._Instance.GetAccountByUserName(_staff._idCard)

        Dim gender As Integer
        Dim dob As String

        If cbGender.SelectedIndex = 1 Then
            gender = 0
        Else
            gender = 1
        End If

        dob = dtpDOBStaff.Value.Year & "-" & dtpDOBStaff.Value.Month & "-" & dtpDOBStaff.Value.Day

        If btnChangeInfo.Text = "Thay đổi thông tin cá nhân" Then
            Enable(True)
            btnChangeInfo.Text = "Cập nhật"
        Else
            'Xét trường hợp có check thay đổi mật khẩu hay không
            'Nếu có thì có thêm hàm đổi pass ngược lại thì ko có
            If checkboxChangePass.Checked = True Then

                'So sánh pass cũ đang nhập vào với pass cũ xem có trùng nhau hay không 
                'nếu trùng thì xét if tiếp không thì cho nhập lại
                If txtOldPass.Text = acc._passWord Then

                    'Kiểm tra mật khẩu mới có trùng nhau không 
                    'nếu trùng thì xét if tiếp theo, không thì cho nhập lại
                    If txtRetypeNewPass.Text = txtNewPass.Text Then

                        'So sánh pass mới với pass cũ xem có trùng nhau hay không 
                        'nếu trùng thì không cho đổi và ngược lại
                        If txtNewPass.Text <> txtOldPass.Text Then
                            If StaffDAO._Instance.UpdateInfoStaff(_staff._id, txtNameStaff.Text, dob, gender, txtIDStaff.Text, txtAddressStaff.Text, txtPhoneStaff.Text) Then
                                If AccountDAO._Instance.UpdateAccountStaff(acc._id, txtIDStaff.Text, txtNewPass.Text, _staff._id, acc._type) Then
                                    MessageBox.Show("Cập nhật thành công!")
                                    Enable(False)

                                    RaiseEvent updateAccount(Me, New AccountEvent(AccountDAO._Instance.GetAccountByUserName(txtIDStaff.Text)))
                                Else
                                    MessageBox.Show("Cập nhật thất bại!")
                                End If
                            Else
                                MessageBox.Show("Cập nhật thất bại!")
                            End If
                        Else
                            MessageBox.Show("Mật khẩu mới của bạn trùng với mật khẩu cũ!!! Vui lòng nhập mật khẩu mới")
                            txtNewPass.Select()
                        End If
                    Else
                        MessageBox.Show("Mật khẩu mới của bạn nhập không khớp nhau!!!")
                        txtRetypeNewPass.Select()
                    End If
                Else
                    MessageBox.Show("Mật khẩu cũ của bạn không đúng!!!")
                    txtRetypeNewPass.Select()
                End If
            Else
                If StaffDAO._Instance.UpdateInfoStaff(_staff._id, txtNameStaff.Text, dob, gender, txtIDStaff.Text, txtAddressStaff.Text, txtPhoneStaff.Text) Then
                    RaiseEvent updateAccount(Me, New AccountEvent(AccountDAO._Instance.GetAccountByUserName(txtIDStaff.Text)))
                Else
                    MessageBox.Show("Cập nhật thất bại!")
                End If
            End If

            btnChangeInfo.Text = "Thay đổi thông tin cá nhân"
        End If
    End Sub


#End Region

#Region "BẮT SỰ KIỆN"

    'Combobox giới tính
    Private Sub checkboxChangePass_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxChangePass.CheckedChanged
        If checkboxChangePass.Checked = True Then
            ResizeForm(FROM_HEIGH_NEW, PANEL_HEIGH_NEW, True, BTN_LOCATION_NEW, BTN_WIDTH_NEW)

            If btnChangeInfo.Text = "Thay đổi thông tin cá nhân" Then
                btnChangeInfo.Text = "Cập nhật"
            End If
        Else
            ResizeForm(FROM_HEIGH_OLD, PANEL_HEIGH_OLD, False, BTN_LOCATION_OLD, BTN_WIDTH_OLD)

            If btnChangeInfo.Text = "Cập nhật" Then
                btnChangeInfo.Text = "Thay đổi thông tin cá nhân"
            End If
        End If
    End Sub

    'Nút thay đổi thông tin"
    Private Sub btnChangeInfo_Click(sender As Object, e As EventArgs) Handles btnChangeInfo.Click
        UpdateInfo()
    End Sub

#End Region

#Region "CUSTOM EVENT"

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

End Class

#Region "CLASS EVENT"

Public Class AccountEvent
    Inherits EventArgs

    Private acc As Accounts

    Public Property _acc As Accounts
        Get
            Return acc
        End Get
        Set(value As Accounts)
            acc = value
        End Set
    End Property

    Public Sub New(acc As Accounts)
        Me.acc = acc
    End Sub
End Class

#End Region