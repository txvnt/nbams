Public Class Simulate

    Dim context As Home

    Sub New(context)
        InitializeComponent()
        Me.context = context
        DataGridView1.DataSource = Equipo.obtenerNombresEquipos()
        DataGridView2.DataSource = Equipo.obtenerNombresEquipos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idEquipo1 As Long = DataGridView1(0, DataGridView1.CurrentRow.Index).Value
        Dim idEquipo2 As Long = DataGridView2(0, DataGridView2.CurrentRow.Index).Value
        If idEquipo1 = idEquipo2 Then
            MsgBox("Elige 2 equipos distintos entre sí")
        Else
            Static Generator As System.Random = New System.Random()
            Dim pts1 = Generator.Next(80, 130)
            Dim pts2 = Generator.Next(80, 130)
            Dim day As Integer = Convert.ToInt32(DateTime.Now.ToString("dd"))
            Dim month As Integer = Convert.ToInt32(DateTime.Now.ToString("MM"))
            Dim year As Integer = Convert.ToInt32(DateTime.Now.ToString("yyyy"))
            Partido.agregarPartido(day, month, year, idEquipo1, idEquipo2, pts1, pts2)
            MsgBox("Partido simulado correctamente.")
            context.updateTeams()
            Me.Close()
        End If
    End Sub

    Private Sub Simulate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class