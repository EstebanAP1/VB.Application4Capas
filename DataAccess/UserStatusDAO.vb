Imports Common
Public Class UserStatusDAO
    Public Function LoadCombo() As List(Of UserStatus)
        Dim statusList As New List(Of UserStatus)

        Dim data As New Data
        Dim dataTable = data.LoadDataTable("SELECT [id], [value] FROM [UserStatus]")

        For Each row As DataRow In dataTable.Rows
            Dim status As New UserStatus With {
                .Id = Convert.ToInt32(row("id")),
                .Value = row("value").ToString()
            }
            statusList.Add(status)
        Next

        Return statusList
    End Function
End Class
