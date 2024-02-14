Imports BusinessLogic
Imports Common

Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If FormValidation() Then Return

        Dim result = UsersBL.Login(UsernameTextBox.Text, PasswordTextBox.Text)
        If result.Authenticated Then
            Users.ActiveUser = result.Username
            Users.ActivePassword = result.Password
            If result.Type = 1 Then
                MdiAdmin.Show()
            ElseIf result.Type = 2 Then
                MdiLimited.Show()
            Else
                MessageBox.Show("Database error. Contact an administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Close()
        ElseIf result.Status = 2 Then
            MessageBox.Show("Your user is inactive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result.Status = 3 Then
            MessageBox.Show("Your user has been blocked. Contact an admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PasswordTextBox.Clear()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Close()
    End Sub

    Private Function FormValidation() As Boolean
        If Validation.ValidateTextBox(UsernameTextBox, "Username is required") Then Return True
        If Validation.ValidateTextBox(PasswordTextBox, "Password is required") Then Return True
        Return False
    End Function

End Class
