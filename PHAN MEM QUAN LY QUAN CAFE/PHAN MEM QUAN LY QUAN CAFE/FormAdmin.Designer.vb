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
        Me.tpBill = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl()
        Me.btnEnd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNext = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPrevious = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFirst = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.dgvRevenue = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.btnStatistical = New DevExpress.XtraEditors.SimpleButton()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
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
        Me.LabelControl47 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIDCategory = New DevExpress.XtraEditors.TextEdit()
        Me.btnSaveCategory = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelCategory = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNameCategory = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.dgvCategory = New DevExpress.XtraGrid.GridControl()
        Me.gridCategory = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.btnDeleteCategory = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditCategory = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddCategory = New DevExpress.XtraEditors.SimpleButton()
        Me.tpFood = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl15 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIDFood = New DevExpress.XtraEditors.TextEdit()
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
        Me.PanelControl14 = New DevExpress.XtraEditors.PanelControl()
        Me.btnDeleteFood = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditFood = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddFood = New DevExpress.XtraEditors.SimpleButton()
        Me.tpCustomer = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl17 = New DevExpress.XtraEditors.PanelControl()
        Me.txtSearchCustomer = New DevExpress.XtraEditors.TextEdit()
        Me.btnSearchCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl18 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPhoneCustomer = New DevExpress.XtraEditors.TextEdit()
        Me.cbSexCustomer = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAddressCustomer = New System.Windows.Forms.TextBox()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdCardCustomer = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpCustomer = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSaveCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNameCustomer = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl19 = New DevExpress.XtraEditors.PanelControl()
        Me.dgvCustomer = New DevExpress.XtraGrid.GridControl()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl20 = New DevExpress.XtraEditors.PanelControl()
        Me.btnDeleteCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.tpStaff = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl12 = New DevExpress.XtraEditors.PanelControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.btnShowStaff = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl11 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl51 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIDStaff = New DevExpress.XtraEditors.TextEdit()
        Me.cbbGenderStaff = New System.Windows.Forms.ComboBox()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPhoneStaff = New DevExpress.XtraEditors.TextEdit()
        Me.btnResetPass = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
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
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.btnDeleteStaff = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditStaff = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddStaff = New DevExpress.XtraEditors.SimpleButton()
        Me.tpInventoryManagement = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl22 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.tpInput = New DevExpress.XtraTab.XtraTabPage()
        Me.panelTotal = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.cbInputStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.nmInputPrice = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.nmInputCount = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.cbInputObject = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dgvInput = New DevExpress.XtraGrid.GridControl()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpInput = New System.Windows.Forms.DateTimePicker()
        Me.tpOutput = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl21 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.cbOutputStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.nmOutputCount = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.cbOutputObject = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dgvOutput = New DevExpress.XtraGrid.GridControl()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpOutput = New System.Windows.Forms.DateTimePicker()
        Me.tpObject = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl29 = New DevExpress.XtraEditors.PanelControl()
        Me.cbUnit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbSuplier = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSaveObject = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelObject = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNameObject = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl30 = New DevExpress.XtraEditors.PanelControl()
        Me.dgvObject = New DevExpress.XtraGrid.GridControl()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl31 = New DevExpress.XtraEditors.PanelControl()
        Me.txtSearchObject = New DevExpress.XtraEditors.TextEdit()
        Me.btnSearchObject = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl32 = New DevExpress.XtraEditors.PanelControl()
        Me.btnDeleteObject = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditObject = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddObject = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage7 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl27 = New DevExpress.XtraEditors.PanelControl()
        Me.btnSaveUnit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelUnit = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNameUnit = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl28 = New DevExpress.XtraEditors.PanelControl()
        Me.dgvUnit = New DevExpress.XtraGrid.GridControl()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl25 = New DevExpress.XtraEditors.PanelControl()
        Me.txtSearchUnit = New DevExpress.XtraEditors.TextEdit()
        Me.btnSearchUnit = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl26 = New DevExpress.XtraEditors.PanelControl()
        Me.btnDeleteUnit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditUnit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddUnit = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage8 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl33 = New DevExpress.XtraEditors.PanelControl()
        Me.txtSearchSuplier = New DevExpress.XtraEditors.TextEdit()
        Me.btnSearchSuplier = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl36 = New DevExpress.XtraEditors.PanelControl()
        Me.btnDeleteSuplier = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditSuplier = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddSuplier = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl34 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmailSuplier = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPhoneSuplier = New DevExpress.XtraEditors.TextEdit()
        Me.txtAddressSuplier = New System.Windows.Forms.TextBox()
        Me.LabelControl46 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSaveSuplier = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelSuplier = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl48 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl49 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNameSuplier = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl35 = New DevExpress.XtraEditors.PanelControl()
        Me.dgvSuplier = New DevExpress.XtraGrid.GridControl()
        Me.GridView11 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
        CType(Me.tcAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcAdmin.SuspendLayout()
        Me.tpBill.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.dgvRevenue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
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
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
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
        CType(Me.PanelControl14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl14.SuspendLayout()
        Me.tpCustomer.SuspendLayout()
        CType(Me.PanelControl17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl17.SuspendLayout()
        CType(Me.txtSearchCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl18, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl18.SuspendLayout()
        CType(Me.txtPhoneCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSexCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdCardCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl19, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl19.SuspendLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl20.SuspendLayout()
        Me.tpStaff.SuspendLayout()
        CType(Me.PanelControl12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl12.SuspendLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
        Me.tpInventoryManagement.SuspendLayout()
        CType(Me.PanelControl22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl22.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.tpInput.SuspendLayout()
        CType(Me.panelTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTotal.SuspendLayout()
        CType(Me.cbInputStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmInputPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmInputCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbInputObject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpOutput.SuspendLayout()
        CType(Me.PanelControl21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl21.SuspendLayout()
        CType(Me.cbOutputStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmOutputCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbOutputObject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpObject.SuspendLayout()
        CType(Me.PanelControl29, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl29.SuspendLayout()
        CType(Me.cbUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSuplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameObject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl30, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl30.SuspendLayout()
        CType(Me.dgvObject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl31, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl31.SuspendLayout()
        CType(Me.txtSearchObject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl32, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl32.SuspendLayout()
        Me.XtraTabPage7.SuspendLayout()
        CType(Me.PanelControl27, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl27.SuspendLayout()
        CType(Me.txtNameUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl28, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl28.SuspendLayout()
        CType(Me.dgvUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl25, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl25.SuspendLayout()
        CType(Me.txtSearchUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl26, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl26.SuspendLayout()
        Me.XtraTabPage8.SuspendLayout()
        CType(Me.PanelControl33, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl33.SuspendLayout()
        CType(Me.txtSearchSuplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl36, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl36.SuspendLayout()
        CType(Me.PanelControl34, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl34.SuspendLayout()
        CType(Me.txtEmailSuplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhoneSuplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameSuplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl35, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl35.SuspendLayout()
        CType(Me.dgvSuplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcAdmin
        '
        Me.tcAdmin.Location = New System.Drawing.Point(12, 12)
        Me.tcAdmin.Name = "tcAdmin"
        Me.tcAdmin.SelectedTabPage = Me.tpBill
        Me.tcAdmin.Size = New System.Drawing.Size(746, 473)
        Me.tcAdmin.TabIndex = 0
        Me.tcAdmin.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tpBill, Me.tpTable, Me.tpCategory, Me.tpFood, Me.tpCustomer, Me.tpStaff, Me.tpInventoryManagement})
        '
        'tpBill
        '
        Me.tpBill.Controls.Add(Me.LabelControl45)
        Me.tpBill.Controls.Add(Me.btnEnd)
        Me.tpBill.Controls.Add(Me.btnNext)
        Me.tpBill.Controls.Add(Me.btnPrevious)
        Me.tpBill.Controls.Add(Me.btnFirst)
        Me.tpBill.Controls.Add(Me.PanelControl2)
        Me.tpBill.Controls.Add(Me.PanelControl1)
        Me.tpBill.Name = "tpBill"
        Me.tpBill.Size = New System.Drawing.Size(740, 445)
        Me.tpBill.Text = "Doanh thu"
        '
        'LabelControl45
        '
        Me.LabelControl45.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl45.Location = New System.Drawing.Point(373, 414)
        Me.LabelControl45.Name = "LabelControl45"
        Me.LabelControl45.Size = New System.Drawing.Size(8, 14)
        Me.LabelControl45.TabIndex = 7
        Me.LabelControl45.Text = "1"
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(523, 411)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 5
        Me.btnEnd.Text = "Cuối"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(442, 411)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Kế tiếp"
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(221, 411)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 3
        Me.btnPrevious.Text = "Trước"
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(140, 411)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 23)
        Me.btnFirst.TabIndex = 2
        Me.btnFirst.Text = "Đầu"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.dgvRevenue)
        Me.PanelControl2.Location = New System.Drawing.Point(8, 63)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(725, 340)
        Me.PanelControl2.TabIndex = 1
        '
        'dgvRevenue
        '
        Me.dgvRevenue.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvRevenue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRevenue.Location = New System.Drawing.Point(2, 2)
        Me.dgvRevenue.MainView = Me.GridView1
        Me.dgvRevenue.Name = "dgvRevenue"
        Me.dgvRevenue.Size = New System.Drawing.Size(721, 336)
        Me.dgvRevenue.TabIndex = 2
        Me.dgvRevenue.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.dgvRevenue
        Me.GridView1.Name = "GridView1"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.dtpToDate)
        Me.PanelControl1.Controls.Add(Me.btnStatistical)
        Me.PanelControl1.Controls.Add(Me.dtpFromDate)
        Me.PanelControl1.Location = New System.Drawing.Point(8, 15)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(725, 42)
        Me.PanelControl1.TabIndex = 0
        '
        'dtpToDate
        '
        Me.dtpToDate.Location = New System.Drawing.Point(518, 11)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpToDate.TabIndex = 2
        '
        'btnStatistical
        '
        Me.btnStatistical.Location = New System.Drawing.Point(330, 4)
        Me.btnStatistical.Name = "btnStatistical"
        Me.btnStatistical.Size = New System.Drawing.Size(80, 33)
        Me.btnStatistical.TabIndex = 1
        Me.btnStatistical.Text = "Thống kê"
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Location = New System.Drawing.Point(8, 11)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpFromDate.TabIndex = 0
        '
        'tpTable
        '
        Me.tpTable.Controls.Add(Me.PanelControl23)
        Me.tpTable.Controls.Add(Me.PanelControl5)
        Me.tpTable.Controls.Add(Me.PanelControl3)
        Me.tpTable.Name = "tpTable"
        Me.tpTable.Size = New System.Drawing.Size(740, 445)
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
        Me.tpCategory.Controls.Add(Me.PanelControl6)
        Me.tpCategory.Name = "tpCategory"
        Me.tpCategory.Size = New System.Drawing.Size(740, 445)
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
        Me.PanelControl8.Controls.Add(Me.LabelControl47)
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
        'LabelControl47
        '
        Me.LabelControl47.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl47.Location = New System.Drawing.Point(20, 128)
        Me.LabelControl47.Name = "LabelControl47"
        Me.LabelControl47.Size = New System.Drawing.Size(18, 14)
        Me.LabelControl47.TabIndex = 9
        Me.LabelControl47.Text = "ID:"
        '
        'txtIDCategory
        '
        Me.txtIDCategory.Location = New System.Drawing.Point(119, 126)
        Me.txtIDCategory.Name = "txtIDCategory"
        Me.txtIDCategory.Size = New System.Drawing.Size(176, 20)
        Me.txtIDCategory.TabIndex = 10
        '
        'btnSaveCategory
        '
        Me.btnSaveCategory.Location = New System.Drawing.Point(119, 202)
        Me.btnSaveCategory.Name = "btnSaveCategory"
        Me.btnSaveCategory.Size = New System.Drawing.Size(85, 28)
        Me.btnSaveCategory.TabIndex = 7
        Me.btnSaveCategory.Text = "Lưu"
        Me.btnSaveCategory.Visible = False
        '
        'btnCancelCategory
        '
        Me.btnCancelCategory.Location = New System.Drawing.Point(210, 202)
        Me.btnCancelCategory.Name = "btnCancelCategory"
        Me.btnCancelCategory.Size = New System.Drawing.Size(85, 28)
        Me.btnCancelCategory.TabIndex = 8
        Me.btnCancelCategory.Text = "Huỷ"
        Me.btnCancelCategory.Visible = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Location = New System.Drawing.Point(82, 53)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(173, 18)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "THÔNG TIN DANH MỤC"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Location = New System.Drawing.Point(20, 156)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(90, 14)
        Me.LabelControl6.TabIndex = 6
        Me.LabelControl6.Text = "Tên danh mục:"
        '
        'txtNameCategory
        '
        Me.txtNameCategory.Location = New System.Drawing.Point(119, 154)
        Me.txtNameCategory.Name = "txtNameCategory"
        Me.txtNameCategory.Size = New System.Drawing.Size(176, 20)
        Me.txtNameCategory.TabIndex = 6
        '
        'PanelControl7
        '
        Me.PanelControl7.Controls.Add(Me.dgvCategory)
        Me.PanelControl7.Location = New System.Drawing.Point(3, 65)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(409, 374)
        Me.PanelControl7.TabIndex = 5
        '
        'dgvCategory
        '
        Me.dgvCategory.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCategory.Location = New System.Drawing.Point(2, 2)
        Me.dgvCategory.MainView = Me.gridCategory
        Me.dgvCategory.Name = "dgvCategory"
        Me.dgvCategory.Size = New System.Drawing.Size(405, 370)
        Me.dgvCategory.TabIndex = 2
        Me.dgvCategory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridCategory})
        '
        'gridCategory
        '
        Me.gridCategory.GridControl = Me.dgvCategory
        Me.gridCategory.Name = "gridCategory"
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.btnDeleteCategory)
        Me.PanelControl6.Controls.Add(Me.btnEditCategory)
        Me.PanelControl6.Controls.Add(Me.btnAddCategory)
        Me.PanelControl6.Location = New System.Drawing.Point(3, 5)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(409, 55)
        Me.PanelControl6.TabIndex = 4
        '
        'btnDeleteCategory
        '
        Me.btnDeleteCategory.Location = New System.Drawing.Point(310, 5)
        Me.btnDeleteCategory.Name = "btnDeleteCategory"
        Me.btnDeleteCategory.Size = New System.Drawing.Size(85, 45)
        Me.btnDeleteCategory.TabIndex = 3
        Me.btnDeleteCategory.Text = "Xoá"
        '
        'btnEditCategory
        '
        Me.btnEditCategory.Location = New System.Drawing.Point(160, 5)
        Me.btnEditCategory.Name = "btnEditCategory"
        Me.btnEditCategory.Size = New System.Drawing.Size(85, 45)
        Me.btnEditCategory.TabIndex = 2
        Me.btnEditCategory.Text = "Sửa"
        '
        'btnAddCategory
        '
        Me.btnAddCategory.Location = New System.Drawing.Point(10, 5)
        Me.btnAddCategory.Name = "btnAddCategory"
        Me.btnAddCategory.Size = New System.Drawing.Size(85, 45)
        Me.btnAddCategory.TabIndex = 1
        Me.btnAddCategory.Text = "Thêm"
        '
        'tpFood
        '
        Me.tpFood.Controls.Add(Me.PanelControl15)
        Me.tpFood.Controls.Add(Me.PanelControl16)
        Me.tpFood.Controls.Add(Me.PanelControl13)
        Me.tpFood.Controls.Add(Me.PanelControl14)
        Me.tpFood.Name = "tpFood"
        Me.tpFood.Size = New System.Drawing.Size(740, 445)
        Me.tpFood.Text = "Thức ăn"
        '
        'PanelControl15
        '
        Me.PanelControl15.Controls.Add(Me.LabelControl33)
        Me.PanelControl15.Controls.Add(Me.txtIDFood)
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
        'LabelControl33
        '
        Me.LabelControl33.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl33.Location = New System.Drawing.Point(13, 96)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(18, 14)
        Me.LabelControl33.TabIndex = 29
        Me.LabelControl33.Text = "ID:"
        '
        'txtIDFood
        '
        Me.txtIDFood.Location = New System.Drawing.Point(119, 95)
        Me.txtIDFood.Name = "txtIDFood"
        Me.txtIDFood.Size = New System.Drawing.Size(176, 20)
        Me.txtIDFood.TabIndex = 30
        '
        'cbCategoryFood
        '
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
        Me.nmPriceFood.Location = New System.Drawing.Point(120, 182)
        Me.nmPriceFood.Name = "nmPriceFood"
        Me.nmPriceFood.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.nmPriceFood.Properties.IsFloatValue = False
        Me.nmPriceFood.Properties.Mask.EditMask = "N00"
        Me.nmPriceFood.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
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
        Me.btnSaveFood.Location = New System.Drawing.Point(120, 224)
        Me.btnSaveFood.Name = "btnSaveFood"
        Me.btnSaveFood.Size = New System.Drawing.Size(85, 28)
        Me.btnSaveFood.TabIndex = 9
        Me.btnSaveFood.Text = "Lưu"
        Me.btnSaveFood.Visible = False
        '
        'btnCancelFood
        '
        Me.btnCancelFood.Location = New System.Drawing.Point(211, 224)
        Me.btnCancelFood.Name = "btnCancelFood"
        Me.btnCancelFood.Size = New System.Drawing.Size(85, 28)
        Me.btnCancelFood.TabIndex = 10
        Me.btnCancelFood.Text = "Huỷ"
        Me.btnCancelFood.Visible = False
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
        Me.txtNameFood.Location = New System.Drawing.Point(120, 126)
        Me.txtNameFood.Name = "txtNameFood"
        Me.txtNameFood.Size = New System.Drawing.Size(176, 20)
        Me.txtNameFood.TabIndex = 6
        '
        'PanelControl16
        '
        Me.PanelControl16.Controls.Add(Me.dgvFood)
        Me.PanelControl16.Location = New System.Drawing.Point(3, 65)
        Me.PanelControl16.Name = "PanelControl16"
        Me.PanelControl16.Size = New System.Drawing.Size(409, 374)
        Me.PanelControl16.TabIndex = 11
        '
        'dgvFood
        '
        Me.dgvFood.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvFood.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFood.Location = New System.Drawing.Point(2, 2)
        Me.dgvFood.MainView = Me.gridFood
        Me.dgvFood.Name = "dgvFood"
        Me.dgvFood.Size = New System.Drawing.Size(405, 370)
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
        'PanelControl14
        '
        Me.PanelControl14.Controls.Add(Me.btnDeleteFood)
        Me.PanelControl14.Controls.Add(Me.btnEditFood)
        Me.PanelControl14.Controls.Add(Me.btnAddFood)
        Me.PanelControl14.Location = New System.Drawing.Point(3, 5)
        Me.PanelControl14.Name = "PanelControl14"
        Me.PanelControl14.Size = New System.Drawing.Size(409, 55)
        Me.PanelControl14.TabIndex = 9
        '
        'btnDeleteFood
        '
        Me.btnDeleteFood.Location = New System.Drawing.Point(310, 5)
        Me.btnDeleteFood.Name = "btnDeleteFood"
        Me.btnDeleteFood.Size = New System.Drawing.Size(85, 45)
        Me.btnDeleteFood.TabIndex = 3
        Me.btnDeleteFood.Text = "Xoá"
        '
        'btnEditFood
        '
        Me.btnEditFood.Location = New System.Drawing.Point(160, 5)
        Me.btnEditFood.Name = "btnEditFood"
        Me.btnEditFood.Size = New System.Drawing.Size(85, 45)
        Me.btnEditFood.TabIndex = 2
        Me.btnEditFood.Text = "Sửa"
        '
        'btnAddFood
        '
        Me.btnAddFood.Location = New System.Drawing.Point(10, 5)
        Me.btnAddFood.Name = "btnAddFood"
        Me.btnAddFood.Size = New System.Drawing.Size(85, 45)
        Me.btnAddFood.TabIndex = 1
        Me.btnAddFood.Text = "Thêm"
        '
        'tpCustomer
        '
        Me.tpCustomer.Controls.Add(Me.PanelControl17)
        Me.tpCustomer.Controls.Add(Me.PanelControl18)
        Me.tpCustomer.Controls.Add(Me.PanelControl19)
        Me.tpCustomer.Controls.Add(Me.PanelControl20)
        Me.tpCustomer.Name = "tpCustomer"
        Me.tpCustomer.Size = New System.Drawing.Size(740, 445)
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
        Me.PanelControl18.Controls.Add(Me.LabelControl15)
        Me.PanelControl18.Controls.Add(Me.txtPhoneCustomer)
        Me.PanelControl18.Controls.Add(Me.cbSexCustomer)
        Me.PanelControl18.Controls.Add(Me.LabelControl16)
        Me.PanelControl18.Controls.Add(Me.txtAddressCustomer)
        Me.PanelControl18.Controls.Add(Me.LabelControl17)
        Me.PanelControl18.Controls.Add(Me.txtIdCardCustomer)
        Me.PanelControl18.Controls.Add(Me.LabelControl20)
        Me.PanelControl18.Controls.Add(Me.dtpCustomer)
        Me.PanelControl18.Controls.Add(Me.LabelControl21)
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
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl15.Location = New System.Drawing.Point(13, 262)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(86, 14)
        Me.LabelControl15.TabIndex = 23
        Me.LabelControl15.Text = "Số điện thoại:"
        '
        'txtPhoneCustomer
        '
        Me.txtPhoneCustomer.Location = New System.Drawing.Point(118, 260)
        Me.txtPhoneCustomer.Name = "txtPhoneCustomer"
        Me.txtPhoneCustomer.Size = New System.Drawing.Size(176, 20)
        Me.txtPhoneCustomer.TabIndex = 11
        '
        'cbSexCustomer
        '
        Me.cbSexCustomer.EditValue = "(Chưa chọn)"
        Me.cbSexCustomer.Location = New System.Drawing.Point(119, 230)
        Me.cbSexCustomer.Name = "cbSexCustomer"
        Me.cbSexCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbSexCustomer.Properties.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.cbSexCustomer.Size = New System.Drawing.Size(176, 20)
        Me.cbSexCustomer.TabIndex = 10
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl16.Location = New System.Drawing.Point(14, 230)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(55, 14)
        Me.LabelControl16.TabIndex = 19
        Me.LabelControl16.Text = "Giới tính:"
        '
        'txtAddressCustomer
        '
        Me.txtAddressCustomer.Location = New System.Drawing.Point(119, 118)
        Me.txtAddressCustomer.Multiline = True
        Me.txtAddressCustomer.Name = "txtAddressCustomer"
        Me.txtAddressCustomer.Size = New System.Drawing.Size(176, 67)
        Me.txtAddressCustomer.TabIndex = 8
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl17.Location = New System.Drawing.Point(14, 199)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(88, 14)
        Me.LabelControl17.TabIndex = 16
        Me.LabelControl17.Text = "CMND / CCCD:"
        '
        'txtIdCardCustomer
        '
        Me.txtIdCardCustomer.Location = New System.Drawing.Point(119, 197)
        Me.txtIdCardCustomer.Name = "txtIdCardCustomer"
        Me.txtIdCardCustomer.Size = New System.Drawing.Size(176, 20)
        Me.txtIdCardCustomer.TabIndex = 9
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl20.Location = New System.Drawing.Point(14, 120)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(44, 14)
        Me.LabelControl20.TabIndex = 14
        Me.LabelControl20.Text = "Địa chỉ:"
        '
        'dtpCustomer
        '
        Me.dtpCustomer.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCustomer.Location = New System.Drawing.Point(119, 81)
        Me.dtpCustomer.Name = "dtpCustomer"
        Me.dtpCustomer.Size = New System.Drawing.Size(176, 20)
        Me.dtpCustomer.TabIndex = 7
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl21.Location = New System.Drawing.Point(14, 83)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(63, 14)
        Me.LabelControl21.TabIndex = 11
        Me.LabelControl21.Text = "Ngày sinh:"
        '
        'btnSaveCustomer
        '
        Me.btnSaveCustomer.Location = New System.Drawing.Point(119, 292)
        Me.btnSaveCustomer.Name = "btnSaveCustomer"
        Me.btnSaveCustomer.Size = New System.Drawing.Size(85, 28)
        Me.btnSaveCustomer.TabIndex = 12
        Me.btnSaveCustomer.Text = "Lưu"
        Me.btnSaveCustomer.Visible = False
        '
        'btnCancelCustomer
        '
        Me.btnCancelCustomer.Location = New System.Drawing.Point(210, 292)
        Me.btnCancelCustomer.Name = "btnCancelCustomer"
        Me.btnCancelCustomer.Size = New System.Drawing.Size(85, 28)
        Me.btnCancelCustomer.TabIndex = 13
        Me.btnCancelCustomer.Text = "Huỷ"
        Me.btnCancelCustomer.Visible = False
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl22.Location = New System.Drawing.Point(83, 8)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(191, 18)
        Me.LabelControl22.TabIndex = 8
        Me.LabelControl22.Text = "THÔNG TIN KHÁCH HÀNG"
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl23.Location = New System.Drawing.Point(13, 48)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(101, 14)
        Me.LabelControl23.TabIndex = 6
        Me.LabelControl23.Text = "Tên khách hàng:"
        '
        'txtNameCustomer
        '
        Me.txtNameCustomer.Location = New System.Drawing.Point(119, 47)
        Me.txtNameCustomer.Name = "txtNameCustomer"
        Me.txtNameCustomer.Size = New System.Drawing.Size(176, 20)
        Me.txtNameCustomer.TabIndex = 6
        '
        'PanelControl19
        '
        Me.PanelControl19.Controls.Add(Me.dgvCustomer)
        Me.PanelControl19.Location = New System.Drawing.Point(3, 65)
        Me.PanelControl19.Name = "PanelControl19"
        Me.PanelControl19.Size = New System.Drawing.Size(409, 374)
        Me.PanelControl19.TabIndex = 10
        '
        'dgvCustomer
        '
        Me.dgvCustomer.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCustomer.Location = New System.Drawing.Point(2, 2)
        Me.dgvCustomer.MainView = Me.GridView6
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.Size = New System.Drawing.Size(405, 370)
        Me.dgvCustomer.TabIndex = 2
        Me.dgvCustomer.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6})
        '
        'GridView6
        '
        Me.GridView6.GridControl = Me.dgvCustomer
        Me.GridView6.Name = "GridView6"
        '
        'PanelControl20
        '
        Me.PanelControl20.Controls.Add(Me.btnDeleteCustomer)
        Me.PanelControl20.Controls.Add(Me.btnEditCustomer)
        Me.PanelControl20.Controls.Add(Me.btnAddCustomer)
        Me.PanelControl20.Location = New System.Drawing.Point(3, 5)
        Me.PanelControl20.Name = "PanelControl20"
        Me.PanelControl20.Size = New System.Drawing.Size(409, 55)
        Me.PanelControl20.TabIndex = 9
        '
        'btnDeleteCustomer
        '
        Me.btnDeleteCustomer.Location = New System.Drawing.Point(310, 5)
        Me.btnDeleteCustomer.Name = "btnDeleteCustomer"
        Me.btnDeleteCustomer.Size = New System.Drawing.Size(85, 45)
        Me.btnDeleteCustomer.TabIndex = 3
        Me.btnDeleteCustomer.Text = "Xoá"
        '
        'btnEditCustomer
        '
        Me.btnEditCustomer.Location = New System.Drawing.Point(160, 5)
        Me.btnEditCustomer.Name = "btnEditCustomer"
        Me.btnEditCustomer.Size = New System.Drawing.Size(85, 45)
        Me.btnEditCustomer.TabIndex = 2
        Me.btnEditCustomer.Text = "Sửa"
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Location = New System.Drawing.Point(10, 5)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(85, 45)
        Me.btnAddCustomer.TabIndex = 1
        Me.btnAddCustomer.Text = "Thêm"
        '
        'tpStaff
        '
        Me.tpStaff.Controls.Add(Me.PanelControl12)
        Me.tpStaff.Controls.Add(Me.PanelControl11)
        Me.tpStaff.Controls.Add(Me.PanelControl10)
        Me.tpStaff.Controls.Add(Me.PanelControl9)
        Me.tpStaff.Name = "tpStaff"
        Me.tpStaff.Size = New System.Drawing.Size(740, 445)
        Me.tpStaff.Text = "Nhân viên"
        '
        'PanelControl12
        '
        Me.PanelControl12.Controls.Add(Me.TextEdit2)
        Me.PanelControl12.Controls.Add(Me.btnShowStaff)
        Me.PanelControl12.Location = New System.Drawing.Point(418, 5)
        Me.PanelControl12.Name = "PanelControl12"
        Me.PanelControl12.Size = New System.Drawing.Size(318, 55)
        Me.PanelControl12.TabIndex = 8
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(14, 18)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(190, 20)
        Me.TextEdit2.TabIndex = 3
        '
        'btnShowStaff
        '
        Me.btnShowStaff.Location = New System.Drawing.Point(228, 5)
        Me.btnShowStaff.Name = "btnShowStaff"
        Me.btnShowStaff.Size = New System.Drawing.Size(85, 45)
        Me.btnShowStaff.TabIndex = 4
        Me.btnShowStaff.Text = "Tìm"
        '
        'PanelControl11
        '
        Me.PanelControl11.Controls.Add(Me.LabelControl51)
        Me.PanelControl11.Controls.Add(Me.txtIDStaff)
        Me.PanelControl11.Controls.Add(Me.cbbGenderStaff)
        Me.PanelControl11.Controls.Add(Me.LabelControl12)
        Me.PanelControl11.Controls.Add(Me.txtPhoneStaff)
        Me.PanelControl11.Controls.Add(Me.btnResetPass)
        Me.PanelControl11.Controls.Add(Me.LabelControl11)
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
        Me.PanelControl11.Location = New System.Drawing.Point(418, 66)
        Me.PanelControl11.Name = "PanelControl11"
        Me.PanelControl11.Size = New System.Drawing.Size(318, 395)
        Me.PanelControl11.TabIndex = 7
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
        'txtIDStaff
        '
        Me.txtIDStaff.Location = New System.Drawing.Point(120, 37)
        Me.txtIDStaff.Name = "txtIDStaff"
        Me.txtIDStaff.Size = New System.Drawing.Size(176, 20)
        Me.txtIDStaff.TabIndex = 25
        '
        'cbbGenderStaff
        '
        Me.cbbGenderStaff.FormattingEnabled = True
        Me.cbbGenderStaff.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.cbbGenderStaff.Location = New System.Drawing.Point(119, 236)
        Me.cbbGenderStaff.Name = "cbbGenderStaff"
        Me.cbbGenderStaff.Size = New System.Drawing.Size(176, 21)
        Me.cbbGenderStaff.TabIndex = 24
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl12.Location = New System.Drawing.Point(14, 271)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(86, 14)
        Me.LabelControl12.TabIndex = 23
        Me.LabelControl12.Text = "Số điện thoại:"
        '
        'txtPhoneStaff
        '
        Me.txtPhoneStaff.Location = New System.Drawing.Point(119, 269)
        Me.txtPhoneStaff.Name = "txtPhoneStaff"
        Me.txtPhoneStaff.Size = New System.Drawing.Size(176, 20)
        Me.txtPhoneStaff.TabIndex = 10
        '
        'btnResetPass
        '
        Me.btnResetPass.Location = New System.Drawing.Point(120, 333)
        Me.btnResetPass.Name = "btnResetPass"
        Me.btnResetPass.Size = New System.Drawing.Size(176, 37)
        Me.btnResetPass.TabIndex = 12
        Me.btnResetPass.Text = "Đặt lại tài khoản"
        Me.btnResetPass.Visible = False
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl11.Location = New System.Drawing.Point(15, 238)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(55, 14)
        Me.LabelControl11.TabIndex = 19
        Me.LabelControl11.Text = "Giới tính:"
        '
        'txtAddressStaff
        '
        Me.txtAddressStaff.Location = New System.Drawing.Point(120, 140)
        Me.txtAddressStaff.Multiline = True
        Me.txtAddressStaff.Name = "txtAddressStaff"
        Me.txtAddressStaff.Size = New System.Drawing.Size(176, 51)
        Me.txtAddressStaff.TabIndex = 7
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl10.Location = New System.Drawing.Point(15, 206)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(88, 14)
        Me.LabelControl10.TabIndex = 16
        Me.LabelControl10.Text = "CMND / CCCD:"
        '
        'txtIDCardStaff
        '
        Me.txtIDCardStaff.Location = New System.Drawing.Point(120, 204)
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
        Me.btnSaveStaff.Location = New System.Drawing.Point(120, 299)
        Me.btnSaveStaff.Name = "btnSaveStaff"
        Me.btnSaveStaff.Size = New System.Drawing.Size(85, 28)
        Me.btnSaveStaff.TabIndex = 11
        Me.btnSaveStaff.Text = "Lưu"
        Me.btnSaveStaff.Visible = False
        '
        'btnCancelStaff
        '
        Me.btnCancelStaff.Location = New System.Drawing.Point(211, 299)
        Me.btnCancelStaff.Name = "btnCancelStaff"
        Me.btnCancelStaff.Size = New System.Drawing.Size(85, 28)
        Me.btnCancelStaff.TabIndex = 12
        Me.btnCancelStaff.Text = "Huỷ"
        Me.btnCancelStaff.Visible = False
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
        Me.txtNameStaff.Location = New System.Drawing.Point(121, 68)
        Me.txtNameStaff.Name = "txtNameStaff"
        Me.txtNameStaff.Size = New System.Drawing.Size(176, 20)
        Me.txtNameStaff.TabIndex = 5
        '
        'PanelControl10
        '
        Me.PanelControl10.Controls.Add(Me.dgvStaff)
        Me.PanelControl10.Location = New System.Drawing.Point(3, 65)
        Me.PanelControl10.Name = "PanelControl10"
        Me.PanelControl10.Size = New System.Drawing.Size(409, 374)
        Me.PanelControl10.TabIndex = 6
        '
        'dgvStaff
        '
        Me.dgvStaff.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStaff.Location = New System.Drawing.Point(2, 2)
        Me.dgvStaff.MainView = Me.gridStaff
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.Size = New System.Drawing.Size(405, 370)
        Me.dgvStaff.TabIndex = 2
        Me.dgvStaff.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridStaff})
        '
        'gridStaff
        '
        Me.gridStaff.GridControl = Me.dgvStaff
        Me.gridStaff.Name = "gridStaff"
        '
        'PanelControl9
        '
        Me.PanelControl9.Controls.Add(Me.btnDeleteStaff)
        Me.PanelControl9.Controls.Add(Me.btnEditStaff)
        Me.PanelControl9.Controls.Add(Me.btnAddStaff)
        Me.PanelControl9.Location = New System.Drawing.Point(3, 5)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(409, 55)
        Me.PanelControl9.TabIndex = 5
        '
        'btnDeleteStaff
        '
        Me.btnDeleteStaff.Location = New System.Drawing.Point(310, 5)
        Me.btnDeleteStaff.Name = "btnDeleteStaff"
        Me.btnDeleteStaff.Size = New System.Drawing.Size(85, 45)
        Me.btnDeleteStaff.TabIndex = 2
        Me.btnDeleteStaff.Text = "Xoá"
        '
        'btnEditStaff
        '
        Me.btnEditStaff.Location = New System.Drawing.Point(160, 5)
        Me.btnEditStaff.Name = "btnEditStaff"
        Me.btnEditStaff.Size = New System.Drawing.Size(85, 45)
        Me.btnEditStaff.TabIndex = 1
        Me.btnEditStaff.Text = "Sửa"
        '
        'btnAddStaff
        '
        Me.btnAddStaff.Location = New System.Drawing.Point(10, 5)
        Me.btnAddStaff.Name = "btnAddStaff"
        Me.btnAddStaff.Size = New System.Drawing.Size(85, 45)
        Me.btnAddStaff.TabIndex = 0
        Me.btnAddStaff.Text = "Thêm"
        '
        'tpInventoryManagement
        '
        Me.tpInventoryManagement.Controls.Add(Me.LabelControl30)
        Me.tpInventoryManagement.Controls.Add(Me.PanelControl22)
        Me.tpInventoryManagement.Name = "tpInventoryManagement"
        Me.tpInventoryManagement.Size = New System.Drawing.Size(740, 445)
        Me.tpInventoryManagement.Text = "Quản lý kho"
        '
        'LabelControl30
        '
        Me.LabelControl30.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl30.Location = New System.Drawing.Point(326, 9)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(95, 14)
        Me.LabelControl30.TabIndex = 18
        Me.LabelControl30.Text = "THÔNG TIN KHO"
        '
        'PanelControl22
        '
        Me.PanelControl22.Controls.Add(Me.XtraTabControl2)
        Me.PanelControl22.Location = New System.Drawing.Point(3, 31)
        Me.PanelControl22.Name = "PanelControl22"
        Me.PanelControl22.Size = New System.Drawing.Size(734, 411)
        Me.PanelControl22.TabIndex = 2
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Location = New System.Drawing.Point(5, 5)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.tpInput
        Me.XtraTabControl2.Size = New System.Drawing.Size(724, 401)
        Me.XtraTabControl2.TabIndex = 0
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tpInput, Me.tpOutput, Me.tpObject, Me.XtraTabPage7, Me.XtraTabPage8})
        '
        'tpInput
        '
        Me.tpInput.Controls.Add(Me.panelTotal)
        Me.tpInput.Name = "tpInput"
        Me.tpInput.Size = New System.Drawing.Size(718, 373)
        Me.tpInput.Text = "Nhập kho"
        '
        'panelTotal
        '
        Me.panelTotal.Controls.Add(Me.LabelControl29)
        Me.panelTotal.Controls.Add(Me.LabelControl28)
        Me.panelTotal.Controls.Add(Me.cbInputStatus)
        Me.panelTotal.Controls.Add(Me.LabelControl27)
        Me.panelTotal.Controls.Add(Me.nmInputPrice)
        Me.panelTotal.Controls.Add(Me.LabelControl26)
        Me.panelTotal.Controls.Add(Me.nmInputCount)
        Me.panelTotal.Controls.Add(Me.LabelControl25)
        Me.panelTotal.Controls.Add(Me.cbInputObject)
        Me.panelTotal.Controls.Add(Me.dgvInput)
        Me.panelTotal.Controls.Add(Me.LabelControl24)
        Me.panelTotal.Controls.Add(Me.dtpInput)
        Me.panelTotal.Location = New System.Drawing.Point(3, 3)
        Me.panelTotal.Name = "panelTotal"
        Me.panelTotal.Size = New System.Drawing.Size(712, 367)
        Me.panelTotal.TabIndex = 4
        '
        'LabelControl29
        '
        Me.LabelControl29.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl29.Location = New System.Drawing.Point(301, 13)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(133, 14)
        Me.LabelControl29.TabIndex = 17
        Me.LabelControl29.Text = "THÔNG TIN NHẬP KHO"
        '
        'LabelControl28
        '
        Me.LabelControl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl28.Location = New System.Drawing.Point(16, 83)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl28.TabIndex = 16
        Me.LabelControl28.Text = "Trạng thái:"
        '
        'cbInputStatus
        '
        Me.cbInputStatus.EditValue = "(Chưa chọn)"
        Me.cbInputStatus.Location = New System.Drawing.Point(87, 81)
        Me.cbInputStatus.Name = "cbInputStatus"
        Me.cbInputStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbInputStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbInputStatus.Size = New System.Drawing.Size(118, 20)
        Me.cbInputStatus.TabIndex = 4
        '
        'LabelControl27
        '
        Me.LabelControl27.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl27.Location = New System.Drawing.Point(270, 80)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(44, 14)
        Me.LabelControl27.TabIndex = 14
        Me.LabelControl27.Text = "Giá bán:"
        '
        'nmInputPrice
        '
        Me.nmInputPrice.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nmInputPrice.Location = New System.Drawing.Point(337, 79)
        Me.nmInputPrice.Name = "nmInputPrice"
        Me.nmInputPrice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.nmInputPrice.Properties.IsFloatValue = False
        Me.nmInputPrice.Properties.Mask.EditMask = "N00"
        Me.nmInputPrice.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nmInputPrice.Size = New System.Drawing.Size(72, 20)
        Me.nmInputPrice.TabIndex = 5
        '
        'LabelControl26
        '
        Me.LabelControl26.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl26.Location = New System.Drawing.Point(269, 47)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(53, 14)
        Me.LabelControl26.TabIndex = 12
        Me.LabelControl26.Text = "Số lượng:"
        '
        'nmInputCount
        '
        Me.nmInputCount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nmInputCount.Location = New System.Drawing.Point(337, 47)
        Me.nmInputCount.Name = "nmInputCount"
        Me.nmInputCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.nmInputCount.Properties.IsFloatValue = False
        Me.nmInputCount.Properties.Mask.EditMask = "N00"
        Me.nmInputCount.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nmInputCount.Size = New System.Drawing.Size(72, 20)
        Me.nmInputCount.TabIndex = 2
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl25.Location = New System.Drawing.Point(16, 47)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(58, 14)
        Me.LabelControl25.TabIndex = 10
        Me.LabelControl25.Text = "Sản phẩm:"
        '
        'cbInputObject
        '
        Me.cbInputObject.EditValue = "(Chưa chọn)"
        Me.cbInputObject.Location = New System.Drawing.Point(87, 45)
        Me.cbInputObject.Name = "cbInputObject"
        Me.cbInputObject.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbInputObject.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbInputObject.Size = New System.Drawing.Size(118, 20)
        Me.cbInputObject.TabIndex = 0
        '
        'dgvInput
        '
        Me.dgvInput.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvInput.Location = New System.Drawing.Point(5, 114)
        Me.dgvInput.MainView = Me.GridView7
        Me.dgvInput.Name = "dgvInput"
        Me.dgvInput.Size = New System.Drawing.Size(702, 248)
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
        Me.LabelControl24.Location = New System.Drawing.Point(445, 48)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(62, 14)
        Me.LabelControl24.TabIndex = 7
        Me.LabelControl24.Text = "Ngày nhập:"
        '
        'dtpInput
        '
        Me.dtpInput.Location = New System.Drawing.Point(518, 47)
        Me.dtpInput.Name = "dtpInput"
        Me.dtpInput.Size = New System.Drawing.Size(189, 20)
        Me.dtpInput.TabIndex = 3
        '
        'tpOutput
        '
        Me.tpOutput.Controls.Add(Me.PanelControl21)
        Me.tpOutput.Name = "tpOutput"
        Me.tpOutput.Size = New System.Drawing.Size(718, 373)
        Me.tpOutput.Text = "Xuất kho"
        '
        'PanelControl21
        '
        Me.PanelControl21.Controls.Add(Me.LabelControl31)
        Me.PanelControl21.Controls.Add(Me.LabelControl32)
        Me.PanelControl21.Controls.Add(Me.cbOutputStatus)
        Me.PanelControl21.Controls.Add(Me.LabelControl34)
        Me.PanelControl21.Controls.Add(Me.nmOutputCount)
        Me.PanelControl21.Controls.Add(Me.LabelControl35)
        Me.PanelControl21.Controls.Add(Me.cbOutputObject)
        Me.PanelControl21.Controls.Add(Me.dgvOutput)
        Me.PanelControl21.Controls.Add(Me.LabelControl36)
        Me.PanelControl21.Controls.Add(Me.dtpOutput)
        Me.PanelControl21.Location = New System.Drawing.Point(3, 3)
        Me.PanelControl21.Name = "PanelControl21"
        Me.PanelControl21.Size = New System.Drawing.Size(712, 367)
        Me.PanelControl21.TabIndex = 5
        '
        'LabelControl31
        '
        Me.LabelControl31.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl31.Location = New System.Drawing.Point(301, 13)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(131, 14)
        Me.LabelControl31.TabIndex = 17
        Me.LabelControl31.Text = "THÔNG TIN XUẤT KHO"
        '
        'LabelControl32
        '
        Me.LabelControl32.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl32.Location = New System.Drawing.Point(249, 83)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl32.TabIndex = 16
        Me.LabelControl32.Text = "Trạng thái:"
        '
        'cbOutputStatus
        '
        Me.cbOutputStatus.EditValue = "(Chưa chọn)"
        Me.cbOutputStatus.Location = New System.Drawing.Point(320, 81)
        Me.cbOutputStatus.Name = "cbOutputStatus"
        Me.cbOutputStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbOutputStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbOutputStatus.Size = New System.Drawing.Size(118, 20)
        Me.cbOutputStatus.TabIndex = 4
        '
        'LabelControl34
        '
        Me.LabelControl34.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl34.Location = New System.Drawing.Point(269, 47)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(53, 14)
        Me.LabelControl34.TabIndex = 12
        Me.LabelControl34.Text = "Số lượng:"
        '
        'nmOutputCount
        '
        Me.nmOutputCount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nmOutputCount.Location = New System.Drawing.Point(337, 47)
        Me.nmOutputCount.Name = "nmOutputCount"
        Me.nmOutputCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.nmOutputCount.Properties.IsFloatValue = False
        Me.nmOutputCount.Properties.Mask.EditMask = "N00"
        Me.nmOutputCount.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nmOutputCount.Size = New System.Drawing.Size(72, 20)
        Me.nmOutputCount.TabIndex = 2
        '
        'LabelControl35
        '
        Me.LabelControl35.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl35.Location = New System.Drawing.Point(16, 47)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(58, 14)
        Me.LabelControl35.TabIndex = 10
        Me.LabelControl35.Text = "Sản phẩm:"
        '
        'cbOutputObject
        '
        Me.cbOutputObject.EditValue = "(Chưa chọn)"
        Me.cbOutputObject.Location = New System.Drawing.Point(87, 45)
        Me.cbOutputObject.Name = "cbOutputObject"
        Me.cbOutputObject.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbOutputObject.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbOutputObject.Size = New System.Drawing.Size(118, 20)
        Me.cbOutputObject.TabIndex = 1
        '
        'dgvOutput
        '
        Me.dgvOutput.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvOutput.Location = New System.Drawing.Point(5, 114)
        Me.dgvOutput.MainView = Me.GridView8
        Me.dgvOutput.Name = "dgvOutput"
        Me.dgvOutput.Size = New System.Drawing.Size(702, 248)
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
        Me.LabelControl36.Location = New System.Drawing.Point(445, 48)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(59, 14)
        Me.LabelControl36.TabIndex = 7
        Me.LabelControl36.Text = "Ngày xuất:"
        '
        'dtpOutput
        '
        Me.dtpOutput.Location = New System.Drawing.Point(518, 47)
        Me.dtpOutput.Name = "dtpOutput"
        Me.dtpOutput.Size = New System.Drawing.Size(189, 20)
        Me.dtpOutput.TabIndex = 3
        '
        'tpObject
        '
        Me.tpObject.Controls.Add(Me.PanelControl29)
        Me.tpObject.Controls.Add(Me.PanelControl30)
        Me.tpObject.Controls.Add(Me.PanelControl31)
        Me.tpObject.Controls.Add(Me.PanelControl32)
        Me.tpObject.Name = "tpObject"
        Me.tpObject.Size = New System.Drawing.Size(718, 373)
        Me.tpObject.Text = "Sản phẩm"
        '
        'PanelControl29
        '
        Me.PanelControl29.Controls.Add(Me.cbUnit)
        Me.PanelControl29.Controls.Add(Me.cbSuplier)
        Me.PanelControl29.Controls.Add(Me.LabelControl42)
        Me.PanelControl29.Controls.Add(Me.LabelControl41)
        Me.PanelControl29.Controls.Add(Me.btnSaveObject)
        Me.PanelControl29.Controls.Add(Me.btnCancelObject)
        Me.PanelControl29.Controls.Add(Me.LabelControl37)
        Me.PanelControl29.Controls.Add(Me.LabelControl38)
        Me.PanelControl29.Controls.Add(Me.txtNameObject)
        Me.PanelControl29.Location = New System.Drawing.Point(402, 66)
        Me.PanelControl29.Name = "PanelControl29"
        Me.PanelControl29.Size = New System.Drawing.Size(313, 299)
        Me.PanelControl29.TabIndex = 19
        '
        'cbUnit
        '
        Me.cbUnit.EditValue = "(Chưa chọn)"
        Me.cbUnit.Location = New System.Drawing.Point(117, 165)
        Me.cbUnit.Name = "cbUnit"
        Me.cbUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbUnit.Size = New System.Drawing.Size(176, 20)
        Me.cbUnit.TabIndex = 7
        '
        'cbSuplier
        '
        Me.cbSuplier.EditValue = "(Chưa chọn)"
        Me.cbSuplier.Location = New System.Drawing.Point(117, 132)
        Me.cbSuplier.Name = "cbSuplier"
        Me.cbSuplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbSuplier.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbSuplier.Size = New System.Drawing.Size(176, 20)
        Me.cbSuplier.TabIndex = 6
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
        Me.btnSaveObject.Location = New System.Drawing.Point(117, 251)
        Me.btnSaveObject.Name = "btnSaveObject"
        Me.btnSaveObject.Size = New System.Drawing.Size(85, 28)
        Me.btnSaveObject.TabIndex = 8
        Me.btnSaveObject.Text = "Lưu"
        Me.btnSaveObject.Visible = False
        '
        'btnCancelObject
        '
        Me.btnCancelObject.Location = New System.Drawing.Point(208, 251)
        Me.btnCancelObject.Name = "btnCancelObject"
        Me.btnCancelObject.Size = New System.Drawing.Size(85, 28)
        Me.btnCancelObject.TabIndex = 9
        Me.btnCancelObject.Text = "Huỷ"
        Me.btnCancelObject.Visible = False
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
        Me.txtNameObject.Location = New System.Drawing.Point(117, 99)
        Me.txtNameObject.Name = "txtNameObject"
        Me.txtNameObject.Size = New System.Drawing.Size(176, 20)
        Me.txtNameObject.TabIndex = 5
        '
        'PanelControl30
        '
        Me.PanelControl30.Controls.Add(Me.dgvObject)
        Me.PanelControl30.Location = New System.Drawing.Point(3, 66)
        Me.PanelControl30.Name = "PanelControl30"
        Me.PanelControl30.Size = New System.Drawing.Size(393, 301)
        Me.PanelControl30.TabIndex = 18
        '
        'dgvObject
        '
        Me.dgvObject.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvObject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvObject.Location = New System.Drawing.Point(2, 2)
        Me.dgvObject.MainView = Me.GridView10
        Me.dgvObject.Name = "dgvObject"
        Me.dgvObject.Size = New System.Drawing.Size(389, 297)
        Me.dgvObject.TabIndex = 2
        Me.dgvObject.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView10})
        '
        'GridView10
        '
        Me.GridView10.GridControl = Me.dgvObject
        Me.GridView10.Name = "GridView10"
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
        'PanelControl32
        '
        Me.PanelControl32.Controls.Add(Me.btnDeleteObject)
        Me.PanelControl32.Controls.Add(Me.btnEditObject)
        Me.PanelControl32.Controls.Add(Me.btnAddObject)
        Me.PanelControl32.Location = New System.Drawing.Point(3, 5)
        Me.PanelControl32.Name = "PanelControl32"
        Me.PanelControl32.Size = New System.Drawing.Size(395, 55)
        Me.PanelControl32.TabIndex = 16
        '
        'btnDeleteObject
        '
        Me.btnDeleteObject.Location = New System.Drawing.Point(287, 5)
        Me.btnDeleteObject.Name = "btnDeleteObject"
        Me.btnDeleteObject.Size = New System.Drawing.Size(85, 45)
        Me.btnDeleteObject.TabIndex = 2
        Me.btnDeleteObject.Text = "Xoá"
        '
        'btnEditObject
        '
        Me.btnEditObject.Location = New System.Drawing.Point(143, 5)
        Me.btnEditObject.Name = "btnEditObject"
        Me.btnEditObject.Size = New System.Drawing.Size(85, 45)
        Me.btnEditObject.TabIndex = 1
        Me.btnEditObject.Text = "Sửa"
        '
        'btnAddObject
        '
        Me.btnAddObject.Location = New System.Drawing.Point(5, 5)
        Me.btnAddObject.Name = "btnAddObject"
        Me.btnAddObject.Size = New System.Drawing.Size(85, 45)
        Me.btnAddObject.TabIndex = 0
        Me.btnAddObject.Text = "Thêm"
        '
        'XtraTabPage7
        '
        Me.XtraTabPage7.Controls.Add(Me.PanelControl27)
        Me.XtraTabPage7.Controls.Add(Me.PanelControl28)
        Me.XtraTabPage7.Controls.Add(Me.PanelControl25)
        Me.XtraTabPage7.Controls.Add(Me.PanelControl26)
        Me.XtraTabPage7.Name = "XtraTabPage7"
        Me.XtraTabPage7.Size = New System.Drawing.Size(718, 373)
        Me.XtraTabPage7.Text = "Đơn vị"
        '
        'PanelControl27
        '
        Me.PanelControl27.Controls.Add(Me.btnSaveUnit)
        Me.PanelControl27.Controls.Add(Me.btnCancelUnit)
        Me.PanelControl27.Controls.Add(Me.LabelControl39)
        Me.PanelControl27.Controls.Add(Me.LabelControl40)
        Me.PanelControl27.Controls.Add(Me.txtNameUnit)
        Me.PanelControl27.Location = New System.Drawing.Point(402, 66)
        Me.PanelControl27.Name = "PanelControl27"
        Me.PanelControl27.Size = New System.Drawing.Size(313, 299)
        Me.PanelControl27.TabIndex = 15
        '
        'btnSaveUnit
        '
        Me.btnSaveUnit.Location = New System.Drawing.Point(117, 142)
        Me.btnSaveUnit.Name = "btnSaveUnit"
        Me.btnSaveUnit.Size = New System.Drawing.Size(85, 28)
        Me.btnSaveUnit.TabIndex = 6
        Me.btnSaveUnit.Text = "Lưu"
        Me.btnSaveUnit.Visible = False
        '
        'btnCancelUnit
        '
        Me.btnCancelUnit.Location = New System.Drawing.Point(208, 142)
        Me.btnCancelUnit.Name = "btnCancelUnit"
        Me.btnCancelUnit.Size = New System.Drawing.Size(85, 28)
        Me.btnCancelUnit.TabIndex = 7
        Me.btnCancelUnit.Text = "Huỷ"
        Me.btnCancelUnit.Visible = False
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
        Me.LabelControl40.Location = New System.Drawing.Point(11, 104)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(68, 14)
        Me.LabelControl40.TabIndex = 6
        Me.LabelControl40.Text = "Tên đơn vị:"
        '
        'txtNameUnit
        '
        Me.txtNameUnit.Location = New System.Drawing.Point(117, 103)
        Me.txtNameUnit.Name = "txtNameUnit"
        Me.txtNameUnit.Size = New System.Drawing.Size(176, 20)
        Me.txtNameUnit.TabIndex = 5
        '
        'PanelControl28
        '
        Me.PanelControl28.Controls.Add(Me.dgvUnit)
        Me.PanelControl28.Location = New System.Drawing.Point(3, 66)
        Me.PanelControl28.Name = "PanelControl28"
        Me.PanelControl28.Size = New System.Drawing.Size(393, 301)
        Me.PanelControl28.TabIndex = 14
        '
        'dgvUnit
        '
        Me.dgvUnit.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUnit.Location = New System.Drawing.Point(2, 2)
        Me.dgvUnit.MainView = Me.GridView9
        Me.dgvUnit.Name = "dgvUnit"
        Me.dgvUnit.Size = New System.Drawing.Size(389, 297)
        Me.dgvUnit.TabIndex = 2
        Me.dgvUnit.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView9})
        '
        'GridView9
        '
        Me.GridView9.GridControl = Me.dgvUnit
        Me.GridView9.Name = "GridView9"
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
        'PanelControl26
        '
        Me.PanelControl26.Controls.Add(Me.btnDeleteUnit)
        Me.PanelControl26.Controls.Add(Me.btnEditUnit)
        Me.PanelControl26.Controls.Add(Me.btnAddUnit)
        Me.PanelControl26.Location = New System.Drawing.Point(3, 5)
        Me.PanelControl26.Name = "PanelControl26"
        Me.PanelControl26.Size = New System.Drawing.Size(395, 55)
        Me.PanelControl26.TabIndex = 12
        '
        'btnDeleteUnit
        '
        Me.btnDeleteUnit.Location = New System.Drawing.Point(287, 5)
        Me.btnDeleteUnit.Name = "btnDeleteUnit"
        Me.btnDeleteUnit.Size = New System.Drawing.Size(85, 45)
        Me.btnDeleteUnit.TabIndex = 2
        Me.btnDeleteUnit.Text = "Xoá"
        '
        'btnEditUnit
        '
        Me.btnEditUnit.Location = New System.Drawing.Point(143, 5)
        Me.btnEditUnit.Name = "btnEditUnit"
        Me.btnEditUnit.Size = New System.Drawing.Size(85, 45)
        Me.btnEditUnit.TabIndex = 1
        Me.btnEditUnit.Text = "Sửa"
        '
        'btnAddUnit
        '
        Me.btnAddUnit.Location = New System.Drawing.Point(5, 5)
        Me.btnAddUnit.Name = "btnAddUnit"
        Me.btnAddUnit.Size = New System.Drawing.Size(85, 45)
        Me.btnAddUnit.TabIndex = 0
        Me.btnAddUnit.Text = "Thêm"
        '
        'XtraTabPage8
        '
        Me.XtraTabPage8.Controls.Add(Me.PanelControl33)
        Me.XtraTabPage8.Controls.Add(Me.PanelControl36)
        Me.XtraTabPage8.Controls.Add(Me.PanelControl34)
        Me.XtraTabPage8.Controls.Add(Me.PanelControl35)
        Me.XtraTabPage8.Name = "XtraTabPage8"
        Me.XtraTabPage8.Size = New System.Drawing.Size(718, 373)
        Me.XtraTabPage8.Text = "Nhà cung cấp"
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
        'PanelControl36
        '
        Me.PanelControl36.Controls.Add(Me.btnDeleteSuplier)
        Me.PanelControl36.Controls.Add(Me.btnEditSuplier)
        Me.PanelControl36.Controls.Add(Me.btnAddSuplier)
        Me.PanelControl36.Location = New System.Drawing.Point(3, 5)
        Me.PanelControl36.Name = "PanelControl36"
        Me.PanelControl36.Size = New System.Drawing.Size(395, 55)
        Me.PanelControl36.TabIndex = 26
        '
        'btnDeleteSuplier
        '
        Me.btnDeleteSuplier.Location = New System.Drawing.Point(287, 5)
        Me.btnDeleteSuplier.Name = "btnDeleteSuplier"
        Me.btnDeleteSuplier.Size = New System.Drawing.Size(85, 45)
        Me.btnDeleteSuplier.TabIndex = 2
        Me.btnDeleteSuplier.Text = "Xoá"
        '
        'btnEditSuplier
        '
        Me.btnEditSuplier.Location = New System.Drawing.Point(143, 5)
        Me.btnEditSuplier.Name = "btnEditSuplier"
        Me.btnEditSuplier.Size = New System.Drawing.Size(85, 45)
        Me.btnEditSuplier.TabIndex = 1
        Me.btnEditSuplier.Text = "Sửa"
        '
        'btnAddSuplier
        '
        Me.btnAddSuplier.Location = New System.Drawing.Point(5, 5)
        Me.btnAddSuplier.Name = "btnAddSuplier"
        Me.btnAddSuplier.Size = New System.Drawing.Size(85, 45)
        Me.btnAddSuplier.TabIndex = 0
        Me.btnAddSuplier.Text = "Thêm"
        '
        'PanelControl34
        '
        Me.PanelControl34.Controls.Add(Me.LabelControl44)
        Me.PanelControl34.Controls.Add(Me.txtEmailSuplier)
        Me.PanelControl34.Controls.Add(Me.LabelControl43)
        Me.PanelControl34.Controls.Add(Me.txtPhoneSuplier)
        Me.PanelControl34.Controls.Add(Me.txtAddressSuplier)
        Me.PanelControl34.Controls.Add(Me.LabelControl46)
        Me.PanelControl34.Controls.Add(Me.btnSaveSuplier)
        Me.PanelControl34.Controls.Add(Me.btnCancelSuplier)
        Me.PanelControl34.Controls.Add(Me.LabelControl48)
        Me.PanelControl34.Controls.Add(Me.LabelControl49)
        Me.PanelControl34.Controls.Add(Me.txtNameSuplier)
        Me.PanelControl34.Location = New System.Drawing.Point(402, 66)
        Me.PanelControl34.Name = "PanelControl34"
        Me.PanelControl34.Size = New System.Drawing.Size(313, 299)
        Me.PanelControl34.TabIndex = 13
        '
        'LabelControl44
        '
        Me.LabelControl44.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl44.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl44.Location = New System.Drawing.Point(7, 187)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(35, 14)
        Me.LabelControl44.TabIndex = 25
        Me.LabelControl44.Text = "Email:"
        '
        'txtEmailSuplier
        '
        Me.txtEmailSuplier.Location = New System.Drawing.Point(125, 186)
        Me.txtEmailSuplier.Name = "txtEmailSuplier"
        Me.txtEmailSuplier.Size = New System.Drawing.Size(163, 20)
        Me.txtEmailSuplier.TabIndex = 7
        '
        'LabelControl43
        '
        Me.LabelControl43.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl43.Location = New System.Drawing.Point(7, 161)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(86, 14)
        Me.LabelControl43.TabIndex = 23
        Me.LabelControl43.Text = "Số điện thoại:"
        '
        'txtPhoneSuplier
        '
        Me.txtPhoneSuplier.Location = New System.Drawing.Point(125, 159)
        Me.txtPhoneSuplier.Name = "txtPhoneSuplier"
        Me.txtPhoneSuplier.Size = New System.Drawing.Size(163, 20)
        Me.txtPhoneSuplier.TabIndex = 6
        '
        'txtAddressSuplier
        '
        Me.txtAddressSuplier.Location = New System.Drawing.Point(125, 95)
        Me.txtAddressSuplier.Multiline = True
        Me.txtAddressSuplier.Name = "txtAddressSuplier"
        Me.txtAddressSuplier.Size = New System.Drawing.Size(164, 54)
        Me.txtAddressSuplier.TabIndex = 6
        '
        'LabelControl46
        '
        Me.LabelControl46.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl46.Location = New System.Drawing.Point(8, 97)
        Me.LabelControl46.Name = "LabelControl46"
        Me.LabelControl46.Size = New System.Drawing.Size(44, 14)
        Me.LabelControl46.TabIndex = 14
        Me.LabelControl46.Text = "Địa chỉ:"
        '
        'btnSaveSuplier
        '
        Me.btnSaveSuplier.Location = New System.Drawing.Point(125, 235)
        Me.btnSaveSuplier.Name = "btnSaveSuplier"
        Me.btnSaveSuplier.Size = New System.Drawing.Size(85, 28)
        Me.btnSaveSuplier.TabIndex = 8
        Me.btnSaveSuplier.Text = "Lưu"
        Me.btnSaveSuplier.Visible = False
        '
        'btnCancelSuplier
        '
        Me.btnCancelSuplier.Location = New System.Drawing.Point(216, 235)
        Me.btnCancelSuplier.Name = "btnCancelSuplier"
        Me.btnCancelSuplier.Size = New System.Drawing.Size(71, 28)
        Me.btnCancelSuplier.TabIndex = 9
        Me.btnCancelSuplier.Text = "Huỷ"
        Me.btnCancelSuplier.Visible = False
        '
        'LabelControl48
        '
        Me.LabelControl48.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl48.Location = New System.Drawing.Point(48, 15)
        Me.LabelControl48.Name = "LabelControl48"
        Me.LabelControl48.Size = New System.Drawing.Size(206, 18)
        Me.LabelControl48.TabIndex = 8
        Me.LabelControl48.Text = "THÔNG TIN NHÀ CUNG CẤP"
        '
        'LabelControl49
        '
        Me.LabelControl49.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl49.Location = New System.Drawing.Point(7, 59)
        Me.LabelControl49.Name = "LabelControl49"
        Me.LabelControl49.Size = New System.Drawing.Size(112, 14)
        Me.LabelControl49.TabIndex = 6
        Me.LabelControl49.Text = "Tên nhà cung cấp:"
        '
        'txtNameSuplier
        '
        Me.txtNameSuplier.Location = New System.Drawing.Point(125, 58)
        Me.txtNameSuplier.Name = "txtNameSuplier"
        Me.txtNameSuplier.Size = New System.Drawing.Size(164, 20)
        Me.txtNameSuplier.TabIndex = 5
        '
        'PanelControl35
        '
        Me.PanelControl35.Controls.Add(Me.dgvSuplier)
        Me.PanelControl35.Location = New System.Drawing.Point(3, 66)
        Me.PanelControl35.Name = "PanelControl35"
        Me.PanelControl35.Size = New System.Drawing.Size(393, 301)
        Me.PanelControl35.TabIndex = 10
        '
        'dgvSuplier
        '
        Me.dgvSuplier.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvSuplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSuplier.Location = New System.Drawing.Point(2, 2)
        Me.dgvSuplier.MainView = Me.GridView11
        Me.dgvSuplier.Name = "dgvSuplier"
        Me.dgvSuplier.Size = New System.Drawing.Size(389, 297)
        Me.dgvSuplier.TabIndex = 2
        Me.dgvSuplier.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView11})
        '
        'GridView11
        '
        Me.GridView11.GridControl = Me.dgvSuplier
        Me.GridView11.Name = "GridView11"
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
        Me.ClientSize = New System.Drawing.Size(765, 487)
        Me.Controls.Add(Me.tcAdmin)
        Me.MaximumSize = New System.Drawing.Size(781, 526)
        Me.MinimumSize = New System.Drawing.Size(781, 526)
        Me.Name = "FormAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAdmin"
        CType(Me.tcAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcAdmin.ResumeLayout(False)
        Me.tpBill.ResumeLayout(False)
        Me.tpBill.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.dgvRevenue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
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
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
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
        CType(Me.PanelControl14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl14.ResumeLayout(False)
        Me.tpCustomer.ResumeLayout(False)
        CType(Me.PanelControl17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl17.ResumeLayout(False)
        CType(Me.txtSearchCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl18, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl18.ResumeLayout(False)
        Me.PanelControl18.PerformLayout()
        CType(Me.txtPhoneCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSexCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdCardCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl19, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl19.ResumeLayout(False)
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl20.ResumeLayout(False)
        Me.tpStaff.ResumeLayout(False)
        CType(Me.PanelControl12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl12.ResumeLayout(False)
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        Me.tpInventoryManagement.ResumeLayout(False)
        Me.tpInventoryManagement.PerformLayout()
        CType(Me.PanelControl22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl22.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.tpInput.ResumeLayout(False)
        CType(Me.panelTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTotal.ResumeLayout(False)
        Me.panelTotal.PerformLayout()
        CType(Me.cbInputStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmInputPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmInputCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbInputObject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpOutput.ResumeLayout(False)
        CType(Me.PanelControl21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl21.ResumeLayout(False)
        Me.PanelControl21.PerformLayout()
        CType(Me.cbOutputStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmOutputCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbOutputObject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpObject.ResumeLayout(False)
        CType(Me.PanelControl29, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl29.ResumeLayout(False)
        Me.PanelControl29.PerformLayout()
        CType(Me.cbUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSuplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameObject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl30, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl30.ResumeLayout(False)
        CType(Me.dgvObject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl31, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl31.ResumeLayout(False)
        CType(Me.txtSearchObject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl32, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl32.ResumeLayout(False)
        Me.XtraTabPage7.ResumeLayout(False)
        CType(Me.PanelControl27, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl27.ResumeLayout(False)
        Me.PanelControl27.PerformLayout()
        CType(Me.txtNameUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl28, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl28.ResumeLayout(False)
        CType(Me.dgvUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl25, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl25.ResumeLayout(False)
        CType(Me.txtSearchUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl26, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl26.ResumeLayout(False)
        Me.XtraTabPage8.ResumeLayout(False)
        CType(Me.PanelControl33, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl33.ResumeLayout(False)
        CType(Me.txtSearchSuplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl36, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl36.ResumeLayout(False)
        CType(Me.PanelControl34, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl34.ResumeLayout(False)
        Me.PanelControl34.PerformLayout()
        CType(Me.txtEmailSuplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhoneSuplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameSuplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl35, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl35.ResumeLayout(False)
        CType(Me.dgvSuplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcAdmin As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tpBill As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpTable As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpCategory As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpFood As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnStatistical As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgvRevenue As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnPrevious As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFirst As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEnd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNext As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgvTable As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridTable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgvCategory As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridCategory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
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
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
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
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnResetPass As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPhoneStaff As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl12 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnShowStaff As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents PanelControl14 As DevExpress.XtraEditors.PanelControl
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
    Friend WithEvents cbSexCustomer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAddressCustomer As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdCardCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpCustomer As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSaveCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl19 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgvCustomer As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl20 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnDeleteCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl22 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tpInput As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents panelTotal As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbInputStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nmInputPrice As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nmInputCount As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbInputObject As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents dgvInput As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tpOutput As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpObject As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage7 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage8 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl21 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbOutputStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nmOutputCount As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbOutputObject As DevExpress.XtraEditors.ComboBoxEdit
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
    Friend WithEvents PanelControl26 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnDeleteUnit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditUnit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddUnit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents PanelControl29 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cbUnit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbSuplier As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSaveObject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelObject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameObject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl30 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgvObject As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl31 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtSearchObject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSearchObject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl32 As DevExpress.XtraEditors.PanelControl
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
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl34 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPhoneSuplier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAddressSuplier As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl46 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSaveSuplier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelSuplier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameSuplier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl35 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgvSuplier As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmailSuplier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl33 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtSearchSuplier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSearchSuplier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl36 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnDeleteSuplier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditSuplier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddSuplier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbCategoryFood As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIDFood As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIDCategory As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbbGenderStaff As System.Windows.Forms.ComboBox
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
End Class
