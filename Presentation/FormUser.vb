Imports BusinessLogic
Imports Common

Public Class FormUser
    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserStatusBL.LoadCombo(CmbUserStatus)
        UserTypeBL.LoadCombo(CmbUserType)
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        If FormValidating() Then Return

        Dim user As New Users With {
            .Username = TxtUsername.Text,
            .Password = TxtPassword.Text,
            .Name = TxtName.Text,
            .Status = CmbUserStatus.SelectedValue,
            .Type = CmbUserType.SelectedValue
        }
        Dim bl As New UsersBL
        Dim result = bl.Insert(user)

        If bl.DbCodeError <> 0 Then
            If bl.DbCodeError = -2147217873 Then
                MessageBox.Show($"User {TxtUsername.Text} already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtUsername.Focus()
                Return
            End If
            MessageBox.Show($"Error: {bl.DbMessageError}", $"CodeError: {bl.DbCodeError}", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show($"User {TxtUsername.Text} inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear()
            TxtUsername.Focus()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If String.IsNullOrEmpty(TxtUsername.Text) Then
            MessageBox.Show("Username is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtUsername.Focus()
            Return
        End If

        Dim user As New Users With {
            .Username = TxtUsername.Text
        }
        Dim bl As New UsersBL
        Dim result = bl.Delete(user)

        If bl.DbCodeError <> 0 Then
            MessageBox.Show($"Error: {bl.DbMessageError}", $"CodeError: {bl.DbCodeError}", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If result = 0 Then
                MessageBox.Show($"User {TxtUsername.Text} not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtUsername.Focus()
            Else
                MessageBox.Show($"User {TxtUsername.Text} deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clear()
                TxtUsername.Focus()
            End If
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If FormValidating() Then Return

        Dim user As New Users With {
            .Username = TxtUsername.Text,
            .Password = TxtPassword.Text,
            .Name = TxtName.Text,
            .Status = CmbUserStatus.SelectedValue,
            .Type = CmbUserType.SelectedValue
        }
        Dim bl As New UsersBL
        Dim result = bl.Update(user)

        If bl.DbCodeError <> 0 Then
            MessageBox.Show($"Error: {bl.DbMessageError}", $"CodeError: {bl.DbCodeError}", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If result = 0 Then
                MessageBox.Show($"User {TxtUsername.Text} not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtUsername.Focus()
            Else
                MessageBox.Show($"User {TxtUsername.Text} updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clear()
                TxtUsername.Focus()
            End If
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If String.IsNullOrEmpty(TxtUsername.Text) Then
            MessageBox.Show("Username is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtUsername.Focus()
            Return
        End If

        Dim user As Users = UsersBL.GetUser(TxtUsername.Text)

        If user.Found Then
            TxtPassword.Text = user.Password
            TxtPasswordConfirm.Text = user.Password
            TxtName.Text = user.Name
            CmbUserStatus.SelectedValue = user.Status
            CmbUserType.SelectedValue = user.Type
        Else
            MessageBox.Show($"User {TxtUsername.Text} not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtUsername.Focus()
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        End
    End Sub

    Private Sub Clear(Optional username = "")
        TxtUsername.Text = username
        TxtPassword.Text = ""
        TxtPasswordConfirm.Text = ""
        TxtName.Text = ""
        CmbUserStatus.SelectedIndex = 0
        CmbUserType.SelectedIndex = 0
    End Sub

    Private Function FormValidating() As Boolean
        If String.IsNullOrWhiteSpace(TxtUsername.Text) Then
            MessageBox.Show("Username is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtUsername.Focus()
            Return True
        End If
        If String.IsNullOrWhiteSpace(TxtPassword.Text) Then
            MessageBox.Show("Password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtPassword.Focus()
            Return True
        End If
        If String.IsNullOrWhiteSpace(TxtPasswordConfirm.Text) Then
            MessageBox.Show("Password confirm is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtPasswordConfirm.Focus()
            Return True
        End If
        If String.IsNullOrWhiteSpace(TxtName.Text) Then
            MessageBox.Show("Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtName.Focus()
            Return True
        End If
        If (CmbUserStatus.SelectedIndex = -1) Then
            MessageBox.Show("Status is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CmbUserStatus.Focus()
            Return True
        End If
        If (CmbUserType.SelectedIndex = -1) Then
            MessageBox.Show("Type is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CmbUserType.Focus()
            Return True
        End If
        If TxtPassword.Text <> TxtPasswordConfirm.Text Then
            MessageBox.Show("Passwords must be equals", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtPasswordConfirm.Text = ""
            TxtPasswordConfirm.Focus()
            Return True
        End If

        Return False
    End Function
End Class
