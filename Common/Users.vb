Public Class Users
    Public Property Username As String
    Public Property Password As String
    Public Property Name As String
    Public Property Status As Integer
    Public Property StatusValue As String
    Public Property Type As Integer
    Public Property TypeValue As String
    Public Property Found As Boolean

    Public Sub New()
        Username = ""
        Password = ""
        Name = ""
        Status = 0
        StatusValue = ""
        Type = 0
        TypeValue = ""
        Found = False
    End Sub
End Class
