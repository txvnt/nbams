Public Class DB
    Public Shared db As IDB
    Public Shared dbUsed As Boolean
    Public Shared Function SelectQuery(consulta As String) As DataTable
        Return db.SelectQuery(consulta)

    End Function

    Public Shared Sub Query(consulta As String)
        db.Query(consulta)
    End Sub

End Class