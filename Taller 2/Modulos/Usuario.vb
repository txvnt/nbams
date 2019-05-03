Public Class Usuario
    Public nombreUsuario As String
    Public nombres As String
    Public apellidos As String
    Public email As String
    Public contacto As Integer
    Public password As String
    Public tipo As Boolean

    Public Sub New(nombreUsuario As String, nombres As String, apellidos As String, email As String, contacto As Integer, password As String, tipo As Boolean)
        Me.nombreUsuario = nombreUsuario
        Me.nombres = nombres
        Me.apellidos = apellidos
        Me.email = email
        Me.contacto = contacto
        Me.password = password
        Me.tipo = tipo
    End Sub

    Public Shared Function obtenerUsuario(nombreUsuario As String) As Usuario
        Dim tabla = DB.SelectQuery(String.Format("SELECT NombreUsuario,Nombres,Apellidos,Email,Contacto,Password,TipoUsuario
                                                  FROM Usuario
                                                  WHERE NombreUsuario = '{0}'", nombreUsuario))
        If tabla.Rows.Count > 0 Then
            Dim data = tabla.Rows(0).ItemArray
            Return New Usuario(data(0), data(1), data(2), data(3), data(4), data(5), data(6))
        Else
            Return Nothing
        End If
    End Function

    Public Sub insertarUsuario()
        DB.Query(String.Format("INSERT INTO Usuario([NombreUsuario],[Nombres],[Apellidos],[Email],[Contacto],[Password],[TipoUsuario]) 
                                VALUES ('{0}','{1}','{2}','{3}',{4},'{5}',0)", Me.nombreUsuario, Me.nombres, Me.apellidos, Me.email, Me.contacto, Me.password))
    End Sub
End Class
