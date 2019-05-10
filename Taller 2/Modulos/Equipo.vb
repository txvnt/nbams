Public Class Equipo

    Public id As String
    Public nombreEquipo As String
    Public ciudad As String
    Public conferencia As String
    Public rutaImagen As String
    Public victorias As Integer
    Public derrotas As Integer

    Public Sub New(nombreEquipo As String, ciudad As String, conferencia As String, rutaImagen As String, victorias As Integer, derrotas As Integer)
        Me.nombreEquipo = nombreEquipo
        Me.ciudad = ciudad
        Me.conferencia = conferencia
        Me.rutaImagen = rutaImagen
        Me.victorias = victorias
        Me.derrotas = derrotas
    End Sub

    Public Shared Function obtenerEquipo(idEquipo As Integer) As Equipo
        Dim tabla = DB.SelectQuery(String.Format("SELECT eq.Nombre,eq.Ciudad,eq.Conferencia,eq.RutaImagen,(SELECT COUNT(*) FROM Partido p WHERE (p.codLocal=eq.Id AND p.ptjeLocal>p.ptjeVisita) OR (p.codVisita=eq.Id And p.ptjeVisita>p.ptjeLocal)) AS Victorias,(SELECT COUNT(*) FROM Partido p WHERE (p.codLocal=eq.Id AND p.ptjeLocal<p.ptjeVisita) OR (p.codVisita=eq.Id AND p.ptjeVisita<p.ptjeLocal)) AS Derrotas
                                                  FROM Equipo eq
                                                  WHERE Id = {0}", idEquipo))
        If tabla.Rows.Count > 0 Then
            Dim data = tabla.Rows(0).ItemArray
            Return New Equipo(data(0), data(1), data(2), data(3), data(4), (data(5)))
        Else
            Return Nothing
        End If
    End Function

    Public Sub agregarEquipo()
        DB.Query(String.Format("INSERT INTO Equipo([Nombre],[Conferencia],[Ciudad],[RutaImagen]) 
                                VALUES ('{0}','{1}','{2}','{3}')", Me.nombreEquipo, Me.conferencia, Me.ciudad, Me.rutaImagen))
    End Sub

    Public Sub actualizarEquipo()
        DB.Query(String.Format("UPDATE Equipo SET Nombre = '{0}', Ciudad = '{1}', Conferencia = '{2}', RutaImagen = '{3}' WHERE Id={4}", Me.nombreEquipo, Me.ciudad, Me.conferencia, Me.rutaImagen, Me.id))
    End Sub

    Public Shared Function obtenerJugadoresEquipo(idEquipo As String) As DataTable
        Dim tabla = DB.SelectQuery(String.Format("SELECT Id,Nombre,Apellido,Titular,Posicion FROM Jugador j WHERE j.CodEquipoPertenece = {0}", idEquipo))
        Return tabla
    End Function

    Public Shared Function obtenerEquiposEste() As DataTable
        Dim tabla = DB.SelectQuery(String.Format("SELECT eq.Id,eq.Nombre,eq.Ciudad,(SELECT COUNT(*) FROM Partido p WHERE (p.codLocal=eq.Id AND p.ptjeLocal>p.ptjeVisita) OR (p.codVisita=eq.Id And p.ptjeVisita>p.ptjeLocal)) AS Victorias,(SELECT COUNT(*) FROM Partido p WHERE (p.codLocal=eq.Id AND p.ptjeLocal<p.ptjeVisita) OR (p.codVisita=eq.Id AND p.ptjeVisita<p.ptjeLocal)) AS Derrotas FROM Equipo eq WHERE eq.Conferencia = 'Este'"))
        Return tabla
    End Function

    Public Shared Function obtenerEquiposOeste() As DataTable
        Dim tabla = DB.SelectQuery(String.Format("SELECT eq.Id,eq.Nombre,eq.Ciudad,(SELECT COUNT(*) FROM Partido p WHERE (p.codLocal=eq.Id AND p.ptjeLocal>p.ptjeVisita) OR (p.codVisita=eq.Id And p.ptjeVisita>p.ptjeLocal)) AS Victorias,(SELECT COUNT(*) FROM Partido p WHERE (p.codLocal=eq.Id AND p.ptjeLocal<p.ptjeVisita) OR (p.codVisita=eq.Id AND p.ptjeVisita<p.ptjeLocal)) AS Derrotas FROM Equipo eq WHERE eq.Conferencia = 'Oeste'"))
        Return tabla
    End Function

    Public Shared Function obtenerTodosEquipos() As DataTable
        Return DB.SelectQuery(String.Format("SELECT e.Id,e.Nombre,e.Conferencia,e.Ciudad,(SELECT COUNT(*) FROM Partido p WHERE (p.codLocal=e.Id AND p.ptjeLocal>p.ptjeVisita) OR (p.codVisita=e.Id And p.ptjeVisita>p.ptjeLocal)) AS Victorias,(SELECT COUNT(*) FROM Partido p WHERE (p.codLocal=e.Id AND p.ptjeLocal<p.ptjeVisita) OR (p.codVisita=e.Id AND p.ptjeVisita<p.ptjeLocal)) AS Derrotas FROM Equipo e"))
    End Function

    Public Shared Function obtenerNombresEquipos() As DataTable
        Return DB.SelectQuery(String.Format("SELECT Id,Nombre From Equipo"))
    End Function
End Class
