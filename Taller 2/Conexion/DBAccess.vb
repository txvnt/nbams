Imports System.Data.OleDb
Imports Taller_2

Public Class DBAccess
    Implements IDB

    Private ruta As String = "C:/Access/velez_pardo.accdb"
    Private conexion As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & ruta & " ;Persist Security Info=False"

    Public Function SelectQuery(consulta As String) As DataTable Implements IDB.SelectQuery
        Dim tabla As New DataTable
        Dim adaptador As New OleDbDataAdapter(consulta, conexion)
        Try
            adaptador.Fill(tabla)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return tabla
    End Function

    Public Sub Query(consulta As String) Implements IDB.Query
        Dim tabla As New DataTable
        Try
            Dim adaptador As New OleDbDataAdapter(consulta, conexion)
            adaptador.Fill(tabla)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

End Class
