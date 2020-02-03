Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO
Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO

Public Class FormDangNhap
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Application.[Exit]()
    End Sub

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        Dim username As String = txtTenDangNhap.Text
        Dim password As String = txtMatKhau.Text

        If Login(username, password) Then
            Dim loginAccount As Accounts = AccountDAO._Instance.GetAccountByUserName(username)
            Me.Hide()
            Dim f As FormBanHang = New FormBanHang
            f.Show()
        Else
            MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!")
        End If
    End Sub

    Private Function Login(ByVal username As String, ByVal password As String) As Boolean
        Return AccountDAO._Instance.Login(username, password)
    End Function

    Private Sub FormDangNhap_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) <> System.Windows.Forms.DialogResult.OK Then
            e.Cancel = True
        End If
    End Sub
End Class
