Public Class Users
    Public Property Username As String
    Public Property Password As String
    Public Property Name As String
    Public Property Status As Integer
    Public Property StatusValue As String
    Public Property Type As Integer
    Public Property TypeValue As String
    Public Property Found As Boolean
    Public Property Authenticated As Boolean


    Public Shared Property ActiveUser As String
    Public Shared Property ActivePassword As String

    Public Sub New()
        Username = ""
        Password = ""
        Name = ""
        Status = 0
        StatusValue = ""
        Type = 0
        TypeValue = ""
        Found = False
        Authenticated = False
    End Sub
End Class
