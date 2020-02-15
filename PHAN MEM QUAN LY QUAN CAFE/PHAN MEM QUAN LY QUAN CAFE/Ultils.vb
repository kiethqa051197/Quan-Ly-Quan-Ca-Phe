Public Class Ultils
    Public Shared Function CheckEmpty(text As String) As Boolean
        If text.Equals("") Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function QuerySelectAllExcept(table As String) As String
        If table.Equals("TABLES") Then
            Dim query As String = "SELECT * FROM " & table & " WHERE statusDelete = 1 EXCEPT (SELECT * FROM " & table & " WHERE id = 1)"

            Return query
        Else
            Dim query As String = "SELECT * FROM " & table & " WHERE status = 1 EXCEPT (SELECT * FROM " & table & " WHERE id = 1)"

            Return query
        End If
    End Function
End Class
