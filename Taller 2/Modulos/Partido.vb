Public Class Partido
    Public Shared Function obtenerPartidos() As DataTable
        Dim tabla = DB.SelectQuery(String.Format("SELECT p.Dia,p.Mes,p.Año,e1.Nombre AS [Equipo local],p.ptjeLocal AS [Ptje local],p.ptjeVisita AS [Ptje visita],e2.Nombre AS [Equipo visita] FROM Partido p, Equipo e1, Equipo e2 WHERE e1.Id=p.codLocal AND e2.Id=p.codVisita"))
        Return tabla
    End Function
End Class
