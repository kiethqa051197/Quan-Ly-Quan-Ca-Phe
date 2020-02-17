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
        Me.txtNameStaff = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpDOBStaff = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIDStaff = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAddressStaff = New System.Windows.Forms.TextBox()
        Me.txtPhoneStaff = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.btnChangeInfo = New DevExpress.XtraEditors.SimpleButton()
        Me.checkboxChangePass = New System.Windows.Forms.CheckBox()
        Me.panelInfoStaff = New DevExpress.XtraEditors.PanelControl()
        Me.panelChangePass = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRetypeNewPass = New DevExpress.XtraEditors.TextEdit()
        Me.txtOldPass = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNewPass = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtNameStaff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIDStaff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhoneStaff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelInfoStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelInfoStaff.SuspendLayout()
        CType(Me.panelChangePass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelChangePass.SuspendLayout()
        CType(Me.txtRetypeNewPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOldPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNewPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNameStaff
        '
        Me.txtNameStaff.Enabled = False
        Me.txtNameStaff.Location = New System.Drawing.Point(129, 54)
        Me.txtNameStaff.Name = "txtNameStaff"
        Me.txtNameStaff.Size = New System.Drawing.Size(176, 20)
        Me.txtNameStaff.TabIndex = 5
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
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Location = New System.Drawing.Point(88, 16)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(160, 18)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "THÔNG TIN CÁ NHÂN"
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
        'dtpDOBStaff
        '
        Me.dtpDOBStaff.Enabled = False
        Me.dtpDOBStaff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDOBStaff.Location = New System.Drawing.Point(129, 88)
        Me.dtpDOBStaff.Name = "dtpDOBStaff"
        Me.dtpDOBStaff.Size = New System.Drawing.Size(176, 20)
        Me.dtpDOBStaff.TabIndex = 6
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
        'txtIDStaff
        '
        Me.txtIDStaff.Enabled = False
        Me.txtIDStaff.Location = New System.Drawing.Point(128, 226)
        Me.txtIDStaff.Name = "txtIDStaff"
        Me.txtIDStaff.Size = New System.Drawing.Size(176, 20)
        Me.txtIDStaff.TabIndex = 8
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl10.Location = New System.Drawing.Point(17, 228)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(88, 14)
        Me.LabelControl10.TabIndex = 16
        Me.LabelControl10.Text = "CMND / CCCD:"
        '
        'txtAddressStaff
        '
        Me.txtAddressStaff.Enabled = False
        Me.txtAddressStaff.Location = New System.Drawing.Point(129, 123)
        Me.txtAddressStaff.Multiline = True
        Me.txtAddressStaff.Name = "txtAddressStaff"
        Me.txtAddressStaff.Size = New System.Drawing.Size(176, 97)
        Me.txtAddressStaff.TabIndex = 7
        '
        'txtPhoneStaff
        '
        Me.txtPhoneStaff.Enabled = False
        Me.txtPhoneStaff.Location = New System.Drawing.Point(128, 268)
        Me.txtPhoneStaff.Name = "txtPhoneStaff"
        Me.txtPhoneStaff.Size = New System.Drawing.Size(176, 20)
        Me.txtPhoneStaff.TabIndex = 10
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
        'btnChangeInfo
        '
        Me.btnChangeInfo.Location = New System.Drawing.Point(129, 341)
        Me.btnChangeInfo.Name = "btnChangeInfo"
        Me.btnChangeInfo.Size = New System.Drawing.Size(177, 45)
        Me.btnChangeInfo.TabIndex = 26
        Me.btnChangeInfo.Text = "Thay đổi thông tin cá nhân"
        '
        'checkboxChangePass
        '
        Me.checkboxChangePass.AutoSize = True
        Me.checkboxChangePass.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.checkboxChangePass.Location = New System.Drawing.Point(202, 307)
        Me.checkboxChangePass.Name = "checkboxChangePass"
        Me.checkboxChangePass.Size = New System.Drawing.Size(102, 17)
        Me.checkboxChangePass.TabIndex = 27
        Me.checkboxChangePass.Text = "Đổi mật khẩu"
        Me.checkboxChangePass.UseVisualStyleBackColor = True
        '
        'panelInfoStaff
        '
        Me.panelInfoStaff.Controls.Add(Me.panelChangePass)
        Me.panelInfoStaff.Controls.Add(Me.checkboxChangePass)
        Me.panelInfoStaff.Controls.Add(Me.btnChangeInfo)
        Me.panelInfoStaff.Controls.Add(Me.LabelControl12)
        Me.panelInfoStaff.Controls.Add(Me.txtPhoneStaff)
        Me.panelInfoStaff.Controls.Add(Me.txtAddressStaff)
        Me.panelInfoStaff.Controls.Add(Me.LabelControl10)
        Me.panelInfoStaff.Controls.Add(Me.txtIDStaff)
        Me.panelInfoStaff.Controls.Add(Me.LabelControl9)
        Me.panelInfoStaff.Controls.Add(Me.dtpDOBStaff)
        Me.panelInfoStaff.Controls.Add(Me.LabelControl8)
        Me.panelInfoStaff.Controls.Add(Me.LabelControl5)
        Me.panelInfoStaff.Controls.Add(Me.LabelControl7)
        Me.panelInfoStaff.Controls.Add(Me.txtNameStaff)
        Me.panelInfoStaff.Location = New System.Drawing.Point(12, 12)
        Me.panelInfoStaff.Name = "panelInfoStaff"
        Me.panelInfoStaff.Size = New System.Drawing.Size(328, 400)
        Me.panelInfoStaff.TabIndex = 11
        '
        'panelChangePass
        '
        Me.panelChangePass.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.panelChangePass.Controls.Add(Me.LabelControl3)
        Me.panelChangePass.Controls.Add(Me.txtRetypeNewPass)
        Me.panelChangePass.Controls.Add(Me.txtOldPass)
        Me.panelChangePass.Controls.Add(Me.LabelControl1)
        Me.panelChangePass.Controls.Add(Me.txtNewPass)
        Me.panelChangePass.Controls.Add(Me.LabelControl2)
        Me.panelChangePass.Location = New System.Drawing.Point(5, 330)
        Me.panelChangePass.Name = "panelChangePass"
        Me.panelChangePass.Size = New System.Drawing.Size(318, 110)
        Me.panelChangePass.TabIndex = 30
        Me.panelChangePass.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Location = New System.Drawing.Point(15, 81)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(140, 14)
        Me.LabelControl3.TabIndex = 45
        Me.LabelControl3.Text = "Nhập lại mật khẩu mới:"
        '
        'txtRetypeNewPass
        '
        Me.txtRetypeNewPass.Location = New System.Drawing.Point(162, 79)
        Me.txtRetypeNewPass.Name = "txtRetypeNewPass"
        Me.txtRetypeNewPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRetypeNewPass.Size = New System.Drawing.Size(140, 20)
        Me.txtRetypeNewPass.TabIndex = 44
        '
        'txtOldPass
        '
        Me.txtOldPass.Location = New System.Drawing.Point(162, 11)
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPass.Size = New System.Drawing.Size(141, 20)
        Me.txtOldPass.TabIndex = 43
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Location = New System.Drawing.Point(16, 46)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(88, 14)
        Me.LabelControl1.TabIndex = 42
        Me.LabelControl1.Text = "Mật khẩu mới:"
        '
        'txtNewPass
        '
        Me.txtNewPass.Location = New System.Drawing.Point(162, 44)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPass.Size = New System.Drawing.Size(141, 20)
        Me.txtNewPass.TabIndex = 40
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(17, 13)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(80, 14)
        Me.LabelControl2.TabIndex = 41
        Me.LabelControl2.Text = "Mật khẩu cũ:"
        '
        'FormThongTinNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 424)
        Me.Controls.Add(Me.panelInfoStaff)
        Me.MaximumSize = New System.Drawing.Size(367, 564)
        Me.MinimumSize = New System.Drawing.Size(367, 463)
        Me.Name = "FormThongTinNhanVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormThongTinNhanVien"
        CType(Me.txtNameStaff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIDStaff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhoneStaff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelInfoStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelInfoStaff.ResumeLayout(False)
        Me.panelInfoStaff.PerformLayout()
        CType(Me.panelChangePass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelChangePass.ResumeLayout(False)
        Me.panelChangePass.PerformLayout()
        CType(Me.txtRetypeNewPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOldPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNewPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNameStaff As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpDOBStaff As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIDStaff As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAddressStaff As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneStaff As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnChangeInfo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents checkboxChangePass As System.Windows.Forms.CheckBox
    Friend WithEvents panelInfoStaff As DevExpress.XtraEditors.PanelControl
    Friend WithEvents panelChangePass As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRetypeNewPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOldPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNewPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
