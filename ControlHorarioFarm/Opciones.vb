Public Class Opciones
    Dim sucursales As New Collection

    Private Sub Opciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        TextBoxActualPass.Clear()
        TextBoxNewPass.Clear()
        TextBoxNewPass2.Clear()
    End Sub

    Private Sub Opciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Contraseña = "" Then
            MessageBox.Show("Por favor configure una contraseña")
            TextBoxActualPass.Enabled = False
        Else
            If Not PasswordDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Close()
            End If
            TextBoxActualPass.Enabled = True
        End If
        sucursales = MySQL.CargarSuc()
        For Each suc As Entidades.Sucursales In sucursales
            ComboBoxSuc.Items.Add(suc.ID & " | " & suc.Nombre)
        Next
        If Not My.Settings.Sucursal = "" Then
            ComboBoxSuc.SelectedItem = My.Settings.Sucursal
        End If
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        If Not (TextBoxNewPass.Text = "" Or TextBoxNewPass2.Text = "") Then
            If TextBoxActualPass.Enabled = True Then
                If My.Settings.Contraseña = Encrypt(TextBoxActualPass.Text) Then
                    If TextBoxNewPass.Text = TextBoxNewPass2.Text Then
                        My.Settings.Contraseña = Encrypt(TextBoxNewPass.Text)
                        My.Settings.Sucursal = ComboBoxSuc.SelectedItem
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
                    My.Settings.Sucursal = ComboBoxSuc.SelectedItem
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
            My.Settings.Sucursal = ComboBoxSuc.SelectedItem
            My.Settings.Save()
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub
End Class