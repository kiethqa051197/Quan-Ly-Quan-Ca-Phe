Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO

Public Class BillsDAO
    Private Shared instance As BillsDAO

    Public Shared Property _Instance As BillsDAO
        Get
            If instance Is Nothing Then instance = New BillsDAO()
            Return BillsDAO.instance
        End Get
        Private Set(value As BillsDAO)
            BillsDAO.instance = value
        End Set
    End Property

    Private Sub New()
    End Sub

    Public Function GetUncheckBillIDByTableID(id As Integer) As Integer
        Dim data As DataTable = DataProvider._Instance.ExecuteQuery("SELECT * FROM BILLS WHERE idTable = " & id & " AND status = 0")

        If data.Rows.Count > 0 Then
            Dim bill As Bills = New Bills(data.Rows(0))
            Return bill._id
        End If

        Return -1
    End Function

    Public Sub CheckOut(id As Integer, idCustomer As Integer, discount As Integer, idStaff As Integer)
        Dim query As String = "UPDATE BILLS SET idCustomer = " & idCustomer & ", dateCheckout = GETDATE(), status = 1," & "discount = " & discount & ", idStaff = " & idStaff & " WHERE id = " & id
        DataProvider._Instance.ExecuteNoneQuery(query)
    End Sub

    Public Sub InsertBill(idTable As Integer, idStaff As Integer)
        DataProvider._Instance.ExecuteNoneQuery("EXEC PC_InsertBill @idTb , @idSt ", New Object() {idTable, idStaff})
    End Sub

    Public Function GetBillListByDate(checkIn As DateTime, checkOut As DateTime) As DataTable
        Return DataProvider._Instance.ExecuteQuery("EXEC USP_GetBillByDate @datecheckin , @datecheckout ", New Object() {checkIn, checkOut})
    End Function

    Public Function GetBillListByDateAndPage(checkIn As DateTime, checkOut As DateTime, pageNum As Integer) As DataTable
        Return DataProvider._Instance.ExecuteQuery("EXEC USP_GetBillByDateAndPage @datecheckin , @datecheckout , @page ", New Object() {checkIn, checkOut, pageNum})
    End Function

    Public Function GetNumBillByDate(checkIn As DateTime, checkOut As DateTime) As Integer
        Return CInt(DataProvider._Instance.ExecuteScalar("EXEC USP_GetNumBillByDate @datecheckin , @datecheckout ", New Object() {checkIn, checkOut}))
    End Function

    Public Function GetMaxIDBill() As Integer
        Try
            Return CInt(DataProvider._Instance.ExecuteScalar("SELECT MAX(id) FROM BILLS"))
        Catch
            Return 1
        End Try
    End Function

    Public Function PrintReport(id As Integer) As DataTable
        Return DataProvider._Instance.ExecuteQuery("EXEC PC_REPORT_BILLS @idBill ", New Object() {id})
    End Function
End Class