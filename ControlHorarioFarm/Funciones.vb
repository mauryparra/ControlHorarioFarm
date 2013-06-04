Module Funciones
    Public Function FillAutoCompleteEmpleados() As AutoCompleteStringCollection
        Dim empleadoAutoCom As New AutoCompleteStringCollection

        For Each empleado As Entidades.Empleados In MySQL.CargarEmpleados
            empleadoAutoCom.Add(empleado.Nombre + " " + empleado.Apellido)
        Next
        Return empleadoAutoCom
    End Function
End Module
