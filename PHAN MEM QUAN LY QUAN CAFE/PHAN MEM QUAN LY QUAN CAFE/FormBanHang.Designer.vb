<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBanHang
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl()
        Me.nmCount = New DevExpress.XtraEditors.SpinEdit()
        Me.cbObject = New System.Windows.Forms.ComboBox()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
        Me.btnAddObject = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.listBill = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.cbSwichTable = New System.Windows.Forms.ComboBox()
        Me.btnCheckOut = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.nmDiscount = New DevExpress.XtraEditors.SpinEdit()
        Me.btnDiscount = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSwichTable = New DevExpress.XtraEditors.SimpleButton()
        Me.tableLayout = New System.Windows.Forms.FlowLayoutPanel()
        Me.AdminStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountInfoToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalInfoToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.nmCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.LabelControl45)
        Me.PanelControl1.Controls.Add(Me.nmCount)
        Me.PanelControl1.Controls.Add(Me.cbObject)
        Me.PanelControl1.Controls.Add(Me.cbCategory)
        Me.PanelControl1.Controls.Add(Me.btnAddObject)
        Me.PanelControl1.Location = New System.Drawing.Point(456, 30)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(332, 59)
        Me.PanelControl1.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.LabelControl2.Location = New System.Drawing.Point(7, 36)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl2.TabIndex = 12
        Me.LabelControl2.Text = "Tên món:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(6, 9)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl1.TabIndex = 11
        Me.LabelControl1.Text = "Danh mục:"
        '
        'LabelControl45
        '
        Me.LabelControl45.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.LabelControl45.Location = New System.Drawing.Point(202, 9)
        Me.LabelControl45.Name = "LabelControl45"
        Me.LabelControl45.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl45.TabIndex = 10
        Me.LabelControl45.Text = "Số lượng:"
        '
        'nmCount
        '
        Me.nmCount.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmCount.Location = New System.Drawing.Point(202, 28)
        Me.nmCount.Name = "nmCount"
        Me.nmCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.nmCount.Properties.IsFloatValue = False
        Me.nmCount.Properties.Mask.EditMask = "N00"
        Me.nmCount.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nmCount.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmCount.Size = New System.Drawing.Size(46, 20)
        Me.nmCount.TabIndex = 9
        '
        'cbObject
        '
        Me.cbObject.FormattingEnabled = True
        Me.cbObject.Location = New System.Drawing.Point(60, 33)
        Me.cbObject.Name = "cbObject"
        Me.cbObject.Size = New System.Drawing.Size(132, 21)
        Me.cbObject.TabIndex = 6
        '
        'cbCategory
        '
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Location = New System.Drawing.Point(60, 6)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(132, 21)
        Me.cbCategory.TabIndex = 1
        '
        'btnAddObject
        '
        Me.btnAddObject.Location = New System.Drawing.Point(254, 5)
        Me.btnAddObject.Name = "btnAddObject"
        Me.btnAddObject.Size = New System.Drawing.Size(73, 48)
        Me.btnAddObject.TabIndex = 5
        Me.btnAddObject.Text = "Thêm món"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.listBill)
        Me.PanelControl2.Location = New System.Drawing.Point(456, 92)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(332, 306)
        Me.PanelControl2.TabIndex = 3
        '
        'listBill
        '
        Me.listBill.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.listBill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listBill.GridLines = True
        Me.listBill.Location = New System.Drawing.Point(2, 2)
        Me.listBill.Name = "listBill"
        Me.listBill.Size = New System.Drawing.Size(328, 302)
        Me.listBill.TabIndex = 0
        Me.listBill.UseCompatibleStateImageBehavior = False
        Me.listBill.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Tên món"
        Me.ColumnHeader1.Width = 140
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Số lượng"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Đơn giá"
        Me.ColumnHeader3.Width = 53
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Thành tiền"
        Me.ColumnHeader4.Width = 69
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.cbSwichTable)
        Me.PanelControl3.Controls.Add(Me.btnCheckOut)
        Me.PanelControl3.Controls.Add(Me.txtTotal)
        Me.PanelControl3.Controls.Add(Me.nmDiscount)
        Me.PanelControl3.Controls.Add(Me.btnDiscount)
        Me.PanelControl3.Controls.Add(Me.btnSwichTable)
        Me.PanelControl3.Location = New System.Drawing.Point(456, 402)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(332, 60)
        Me.PanelControl3.TabIndex = 5
        '
        'cbSwichTable
        '
        Me.cbSwichTable.FormattingEnabled = True
        Me.cbSwichTable.Location = New System.Drawing.Point(3, 35)
        Me.cbSwichTable.Name = "cbSwichTable"
        Me.cbSwichTable.Size = New System.Drawing.Size(73, 21)
        Me.cbSwichTable.TabIndex = 7
        '
        'btnCheckOut
        '
        Me.btnCheckOut.Location = New System.Drawing.Point(254, 6)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(73, 48)
        Me.btnCheckOut.TabIndex = 10
        Me.btnCheckOut.Text = "Thanh toán"
        '
        'txtTotal
        '
        Me.txtTotal.EditValue = "0"
        Me.txtTotal.Location = New System.Drawing.Point(160, 20)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotal.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtTotal.Properties.Appearance.Options.UseFont = True
        Me.txtTotal.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotal.Properties.ReadOnly = True
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotal.Size = New System.Drawing.Size(90, 20)
        Me.txtTotal.TabIndex = 6
        '
        'nmDiscount
        '
        Me.nmDiscount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nmDiscount.Location = New System.Drawing.Point(82, 35)
        Me.nmDiscount.Name = "nmDiscount"
        Me.nmDiscount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.nmDiscount.Properties.IsFloatValue = False
        Me.nmDiscount.Properties.Mask.EditMask = "N00"
        Me.nmDiscount.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nmDiscount.Size = New System.Drawing.Size(72, 20)
        Me.nmDiscount.TabIndex = 8
        '
        'btnDiscount
        '
        Me.btnDiscount.Location = New System.Drawing.Point(82, 4)
        Me.btnDiscount.Name = "btnDiscount"
        Me.btnDiscount.Size = New System.Drawing.Size(73, 27)
        Me.btnDiscount.TabIndex = 9
        Me.btnDiscount.Text = "Giảm giá"
        '
        'btnSwichTable
        '
        Me.btnSwichTable.Location = New System.Drawing.Point(3, 4)
        Me.btnSwichTable.Name = "btnSwichTable"
        Me.btnSwichTable.Size = New System.Drawing.Size(73, 27)
        Me.btnSwichTable.TabIndex = 7
        Me.btnSwichTable.Text = "Chuyển bàn"
        '
        'tableLayout
        '
        Me.tableLayout.AutoScroll = True
        Me.tableLayout.Location = New System.Drawing.Point(12, 30)
        Me.tableLayout.Name = "tableLayout"
        Me.tableLayout.Size = New System.Drawing.Size(438, 432)
        Me.tableLayout.TabIndex = 1
        '
        'AdminStripMenu
        '
        Me.AdminStripMenu.Name = "AdminStripMenu"
        Me.AdminStripMenu.Size = New System.Drawing.Size(55, 20)
        Me.AdminStripMenu.Text = "Admin"
        '
        'AccountInfoToolStripMenu
        '
        Me.AccountInfoToolStripMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonalInfoToolStripMenu, Me.LogOutToolStripMenuItem})
        Me.AccountInfoToolStripMenu.Name = "AccountInfoToolStripMenu"
        Me.AccountInfoToolStripMenu.Size = New System.Drawing.Size(122, 20)
        Me.AccountInfoToolStripMenu.Text = "Thông tin tài khoản"
        '
        'PersonalInfoToolStripMenu
        '
        Me.PersonalInfoToolStripMenu.Name = "PersonalInfoToolStripMenu"
        Me.PersonalInfoToolStripMenu.Size = New System.Drawing.Size(170, 22)
        Me.PersonalInfoToolStripMenu.Text = "Thông tin cá nhân"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.LogOutToolStripMenuItem.Text = "Đăng xuất"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminStripMenu, Me.AccountInfoToolStripMenu, Me.CustomerToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.CustomerToolStripMenuItem.Text = "Khách hàng"
        '
        'FormBanHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 471)
        Me.Controls.Add(Me.tableLayout)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximumSize = New System.Drawing.Size(816, 510)
        Me.MinimumSize = New System.Drawing.Size(816, 510)
        Me.Name = "FormBanHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phần mềm quản lý quán cafe"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.nmCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnAddObject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSwichTable As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents nmDiscount As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnDiscount As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCheckOut As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents listBill As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tableLayout As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cbObject As System.Windows.Forms.ComboBox
    Friend WithEvents cbSwichTable As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nmCount As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AdminStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountInfoToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalInfoToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
