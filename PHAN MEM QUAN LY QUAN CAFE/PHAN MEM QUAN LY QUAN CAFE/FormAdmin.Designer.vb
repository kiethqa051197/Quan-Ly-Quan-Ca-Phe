<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        Me.tcAdmin = New DevExpress.XtraTab.XtraTabControl()
        Me.tpTable = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl23 = New DevExpress.XtraEditors.PanelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.btnDeleteTable = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditTable = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddTable = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl50 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIDTable = New DevExpress.XtraEditors.TextEdit()
        Me.btnSaveTable = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelTable = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNameTable = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.dgvTable = New DevExpress.XtraGrid.GridControl()
        Me.gridTable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tpCategory = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl24 = New DevExpress.XtraEditors.PanelControl()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl()
        Me.btnDeleteCategory = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditCategory = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl47 = New DevExpress.XtraEditors.LabelControl()
        Me.btnAddCategory = New DevExpress.XtraEditors.SimpleButton()
        Me.txtIDCategory = New DevExpress.XtraEditors.TextEdit()
        Me.btnSaveCategory = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelCategory = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNameCategory = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.dgvCategory = New DevExpress.XtraGrid.GridControl()
        Me.gridCategory = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tpFood = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl15 = New DevExpress.XtraEditors.PanelControl()
        Me.btnDeleteFood = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.btnEditFood = New DevExpress.XtraEditors.SimpleButton()
        Me.txtIDFood = New DevExpress.XtraEditors.TextEdit()
        Me.btnAddFood = New DevExpress.XtraEditors.SimpleButton()
        Me.cbCategoryFood = New System.Windows.Forms.ComboBox()
        Me.nmPriceFood = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSaveFood = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelFood = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNameFood = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl16 = New DevExpress.XtraEditors.PanelControl()
        Me.dgvFood = New DevExpress.XtraGrid.GridControl()
        Me.gridFood = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl13 = New DevExpress.XtraEditors.PanelControl()
        Me.txtSearchFood = New DevExpress.XtraEditors.TextEdit()
        Me.btnSearchFood = New DevExpress.XtraEditors.SimpleButton()
        Me.tpCustomer = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl17 = New DevExpress.XtraEditors.PanelControl()
        Me.txtSearchCustomer = New DevExpress.XtraEditors.TextEdit()
        Me.btnSearchCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl18 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIDCustomer = New DevExpress.XtraEditors.TextEdit()
        Me.btnDeleteCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.btnAddCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.txtPhoneCustomer = New DevExpress.XtraEditors.TextEdit()
        Me.btnSaveCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNameCustomer = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl19 = New DevExpress.XtraEditors.PanelControl()
        Me.dgvCustomer = New DevExpress.XtraGrid.GridControl()
        Me.gridCustomer = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tpStaff = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl11 = New DevExpress.XtraEditors.PanelControl()
        Me.btnDeleteStaff = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl51 = New DevExpress.XtraEditors.LabelControl()
        Me.btnEditStaff = New DevExpress.XtraEditors.SimpleButton()
        Me.txtIDStaff = New DevExpress.XtraEditors.TextEdit()
        Me.btnAddStaff = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPhoneStaff = New DevExpress.XtraEditors.TextEdit()
        Me.btnResetPass = New DevExpress.XtraEditors.SimpleButton()
        Me.txtAddressStaff = New System.Windows.Forms.TextBox()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIDCardStaff = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpDOBStaff = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSaveStaff = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelStaff = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNameStaff = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl10 = New DevExpress.XtraEditors.PanelControl()
        Me.dgvStaff = New DevExpress.XtraGrid.GridControl()
        Me.gridStaff = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tpInventoryManagement = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl22 = New DevExpress.XtraEditors.PanelControl()
        Me.tcInputOutput = New DevExpress.XtraTab.XtraTabControl()
        Me.tpInput = New DevExpress.XtraTab.XtraTabPage()
        Me.panelTotal = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.btnAddObjectInput = New DevExpress.XtraEditors.SimpleButton()
        Me.cbbInputStatus = New System.Windows.Forms.ComboBox()
        Me.cbbInputObject = New System.Windows.Forms.ComboBox()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.nmInputPrice = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.nmInputCount = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.btnShowDetailBillInput = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDeleteInput = New DevExpress.XtraEditors.SimpleButton()
        Me.btEditInput = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddInput = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSaveInput = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelInput = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.dgvInput = New DevExpress.XtraGrid.GridControl()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpInput = New System.Windows.Forms.DateTimePicker()
        Me.tcInventory = New DevExpress.XtraTab.XtraTabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtgiatritrungbinh = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.txtDoanhThu = New System.Windows.Forms.TextBox()
        Me.btnView = New DevExpress.XtraEditors.SimpleButton()
        Me.tpOutput = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl21 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl12 = New DevExpress.XtraEditors.PanelControl()
        Me.cbOutputStatus = New System.Windows.Forms.ComboBox()
        Me.cbbOutputObject = New System.Windows.Forms.ComboBox()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.nmOutputCount = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton16 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton10 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton11 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton12 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton13 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.dgvOutput = New DevExpress.XtraGrid.GridControl()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpOutput = New System.Windows.Forms.DateTimePicker()
        Me.tpObject = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl29 = New DevExpress.XtraEditors.PanelControl()
        Me.cbbUnitObject = New System.Windows.Forms.ComboBox()
        Me.btnAddUnitObject = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddSupplierObject = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDeleteObject = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.btnEditObject = New DevExpress.XtraEditors.SimpleButton()
        Me.txtIDObject = New DevExpress.XtraEditors.TextEdit()
        Me.btnAddObject = New DevExpress.XtraEditors.SimpleButton()
        Me.cbbSuplierObject = New System.Windows.Forms.ComboBox()
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSaveObject = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelObject = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNameObject = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl30 = New DevExpress.XtraEditors.PanelControl()
        Me.dgvObject = New DevExpress.XtraGrid.GridControl()
        Me.gridObject = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl31 = New DevExpress.XtraEditors.PanelControl()
        Me.txtSearchObject = New DevExpress.XtraEditors.TextEdit()
        Me.btnSearchObject = New DevExpress.XtraEditors.SimpleButton()
        Me.tpUnit = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl27 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIDUnit = New DevExpress.XtraEditors.TextEdit()
        Me.btnAddUnit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditUnit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDeleteUnit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSaveUnit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelUnit = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNameUnit = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl28 = New DevExpress.XtraEditors.PanelControl()
        Me.dgvUnit = New DevExpress.XtraGrid.GridControl()
        Me.gridUnit = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl25 = New DevExpress.XtraEditors.PanelControl()
        Me.txtSearchUnit = New DevExpress.XtraEditors.TextEdit()
        Me.btnSearchUnit = New DevExpress.XtraEditors.SimpleButton()
        Me.tpSupplier = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl33 = New DevExpress.XtraEditors.PanelControl()
        Me.txtSearchSuplier = New DevExpress.XtraEditors.TextEdit()
        Me.btnSearchSuplier = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl34 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIDSupplier = New DevExpress.XtraEditors.TextEdit()
        Me.btnAddSupplier = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditSupplier = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDeleteSupplier = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmailSupplier = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPhoneSupplier = New DevExpress.XtraEditors.TextEdit()
        Me.txtAddressSupplier = New System.Windows.Forms.TextBox()
        Me.LabelControl46 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSaveSupplier = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelSupplier = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl48 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl49 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNameSupplier = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl35 = New DevExpress.XtraEditors.PanelControl()
        Me.dgvSuplier = New DevExpress.XtraGrid.GridControl()
        Me.gridSupplier = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
        CType(Me.tcAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcAdmin.SuspendLayout()
        Me.tpTable.SuspendLayout()
        CType(Me.PanelControl23, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl23.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.txtIDTable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameTable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCategory.SuspendLayout()
        CType(Me.PanelControl24, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl24.SuspendLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl8.SuspendLayout()
        CType(Me.txtIDCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpFood.SuspendLayout()
        CType(Me.PanelControl15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl15.SuspendLayout()
        CType(Me.txtIDFood.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmPriceFood.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameFood.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl16.SuspendLayout()
        CType(Me.dgvFood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridFood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl13.SuspendLayout()
        CType(Me.txtSearchFood.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCustomer.SuspendLayout()
        CType(Me.PanelControl17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl17.SuspendLayout()
        CType(Me.txtSearchCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl18, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl18.SuspendLayout()
        CType(Me.txtIDCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhoneCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl19, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl19.SuspendLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpStaff.SuspendLayout()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl11.SuspendLayout()
        CType(Me.txtIDStaff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhoneStaff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIDCardStaff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameStaff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl10.SuspendLayout()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpInventoryManagement.SuspendLayout()
        CType(Me.PanelControl22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl22.SuspendLayout()
        CType(Me.tcInputOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcInputOutput.SuspendLayout()
        Me.tpInput.SuspendLayout()
        CType(Me.panelTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTotal.SuspendLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.nmInputPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmInputCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.dgvInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcInventory.SuspendLayout()
        Me.tpOutput.SuspendLayout()
        CType(Me.PanelControl21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl21.SuspendLayout()
        CType(Me.PanelControl12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl12.SuspendLayout()
        CType(Me.nmOutputCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpObject.SuspendLayout()
        CType(Me.PanelControl29, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl29.SuspendLayout()
        CType(Me.txtIDObject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameObject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl30, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl30.SuspendLayout()
        CType(Me.dgvObject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridObject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl31, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl31.SuspendLayout()
        CType(Me.txtSearchObject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpUnit.SuspendLayout()
        CType(Me.PanelControl27, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl27.SuspendLayout()
        CType(Me.txtIDUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl28, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl28.SuspendLayout()
        CType(Me.dgvUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl25, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl25.SuspendLayout()
        CType(Me.txtSearchUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpSupplier.SuspendLayout()
        CType(Me.PanelControl33, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl33.SuspendLayout()
        CType(Me.txtSearchSuplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl34, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl34.SuspendLayout()
        CType(Me.txtIDSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmailSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhoneSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl35, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl35.SuspendLayout()
        CType(Me.dgvSuplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcAdmin
        '
        Me.tcAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcAdmin.Location = New System.Drawing.Point(0, 0)
        Me.tcAdmin.Name = "tcAdmin"
        Me.tcAdmin.SelectedTabPage = Me.tpTable
        Me.tcAdmin.Size = New System.Drawing.Size(751, 473)
        Me.tcAdmin.TabIndex = 0
        Me.tcAdmin.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tpTable, Me.tpCategory, Me.tpFood, Me.tpCustomer, Me.tpStaff, Me.tpInventoryManagement})
        '
        'tpTable
        '
        Me.tpTable.Controls.Add(Me.PanelControl23)
        Me.tpTable.Controls.Add(Me.PanelControl5)
        Me.tpTable.Controls.Add(Me.PanelControl3)
        Me.tpTable.Name = "tpTable"
        Me.tpTable.Size = New System.Drawing.Size(745, 445)
        Me.tpTable.Text = "Bàn ăn"
        '
        'PanelControl23
        '
        Me.PanelControl23.Controls.Add(Me.TextEdit1)
        Me.PanelControl23.Controls.Add(Me.SimpleButton1)
        Me.PanelControl23.Location = New System.Drawing.Point(418, 7)
        Me.PanelControl23.Name = "PanelControl23"
        Me.PanelControl23.Size = New System.Drawing.Size(318, 55)
        Me.PanelControl23.TabIndex = 11
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(14, 18)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(190, 20)
        Me.TextEdit1.TabIndex = 4
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(228, 5)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(85, 45)
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "Tìm"
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.btnDeleteTable)
        Me.PanelControl5.Controls.Add(Me.btnEditTable)
        Me.PanelControl5.Controls.Add(Me.btnAddTable)
        Me.PanelControl5.Controls.Add(Me.LabelControl50)
        Me.PanelControl5.Controls.Add(Me.txtIDTable)
        Me.PanelControl5.Controls.Add(Me.btnSaveTable)
        Me.PanelControl5.Controls.Add(Me.btnCancelTable)
        Me.PanelControl5.Controls.Add(Me.LabelControl1)
        Me.PanelControl5.Controls.Add(Me.LabelControl2)
        Me.PanelControl5.Controls.Add(Me.txtNameTable)
        Me.PanelControl5.Location = New System.Drawing.Point(418, 66)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(318, 371)
        Me.PanelControl5.TabIndex = 4
        '
        'btnDeleteTable
        '
        Me.btnDeleteTable.Location = New System.Drawing.Point(210, 256)
        Me.btnDeleteTable.Name = "btnDeleteTable"
        Me.btnDeleteTable.Size = New System.Drawing.Size(85, 45)
        Me.btnDeleteTable.TabIndex = 14
        Me.btnDeleteTable.Text = "Xoá"
        '
        'btnEditTable
        '
        Me.btnEditTable.Location = New System.Drawing.Point(119, 256)
        Me.btnEditTable.Name = "btnEditTable"
        Me.btnEditTable.Size = New System.Drawing.Size(85, 45)
        Me.btnEditTable.TabIndex = 13
        Me.btnEditTable.Text = "Sửa"
        '
        'btnAddTable
        '
        Me.btnAddTable.Location = New System.Drawing.Point(23, 256)
        Me.btnAddTable.Name = "btnAddTable"
        Me.btnAddTable.Size = New System.Drawing.Size(85, 45)
        Me.btnAddTable.TabIndex = 12
        Me.btnAddTable.Text = "Thêm"
        '
        'LabelControl50
        '
        Me.LabelControl50.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl50.Location = New System.Drawing.Point(20, 99)
        Me.LabelControl50.Name = "LabelControl50"
        Me.LabelControl50.Size = New System.Drawing.Size(18, 14)
        Me.LabelControl50.TabIndex = 10
        Me.LabelControl50.Text = "ID:"
        '
        'txtIDTable
        '
        Me.txtIDTable.Enabled = False
        Me.txtIDTable.Location = New System.Drawing.Point(119, 97)
        Me.txtIDTable.Name = "txtIDTable"
        Me.txtIDTable.Size = New System.Drawing.Size(176, 20)
        Me.txtIDTable.TabIndex = 11
        '
        'btnSaveTable
        '
        Me.btnSaveTable.Enabled = False
        Me.btnSaveTable.Location = New System.Drawing.Point(119, 307)
        Me.btnSaveTable.Name = "btnSaveTable"
        Me.btnSaveTable.Size = New System.Drawing.Size(85, 48)
        Me.btnSaveTable.TabIndex = 8
        Me.btnSaveTable.Text = "Lưu"
        '
        'btnCancelTable
        '
        Me.btnCancelTable.Enabled = False
        Me.btnCancelTable.Location = New System.Drawing.Point(210, 307)
        Me.btnCancelTable.Name = "btnCancelTable"
        Me.btnCancelTable.Size = New System.Drawing.Size(85, 48)
        Me.btnCancelTable.TabIndex = 9
        Me.btnCancelTable.Text = "Huỷ"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Location = New System.Drawing.Point(89, 45)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(149, 18)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "THÔNG TIN BÀN ĂN"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(20, 134)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 14)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Tên bàn:"
        '
        'txtNameTable
        '
        Me.txtNameTable.Enabled = False
        Me.txtNameTable.Location = New System.Drawing.Point(119, 132)
        Me.txtNameTable.Name = "txtNameTable"
        Me.txtNameTable.Size = New System.Drawing.Size(176, 20)
        Me.txtNameTable.TabIndex = 6
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.dgvTable)
        Me.PanelControl3.Location = New System.Drawing.Point(3, 5)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(409, 434)
        Me.PanelControl3.TabIndex = 2
        '
        'dgvTable
        '
        Me.dgvTable.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvTable.Location = New System.Drawing.Point(2, 2)
        Me.dgvTable.MainView = Me.gridTable
        Me.dgvTable.Name = "dgvTable"
        Me.dgvTable.Size = New System.Drawing.Size(405, 430)
        Me.dgvTable.TabIndex = 2
        Me.dgvTable.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridTable})
        '
        'gridTable
        '
        Me.gridTable.GridControl = Me.dgvTable
        Me.gridTable.Name = "gridTable"
        '
        'tpCategory
        '
        Me.tpCategory.Controls.Add(Me.PanelControl24)
        Me.tpCategory.Controls.Add(Me.PanelControl8)
        Me.tpCategory.Controls.Add(Me.PanelControl7)
        Me.tpCategory.Name = "tpCategory"
        Me.tpCategory.Size = New System.Drawing.Size(745, 445)
        Me.tpCategory.Text = "Danh mục"
        '
        'PanelControl24
        '
        Me.PanelControl24.Controls.Add(Me.TextEdit3)
        Me.PanelControl24.Controls.Add(Me.SimpleButton2)
        Me.PanelControl24.Location = New System.Drawing.Point(418, 5)
        Me.PanelControl24.Name = "PanelControl24"
        Me.PanelControl24.Size = New System.Drawing.Size(318, 55)
        Me.PanelControl24.TabIndex = 11
        '
        'TextEdit3
        '
        Me.TextEdit3.Location = New System.Drawing.Point(14, 18)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(190, 20)
        Me.TextEdit3.TabIndex = 4
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(228, 5)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(85, 45)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "Tìm"
        '
        'PanelControl8
        '
        Me.PanelControl8.Controls.Add(Me.btnDeleteCategory)
        Me.PanelControl8.Controls.Add(Me.btnEditCategory)
        Me.PanelControl8.Controls.Add(Me.LabelControl47)
        Me.PanelControl8.Controls.Add(Me.btnAddCategory)
        Me.PanelControl8.Controls.Add(Me.txtIDCategory)
        Me.PanelControl8.Controls.Add(Me.btnSaveCategory)
        Me.PanelControl8.Controls.Add(Me.btnCancelCategory)
        Me.PanelControl8.Controls.Add(Me.LabelControl4)
        Me.PanelControl8.Controls.Add(Me.LabelControl6)
        Me.PanelControl8.Controls.Add(Me.txtNameCategory)
        Me.PanelControl8.Location = New System.Drawing.Point(418, 66)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(318, 374)
        Me.PanelControl8.TabIndex = 6
        '
        'btnDeleteCategory
        '
        Me.btnDeleteCategory.Location = New System.Drawing.Point(228, 248)
        Me.btnDeleteCategory.Name = "btnDeleteCategory"
        Me.btnDeleteCategory.Size = New System.Drawing.Size(85, 45)
        Me.btnDeleteCategory.TabIndex = 3
        Me.btnDeleteCategory.Text = "Xoá"
        '
        'btnEditCategory
        '
        Me.btnEditCategory.Location = New System.Drawing.Point(119, 248)
        Me.btnEditCategory.Name = "btnEditCategory"
        Me.btnEditCategory.Size = New System.Drawing.Size(85, 45)
        Me.btnEditCategory.TabIndex = 2
        Me.btnEditCategory.Text = "Sửa"
        '
        'LabelControl47
        '
        Me.LabelControl47.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl47.Location = New System.Drawing.Point(20, 111)
        Me.LabelControl47.Name = "LabelControl47"
        Me.LabelControl47.Size = New System.Drawing.Size(18, 14)
        Me.LabelControl47.TabIndex = 9
        Me.LabelControl47.Text = "ID:"
        '
        'btnAddCategory
        '
        Me.btnAddCategory.Location = New System.Drawing.Point(14, 248)
        Me.btnAddCategory.Name = "btnAddCategory"
        Me.btnAddCategory.Size = New System.Drawing.Size(85, 45)
        Me.btnAddCategory.TabIndex = 1
        Me.btnAddCategory.Text = "Thêm"
        '
        'txtIDCategory
        '
        Me.txtIDCategory.Enabled = False
        Me.txtIDCategory.Location = New System.Drawing.Point(119, 109)
        Me.txtIDCategory.Name = "txtIDCategory"
        Me.txtIDCategory.Size = New System.Drawing.Size(176, 20)
        Me.txtIDCategory.TabIndex = 10
        '
        'btnSaveCategory
        '
        Me.btnSaveCategory.Enabled = False
        Me.btnSaveCategory.Location = New System.Drawing.Point(119, 299)
        Me.btnSaveCategory.Name = "btnSaveCategory"
        Me.btnSaveCategory.Size = New System.Drawing.Size(85, 45)
        Me.btnSaveCategory.TabIndex = 7
        Me.btnSaveCategory.Text = "Lưu"
        '
        'btnCancelCategory
        '
        Me.btnCancelCategory.Enabled = False
        Me.btnCancelCategory.Location = New System.Drawing.Point(228, 299)
        Me.btnCancelCategory.Name = "btnCancelCategory"
        Me.btnCancelCategory.Size = New System.Drawing.Size(85, 45)
        Me.btnCancelCategory.TabIndex = 8
        Me.btnCancelCategory.Text = "Huỷ"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Location = New System.Drawing.Point(82, 25)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(173, 18)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "THÔNG TIN DANH MỤC"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Location = New System.Drawing.Point(20, 139)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(90, 14)
        Me.LabelControl6.TabIndex = 6
        Me.LabelControl6.Text = "Tên danh mục:"
        '
        'txtNameCategory
        '
        Me.txtNameCategory.Enabled = False
        Me.txtNameCategory.Location = New System.Drawing.Point(119, 137)
        Me.txtNameCategory.Name = "txtNameCategory"
        Me.txtNameCategory.Size = New System.Drawing.Size(176, 20)
        Me.txtNameCategory.TabIndex = 6
        '
        'PanelControl7
        '
        Me.PanelControl7.Controls.Add(Me.dgvCategory)
        Me.PanelControl7.Location = New System.Drawing.Point(3, 5)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(409, 434)
        Me.PanelControl7.TabIndex = 5
        '
        'dgvCategory
        '
        Me.dgvCategory.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCategory.Location = New System.Drawing.Point(2, 2)
        Me.dgvCategory.MainView = Me.gridCategory
        Me.dgvCategory.Name = "dgvCategory"
        Me.dgvCategory.Size = New System.Drawing.Size(405, 430)
        Me.dgvCategory.TabIndex = 2
        Me.dgvCategory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridCategory})
        '
        'gridCategory
        '
        Me.gridCategory.GridControl = Me.dgvCategory
        Me.gridCategory.Name = "gridCategory"
        '
        'tpFood
        '
        Me.tpFood.Controls.Add(Me.PanelControl15)
        Me.tpFood.Controls.Add(Me.PanelControl16)
        Me.tpFood.Controls.Add(Me.PanelControl13)
        Me.tpFood.Name = "tpFood"
        Me.tpFood.Size = New System.Drawing.Size(745, 445)
        Me.tpFood.Text = "Thức ăn"
        '
        'PanelControl15
        '
        Me.PanelControl15.Controls.Add(Me.btnDeleteFood)
        Me.PanelControl15.Controls.Add(Me.LabelControl33)
        Me.PanelControl15.Controls.Add(Me.btnEditFood)
        Me.PanelControl15.Controls.Add(Me.txtIDFood)
        Me.PanelControl15.Controls.Add(Me.btnAddFood)
        Me.PanelControl15.Controls.Add(Me.cbCategoryFood)
        Me.PanelControl15.Controls.Add(Me.nmPriceFood)
        Me.PanelControl15.Controls.Add(Me.LabelControl13)
        Me.PanelControl15.Controls.Add(Me.LabelControl14)
        Me.PanelControl15.Controls.Add(Me.btnSaveFood)
        Me.PanelControl15.Controls.Add(Me.btnCancelFood)
        Me.PanelControl15.Controls.Add(Me.LabelControl18)
        Me.PanelControl15.Controls.Add(Me.LabelControl19)
        Me.PanelControl15.Controls.Add(Me.txtNameFood)
        Me.PanelControl15.Location = New System.Drawing.Point(418, 66)
        Me.PanelControl15.Name = "PanelControl15"
        Me.PanelControl15.Size = New System.Drawing.Size(318, 379)
        Me.PanelControl15.TabIndex = 1
        '
        'btnDeleteFood
        '
        Me.btnDeleteFood.Location = New System.Drawing.Point(211, 224)
        Me.btnDeleteFood.Name = "btnDeleteFood"
        Me.btnDeleteFood.Size = New System.Drawing.Size(85, 45)
        Me.btnDeleteFood.TabIndex = 3
        Me.btnDeleteFood.Text = "Xoá"
        '
        'LabelControl33
        '
        Me.LabelControl33.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl33.Location = New System.Drawing.Point(13, 96)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(18, 14)
        Me.LabelControl33.TabIndex = 29
        Me.LabelControl33.Text = "ID:"
        '
        'btnEditFood
        '
        Me.btnEditFood.Location = New System.Drawing.Point(114, 224)
        Me.btnEditFood.Name = "btnEditFood"
        Me.btnEditFood.Size = New System.Drawing.Size(85, 45)
        Me.btnEditFood.TabIndex = 2
        Me.btnEditFood.Text = "Sửa"
        '
        'txtIDFood
        '
        Me.txtIDFood.Enabled = False
        Me.txtIDFood.Location = New System.Drawing.Point(119, 95)
        Me.txtIDFood.Name = "txtIDFood"
        Me.txtIDFood.Size = New System.Drawing.Size(176, 20)
        Me.txtIDFood.TabIndex = 30
        '
        'btnAddFood
        '
        Me.btnAddFood.Location = New System.Drawing.Point(13, 224)
        Me.btnAddFood.Name = "btnAddFood"
        Me.btnAddFood.Size = New System.Drawing.Size(85, 45)
        Me.btnAddFood.TabIndex = 1
        Me.btnAddFood.Text = "Thêm"
        '
        'cbCategoryFood
        '
        Me.cbCategoryFood.Enabled = False
        Me.cbCategoryFood.FormattingEnabled = True
        Me.cbCategoryFood.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.cbCategoryFood.Location = New System.Drawing.Point(120, 154)
        Me.cbCategoryFood.Name = "cbCategoryFood"
        Me.cbCategoryFood.Size = New System.Drawing.Size(176, 21)
        Me.cbCategoryFood.TabIndex = 28
        '
        'nmPriceFood
        '
        Me.nmPriceFood.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nmPriceFood.Enabled = False
        Me.nmPriceFood.Location = New System.Drawing.Point(120, 182)
        Me.nmPriceFood.Name = "nmPriceFood"
        Me.nmPriceFood.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.nmPriceFood.Properties.IsFloatValue = False
        Me.nmPriceFood.Properties.Mask.EditMask = "N00"
        Me.nmPriceFood.Properties.MaxValue = New Decimal(New Integer() {500000, 0, 0, 0})
        Me.nmPriceFood.Size = New System.Drawing.Size(176, 20)
        Me.nmPriceFood.TabIndex = 8
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl13.Location = New System.Drawing.Point(15, 184)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(49, 14)
        Me.LabelControl13.TabIndex = 27
        Me.LabelControl13.Text = "Giá bán:"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl14.Location = New System.Drawing.Point(13, 155)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(65, 14)
        Me.LabelControl14.TabIndex = 24
        Me.LabelControl14.Text = "Danh mục:"
        '
        'btnSaveFood
        '
        Me.btnSaveFood.Location = New System.Drawing.Point(115, 275)
        Me.btnSaveFood.Name = "btnSaveFood"
        Me.btnSaveFood.Size = New System.Drawing.Size(85, 44)
        Me.btnSaveFood.TabIndex = 9
        Me.btnSaveFood.Text = "Lưu"
        '
        'btnCancelFood
        '
        Me.btnCancelFood.Location = New System.Drawing.Point(211, 275)
        Me.btnCancelFood.Name = "btnCancelFood"
        Me.btnCancelFood.Size = New System.Drawing.Size(85, 44)
        Me.btnCancelFood.TabIndex = 10
        Me.btnCancelFood.Text = "Huỷ"
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl18.Location = New System.Drawing.Point(83, 5)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(159, 18)
        Me.LabelControl18.TabIndex = 8
        Me.LabelControl18.Text = "THÔNG TIN THỨC ĂN"
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl19.Location = New System.Drawing.Point(14, 127)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(78, 14)
        Me.LabelControl19.TabIndex = 6
        Me.LabelControl19.Text = "Tên thức ăn:"
        '
        'txtNameFood
        '
        Me.txtNameFood.Enabled = False
        Me.txtNameFood.Location = New System.Drawing.Point(120, 126)
        Me.txtNameFood.Name = "txtNameFood"
        Me.txtNameFood.Size = New System.Drawing.Size(176, 20)
        Me.txtNameFood.TabIndex = 6
        '
        'PanelControl16
        '
        Me.PanelControl16.Controls.Add(Me.dgvFood)
        Me.PanelControl16.Location = New System.Drawing.Point(3, 5)
        Me.PanelControl16.Name = "PanelControl16"
        Me.PanelControl16.Size = New System.Drawing.Size(409, 434)
        Me.PanelControl16.TabIndex = 11
        '
        'dgvFood
        '
        Me.dgvFood.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvFood.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFood.Location = New System.Drawing.Point(2, 2)
        Me.dgvFood.MainView = Me.gridFood
        Me.dgvFood.Name = "dgvFood"
        Me.dgvFood.Size = New System.Drawing.Size(405, 430)
        Me.dgvFood.TabIndex = 2
        Me.dgvFood.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridFood})
        '
        'gridFood
        '
        Me.gridFood.GridControl = Me.dgvFood
        Me.gridFood.Name = "gridFood"
        '
        'PanelControl13
        '
        Me.PanelControl13.Controls.Add(Me.txtSearchFood)
        Me.PanelControl13.Controls.Add(Me.btnSearchFood)
        Me.PanelControl13.Location = New System.Drawing.Point(418, 5)
        Me.PanelControl13.Name = "PanelControl13"
        Me.PanelControl13.Size = New System.Drawing.Size(318, 55)
        Me.PanelControl13.TabIndex = 10
        '
        'txtSearchFood
        '
        Me.txtSearchFood.Location = New System.Drawing.Point(14, 18)
        Me.txtSearchFood.Name = "txtSearchFood"
        Me.txtSearchFood.Size = New System.Drawing.Size(190, 20)
        Me.txtSearchFood.TabIndex = 4
        '
        'btnSearchFood
        '
        Me.btnSearchFood.Location = New System.Drawing.Point(228, 5)
        Me.btnSearchFood.Name = "btnSearchFood"
        Me.btnSearchFood.Size = New System.Drawing.Size(85, 45)
        Me.btnSearchFood.TabIndex = 5
        Me.btnSearchFood.Text = "Tìm"
        '
        'tpCustomer
        '
        Me.tpCustomer.Controls.Add(Me.PanelControl17)
        Me.tpCustomer.Controls.Add(Me.PanelControl18)
        Me.tpCustomer.Controls.Add(Me.PanelControl19)
        Me.tpCustomer.Name = "tpCustomer"
        Me.tpCustomer.Size = New System.Drawing.Size(745, 445)
        Me.tpCustomer.Text = "Khách hàng"
        '
        'PanelControl17
        '
        Me.PanelControl17.Controls.Add(Me.txtSearchCustomer)
        Me.PanelControl17.Controls.Add(Me.btnSearchCustomer)
        Me.PanelControl17.Location = New System.Drawing.Point(418, 5)
        Me.PanelControl17.Name = "PanelControl17"
        Me.PanelControl17.Size = New System.Drawing.Size(318, 55)
        Me.PanelControl17.TabIndex = 12
        '
        'txtSearchCustomer
        '
        Me.txtSearchCustomer.Location = New System.Drawing.Point(14, 18)
        Me.txtSearchCustomer.Name = "txtSearchCustomer"
        Me.txtSearchCustomer.Size = New System.Drawing.Size(190, 20)
        Me.txtSearchCustomer.TabIndex = 4
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.Location = New System.Drawing.Point(228, 5)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(85, 45)
        Me.btnSearchCustomer.TabIndex = 5
        Me.btnSearchCustomer.Text = "Tìm"
        '
        'PanelControl18
        '
        Me.PanelControl18.Controls.Add(Me.LabelControl3)
        Me.PanelControl18.Controls.Add(Me.txtIDCustomer)
        Me.PanelControl18.Controls.Add(Me.btnDeleteCustomer)
        Me.PanelControl18.Controls.Add(Me.btnEditCustomer)
        Me.PanelControl18.Controls.Add(Me.LabelControl15)
        Me.PanelControl18.Controls.Add(Me.btnAddCustomer)
        Me.PanelControl18.Controls.Add(Me.txtPhoneCustomer)
        Me.PanelControl18.Controls.Add(Me.btnSaveCustomer)
        Me.PanelControl18.Controls.Add(Me.btnCancelCustomer)
        Me.PanelControl18.Controls.Add(Me.LabelControl22)
        Me.PanelControl18.Controls.Add(Me.LabelControl23)
        Me.PanelControl18.Controls.Add(Me.txtNameCustomer)
        Me.PanelControl18.Location = New System.Drawing.Point(418, 66)
        Me.PanelControl18.Name = "PanelControl18"
        Me.PanelControl18.Size = New System.Drawing.Size(318, 372)
        Me.PanelControl18.TabIndex = 11
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Location = New System.Drawing.Point(13, 71)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(18, 14)
        Me.LabelControl3.TabIndex = 24
        Me.LabelControl3.Text = "ID:"
        '
        'txtIDCustomer
        '
        Me.txtIDCustomer.Enabled = False
        Me.txtIDCustomer.Location = New System.Drawing.Point(128, 70)
        Me.txtIDCustomer.Name = "txtIDCustomer"
        Me.txtIDCustomer.Size = New System.Drawing.Size(167, 20)
        Me.txtIDCustomer.TabIndex = 25
        '
        'btnDeleteCustomer
        '
        Me.btnDeleteCustomer.Location = New System.Drawing.Point(210, 210)
        Me.btnDeleteCustomer.Name = "btnDeleteCustomer"
        Me.btnDeleteCustomer.Size = New System.Drawing.Size(85, 45)
        Me.btnDeleteCustomer.TabIndex = 3
        Me.btnDeleteCustomer.Text = "Xoá"
        '
        'btnEditCustomer
        '
        Me.btnEditCustomer.Location = New System.Drawing.Point(110, 210)
        Me.btnEditCustomer.Name = "btnEditCustomer"
        Me.btnEditCustomer.Size = New System.Drawing.Size(85, 45)
        Me.btnEditCustomer.TabIndex = 2
        Me.btnEditCustomer.Text = "Sửa"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl15.Location = New System.Drawing.Point(14, 145)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(86, 14)
        Me.LabelControl15.TabIndex = 23
        Me.LabelControl15.Text = "Số điện thoại:"
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Location = New System.Drawing.Point(13, 210)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(85, 45)
        Me.btnAddCustomer.TabIndex = 1
        Me.btnAddCustomer.Text = "Thêm"
        '
        'txtPhoneCustomer
        '
        Me.txtPhoneCustomer.Enabled = False
        Me.txtPhoneCustomer.Location = New System.Drawing.Point(128, 143)
        Me.txtPhoneCustomer.Name = "txtPhoneCustomer"
        Me.txtPhoneCustomer.Size = New System.Drawing.Size(167, 20)
        Me.txtPhoneCustomer.TabIndex = 11
        '
        'btnSaveCustomer
        '
        Me.btnSaveCustomer.Location = New System.Drawing.Point(110, 261)
        Me.btnSaveCustomer.Name = "btnSaveCustomer"
        Me.btnSaveCustomer.Size = New System.Drawing.Size(85, 44)
        Me.btnSaveCustomer.TabIndex = 12
        Me.btnSaveCustomer.Text = "Lưu"
        '
        'btnCancelCustomer
        '
        Me.btnCancelCustomer.Location = New System.Drawing.Point(210, 261)
        Me.btnCancelCustomer.Name = "btnCancelCustomer"
        Me.btnCancelCustomer.Size = New System.Drawing.Size(85, 44)
        Me.btnCancelCustomer.TabIndex = 13
        Me.btnCancelCustomer.Text = "Huỷ"
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl22.Location = New System.Drawing.Point(82, 21)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(191, 18)
        Me.LabelControl22.TabIndex = 8
        Me.LabelControl22.Text = "THÔNG TIN KHÁCH HÀNG"
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl23.Location = New System.Drawing.Point(13, 106)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(101, 14)
        Me.LabelControl23.TabIndex = 6
        Me.LabelControl23.Text = "Tên khách hàng:"
        '
        'txtNameCustomer
        '
        Me.txtNameCustomer.Enabled = False
        Me.txtNameCustomer.Location = New System.Drawing.Point(128, 105)
        Me.txtNameCustomer.Name = "txtNameCustomer"
        Me.txtNameCustomer.Size = New System.Drawing.Size(167, 20)
        Me.txtNameCustomer.TabIndex = 6
        '
        'PanelControl19
        '
        Me.PanelControl19.Controls.Add(Me.dgvCustomer)
        Me.PanelControl19.Location = New System.Drawing.Point(3, 5)
        Me.PanelControl19.Name = "PanelControl19"
        Me.PanelControl19.Size = New System.Drawing.Size(409, 434)
        Me.PanelControl19.TabIndex = 10
        '
        'dgvCustomer
        '
        Me.dgvCustomer.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCustomer.Location = New System.Drawing.Point(2, 2)
        Me.dgvCustomer.MainView = Me.gridCustomer
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.Size = New System.Drawing.Size(405, 430)
        Me.dgvCustomer.TabIndex = 2
        Me.dgvCustomer.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridCustomer})
        '
        'gridCustomer
        '
        Me.gridCustomer.GridControl = Me.dgvCustomer
        Me.gridCustomer.Name = "gridCustomer"
        '
        'tpStaff
        '
        Me.tpStaff.Controls.Add(Me.PanelControl11)
        Me.tpStaff.Controls.Add(Me.PanelControl10)
        Me.tpStaff.Name = "tpStaff"
        Me.tpStaff.Size = New System.Drawing.Size(745, 445)
        Me.tpStaff.Text = "Nhân viên"
        '
        'PanelControl11
        '
        Me.PanelControl11.Controls.Add(Me.btnDeleteStaff)
        Me.PanelControl11.Controls.Add(Me.LabelControl51)
        Me.PanelControl11.Controls.Add(Me.btnEditStaff)
        Me.PanelControl11.Controls.Add(Me.txtIDStaff)
        Me.PanelControl11.Controls.Add(Me.btnAddStaff)
        Me.PanelControl11.Controls.Add(Me.LabelControl12)
        Me.PanelControl11.Controls.Add(Me.txtPhoneStaff)
        Me.PanelControl11.Controls.Add(Me.btnResetPass)
        Me.PanelControl11.Controls.Add(Me.txtAddressStaff)
        Me.PanelControl11.Controls.Add(Me.LabelControl10)
        Me.PanelControl11.Controls.Add(Me.txtIDCardStaff)
        Me.PanelControl11.Controls.Add(Me.LabelControl9)
        Me.PanelControl11.Controls.Add(Me.dtpDOBStaff)
        Me.PanelControl11.Controls.Add(Me.LabelControl8)
        Me.PanelControl11.Controls.Add(Me.btnSaveStaff)
        Me.PanelControl11.Controls.Add(Me.btnCancelStaff)
        Me.PanelControl11.Controls.Add(Me.LabelControl5)
        Me.PanelControl11.Controls.Add(Me.LabelControl7)
        Me.PanelControl11.Controls.Add(Me.txtNameStaff)
        Me.PanelControl11.Location = New System.Drawing.Point(418, 5)
        Me.PanelControl11.Name = "PanelControl11"
        Me.PanelControl11.Size = New System.Drawing.Size(318, 432)
        Me.PanelControl11.TabIndex = 7
        '
        'btnDeleteStaff
        '
        Me.btnDeleteStaff.Location = New System.Drawing.Point(211, 290)
        Me.btnDeleteStaff.Name = "btnDeleteStaff"
        Me.btnDeleteStaff.Size = New System.Drawing.Size(85, 45)
        Me.btnDeleteStaff.TabIndex = 2
        Me.btnDeleteStaff.Text = "Xoá"
        '
        'LabelControl51
        '
        Me.LabelControl51.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl51.Location = New System.Drawing.Point(14, 38)
        Me.LabelControl51.Name = "LabelControl51"
        Me.LabelControl51.Size = New System.Drawing.Size(18, 14)
        Me.LabelControl51.TabIndex = 26
        Me.LabelControl51.Text = "ID:"
        '
        'btnEditStaff
        '
        Me.btnEditStaff.Location = New System.Drawing.Point(113, 290)
        Me.btnEditStaff.Name = "btnEditStaff"
        Me.btnEditStaff.Size = New System.Drawing.Size(85, 45)
        Me.btnEditStaff.TabIndex = 1
        Me.btnEditStaff.Text = "Sửa"
        '
        'txtIDStaff
        '
        Me.txtIDStaff.Enabled = False
        Me.txtIDStaff.Location = New System.Drawing.Point(120, 37)
        Me.txtIDStaff.Name = "txtIDStaff"
        Me.txtIDStaff.Size = New System.Drawing.Size(176, 20)
        Me.txtIDStaff.TabIndex = 25
        '
        'btnAddStaff
        '
        Me.btnAddStaff.Location = New System.Drawing.Point(13, 290)
        Me.btnAddStaff.Name = "btnAddStaff"
        Me.btnAddStaff.Size = New System.Drawing.Size(85, 45)
        Me.btnAddStaff.TabIndex = 0
        Me.btnAddStaff.Text = "Thêm"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl12.Location = New System.Drawing.Point(15, 258)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(86, 14)
        Me.LabelControl12.TabIndex = 23
        Me.LabelControl12.Text = "Số điện thoại:"
        '
        'txtPhoneStaff
        '
        Me.txtPhoneStaff.Enabled = False
        Me.txtPhoneStaff.Location = New System.Drawing.Point(120, 256)
        Me.txtPhoneStaff.Name = "txtPhoneStaff"
        Me.txtPhoneStaff.Size = New System.Drawing.Size(176, 20)
        Me.txtPhoneStaff.TabIndex = 10
        '
        'btnResetPass
        '
        Me.btnResetPass.Location = New System.Drawing.Point(13, 386)
        Me.btnResetPass.Name = "btnResetPass"
        Me.btnResetPass.Size = New System.Drawing.Size(283, 37)
        Me.btnResetPass.TabIndex = 12
        Me.btnResetPass.Text = "Đặt lại tài khoản"
        '
        'txtAddressStaff
        '
        Me.txtAddressStaff.Enabled = False
        Me.txtAddressStaff.Location = New System.Drawing.Point(120, 140)
        Me.txtAddressStaff.Multiline = True
        Me.txtAddressStaff.Name = "txtAddressStaff"
        Me.txtAddressStaff.Size = New System.Drawing.Size(176, 64)
        Me.txtAddressStaff.TabIndex = 7
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl10.Location = New System.Drawing.Point(14, 220)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(88, 14)
        Me.LabelControl10.TabIndex = 16
        Me.LabelControl10.Text = "CMND / CCCD:"
        '
        'txtIDCardStaff
        '
        Me.txtIDCardStaff.Enabled = False
        Me.txtIDCardStaff.Location = New System.Drawing.Point(119, 218)
        Me.txtIDCardStaff.Name = "txtIDCardStaff"
        Me.txtIDCardStaff.Size = New System.Drawing.Size(176, 20)
        Me.txtIDCardStaff.TabIndex = 8
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Location = New System.Drawing.Point(15, 140)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(44, 14)
        Me.LabelControl9.TabIndex = 14
        Me.LabelControl9.Text = "Địa chỉ:"
        '
        'dtpDOBStaff
        '
        Me.dtpDOBStaff.Enabled = False
        Me.dtpDOBStaff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDOBStaff.Location = New System.Drawing.Point(121, 102)
        Me.dtpDOBStaff.Name = "dtpDOBStaff"
        Me.dtpDOBStaff.Size = New System.Drawing.Size(176, 20)
        Me.dtpDOBStaff.TabIndex = 6
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl8.Location = New System.Drawing.Point(16, 104)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(63, 14)
        Me.LabelControl8.TabIndex = 11
        Me.LabelControl8.Text = "Ngày sinh:"
        '
        'btnSaveStaff
        '
        Me.btnSaveStaff.Location = New System.Drawing.Point(13, 341)
        Me.btnSaveStaff.Name = "btnSaveStaff"
        Me.btnSaveStaff.Size = New System.Drawing.Size(135, 39)
        Me.btnSaveStaff.TabIndex = 11
        Me.btnSaveStaff.Text = "Lưu"
        '
        'btnCancelStaff
        '
        Me.btnCancelStaff.Location = New System.Drawing.Point(154, 341)
        Me.btnCancelStaff.Name = "btnCancelStaff"
        Me.btnCancelStaff.Size = New System.Drawing.Size(142, 39)
        Me.btnCancelStaff.TabIndex = 12
        Me.btnCancelStaff.Text = "Huỷ"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Location = New System.Drawing.Point(83, 5)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(178, 18)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "THÔNG TIN NHÂN VIÊN"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl7.Location = New System.Drawing.Point(15, 69)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(90, 14)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "Tên nhân viên:"
        '
        'txtNameStaff
        '
        Me.txtNameStaff.Enabled = False
        Me.txtNameStaff.Location = New System.Drawing.Point(121, 68)
        Me.txtNameStaff.Name = "txtNameStaff"
        Me.txtNameStaff.Size = New System.Drawing.Size(176, 20)
        Me.txtNameStaff.TabIndex = 5
        '
        'PanelControl10
        '
        Me.PanelControl10.Controls.Add(Me.dgvStaff)
        Me.PanelControl10.Location = New System.Drawing.Point(3, 5)
        Me.PanelControl10.Name = "PanelControl10"
        Me.PanelControl10.Size = New System.Drawing.Size(409, 434)
        Me.PanelControl10.TabIndex = 6
        '
        'dgvStaff
        '
        Me.dgvStaff.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStaff.Location = New System.Drawing.Point(2, 2)
        Me.dgvStaff.MainView = Me.gridStaff
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.Size = New System.Drawing.Size(405, 430)
        Me.dgvStaff.TabIndex = 2
        Me.dgvStaff.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridStaff})
        '
        'gridStaff
        '
        Me.gridStaff.GridControl = Me.dgvStaff
        Me.gridStaff.Name = "gridStaff"
        '
        'tpInventoryManagement
        '
        Me.tpInventoryManagement.Controls.Add(Me.PanelControl22)
        Me.tpInventoryManagement.Name = "tpInventoryManagement"
        Me.tpInventoryManagement.Size = New System.Drawing.Size(745, 445)
        Me.tpInventoryManagement.Text = "Quản lý kho"
        '
        'PanelControl22
        '
        Me.PanelControl22.Controls.Add(Me.tcInputOutput)
        Me.PanelControl22.Location = New System.Drawing.Point(3, 3)
        Me.PanelControl22.Name = "PanelControl22"
        Me.PanelControl22.Size = New System.Drawing.Size(734, 439)
        Me.PanelControl22.TabIndex = 2
        '
        'tcInputOutput
        '
        Me.tcInputOutput.Location = New System.Drawing.Point(5, 5)
        Me.tcInputOutput.Name = "tcInputOutput"
        Me.tcInputOutput.SelectedTabPage = Me.tpInput
        Me.tcInputOutput.Size = New System.Drawing.Size(724, 429)
        Me.tcInputOutput.TabIndex = 0
        Me.tcInputOutput.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tcInventory, Me.tpInput, Me.tpOutput, Me.tpObject, Me.tpUnit, Me.tpSupplier})
        '
        'tpInput
        '
        Me.tpInput.Controls.Add(Me.panelTotal)
        Me.tpInput.Name = "tpInput"
        Me.tpInput.Size = New System.Drawing.Size(718, 401)
        Me.tpInput.Text = "Nhập kho"
        '
        'panelTotal
        '
        Me.panelTotal.Controls.Add(Me.PanelControl6)
        Me.panelTotal.Controls.Add(Me.PanelControl4)
        Me.panelTotal.Controls.Add(Me.LabelControl29)
        Me.panelTotal.Controls.Add(Me.dgvInput)
        Me.panelTotal.Controls.Add(Me.LabelControl24)
        Me.panelTotal.Controls.Add(Me.dtpInput)
        Me.panelTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelTotal.Location = New System.Drawing.Point(0, 0)
        Me.panelTotal.Name = "panelTotal"
        Me.panelTotal.Size = New System.Drawing.Size(718, 401)
        Me.panelTotal.TabIndex = 4
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.btnAddObjectInput)
        Me.PanelControl6.Controls.Add(Me.cbbInputStatus)
        Me.PanelControl6.Controls.Add(Me.cbbInputObject)
        Me.PanelControl6.Controls.Add(Me.LabelControl28)
        Me.PanelControl6.Controls.Add(Me.LabelControl27)
        Me.PanelControl6.Controls.Add(Me.nmInputPrice)
        Me.PanelControl6.Controls.Add(Me.LabelControl26)
        Me.PanelControl6.Controls.Add(Me.nmInputCount)
        Me.PanelControl6.Controls.Add(Me.LabelControl25)
        Me.PanelControl6.Location = New System.Drawing.Point(5, 41)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(451, 88)
        Me.PanelControl6.TabIndex = 32
        '
        'btnAddObjectInput
        '
        Me.btnAddObjectInput.Location = New System.Drawing.Point(208, 18)
        Me.btnAddObjectInput.Name = "btnAddObjectInput"
        Me.btnAddObjectInput.Size = New System.Drawing.Size(26, 21)
        Me.btnAddObjectInput.TabIndex = 30
        Me.btnAddObjectInput.Text = "+"
        '
        'cbbInputStatus
        '
        Me.cbbInputStatus.FormattingEnabled = True
        Me.cbbInputStatus.Location = New System.Drawing.Point(319, 49)
        Me.cbbInputStatus.Name = "cbbInputStatus"
        Me.cbbInputStatus.Size = New System.Drawing.Size(121, 21)
        Me.cbbInputStatus.TabIndex = 29
        '
        'cbbInputObject
        '
        Me.cbbInputObject.FormattingEnabled = True
        Me.cbbInputObject.Location = New System.Drawing.Point(81, 18)
        Me.cbbInputObject.Name = "cbbInputObject"
        Me.cbbInputObject.Size = New System.Drawing.Size(121, 21)
        Me.cbbInputObject.TabIndex = 28
        '
        'LabelControl28
        '
        Me.LabelControl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl28.Location = New System.Drawing.Point(248, 52)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl28.TabIndex = 27
        Me.LabelControl28.Text = "Trạng thái:"
        '
        'LabelControl27
        '
        Me.LabelControl27.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl27.Location = New System.Drawing.Point(248, 20)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(44, 14)
        Me.LabelControl27.TabIndex = 26
        Me.LabelControl27.Text = "Giá bán:"
        '
        'nmInputPrice
        '
        Me.nmInputPrice.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nmInputPrice.Location = New System.Drawing.Point(319, 18)
        Me.nmInputPrice.Name = "nmInputPrice"
        Me.nmInputPrice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.nmInputPrice.Properties.IsFloatValue = False
        Me.nmInputPrice.Properties.Mask.EditMask = "N00"
        Me.nmInputPrice.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nmInputPrice.Size = New System.Drawing.Size(121, 20)
        Me.nmInputPrice.TabIndex = 23
        '
        'LabelControl26
        '
        Me.LabelControl26.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl26.Location = New System.Drawing.Point(10, 49)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(53, 14)
        Me.LabelControl26.TabIndex = 25
        Me.LabelControl26.Text = "Số lượng:"
        '
        'nmInputCount
        '
        Me.nmInputCount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nmInputCount.Location = New System.Drawing.Point(81, 49)
        Me.nmInputCount.Name = "nmInputCount"
        Me.nmInputCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.nmInputCount.Properties.IsFloatValue = False
        Me.nmInputCount.Properties.Mask.EditMask = "N00"
        Me.nmInputCount.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nmInputCount.Size = New System.Drawing.Size(121, 20)
        Me.nmInputCount.TabIndex = 22
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl25.Location = New System.Drawing.Point(10, 20)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(58, 14)
        Me.LabelControl25.TabIndex = 24
        Me.LabelControl25.Text = "Sản phẩm:"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.btnShowDetailBillInput)
        Me.PanelControl4.Controls.Add(Me.btnDeleteInput)
        Me.PanelControl4.Controls.Add(Me.btEditInput)
        Me.PanelControl4.Controls.Add(Me.btnAddInput)
        Me.PanelControl4.Controls.Add(Me.btnSaveInput)
        Me.PanelControl4.Controls.Add(Me.btnCancelInput)
        Me.PanelControl4.Location = New System.Drawing.Point(462, 41)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(245, 88)
        Me.PanelControl4.TabIndex = 22
        '
        'btnShowDetailBillInput
        '
        Me.btnShowDetailBillInput.Location = New System.Drawing.Point(15, 49)
        Me.btnShowDetailBillInput.Name = "btnShowDetailBillInput"
        Me.btnShowDetailBillInput.Size = New System.Drawing.Size(61, 28)
        Me.btnShowDetailBillInput.TabIndex = 32
        Me.btnShowDetailBillInput.Text = "Xem"
        '
        'btnDeleteInput
        '
        Me.btnDeleteInput.Location = New System.Drawing.Point(164, 15)
        Me.btnDeleteInput.Name = "btnDeleteInput"
        Me.btnDeleteInput.Size = New System.Drawing.Size(71, 28)
        Me.btnDeleteInput.TabIndex = 29
        Me.btnDeleteInput.Text = "Xoá"
        '
        'btEditInput
        '
        Me.btEditInput.Location = New System.Drawing.Point(86, 15)
        Me.btEditInput.Name = "btEditInput"
        Me.btEditInput.Size = New System.Drawing.Size(71, 28)
        Me.btEditInput.TabIndex = 28
        Me.btEditInput.Text = "Sửa"
        '
        'btnAddInput
        '
        Me.btnAddInput.Location = New System.Drawing.Point(15, 15)
        Me.btnAddInput.Name = "btnAddInput"
        Me.btnAddInput.Size = New System.Drawing.Size(61, 28)
        Me.btnAddInput.TabIndex = 27
        Me.btnAddInput.Text = "Thêm"
        '
        'btnSaveInput
        '
        Me.btnSaveInput.Enabled = False
        Me.btnSaveInput.Location = New System.Drawing.Point(86, 48)
        Me.btnSaveInput.Name = "btnSaveInput"
        Me.btnSaveInput.Size = New System.Drawing.Size(71, 29)
        Me.btnSaveInput.TabIndex = 30
        Me.btnSaveInput.Text = "Lưu"
        '
        'btnCancelInput
        '
        Me.btnCancelInput.Enabled = False
        Me.btnCancelInput.Location = New System.Drawing.Point(164, 48)
        Me.btnCancelInput.Name = "btnCancelInput"
        Me.btnCancelInput.Size = New System.Drawing.Size(71, 28)
        Me.btnCancelInput.TabIndex = 31
        Me.btnCancelInput.Text = "Huỷ"
        '
        'LabelControl29
        '
        Me.LabelControl29.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl29.Location = New System.Drawing.Point(16, 15)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(133, 14)
        Me.LabelControl29.TabIndex = 17
        Me.LabelControl29.Text = "THÔNG TIN NHẬP KHO"
        '
        'dgvInput
        '
        Me.dgvInput.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvInput.Location = New System.Drawing.Point(5, 135)
        Me.dgvInput.MainView = Me.GridView7
        Me.dgvInput.Name = "dgvInput"
        Me.dgvInput.Size = New System.Drawing.Size(702, 261)
        Me.dgvInput.TabIndex = 8
        Me.dgvInput.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView7})
        '
        'GridView7
        '
        Me.GridView7.GridControl = Me.dgvInput
        Me.GridView7.Name = "GridView7"
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl24.Location = New System.Drawing.Point(445, 16)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(62, 14)
        Me.LabelControl24.TabIndex = 7
        Me.LabelControl24.Text = "Ngày nhập:"
        '
        'dtpInput
        '
        Me.dtpInput.Enabled = False
        Me.dtpInput.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInput.Location = New System.Drawing.Point(518, 15)
        Me.dtpInput.Name = "dtpInput"
        Me.dtpInput.Size = New System.Drawing.Size(189, 20)
        Me.dtpInput.TabIndex = 3
        '
        'tcInventory
        '
        Me.tcInventory.Controls.Add(Me.Label4)
        Me.tcInventory.Controls.Add(Me.txtgiatritrungbinh)
        Me.tcInventory.Controls.Add(Me.Label3)
        Me.tcInventory.Controls.Add(Me.dtp)
        Me.tcInventory.Controls.Add(Me.txtDoanhThu)
        Me.tcInventory.Controls.Add(Me.btnView)
        Me.tcInventory.Name = "tcInventory"
        Me.tcInventory.Size = New System.Drawing.Size(718, 401)
        Me.tcInventory.Text = "Tồn kho"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(240, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Gia tri trung binh"
        '
        'txtgiatritrungbinh
        '
        Me.txtgiatritrungbinh.Location = New System.Drawing.Point(57, 77)
        Me.txtgiatritrungbinh.Name = "txtgiatritrungbinh"
        Me.txtgiatritrungbinh.Size = New System.Drawing.Size(146, 20)
        Me.txtgiatritrungbinh.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(240, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "doanh thu"
        '
        'dtp
        '
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp.Location = New System.Drawing.Point(57, 24)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(121, 20)
        Me.dtp.TabIndex = 38
        '
        'txtDoanhThu
        '
        Me.txtDoanhThu.Location = New System.Drawing.Point(57, 134)
        Me.txtDoanhThu.Name = "txtDoanhThu"
        Me.txtDoanhThu.Size = New System.Drawing.Size(146, 20)
        Me.txtDoanhThu.TabIndex = 37
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(279, 24)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(61, 21)
        Me.btnView.TabIndex = 34
        Me.btnView.Text = "Xem"
        '
        'tpOutput
        '
        Me.tpOutput.Controls.Add(Me.PanelControl21)
        Me.tpOutput.Name = "tpOutput"
        Me.tpOutput.Size = New System.Drawing.Size(718, 401)
        Me.tpOutput.Text = "Xuất kho"
        '
        'PanelControl21
        '
        Me.PanelControl21.Controls.Add(Me.PanelControl12)
        Me.PanelControl21.Controls.Add(Me.PanelControl9)
        Me.PanelControl21.Controls.Add(Me.LabelControl31)
        Me.PanelControl21.Controls.Add(Me.dgvOutput)
        Me.PanelControl21.Controls.Add(Me.LabelControl36)
        Me.PanelControl21.Controls.Add(Me.dtpOutput)
        Me.PanelControl21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl21.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl21.Name = "PanelControl21"
        Me.PanelControl21.Size = New System.Drawing.Size(718, 401)
        Me.PanelControl21.TabIndex = 5
        '
        'PanelControl12
        '
        Me.PanelControl12.Controls.Add(Me.cbOutputStatus)
        Me.PanelControl12.Controls.Add(Me.cbbOutputObject)
        Me.PanelControl12.Controls.Add(Me.LabelControl32)
        Me.PanelControl12.Controls.Add(Me.LabelControl34)
        Me.PanelControl12.Controls.Add(Me.nmOutputCount)
        Me.PanelControl12.Controls.Add(Me.LabelControl35)
        Me.PanelControl12.Location = New System.Drawing.Point(5, 43)
        Me.PanelControl12.Name = "PanelControl12"
        Me.PanelControl12.Size = New System.Drawing.Size(451, 88)
        Me.PanelControl12.TabIndex = 32
        '
        'cbOutputStatus
        '
        Me.cbOutputStatus.FormattingEnabled = True
        Me.cbOutputStatus.Location = New System.Drawing.Point(85, 50)
        Me.cbOutputStatus.Name = "cbOutputStatus"
        Me.cbOutputStatus.Size = New System.Drawing.Size(120, 21)
        Me.cbOutputStatus.TabIndex = 26
        '
        'cbbOutputObject
        '
        Me.cbbOutputObject.FormattingEnabled = True
        Me.cbbOutputObject.Location = New System.Drawing.Point(85, 17)
        Me.cbbOutputObject.Name = "cbbOutputObject"
        Me.cbbOutputObject.Size = New System.Drawing.Size(120, 21)
        Me.cbbOutputObject.TabIndex = 25
        '
        'LabelControl32
        '
        Me.LabelControl32.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl32.Location = New System.Drawing.Point(9, 52)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl32.TabIndex = 24
        Me.LabelControl32.Text = "Trạng thái:"
        '
        'LabelControl34
        '
        Me.LabelControl34.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl34.Location = New System.Drawing.Point(245, 20)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(53, 14)
        Me.LabelControl34.TabIndex = 23
        Me.LabelControl34.Text = "Số lượng:"
        '
        'nmOutputCount
        '
        Me.nmOutputCount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nmOutputCount.Location = New System.Drawing.Point(316, 18)
        Me.nmOutputCount.Name = "nmOutputCount"
        Me.nmOutputCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.nmOutputCount.Properties.IsFloatValue = False
        Me.nmOutputCount.Properties.Mask.EditMask = "N00"
        Me.nmOutputCount.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nmOutputCount.Size = New System.Drawing.Size(110, 20)
        Me.nmOutputCount.TabIndex = 20
        '
        'LabelControl35
        '
        Me.LabelControl35.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl35.Location = New System.Drawing.Point(11, 19)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(58, 14)
        Me.LabelControl35.TabIndex = 22
        Me.LabelControl35.Text = "Sản phẩm:"
        '
        'PanelControl9
        '
        Me.PanelControl9.Controls.Add(Me.SimpleButton16)
        Me.PanelControl9.Controls.Add(Me.SimpleButton9)
        Me.PanelControl9.Controls.Add(Me.SimpleButton10)
        Me.PanelControl9.Controls.Add(Me.SimpleButton11)
        Me.PanelControl9.Controls.Add(Me.SimpleButton12)
        Me.PanelControl9.Controls.Add(Me.SimpleButton13)
        Me.PanelControl9.Location = New System.Drawing.Point(462, 43)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(245, 88)
        Me.PanelControl9.TabIndex = 23
        '
        'SimpleButton16
        '
        Me.SimpleButton16.Location = New System.Drawing.Point(15, 48)
        Me.SimpleButton16.Name = "SimpleButton16"
        Me.SimpleButton16.Size = New System.Drawing.Size(65, 28)
        Me.SimpleButton16.TabIndex = 32
        Me.SimpleButton16.Text = "Xem"
        '
        'SimpleButton9
        '
        Me.SimpleButton9.Location = New System.Drawing.Point(164, 15)
        Me.SimpleButton9.Name = "SimpleButton9"
        Me.SimpleButton9.Size = New System.Drawing.Size(71, 28)
        Me.SimpleButton9.TabIndex = 29
        Me.SimpleButton9.Text = "Xoá"
        '
        'SimpleButton10
        '
        Me.SimpleButton10.Location = New System.Drawing.Point(86, 15)
        Me.SimpleButton10.Name = "SimpleButton10"
        Me.SimpleButton10.Size = New System.Drawing.Size(71, 28)
        Me.SimpleButton10.TabIndex = 28
        Me.SimpleButton10.Text = "Sửa"
        '
        'SimpleButton11
        '
        Me.SimpleButton11.Location = New System.Drawing.Point(15, 15)
        Me.SimpleButton11.Name = "SimpleButton11"
        Me.SimpleButton11.Size = New System.Drawing.Size(65, 28)
        Me.SimpleButton11.TabIndex = 27
        Me.SimpleButton11.Text = "Thêm"
        '
        'SimpleButton12
        '
        Me.SimpleButton12.Enabled = False
        Me.SimpleButton12.Location = New System.Drawing.Point(86, 48)
        Me.SimpleButton12.Name = "SimpleButton12"
        Me.SimpleButton12.Size = New System.Drawing.Size(71, 29)
        Me.SimpleButton12.TabIndex = 30
        Me.SimpleButton12.Text = "Lưu"
        '
        'SimpleButton13
        '
        Me.SimpleButton13.Enabled = False
        Me.SimpleButton13.Location = New System.Drawing.Point(163, 49)
        Me.SimpleButton13.Name = "SimpleButton13"
        Me.SimpleButton13.Size = New System.Drawing.Size(71, 28)
        Me.SimpleButton13.TabIndex = 31
        Me.SimpleButton13.Text = "Huỷ"
        '
        'LabelControl31
        '
        Me.LabelControl31.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl31.Location = New System.Drawing.Point(16, 16)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(131, 14)
        Me.LabelControl31.TabIndex = 17
        Me.LabelControl31.Text = "THÔNG TIN XUẤT KHO"
        '
        'dgvOutput
        '
        Me.dgvOutput.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvOutput.Location = New System.Drawing.Point(5, 137)
        Me.dgvOutput.MainView = Me.GridView8
        Me.dgvOutput.Name = "dgvOutput"
        Me.dgvOutput.Size = New System.Drawing.Size(702, 259)
        Me.dgvOutput.TabIndex = 8
        Me.dgvOutput.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView8})
        '
        'GridView8
        '
        Me.GridView8.GridControl = Me.dgvOutput
        Me.GridView8.Name = "GridView8"
        '
        'LabelControl36
        '
        Me.LabelControl36.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl36.Location = New System.Drawing.Point(451, 15)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(59, 14)
        Me.LabelControl36.TabIndex = 7
        Me.LabelControl36.Text = "Ngày xuất:"
        '
        'dtpOutput
        '
        Me.dtpOutput.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOutput.Location = New System.Drawing.Point(524, 14)
        Me.dtpOutput.Name = "dtpOutput"
        Me.dtpOutput.Size = New System.Drawing.Size(189, 20)
        Me.dtpOutput.TabIndex = 3
        '
        'tpObject
        '
        Me.tpObject.Controls.Add(Me.PanelControl29)
        Me.tpObject.Controls.Add(Me.PanelControl30)
        Me.tpObject.Controls.Add(Me.PanelControl31)
        Me.tpObject.Name = "tpObject"
        Me.tpObject.Size = New System.Drawing.Size(718, 401)
        Me.tpObject.Text = "Sản phẩm"
        '
        'PanelControl29
        '
        Me.PanelControl29.Controls.Add(Me.cbbUnitObject)
        Me.PanelControl29.Controls.Add(Me.btnAddUnitObject)
        Me.PanelControl29.Controls.Add(Me.btnAddSupplierObject)
        Me.PanelControl29.Controls.Add(Me.btnDeleteObject)
        Me.PanelControl29.Controls.Add(Me.LabelControl16)
        Me.PanelControl29.Controls.Add(Me.btnEditObject)
        Me.PanelControl29.Controls.Add(Me.txtIDObject)
        Me.PanelControl29.Controls.Add(Me.btnAddObject)
        Me.PanelControl29.Controls.Add(Me.cbbSuplierObject)
        Me.PanelControl29.Controls.Add(Me.LabelControl42)
        Me.PanelControl29.Controls.Add(Me.LabelControl41)
        Me.PanelControl29.Controls.Add(Me.btnSaveObject)
        Me.PanelControl29.Controls.Add(Me.btnCancelObject)
        Me.PanelControl29.Controls.Add(Me.LabelControl37)
        Me.PanelControl29.Controls.Add(Me.LabelControl38)
        Me.PanelControl29.Controls.Add(Me.txtNameObject)
        Me.PanelControl29.Location = New System.Drawing.Point(402, 66)
        Me.PanelControl29.Name = "PanelControl29"
        Me.PanelControl29.Size = New System.Drawing.Size(313, 330)
        Me.PanelControl29.TabIndex = 19
        '
        'cbbUnitObject
        '
        Me.cbbUnitObject.Enabled = False
        Me.cbbUnitObject.FormattingEnabled = True
        Me.cbbUnitObject.Location = New System.Drawing.Point(117, 165)
        Me.cbbUnitObject.Name = "cbbUnitObject"
        Me.cbbUnitObject.Size = New System.Drawing.Size(144, 21)
        Me.cbbUnitObject.TabIndex = 33
        '
        'btnAddUnitObject
        '
        Me.btnAddUnitObject.Location = New System.Drawing.Point(267, 167)
        Me.btnAddUnitObject.Name = "btnAddUnitObject"
        Me.btnAddUnitObject.Size = New System.Drawing.Size(26, 21)
        Me.btnAddUnitObject.TabIndex = 32
        Me.btnAddUnitObject.Text = "+"
        '
        'btnAddSupplierObject
        '
        Me.btnAddSupplierObject.Location = New System.Drawing.Point(267, 131)
        Me.btnAddSupplierObject.Name = "btnAddSupplierObject"
        Me.btnAddSupplierObject.Size = New System.Drawing.Size(26, 21)
        Me.btnAddSupplierObject.TabIndex = 31
        Me.btnAddSupplierObject.Text = "+"
        '
        'btnDeleteObject
        '
        Me.btnDeleteObject.Location = New System.Drawing.Point(208, 222)
        Me.btnDeleteObject.Name = "btnDeleteObject"
        Me.btnDeleteObject.Size = New System.Drawing.Size(85, 94)
        Me.btnDeleteObject.TabIndex = 2
        Me.btnDeleteObject.Text = "Xoá"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl16.Location = New System.Drawing.Point(11, 65)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(18, 14)
        Me.LabelControl16.TabIndex = 23
        Me.LabelControl16.Text = "ID:"
        '
        'btnEditObject
        '
        Me.btnEditObject.Location = New System.Drawing.Point(114, 222)
        Me.btnEditObject.Name = "btnEditObject"
        Me.btnEditObject.Size = New System.Drawing.Size(85, 45)
        Me.btnEditObject.TabIndex = 1
        Me.btnEditObject.Text = "Sửa"
        '
        'txtIDObject
        '
        Me.txtIDObject.Enabled = False
        Me.txtIDObject.Location = New System.Drawing.Point(117, 64)
        Me.txtIDObject.Name = "txtIDObject"
        Me.txtIDObject.Size = New System.Drawing.Size(176, 20)
        Me.txtIDObject.TabIndex = 22
        '
        'btnAddObject
        '
        Me.btnAddObject.Location = New System.Drawing.Point(18, 222)
        Me.btnAddObject.Name = "btnAddObject"
        Me.btnAddObject.Size = New System.Drawing.Size(85, 45)
        Me.btnAddObject.TabIndex = 0
        Me.btnAddObject.Text = "Thêm"
        '
        'cbbSuplierObject
        '
        Me.cbbSuplierObject.Enabled = False
        Me.cbbSuplierObject.FormattingEnabled = True
        Me.cbbSuplierObject.Location = New System.Drawing.Point(117, 132)
        Me.cbbSuplierObject.Name = "cbbSuplierObject"
        Me.cbbSuplierObject.Size = New System.Drawing.Size(144, 21)
        Me.cbbSuplierObject.TabIndex = 20
        '
        'LabelControl42
        '
        Me.LabelControl42.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl42.Location = New System.Drawing.Point(13, 167)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(72, 14)
        Me.LabelControl42.TabIndex = 13
        Me.LabelControl42.Text = "Đơn vị tính:"
        '
        'LabelControl41
        '
        Me.LabelControl41.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl41.Location = New System.Drawing.Point(11, 133)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(86, 14)
        Me.LabelControl41.TabIndex = 11
        Me.LabelControl41.Text = "Nhà cung cấp:"
        '
        'btnSaveObject
        '
        Me.btnSaveObject.Enabled = False
        Me.btnSaveObject.Location = New System.Drawing.Point(18, 273)
        Me.btnSaveObject.Name = "btnSaveObject"
        Me.btnSaveObject.Size = New System.Drawing.Size(85, 44)
        Me.btnSaveObject.TabIndex = 8
        Me.btnSaveObject.Text = "Lưu"
        '
        'btnCancelObject
        '
        Me.btnCancelObject.Enabled = False
        Me.btnCancelObject.Location = New System.Drawing.Point(114, 273)
        Me.btnCancelObject.Name = "btnCancelObject"
        Me.btnCancelObject.Size = New System.Drawing.Size(85, 43)
        Me.btnCancelObject.TabIndex = 9
        Me.btnCancelObject.Text = "Huỷ"
        '
        'LabelControl37
        '
        Me.LabelControl37.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl37.Location = New System.Drawing.Point(84, 24)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(171, 18)
        Me.LabelControl37.TabIndex = 8
        Me.LabelControl37.Text = "THÔNG TIN SẢN PHẨM"
        '
        'LabelControl38
        '
        Me.LabelControl38.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl38.Location = New System.Drawing.Point(11, 100)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(89, 14)
        Me.LabelControl38.TabIndex = 6
        Me.LabelControl38.Text = "Tên sản phẩm:"
        '
        'txtNameObject
        '
        Me.txtNameObject.Enabled = False
        Me.txtNameObject.Location = New System.Drawing.Point(117, 99)
        Me.txtNameObject.Name = "txtNameObject"
        Me.txtNameObject.Size = New System.Drawing.Size(176, 20)
        Me.txtNameObject.TabIndex = 5
        '
        'PanelControl30
        '
        Me.PanelControl30.Controls.Add(Me.dgvObject)
        Me.PanelControl30.Location = New System.Drawing.Point(3, 5)
        Me.PanelControl30.Name = "PanelControl30"
        Me.PanelControl30.Size = New System.Drawing.Size(393, 393)
        Me.PanelControl30.TabIndex = 18
        '
        'dgvObject
        '
        Me.dgvObject.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvObject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvObject.Location = New System.Drawing.Point(2, 2)
        Me.dgvObject.MainView = Me.gridObject
        Me.dgvObject.Name = "dgvObject"
        Me.dgvObject.Size = New System.Drawing.Size(389, 389)
        Me.dgvObject.TabIndex = 2
        Me.dgvObject.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridObject})
        '
        'gridObject
        '
        Me.gridObject.GridControl = Me.dgvObject
        Me.gridObject.Name = "gridObject"
        '
        'PanelControl31
        '
        Me.PanelControl31.Controls.Add(Me.txtSearchObject)
        Me.PanelControl31.Controls.Add(Me.btnSearchObject)
        Me.PanelControl31.Location = New System.Drawing.Point(402, 5)
        Me.PanelControl31.Name = "PanelControl31"
        Me.PanelControl31.Size = New System.Drawing.Size(313, 55)
        Me.PanelControl31.TabIndex = 17
        '
        'txtSearchObject
        '
        Me.txtSearchObject.Location = New System.Drawing.Point(13, 18)
        Me.txtSearchObject.Name = "txtSearchObject"
        Me.txtSearchObject.Size = New System.Drawing.Size(190, 20)
        Me.txtSearchObject.TabIndex = 3
        '
        'btnSearchObject
        '
        Me.btnSearchObject.Location = New System.Drawing.Point(223, 5)
        Me.btnSearchObject.Name = "btnSearchObject"
        Me.btnSearchObject.Size = New System.Drawing.Size(85, 45)
        Me.btnSearchObject.TabIndex = 4
        Me.btnSearchObject.Text = "Tìm"
        '
        'tpUnit
        '
        Me.tpUnit.Controls.Add(Me.PanelControl27)
        Me.tpUnit.Controls.Add(Me.PanelControl28)
        Me.tpUnit.Controls.Add(Me.PanelControl25)
        Me.tpUnit.Name = "tpUnit"
        Me.tpUnit.Size = New System.Drawing.Size(718, 401)
        Me.tpUnit.Text = "Đơn vị"
        '
        'PanelControl27
        '
        Me.PanelControl27.Controls.Add(Me.LabelControl11)
        Me.PanelControl27.Controls.Add(Me.txtIDUnit)
        Me.PanelControl27.Controls.Add(Me.btnAddUnit)
        Me.PanelControl27.Controls.Add(Me.btnEditUnit)
        Me.PanelControl27.Controls.Add(Me.btnDeleteUnit)
        Me.PanelControl27.Controls.Add(Me.btnSaveUnit)
        Me.PanelControl27.Controls.Add(Me.btnCancelUnit)
        Me.PanelControl27.Controls.Add(Me.LabelControl39)
        Me.PanelControl27.Controls.Add(Me.LabelControl40)
        Me.PanelControl27.Controls.Add(Me.txtNameUnit)
        Me.PanelControl27.Location = New System.Drawing.Point(402, 66)
        Me.PanelControl27.Name = "PanelControl27"
        Me.PanelControl27.Size = New System.Drawing.Size(313, 330)
        Me.PanelControl27.TabIndex = 15
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl11.Location = New System.Drawing.Point(17, 90)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(18, 14)
        Me.LabelControl11.TabIndex = 10
        Me.LabelControl11.Text = "ID:"
        '
        'txtIDUnit
        '
        Me.txtIDUnit.Enabled = False
        Me.txtIDUnit.Location = New System.Drawing.Point(118, 88)
        Me.txtIDUnit.Name = "txtIDUnit"
        Me.txtIDUnit.Size = New System.Drawing.Size(176, 20)
        Me.txtIDUnit.TabIndex = 9
        '
        'btnAddUnit
        '
        Me.btnAddUnit.Location = New System.Drawing.Point(17, 194)
        Me.btnAddUnit.Name = "btnAddUnit"
        Me.btnAddUnit.Size = New System.Drawing.Size(85, 45)
        Me.btnAddUnit.TabIndex = 0
        Me.btnAddUnit.Text = "Thêm"
        '
        'btnEditUnit
        '
        Me.btnEditUnit.Location = New System.Drawing.Point(114, 194)
        Me.btnEditUnit.Name = "btnEditUnit"
        Me.btnEditUnit.Size = New System.Drawing.Size(85, 45)
        Me.btnEditUnit.TabIndex = 1
        Me.btnEditUnit.Text = "Sửa"
        '
        'btnDeleteUnit
        '
        Me.btnDeleteUnit.Location = New System.Drawing.Point(208, 194)
        Me.btnDeleteUnit.Name = "btnDeleteUnit"
        Me.btnDeleteUnit.Size = New System.Drawing.Size(87, 103)
        Me.btnDeleteUnit.TabIndex = 2
        Me.btnDeleteUnit.Text = "Xoá"
        '
        'btnSaveUnit
        '
        Me.btnSaveUnit.Enabled = False
        Me.btnSaveUnit.Location = New System.Drawing.Point(17, 245)
        Me.btnSaveUnit.Name = "btnSaveUnit"
        Me.btnSaveUnit.Size = New System.Drawing.Size(85, 52)
        Me.btnSaveUnit.TabIndex = 6
        Me.btnSaveUnit.Text = "Lưu"
        '
        'btnCancelUnit
        '
        Me.btnCancelUnit.Enabled = False
        Me.btnCancelUnit.Location = New System.Drawing.Point(114, 245)
        Me.btnCancelUnit.Name = "btnCancelUnit"
        Me.btnCancelUnit.Size = New System.Drawing.Size(85, 52)
        Me.btnCancelUnit.TabIndex = 7
        Me.btnCancelUnit.Text = "Huỷ"
        '
        'LabelControl39
        '
        Me.LabelControl39.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl39.Location = New System.Drawing.Point(67, 18)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(192, 18)
        Me.LabelControl39.TabIndex = 8
        Me.LabelControl39.Text = "THÔNG TIN ĐƠN VỊ TÍNH"
        '
        'LabelControl40
        '
        Me.LabelControl40.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl40.Location = New System.Drawing.Point(17, 126)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(68, 14)
        Me.LabelControl40.TabIndex = 6
        Me.LabelControl40.Text = "Tên đơn vị:"
        '
        'txtNameUnit
        '
        Me.txtNameUnit.Enabled = False
        Me.txtNameUnit.Location = New System.Drawing.Point(119, 124)
        Me.txtNameUnit.Name = "txtNameUnit"
        Me.txtNameUnit.Size = New System.Drawing.Size(176, 20)
        Me.txtNameUnit.TabIndex = 5
        '
        'PanelControl28
        '
        Me.PanelControl28.Controls.Add(Me.dgvUnit)
        Me.PanelControl28.Location = New System.Drawing.Point(3, 5)
        Me.PanelControl28.Name = "PanelControl28"
        Me.PanelControl28.Size = New System.Drawing.Size(393, 393)
        Me.PanelControl28.TabIndex = 14
        '
        'dgvUnit
        '
        Me.dgvUnit.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUnit.Location = New System.Drawing.Point(2, 2)
        Me.dgvUnit.MainView = Me.gridUnit
        Me.dgvUnit.Name = "dgvUnit"
        Me.dgvUnit.Size = New System.Drawing.Size(389, 389)
        Me.dgvUnit.TabIndex = 2
        Me.dgvUnit.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridUnit})
        '
        'gridUnit
        '
        Me.gridUnit.GridControl = Me.dgvUnit
        Me.gridUnit.Name = "gridUnit"
        '
        'PanelControl25
        '
        Me.PanelControl25.Controls.Add(Me.txtSearchUnit)
        Me.PanelControl25.Controls.Add(Me.btnSearchUnit)
        Me.PanelControl25.Location = New System.Drawing.Point(402, 5)
        Me.PanelControl25.Name = "PanelControl25"
        Me.PanelControl25.Size = New System.Drawing.Size(313, 55)
        Me.PanelControl25.TabIndex = 13
        '
        'txtSearchUnit
        '
        Me.txtSearchUnit.Location = New System.Drawing.Point(13, 18)
        Me.txtSearchUnit.Name = "txtSearchUnit"
        Me.txtSearchUnit.Size = New System.Drawing.Size(190, 20)
        Me.txtSearchUnit.TabIndex = 4
        '
        'btnSearchUnit
        '
        Me.btnSearchUnit.Location = New System.Drawing.Point(223, 5)
        Me.btnSearchUnit.Name = "btnSearchUnit"
        Me.btnSearchUnit.Size = New System.Drawing.Size(85, 45)
        Me.btnSearchUnit.TabIndex = 5
        Me.btnSearchUnit.Text = "Tìm"
        '
        'tpSupplier
        '
        Me.tpSupplier.Controls.Add(Me.PanelControl33)
        Me.tpSupplier.Controls.Add(Me.PanelControl34)
        Me.tpSupplier.Controls.Add(Me.PanelControl35)
        Me.tpSupplier.Name = "tpSupplier"
        Me.tpSupplier.Size = New System.Drawing.Size(718, 401)
        Me.tpSupplier.Text = "Nhà cung cấp"
        '
        'PanelControl33
        '
        Me.PanelControl33.Controls.Add(Me.txtSearchSuplier)
        Me.PanelControl33.Controls.Add(Me.btnSearchSuplier)
        Me.PanelControl33.Location = New System.Drawing.Point(402, 5)
        Me.PanelControl33.Name = "PanelControl33"
        Me.PanelControl33.Size = New System.Drawing.Size(313, 55)
        Me.PanelControl33.TabIndex = 14
        '
        'txtSearchSuplier
        '
        Me.txtSearchSuplier.Location = New System.Drawing.Point(13, 18)
        Me.txtSearchSuplier.Name = "txtSearchSuplier"
        Me.txtSearchSuplier.Size = New System.Drawing.Size(190, 20)
        Me.txtSearchSuplier.TabIndex = 3
        '
        'btnSearchSuplier
        '
        Me.btnSearchSuplier.Location = New System.Drawing.Point(223, 5)
        Me.btnSearchSuplier.Name = "btnSearchSuplier"
        Me.btnSearchSuplier.Size = New System.Drawing.Size(85, 45)
        Me.btnSearchSuplier.TabIndex = 4
        Me.btnSearchSuplier.Text = "Tìm"
        '
        'PanelControl34
        '
        Me.PanelControl34.Controls.Add(Me.LabelControl17)
        Me.PanelControl34.Controls.Add(Me.txtIDSupplier)
        Me.PanelControl34.Controls.Add(Me.btnAddSupplier)
        Me.PanelControl34.Controls.Add(Me.btnEditSupplier)
        Me.PanelControl34.Controls.Add(Me.btnDeleteSupplier)
        Me.PanelControl34.Controls.Add(Me.LabelControl44)
        Me.PanelControl34.Controls.Add(Me.txtEmailSupplier)
        Me.PanelControl34.Controls.Add(Me.LabelControl43)
        Me.PanelControl34.Controls.Add(Me.txtPhoneSupplier)
        Me.PanelControl34.Controls.Add(Me.txtAddressSupplier)
        Me.PanelControl34.Controls.Add(Me.LabelControl46)
        Me.PanelControl34.Controls.Add(Me.btnSaveSupplier)
        Me.PanelControl34.Controls.Add(Me.btnCancelSupplier)
        Me.PanelControl34.Controls.Add(Me.LabelControl48)
        Me.PanelControl34.Controls.Add(Me.LabelControl49)
        Me.PanelControl34.Controls.Add(Me.txtNameSupplier)
        Me.PanelControl34.Location = New System.Drawing.Point(402, 66)
        Me.PanelControl34.Name = "PanelControl34"
        Me.PanelControl34.Size = New System.Drawing.Size(313, 330)
        Me.PanelControl34.TabIndex = 13
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl17.Location = New System.Drawing.Point(18, 52)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(18, 14)
        Me.LabelControl17.TabIndex = 27
        Me.LabelControl17.Text = "ID:"
        '
        'txtIDSupplier
        '
        Me.txtIDSupplier.Enabled = False
        Me.txtIDSupplier.Location = New System.Drawing.Point(130, 50)
        Me.txtIDSupplier.Name = "txtIDSupplier"
        Me.txtIDSupplier.Size = New System.Drawing.Size(164, 20)
        Me.txtIDSupplier.TabIndex = 26
        '
        'btnAddSupplier
        '
        Me.btnAddSupplier.Location = New System.Drawing.Point(18, 230)
        Me.btnAddSupplier.Name = "btnAddSupplier"
        Me.btnAddSupplier.Size = New System.Drawing.Size(85, 45)
        Me.btnAddSupplier.TabIndex = 0
        Me.btnAddSupplier.Text = "Thêm"
        '
        'btnEditSupplier
        '
        Me.btnEditSupplier.Location = New System.Drawing.Point(116, 230)
        Me.btnEditSupplier.Name = "btnEditSupplier"
        Me.btnEditSupplier.Size = New System.Drawing.Size(85, 45)
        Me.btnEditSupplier.TabIndex = 1
        Me.btnEditSupplier.Text = "Sửa"
        '
        'btnDeleteSupplier
        '
        Me.btnDeleteSupplier.Location = New System.Drawing.Point(212, 230)
        Me.btnDeleteSupplier.Name = "btnDeleteSupplier"
        Me.btnDeleteSupplier.Size = New System.Drawing.Size(82, 95)
        Me.btnDeleteSupplier.TabIndex = 2
        Me.btnDeleteSupplier.Text = "Xoá"
        '
        'LabelControl44
        '
        Me.LabelControl44.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl44.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl44.Location = New System.Drawing.Point(18, 202)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(35, 14)
        Me.LabelControl44.TabIndex = 25
        Me.LabelControl44.Text = "Email:"
        '
        'txtEmailSupplier
        '
        Me.txtEmailSupplier.Enabled = False
        Me.txtEmailSupplier.Location = New System.Drawing.Point(131, 200)
        Me.txtEmailSupplier.Name = "txtEmailSupplier"
        Me.txtEmailSupplier.Size = New System.Drawing.Size(163, 20)
        Me.txtEmailSupplier.TabIndex = 7
        '
        'LabelControl43
        '
        Me.LabelControl43.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl43.Location = New System.Drawing.Point(18, 175)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(86, 14)
        Me.LabelControl43.TabIndex = 23
        Me.LabelControl43.Text = "Số điện thoại:"
        '
        'txtPhoneSupplier
        '
        Me.txtPhoneSupplier.Enabled = False
        Me.txtPhoneSupplier.Location = New System.Drawing.Point(131, 173)
        Me.txtPhoneSupplier.Name = "txtPhoneSupplier"
        Me.txtPhoneSupplier.Size = New System.Drawing.Size(163, 20)
        Me.txtPhoneSupplier.TabIndex = 6
        '
        'txtAddressSupplier
        '
        Me.txtAddressSupplier.Enabled = False
        Me.txtAddressSupplier.Location = New System.Drawing.Point(131, 113)
        Me.txtAddressSupplier.Multiline = True
        Me.txtAddressSupplier.Name = "txtAddressSupplier"
        Me.txtAddressSupplier.Size = New System.Drawing.Size(164, 49)
        Me.txtAddressSupplier.TabIndex = 6
        '
        'LabelControl46
        '
        Me.LabelControl46.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl46.Location = New System.Drawing.Point(18, 115)
        Me.LabelControl46.Name = "LabelControl46"
        Me.LabelControl46.Size = New System.Drawing.Size(44, 14)
        Me.LabelControl46.TabIndex = 14
        Me.LabelControl46.Text = "Địa chỉ:"
        '
        'btnSaveSupplier
        '
        Me.btnSaveSupplier.Enabled = False
        Me.btnSaveSupplier.Location = New System.Drawing.Point(18, 281)
        Me.btnSaveSupplier.Name = "btnSaveSupplier"
        Me.btnSaveSupplier.Size = New System.Drawing.Size(85, 44)
        Me.btnSaveSupplier.TabIndex = 8
        Me.btnSaveSupplier.Text = "Lưu"
        '
        'btnCancelSupplier
        '
        Me.btnCancelSupplier.Enabled = False
        Me.btnCancelSupplier.Location = New System.Drawing.Point(117, 281)
        Me.btnCancelSupplier.Name = "btnCancelSupplier"
        Me.btnCancelSupplier.Size = New System.Drawing.Size(84, 44)
        Me.btnCancelSupplier.TabIndex = 9
        Me.btnCancelSupplier.Text = "Huỷ"
        '
        'LabelControl48
        '
        Me.LabelControl48.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl48.Location = New System.Drawing.Point(60, 15)
        Me.LabelControl48.Name = "LabelControl48"
        Me.LabelControl48.Size = New System.Drawing.Size(206, 18)
        Me.LabelControl48.TabIndex = 8
        Me.LabelControl48.Text = "THÔNG TIN NHÀ CUNG CẤP"
        '
        'LabelControl49
        '
        Me.LabelControl49.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl49.Location = New System.Drawing.Point(18, 83)
        Me.LabelControl49.Name = "LabelControl49"
        Me.LabelControl49.Size = New System.Drawing.Size(54, 14)
        Me.LabelControl49.TabIndex = 6
        Me.LabelControl49.Text = "Tên NCC:"
        '
        'txtNameSupplier
        '
        Me.txtNameSupplier.Enabled = False
        Me.txtNameSupplier.Location = New System.Drawing.Point(131, 81)
        Me.txtNameSupplier.Name = "txtNameSupplier"
        Me.txtNameSupplier.Size = New System.Drawing.Size(164, 20)
        Me.txtNameSupplier.TabIndex = 5
        '
        'PanelControl35
        '
        Me.PanelControl35.Controls.Add(Me.dgvSuplier)
        Me.PanelControl35.Location = New System.Drawing.Point(3, 5)
        Me.PanelControl35.Name = "PanelControl35"
        Me.PanelControl35.Size = New System.Drawing.Size(393, 393)
        Me.PanelControl35.TabIndex = 10
        '
        'dgvSuplier
        '
        Me.dgvSuplier.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvSuplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSuplier.Location = New System.Drawing.Point(2, 2)
        Me.dgvSuplier.MainView = Me.gridSupplier
        Me.dgvSuplier.Name = "dgvSuplier"
        Me.dgvSuplier.Size = New System.Drawing.Size(389, 389)
        Me.dgvSuplier.TabIndex = 2
        Me.dgvSuplier.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridSupplier})
        '
        'gridSupplier
        '
        Me.gridSupplier.GridControl = Me.dgvSuplier
        Me.gridSupplier.Name = "gridSupplier"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.XtraTabControl1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(740, 445)
        Me.XtraTabPage2.Text = "Quản lý kho"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 3)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.Size = New System.Drawing.Size(300, 300)
        Me.XtraTabControl1.TabIndex = 0
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(294, 281)
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(294, 272)
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 473)
        Me.Controls.Add(Me.tcAdmin)
        Me.MaximumSize = New System.Drawing.Size(781, 526)
        Me.Name = "FormAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAdmin"
        CType(Me.tcAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcAdmin.ResumeLayout(False)
        Me.tpTable.ResumeLayout(False)
        CType(Me.PanelControl23, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl23.ResumeLayout(False)
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.PanelControl5.PerformLayout()
        CType(Me.txtIDTable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameTable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCategory.ResumeLayout(False)
        CType(Me.PanelControl24, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl24.ResumeLayout(False)
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl8.ResumeLayout(False)
        Me.PanelControl8.PerformLayout()
        CType(Me.txtIDCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpFood.ResumeLayout(False)
        CType(Me.PanelControl15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl15.ResumeLayout(False)
        Me.PanelControl15.PerformLayout()
        CType(Me.txtIDFood.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmPriceFood.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameFood.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl16.ResumeLayout(False)
        CType(Me.dgvFood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridFood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl13.ResumeLayout(False)
        CType(Me.txtSearchFood.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCustomer.ResumeLayout(False)
        CType(Me.PanelControl17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl17.ResumeLayout(False)
        CType(Me.txtSearchCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl18, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl18.ResumeLayout(False)
        Me.PanelControl18.PerformLayout()
        CType(Me.txtIDCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhoneCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl19, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl19.ResumeLayout(False)
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpStaff.ResumeLayout(False)
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl11.ResumeLayout(False)
        Me.PanelControl11.PerformLayout()
        CType(Me.txtIDStaff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhoneStaff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIDCardStaff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameStaff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl10.ResumeLayout(False)
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpInventoryManagement.ResumeLayout(False)
        CType(Me.PanelControl22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl22.ResumeLayout(False)
        CType(Me.tcInputOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcInputOutput.ResumeLayout(False)
        Me.tpInput.ResumeLayout(False)
        CType(Me.panelTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTotal.ResumeLayout(False)
        Me.panelTotal.PerformLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        Me.PanelControl6.PerformLayout()
        CType(Me.nmInputPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmInputCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.dgvInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcInventory.ResumeLayout(False)
        Me.tcInventory.PerformLayout()
        Me.tpOutput.ResumeLayout(False)
        CType(Me.PanelControl21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl21.ResumeLayout(False)
        Me.PanelControl21.PerformLayout()
        CType(Me.PanelControl12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl12.ResumeLayout(False)
        Me.PanelControl12.PerformLayout()
        CType(Me.nmOutputCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpObject.ResumeLayout(False)
        CType(Me.PanelControl29, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl29.ResumeLayout(False)
        Me.PanelControl29.PerformLayout()
        CType(Me.txtIDObject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameObject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl30, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl30.ResumeLayout(False)
        CType(Me.dgvObject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridObject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl31, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl31.ResumeLayout(False)
        CType(Me.txtSearchObject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpUnit.ResumeLayout(False)
        CType(Me.PanelControl27, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl27.ResumeLayout(False)
        Me.PanelControl27.PerformLayout()
        CType(Me.txtIDUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl28, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl28.ResumeLayout(False)
        CType(Me.dgvUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl25, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl25.ResumeLayout(False)
        CType(Me.txtSearchUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpSupplier.ResumeLayout(False)
        CType(Me.PanelControl33, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl33.ResumeLayout(False)
        CType(Me.txtSearchSuplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl34, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl34.ResumeLayout(False)
        Me.PanelControl34.PerformLayout()
        CType(Me.txtIDSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmailSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhoneSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl35, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl35.ResumeLayout(False)
        CType(Me.dgvSuplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcAdmin As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tpTable As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpCategory As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpFood As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgvTable As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridTable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgvCategory As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridCategory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnDeleteCategory As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditCategory As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddCategory As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSaveCategory As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelCategory As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameCategory As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tpStaff As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnDeleteStaff As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditStaff As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddStaff As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl10 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgvStaff As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridStaff As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl11 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSaveStaff As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelStaff As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameStaff As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpDOBStaff As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAddressStaff As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIDCardStaff As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnResetPass As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPhoneStaff As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl15 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSaveFood As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelFood As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFood As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl16 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgvFood As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridFood As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl13 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtSearchFood As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSearchFood As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDeleteFood As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditFood As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddFood As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nmPriceFood As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpInventoryManagement As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpCustomer As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl17 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtSearchCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSearchCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl18 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPhoneCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSaveCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl19 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgvCustomer As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridCustomer As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnDeleteCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl22 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tcInputOutput As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tpInput As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents panelTotal As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dgvInput As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tpOutput As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpObject As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpUnit As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpSupplier As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl21 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dgvOutput As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpOutput As System.Windows.Forms.DateTimePicker
    Friend WithEvents PanelControl23 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl24 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl25 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtSearchUnit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSearchUnit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDeleteUnit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditUnit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddUnit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents PanelControl29 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSaveObject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelObject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameObject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl30 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgvObject As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridObject As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl31 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtSearchObject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSearchObject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDeleteObject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditObject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddObject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl27 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSaveUnit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelUnit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameUnit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl28 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgvUnit As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridUnit As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl34 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPhoneSupplier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAddressSupplier As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl46 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSaveSupplier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelSupplier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameSupplier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl35 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgvSuplier As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridSupplier As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmailSupplier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl33 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtSearchSuplier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSearchSuplier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDeleteSupplier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditSupplier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddSupplier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbCategoryFood As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIDFood As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIDCategory As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl51 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIDStaff As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnDeleteTable As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditTable As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddTable As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl50 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIDTable As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSaveTable As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelTable As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameTable As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIDCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbbSuplierObject As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIDObject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIDUnit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIDSupplier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnAddObjectInput As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbbInputStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cbbInputObject As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nmInputPrice As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nmInputCount As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnDeleteInput As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btEditInput As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddInput As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveInput As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelInput As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl12 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cbbOutputObject As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nmOutputCount As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton10 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton11 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton12 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton13 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnShowDetailBillInput As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddSupplierObject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbOutputStatus As System.Windows.Forms.ComboBox
    Friend WithEvents SimpleButton16 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddUnitObject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbbUnitObject As System.Windows.Forms.ComboBox
    Friend WithEvents tcInventory As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDoanhThu As System.Windows.Forms.TextBox
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtgiatritrungbinh As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
