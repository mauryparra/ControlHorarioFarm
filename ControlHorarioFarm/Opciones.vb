Public Class Opciones

    Private Sub Opciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        TextBoxActualPass.Clear()
        TextBoxNewPass.Clear()
        TextBoxNewPass2.Clear()
    End Sub

    Private Sub Opciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxVersion.Text = My.Application.Info.Version.ToString

        MySQL.cargarSuc()
        ComboBoxSuc.DataSource = Main.dtSucursales.DefaultView
        ComboBoxSuc.DisplayMember = "Nombre"
        ComboBoxSuc.ValueMember = "ID"

        If Not My.Settings.Sucursal = "" Then
            ComboBoxSuc.SelectedValue = My.Settings.Sucursal
        End If
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        If Not (TextBoxNewPass.Text = "" Or TextBoxNewPass2.Text = "") Then
            If TextBoxActualPass.Enabled = True Then
                If My.Settings.Contraseña = Encrypt(TextBoxActualPass.Text) Then
                    If TextBoxNewPass.Text = TextBoxNewPass2.Text Then
                        My.Settings.Contraseña = Encrypt(TextBoxNewPass.Text)
                        My.Settings.Sucursal = ComboBoxSuc.SelectedValue
                        My.Settings.Save()
                        Me.Close()
                    Else
                        MessageBox.Show("La contraseña nueva no coincide")
                        TextBoxNewPass.Clear()
                        TextBoxNewPass2.Clear()
                        TextBoxNewPass.Focus()
                    End If
                Else
                    MessageBox.Show("La Contraseña Actual no es correcta")
                    TextBoxActualPass.Clear()
                    TextBoxActualPass.Focus()
                End If
            Else
                If TextBoxNewPass.Text = TextBoxNewPass2.Text Then
                    My.Settings.Contraseña = Encrypt(TextBoxNewPass.Text)
                    My.Settings.Sucursal = ComboBoxSuc.SelectedValue
                    My.Settings.Save()
                    Me.Close()
                Else
                    MessageBox.Show("La contraseña nueva no coincide")
                    TextBoxNewPass.Clear()
                    TextBoxNewPass2.Clear()
                    TextBoxNewPass.Focus()
                End If
            End If
        Else
            My.Settings.Sucursal = ComboBoxSuc.SelectedValue
            My.Settings.Save()
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub
End Class