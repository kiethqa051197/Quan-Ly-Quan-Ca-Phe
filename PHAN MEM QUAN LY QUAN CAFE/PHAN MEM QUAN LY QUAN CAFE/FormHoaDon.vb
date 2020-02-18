Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO

Public Class FormHoaDon

    Private Sub FormHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New Bill_Report
        rpt.DataSource = BillsDAO._Instance.PrintReport(1006)
        rpt.BindData()
        DocumentViewer1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
    End Sub
End Class