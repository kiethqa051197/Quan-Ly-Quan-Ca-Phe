<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDangNhap
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
        Me.txtTenDangNhap = New DevExpress.XtraEditors.TextEdit()
        Me.txtMatKhau = New DevExpress.XtraEditors.TextEdit()
        Me.btnDangNhap = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtTenDangNhap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMatKhau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTenDangNhap
        '
        Me.txtTenDangNhap.EditValue = "3121564645"
        Me.txtTenDangNhap.Location = New System.Drawing.Point(109, 12)
        Me.txtTenDangNhap.Name = "txtTenDangNhap"
        Me.txtTenDangNhap.Size = New System.Drawing.Size(156, 20)
        Me.txtTenDangNhap.TabIndex = 1
        '
        'txtMatKhau
        '
        Me.txtMatKhau.EditValue = "123456"
        Me.txtMatKhau.Location = New System.Drawing.Point(109, 48)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhau.Size = New System.Drawing.Size(156, 20)
        Me.txtMatKhau.TabIndex = 2
        '
        'btnDangNhap
        '
        Me.btnDangNhap.Appearance.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnDangNhap.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue
        Me.btnDangNhap.Appearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnDangNhap.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnDangNhap.Appearance.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnDangNhap.Appearance.Options.UseBackColor = True
        Me.btnDangNhap.Appearance.Options.UseBorderColor = True
        Me.btnDangNhap.Appearance.Options.UseFont = True
        Me.btnDangNhap.Appearance.Options.UseForeColor = True
        Me.btnDangNhap.Location = New System.Drawing.Point(109, 88)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(75, 23)
        Me.btnDangNhap.TabIndex = 3
        Me.btnDangNhap.Text = "Đăng nhập"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Tên đăng nhập:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(12, 51)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Mật khẩu:"
        '
        'btnThoat
        '
        Me.btnThoat.Appearance.BackColor = System.Drawing.Color.Red
        Me.btnThoat.Appearance.BackColor2 = System.Drawing.Color.Red
        Me.btnThoat.Appearance.BorderColor = System.Drawing.Color.Red
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btnThoat.Appearance.Options.UseBackColor = True
        Me.btnThoat.Appearance.Options.UseBorderColor = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnThoat.Location = New System.Drawing.Point(190, 88)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 4
        Me.btnThoat.Text = "Thoát"
        '
        'FormDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 122)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnDangNhap)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.txtTenDangNhap)
        Me.MaximumSize = New System.Drawing.Size(293, 161)
        Me.MinimumSize = New System.Drawing.Size(293, 161)
        Me.Name = "FormDangNhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng Nhập"
        CType(Me.txtTenDangNhap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMatKhau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTenDangNhap As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMatKhau As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnDangNhap As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton

End Class
