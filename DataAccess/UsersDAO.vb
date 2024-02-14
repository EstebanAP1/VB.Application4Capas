Imports Common
Imports Microsoft.VisualBasic.ApplicationServices

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
        Dim query = "INSERT INTO Users(username,password,name,status,type) VALUES (@username,@password,@name,@status,@type)"
        db.CreateCommand(query)
        db.AddParameter("@username", SqlDbType.VarChar, user.Username)
        db.AddParameter("@password", SqlDbType.VarChar, user.Password)
        db.AddParameter("@name", SqlDbType.VarChar, user.Name)
        db.AddParameter("@status", SqlDbType.Int, user.Status)
        db.AddParameter("@type", SqlDbType.Int, user.Type)
        result = db.ExecuteNonQuery()

        If db.DbCodeError <> 0 Then
            DbCodeError = db.DbCodeError
            DbMessageError = db.DbMessageError
        End If

        Return result
    End Function

    Public Function Delete(user As Users) As Integer
        Dim result As Integer
        Dim query = "DELETE FROM Users WHERE username=@username"
        db.CreateCommand(query)
        db.AddParameter("@username", SqlDbType.VarChar, user.Username)
        result = db.ExecuteNonQuery()

        If db.DbCodeError <> 0 Then
            DbCodeError = db.DbCodeError
            DbMessageError = db.DbMessageError
        End If

        Return result
    End Function

    Public Function Update(user As Users) As Integer
        Dim result As Integer
        Dim query = "UPDATE Users SET password=@password,name=@name,status=@status,type=@type WHERE username=@username"
        db.CreateCommand(query)
        db.AddParameter("@username", SqlDbType.VarChar, user.Username)
        db.AddParameter("@password", SqlDbType.VarChar, user.Password)
        db.AddParameter("@name", SqlDbType.VarChar, user.Name)
        db.AddParameter("@status", SqlDbType.Int, user.Status)
        db.AddParameter("@type", SqlDbType.Int, user.Type)
        result = db.ExecuteNonQuery()

        If db.DbCodeError <> 0 Then
            DbCodeError = db.DbCodeError
            DbMessageError = db.DbMessageError
        End If

        Return result
    End Function

    Public Shared Function GetUser(username As String) As Users
        Dim db As New Database
        Dim query = "SELECT password,name,status,type FROM Users WHERE username=@username"
        db.CreateCommand(query, CommandType.Text)
        db.AddParameter("@username", SqlDbType.VarChar, username)

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

    Public Shared Function GetUsers() As List(Of Users)
        Dim users As New List(Of Users)
        Dim data As New Data
        Dim query = "SELECT u.username, u.name, us.value as status, ut.value as type FROM Users u
                     INNER JOIN UserStatus us ON u.status = us.id
                     INNER JOIN UserType ut ON u.type = ut.id"
        Dim dataTable = data.LoadDataTable(query)

        For Each row As DataRow In dataTable.Rows
            Dim user As New Users With {
                .Username = row("username").ToString(),
                .Name = row("name").ToString(),
                .StatusValue = row("status").ToString(),
                .TypeValue = row("type").ToString()
            }
            users.Add(user)
        Next

        Return users
    End Function

    Public Shared Function GetUsernameList() As List(Of String)
        Dim usernames As New List(Of String)
        Dim data As New Data
        Dim query = "SELECT username FROM Users"
        Dim dataTable = data.LoadDataTable(query)

        For Each row As DataRow In dataTable.Rows
            usernames.Add(row("username").ToString())
        Next

        Return usernames
    End Function

    Public Function ChangePassword(password As String) As Integer
        Dim result As Integer
        Dim query = "UPDATE Users SET password=@password WHERE username=@username"
        db.CreateCommand(query)
        db.AddParameter("@username", SqlDbType.VarChar, Users.ActiveUser)
        db.AddParameter("@password", SqlDbType.VarChar, password)
        result = db.ExecuteNonQuery()

        If db.DbCodeError <> 0 Then
            DbCodeError = db.DbCodeError
            DbMessageError = db.DbMessageError
        End If

        Return result
    End Function
End Class
