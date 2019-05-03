Public Class Auth
    Private nombreUsuario As String
    Private password As String
    Public Shared usuarioLogeado As String = ""

    Public Sub New(nombreUsuario As String, password As String)
        Me.nombreUsuario = nombreUsuario
        Me.password = password
    End Sub

    Public Function Login() As Boolean
        Dim tabla = DB.SelectQuery(String.Format("SELECT count(*)
                                                    FROM Usuario
                                                    WHERE NombreUsuario LIKE '{0}' AND Password LIKE '{1}'", Me.nombreUsuario, Me.password))
        Return tabla.Rows(0).Item(0) > 0
    End Function
End Class
