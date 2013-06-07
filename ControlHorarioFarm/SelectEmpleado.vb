Public Class SelectEmpleado

    Private Sub SelectEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 118
        For Each empleado As Entidades.Empleados In Main.empleados
            If (empleado.Nombre + " " + empleado.Apellido).Contains(Main.TextBoxNombre.Text) Then
                Dim row As New DataGridViewRow
                With row
                    .CreateCells(DataGridViewEmpleados)
                    .Cells(0).Value = empleado.ID
                    .Cells(1).Value = empleado.Nombre
                    .Cells(2).Value = empleado.Apellido
                End With
                DataGridViewEmpleados.Rows.Add(row)
            End If
        Next
    End Sub

    Private Sub DataGridViewEmpleados_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridViewEmpleados.KeyDown
        If e.KeyCode = Keys.Enter Then
            If DataGridViewEmpleados.Rows.Count > 0 Then
                Main.empleado = Main.empleados.Item(DataGridViewEmpleados.SelectedCells.Item(0).Value.ToString)
                Main.TextBoxNombre.Text = Main.empleado.Nombre + " " + Main.empleado.Apellido
                Main.SplitContainer.Panel1.Controls.Remove(Me)
                Main.TextBoxPass.Focus()
            Else
                Main.SplitContainer.Panel1.Controls.Remove(Me)
                Main.TextBoxNombre.Focus()
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            Main.SplitContainer.Panel1.Controls.Remove(Me)
        End If
    End Sub

End Class
