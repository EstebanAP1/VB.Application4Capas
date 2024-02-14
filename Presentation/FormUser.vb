Imports BusinessLogic
Imports Common

Public Class FormUser
    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserStatusBL.LoadCombo(CmbUserStatus)
        UserTypeBL.LoadCombo(CmbUserType)
        UsersBL.GetUsers(DgvUsers)
        AutoCompleteUsername()
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
            If bl.DbCodeError = -2146232060 Then
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
        If Validation.ValidateTextBox(TxtUsername, "Username is required") Then Return

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

    Private Sub SearchUser()
        If Validation.ValidateTextBox(TxtUsername, "Username is required") Then Return

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

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        SearchUser()
    End Sub

    Private Sub DgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUsers.CellClick
        If e.RowIndex >= 0 Then
            TxtUsername.Text = DgvUsers.Rows(e.RowIndex).Cells("Username").Value.ToString()
            SearchUser()
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        End
    End Sub

    Private Sub Clear()
        TxtUsername.Clear()
        TxtPassword.Clear()
        TxtPasswordConfirm.Clear()
        TxtName.Clear()
        CmbUserStatus.SelectedIndex = -1
        CmbUserType.SelectedIndex = -1

        UsersBL.GetUsers(DgvUsers)
        AutoCompleteUsername()
    End Sub

    Private Sub AutoCompleteUsername()
        Dim users = UsersBL.GetUsernameList()
        Dim source As New AutoCompleteStringCollection()
        source.AddRange(users.ToArray())
        TxtUsername.AutoCompleteCustomSource = source
        TxtUsername.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        TxtUsername.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub

    Private Function FormValidating() As Boolean
        If Validation.ValidateTextBox(TxtUsername, "Username is required") Then Return True
        If Validation.ValidateTextBox(TxtPassword, "Password is required") Then Return True
        If Validation.ValidateTextBox(TxtPasswordConfirm, "Password confirm is required") Then Return True
        If Validation.ValidateTextBox(TxtName, "Name is required") Then Return True
        If Validation.ValidateComboBox(CmbUserStatus, "User status is required") Then Return True
        If Validation.ValidateComboBox(CmbUserType, "User type is required") Then Return True
        If Validation.ValidatePassword(TxtPassword, TxtPasswordConfirm) Then Return True

        Return False
    End Function
End Class
