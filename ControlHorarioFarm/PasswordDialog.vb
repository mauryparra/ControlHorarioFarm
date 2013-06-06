Imports System.Windows.Forms

Public Class PasswordDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If My.Settings.Contraseña = Encrypt(TextBoxPass.Text) Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            TextBoxPass.Clear()
            Me.Close()
        Else
            MessageBox.Show("Contraseña Incorrecta")
            TextBoxPass.Focus()
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PasswordDialog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        TextBoxPass.Clear()
    End Sub
End Class
