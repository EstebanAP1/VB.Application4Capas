Imports DataAccess
Imports System.Windows.Forms

Public Class UserStatusBL
    Shared Sub LoadCombo(combo As ComboBox)
        Dim statusDAO As New UserStatusDAO
        combo.DataSource = statusDAO.LoadCombo()
        combo.DisplayMember = "Value"
        combo.ValueMember = "Id"
        combo.SelectedIndex = -1
    End Sub
End Class
