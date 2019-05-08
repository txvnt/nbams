Public Class Matches

    Sub New()
        InitializeComponent()
        DataGridView1.DataSource = Partido.obtenerPartidos()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Matches_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class