Imports Common
Imports DataAccess
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Runtime.Serialization
Imports System.Windows.Forms

Public Class UsersBL
    Public Property DbCodeError As Integer
    Public Property DbMessageError As String

    Public Sub New()
        DbCodeError = 0
        DbMessageError = ""
    End Sub

    Public Function Insert(user As Users) As Integer
        Dim dao As New UsersDAO
        Dim result = dao.Insert(user)

        If dao.DbCodeError <> 0 Then
            DbCodeError = dao.DbCodeError
            DbMessageError = dao.DbMessageError
        End If

        Return result
    End Function

    Public Function Delete(user As Users) As Integer
        Dim dao As New UsersDAO
        Dim result = dao.Delete(user)

        If dao.DbCodeError <> 0 Then
            DbCodeError = dao.DbCodeError
            DbMessageError = dao.DbMessageError
        End If

        Return result
    End Function

    Public Function Update(user As Users) As Integer
        Dim dao As New UsersDAO
        Dim result = dao.Update(user)

        If dao.DbCodeError <> 0 Then
            DbCodeError = dao.DbCodeError
            DbMessageError = dao.DbMessageError
        End If

        Return result
    End Function

    Public Shared Function GetUser(username As String) As Users
        Return UsersDAO.GetUser(username)
    End Function

    Public Shared Sub GetUsers(DgvUsers As DataGridView)
        Dim users = UsersDAO.GetUsers()
        DgvUsers.DataSource = users.Select(Function(user) New With {
            user.Username,
            user.Name,
            user.StatusValue,
            user.TypeValue
        }).ToList()
        DgvUsers.Columns("StatusValue").HeaderText = "Status"
        DgvUsers.Columns("TypeValue").HeaderText = "Type"
    End Sub

    Public Shared Function GetUsernameList() As List(Of String)
        Return UsersDAO.GetUsernameList()
    End Function

    Public Shared Function Login(username As String, password As String) As Users
        Dim users = GetUser(username)

        If users.Found And users.Password = password And users.Status = 1 Then
            users.Authenticated = True
        End If

        Return users
    End Function

    Public Function ChangePassword(password As String) As Integer
        Dim dao As New UsersDAO
        Dim result = dao.ChangePassword(password)

        If dao.DbCodeError <> 0 Then
            DbCodeError = dao.DbCodeError
            DbMessageError = dao.DbMessageError
        End If

        Return result
    End Function
End Class
