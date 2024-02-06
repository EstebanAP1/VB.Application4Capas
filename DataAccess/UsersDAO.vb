Imports Common
Imports System.Data.OleDb

Public Class UsersDAO
    Private ReadOnly db As New Database
    Public Property DbCodeError As Integer
    Public Property DbMessageError As String
    Public Sub New()
        DbCodeError = 0
        DbMessageError = ""
    End Sub
    Public Function Insert(user As Users) As Integer
        Dim result As Integer
        Dim query = "INSERT INTO Users([username],[password],[name],[status],[type]) VALUES (?,?,?,?,?)"
        db.CreateCommand(query)
        db.AddParameter("?", OleDbType.VarChar, user.Username)
        db.AddParameter("?", OleDbType.VarChar, user.Password)
        db.AddParameter("?", OleDbType.VarChar, user.Name)
        db.AddParameter("?", OleDbType.Integer, user.Status)
        db.AddParameter("?", OleDbType.Integer, user.Type)
        result = db.ExecuteNonQuery()

        If db.DbCodeError <> 0 Then
            DbCodeError = db.DbCodeError
            DbMessageError = db.DbMessageError
        End If

        Return result
    End Function

    Public Function Delete(user As Users) As Integer
        Dim result As Integer
        Dim query = "DELETE FROM Users WHERE [username]=?"
        db.CreateCommand(query)
        db.AddParameter("?", OleDbType.VarChar, user.Username)
        result = db.ExecuteNonQuery()

        If db.DbCodeError <> 0 Then
            DbCodeError = db.DbCodeError
            DbMessageError = db.DbMessageError
        End If

        Return result
    End Function

    Public Function Update(user As Users) As Integer
        Dim result As Integer
        Dim query = "UPDATE Users SET [password]=?, [name]=?, [status]=?, [type]=? WHERE [username]=?"
        db.CreateCommand(query)
        db.AddParameter("?", OleDbType.VarChar, user.Password)
        db.AddParameter("?", OleDbType.VarChar, user.Name)
        db.AddParameter("?", OleDbType.Integer, user.Status)
        db.AddParameter("?", OleDbType.Integer, user.Type)
        db.AddParameter("?", OleDbType.VarChar, user.Username)
        result = db.ExecuteNonQuery()

        If db.DbCodeError <> 0 Then
            DbCodeError = db.DbCodeError
            DbMessageError = db.DbMessageError
        End If

        Return result
    End Function

    Public Shared Function GetUser(username As String) As Users
        Dim db As New Database
        Dim query = "SELECT [password],[name],[status],[type] FROM Users WHERE [username]=?"
        db.CreateCommand(query, CommandType.Text)
        db.AddParameter("?", OleDbType.VarChar, username)

        Dim data = db.ExecuteReader()
        Dim user As New Users()

        If data.Read() Then
            user.Found = True
            user.Username = username
            user.Password = data.GetString(0)
            user.Name = data.GetString(1)
            user.Status = data.GetInt32(2)
            user.Type = data.GetInt32(3)
        End If

        data.Close()

        Return user
    End Function
End Class
