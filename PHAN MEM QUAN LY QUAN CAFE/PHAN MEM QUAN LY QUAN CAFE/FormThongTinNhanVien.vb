Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO

Public Class FormThongTinNhanVien

#Region "KHỞI TẠO"
    Dim staff As Staffs

    Public Property _staff As Staffs
        Get
            Return staff
        End Get
        Set(ByVal value As Staffs)
            staff = value
        End Set
    End Property

    Public Sub New(ByVal staff As Staffs)
        InitializeComponent()
        Me._staff = staff
    End Sub
#End Region

End Class