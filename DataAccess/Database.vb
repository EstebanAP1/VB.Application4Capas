Imports System.Data.SqlClient

Public Class Database
    Private ReadOnly connectionString As String
    Private ReadOnly connection As SqlConnection
    Private ReadOnly command As SqlCommand

    Public Property DbCodeError As Integer
    Public Property DbMessageError As String

    Private ReadOnly dataSource As String = "ESTEBAN\SQLEXPRESS"
    Private ReadOnly database As String = "VB_Users"
    Private ReadOnly user As String = "sa"
    Private ReadOnly password As String = "1234"

    Public Sub New()
        DbCodeError = 0
        DbMessageError = ""
        connectionString = $"Data Source={dataSource};Initial Catalog={database};User Id={user};Password={password}"
        connection = New SqlConnection(connectionString)
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

    Public Sub AddParameter(name As String, type As SqlDbType, value As Object)
        command.Parameters.AddWithValue(name, value).SqlDbType = type
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

    Public Function ExecuteReader() As SqlDataReader
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
            Using dataAdapter As New SqlDataAdapter(command)
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
