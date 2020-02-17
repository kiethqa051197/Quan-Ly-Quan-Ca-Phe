<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKhachHang
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
        Me.PanelControl18 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPhoneCustomer = New DevExpress.XtraEditors.TextEdit()
        Me.btnSaveCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNameCustomer = New DevExpress.XtraEditors.TextEdit()
        CType(Me.PanelControl18, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl18.SuspendLayout()
        CType(Me.txtPhoneCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl18
        '
        Me.PanelControl18.Controls.Add(Me.LabelControl15)
        Me.PanelControl18.Controls.Add(Me.txtPhoneCustomer)
        Me.PanelControl18.Controls.Add(Me.btnSaveCustomer)
        Me.PanelControl18.Controls.Add(Me.btnCancelCustomer)
        Me.PanelControl18.Controls.Add(Me.LabelControl22)
        Me.PanelControl18.Controls.Add(Me.LabelControl23)
        Me.PanelControl18.Controls.Add(Me.txtNameCustomer)
        Me.PanelControl18.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl18.Name = "PanelControl18"
        Me.PanelControl18.Size = New System.Drawing.Size(317, 182)
        Me.PanelControl18.TabIndex = 15
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl15.Location = New System.Drawing.Point(14, 86)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(86, 14)
        Me.LabelControl15.TabIndex = 23
        Me.LabelControl15.Text = "Số điện thoại:"
        '
        'txtPhoneCustomer
        '
        Me.txtPhoneCustomer.Location = New System.Drawing.Point(133, 84)
        Me.txtPhoneCustomer.Name = "txtPhoneCustomer"
        Me.txtPhoneCustomer.Size = New System.Drawing.Size(162, 20)
        Me.txtPhoneCustomer.TabIndex = 11
        '
        'btnSaveCustomer
        '
        Me.btnSaveCustomer.Enabled = False
        Me.btnSaveCustomer.Location = New System.Drawing.Point(133, 122)
        Me.btnSaveCustomer.Name = "btnSaveCustomer"
        Me.btnSaveCustomer.Size = New System.Drawing.Size(80, 44)
        Me.btnSaveCustomer.TabIndex = 12
        Me.btnSaveCustomer.Text = "Lưu"
        '
        'btnCancelCustomer
        '
        Me.btnCancelCustomer.Location = New System.Drawing.Point(219, 122)
        Me.btnCancelCustomer.Name = "btnCancelCustomer"
        Me.btnCancelCustomer.Size = New System.Drawing.Size(76, 44)
        Me.btnCancelCustomer.TabIndex = 13
        Me.btnCancelCustomer.Text = "Huỷ"
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl22.Location = New System.Drawing.Point(75, 17)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(191, 18)
        Me.LabelControl22.TabIndex = 8
        Me.LabelControl22.Text = "THÔNG TIN KHÁCH HÀNG"
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl23.Location = New System.Drawing.Point(13, 57)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(101, 14)
        Me.LabelControl23.TabIndex = 6
        Me.LabelControl23.Text = "Tên khách hàng:"
        '
        'txtNameCustomer
        '
        Me.txtNameCustomer.Location = New System.Drawing.Point(133, 56)
        Me.txtNameCustomer.Name = "txtNameCustomer"
        Me.txtNameCustomer.Size = New System.Drawing.Size(162, 20)
        Me.txtNameCustomer.TabIndex = 6
        '
        'FormKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 200)
        Me.Controls.Add(Me.PanelControl18)
        Me.Name = "FormKhachHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Khách hàng"
        CType(Me.PanelControl18, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl18.ResumeLayout(False)
        Me.PanelControl18.PerformLayout()
        CType(Me.txtPhoneCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl18 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPhoneCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSaveCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameCustomer As DevExpress.XtraEditors.TextEdit
End Class
