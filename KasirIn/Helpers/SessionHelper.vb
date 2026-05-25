Public Class SessionHelper
    Public Shared UserId As Integer = 0
    Public Shared Username As String = ""
    Public Shared NamaLengkap As String = ""
    Public Shared Role As String = ""

    Public Shared Sub ClearSession()
        UserId = 0
        Username = ""
        NamaLengkap = ""
        Role = ""
    End Sub
End Class
