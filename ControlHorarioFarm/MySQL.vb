Imports System.Data.Odbc
Module MySQL
    Private con As New OdbcConnection("DSN=Horarios")
    Private com As OdbcCommand
    Private dr As OdbcDataReader

    Public Function CargarEmpleados() As Collection
        Dim empleados As New Collection
        Try
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

                    empleados.Add(empleado, empleado.ID) 'Agrega empleado a la colección
                Loop
            Else
                MessageBox.Show("No se econtraron empleados")
            End If
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

    Public Function CargarSuc() As Collection
        Dim sucursales As New Collection
        Try
            com = New OdbcCommand("SELECT * FROM sucur ", con)
            con.Open()
            dr = com.ExecuteReader()

            If dr.HasRows Then
                Do While dr.Read()
                    Dim suc As New Entidades.Sucursales
                    suc.ID = dr.GetInt32(0)
                    suc.Nombre = dr.GetString(1)
                    suc.Abreviat = dr.GetString(2)

                    sucursales.Add(suc, suc.ID) 'Agrega sucursal a la colección
                Loop
            Else
                MessageBox.Show("No se econtraron empleados")
            End If
            Return sucursales
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
        Return sucursales
    End Function

    Public Sub cargarHistorial(ByRef dgv As DataGridView)
        Try
            dgv.Rows.Clear()
            com = New OdbcCommand("SELECT ingsal.tipo, ingsal.fechah, sucur.nombre, turnos.descripcion " & _
                                  "FROM ingsal LEFT JOIN sucur ON (sucur.id_suc = ingsal.id_suc) " & _
                                  "LEFT JOIN turnos ON (turnos.id_turno = ingsal.turno) " & _
                                  "WHERE ingsal.id_op = ? ORDER BY fechah DESC LIMIT 10 ", con)
            com.Parameters.AddWithValue("?ID", Main.empleado.ID)
            con.Open()
            dr = com.ExecuteReader()

            If dr.HasRows Then
                Do While dr.Read()
                    Dim row As New DataGridViewRow
                    row.CreateCells(dgv)

                    ' Carga el tipo de registros segun sea Entrada/Salida
                    If dr.GetInt32(0) = 1 Then
                        row.Cells(0).Value = "Entrada"
                        row.DefaultCellStyle.BackColor = Color.Aquamarine
                    ElseIf dr.GetInt32(0) = 2 Then
                        row.Cells(0).Value = "Salida"
                        row.DefaultCellStyle.BackColor = Color.IndianRed
                    End If
                    ' Carga la fecha y hora
                    row.Cells(1).Value = FormatDateTime(dr.GetDateTime(1), DateFormat.GeneralDate)
                    ' Carga la sucursal del registro
                    row.Cells(2).Value = dr.GetString(2)
                    ' Carga Turno
                    row.Cells(3).Value = dr.GetString(3)

                    dgv.Rows.Add(row)
                Loop
            Else
                MessageBox.Show("No se econtraron registros anteriores")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Sub testCon()
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
