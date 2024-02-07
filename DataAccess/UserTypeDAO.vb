Imports Common
Public Class UserTypeDAO
    Public Function LoadCombo() As List(Of UserType)
        Dim typeList As New List(Of UserType)

        Dim data As New Data
        Dim dataTable = data.LoadDataTable("SELECT id,value FROM UserType")

        For Each row As DataRow In dataTable.Rows
            Dim type As New UserType With {
                .Id = Convert.ToInt32(row("id")),
                .Value = row("value").ToString()
            }
            typeList.Add(type)
        Next

        Return typeList
    End Function

End Class
