Imports BusinessLogic

Public Class FormUser
    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserStatusBL.LoadCombo(CmbUserStatus)
        UserTypeBL.LoadCombo(CmbUserType)
    End Sub
End Class