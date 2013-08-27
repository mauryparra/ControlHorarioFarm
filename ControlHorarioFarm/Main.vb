Imports sntp

Public Class Main
    Public empleados As New Collection
    Public empleado As New Entidades.Empleados
    Public dtTurnos As New DataTable("Turnos")
    Public dtSucursales As New DataTable("Sucursales")

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If My.Settings.ChangeTimeMode Then
            My.Settings.InternetTime = True
            My.Settings.ChangeTimeMode = False
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        MySQL.testCon()

        ' Si se actualiza la aplicación, actualiza My.Settings con el archivo de la version anterior
        If My.Settings.UpgradeRequired Then
            My.Settings.Upgrade()
            My.Settings.UpgradeRequired = False
        End If
        SplitContainer.Panel1.BackColor = Color.White
        If My.Settings.InternetTime Then
            Me.Text = "Control Horarios Farmacias [INTERNET]"
            Try
                Funciones.Time = sntp.SntpClient.GetNetworkTime()
            Catch ex As Exception
                My.Settings.InternetTime = False
                My.Settings.ChangeTimeMode = True
                Throw New TimeoutException("Se agoto el tiempo de conexión a Internet")
            End Try
            LabelHora.Text = Funciones.Time
        Else
            Me.Text = "Control Horarios Farmacias [LOCAL]"
            LabelHora.Text = DateTime.Now.ToString("HH:mm:ss")
        End If
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
        If My.Settings.InternetTime Then
            Funciones.incrementTime()
            If Not Me.Text = "Control Horarios Farmacias [INTERNET]" Then
                Me.Text = "Control Horarios Farmacias [INTERNET]"
            End If
            LabelHora.Text = Funciones.Time
        Else
            If Not Me.Text = "Control Horarios Farmacias [LOCAL]" Then
                Me.Text = "Control Horarios Farmacias [LOCAL]"
            End If
            LabelHora.Text = TimeOfDay.ToString("HH:mm:ss")
        End If
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
                        ButtonMarcar.Text = "&Salida"
                        SplitContainer.Panel1.BackColor = Color.IndianRed
                        MySQL.cargarTurnos(DataGridViewReg.Rows(0).Cells(4).Value)
                        ComboBoxTurnos.SelectedIndex = 0

                        If Funciones.CheckSalida(DataGridViewReg) = True Then
                            MySQL.cargarHistorial(DataGridViewReg)    ' Si cerro automaticamente
                            ComboBoxTipo.SelectedItem = "Entrada"
                            ButtonMarcar.Text = "&Entrada"
                            SplitContainer.Panel1.BackColor = Color.Aquamarine
                            MySQL.cargarTurnos()
                            Funciones.filtrarTurnos(dtTurnos)
                            ComboBoxTurnos.SelectedIndex = -1
                        End If
                    Else
                        ComboBoxTipo.SelectedItem = "Entrada"
                        ButtonMarcar.Text = "&Entrada"
                        SplitContainer.Panel1.BackColor = Color.Aquamarine
                        MySQL.cargarTurnos()
                        Funciones.filtrarTurnos(dtTurnos)
                        ComboBoxTurnos.SelectedIndex = -1
                    End If
                Else
                    ComboBoxTipo.SelectedItem = "Entrada"
                    ButtonMarcar.Text = "&Entrada"
                    SplitContainer.Panel1.BackColor = Color.Aquamarine
                    MySQL.cargarTurnos()
                    Funciones.filtrarTurnos(dtTurnos)
                    ComboBoxTurnos.SelectedIndex = -1
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
        ButtonMarcar.Text = "&Marcar"
        ComboBoxTipo.SelectedIndex = -1
        ComboBoxTurnos.SelectedIndex = -1
        DataGridViewReg.Rows.Clear()
        SplitContainer.Panel1.BackColor = Color.White
    End Sub

    Private Sub ButtonMarcar_Click(sender As Object, e As EventArgs) Handles ButtonMarcar.Click
        MySQL.marcarHorario()
        Me.ClearForm()
        TextBoxNombre.Focus()
    End Sub

    Private Sub ClearForm()
        TextBoxNombre.Clear()
        TextBoxPass.Clear()
        ComboBoxTipo.ResetText()
        ComboBoxTurnos.ResetText()
        DataGridViewReg.Rows.Clear()
        ButtonMarcar.Text = "&Marcar"
        ButtonMarcar.Enabled = False
        SplitContainer.Panel1.BackColor = Color.White
    End Sub
End Class