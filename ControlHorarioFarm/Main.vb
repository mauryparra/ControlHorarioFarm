Public Class Main


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        'MySQL.TestCon()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        LabelHora.Text = TimeOfDay.ToString("HH:mm:ss")
    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Application.Exit()
    End Sub
End Class
