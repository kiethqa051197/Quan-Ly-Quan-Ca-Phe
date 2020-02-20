Public Class Report_Bill
    Public Sub New(id As Integer)
        InitializeComponent()
        DataSetBill1.Clear()
        PC_BILL_REPORTTableAdapter.Fill(DataSetBill1.PC_BILL_REPORT, id)
    End Sub
End Class