Public Class Main
    Public empleados As New Collection
    Public empleado As New Entidades.Empleados

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        ButtonMarcar.Enabled = False
        empleados = MySQL.CargarEmpleados()
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
        Opciones.ShowDialog()
    End Sub

    Private Sub TextBoxPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            If empleado.Pass = Encrypt(TextBoxPass.Text) Then
                cargarHistorial(DataGridViewReg)
                If DataGridViewReg.Rows.Count > 0 Then
                    If DataGridViewReg.Rows(0).Cells(0).Value = "Entrada" Then
                        ComboBoxTipo.SelectedItem = "Salida"
                    Else
                        ComboBoxTipo.SelectedItem = "Entrada"
                    End If
                Else
                    ComboBoxTipo.SelectedItem = "Entrada"
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
        ButtonMarcar.Enabled = False
    End Sub

    Private Sub ComboBoxTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTipo.SelectedIndexChanged
        If ComboBoxTipo.SelectedItem = "Entrada" Then
            ComboBoxTipo.BackColor = Color.Aquamarine
        ElseIf ComboBoxTipo.SelectedItem = "Salida" Then
            ComboBoxTipo.BackColor = Color.IndianRed
        Else
            ComboBoxTipo.BackColor = System.Drawing.SystemColors.Window
        End If
    End Sub
End Class
