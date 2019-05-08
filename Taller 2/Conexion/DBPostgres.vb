Imports Npgsql
Public Class DBPostgres
    Implements IDB
    Private conexion As String = "Server=localhost;Port=5432;Database=velez_pardo;User Id=postgres;Password=postgres"
    Private connection As New NpgsqlConnection

    Public Sub New()
        connection.ConnectionString = conexion
    End Sub

    Public Function SelectQuery(consulta As String) As DataTable Implements IDB.SelectQuery
        Try
            Dim tabla As DataTable = New DataTable()
            connection.Open()
            Dim comando As New NpgsqlCommand
            comando.CommandText = consulta
            comando.Connection = connection
            Dim adaptador As NpgsqlDataAdapter = New NpgsqlDataAdapter(comando)
            adaptador.Fill(tabla)
            connection.Close()
            Return tabla
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub Query(consulta As String) Implements IDB.Query
        Dim tabla As New DataTable
        Try
            connection.Open() 'se abre la conexión
            Dim comando As New NpgsqlCommand
            comando.CommandText = consulta
            comando.Connection = connection
            comando.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

End Class
