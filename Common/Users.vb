Public Class Users
    Public Property Username As String
    Public Property Password As String
    Public Property Name As String
    Public Property Status As Integer
    Public Property Type As Integer
    Public Property Found As Boolean

    Public Sub New()
        Username = ""
        Password = ""
        Name = ""
        Status = 0
        Type = 0
        Found = False
    End Sub

    Public Sub New(Username As String, Password As String, Name As String, Status As Integer, Type As Integer)
        Me.Username = Username
        Me.Password = Password
        Me.Name = Name
        Me.Status = Status
        Me.Type = Type
        Found = False
    End Sub
End Class
