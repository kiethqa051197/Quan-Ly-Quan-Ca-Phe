Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO
Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.Ultils

Public Class FormKhachHang
    Private Sub btnSaveCustomer_Click(sender As Object, e As EventArgs) Handles btnSaveCustomer.Click
        Dim name As String = txtNameCustomer.Text.Trim
        Dim phone As String = txtPhoneCustomer.Text.Trim

        saveCustomer(name, phone)
    End Sub

    Private Sub btnCancelCustomer_Click(sender As Object, e As EventArgs) Handles btnCancelCustomer.Click
        Me.Close()
    End Sub

    Private Sub saveCustomer(name As String, phone As String)
        If CheckEmpty(name) Then
            MessageBox.Show("Bạn không được bỏ trống tên khách hàng")
        Else
            If (CustomerDAO._Instance.InsertCustomer(name, phone)) Then
                MessageBox.Show("Thêm khách hàng thành công")
                RaiseEvent AddCustomer(Me, New EventArgs())
                Me.Close()
            Else
                MessageBox.Show("Thêm khách hàng thất bại")
            End If
        End If
    End Sub

    Private Sub txtNameCustomer_TextChanged(sender As Object, e As EventArgs) Handles txtNameCustomer.TextChanged
        If CheckEmpty(txtNameCustomer.Text.Trim) Then
            MessageBox.Show("Bạn không được bỏ trống tên khách hàng")
            btnSaveCustomer.Enabled = False
        Else
            btnSaveCustomer.Enabled = True
        End If
    End Sub

#Region "CUSTOM EVENT"

    'Sự kiện ở đây được định nghĩa là nếu có chỉnh sửa từ phía form bên đây thì form bán hàng sẽ thay đổi theo
    Public Custom Event AddCustomer As EventHandler
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

#End Region

End Class