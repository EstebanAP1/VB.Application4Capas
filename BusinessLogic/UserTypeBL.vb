Imports DataAccess
Imports System.Windows.Forms

Public Class UserTypeBL
    Shared Sub LoadCombo(combo As ComboBox)
        Dim typeDAO As New UserTypeDAO
        combo.DataSource = typeDAO.LoadCombo()
        combo.DisplayMember = "Value"
        combo.ValueMember = "Id"
    End Sub
End Class
