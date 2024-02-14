Imports System.Windows.Forms

Public Class Validation
    Public Shared Function ValidateTextBox(text As TextBox, message As String) As Boolean
        If String.IsNullOrWhiteSpace(text.Text) Then
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            text.Focus()
            Return True
        End If
        Return False
    End Function

    Public Shared Function ValidateComboBox(index As ComboBox, message As String) As Boolean
        If index.SelectedIndex = -1 Then
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            index.Focus()
            Return True
        End If
        Return False
    End Function

    Public Shared Function ValidatePassword(password As TextBox, passwordConfirm As TextBox) As Boolean
        If password.Text <> passwordConfirm.Text Then
            MessageBox.Show("Passwords must be equals", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            password.Text = ""
            passwordConfirm.Text = ""
            password.Focus()
            Return True
        End If
        If StronglyPassword(password.Text) Then
            password.Text = ""
            passwordConfirm.Text = ""
            password.Focus()
            Return True
        End If

        Return False
    End Function

    Private Shared Function StronglyPassword(password As String) As Boolean
        If password.Length < 8 Then
            MessageBox.Show("Password must be at least 8 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If

        If Not password.Any(Function(c) Char.IsUpper(c)) Then
            MessageBox.Show("Password must contain at least one uppercase letter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If

        If Not password.Any(Function(c) Char.IsLower(c)) Then
            MessageBox.Show("Password must contain at least one lowercase letter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If

        If Not password.Any(Function(c) Char.IsDigit(c)) Then
            MessageBox.Show("Password must contain at least one number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If

        If Not password.Any(Function(c) Not Char.IsLetterOrDigit(c)) Then
            MessageBox.Show("Password must contain at least one special character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If

        Return False
    End Function
End Class
