Imports Common
Imports DataAccess

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
End Class
