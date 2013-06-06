Module Funciones
    Public Function Encrypt(ByVal pass As String) As String
        Dim EncryptedPass As String = ""
        Dim T, i, R As String
        Dim n, y As Integer
        Dim x As Long

        i = ""
        T = pass
        n = Len(T)
        For x = 1 To n
            R = Mid(T, x, 1)
            y = 155 - Asc(R)
            EncryptedPass += Chr(y)
        Next

        Return EncryptedPass
    End Function
End Module
