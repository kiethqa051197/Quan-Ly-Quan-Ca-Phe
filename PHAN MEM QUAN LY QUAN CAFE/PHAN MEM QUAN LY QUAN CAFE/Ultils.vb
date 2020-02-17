Public Class Ultils
    Public Shared Function CheckEmpty(text As String) As Boolean
        If text.Equals("") Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
