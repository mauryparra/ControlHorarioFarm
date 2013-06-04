Public Class Entidades
    Public Class Empleados
        Public Property ID As String
        Public Property Nombre As String
        Public Property Apellido As String
        Public Property Pass As String
        Public Property HorasMax As Integer
        Public Property Suc As Integer

        Public Function EncryptPass(ByVal pass As String) As String
            Dim encryptedPass As String = ""

            'Encriptar Contraseña

            Return encryptedPass
        End Function
    End Class
End Class
