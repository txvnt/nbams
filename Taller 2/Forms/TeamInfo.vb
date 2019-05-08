Public Class TeamInfo

    Private equipoInfo As Equipo
    Private homeInstance As Home
    Private user As Usuario

    Sub New(idEquipo, home, usuarioLog)
        ' This call is required by the designer.
        InitializeComponent()
        user = usuarioLog
        equipoInfo = Equipo.obtenerEquipo(idEquipo)
        equipoInfo.id = idEquipo
        homeInstance = home
        ' Add any initialization after the InitializeComponent() call.
        Label5.Text = equipoInfo.conferencia
        Label6.Text = equipoInfo.ciudad
        Label2.Text = equipoInfo.nombreEquipo
        PictureBox1.ImageLocation = equipoInfo.rutaImagen
        DataGridView1.DataSource = Equipo.obtenerJugadoresEquipo(idEquipo)
        If user.tipo Then
            Button1.Visible = True
        End If
    End Sub

    'debuggin purposes
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MsgBox("XD")
        homeInstance.Close()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim addPlayer As New AddPlayer(equipoInfo, Me)
        addPlayer.Show()
    End Sub

    Public Sub actualizarEquipos()
        DataGridView1.DataSource = Equipo.obtenerJugadoresEquipo(Me.equipoInfo.id)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class