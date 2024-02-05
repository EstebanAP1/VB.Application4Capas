Public Class UserType
    Public Property Id As Integer
    Public Property Value As String

    Public Sub New()
        Id = 0
        Value = ""
    End Sub

    Public Sub New(id As Integer, value As String)
        Me.Id = id
        Me.Value = value
    End Sub
End Class
