Imports System.Data.OleDb
Public Class Database
    Private ReadOnly connectionString As String
    Private ReadOnly connection As OleDbConnection
    Private ReadOnly command As OleDbCommand

    Public Property DbCodeError As Integer
    Public Property DbMessageError As String

    Private ReadOnly dataSource = "ESTEBAN\SQLEXPRESS"
    Private ReadOnly database = "VB_Users"
    Private ReadOnly user = "sa"
    Private ReadOnly password = "1234"

    Public Sub New()
        DbCodeError = 0
        DbMessageError = ""

        connectionString = $"Provider=MSOLEDBSQL;Data Source={dataSource};Initial Catalog={database};User Id={user};Password={password}"
        connection = New OleDbConnection(connectionString)
        command = connection.CreateCommand()
    End Sub

    Public Sub Connect()
        Try
            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
        Catch ex As Exception
            DbCodeError = ex.HResult
            DbMessageError = ex.Message
        End Try
    End Sub

    Public Sub Disconnect()
        If connection.State <> ConnectionState.Closed Then
            connection.Close()
        End If
    End Sub

    Public Sub CreateCommand(sql As String, Optional type As CommandType = CommandType.Text)
        command.CommandText = sql
        command.CommandType = type
    End Sub

    Public Sub AddParameter(name As String, type As OleDbType, value As Object)
        command.Parameters.AddWithValue(name, value).OleDbType = type
    End Sub

    Public Function ExecuteNonQuery() As Integer
        Try
            Connect()
            Return command.ExecuteNonQuery()
        Catch ex As Exception
            DbCodeError = ex.HResult
            DbMessageError = ex.Message
            Return -1
        Finally
            command.Parameters.Clear()
            Disconnect()
        End Try
    End Function

    Public Function ExecuteReader() As OleDbDataReader
        Try
            Connect()
            Return command.ExecuteReader(CommandBehavior.CloseConnection)
        Catch ex As Exception
            DbCodeError = ex.HResult
            DbMessageError = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function ExecuteDataTable() As DataTable
        Dim dataTable As New DataTable()
        Try
            Connect()
            Using dataAdapter As New OleDbDataAdapter(command)
                dataAdapter.Fill(dataTable)
            End Using
        Catch ex As Exception
            DbCodeError = ex.HResult
            DbMessageError = ex.Message
        Finally
            command.Parameters.Clear()
            Disconnect()
        End Try
        Return dataTable
    End Function
End Class
