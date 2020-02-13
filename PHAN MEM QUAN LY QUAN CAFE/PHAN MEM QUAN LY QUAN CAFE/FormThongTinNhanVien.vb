Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO

Public Class FormThongTinNhanVien

#Region "KHỞI TẠO"

    Private staff As Staffs
    Private acc As Accounts

    Private isChangeInfo As Boolean = False
    Private isChangePass As Boolean = False

    Private FROM_HEIGH_OLD As Integer = 463
    Private FROM_HEIGH_NEW As Integer = 564

    Private PANEL_HEIGH_OLD As Integer = 400
    Private PANEL_HEIGH_NEW As Integer = 505

    Private BTN_LOCATION_OLD As New Point(129, 341)
    Private BTN_LOCATION_NEW As New Point(165, 450)

    Private BTN_WIDTH_OLD As Integer = 177
    Private BTN_WIDTH_NEW As Integer = 141

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
        acc = AccountDAO._Instance.GetAccountByIdStaff(_staff._id)

        Dim oldPassDatabase As String = acc._passWord
        Dim oldPass As String = txtOldPass.Text.Trim
        Dim newPass As String = txtNewPass.Text.Trim
        Dim newPassRetype As String = txtRetypeNewPass.Text.Trim

        Dim fullname As String = txtNameStaff.Text.Trim
        Dim dob As String = dtpDOBStaff.Value.Year & "-" & dtpDOBStaff.Value.Month & "-" & dtpDOBStaff.Value.Day

        Dim gender As Integer

        If cbGender.SelectedIndex = 1 Then
            gender = 0
        Else
            gender = 1
        End If

        Dim address As String = txtAddressStaff.Text.Trim
        Dim phone As String = txtPhoneStaff.Text.Trim
        Dim idCard As String = txtIDStaff.Text.Trim
        Dim idAccount As Integer = acc._id

        If isChangeInfo = True And isChangePass = True Then
            If CheckEmpty(fullname) Or CheckEmpty(oldPass) Or CheckEmpty(newPass) Or CheckEmpty(newPassRetype) Then
                MessageBox.Show("Vui lòng nhập đủ thông tin!!!")
            Else
                If oldPass.Equals(oldPassDatabase) Then
                    If newPassRetype.Equals(newPass) Then
                        If (StaffDAO._Instance.UpdateInfoStaff(_staff._id, fullname, dob, gender, idCard, address, phone)) Then
                            If (AccountDAO._Instance.UpdateAccountStaff(idAccount, idCard, newPass, _staff._id)) Then
                                MessageBox.Show("Cập nhật thành công")

                                isChangeInfo = False
                                isChangePass = False

                                RaiseEvent updateAccount(Me, New AccountEvent(AccountDAO._Instance.GetAccountByIdStaff(acc._idStaff)))
                                ChangeText()
                            Else
                                MessageBox.Show("Cập nhật thất bại")
                            End If
                        End If
                    Else
                        MessageBox.Show("Vui lòng nhập đúng mật khẩu mới")
                    End If
                Else
                    MessageBox.Show("Bạn nhập sai mật khẩu cũ!!!")
                End If
            End If
        ElseIf isChangeInfo = False And isChangePass = True Then
            If CheckEmpty(oldPass) Or CheckEmpty(newPass) Or CheckEmpty(newPassRetype) Then
                MessageBox.Show("Vui lòng nhập đủ thông tin!!!")
            Else
                If oldPass.Equals(oldPassDatabase) Then
                    If newPassRetype.Equals(newPass) Then
                        If (AccountDAO._Instance.UpdateAccountStaff(idAccount, idCard, newPass, _staff._id)) Then
                            MessageBox.Show("Cập nhật thành công")

                            isChangeInfo = False
                            isChangePass = False

                            RaiseEvent updateAccount(Me, New AccountEvent(AccountDAO._Instance.GetAccountByIdStaff(acc._idStaff)))
                            ChangeText()
                        Else
                            MessageBox.Show("Cập nhật thất bại")
                        End If
                    Else
                        MessageBox.Show("Vui lòng nhập đúng mật khẩu mới")
                    End If
                Else
                    MessageBox.Show("Mật khẩu cũ của bạn không đúng")
                End If
            End If
        ElseIf isChangeInfo = True And isChangePass = False Then
            If CheckEmpty(fullname) Then
                MessageBox.Show("Không được bỏ trống tên!!!")
            Else
                If (StaffDAO._Instance.UpdateInfoStaff(_staff._id, fullname, dob, gender, idCard, address, phone)) Then
                    If (AccountDAO._Instance.UpdateUsernameAccountStaff(idAccount, idCard)) Then
                        MessageBox.Show("Cập nhật thành công")

                        isChangeInfo = False
                        isChangePass = False

                        RaiseEvent updateAccount(Me, New AccountEvent(AccountDAO._Instance.GetAccountByIdStaff(acc._idStaff)))
                        ChangeText()
                    Else
                        MessageBox.Show("Cập nhật thất bại")
                    End If
                Else
                    MessageBox.Show("Cập nhật thất bại")
                End If
            End If
        End If
    End Sub

    'Change text
    Public Sub ChangeText()
        If isChangeInfo = False Then
            Enable(False)
            If isChangePass = False Then
                btnChangeInfo.Text = "Thay đổi thông tin cá nhân"
            Else
                btnChangeInfo.Text = "Lưu"
            End If
        Else
            Enable(True)
            btnChangeInfo.Text = "Lưu"
        End If
    End Sub

    'Xet rong 
    Private Function CheckEmpty(text As String) As Boolean
        If text.Equals("") Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "BẮT SỰ KIỆN"

    'Checkbox thay đổi mật khẩu
    Private Sub checkboxChangePass_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxChangePass.CheckedChanged
        If checkboxChangePass.Checked = True Then
            isChangePass = True
            ChangeText()
            ResizeForm(FROM_HEIGH_NEW, PANEL_HEIGH_NEW, True, BTN_LOCATION_NEW, BTN_WIDTH_NEW)
        Else
            isChangePass = False
            ChangeText()
            ResizeForm(FROM_HEIGH_OLD, PANEL_HEIGH_OLD, False, BTN_LOCATION_OLD, BTN_WIDTH_OLD)
        End If
    End Sub

    'Nút thay đổi thông tin"
    Private Sub btnChangeInfo_Click(sender As Object, e As EventArgs) Handles btnChangeInfo.Click
        If btnChangeInfo.Text.Equals("Thay đổi thông tin cá nhân") Then
            isChangeInfo = True
            ChangeText()
        Else
            UpdateInfo()
        End If
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