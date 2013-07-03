Public Class Main
    Public empleados As New Collection
    Public empleado As New Entidades.Empleados
    Public dtTurnos As New DataTable("Turnos")
    Public dtSucursales As New DataTable("Sucursales")

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        MySQL.testCon()
        ButtonMarcar.Enabled = False
        empleados = MySQL.CargarEmpleados()
        With dtSucursales
            .Columns.Add("ID")
            .Columns.Add("Nombre")
            .Columns.Add("Abrev")
        End With
        With dtTurnos
            .Columns.Add("ID_Suc")
            .Columns.Add("ID_Turno")
            .Columns.Add("Abrev")
            .Columns.Add("Descrip")
            .Columns.Add("Entrada")
            .Columns.Add("Salida")
            .Columns.Add("CantHoras")
        End With
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        LabelHora.Text = TimeOfDay.ToString("HH:mm:ss")
    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Application.Exit()
    End Sub

    Private Sub TextBoxNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim seleccion As New SelectEmpleado
            With seleccion
                .Location = New Point(25, 2)
            End With
            SplitContainer.Panel1.Controls.Add(seleccion)
            seleccion.BringToFront()
            seleccion.Focus()
        End If
    End Sub

    Private Sub ButtonConfig_Click(sender As Object, e As EventArgs) Handles ButtonConfig.Click
        If My.Settings.Contraseña = "" Then
            MessageBox.Show("Por favor configure una contraseña")
            Opciones.TextBoxActualPass.Enabled = False
            Opciones.ShowDialog()
        Else
            If PasswordDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Opciones.TextBoxActualPass.Enabled = True
                Opciones.ShowDialog()
            End If
        End If

    End Sub

    Private Sub TextBoxPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            If empleado.Pass = Encrypt(TextBoxPass.Text) Then
                TextBoxPass.Enabled = False
                cargarHistorial(DataGridViewReg)
                dtTurnos.Rows.Clear()
                ComboBoxTurnos.DataSource = dtTurnos.DefaultView
                ComboBoxTurnos.DisplayMember = "Descrip"
                ComboBoxTurnos.ValueMember = "ID_Turno"
                If DataGridViewReg.Rows.Count > 0 Then
                    If DataGridViewReg.Rows(0).Cells(0).Value = "Entrada" Then
                        ComboBoxTipo.SelectedItem = "Salida"
                        Me.BackColor = Color.IndianRed
                        MySQL.cargarTurnos(DataGridViewReg.Rows(0).Cells(4).Value)
                        ComboBoxTurnos.SelectedIndex = 0

                        If Funciones.CheckSalida(DataGridViewReg) = True Then
                            MySQL.cargarHistorial(DataGridViewReg)    ' Si cerro automaticamente
                            ComboBoxTipo.SelectedItem = "Entrada"
                            Me.BackColor = Color.Aquamarine
                            MySQL.cargarTurnos()
                            Funciones.filtrarTurnos(dtTurnos)
                        End If
                    Else
                        ComboBoxTipo.SelectedItem = "Entrada"
                        Me.BackColor = Color.Aquamarine
                        MySQL.cargarTurnos()
                        Funciones.filtrarTurnos(dtTurnos)
                    End If
                Else
                    ComboBoxTipo.SelectedItem = "Entrada"
                    Me.BackColor = Color.Aquamarine
                    MySQL.cargarTurnos()
                    Funciones.filtrarTurnos(dtTurnos)
                End If
                ButtonMarcar.Enabled = True
                ButtonMarcar.Focus()
            Else
                MessageBox.Show("Contraseña incorrecta")
                TextBoxPass.Clear()
                TextBoxPass.Focus()
            End If
        End If
    End Sub

    Private Sub TextBoxNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombre.TextChanged
        TextBoxPass.Clear()
        TextBoxPass.Enabled = True
        ButtonMarcar.Enabled = False
    End Sub

    Private Sub ButtonMarcar_Click(sender As Object, e As EventArgs) Handles ButtonMarcar.Click
        MySQL.marcarHorario()

    End Sub
End Class