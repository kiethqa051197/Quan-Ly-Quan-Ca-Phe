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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.AdminStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountInfoToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalInfoToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tableLayout = New DevExpress.Utils.FlyoutPanel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.nmCount = New DevExpress.XtraEditors.SpinEdit()
        Me.btnAddObject = New DevExpress.XtraEditors.SimpleButton()
        Me.cbObject = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbCategory = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.listBill = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCheckOut = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.nmDiscount = New DevExpress.XtraEditors.SpinEdit()
        Me.cbSwichTable = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnDiscount = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSwichTable = New DevExpress.XtraEditors.SimpleButton()
        Me.MenuStrip.SuspendLayout()
        CType(Me.tableLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.nmCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbObject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSwichTable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminStripMenu, Me.AccountInfoToolStripMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
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
        'tableLayout
        '
        Me.tableLayout.Location = New System.Drawing.Point(12, 30)
        Me.tableLayout.Name = "tableLayout"
        Me.tableLayout.Size = New System.Drawing.Size(441, 432)
        Me.tableLayout.TabIndex = 1
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.nmCount)
        Me.PanelControl1.Controls.Add(Me.btnAddObject)
        Me.PanelControl1.Controls.Add(Me.cbObject)
        Me.PanelControl1.Controls.Add(Me.cbCategory)
        Me.PanelControl1.Location = New System.Drawing.Point(456, 30)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(332, 59)
        Me.PanelControl1.TabIndex = 2
        '
        'nmCount
        '
        Me.nmCount.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmCount.Location = New System.Drawing.Point(282, 20)
        Me.nmCount.Name = "nmCount"
        Me.nmCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.nmCount.Properties.IsFloatValue = False
        Me.nmCount.Properties.Mask.EditMask = "N00"
        Me.nmCount.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nmCount.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmCount.Size = New System.Drawing.Size(35, 20)
        Me.nmCount.TabIndex = 4
        '
        'btnAddObject
        '
        Me.btnAddObject.Location = New System.Drawing.Point(198, 6)
        Me.btnAddObject.Name = "btnAddObject"
        Me.btnAddObject.Size = New System.Drawing.Size(73, 48)
        Me.btnAddObject.TabIndex = 2
        Me.btnAddObject.Text = "Thêm món"
        '
        'cbObject
        '
        Me.cbObject.Location = New System.Drawing.Point(5, 32)
        Me.cbObject.Name = "cbObject"
        Me.cbObject.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbObject.Size = New System.Drawing.Size(183, 20)
        Me.cbObject.TabIndex = 1
        '
        'cbCategory
        '
        Me.cbCategory.Location = New System.Drawing.Point(5, 7)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCategory.Size = New System.Drawing.Size(183, 20)
        Me.cbCategory.TabIndex = 0
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
        Me.listBill.GridLines = True
        Me.listBill.Location = New System.Drawing.Point(3, 3)
        Me.listBill.Name = "listBill"
        Me.listBill.Size = New System.Drawing.Size(326, 299)
        Me.listBill.TabIndex = 0
        Me.listBill.UseCompatibleStateImageBehavior = False
        Me.listBill.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Tên món"
        Me.ColumnHeader1.Width = 88
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
        Me.PanelControl3.Controls.Add(Me.btnCheckOut)
        Me.PanelControl3.Controls.Add(Me.txtTotal)
        Me.PanelControl3.Controls.Add(Me.nmDiscount)
        Me.PanelControl3.Controls.Add(Me.cbSwichTable)
        Me.PanelControl3.Controls.Add(Me.btnDiscount)
        Me.PanelControl3.Controls.Add(Me.btnSwichTable)
        Me.PanelControl3.Location = New System.Drawing.Point(456, 402)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(332, 60)
        Me.PanelControl3.TabIndex = 5
        '
        'btnCheckOut
        '
        Me.btnCheckOut.Location = New System.Drawing.Point(254, 6)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(73, 48)
        Me.btnCheckOut.TabIndex = 5
        Me.btnCheckOut.Text = "Thanh toán"
        '
        'txtTotal
        '
        Me.txtTotal.EditValue = "0"
        Me.txtTotal.Location = New System.Drawing.Point(159, 19)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotal.Properties.Appearance.Options.UseFont = True
        Me.txtTotal.Properties.ReadOnly = True
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotal.Size = New System.Drawing.Size(90, 24)
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
        Me.nmDiscount.TabIndex = 5
        '
        'cbSwichTable
        '
        Me.cbSwichTable.Location = New System.Drawing.Point(3, 35)
        Me.cbSwichTable.Name = "cbSwichTable"
        Me.cbSwichTable.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbSwichTable.Size = New System.Drawing.Size(71, 20)
        Me.cbSwichTable.TabIndex = 5
        '
        'btnDiscount
        '
        Me.btnDiscount.Location = New System.Drawing.Point(82, 4)
        Me.btnDiscount.Name = "btnDiscount"
        Me.btnDiscount.Size = New System.Drawing.Size(73, 27)
        Me.btnDiscount.TabIndex = 3
        Me.btnDiscount.Text = "Giảm giá"
        '
        'btnSwichTable
        '
        Me.btnSwichTable.Location = New System.Drawing.Point(3, 4)
        Me.btnSwichTable.Name = "btnSwichTable"
        Me.btnSwichTable.Size = New System.Drawing.Size(73, 27)
        Me.btnSwichTable.TabIndex = 2
        Me.btnSwichTable.Text = "Chuyển bàn"
        '
        'FormBanHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 471)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.tableLayout)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximumSize = New System.Drawing.Size(816, 510)
        Me.MinimumSize = New System.Drawing.Size(816, 510)
        Me.Name = "FormBanHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phần mềm quản lý quán cafe"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.tableLayout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.nmCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbObject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSwichTable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents AdminStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountInfoToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tableLayout As DevExpress.Utils.FlyoutPanel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents nmCount As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnAddObject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbObject As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbCategory As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSwichTable As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents nmDiscount As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents cbSwichTable As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnDiscount As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCheckOut As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents listBill As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PersonalInfoToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
