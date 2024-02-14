Imports BusinessLogic
Imports Common
Imports Microsoft.VisualBasic.ApplicationServices

Public Class FormChangePass
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        If FormValidation() Then Return

        Dim bl As New UsersBL
        Dim result = bl.ChangePassword(TxtNewPassword.Text)

        If bl.DbCodeError <> 0 Then
            MessageBox.Show($"Error: {bl.DbMessageError}", $"CodeError: {bl.DbCodeError}", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If result <= 0 Then
                MessageBox.Show($"User {Users.ActiveUser} not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show($"Password changed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            End If
        End If
    End Sub

    Private Function FormValidation() As Boolean
        If Validation.ValidateTextBox(TxtActualPassword, "Actual password is required") Then Return True
        If Users.ActivePassword <> TxtActualPassword.Text Then
            MessageBox.Show("Actual password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtActualPassword.Clear()
            TxtActualPassword.Focus()
            Return True
        End If
        If Validation.ValidateTextBox(TxtNewPassword, "New password is required") Then Return True
        If Validation.ValidateTextBox(TxtConfirmPassword, "Confirm password is required") Then Return True
        If Validation.ValidatePassword(TxtNewPassword, TxtConfirmPassword) Then
            TxtNewPassword.Clear()
            TxtConfirmPassword.Clear()
            TxtNewPassword.Focus()
            Return True
        End If
        If TxtActualPassword.Text = TxtNewPassword.Text Then
            MessageBox.Show("New password must be different from the actual password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtNewPassword.Clear()
            TxtConfirmPassword.Clear()
            TxtNewPassword.Focus()
            Return True
        End If

        Return False
    End Function
End Class