Imports System.Data.Odbc
Module MySQL
    Public con As New OdbcConnection("DSN=Horarios")
    Public com As OdbcCommand
    Public dr As OdbcDataReader

    Sub TestCon()
        Try
            con.Open()
            MessageBox.Show("Conectado")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


End Module
