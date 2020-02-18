Public Class Bill_Report
    Public Sub BindData()
        lblname.DataBindings.Add("Text", DataSource, "FoodName")
        lblprice.DataBindings.Add("Text", DataSource, "Price")
        lblTotal.DataBindings.Add("Text", DataSource, "Total")
    End Sub
End Class