Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO

Public Class FormHoaDon
    Public Sub New(id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim rpt As New Report_Bill(id)
        DocumentViewer1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
    End Sub


    Private Sub FormHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub
End Class