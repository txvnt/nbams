Public Class AddPlayer

    Private equipo As Equipo
    Private teamInfoContext As TeamInfo
    Private titular As Integer

    Sub New(equipo, teamInfoContext)
        ' This call is required by the designer.
        Me.titular = 0
        InitializeComponent()
        Me.equipo = equipo
        Me.teamInfoContext = teamInfoContext
        PictureBox1.ImageLocation = equipo.rutaImagen
        DataGridView1.DataSource = equipo.obtenerJugadoresEquipo(Me.equipo.id)
        ComboBox1.Text = "Base"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombres = TextBox1.Text
        Dim apellidos = TextBox2.Text
        Dim posicion = ComboBox1.Text
        If nombres = "" Or apellidos = "" Then
            MsgBox("Rellena todos los campos.")
        Else
            Dim jugador As New Jugador(nombres, apellidos, Me.titular, Me.equipo.id, posicion)
            jugador.agregarJugador()
            teamInfoContext.actualizarEquipos()
            Me.Close()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            Me.titular = 1
        Else
            Me.titular = 0
        End If
    End Sub
End Class