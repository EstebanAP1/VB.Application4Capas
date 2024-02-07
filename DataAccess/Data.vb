Imports Common

Public Class Data
    Private db As Database

    Public Sub Prepare(command As String, Optional type As CommandType = CommandType.Text)
        db = New Database()
        db.CreateCommand(command, type)
    End Sub

    Public Sub AddParameter(name As String, type As SqlDbType, value As Object)
        db.AddParameter(name, type, value)
    End Sub

    Public Function LoadDataTable() As DataTable
        Return db.ExecuteDataTable()
    End Function

    Public Function LoadDataTable(command As String, Optional type As CommandType = CommandType.Text) As DataTable
        Prepare(command, type)
        Return LoadDataTable()
    End Function
End Class
