<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormThongTinNhanVien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelControl11 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPhoneStaff = New DevExpress.XtraEditors.TextEdit()
        Me.btnChangePass = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAddressStaff = New System.Windows.Forms.TextBox()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIDStaff = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpDOBStaff = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtStaffName = New DevExpress.XtraEditors.TextEdit()
        Me.txtGenderStaff = New DevExpress.XtraEditors.TextEdit()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl11.SuspendLayout()
        CType(Me.txtPhoneStaff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIDStaff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStaffName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGenderStaff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl11
        '
        Me.PanelControl11.Controls.Add(Me.txtGenderStaff)
        Me.PanelControl11.Controls.Add(Me.LabelControl12)
        Me.PanelControl11.Controls.Add(Me.txtPhoneStaff)
        Me.PanelControl11.Controls.Add(Me.btnChangePass)
        Me.PanelControl11.Controls.Add(Me.LabelControl11)
        Me.PanelControl11.Controls.Add(Me.txtAddressStaff)
        Me.PanelControl11.Controls.Add(Me.LabelControl10)
        Me.PanelControl11.Controls.Add(Me.txtIDStaff)
        Me.PanelControl11.Controls.Add(Me.LabelControl9)
        Me.PanelControl11.Controls.Add(Me.dtpDOBStaff)
        Me.PanelControl11.Controls.Add(Me.LabelControl8)
        Me.PanelControl11.Controls.Add(Me.LabelControl5)
        Me.PanelControl11.Controls.Add(Me.LabelControl7)
        Me.PanelControl11.Controls.Add(Me.txtStaffName)
        Me.PanelControl11.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl11.Name = "PanelControl11"
        Me.PanelControl11.Size = New System.Drawing.Size(311, 364)
        Me.PanelControl11.TabIndex = 11
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl12.Location = New System.Drawing.Point(17, 270)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(86, 14)
        Me.LabelControl12.TabIndex = 23
        Me.LabelControl12.Text = "Số điện thoại:"
        '
        'txtPhoneStaff
        '
        Me.txtPhoneStaff.Enabled = False
        Me.txtPhoneStaff.Location = New System.Drawing.Point(122, 268)
        Me.txtPhoneStaff.Name = "txtPhoneStaff"
        Me.txtPhoneStaff.Size = New System.Drawing.Size(176, 20)
        Me.txtPhoneStaff.TabIndex = 10
        '
        'btnChangePass
        '
        Me.btnChangePass.Location = New System.Drawing.Point(123, 309)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(177, 45)
        Me.btnChangePass.TabIndex = 12
        Me.btnChangePass.Text = "Đổi mật khẩu"
        Me.btnChangePass.Visible = False
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl11.Location = New System.Drawing.Point(18, 237)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(55, 14)
        Me.LabelControl11.TabIndex = 19
        Me.LabelControl11.Text = "Giới tính:"
        '
        'txtAddressStaff
        '
        Me.txtAddressStaff.Enabled = False
        Me.txtAddressStaff.Location = New System.Drawing.Point(123, 123)
        Me.txtAddressStaff.Multiline = True
        Me.txtAddressStaff.Name = "txtAddressStaff"
        Me.txtAddressStaff.Size = New System.Drawing.Size(176, 67)
        Me.txtAddressStaff.TabIndex = 7
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl10.Location = New System.Drawing.Point(18, 205)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(88, 14)
        Me.LabelControl10.TabIndex = 16
        Me.LabelControl10.Text = "CMND / CCCD:"
        '
        'txtIDStaff
        '
        Me.txtIDStaff.Enabled = False
        Me.txtIDStaff.Location = New System.Drawing.Point(123, 203)
        Me.txtIDStaff.Name = "txtIDStaff"
        Me.txtIDStaff.Size = New System.Drawing.Size(176, 20)
        Me.txtIDStaff.TabIndex = 8
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Location = New System.Drawing.Point(18, 125)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(44, 14)
        Me.LabelControl9.TabIndex = 14
        Me.LabelControl9.Text = "Địa chỉ:"
        '
        'dtpDOBStaff
        '
        Me.dtpDOBStaff.Enabled = False
        Me.dtpDOBStaff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDOBStaff.Location = New System.Drawing.Point(123, 88)
        Me.dtpDOBStaff.Name = "dtpDOBStaff"
        Me.dtpDOBStaff.Size = New System.Drawing.Size(176, 20)
        Me.dtpDOBStaff.TabIndex = 6
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl8.Location = New System.Drawing.Point(18, 90)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(63, 14)
        Me.LabelControl8.TabIndex = 11
        Me.LabelControl8.Text = "Ngày sinh:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Location = New System.Drawing.Point(81, 14)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(176, 18)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "THÔNG TIN TÀI KHOẢN"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl7.Location = New System.Drawing.Point(17, 55)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(90, 14)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "Tên nhân viên:"
        '
        'txtStaffName
        '
        Me.txtStaffName.Enabled = False
        Me.txtStaffName.Location = New System.Drawing.Point(123, 54)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(176, 20)
        Me.txtStaffName.TabIndex = 5
        '
        'txtGenderStaff
        '
        Me.txtGenderStaff.Enabled = False
        Me.txtGenderStaff.Location = New System.Drawing.Point(122, 235)
        Me.txtGenderStaff.Name = "txtGenderStaff"
        Me.txtGenderStaff.Size = New System.Drawing.Size(176, 20)
        Me.txtGenderStaff.TabIndex = 24
        '
        'FormThongTinNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 388)
        Me.Controls.Add(Me.PanelControl11)
        Me.Name = "FormThongTinNhanVien"
        Me.Text = "FormThongTinNhanVien"
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl11.ResumeLayout(False)
        Me.PanelControl11.PerformLayout()
        CType(Me.txtPhoneStaff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIDStaff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStaffName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGenderStaff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl11 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPhoneStaff As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnChangePass As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAddressStaff As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIDStaff As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpDOBStaff As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStaffName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtGenderStaff As DevExpress.XtraEditors.TextEdit
End Class
