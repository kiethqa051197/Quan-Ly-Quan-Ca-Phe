﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Report_Bill
Inherits DevExpress.XtraReports.UI.XtraReport

'XtraReport overrides dispose to clean up the component list.
<System.Diagnostics.DebuggerNonUserCode()> _
Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
    End If
    MyBase.Dispose(disposing)
End Sub

'Required by the Designer
Private components As System.ComponentModel.IContainer

'NOTE: The following procedure is required by the Designer
'It can be modified using the Designer.  
'Do not modify it using the code editor.
<System.Diagnostics.DebuggerStepThrough()> _
Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.lblname = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataSetBill1 = New DataSetBill()
        Me.PC_BILL_REPORTTableAdapter = New DataSetBillTableAdapters.PC_BILL_REPORTTableAdapter()
        Me.CalculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalculatedField2 = New DevExpress.XtraReports.UI.CalculatedField()
        CType(Me.DataSetBill1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblname, Me.XrLabel6, Me.XrLabel11, Me.XrLabel5})
        Me.Detail.HeightF = 41.33332!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StyleName = "DataField"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblname
        '
        Me.lblname.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PC_BILL_REPORT.name")})
        Me.lblname.LocationFloat = New DevExpress.Utils.PointFloat(6.458251!, 7.000001!)
        Me.lblname.Name = "lblname"
        Me.lblname.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblname.SizeF = New System.Drawing.SizeF(120.0!, 25.99999!)
        Me.lblname.StyleName = "DataField"
        Me.lblname.StylePriority.UseTextAlignment = False
        Me.lblname.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PC_BILL_REPORT.count")})
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(127.7916!, 7.000001!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(72.0!, 25.99999!)
        Me.XrLabel6.StyleName = "DataField"
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "lblcount"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PC_BILL_REPORT.CalculatedField1")})
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(283.0!, 7.000001!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(100.0!, 26.00001!)
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "XrLabel11"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PC_BILL_REPORT.price")})
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(201.75!, 5.333328!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(72.0!, 26.0!)
        Me.XrLabel5.StyleName = "DataField"
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "lblprice"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine6, Me.XrLine5, Me.XrLine4, Me.XrLine3, Me.XrLabel1, Me.XrLine2, Me.XrLabel2, Me.XrLabel3, Me.XrLabel4, Me.XrLabel8})
        Me.TopMargin.HeightF = 132.5!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine6
        '
        Me.XrLine6.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine6.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.XrLine6.LocationFloat = New DevExpress.Utils.PointFloat(267.9166!, 85.54173!)
        Me.XrLine6.Name = "XrLine6"
        Me.XrLine6.SizeF = New System.Drawing.SizeF(15.08338!, 23.00001!)
        '
        'XrLine5
        '
        Me.XrLine5.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine5.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.XrLine5.LocationFloat = New DevExpress.Utils.PointFloat(198.4582!, 85.54171!)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.SizeF = New System.Drawing.SizeF(15.08338!, 23.00001!)
        '
        'XrLine4
        '
        Me.XrLine4.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine4.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(111.3749!, 85.54169!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(15.08338!, 23.00001!)
        '
        'XrLine3
        '
        Me.XrLine3.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(6.458251!, 108.5417!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(376.5417!, 11.45833!)
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(135.0833!, 24.79167!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(147.9167!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "QUÁN CÀ PHÊ"
        '
        'XrLine2
        '
        Me.XrLine2.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(6.458251!, 68.62499!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(376.5417!, 11.45833!)
        '
        'XrLabel2
        '
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(6.458251!, 85.54169!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(104.9166!, 23.0!)
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Tên món"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(213.5416!, 85.54173!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(54.37498!, 23.0!)
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Đơn giá"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(127.7916!, 85.54169!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(70.66664!, 23.0!)
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Số lượng"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(283.0!, 85.54169!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(99.99997!, 23.0!)
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Thành tiền"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrLabel10, Me.XrLabel7})
        Me.BottomMargin.HeightF = 69.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine1
        '
        Me.XrLine1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 10.00001!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(383.0!, 11.45833!)
        '
        'XrLabel10
        '
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(227.7916!, 36.0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(80.00024!, 23.0!)
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Tổng cộng:"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PC_BILL_REPORT.CalculatedField1")})
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.ForeColor = System.Drawing.Color.Red
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(283.0!, 36.0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:$0}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel7.Summary = XrSummary1
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1.0!
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Title.ForeColor = System.Drawing.Color.Maroon
        Me.Title.Name = "Title"
        '
        'FieldCaption
        '
        Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
        Me.FieldCaption.BorderColor = System.Drawing.Color.Black
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.FieldCaption.BorderWidth = 1.0!
        Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
        Me.FieldCaption.Name = "FieldCaption"
        '
        'PageInfo
        '
        Me.PageInfo.BackColor = System.Drawing.Color.Transparent
        Me.PageInfo.BorderColor = System.Drawing.Color.Black
        Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageInfo.BorderWidth = 1.0!
        Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PageInfo.ForeColor = System.Drawing.Color.Black
        Me.PageInfo.Name = "PageInfo"
        '
        'DataField
        '
        Me.DataField.BackColor = System.Drawing.Color.Transparent
        Me.DataField.BorderColor = System.Drawing.Color.Black
        Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataField.BorderWidth = 1.0!
        Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.DataField.ForeColor = System.Drawing.Color.Black
        Me.DataField.Name = "DataField"
        Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'DataSetBill1
        '
        Me.DataSetBill1.DataSetName = "DataSetBill"
        Me.DataSetBill1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PC_BILL_REPORTTableAdapter
        '
        Me.PC_BILL_REPORTTableAdapter.ClearBeforeFill = True
        '
        'CalculatedField1
        '
        Me.CalculatedField1.DataMember = "PC_BILL_REPORT"
        Me.CalculatedField1.Expression = "[count] * [price]"
        Me.CalculatedField1.Name = "CalculatedField1"
        '
        'CalculatedField2
        '
        Me.CalculatedField2.DataMember = "PC_BILL_REPORT"
        Me.CalculatedField2.Name = "CalculatedField2"
        '
        'Report_Bill
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.CalculatedField1, Me.CalculatedField2})
        Me.DataAdapter = Me.PC_BILL_REPORTTableAdapter
        Me.DataMember = "PC_BILL_REPORT"
        Me.DataSource = Me.DataSetBill1
        Me.Margins = New System.Drawing.Printing.Margins(10, 10, 132, 69)
        Me.PageHeight = 583
        Me.PageWidth = 413
        Me.PaperKind = System.Drawing.Printing.PaperKind.A6
        Me.RequestParameters = False
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "14.1"
        CType(Me.DataSetBill1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

End Sub
Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
Friend WithEvents DataSetBill1 As DataSetBill
Friend WithEvents PC_BILL_REPORTTableAdapter As DataSetBillTableAdapters.PC_BILL_REPORTTableAdapter
Friend WithEvents CalculatedField1 As DevExpress.XtraReports.UI.CalculatedField
Friend WithEvents CalculatedField2 As DevExpress.XtraReports.UI.CalculatedField
Friend WithEvents lblname As DevExpress.XtraReports.UI.XRLabel
Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
End Class
