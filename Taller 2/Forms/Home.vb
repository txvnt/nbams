Public Class Home

    Private usuarioLog As Usuario



    Sub New(nombreUsuario As String)
        ' This call is required by the designer.
        InitializeComponent()
        usuarioLog = Usuario.obtenerUsuario(nombreUsuario)
        Label1.Text = "Bienvenido " + usuarioLog.nombres
        DataGridView1.DataSource = Equipo.obtenerEquiposEste()
        DataGridView2.DataSource = Equipo.obtenerEquiposOeste()
        DataGridView3.DataSource = Equipo.obtenerTodosEquipos()
        DataGridView1.ClearSelection()
        DataGridView2.ClearSelection()
        DataGridView3.ClearSelection()
        If (usuarioLog.tipo) Then
            Button1.Visible = True
            Button2.Visible = True
            Button6.Visible = True
        End If
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim add As New Add(Me)
        add.Show()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView2.ClearSelection()
        DataGridView3.ClearSelection()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        DataGridView1.ClearSelection()
        DataGridView3.ClearSelection()
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        DataGridView1.ClearSelection()
        DataGridView2.ClearSelection()
    End Sub

    'Ver info equipo'
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If DataGridView1.SelectedRows.Count = 1 Then
            Dim idEquipo As Long = DataGridView1(0, DataGridView1.CurrentRow.Index).Value
            Dim teamInfo As New TeamInfo(idEquipo, Me, usuarioLog)
            teamInfo.Show()
        ElseIf DataGridView2.SelectedRows.Count = 1 Then
            Dim idEquipo As Long = DataGridView2(0, DataGridView2.CurrentRow.Index).Value
            Dim teamInfo As New TeamInfo(idEquipo, Me, usuarioLog)
            teamInfo.Show()
        ElseIf DataGridView3.SelectedRows.Count = 1 Then
            Dim idEquipo As Long = DataGridView3(0, DataGridView3.CurrentRow.Index).Value
            Dim teamInfo As New TeamInfo(idEquipo, Me, usuarioLog)
            teamInfo.Show()
        End If
        updateTeams()
    End Sub

    'Editar Equipo'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.SelectedRows.Count = 1 Then
            Dim idEquipo As Long = DataGridView1(0, DataGridView1.CurrentRow.Index).Value
            Dim editWindow As New Edit(idEquipo, Me)
            editWindow.Show()
        ElseIf DataGridView2.SelectedRows.Count = 1 Then
            Dim idEquipo As Long = DataGridView2(0, DataGridView2.CurrentRow.Index).Value
            Dim editWindow As New Edit(idEquipo, Me)
            editWindow.Show()
        ElseIf DataGridView3.SelectedRows.Count = 1 Then
            Dim idEquipo As Long = DataGridView3(0, DataGridView3.CurrentRow.Index).Value
            Dim editWindow As New Edit(idEquipo, Me)
            editWindow.Show()
        End If
        updateTeams()
    End Sub

    Public Sub updateTeams()
        DataGridView1.DataSource = Equipo.obtenerEquiposEste()
        DataGridView2.DataSource = Equipo.obtenerEquiposOeste()
        DataGridView3.DataSource = Equipo.obtenerTodosEquipos()
        DataGridView1.ClearSelection()
        DataGridView2.ClearSelection()
        DataGridView3.ClearSelection()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim matches As New Matches()
        matches.Show()
    End Sub
End Class