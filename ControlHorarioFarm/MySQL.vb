Imports System.Data.Odbc
Module MySQL
    Private con As New OdbcConnection(My.Settings.ConnectionString)
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
                MessageBox.Show("No se econtraron empleados", "Control de Horarios", 0, MessageBoxIcon.Error)
            End If
            Return empleados
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Control de Horarios", 0, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
        Return empleados
    End Function

    Public Sub cargarSuc()
        Try
            Main.dtSucursales.Rows.Clear()
            com = New OdbcCommand("SELECT * FROM sucur ", con)
            con.Open()
            dr = com.ExecuteReader()

            If dr.HasRows Then
                Do While dr.Read()
                    Dim row As DataRow
                    row = Main.dtSucursales.NewRow()
                    row.Item("ID") = dr.GetInt32(0)
                    row.Item("Nombre") = dr.GetString(1)
                    row.Item("Abrev") = dr.GetString(2)

                    Main.dtSucursales.Rows.Add(row) 'Agrega sucursal al datatable
                Loop
            Else
                MessageBox.Show("No se econtraron Sucursales", "Control de Horarios", 0, MessageBoxIcon.Stop)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Control de Horarios", 0, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Public Sub cargarHistorial(ByRef dgv As DataGridView)
        Try
            dgv.Rows.Clear()
            com = New OdbcCommand("SELECT ingsal.tipo, ingsal.fechah, sucur.nombre, turnos.descripcion, turnos.id_turno " & _
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
                    row.Cells(1).Value = FormatDateTime(dr.GetDateTime(1)) ' VER
                    ' Carga la sucursal del registro
                    row.Cells(2).Value = dr.GetString(2)
                    ' Carga Turno
                    row.Cells(3).Value = dr.GetString(3)
                    ' Turno ID
                    row.Cells(4).Value = dr.GetInt32(4)

                    dgv.Rows.Add(row)
                Loop
            Else
                MessageBox.Show("No se econtraron registros anteriores", "Control de Horarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Control de Horarios", 0, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Public Sub cargarTurnos(Optional turnoAbierto As Integer = -1)
        Try
            Main.dtTurnos.Rows.Clear()
            If turnoAbierto = -1 Then
                com = New OdbcCommand("SELECT * FROM turnos WHERE id_suc = ? ", con)
                com.Parameters.AddWithValue("ID_SUC", My.Settings.Sucursal)
            Else
                com = New OdbcCommand("SELECT * FROM turnos WHERE id_turno = ? ", con)
                com.Parameters.AddWithValue("ID_Turno", turnoAbierto)
            End If

            con.Open()
            dr = com.ExecuteReader()

            If dr.HasRows Then
                Do While dr.Read()
                    Dim row As DataRow
                    row = Main.dtTurnos.NewRow()
                    row.Item("ID_Suc") = dr.GetInt32(0)
                    row.Item("ID_Turno") = dr.GetInt32(1)
                    row.Item("Abrev") = dr.GetString(2)
                    row.Item("Descrip") = dr.GetString(3)
                    row.Item("Entrada") = dr.GetString(4)
                    row.Item("Salida") = dr.GetString(5)
                    row.Item("CantHoras") = dr.GetString(6)


                    Main.dtTurnos.Rows.Add(row) 'Agrega turno al datatable
                Loop
            Else
                MessageBox.Show("No se econtraron Turnos", "Control de Horarios", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Control de Horarios", 0, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Public Sub marcarHorario()
        Try
            com = New OdbcCommand("INSERT INTO ingsal (id_op, turno, fechah, tipo, id_suc, id_estado, observacion) " & _
                                  "VALUES ( ?, ?, ?, ?, ?, ?, ? ) ", con)
            com.Parameters.AddWithValue("id_op", Main.empleado.ID)
            com.Parameters.AddWithValue("turno", Main.ComboBoxTurnos.SelectedValue)
            If My.Settings.InternetTime Then
                com.Parameters.AddWithValue("fechah", Funciones.Time)
            Else
                com.Parameters.AddWithValue("fechah", System.DateTime.Now)
            End If
            com.Parameters.AddWithValue("tipo", Main.ComboBoxTipo.SelectedIndex + 1)

            ' Obtener id_suc del datatable a partir del turno seleccionado
            Dim rowIndex As Integer
            rowIndex = Main.ComboBoxTurnos.SelectedIndex
            com.Parameters.AddWithValue("id_suc", Main.dtTurnos.DefaultView.Item(rowIndex).Item(0))
            com.Parameters.AddWithValue("id_estado", 1) ' VER
            com.Parameters.AddWithValue("observacion", "CHF v" & My.Application.Info.Version.ToString)

            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MessageBox.Show(Main.ComboBoxTipo.SelectedItem + " Registrada!", "Control de Horarios", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Control de Horarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Public Sub cortarHorario(ByVal turnoabierto As Integer, ByVal salida As Date)
        Try
            com = New OdbcCommand("INSERT INTO ingsal (id_op, turno, fechah, tipo, id_suc, id_estado, observacion) " & _
                                  "VALUES ( ?, ?, ?, ?, ?, ?, ? ) ", con)
            com.Parameters.AddWithValue("id_op", Main.empleado.ID)
            com.Parameters.AddWithValue("turno", turnoabierto)
            com.Parameters.AddWithValue("fechah", salida)
            com.Parameters.AddWithValue("tipo", Main.ComboBoxTipo.SelectedIndex + 1)

            ' Obtener id_suc del datatable a partir del turno seleccionado
            Dim rowIndex As Integer
            rowIndex = Main.ComboBoxTurnos.SelectedIndex
            com.Parameters.AddWithValue("id_suc", Main.dtTurnos.DefaultView.Item(rowIndex).Item(0))
            com.Parameters.AddWithValue("id_estado", 1) ' VER
            com.Parameters.AddWithValue("observacion", "AUTO CHF v" & My.Application.Info.Version.ToString)

            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Turno Cerrado Automaticamente!", "Control de Horarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Control de Horarios", 0, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Public Sub testCon()
        Try
            con.Open()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("No se puede conectar con la Base de Datos. " & ex.Message, "Control de Horarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        Finally
            con.Close()
        End Try
    End Sub

End Module
