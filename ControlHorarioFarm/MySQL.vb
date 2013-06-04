Imports System.Data.Odbc
Module MySQL
    Public con As New OdbcConnection("DSN=Horarios")
    Public com As OdbcCommand
    Public dr As OdbcDataReader

    Public Function CargarEmpleados() As Collection
        Dim empleados As New Collection
        Try
            Using con
                com = New OdbcCommand("SELECT * FROM empleados WHERE baja = 0 ", con)
                con.Open()
                dr = com.ExecuteReader()

                If dr.HasRows Then
                    Do While dr.Read()
                        Dim empleado As New Entidades.Empleados
                        empleado.ID = dr.GetInt32(0)
                        empleado.Nombre = dr.GetString(1)
                        empleado.Apellido = dr.GetString(2)
                        empleado.Pass = dr.GetString(3)
                        empleado.HorasMax = dr.GetInt32(5) 'Campo 4 es Baja (Boolean) ya filtrado
                        empleado.Suc = dr.GetInt32(6)

                        empleados.Add(empleado) 'Agrega empleado a la colección
                    Loop
                Else
                    MessageBox.Show("No se econtraron empleados")
                End If
            End Using
            Return empleados
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
        Return empleados
    End Function


    Sub TestCon()
        Try
            con.Open()
            MessageBox.Show("Conectado")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

End Module
