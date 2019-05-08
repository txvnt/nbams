Public Class Jugador
    Public nombre As String
    Public apellido As String
    Public titular As Integer
    Public codEquipo As Integer
    Public posicion As String

    Public Sub New(nombre As String, apellido As String, titular As Boolean, codEquipo As Integer, posicion As String)
        Me.nombre = nombre
        Me.apellido = apellido
        Me.titular = titular
        Me.codEquipo = codEquipo
        Me.posicion = posicion
    End Sub

    Public Sub agregarJugador()
        DB.Query(String.Format("INSERT INTO Jugador([Nombre],[Apellido],[CodEquipoPertenece],[Titular],[Posicion]) 
                                VALUES ('{0}','{1}',{2},{3},'{4}')", Me.nombre, Me.apellido, Me.codEquipo, Me.titular, Me.posicion))
    End Sub

End Class
