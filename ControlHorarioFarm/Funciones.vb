Imports System.Net

Module Funciones
    Private _time As DateTime = New DateTime(1900, 1, 1)

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

    Public Function CheckSalida(ByRef dgv As DataGridView) As Boolean
        Dim cantHoras As Integer = CInt(Main.dtTurnos.Rows(0).Item("CantHoras").ToString.Substring(11, 2))
        Dim entrada As Date = dgv.Rows(0).Cells("Hora").Value
        Dim horaSalida As TimeSpan = TimeSpan.Parse(Main.dtTurnos.Rows(0).Item("Salida").ToString.Substring(11))
        Dim fechaSalida As Date = Date.Parse(entrada.Date & " " & horaSalida.ToString)
        Dim hora As Date = DateAndTime.Now

        If DateAndTime.DateDiff(DateInterval.Hour, entrada, hora) > (cantHoras + 2) Then ' Horas del Turno más 2 extra
            If MessageBox.Show("¿Desea cerrar el turno anterior?", "Turno sin Cerrar Detectado!", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                MySQL.cortarHorario(Main.dtTurnos.Rows(0).Item("ID_Turno"), fechaSalida)
                Return True
            Else
                Return False
            End If
        End If
        Return False
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

    Public Property Time() As DateTime
        Set(value As DateTime)
            _time = value
        End Set
        Get
            Return _time.ToString("HH:mm:ss")
        End Get
    End Property

    Public Sub incrementTime()
        Time = Time.AddSeconds(1)
    End Sub

End Module
