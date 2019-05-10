Public Class Partido

    Public Shared Function obtenerPartidos() As DataTable
        Dim tabla = DB.SelectQuery(String.Format("SELECT p.Dia,p.Mes,p.Año,e1.Nombre AS [Equipo local],p.ptjeLocal AS [Ptje local],p.ptjeVisita AS [Ptje visita],e2.Nombre AS [Equipo visita] FROM Partido p, Equipo e1, Equipo e2 WHERE e1.Id=p.codLocal AND e2.Id=p.codVisita"))
        Return tabla
    End Function

    Public Shared Function agregarPartido(dia As Integer, mes As Integer, year As Integer, codLocal As Integer, codVisita As Integer, ptjeLocal As Integer, ptjeVisita As Integer)
        DB.Query(String.Format("INSERT INTO Partido([Dia],[Mes],[Año],[codLocal],[codVisita],[ptjeLocal],[ptjeVisita]) 
                                VALUES ({0},{1},{2},{3},{4},{5},{6})", dia, mes, year, codLocal, codVisita, ptjeLocal, ptjeVisita))
    End Function
End Class
