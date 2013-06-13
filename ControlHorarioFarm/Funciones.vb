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

    Public Sub filtrarTurnos(ByRef dt As DataTable)
        ' Filtra los turnos que se muestran en el combobox según la hora del día
        Dim remover As New List(Of DataRow)


        For Each row As DataRow In dt.Rows
            Dim hora As TimeSpan = TimeOfDay.TimeOfDay
            Dim entrada As TimeSpan = TimeSpan.Parse(row.Item("Entrada").ToString.Substring(11))
            Dim salida As TimeSpan = TimeSpan.Parse(row.Item("Salida").ToString.Substring(11))
            
            Dim margenEntrada As TimeSpan = TimeSpan.Parse("02:00:00")
            Dim margenSalida As TimeSpan = TimeSpan.Parse("00:30:00")

            If entrada < salida Then
                entrada -= margenEntrada
                salida += margenSalida
                If Not (TimeOfDay.TimeOfDay > entrada And TimeOfDay.TimeOfDay < salida) Then
                    remover.Add(row)
                End If
            Else
                entrada -= margenEntrada
                salida += margenSalida
                If TimeOfDay.TimeOfDay < entrada And TimeOfDay.TimeOfDay > salida Then
                    remover.Add(row)
                End If
            End If
        Next

        For Each row In remover
            dt.Rows.Remove(row)
        Next
    End Sub
End Module
