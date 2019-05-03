Public Class Partido
    Public Shared Function obtenerPartidos() As DataTable
        Dim tabla = DB.SelectQuery(String.Format("SELECT * FROM Partido pa"))
        Return tabla
    End Function
End Class
